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
    public partial class FormMauSac : Form
    {
        MauSacBUS mauSacBUS=new MauSacBUS();
        public FormMauSac()
        {
            InitializeComponent();
            formTimKiem2.txtTimKiem.TextChanged += new EventHandler(Search);
            formTimKiem2.btnTimKiem.Visible= false;
        }

        private void FormMauSac_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void Search(object sender, EventArgs e)
        {
            if(formTimKiem2.txtTimKiem.Text==" " || formTimKiem2.txtTimKiem.Text == "")
            {
                formTimKiem2.btnTimKiem.Visible=false;
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
            dataGridViewMauSac.Rows.Clear();
            foreach(var i in mauSacBUS.getMauSac())
            {
                dataGridViewMauSac.Rows.Add(i.MaMau, i.TenMau);
            }
            dataGridViewMauSac.ClearSelection();
        }
        public void LoadData(string text)
        {
            dataGridViewMauSac.Rows.Clear();
            foreach (var i in mauSacBUS.TimKiemMauSac(text))
            {
                dataGridViewMauSac.Rows.Add(i.MaMau, i.TenMau);
            }
            dataGridViewMauSac.ClearSelection();
        }
        public void LamMoiButtonThem(FormMauSacModel model)
        {
            model.lbMaMau.Visible=false;
            model.txtMaMauSac.Visible=false;   
            model.btnSua.Visible=false;
            model.btnThem.Visible=true;
        }
        public void LamMoiButtonSua(FormMauSacModel model)
        {
            model.lbMaMau.Visible = true;
            model.txtMaMauSac.Visible = true;
            model.btnSua.Visible = true;
            model.btnThem.Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormMauSacModel model=new FormMauSacModel();
            LamMoiButtonThem(model);
            model.ShowDialog();
            LoadData();
        }

        private void dataGridViewMauSac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string tencot = dataGridViewMauSac.Columns[e.ColumnIndex].Name;
            if(tencot == "Sua")
            {
                FormMauSacModel model = new FormMauSacModel();
                LamMoiButtonSua(model);
                model.txtMaMauSac.Text = dataGridViewMauSac.Rows[e.RowIndex].Cells[0].Value.ToString();
                model.txtTenMauSac.Text = dataGridViewMauSac.Rows[e.RowIndex].Cells[1].Value.ToString();
                model.ShowDialog();
                LoadData();
            }else if(tencot == "Xoa")
            {
                if (MessageBox.Show("Bạn Có Muốn Xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (mauSacBUS.XoaMau(Convert.ToInt32(dataGridViewMauSac.Rows[e.RowIndex].Cells[0].Value.ToString())))
                    {
                        MessageBox.Show("Xóa Thành Công");
                        LoadData();
                    }
                }
            }else if (tencot == "ChiTiet")
            {
                FormXemChiTietMauSac mauSac=new FormXemChiTietMauSac();
                mauSac.txtMaMauSac.Text= dataGridViewMauSac.Rows[e.RowIndex].Cells[0].Value.ToString();
                mauSac.txtTenMauSac.Text= dataGridViewMauSac.Rows[e.RowIndex].Cells[1].Value.ToString();
                mauSac.ShowDialog();
                dataGridViewMauSac.ClearSelection();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridViewMauSac.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcel = new Microsoft.Office.Interop.Excel.Application();
                xcel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < 3; i++)
                {
                    xcel.Cells[1, i] = dataGridViewMauSac.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridViewMauSac.Rows.Count; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        xcel.Cells[i + 2, j + 1] = dataGridViewMauSac.Rows[i].Cells[j].Value.ToString();
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
                        if (mauSacBUS.KiemTraMauSac(xlRange.Cells[xlRow, 2].Text) == false)
                        {
                            MauSac mauSac = new MauSac();
                            mauSac.TenMau = xlRange.Cells[xlRow, 2].Text;
                            mauSac.TrangThai = 1;
                            if (mauSacBUS.ThemMau(mauSac))
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
