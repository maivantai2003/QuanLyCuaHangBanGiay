using BUS;
using DTO;
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
    public partial class FormNhomQuyenModel : Form
    {
        NhomQuyenBUS nhomQuyenBUS=new NhomQuyenBUS();
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
        public FormNhomQuyenModel()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenNhomQuyen.Text == "")
                {
                    MessageBox.Show("Không Được Để Trống");
                    return;
                }else if (nhomQuyenBUS.KiemTraNhomQuyen(txtTenNhomQuyen.Text))
                {
                    MessageBox.Show("Nhóm Quyền Đã Tồn Tại");
                    return;
                }
                else
                {
                    NhomQuyen nhomQuyen = new NhomQuyen();
                    nhomQuyen.TrangThai = 1;
                    nhomQuyen.TenNhomQuyen = txtTenNhomQuyen.Text;
                    if (nhomQuyenBUS.ThemNhomQuyen(nhomQuyen))
                    {
                        MessageBox.Show("Thêm Nhóm Quyền Thành Công");
                    }
                }
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenNhomQuyen.Text == "")
                {
                    MessageBox.Show("Không Được Để Trống");
                    return;
                }
                else if (nhomQuyenBUS.KiemTraNhomQuyen(txtTenNhomQuyen.Text))
                {
                    MessageBox.Show("Nhóm Quyền Đã Tồn Tại");
                    return;
                }
                else
                {
                    NhomQuyen nhomQuyen = new NhomQuyen();
                    nhomQuyen.MaNhomQuyen = Convert.ToInt32(txtMaNhomQuyen.Text);
                    nhomQuyen.TenNhomQuyen = txtTenNhomQuyen.Text;
                    if (nhomQuyenBUS.SuaNhomQuyen(nhomQuyen))
                    {
                        MessageBox.Show("Sửa Nhóm Quyền Thành Công");
                        this.Dispose();
                    }
                    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
