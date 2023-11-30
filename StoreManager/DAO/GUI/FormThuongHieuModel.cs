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
    public partial class FormThuongHieuModel : Form
    {
        ThuongHieuBUS thuongHieuBUS=new ThuongHieuBUS();
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
        public FormThuongHieuModel()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThuongHieu thuonghieu=new ThuongHieu();
            thuonghieu.TrangThai = 1;
            thuonghieu.TenThuongHieu = txtTenThuongHieu.Text;
            if (KiemTraLoi.KiemTraRong(txtTenThuongHieu.Text))
            {
                MessageBox.Show("Vui Lòng Nhập");
                txtTenThuongHieu.Focus();
            }
            else
            {
                if (thuongHieuBUS.KiemTraThuongHieu(txtTenThuongHieu.Text))
                {
                    MessageBox.Show("Thương Hiệu Đã Tồn Tại");
                }
                else
                {
                    if (thuongHieuBUS.ThemThuongHieu(thuonghieu))
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            ThuongHieu thuonghieu = new ThuongHieu();
            thuonghieu.MaThuongHieu = Convert.ToInt32(txtMaThuongHieu.Text);
            thuonghieu.TenThuongHieu = txtTenThuongHieu.Text;
            if (KiemTraLoi.KiemTraRong(txtTenThuongHieu.Text))
            {
                MessageBox.Show("Vui Lòng Nhập");
                txtTenThuongHieu.Focus();
            }
            else
            {
                if (thuongHieuBUS.KiemTraThuongHieu(txtTenThuongHieu.Text))
                {
                    MessageBox.Show("Thương Hiệu Đã Tồn Tại");
                }
                else
                {
                    if (thuongHieuBUS.SuaThuongHieu(thuonghieu))
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
    }
}
