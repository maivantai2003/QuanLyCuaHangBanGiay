using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GUI
{
    public partial class FormThongKe : Form
    {
        SanPhamBUS sanPhamBUS=new SanPhamBUS();
        HoaDonBUS HoaDonBUS=new HoaDonBUS();
        ChiTietSanPhamBUS chiTietSanPhamBUS=new ChiTietSanPhamBUS();
        ChiTietHoaDonBUS chiTietHoaDonBUS=new ChiTietHoaDonBUS();
        PhieuTraBUS phieuTraBUS=new PhieuTraBUS();  
        ThongKeBUS thongKeBUS=new ThongKeBUS();
        ChiTietPhieuNhapBUS chiTietPhieuNhapBUS=new ChiTietPhieuNhapBUS();
        public FormThongKe()
        {
            InitializeComponent();
            lbSoLuongPhieuTra.Text = "Số Lượng Phiếu Trả " + phieuTraBUS.SoLuongPhieuTra() + " (" + thongKeBUS.TongTienTra().ToString("0") + ")";
            lbSoLuongHoaDon.Text = "Số Lượng Hóa Đơn " + HoaDonBUS.SoHoaDon() + " (" + HoaDonBUS.DoanhThu().ToString("0") + ")";
            lbTongDoanhThu.Text = "Tổng Doanh Thu " + (HoaDonBUS.DoanhThu()-thongKeBUS.TongTienTra()).ToString("0");
            lbSoSP.Text = "Số Sản Phẩm " + sanPhamBUS.SoLuongSanPham();
        }
        public void ThongKe(DataTable tb)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControlThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            int lc = tabControlThongKe.SelectedIndex;
            if (lc == 0)
            {
                lbNoiDung.Text = "Số Lượng Hàng Đã Bán " + chiTietHoaDonBUS.SoLuongHangDaBan();
                chartSPBan.DataSource = thongKeBUS.ThongKeSanPhamDaBan();
                chartSPBan.Series["Series1"].XValueMember = "TenSanPham";
                chartSPBan.Series["Series1"].YValueMembers = "SL";

                chartCTSPBan.DataSource = thongKeBUS.ThongKeChiTietSanPhamDaBan();
                chartCTSPBan.Series["Series1"].XValueMember = "SanPham";
                chartCTSPBan.Series["Series1"].YValueMembers = "SL";
            }
            else if (lc == 1)
            {
                lbNoiDung.Text = "Số Lượng Hàng Nhập " + chiTietPhieuNhapBUS.SoLuongNhap();
                chartSLNhap.DataSource = thongKeBUS.ThongKeSoLuongNhap();
                chartSLNhap.Series["Series1"].XValueMember = "TenSanPham";
                chartSLNhap.Series["Series1"].YValueMembers = "SL";
                chartChiTietSLNhap.DataSource = thongKeBUS.ThongKeChiTietSanPhamNhap();
                chartChiTietSLNhap.Series["Series1"].XValueMember = "SanPham";
                chartChiTietSLNhap.Series["Series1"].YValueMembers = "SL";
            }
            else if (lc == 2)
            {
                lbNoiDung.Text = "Số Lượng Tồn " + sanPhamBUS.SoLuongTon();
                chartSLHangTon.DataSource = thongKeBUS.ThongKeSoLuongTon();
                chartSLHangTon.Series["Series1"].XValueMember = "TenSanPham";
                chartSLHangTon.Series["Series1"].YValueMembers = "SL";
                chartChiTietSLHangTon.DataSource = thongKeBUS.ThongKeChiTietSanPhamTon();
                chartChiTietSLHangTon.Series["Series1"].XValueMember = "SanPham";
                chartChiTietSLHangTon.Series["Series1"].YValueMembers = "SL";
            }
            else if (lc == 3)
            {
                lbNoiDung.Text = "Doanh Thu ";
                chartDoanhThu.DataSource = thongKeBUS.ThongKeDoanhThu(dateTimeTuNgay.Value, dateTimeDenNgay.Value);
                chartDoanhThu.Series["Series1"].XValueMember = "Ngay";
                chartDoanhThu.Series["Series1"].YValueMembers = "doanhthu";
            }
            else if (lc == 4)
            {
                lbNoiDung.Text = "Sản Phẩm Phổ Biến";
                chartSPPhoBien.DataSource = thongKeBUS.ThongKeSanPhamPhoBien();
                chartSPPhoBien.Series["Series1"].XValueMember = "TenSanPham";
                chartSPPhoBien.Series["Series1"].YValueMembers = "SL";
                chartChiTietSPPhoBien.DataSource = thongKeBUS.ThongKeChiTietSanPhamPhoBien();
                chartChiTietSPPhoBien.Series["Series1"].XValueMember = "SanPham";
                chartChiTietSPPhoBien.Series["Series1"].YValueMembers = "SL";

            }
        }

        private void tabControlThongKe_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            lbNoiDung.Text = "Số Lượng Hàng Đã Bán " + chiTietHoaDonBUS.SoLuongHangDaBan();
            chartSPBan.DataSource = thongKeBUS.ThongKeSanPhamDaBan();
            chartSPBan.Series["Series1"].XValueMember = "TenSanPham";
            chartSPBan.Series["Series1"].YValueMembers = "SL";
            chartCTSPBan.DataSource = thongKeBUS.ThongKeChiTietSanPhamDaBan();
            chartCTSPBan.Series["Series1"].XValueMember = "SanPham";
            chartCTSPBan.Series["Series1"].YValueMembers = "SL";
        }
    }
}
