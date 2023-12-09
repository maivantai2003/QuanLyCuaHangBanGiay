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
    public partial class FormXemChiTietPhieuNhap : Form
    {
        ChiTietPhieuNhapBUS ctpn=new ChiTietPhieuNhapBUS();
        PhieuNhapBUS phieuNhapBUS = new PhieuNhapBUS();
        KhachHangBUS khachHangBUS = new KhachHangBUS();
        NhaCungCapBUS nhaCungCapBUS = new NhaCungCapBUS();
        NhanVienBUS nhanVienBUS=new NhanVienBUS();
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
        public FormXemChiTietPhieuNhap(int maphieunhap)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            PhieuNhap phieuNhap = phieuNhapBUS.LayPhieuNhap(maphieunhap);
            lbMaPhieuNhap.Text = "Mã Phiếu Nhập: " + phieuNhap.MaPhieuNhap;
            lbNgayNhap.Text = "Ngày Lập: " + phieuNhap.NgayNhap;
            lbNhaCungCap.Text = "Nhà Cung Cấp: " + nhaCungCapBUS.TenNhaCungCap(phieuNhap.MaNhaCungCap);
            lbTenNhanVien.Text = "Nhân Viên: " + nhanVienBUS.TenNhanVien(phieuNhap.MaNhanVien);
            lbTongTien.Text = "Tổng Tiền Nhập: " + phieuNhap.TongTienNhap.ToString("0")+"VND";
            foreach (var i in ctpn.DanhSachChiTietPhieuNhap(maphieunhap))
            {
                string[] s = i.ToString().Split(',');
                dataGridViewChiTietPhieuNhap.Rows.Add(s[0], s[1], s[2], s[3], s[4], s[5], s[6], s[7]);
            }
            dataGridViewChiTietPhieuNhap.ClearSelection();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("PHIẾU NHẬP", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(350, 20));
            e.Graphics.DrawString(lbNgayNhap.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 60));
            e.Graphics.DrawString(lbMaPhieuNhap.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 85));
            e.Graphics.DrawString(lbTenNhanVien.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 105));
            e.Graphics.DrawString(lbNhaCungCap.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 125));
            e.Graphics.DrawString("Chi Tiết Nhập", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, 160));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, 175));
            e.Graphics.DrawString("STT", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(20, 190));
            e.Graphics.DrawString("Tên Sản Phẩm", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(80, 190));
            e.Graphics.DrawString("Màu", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(240, 190));
            e.Graphics.DrawString("Kích Cỡ", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(300, 190));
            e.Graphics.DrawString("Số Lượng Nhập", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(400, 190));
            e.Graphics.DrawString("Đơn Vị", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(520, 190));
            e.Graphics.DrawString("Tiền Nhập", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(630, 190));
            e.Graphics.DrawString("Thành Tiền", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(740, 190));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20,200));
            int point = 220;
            for(int i = 0; i < dataGridViewChiTietPhieuNhap.Rows.Count; i++)
            {
                e.Graphics.DrawString((i+1)+"", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(20, point));
                e.Graphics.DrawString(dataGridViewChiTietPhieuNhap.Rows[i].Cells[1].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(80, point));
                e.Graphics.DrawString(dataGridViewChiTietPhieuNhap.Rows[i].Cells[2].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(240, point));
                e.Graphics.DrawString(dataGridViewChiTietPhieuNhap.Rows[i].Cells[3].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(320, point));
                e.Graphics.DrawString(dataGridViewChiTietPhieuNhap.Rows[i].Cells[4].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(420, point));
                e.Graphics.DrawString(dataGridViewChiTietPhieuNhap.Rows[i].Cells[5].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(520, point));
                e.Graphics.DrawString(dataGridViewChiTietPhieuNhap.Rows[i].Cells[6].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(630, point));
                e.Graphics.DrawString(dataGridViewChiTietPhieuNhap.Rows[i].Cells[7].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(740, point));
                point += 25;
            }
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, point));
            e.Graphics.DrawString(lbTongTien.Text,
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(600, point+=25));
        }

        private void btnPDF_Click_1(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
