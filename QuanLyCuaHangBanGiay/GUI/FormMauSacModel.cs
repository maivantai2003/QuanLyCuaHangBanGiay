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
    public partial class FormMauSacModel : Form
    {
        MauSacBUS mauSacBUS=new MauSacBUS();
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
        public FormMauSacModel()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MauSac mauSac = new MauSac();
            mauSac.TenMau = txtTenMauSac.Text;
            mauSac.TrangThai = 1;
            if (KiemTraLoi.KiemTraRong(txtTenMauSac.Text))
            {
                MessageBox.Show("Vui Lòng Nhập");
            }
            else
            {
                if (mauSacBUS.KiemTraMauSac(txtTenMauSac.Text))
                {
                    MessageBox.Show("Màu Đã Tồn Tại");
                }
                else
                {
                    if (mauSacBUS.ThemMau(mauSac))
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
            MauSac mauSac = new MauSac();
            mauSac.MaMau = Convert.ToInt32(txtMaMauSac.Text);
            mauSac.TenMau = txtTenMauSac.Text;
            if (KiemTraLoi.KiemTraRong(txtTenMauSac.Text))
            {
                MessageBox.Show("Vui Lòng Nhập");
            }
            else
            {
                if (mauSacBUS.KiemTraMauSac(txtTenMauSac.Text))
                {
                    MessageBox.Show("Màu Đã Tồn Tại");
                }
                else
                {
                    if (mauSacBUS.SuaMau(mauSac))
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
