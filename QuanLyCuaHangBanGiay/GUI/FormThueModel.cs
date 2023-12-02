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
    public partial class FormThueModel : Form
    {
        ThueBUS thueBUS=new ThueBUS();
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
        public FormThueModel()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraLoi.KiemTraRong(txtTenThue.Text))
            {
                MessageBox.Show("Vui Lòng Nhập");
                txtTenThue.Focus();
            }else if (KiemTraLoi.KiemTraSoThuc(txtMucThue.Text)==false)
            {
                MessageBox.Show("Vui Lòng Nhập Là Số");
                txtMucThue.Focus();
            }
            else if (KiemTraLoi.KiemTraRong(txtMucThue.Text))
            {
                MessageBox.Show("Vui Lòng Nhập");
                txtMucThue.Focus();
            }
            else
            {
                Thue thue = new Thue();
                thue.TrangThai = 1;
                thue.TenThue = txtTenThue.Text;
                thue.MucThue = Convert.ToSingle(txtMucThue.Text);
                if (thueBUS.ThemThue(thue))
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
            if (KiemTraLoi.KiemTraRong(txtTenThue.Text))
            {
                MessageBox.Show("Vui Lòng Nhập");
                txtTenThue.Focus();
            }
            else if (KiemTraLoi.KiemTraSoThuc(txtMucThue.Text) == false)
            {
                MessageBox.Show("Vui Lòng Nhập Là Số");
                txtMucThue.Focus();
            }
            else if (KiemTraLoi.KiemTraRong(txtMucThue.Text))
            {
                MessageBox.Show("Vui Lòng Nhập");
                txtMucThue.Focus();
            }
            else
            {
                Thue thue = new Thue();
                thue.MaThue = Convert.ToInt32(txtMaThue.Text);
                thue.TenThue = txtTenThue.Text;
                thue.MucThue = Convert.ToSingle(txtMucThue.Text);
                if (thueBUS.SuaThue(thue))
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
    }
}
