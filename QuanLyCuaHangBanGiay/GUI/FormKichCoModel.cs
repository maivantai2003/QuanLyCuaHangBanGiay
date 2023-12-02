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
    public partial class FormKichCoModel : Form
    {
        KichCoBUS kichCoBUS=new KichCoBUS();
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
        public FormKichCoModel()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FormKichCoModel_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KichCo kichCo = new KichCo();
            kichCo.TenKichCo = txtTenKichCo.Text;
            kichCo.TrangThai = 1;
            if (KiemTraLoi.KiemTraRong(txtTenKichCo.Text))
            {
                MessageBox.Show("Vui Lòng Nhập");
                txtTenKichCo.Focus();
            }
            else
            {
                if (kichCoBUS.KiemTraKichCo(txtTenKichCo.Text))
                {
                    MessageBox.Show("Kích Cỡ Đã Tồn Tại");
                }
                else
                {
                    if (kichCoBUS.ThemKichCo(kichCo))
                    {
                        MessageBox.Show("Thêm thành công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KichCo kichCo = new KichCo();
            kichCo.MaKichCo = Convert.ToInt32(txtMaKichCo.Text);
            kichCo.TenKichCo = txtTenKichCo.Text;
            kichCo.TrangThai = 1;
            if (KiemTraLoi.KiemTraRong(txtTenKichCo.Text))
            {
                MessageBox.Show("Vui Lòng Nhập");
                txtTenKichCo.Focus();
            }
            else
            {
                if (kichCoBUS.KiemTraKichCo(txtTenKichCo.Text))
                {
                    MessageBox.Show("Kích Cỡ Đã Tồn Tại");
                }
                else
                {
                    if (kichCoBUS.SuaKichCo(kichCo))
                    {
                       MessageBox.Show("Sửa thành công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
                
            }
        }
    }
}
