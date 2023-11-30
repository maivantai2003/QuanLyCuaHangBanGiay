using BUS;
using DTO;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormChucNang : Form
    {
        ChucNangBUS chucNangBUS=new ChucNangBUS();
        public FormChucNang()
        {
            InitializeComponent();
            formTimKiem1.txtTimKiem.TextChanged += new EventHandler(Search);
            formTimKiem1.btnTimKiem.Visible = false;

        }
        private void Search(object sender, EventArgs e)
        {
            if (formTimKiem1.txtTimKiem.Text == " " || formTimKiem1.txtTimKiem.Text == "")
            {
                formTimKiem1.btnTimKiem.Visible = false;
                LoadData();
            }
            else
            {
                formTimKiem1.btnTimKiem.Visible = true;
                LoadData(formTimKiem1.txtTimKiem.Text);
            }
        }
        private void FormChucNang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        /*private void btnThem_Click(object sender, EventArgs e)
        {
            FormChucNangModel model = new FormChucNangModel();
            LamMoiButtonThem(model);
            model.ShowDialog();
            LoadData();
        }*/
        public void LamMoiButtonSua(FormChucNangModel model)
        {
            model.txtMaChucNang.Visible = true;
            model.lbMaChucNang.Visible = true;
            model.btnThem.Visible = false;
            model.btnSua.Visible = true;
        }
        public void LamMoiButtonThem(FormChucNangModel model)
        {
            model.txtMaChucNang.Visible = false;
            model.lbMaChucNang.Visible = false;
            model.btnThem.Visible = true;
            model.btnSua.Visible = false;
        }
        public void LoadData()
        {
            dataGridViewChucNang.Rows.Clear();
            foreach(var i in chucNangBUS.getChucNang())
            {
                if (i.TrangThai==1)
                {
                    dataGridViewChucNang.Rows.Add(i.MaChucNang, i.TenChucNang);
                }
                
            }
            dataGridViewChucNang.ClearSelection();
        }
        public void LoadData(string text)
        {
            dataGridViewChucNang.Rows.Clear();
            foreach (var i in chucNangBUS.TimKiemChucNang(text))
            {
                if (i.TrangThai == 1)
                {
                    dataGridViewChucNang.Rows.Add(i.MaChucNang, i.TenChucNang);
                }

            }
            dataGridViewChucNang.ClearSelection();

        } 

        private void dataGridViewChucNang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string tencot = dataGridViewChucNang.Columns[e.ColumnIndex].Name;
            if (tencot == "Sua")
            {
                FormChucNangModel model = new FormChucNangModel();
                LamMoiButtonSua(model);
                model.txtMaChucNang.Text = dataGridViewChucNang.Rows[e.RowIndex].Cells[0].Value.ToString();
                model.txtTenChucNang.Text = dataGridViewChucNang.Rows[e.RowIndex].Cells[1].Value.ToString();
                model.ShowDialog();
                LoadData();
            }
            else if (tencot == "Xoa")
            {
               
                if (MessageBox.Show("Thông Báo","Bạn Có Muốn Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (chucNangBUS.XoaChucNang(Convert.ToInt32(dataGridViewChucNang.Rows[e.RowIndex].Cells[0].Value.ToString())))
                    {
                        MessageBox.Show("Xóa Thành Công");
                        LoadData();
                    }
                     
                }
            }
            else if (tencot == "ChiTiet")
            {
                FormXemChiTietChucNang chitietchucnang=new FormXemChiTietChucNang();
                chitietchucnang.txtMaChucNang.Text = dataGridViewChucNang.Rows[e.RowIndex].Cells[0].Value.ToString();
                chitietchucnang.txtTenChucNang.Text = dataGridViewChucNang.Rows[e.RowIndex].Cells[1].Value.ToString();
                chitietchucnang.ShowDialog();
                dataGridViewChucNang.ClearSelection();

            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            FormChucNangModel model = new FormChucNangModel();
            LamMoiButtonThem(model);
            model.ShowDialog();
            LoadData();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridViewChucNang.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcel = new Microsoft.Office.Interop.Excel.Application();
                xcel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < 3; i++)
                {
                    xcel.Cells[1, i] = dataGridViewChucNang.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridViewChucNang.Rows.Count; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        xcel.Cells[i + 2, j + 1] = dataGridViewChucNang.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcel.Columns.AutoFit();
                xcel.Visible = true;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlBook;
            Microsoft.Office.Interop.Excel.Worksheet xlSheet;
            Microsoft.Office.Interop.Excel.Range xlRange;
            int xlRow;
            string tenFile;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tenFile = openFileDialog1.FileName;
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlBook = xlApp.Workbooks.Open(tenFile);
                xlSheet = xlBook.Worksheets["Sheet1"];
                xlRange = xlSheet.UsedRange;

                for (xlRow = 2; xlRow <= xlRange.Rows.Count; xlRow++)
                {
                    if (xlRange.Cells[xlRow, 1].Text != "")
                    {
                        if (chucNangBUS.KiemTraChucNang(xlRange.Cells[xlRow, 2].Text) == false)
                        {
                            ChucNang chucNang = new ChucNang();
                            chucNang.TenChucNang = xlRange.Cells[xlRow, 2].Text;
                            chucNang.TrangThai = 1;
                            if (chucNangBUS.ThemChucNang(chucNang))
                            {

                            }
                        }

                    }

                }
                LoadData();
                xlBook.Close();
                xlApp.Quit();
            }
        }
    }
}
