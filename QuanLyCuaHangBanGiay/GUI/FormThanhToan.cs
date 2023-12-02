 using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;
using ZXing;
using System.Drawing.Drawing2D;
using DTO;
using GUI.KIEMTRA;
using System.IO;
using System.Runtime.InteropServices;

namespace GUI
{
    public partial class FormThanhToan : Form
    {
        SanPhamBUS sanPhamBUS=new SanPhamBUS();
        HoaDonBUS hoaDonBUS=new HoaDonBUS();
        MauSacBUS mauSacBUS=new MauSacBUS();    
        KichCoBUS kichCoBUS=new KichCoBUS();    
        //NhanVienBUS nhanVienBUS=new NhanVienBUS(); 
        ChiTietSanPhamBUS chiTietSanPhamBUS=new ChiTietSanPhamBUS();
        KhachHangBUS khachHangBUS=new KhachHangBUS();
        ThueBUS thueBUS=new ThueBUS(); 
        KhuyenMaiBUS khuyenMaiBUS=new KhuyenMaiBUS();   
        ChiTietHoaDonBUS chiTietHoaDonBUS=new ChiTietHoaDonBUS();
        public string TrangThai;
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
        public FormThanhToan(List<string> tmp)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            txtMaHoaDon.Text = hoaDonBUS.MaLonNhat() + 1 + "";
            dateTimePickerNgayNhap.Value = DateTime.Now;
            txtTenHoaDon.Text = "Hóa Đơn Bán Hàng";
            txtTienKhuyenMai.Text = "0";
            txtTienThue.Text = "0";
            float tongtien = 0;
            foreach (var i in tmp)
            {
                string[] s = i.Split(',');
                dataGridViewThanhToan.Rows.Add(s[0], s[1], s[2], s[3], s[4], s[5]);
                tongtien += Convert.ToSingle(s[5]);
            }
            comBoxHinhThucThanhToan.SelectedIndex = 0;
            comBoxMaKhuyenMai.DataSource = khuyenMaiBUS.DanhSachMaKhuyenMai();
            comBoxMaThue.DataSource = thueBUS.DanhSachMaThue();
            txtTongTienHoaDon.Text = tongtien.ToString("0") + "";
            txtThanhTien.Text = tongtien.ToString("0") + "";
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            TrangThai = "Hủy";
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comBoxMaThue_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[]s=comBoxMaThue.Text.Split('-');
            float tienthue = Convert.ToSingle(txtThanhTien.Text) * thueBUS.TienThue(s[1]);
            txtTienThue.Text = tienthue + "";
            float tmp = Convert.ToSingle(txtThanhTien.Text) + tienthue-Convert.ToSingle(txtTienKhuyenMai.Text);
            txtTongTienHoaDon.Text = tmp.ToString("0")+"";
        }
        private void comBoxMaKhuyenMai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] s=comBoxMaKhuyenMai.Text.Split('-');
            float tienkhuyenmai = Convert.ToSingle(txtThanhTien.Text) * khuyenMaiBUS.TienKhuyenMai(Convert.ToInt32(s[0]));
            txtTienKhuyenMai.Text = tienkhuyenmai+"";
            float tmp = Convert.ToSingle(txtThanhTien.Text) - tienkhuyenmai + Convert.ToSingle(txtTienThue.Text);
            txtTongTienHoaDon.Text = tmp.ToString("0") + "";
        }

        private void comBoxHinhThucThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBoxHinhThucThanhToan.Text == "QRCode")
            {
                FormMoMo formMoMo = new FormMoMo();
                formMoMo.ShowDialog();
            }
            else if (comBoxHinhThucThanhToan.Text == "MoMo") 
            {
                var qr_code = $"2|99|{"0359277204"}|{"Trần Quốc Sĩ"}|{"vantai08122003@gmail.com"}|0|0|{txtThanhTien.Text.Trim()}";
                BarcodeWriter barcodeWriter = new BarcodeWriter();
                EncodingOptions encodingOptions = new EncodingOptions() { Width = 200, Height = 200, Margin = 0, PureBarcode = false };
                encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
                barcodeWriter.Renderer = new BitmapRenderer();
                barcodeWriter.Options = encodingOptions;
                barcodeWriter.Format = BarcodeFormat.QR_CODE;
                Bitmap bitmap = barcodeWriter.Write(qr_code);
                string t = Path.GetDirectoryName(Application.ExecutablePath);
                int index = t.LastIndexOf('\\');
                string sub = t.Substring(0, index - 4);
                //string path = "D:\\StoreManager\\DAO\\GUI\\IMG\\";
                string path = sub + @"\IMG\";
                Bitmap logo = new Bitmap(path+"momo.png");
                Bitmap tmp = resizeImage(logo, 64, 64) as Bitmap;
                Graphics g = Graphics.FromImage(bitmap);
                g.DrawImage(tmp, new Point((bitmap.Width - tmp.Width) / 2, (bitmap.Height - tmp.Height) / 2));
                FormQRCode QRcode = new FormQRCode();
                QRcode.pic_QR.Image = bitmap;
                QRcode.ShowDialog();
                if (KiemTraLoi.KiemTraSoDienThoai(txtSDT.Text))
                {
                    if (QRcode.tmp == "Xác Nhận")
                    {

                        btnThanhToan_Click(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Vui Lòng Nhập Số Điện Thoại Khách Hàng");
                }
               

            }
        }
        public Image resizeImage(Image image, int new_height, int new_width)
        {
            Bitmap new_image = new Bitmap(new_width, new_height);
            Graphics g = Graphics.FromImage((Image)new_image);
            g.InterpolationMode = InterpolationMode.High;
            g.DrawImage(image, 0, 0, new_width, new_height);
            return new_image;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if(KiemTraLoi.KiemTraRong(txtTenKhachHang.Text) || KiemTraLoi.KiemTraRong(txtSDT.Text))
            {
                MessageBox.Show("Vui Lòng Nhập Thông Tin Khách Hàng");
            }else if (KiemTraLoi.KiemTraSoDienThoai(txtSDT.Text)==false || KiemTraLoi.KiemTraRong(txtSDT.Text))
            {
                MessageBox.Show("Số Điện Thoại Không Hợp Lệ");
            }else if (KiemTraLoi.KiemTraRong(txtTuoi.Text))
            {
                MessageBox.Show("Vui Lòng Nhập Tuổi");
            }
            else
            {
                KhachHang khachHang=new KhachHang();
                khachHang.MaKhachHang = khachHangBUS.SoLuongKhachHang() + 1 ;
                khachHang.TenKhachHang = txtTenKhachHang.Text;
                khachHang.DiaChi = "TP HCM";
                khachHang.Tuoi = Convert.ToInt32(txtTuoi.Text);
                khachHang.SoDienThoai = txtSDT.Text;
                khachHang.TrangThai = 1;

                if (khachHangBUS.KiemTraSoDienThoai(khachHang.SoDienThoai))
                {
                    khachHang.MaKhachHang = khachHangBUS.MaKhachHang(khachHang.SoDienThoai);
                }
                else
                {
                    if (khachHangBUS.ThemKhachHang(khachHang) == false)
                    {
                        MessageBox.Show("Thêm Khách Hàng Thất Bại");
                        return;
                    }

                }
                string[] thue = comBoxMaThue.Text.Split('-');
                string[] khuyenmai=comBoxMaKhuyenMai.Text.Split('-');
                HoaDon hoaDon = new HoaDon();
                hoaDon.MaHoaDon = Convert.ToInt32(txtMaHoaDon.Text);
                hoaDon.MaKhachHang = khachHang.MaKhachHang;
                hoaDon.MaNhanVien = Convert.ToInt32(txtMaNhanVien.Text.Split('-')[0]);
                hoaDon.MaThue = Convert.ToInt32(thue[0]);
                hoaDon.MaKhuyenMai = Convert.ToInt32(khuyenmai[0]);
                hoaDon.TenHoaDon = txtTenHoaDon.Text;
                hoaDon.NgayLapHoaDon = dateTimePickerNgayNhap.Value;
                hoaDon.TongTien = Convert.ToSingle(txtTongTienHoaDon.Text);
                hoaDon.TongTienKhuyenMai = Convert.ToSingle(txtTienKhuyenMai.Text);
                hoaDon.TongTienThue = Convert.ToSingle(txtTienThue.Text);
                hoaDon.HinhThucThanhToan = comBoxHinhThucThanhToan.Text;
                hoaDon.ThanhTien = Convert.ToSingle(txtThanhTien.Text);
                hoaDon.TrangThai = 1;
                if (hoaDonBUS.ThemHoaDon(hoaDon))
                {
                    for (int i = 0; i < dataGridViewThanhToan.Rows.Count; i++)
                    {
                        ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
                        chiTietHoaDon.MaHoaDon = hoaDon.MaHoaDon;
                        int MaSanPham = sanPhamBUS.MaSanPham(dataGridViewThanhToan.Rows[i].Cells[0].Value.ToString());
                        int MaMau = mauSacBUS.MaMau(dataGridViewThanhToan.Rows[i].Cells[1].Value.ToString());
                        int MaKichCo = kichCoBUS.MaKichCo(dataGridViewThanhToan.Rows[i].Cells[2].Value.ToString());
                        chiTietHoaDon.MaChiTietSanPham = chiTietSanPhamBUS.MaChiTietSanPham(MaSanPham, MaKichCo, MaMau);
                        chiTietHoaDon.GiaSanPham = Convert.ToSingle(dataGridViewThanhToan.Rows[i].Cells[3].Value.ToString());
                        chiTietHoaDon.SoLuong = Convert.ToInt32(dataGridViewThanhToan.Rows[i].Cells[4].Value.ToString());
                        chiTietHoaDon.ThanhTien = Convert.ToSingle(dataGridViewThanhToan.Rows[i].Cells[5].Value.ToString());
                        if (chiTietHoaDonBUS.ThemChiTietHoaDon(chiTietHoaDon))
                        {
                            int soluongsanphamton = sanPhamBUS.SoLuongTon(MaSanPham);
                            int soluongchitietsanphamton = chiTietSanPhamBUS.SoLuongCTTon(chiTietHoaDon.MaChiTietSanPham);
                            if (sanPhamBUS.CapNhatSoLuongTon(MaSanPham, soluongsanphamton - chiTietHoaDon.SoLuong) &&
                                chiTietSanPhamBUS.CapNhatCTSoLuongTon(chiTietHoaDon.MaChiTietSanPham, soluongchitietsanphamton - chiTietHoaDon.SoLuong))
                            {

                            }
                        }
                        else
                        {
                            MessageBox.Show("Có Lỗi Xảy Ra");
                            return;
                        }
                    }
                    printPreviewDialog1.Document = printDocument1;
                    MessageBox.Show("Thanh Toán Thành Công");
                    TrangThai = "Thanh Toán";
                    printPreviewDialog1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra");
                }
                LichSuHoatDong.LichSu(FormMain.MaTaiKhoan, "Xử Lý Thanh Toán: " + txtMaHoaDon.Text + ",Khách Hàng: " + txtTenKhachHang.Text + " Số Tiền: " + txtThanhTien.Text);
                this.Dispose();
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtTuoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("HÓA ĐƠN", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(350, 20));
            e.Graphics.DrawString("Mã Hóa Đơn: "+txtMaHoaDon.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 60));
            e.Graphics.DrawString("Tên Hóa Đơn: "+txtTenHoaDon.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 85));
            e.Graphics.DrawString("Mã Nhân Viên: "+txtMaNhanVien.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 105));
            e.Graphics.DrawString("Ngày Lập: "+dateTimePickerNgayNhap.Value+"", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(360, 60));
            e.Graphics.DrawString("Khách Hàng: "+txtTenKhachHang.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(360, 85));
            e.Graphics.DrawString("Số điện thoại: "+txtSDT.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(360, 105));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, 175));
            e.Graphics.DrawString("STT", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(20, 190));
            e.Graphics.DrawString("Tên Sản Phẩm", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(90, 190));
            e.Graphics.DrawString("Màu", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(230, 190));
            e.Graphics.DrawString("Kích Cỡ", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(340, 190));
            e.Graphics.DrawString("Số Lượng ", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(450, 190));
            e.Graphics.DrawString("Giá Sản Phẩm", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(600, 190));
            e.Graphics.DrawString("Thành Tiền", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(740, 190));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, 200));
            int point = 220;
            for (int i = 0; i < dataGridViewThanhToan.Rows.Count; i++)
            {
                e.Graphics.DrawString((i+1)+"", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(20, point));
                e.Graphics.DrawString(dataGridViewThanhToan.Rows[i].Cells[0].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(90, point));
                e.Graphics.DrawString(dataGridViewThanhToan.Rows[i].Cells[1].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(230, point));
                e.Graphics.DrawString(dataGridViewThanhToan.Rows[i].Cells[2].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(340, point));
                e.Graphics.DrawString(dataGridViewThanhToan.Rows[i].Cells[4].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(450, point));
                e.Graphics.DrawString(dataGridViewThanhToan.Rows[i].Cells[3].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(600, point));
                e.Graphics.DrawString(dataGridViewThanhToan.Rows[i].Cells[5].Value.ToString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(740, point));
                point += 25;
            }
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, point));
            e.Graphics.DrawString("Tiền Thuế: "+txtTienThue.Text+"VND",
                new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(600, point += 25));
            e.Graphics.DrawString("Tiền Khuyến Mãi: "+txtTienKhuyenMai.Text+"VND",
               new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(600, point += 25));
            e.Graphics.DrawString("Thành Tiền: "+txtThanhTien.Text+"VND",
               new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(600, point += 25));
            e.Graphics.DrawString("Tổng Tiền Hóa Đơn: "+txtTongTienHoaDon.Text+"VND",
               new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(600, point += 25));
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if(txtSDT.Text.Length == 10)
            {
                if (khachHangBUS.ThongTinKhachHang(txtSDT.Text) != null)
                {
                    KhachHang khachhang=khachHangBUS.ThongTinKhachHang(txtSDT.Text);
                    txtTenKhachHang.Text = khachhang.TenKhachHang;
                    txtTuoi.Text = khachhang.Tuoi+"";
                }
                else
                {
                    txtTuoi.Text = "";
                    txtTenKhachHang.Text = "";
                }
            }
        }
    }
}
