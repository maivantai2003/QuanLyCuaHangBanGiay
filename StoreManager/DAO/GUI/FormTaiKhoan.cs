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
    public partial class FormTaiKhoan : Form
    {
        TaiKhoanBUS taiKhoanBUS=new TaiKhoanBUS();
        NhomQuyenBUS nhomQuyenBUS = new NhomQuyenBUS(); 
        NhanVienBUS nhanVienBUS = new NhanVienBUS();    
        public FormTaiKhoan()
        {
            InitializeComponent();
            formTimKiem2.txtTimKiem.TextChanged += new EventHandler(Search);
            formTimKiem2.btnTimKiem.Visible = false;
        }

        /*private void btnThem_Click(object sender, EventArgs e)
        {
            FormTaiKhoanModel model=new FormTaiKhoanModel();
            model.comboxTenNhomQuyen.DataSource = nhomQuyenBUS.DanhSachTenNhomQuyen();
            model.comboxTaiKhoan.DataSource=nhanVienBUS.DanhSachTenNhanVien();
            LamMoiButtonThem(model);
            model.ShowDialog();
            LoadData();
        }*/

        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            dataGridViewTaiKhoan.Rows.Clear();
            foreach(var i in taiKhoanBUS.getTaiKhoan())
            {
                if (i.TrangThai == 1)
                {
                    dataGridViewTaiKhoan.Rows.Add(i.MaTaiKhoan,nhomQuyenBUS.TenNhomQuyen(i.MaNhomQuyen),i.TenTaikhoan, i.MatKhau);
                }
            }
            dataGridViewTaiKhoan.ClearSelection();
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
            dataGridViewTaiKhoan.Rows.Clear();
            foreach (var i in taiKhoanBUS.TimKiemTaiKhoan(text))
            {
                if (i.TrangThai == 1)
                {
                    dataGridViewTaiKhoan.Rows.Add(i.MaTaiKhoan, nhomQuyenBUS.TenNhomQuyen(i.MaNhomQuyen), i.TenTaikhoan,i.MatKhau);
                }
            }
            dataGridViewTaiKhoan.ClearSelection();
        }
        public void LamMoiButtonSua(FormTaiKhoanModel model)
        {
            /*model.lbMaTaiKhoan.Visible = true;
            model.comboxTaiKhoan.Visible = true;*/
            model.btnThem.Visible = false;
            model.btnSua.Visible = true;
        }
        public void LamMoiButtonThem(FormTaiKhoanModel model)
        {
            /*model.lbMaTaiKhoan.Visible = false;
            model.comboxTaiKhoan.Visible = false;*/
            model.btnThem.Visible = true;
            model.btnSua.Visible = false;
        }

        private void dataGridViewTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string tencot = dataGridViewTaiKhoan.Columns[e.ColumnIndex].Name;
            if (tencot == "Sua")
            {
                FormTaiKhoanModel model = new FormTaiKhoanModel();
                LamMoiButtonSua(model);
                model.txtMatKhau.Text = dataGridViewTaiKhoan.Rows[e.RowIndex].Cells[3].Value.ToString();
                model.txtTenTaiKhoan.Text = dataGridViewTaiKhoan.Rows[e.RowIndex].Cells[2].Value.ToString();
                model.comboxTaiKhoan.Text = dataGridViewTaiKhoan.Rows[e.RowIndex].Cells[0].Value.ToString();
                model.comboxTenNhomQuyen.DataSource = nhomQuyenBUS.DanhSachTenNhomQuyen();
                model.comboxTenNhomQuyen.SelectedItem = nhomQuyenBUS.MaNhomQuyen(dataGridViewTaiKhoan.Rows[e.RowIndex].Cells[1].Value.ToString()) +"-"+ dataGridViewTaiKhoan.Rows[e.RowIndex].Cells[1].Value.ToString();
                model.ShowDialog();
                LoadData();
                
            }
            else if (tencot == "Xoa")
            {
                if (dataGridViewTaiKhoan.Rows[e.RowIndex].Cells[1].Value.ToString()=="Admin")
                {
                    MessageBox.Show("Đây là tài khoản Admin không được xóa");
                    dataGridViewTaiKhoan.ClearSelection();
                }
                else
                {
                    if (MessageBox.Show("Thông Báo", "Bạn Có Muốn Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (taiKhoanBUS.XoaTaiKhoan(Convert.ToInt32(dataGridViewTaiKhoan.Rows[e.RowIndex].Cells[0].Value.ToString())))
                        {
                            MessageBox.Show("Xóa Thành Công");
                            LoadData();
                        }

                    }
                }
                
            }else if(tencot == "ChiTiet")
            {
                FormXemChiTietTaiKhoan chitiettaikhoan=new FormXemChiTietTaiKhoan();
                chitiettaikhoan.txtMaTaiKhoan.Text= dataGridViewTaiKhoan.Rows[e.RowIndex].Cells[0].Value.ToString();
                chitiettaikhoan.txtTenNhomQuyen.Text= dataGridViewTaiKhoan.Rows[e.RowIndex].Cells[1].Value.ToString();
                chitiettaikhoan.txtTenTaiKhoan.Text= dataGridViewTaiKhoan.Rows[e.RowIndex].Cells[2].Value.ToString();
                chitiettaikhoan.txtMatKhau.Text= dataGridViewTaiKhoan.Rows[e.RowIndex].Cells[3].Value.ToString();
                chitiettaikhoan.ShowDialog();
                dataGridViewTaiKhoan.ClearSelection();
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            FormTaiKhoanModel model = new FormTaiKhoanModel();
            model.comboxTenNhomQuyen.DataSource = nhomQuyenBUS.DanhSachTenNhomQuyen();
            model.comboxTaiKhoan.DataSource = nhanVienBUS.DanhSachTenNhanVien();
            LamMoiButtonThem(model);
            model.ShowDialog();
            LoadData();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridViewTaiKhoan.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcel = new Microsoft.Office.Interop.Excel.Application();
                xcel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < 5; i++)
                {
                    xcel.Cells[1, i] = dataGridViewTaiKhoan.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridViewTaiKhoan.Rows.Count; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        xcel.Cells[i + 2, j + 1] = dataGridViewTaiKhoan.Rows[i].Cells[j].Value.ToString();
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
                        if (taiKhoanBUS.KiemTraTaiKhoan(Convert.ToInt32(xlRange.Cells[xlRow, 1].Text)) == false)
                        {
                            TaiKhoan taiKhoan = new TaiKhoan();
                            taiKhoan.TrangThai = 1;
                            taiKhoan.MaTaiKhoan =Convert.ToInt32(xlRange.Cells[xlRow, 1].Text);
                            taiKhoan.MaNhomQuyen=nhomQuyenBUS.MaNhomQuyen(xlRange.Cells[xlRow, 2].Text);
                            taiKhoan.TenTaikhoan = xlRange.Cells[xlRow, 3].Text;
                            taiKhoan.MatKhau = xlRange.Cells[xlRow, 4].Text;
                            MessageBox.Show(taiKhoan.MaTaiKhoan + "--" + taiKhoan.MaNhomQuyen);
                            if (taiKhoanBUS.ThemTaiKhoan(taiKhoan))
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
