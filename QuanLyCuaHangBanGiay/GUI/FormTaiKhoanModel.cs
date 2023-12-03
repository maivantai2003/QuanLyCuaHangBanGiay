using BUS;
using DTO;
using GUI.KIEMTRA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormTaiKhoanModel : Form
    {
        TaiKhoanBUS taiKhoanBUS=new TaiKhoanBUS();
        NhomQuyenBUS nhomQuyenBUS = new NhomQuyenBUS();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
    int nLeftRect,     // x-coordinate of upper-left corner
    int nTopRect,      // y-coordinate of upper-left corner
    int nRightRect,    // x-coordinate of lower-right corner
    int nBottomRect,   // y-coordinate of lower-right corner
    int nWidthEllipse, // height of ellipse
    int nHeightEllipse // width of ellipse
);
        public FormTaiKhoanModel()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void FormTaiKhoanModel_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                    TaiKhoan taikhoan = new TaiKhoan();
                    taikhoan.MatKhau = txtMatKhau.Text;
                    taikhoan.MaTaiKhoan = Convert.ToInt32(comboxTaiKhoan.Text.Split('-')[0]);
                    taikhoan.TenTaikhoan = txtTenTaiKhoan.Text;
                    taikhoan.MaNhomQuyen = Convert.ToInt32(comboxTenNhomQuyen.Text.Split('-')[0]);
                    taikhoan.TrangThai = 1;
                    if (KiemTraLoi.KiemTraRong(txtMatKhau.Text) || KiemTraLoi.KiemTraRong(txtMatKhau.Text))
                    {
                        MessageBox.Show("Vui Lòng Nhâp");
                    }
                    else
                    {
                        if (taiKhoanBUS.KiemTraTaiKhoan(taikhoan.MaTaiKhoan) || taiKhoanBUS.KiemTraTenTaiKhoan(txtTenTaiKhoan.Text))
                        {
                            MessageBox.Show("Tài Khoản Đã Tồn Tại");
                        }
                        else
                        {
                            if (taiKhoanBUS.ThemTaiKhoan(taikhoan))
                            {
                                LichSuHoatDong.LichSu(FormMain.MaTaiKhoan, "Thêm Tài Khoản: " + txtTenTaiKhoan.Text);
                                MessageBox.Show("Thêm Thành Công");
                                this.Dispose();
                            }
                            else
                            {
                                MessageBox.Show("Thêm Tài Khoản Thất Bại");
                            }
                        }
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);  
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {

                if (KiemTraLoi.KiemTraRong(txtMatKhau.Text) || KiemTraLoi.KiemTraRong(txtTenTaiKhoan.Text))
                {
                    MessageBox.Show("Vui Lòng Nhập");
                }
                else
                {
                    TaiKhoan taikhoan = new TaiKhoan();
                    taikhoan.MatKhau = txtMatKhau.Text;
                    taikhoan.MaTaiKhoan = Convert.ToInt32(comboxTaiKhoan.Text.Split('-')[0]);
                    taikhoan.TenTaikhoan = txtTenTaiKhoan.Text;
                    taikhoan.MaNhomQuyen = Convert.ToInt32(comboxTenNhomQuyen.Text.Split('-')[0]);
                    if (taiKhoanBUS.SuaTaiKhoan(taikhoan))
                    {
                        LichSuHoatDong.LichSu(FormMain.MaTaiKhoan, "Sửa Tài Khoản: " + txtTenTaiKhoan.Text);
                        MessageBox.Show("Sửa Thành Công");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Sửa Tài Khoản Thất Bại");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }
        public string MaHoa(string txt)
        {
            return "";
        }
    }
}
