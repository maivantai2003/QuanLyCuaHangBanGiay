using BUS;
using DTO;
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
    public partial class FormKichCo : Form
    {
        KichCoBUS kichCoBUS=new KichCoBUS();
        public FormKichCo()
        {
            InitializeComponent();
            formTimKiem2.txtTimKiem.TextChanged += new EventHandler(Search);
            formTimKiem2.btnTimKiem.Visible = false;
        }

        private void FormKichCo_Load(object sender, EventArgs e)
        {
            LoadData();
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
        public void LoadData()
        {
            dataGridViewKichCo.Rows.Clear();
            foreach(var i in kichCoBUS.getKichCo())
            {
                dataGridViewKichCo.Rows.Add(i.MaKichCo, i.TenKichCo);
            }
            dataGridViewKichCo.ClearSelection();
        }
        public void LoadData(string text)
        {
            dataGridViewKichCo.Rows.Clear();
            foreach (var i in kichCoBUS.TimKiemKichCo(text))
            {
                dataGridViewKichCo.Rows.Add(i.MaKichCo, i.TenKichCo);
            }
            dataGridViewKichCo.ClearSelection();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormKichCoModel model = new FormKichCoModel();
            LamMoiButtonThem(model);
            model.ShowDialog();
            LoadData();
        }
        public void LamMoiButtonThem(FormKichCoModel model)
        {
            model.lbMaKichCo.Visible=false;
            model.txtMaKichCo.Visible = false;
            model.btnSua.Visible=false;
            model.btnThem.Visible = true;
        }
        public void LamMoiButtonSua(FormKichCoModel model)
        {
            model.lbMaKichCo.Visible = true;
            model.txtMaKichCo.Visible = true;
            model.btnSua.Visible = true;
            model.btnThem.Visible = false;
        }

        private void dataGridViewKichCo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string tencot = dataGridViewKichCo.Columns[e.ColumnIndex].Name;
            if(tencot == "Sua")
            {
                FormKichCoModel model=new FormKichCoModel();
                LamMoiButtonSua(model);
                model.txtMaKichCo.Text = dataGridViewKichCo.Rows[e.RowIndex].Cells[0].Value.ToString();
                model.txtTenKichCo.Text= dataGridViewKichCo.Rows[e.RowIndex].Cells[1].Value.ToString();
                model.ShowDialog();
                LoadData();
            }
            else if (tencot == "Xoa")
            {
                if(MessageBox.Show("Bạn Có Muốn Xóa","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (kichCoBUS.XoaKichCO(Convert.ToInt32(dataGridViewKichCo.Rows[e.RowIndex].Cells[0].Value.ToString())))
                    {
                        MessageBox.Show("Xóa Thành Công");
                        LoadData();
                    }

                }
            }else if (tencot == "ChiTiet")
            {
                FormXemChiTietKichCo kichCo=new FormXemChiTietKichCo();
                kichCo.txtMaKichCo.Text= dataGridViewKichCo.Rows[e.RowIndex].Cells[0].Value.ToString();
                kichCo.txtTenKichCo.Text= dataGridViewKichCo.Rows[e.RowIndex].Cells[1].Value.ToString();
                kichCo.ShowDialog();
                dataGridViewKichCo.ClearSelection();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridViewKichCo.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcel = new Microsoft.Office.Interop.Excel.Application();
                xcel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < 3; i++)
                {
                    xcel.Cells[1, i] = dataGridViewKichCo.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridViewKichCo.Rows.Count; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        xcel.Cells[i + 2, j + 1] = dataGridViewKichCo.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcel.Columns.AutoFit();
                xcel.Visible = true;
            }
            else
            {
                MessageBox.Show("Chưa Có Thông Tin");
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
                        if (kichCoBUS.KiemTraKichCo(xlRange.Cells[xlRow, 2].Text) == false)
                        {
                            KichCo kichCo = new KichCo();
                            kichCo.TenKichCo = xlRange.Cells[xlRow, 2].Text;
                            kichCo.TrangThai = 1;
                            if (kichCoBUS.ThemKichCo(kichCo))
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
