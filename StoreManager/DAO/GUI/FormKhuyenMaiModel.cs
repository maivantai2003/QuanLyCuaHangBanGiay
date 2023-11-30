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
    public partial class FormKhuyenMaiModel : Form
    {
        KhuyenMaiBUS khuyenMaiBUS=new KhuyenMaiBUS();
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
        public FormKhuyenMaiModel()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraLoi.KiemTraRong(txtMucKhuyenMai.Text))
            {
                MessageBox.Show("Vui Lòng Nhập");
                txtMucKhuyenMai.Focus();
            }else if (KiemTraLoi.KiemTraRong(txtDieuKien.Text)) 
            {
                MessageBox.Show("Vui Lòng Nhập");
                txtDieuKien.Focus();
            }else if (KiemTraLoi.KiemTraSoThuc(txtMucKhuyenMai.Text)==false)
            {
                MessageBox.Show("Vui Lòng Nhập Số");
                txtMucKhuyenMai.Focus();
            }else if (dateTimeThoiGianBatDau.Value>dateTimeThoiGianKetThuc.Value)
            {
                MessageBox.Show("Ngày Không Hợp Lệ");
                dateTimeThoiGianKetThuc.Focus();
            }
            else
            {
                KhuyenMai khuyenmai = new KhuyenMai();
                khuyenmai.MucKhuyenMai = Convert.ToSingle(txtMucKhuyenMai.Text);
                khuyenmai.DieuKien = txtDieuKien.Text;
                khuyenmai.ThoiGianBatDau = dateTimeThoiGianBatDau.Value;
                khuyenmai.ThoiGianKetThuc=dateTimeThoiGianKetThuc.Value;
                khuyenmai.TinhTrang = 1;
                if (khuyenMaiBUS.ThemKhuyenMai(khuyenmai))
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (KiemTraLoi.KiemTraRong(txtMucKhuyenMai.Text))
            {
                MessageBox.Show("Vui Lòng Nhập");
                txtMucKhuyenMai.Focus();
            }
            else if (KiemTraLoi.KiemTraRong(txtDieuKien.Text))
            {
                MessageBox.Show("Vui Lòng Nhập");
                txtDieuKien.Focus();
            }
            else if (KiemTraLoi.KiemTraSoThuc(txtMucKhuyenMai.Text)==false)
            {
                MessageBox.Show("Vui Lòng Nhập Số");
                txtMucKhuyenMai.Focus();
            }
            else
            {
                KhuyenMai khuyenmai = new KhuyenMai();
                khuyenmai.MaKhuyenMai = Convert.ToInt32(txtMaKhuyenMai.Text);
                khuyenmai.MucKhuyenMai = Convert.ToSingle(txtMucKhuyenMai.Text);
                khuyenmai.DieuKien = txtDieuKien.Text;
                khuyenmai.ThoiGianBatDau = dateTimeThoiGianBatDau.Value;
                khuyenmai.ThoiGianKetThuc = dateTimeThoiGianKetThuc.Value;
                if (khuyenMaiBUS.SuaKhuyenMai(khuyenmai))
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
