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
    public partial class FormTheLoai : Form
    {
        TheLoaiBUS theLoaiBUS=new TheLoaiBUS();
        public FormTheLoai()
        {
            InitializeComponent();
            formTimKiem2.btnTimKiem.Visible = false;
            formTimKiem2.txtTimKiem.TextChanged += new EventHandler(Search);
        }

        private void FormTheLoai_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void Search(object sender, EventArgs e)
        {
            if (formTimKiem2.txtTimKiem.Text=="" || formTimKiem2.txtTimKiem.Text == " ")
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
            dataGridViewTheLoai.Rows.Clear();
            foreach(var i in theLoaiBUS.getTheLoai())
            {
                if (i.TrangThai == 1)
                {
                    dataGridViewTheLoai.Rows.Add(i.MaTheLoai,i.TenTheLoai);
                }
            }
            dataGridViewTheLoai.ClearSelection();
        }
        public void LoadData(string text)
        {
            dataGridViewTheLoai.Rows.Clear();
            foreach (var i in theLoaiBUS.TimKiemTheLoai(text))
            {
                if (i.TrangThai == 1)
                {
                    dataGridViewTheLoai.Rows.Add(i.MaTheLoai, i.TenTheLoai);
                }
            }
            dataGridViewTheLoai.ClearSelection();
        }
        public void LamMoiButtonThem(FormTheLoaiModel model)
        {
            model.lbMaTheLoai.Visible = false;
            model.txtMaTheLoai.Visible = false;
            model.btnThem.Visible = true;
            model.btnSua.Visible = false;
          
        }
        public void LamMoiButtonSua(FormTheLoaiModel model)
        {
            model.lbMaTheLoai.Visible = true;
            model.txtMaTheLoai.Visible = true;
            model.btnThem.Visible = false;
            model.btnSua.Visible = true;

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            FormTheLoaiModel model = new FormTheLoaiModel();
            LamMoiButtonThem(model);
            model.ShowDialog();
            LoadData();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridViewTheLoai.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcel = new Microsoft.Office.Interop.Excel.Application();
                xcel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < 3; i++)
                {
                    xcel.Cells[1, i] = dataGridViewTheLoai.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridViewTheLoai.Rows.Count; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        xcel.Cells[i + 2, j + 1] = dataGridViewTheLoai.Rows[i].Cells[j].Value.ToString();
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

        private void dataGridViewTheLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string tencot = dataGridViewTheLoai.Columns[e.ColumnIndex].Name;
            if (tencot == "Sua")
            {
                FormTheLoaiModel model = new FormTheLoaiModel();
                model.txtMaTheLoai.Text = dataGridViewTheLoai.Rows[e.RowIndex].Cells[0].Value.ToString();
                model.txtTenTheLoai.Text= dataGridViewTheLoai.Rows[e.RowIndex].Cells[1].Value.ToString();
                LamMoiButtonSua(model);
                model.ShowDialog();
                LoadData();
            }
            else if (tencot == "Xoa")
            {
                if (MessageBox.Show("Bạn Có Muốn Xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (theLoaiBUS.XoaTheLoai(Convert.ToInt32(dataGridViewTheLoai.Rows[e.RowIndex].Cells[0].Value.ToString())))
                    {
                        MessageBox.Show("Xóa Thành Công");
                        LoadData();
                    }
                }
            }else if (tencot == "ChiTiet")
            {
                FormXemChiTietTheLoai chitiettheloai=new FormXemChiTietTheLoai();
                chitiettheloai.txtMaTheLoai.Text= dataGridViewTheLoai.Rows[e.RowIndex].Cells[0].Value.ToString();
                chitiettheloai.txtTenTheLoai.Text= dataGridViewTheLoai.Rows[e.RowIndex].Cells[1].Value.ToString();
                chitiettheloai.ShowDialog();
                dataGridViewTheLoai.ClearSelection();
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
                        if (theLoaiBUS.KiemTraTheLoai(xlRange.Cells[xlRow, 2].Text) == false)
                        {
                            TheLoai theLoai = new TheLoai();
                            theLoai.TenTheLoai = xlRange.Cells[xlRow, 2].Text;
                            theLoai.TrangThai = 1;
                            if (theLoaiBUS.ThemTheLoai(theLoai))
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
