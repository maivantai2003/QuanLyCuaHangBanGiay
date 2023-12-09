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
    public partial class FormXemChiTietHoaDon : Form
    {
        HoaDonBUS hoaDonBUS=new HoaDonBUS();
        ChiTietHoaDonBUS chiTietHoaDonBUS = new ChiTietHoaDonBUS();
        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        KhachHangBUS khachHangBUS = new KhachHangBUS();
        public FormXemChiTietHoaDon(int mahoadon)
        {
            InitializeComponent();
            HoaDon hoadon = hoaDonBUS.LayHoaDon(mahoadon);
            KhachHang khachHang = khachHangBUS.LayKhachHang(hoadon.MaKhachHang);
            lbMaHoaDon.Text = "Mã Hóa Đơn: " + hoadon.MaHoaDon;
            lbTenHoaDon.Text = "Tên Hóa Đơn: " + hoadon.TenHoaDon;
            lbNgayLap.Text = "Ngày Lập: " + hoadon.NgayLapHoaDon;
            lbMaNhanVien.Text = "Mã Nhân Viên: " + hoadon.MaNhanVien + "-" + nhanVienBUS.TenNhanVien(hoadon.MaNhanVien);
            lbKhachHang.Text = "Khách Hàng: " + hoadon.MaKhachHang + "-" + khachHang.TenKhachHang;
            lbSoDienThoai.Text = "Số Điện Thoại: " + khachHang.SoDienThoai;
            lbTienThue.Text = "Tiền Thuế: " + hoadon.TongTienThue;
            lbTienKhuyenMai.Text = "Tiền Khuyến Mãi: " + hoadon.TongTienKhuyenMai;
            lbThanhTien.Text = "Thành Tiền: " + hoadon.ThanhTien.ToString("0")+"VND";
            lbTongTien.Text = "Tổng Tiền: " + hoadon.TongTien.ToString("0") + "VND";
            LoadData(mahoadon);

        }
        public void LoadData(int mahoadon)
        {
            foreach (var i in chiTietHoaDonBUS.ChiTietHoaDon(mahoadon))
            {
                string[] s = i.Split(',');
                
                dataGridViewChiTietHoaDon.Rows.Add(s[0], s[1], s[2], s[3], s[4], s[5], s[6]);
            }
            dataGridViewChiTietHoaDon.ClearSelection();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("HÓA ĐƠN", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(350, 20));
            e.Graphics.DrawString(lbMaHoaDon.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 60));
            e.Graphics.DrawString(lbTenHoaDon.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 85));
            e.Graphics.DrawString(lbMaNhanVien.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 105));
            e.Graphics.DrawString(lbNgayLap.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(360, 60));
            e.Graphics.DrawString(lbKhachHang.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(360, 85));
            e.Graphics.DrawString(lbSoDienThoai.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(360, 105));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, 175));
            e.Graphics.DrawString("STT", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(20, 190));
            e.Graphics.DrawString("Tên Sản Phẩm", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(80, 190));
            e.Graphics.DrawString("Màu", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(250, 190));
            e.Graphics.DrawString("Kích Cỡ", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(340, 190));
            e.Graphics.DrawString("Số Lượng ", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(450, 190));
            e.Graphics.DrawString("Giá Sản Phẩm", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(600, 190));
            e.Graphics.DrawString("Thành Tiền", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(740, 190));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, 200));
            int point = 220;
            for (int i = 0; i < dataGridViewChiTietHoaDon.Rows.Count; i++)
            {
                e.Graphics.DrawString(dataGridViewChiTietHoaDon.Rows[i].Cells[0].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(20, point));
                e.Graphics.DrawString(dataGridViewChiTietHoaDon.Rows[i].Cells[1].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(80, point));
                e.Graphics.DrawString(dataGridViewChiTietHoaDon.Rows[i].Cells[2].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(250, point));
                e.Graphics.DrawString(dataGridViewChiTietHoaDon.Rows[i].Cells[3].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(340, point));
                e.Graphics.DrawString(dataGridViewChiTietHoaDon.Rows[i].Cells[4].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(450, point));
                e.Graphics.DrawString(dataGridViewChiTietHoaDon.Rows[i].Cells[5].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(600, point));
                e.Graphics.DrawString(dataGridViewChiTietHoaDon.Rows[i].Cells[6].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(740, point));
                point += 25;
            }
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, point));
            e.Graphics.DrawString(lbTienThue.Text,
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(600, point += 25));
            e.Graphics.DrawString(lbTienKhuyenMai.Text,
               new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(600, point += 25));
            e.Graphics.DrawString(lbThanhTien.Text,
               new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(600, point += 25));
            e.Graphics.DrawString(lbTongTien.Text,
               new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(600, point += 25));
        }
    }
}
