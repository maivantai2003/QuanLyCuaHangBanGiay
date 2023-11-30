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
    public partial class FormNhaCungCapModel : Form
    {
        NhaCungCapBUS nhaCungCapBUS=new NhaCungCapBUS();
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
        public FormNhaCungCapModel()
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
            if (KiemTraLoi.KiemTraRong(txtDiaChi.Text))
            {
                MessageBox.Show("Vui Lòng Nhập Địa Chỉ Nhà Cung Cấp");
            }else if (KiemTraLoi.KiemTraRong(txtSDT.Text))
            {
                MessageBox.Show("Vui Lòng Nhập Địa Chỉ");
            }else if (KiemTraLoi.KiemTraRong(txtTenNhaCungCap.Text))
            {
                MessageBox.Show("Vui Lòng Nhập Tên Nhà Cung Cấp");
            }else if (KiemTraLoi.KiemTraSoDienThoai(txtSDT.Text)==false)
            {
                MessageBox.Show("Số Điện Thoại Không Hợp Lệ");
            }
            else
            {
                NhaCungCap nhaCungCap=new NhaCungCap();
                nhaCungCap.TenNhaCungCap = txtTenNhaCungCap.Text;
                nhaCungCap.DiaChi=txtDiaChi.Text;
                nhaCungCap.SoDienThoai=txtSDT.Text;
                nhaCungCap.TrangThai = 1;
                if (nhaCungCapBUS.KiemTraNhaCungCap(nhaCungCap.TenNhaCungCap,nhaCungCap.SoDienThoai))
                {
                    MessageBox.Show("Nhà Cung Cấp Đã Tồn Tại");
                }
                else
                {
                    if (nhaCungCapBUS.ThemNhaCungCap(nhaCungCap))
                    {
                        MessageBox.Show("Thêm Nhà Cung Cấp Thành Công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm Không Thành Công");
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (KiemTraLoi.KiemTraRong(txtDiaChi.Text))
            {
                MessageBox.Show("Vui Lòng Nhập Địa Chỉ Nhà Cung Cấp");
            }
            else if (KiemTraLoi.KiemTraRong(txtSDT.Text))
            {
                MessageBox.Show("Vui Lòng Nhập Địa Chỉ");
            }
            else if (KiemTraLoi.KiemTraRong(txtTenNhaCungCap.Text))
            {
                MessageBox.Show("Vui Lòng Nhập Tên Nhà Cung Cấp");
            }
            else if (KiemTraLoi.KiemTraSoDienThoai(txtSDT.Text)==false)
            {
                MessageBox.Show("Số Điện Thoại Không Hợp Lệ");
            }
            else
            {
                NhaCungCap nhaCungCap = new NhaCungCap();
                nhaCungCap.MaNhaCungCap = Convert.ToInt32(txtMaNhaCungCap.Text);
                nhaCungCap.TenNhaCungCap = txtTenNhaCungCap.Text;
                nhaCungCap.DiaChi = txtDiaChi.Text;
                nhaCungCap.SoDienThoai = txtSDT.Text;
               
                if (nhaCungCapBUS.KiemTraNhaCungCap(nhaCungCap.TenNhaCungCap, nhaCungCap.SoDienThoai))
                {
                    MessageBox.Show("Nhà Cung Cấp Đã Tồn Tại");
                }
                else
                {
                    if (nhaCungCapBUS.SuaNhaCungCap(nhaCungCap))
                    {
                        MessageBox.Show("Sửa Nhà Cung Cấp Thành Công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sửa Không Thành Công");
                    }
                }
            }
        }
    }
}
