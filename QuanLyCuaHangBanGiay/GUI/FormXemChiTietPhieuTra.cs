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
    public partial class FormXemChiTietPhieuTra : Form
    {
        PhieuTraBUS phieuTraBUS = new PhieuTraBUS();
        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        ChiTietPhieuTraBUS chiTietPhieuTraBUS = new ChiTietPhieuTraBUS();
        public FormXemChiTietPhieuTra(int maphieutra)
        {
            InitializeComponent();
            PhieuTra phieuTra = phieuTraBUS.LayPhieuTra(maphieutra);
            lbMaPhieuTra.Text = "Mã Phiếu Trả: " + phieuTra.MaPhieuTra;
            lbMaHoaDon.Text = "Mã Hóa Đơn: " + phieuTra.MaHoaDon;
            lbMaNhanVien.Text = "Tên Nhân Viên: " + phieuTra.MaNhanVien + "-" + nhanVienBUS.TenNhanVien(phieuTra.MaNhanVien);
            lbNgayTra.Text = "Ngày Trả: " + phieuTra.NgayTra;
            lbSLTra.Text = "Số Lượng Trả: " + phieuTra.TongSoLuongTra;
            lbTongTienTra.Text = "Tổng Tiền Trả: " + phieuTra.TongTienTra + "VND";
            foreach (var i in chiTietPhieuTraBUS.ChiTietPhieuTra(maphieutra))
            {
                string[] s = i.Split(',');
                dataGridViewChiTietPhieuTra.Rows.Add(s[0], s[1], s[2], s[3], s[4], s[5], s[6], s[7]);
            }
            dataGridViewChiTietPhieuTra.ClearSelection();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCTPT_Load(object sender, EventArgs e)
        {

        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("PHIẾU TRẢ", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(350, 20));
            e.Graphics.DrawString(lbMaPhieuTra.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 60));
            e.Graphics.DrawString(lbMaHoaDon.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 85));
            e.Graphics.DrawString(lbMaNhanVien.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 105));
            e.Graphics.DrawString(lbNgayTra.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(360, 60));
            e.Graphics.DrawString("Chi Tiết Trả", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, 160));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, 175));
            e.Graphics.DrawString("STT", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(20, 190));
            e.Graphics.DrawString("Tên Sản Phẩm", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(80, 190));
            e.Graphics.DrawString("Màu", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(240, 190));
            e.Graphics.DrawString("Kích Cỡ", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(300, 190));
            e.Graphics.DrawString("Lý Do Trả", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(390, 190));
            e.Graphics.DrawString("Giá Sản Phẩm", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(520, 190));
            e.Graphics.DrawString("Số Lượng", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(630, 190));
            e.Graphics.DrawString("Thành Tiền", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(740, 190));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, 200));
           int point = 220;
            for (int i = 0; i < dataGridViewChiTietPhieuTra.Rows.Count; i++)
            {
                e.Graphics.DrawString(dataGridViewChiTietPhieuTra.Rows[i].Cells[0].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(20, point));
                e.Graphics.DrawString(dataGridViewChiTietPhieuTra.Rows[i].Cells[1].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(80, point));
                e.Graphics.DrawString(dataGridViewChiTietPhieuTra.Rows[i].Cells[2].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(240, point));
                e.Graphics.DrawString(dataGridViewChiTietPhieuTra.Rows[i].Cells[3].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(300, point));
                e.Graphics.DrawString(dataGridViewChiTietPhieuTra.Rows[i].Cells[4].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(390, point));
                e.Graphics.DrawString(dataGridViewChiTietPhieuTra.Rows[i].Cells[5].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(520, point));
                e.Graphics.DrawString(dataGridViewChiTietPhieuTra.Rows[i].Cells[6].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(630, point));
                e.Graphics.DrawString(dataGridViewChiTietPhieuTra.Rows[i].Cells[7].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(740, point));
                point += 25;
            }
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, point));
            e.Graphics.DrawString(lbSLTra.Text,
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(630, point += 25));
            e.Graphics.DrawString(lbTongTienTra.Text,
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(630, point += 25));
        }
    }
}
