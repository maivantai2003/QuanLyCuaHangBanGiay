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
    public partial class FormChucNangModel : Form
    {
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
        ChucNangBUS chucNangBUS=new ChucNangBUS();
        public FormChucNangModel()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                ChucNang chucnang = new ChucNang();
                if (txtTenChucNang.Text == "")
                {
                    MessageBox.Show("Không Được Để Trống");
                    return;
                }
                else if (chucNangBUS.KiemTraChucNang(txtTenChucNang.Text))
                {
                    MessageBox.Show("Chức Năng Đã Tồn Tại");
                    return;
                }
                else
                {
                    chucnang.TenChucNang = txtTenChucNang.Text;
                    chucnang.TrangThai = 1;
                    if (chucNangBUS.ThemChucNang(chucnang))
                    {
                        MessageBox.Show("Thêm Chức Năng Thành Công");
                    }
                    LichSuHoatDong.LichSu(FormMain.MaTaiKhoan, "Thêm Mới Chức Năng: " + txtTenChucNang.Text);
                    this.Dispose();
                }
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
                ChucNang chucnang = new ChucNang();
                if (txtTenChucNang.Text == "")
                {
                    MessageBox.Show("Không Được Để Trống");
                    return;
                }
                else if (chucNangBUS.KiemTraChucNang(txtTenChucNang.Text))
                {
                    MessageBox.Show("Chức Năng Đã Tồn Tại");
                    return;
                }
                else
                {
                    chucnang.MaChucNang = Convert.ToInt32(txtMaChucNang.Text);
                    chucnang.TenChucNang = txtTenChucNang.Text;
                    if (chucNangBUS.SuaChucNang(chucnang))
                    {
                        LichSuHoatDong.LichSu(FormMain.MaTaiKhoan, "Sửa Chức Năng: " + txtTenChucNang.Text);
                        MessageBox.Show("Sửa Thành Công");
                        
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
    }
}
