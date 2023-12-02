using BUS;
using DTO;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
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
using GUI.KIEMTRA;

namespace GUI
{
    public partial class Login : Form
    {
        TaiKhoanBUS taikhoan = new TaiKhoanBUS();
        ChiTietQuyenBUS chiTietQuyen = new ChiTietQuyenBUS();
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
        public Login()
        {
            InitializeComponent();
            btnGoogle.FlatStyle = FlatStyle.Flat;
            btnGoogle.FlatAppearance.BorderSize = 0;
            btnGoogle.UseVisualStyleBackColor = true;
            btnPhone.FlatStyle = FlatStyle.Flat;
            btnPhone.FlatAppearance.BorderSize = 0;
            btnPhone.UseVisualStyleBackColor = true;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
       
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void DangNhap()
        {
            if (txtTaiKhoan.Text == "" && txtMatKhau.Text == "")
            {
                MessageBox.Show("Không Được Để Trống");
                return;
            }else if (txtMatKhau.Text == "" && txtTaiKhoan.Text!="")
            {
                MessageBox.Show("Vui Lòng Nhập Mật Khẩu");
            }else if (txtTaiKhoan.Text == "" && txtMatKhau.Text!="")
            {
                MessageBox.Show("Vui Lòng Nhập Tài Khoản");
            }
            else
            {
                if (taikhoan.DangNhap(txtTaiKhoan.Text, txtMatKhau.Text))
                {
                    int mataikhoan = taikhoan.getMaTaiKhoan(txtTaiKhoan.Text, txtMatKhau.Text);
                    bool kiemtrataikhoan = taikhoan.KiemTraTaiKhoan(mataikhoan);
                    if (kiemtrataikhoan == true)
                    {
                        int maquyen = taikhoan.getMaNhomQuyen(mataikhoan);
                        string chucnang = chiTietQuyen.ChucNang(maquyen);
                        bool tmp = string.IsNullOrEmpty(chucnang);
                        LichSuHoatDong.LichSu(mataikhoan, "Đã Đăng Nhập Vào Hệ Thống");
                        FormMain main = new FormMain(maquyen, mataikhoan, chucnang);
                        main.ShowDialog();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Tài Khoản Không Còn Quyền Truy Cập");
                    }
                   
                }
                else
                {
                    txtMatKhau.Text = "";
                    MessageBox.Show("Tài Khoản Chưa Được Đăng Ký");
                    
                    return;
                }
            }
        }
        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                imgLogin1.Image = imgLogin1.ImageHover;
            }
            else
            {
                imgLogin1.Image = imgLogin1.ImageNormal;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NavigateLink("https://accounts.google.com/v3/signin/identifier?hl=vi_VN&ifkv=AVQVeywcPjTrVm0nsBov0KdZxxwl5vCQ0UaIBytQa3vcwzjrBkuQpj-swezCxSk8zhAxhwzvPOtGlg&flowName=GlifWebSignIn&flowEntry=ServiceLogin&dsh=S1393321471%3A1698858876397215&theme=glif");

        }
        public void NavigateLink(string link)
        {
            try
            {
                ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
                chromeDriverService.HideCommandPromptWindow = true;
                IWebDriver driver = new ChromeDriver(chromeDriverService);
                driver.Url = link;
                driver.Manage().Window.Maximize();
                driver.Navigate();
                
            }
            catch (Exception ex)
            {

            }

        }

        private void btnPhone_Click(object sender, EventArgs e)
        {
            LoginSDT sdt=new LoginSDT();
            sdt.ShowDialog();
        }
    }
}
