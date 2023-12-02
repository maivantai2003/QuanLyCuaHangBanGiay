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
    public partial class FormThuongHieu : Form
    {
        ThuongHieuBUS thuongHieuBUS = new ThuongHieuBUS();
        public FormThuongHieu()
        {
            InitializeComponent();
            formTimKiem2.txtTimKiem.TextChanged += new EventHandler(Search);
            formTimKiem2.btnTimKiem.Visible = false;
            
        }

        private void dataGridViewChucNang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string tencot =dataGridViewThuongHieu.Columns[e.ColumnIndex].Name;
            if (tencot == "Sua")
            {
                FormThuongHieuModel model=new FormThuongHieuModel();
                model.txtMaThuongHieu.Text = dataGridViewThuongHieu.Rows[e.RowIndex].Cells[0].Value.ToString();
                model.txtTenThuongHieu.Text= dataGridViewThuongHieu.Rows[e.RowIndex].Cells[1].Value.ToString();
                LamMoiButtonSua(model);
                model.ShowDialog();
                LoadData();
                
            }
            else if (tencot == "Xoa")
            {
                if (MessageBox.Show("Bạn Có Muốn Xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (thuongHieuBUS.XoaThuongHieu(Convert.ToInt32(dataGridViewThuongHieu.Rows[e.RowIndex].Cells[0].Value.ToString())))
                    {
                        MessageBox.Show("Xóa Thành Công");
                        LoadData();
                    }
                }
            }
            else if (tencot == "ChiTiet")
            {
                FormXemChiTietThuongHieu thuongHieu=new FormXemChiTietThuongHieu();
                thuongHieu.txtMaThuongHieu.Text = dataGridViewThuongHieu.Rows[e.RowIndex].Cells[0].Value.ToString();
                thuongHieu.txtTenThuongHieu.Text= dataGridViewThuongHieu.Rows[e.RowIndex].Cells[1].Value.ToString();
                thuongHieu.ShowDialog();
                dataGridViewThuongHieu.ClearSelection();
            }
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
            dataGridViewThuongHieu.Rows.Clear();
            foreach (var i in thuongHieuBUS.getThuongHieuList())
            {
                if (i.TrangThai == 1)
                {
                    dataGridViewThuongHieu.Rows.Add(i.MaThuongHieu, i.TenThuongHieu);
                }

            }
            dataGridViewThuongHieu.ClearSelection();
        }
        public void LoadData(string text)
        {
            dataGridViewThuongHieu.Rows.Clear();
            foreach (var i in thuongHieuBUS.TimKiemThuongHieu(text))
            {
                if (i.TrangThai == 1)
                {
                    dataGridViewThuongHieu.Rows.Add(i.MaThuongHieu, i.TenThuongHieu);
                }

            }
            dataGridViewThuongHieu.ClearSelection();
        }

        private void FormThuongHieu_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LamMoiButtonThem(FormThuongHieuModel model)
        {
            model.btnThem.Visible = true;
            model.lbMaChucNang.Visible = false;
            model.txtMaThuongHieu.Visible = false;
            model.btnSua.Visible = false;
        }
        public void LamMoiButtonSua(FormThuongHieuModel model)
        {
            model.btnThem.Visible = false;
            model.lbMaChucNang.Visible = true;
            model.txtMaThuongHieu.Visible = true;
            model.btnSua.Visible = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThuongHieuModel model = new FormThuongHieuModel();
            LamMoiButtonThem(model);
            model.ShowDialog();
            LoadData();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridViewThuongHieu.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcel = new Microsoft.Office.Interop.Excel.Application();
                xcel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < 3; i++)
                {
                    xcel.Cells[1, i] = dataGridViewThuongHieu.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridViewThuongHieu.Rows.Count; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        xcel.Cells[i + 2, j + 1] = dataGridViewThuongHieu.Rows[i].Cells[j].Value.ToString();
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
                        if (thuongHieuBUS.KiemTraThuongHieu(xlRange.Cells[xlRow, 2].Text) == false)
                        {
                            ThuongHieu thuongHieu = new ThuongHieu();
                            thuongHieu.TenThuongHieu = xlRange.Cells[xlRow, 2].Text;
                            thuongHieu.TrangThai = 1;
                            if (thuongHieuBUS.ThemThuongHieu(thuongHieu))
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
