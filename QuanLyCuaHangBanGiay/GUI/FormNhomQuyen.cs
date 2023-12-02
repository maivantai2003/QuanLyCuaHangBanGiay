using BUS;
using DTO;
using Microsoft.Office.Interop.Excel;
using System;
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
    public partial class FormNhomQuyen : Form
    {
        NhomQuyenBUS nhomQuyenBUS = new NhomQuyenBUS();
        public FormNhomQuyen()
        {
            InitializeComponent();
            formTimKiem2.txtTimKiem.TextChanged += new EventHandler(Search);
            formTimKiem2.btnTimKiem.Visible = false;

        }
        public void LoadData()
        {
            dataGridViewNhomQuyen.Rows.Clear();
            foreach(var i in nhomQuyenBUS.getNhomQuyen())
            {
                dataGridViewNhomQuyen.Rows.Add(i.MaNhomQuyen, i.TenNhomQuyen);
            }
            dataGridViewNhomQuyen.ClearSelection();
        }
        public void Search(object sender, EventArgs e)
        {
            if (formTimKiem2.txtTimKiem.Text == " " || formTimKiem2.txtTimKiem.Text == "")
            {
                formTimKiem2.btnTimKiem.Visible = false;
                LoadData();
            }
            else
            {
                formTimKiem2.btnTimKiem.Visible = true;
                LoadData(formTimKiem2.txtTimKiem.Text);
            }
        }
        public void LoadData(string text)
        {
            dataGridViewNhomQuyen.Rows.Clear();
            foreach (var i in nhomQuyenBUS.TimKiemNhomQuyen(text))
            {
                dataGridViewNhomQuyen.Rows.Add(i.MaNhomQuyen, i.TenNhomQuyen);
                
            }
            dataGridViewNhomQuyen.ClearSelection();
        }
        private void Seach(object sender, EventArgs e)
        {
            
        }
      
        public void LamMoiButtonSua(FormNhomQuyenModel model)
        {
            model.txtMaNhomQuyen.Visible = true;
            model.lbMaNhomQuyen.Visible = true;
            model.btnThem.Visible = false;
            model.btnSua.Visible = true;
        }
        public void LamMoiButtonThem(FormNhomQuyenModel model)
        {
            model.txtMaNhomQuyen.Visible = false;
            model.lbMaNhomQuyen.Visible = false;
            model.btnThem.Visible = true;
            model.btnSua.Visible = false;
        }

        private void dataGridViewNhomQuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string tencot = dataGridViewNhomQuyen.Columns[e.ColumnIndex].Name;
            if (tencot == "Sua")
            {
                FormNhomQuyenModel model = new FormNhomQuyenModel();
                model.txtMaNhomQuyen.Text = dataGridViewNhomQuyen.Rows[e.RowIndex].Cells[0].Value.ToString();
                model.txtTenNhomQuyen.Text = dataGridViewNhomQuyen.Rows[e.RowIndex].Cells[1].Value.ToString();
                LamMoiButtonSua(model);
                model.ShowDialog();
                LoadData();
               
            }
            else if (tencot == "Xoa")
            {
                if (MessageBox.Show("Thông Báo", "Bạn Có Muốn Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (nhomQuyenBUS.XoaNhomQuyen(Convert.ToInt32(dataGridViewNhomQuyen.Rows[e.RowIndex].Cells[0].Value.ToString())))
                    {
                        MessageBox.Show("Xóa Thành Công");
                        LoadData();
                    }

                }
            }
            else if(tencot =="ChiTiet")
            {
                FormXemChiTietNhomQuyen chitietnhomquyen=new FormXemChiTietNhomQuyen();
                chitietnhomquyen.txtMaNhomQuyen.Text= dataGridViewNhomQuyen.Rows[e.RowIndex].Cells[0].Value.ToString();
                chitietnhomquyen.txtTenNhomQuyen.Text = dataGridViewNhomQuyen.Rows[e.RowIndex].Cells[1].Value.ToString();
                chitietnhomquyen.ShowDialog();
                dataGridViewNhomQuyen.ClearSelection();
            }
        }

        private void FormNhomQuyen_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            FormNhomQuyenModel formNhomQuyen = new FormNhomQuyenModel();
            LamMoiButtonThem(formNhomQuyen);
            formNhomQuyen.ShowDialog();
            LoadData();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridViewNhomQuyen.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcel = new Microsoft.Office.Interop.Excel.Application();
                xcel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < 3; i++)
                {
                    xcel.Cells[1, i] = dataGridViewNhomQuyen.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridViewNhomQuyen.Rows.Count; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        xcel.Cells[i + 2, j + 1] = dataGridViewNhomQuyen.Rows[i].Cells[j].Value.ToString();
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
                        if (nhomQuyenBUS.KiemTraNhomQuyen(xlRange.Cells[xlRow, 2].Text) == false)
                        {
                            NhomQuyen nhomQuyen = new NhomQuyen();
                            nhomQuyen.TenNhomQuyen = xlRange.Cells[xlRow, 2].Text;
                            nhomQuyen.TrangThai = 1;
                            if (nhomQuyenBUS.ThemNhomQuyen(nhomQuyen))
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
