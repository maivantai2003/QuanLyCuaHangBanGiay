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
    public partial class FormChiTietQuyenModel : Form
    {
        ChiTietQuyenBUS chiTietQuyenBUS = new ChiTietQuyenBUS();
        NhomQuyenBUS nhomQuyenBUS = new NhomQuyenBUS();
        ChucNangBUS chucNangBUS = new ChucNangBUS();
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
        public FormChiTietQuyenModel()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (comboxChucNang.Text == "" || comboxHanhDong.Text == "" || comboxNhomQuyen.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Vào");
                return;
            }
            else
            {
                ChiTietQuyen chitietquyen = new ChiTietQuyen();
                chitietquyen.MaChucNang = Convert.ToInt32(comboxChucNang.Text.Split('-')[0]);
                chitietquyen.MaNhomQuyen = Convert.ToInt32(comboxNhomQuyen.Text.Split('-')[0]);
                chitietquyen.HanhDong = comboxHanhDong.Text;
                if (chiTietQuyenBUS.kiemTraHanhDong(chitietquyen.MaNhomQuyen, chitietquyen.MaChucNang,chitietquyen.HanhDong))
                {
                    MessageBox.Show("Chi Tiết Quyền Đã Có");
                    return;
                }
                else{
                    if ((chiTietQuyenBUS.ThemChiTietQuyen(chitietquyen)))
                    {
                        MessageBox.Show("Thêm Thành Công");
                        this.Dispose();
                    }
                    
                }
                LichSuHoatDong.LichSu(FormMain.MaTaiKhoan,"Thêm Mới Chi Tiết Quyền");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }
    }
}
