using BUS;
using DTO;
using GUI.KIEMTRA;
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
    public partial class FormNhaCungCap : Form
    {
        NhaCungCapBUS nhaCungCapBUS=new NhaCungCapBUS();
        public FormNhaCungCap()
        {
            InitializeComponent();
            formTimKiem2.txtTimKiem.TextChanged += new EventHandler(Search);
            formTimKiem2.btnTimKiem.Visible = false;
        }
        public void LoadData()
        {
            dataGridViewNhaCungCap.Rows.Clear();
            foreach(var i in nhaCungCapBUS.getNhaCungCap())
            {
                dataGridViewNhaCungCap.Rows.Add(i.MaNhaCungCap,i.TenNhaCungCap,i.DiaChi,i.SoDienThoai);
            }
            dataGridViewNhaCungCap.ClearSelection();
        }
        public void LoadData(string text)
        {
            dataGridViewNhaCungCap.Rows.Clear();
            foreach (var i in nhaCungCapBUS.TimKiemNhaCungCap(text))
            {
                dataGridViewNhaCungCap.Rows.Add(i.MaNhaCungCap, i.TenNhaCungCap, i.DiaChi, i.SoDienThoai);
            }
            dataGridViewNhaCungCap.ClearSelection();
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
        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormNhaCungCapModel model=new FormNhaCungCapModel();
            LamMoiButtonThem(model);
            model.ShowDialog();
            LoadData();

        }
        public void LamMoiButtonThem(FormNhaCungCapModel model)
        {
            model.lbMaChucNang.Visible=false;
            model.txtMaNhaCungCap.Visible=false;
            model.btnSua.Visible=false;
            model.btnThem.Visible=true;
        }
        public void LamMoiButtonSua(FormNhaCungCapModel model)
        {
            model.lbMaChucNang.Visible = true;
            model.txtMaNhaCungCap.Visible = true;
            model.btnSua.Visible = true;
            model.btnThem.Visible = false;
        }

        private void dataGridViewNhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string tencot = dataGridViewNhaCungCap.Columns[e.ColumnIndex].Name;
            if(tencot == "Sua")
            {
                FormNhaCungCapModel model=new FormNhaCungCapModel();
                LamMoiButtonSua(model);
                model.txtMaNhaCungCap.Text = dataGridViewNhaCungCap.Rows[e.RowIndex].Cells[0].Value.ToString();
                model.txtTenNhaCungCap.Text= dataGridViewNhaCungCap.Rows[e.RowIndex].Cells[1].Value.ToString();
                model.txtDiaChi.Text= dataGridViewNhaCungCap.Rows[e.RowIndex].Cells[2].Value.ToString();
                model.txtSDT.Text= dataGridViewNhaCungCap.Rows[e.RowIndex].Cells[3].Value.ToString();
                model.ShowDialog();
                LoadData();
            }else if(tencot == "Xoa")
            {
                if (MessageBox.Show("Bạn Có Muốn Xóa","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    if (nhaCungCapBUS.XoaNhaCungCap(Convert.ToInt32(dataGridViewNhaCungCap.Rows[e.RowIndex].Cells[0].Value.ToString())))
                    {
                        MessageBox.Show("Xóa Thành Công");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa Thất Bại");
                        return;
                    }
                }
            }else if(tencot == "ChiTiet")
            {
                FormXemChiTietNhaCungCap nhaCungCap=new FormXemChiTietNhaCungCap();
                nhaCungCap.txtMaNhaCungCap.Text = dataGridViewNhaCungCap.Rows[e.RowIndex].Cells[0].Value.ToString();
                nhaCungCap.txtTenNhaCungCap.Text= dataGridViewNhaCungCap.Rows[e.RowIndex].Cells[1].Value.ToString();
                nhaCungCap.txtDiaChi.Text= dataGridViewNhaCungCap.Rows[e.RowIndex].Cells[2].Value.ToString();
                nhaCungCap.txtSoDienThoai.Text= dataGridViewNhaCungCap.Rows[e.RowIndex].Cells[3].Value.ToString();
                nhaCungCap.ShowDialog();
                dataGridViewNhaCungCap.ClearSelection();
            }
            
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridViewNhaCungCap.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcel = new Microsoft.Office.Interop.Excel.Application();
                xcel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < 5; i++)
                {
                    xcel.Cells[1, i] = dataGridViewNhaCungCap.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridViewNhaCungCap.Rows.Count; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        xcel.Cells[i + 2, j + 1] = dataGridViewNhaCungCap.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcel.Columns.AutoFit();
                xcel.Visible = true;
            }
            else
            {
                MessageBox.Show("Chưa Có Dữ Liệu");
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
                        if (nhaCungCapBUS.KiemTraNhaCungCap(xlRange.Cells[xlRow, 2].Text, xlRange.Cells[xlRow, 4].Text) == false && KiemTraLoi.KiemTraSoDienThoai(xlRange.Cells[xlRow, 4].Text)==false)
                        {
                           
                            NhaCungCap nhaCungCap=new NhaCungCap();
                            nhaCungCap.TenNhaCungCap= xlRange.Cells[xlRow, 2].Text;
                            nhaCungCap.DiaChi= xlRange.Cells[xlRow,3].Text;
                            nhaCungCap.SoDienThoai= xlRange.Cells[xlRow, 4].Text;
                            nhaCungCap.TrangThai = 1;
                            if (nhaCungCapBUS.ThemNhaCungCap(nhaCungCap))
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
