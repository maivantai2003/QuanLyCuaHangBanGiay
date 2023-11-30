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
    public partial class FormTheLoaiModel : Form
    {
        TheLoaiBUS theLoaiBUS=new TheLoaiBUS();
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
        public FormTheLoaiModel()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TheLoai theloai=new TheLoai();
            theloai.TrangThai = 1;
            theloai.TenTheLoai = txtTenTheLoai.Text;
            if (KiemTraLoi.KiemTraRong(txtTenTheLoai.Text))
            {
                MessageBox.Show("Vui Lòng Nhập");
                txtTenTheLoai.Focus();
            }
            else
            {
                if (theLoaiBUS.KiemTraTheLoai(txtTenTheLoai.Text))
                {
                    MessageBox.Show("Thể Loại Đã Tồn Tại");
                }
                else
                {
                    if (theLoaiBUS.ThemTheLoai(theloai))
                    {
                        MessageBox.Show("Thêm Thành Công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thất Bại");
                    }
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TheLoai theloai = new TheLoai();
            theloai.MaTheLoai=Convert.ToInt32(txtMaTheLoai.Text);
            theloai.TenTheLoai = txtTenTheLoai.Text;
            if (KiemTraLoi.KiemTraRong(txtTenTheLoai.Text))
            {
                MessageBox.Show("Vui Lòng Nhập");
                txtTenTheLoai.Focus();
            }
            else
            {
                if (theLoaiBUS.KiemTraTheLoai(txtTenTheLoai.Text))
                {
                    MessageBox.Show("Thể Loại Đã Tồn Tại");
                }
                else
                {
                    if (theLoaiBUS.SuaTheLoai(theloai))
                    {
                        MessageBox.Show("Sửa Thành Công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sửa Thất Bại");
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
