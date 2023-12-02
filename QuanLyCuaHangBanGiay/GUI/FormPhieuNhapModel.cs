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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormPhieuNhapModel : Form
    {
        PhieuNhapBUS phieuNhapBUS=new PhieuNhapBUS();
        SanPhamBUS sanPhamBUS=new SanPhamBUS();
        ChatLieuBUS chatLieuBUS = new ChatLieuBUS();
        ThuongHieuBUS thuongHieuBUS = new ThuongHieuBUS();  
        TheLoaiBUS theLoaiBUS=new TheLoaiBUS();
        KichCoBUS kichCoBUS=new KichCoBUS();
        MauSacBUS mauSacBUS=new MauSacBUS();
        ChiTietSanPhamBUS chiTietSanPhamBUS = new ChiTietSanPhamBUS();
        ChiTietPhieuNhapBUS chiTietPhieuNhapBUS = new ChiTietPhieuNhapBUS();
        NhaCungCapBUS nhaCungCapBUS = new NhaCungCapBUS();
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
        int i;
        int vt;
        public FormPhieuNhapModel() 
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            List<string> str = phieuNhapBUS.DanhSachSanPhamNhap();
            foreach (var i in str)
            {
                string[] s = i.Split(',');
                int masanpham = Convert.ToInt32(s[0]);
                int mamau = mauSacBUS.MaMau(s[2]);
                int makichco = kichCoBUS.MaKichCo(s[3]);
                int n = chiTietSanPhamBUS.MaChiTietSanPham(masanpham, makichco, mamau);
                dataGridViewSanPham.Rows.Add(s[0], s[1], s[2], s[3], s[4], chiTietSanPhamBUS.HinhAnh(n));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTenPhieuNhap.Text=="")
            {
                MessageBox.Show("Vui Lòng Nhập Tên Phiếu Nhập");
            }
            else
            {
                if (Check(txtMaCTSP.Text))
                {
                    MessageBox.Show("Sản Phẩm Đã Có");
                    ClearText();    
                }
                else if (numSoLuongNhap.Value == 0)
                {
                    MessageBox.Show("Vui Lòng Nhập Số Lượng");
                }
                else if (txtGiaNhap.Text == "")
                {
                    MessageBox.Show("Vui Lòng Nhập Giá Nhập");
                }
                else
                {
                    dataGridViewChiTietPhieuNhap.Rows.Add(txtMaCTSP.Text, comboxDonVi.Text, numSoLuongNhap.Value, txtGiaNhap.Text, txtThanhTien.Text);
                    txtTongTienNhap.Text = TongTienNhap().ToString("0") + "";
                    dataGridViewSanPham.Rows[vt].Selected = false;
                    ClearText();
                }
            }
        }
        public bool Check(string machitietsanpham)
        {
            for (int i = 0; i < dataGridViewChiTietPhieuNhap.Rows.Count; i++)
            {
                if (dataGridViewChiTietPhieuNhap.Rows[i].Cells[0].Value.ToString() == machitietsanpham)
                {
                    return true;
                }
            }
            return false;
        }
        public float TongTienNhap()
        {
            float s = 0.0f; 
            for(int i = 0; i < dataGridViewChiTietPhieuNhap.Rows.Count; i++)
            {
                s += Convert.ToSingle(dataGridViewChiTietPhieuNhap.Rows[i].Cells[4].Value.ToString());
            }
            return s;
        }
        private void dataGridViewSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            ClearText();
            int masanpham = Convert.ToInt32(dataGridViewSanPham.Rows[e.RowIndex].Cells[0].Value.ToString());
            int mamau = mauSacBUS.MaMau(dataGridViewSanPham.Rows[e.RowIndex].Cells[2].Value.ToString());
            int makichco = kichCoBUS.MaKichCo(dataGridViewSanPham.Rows[e.RowIndex].Cells[3].Value.ToString());
            txtMaCTSP.Text = chiTietSanPhamBUS.MaChiTietSanPham(masanpham,makichco,mamau)+"";
            txtGiaNhap.Text = dataGridViewSanPham.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void dataGridViewChiTietPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            string tencot = dataGridViewChiTietPhieuNhap.Columns[e.ColumnIndex].Name;
            if (tencot=="Xoa")
            {
                if(MessageBox.Show("Bạn Có Muốn Xóa","Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dataGridViewChiTietPhieuNhap.Rows.RemoveAt(e.RowIndex);
                    ClearText();
                }
                
            }
            else
            {
                txtMaCTSP.Text = dataGridViewChiTietPhieuNhap.Rows[e.RowIndex].Cells[0].Value.ToString();
                comboxDonVi.Text = dataGridViewChiTietPhieuNhap.Rows[e.RowIndex].Cells[1].Value.ToString();
                numSoLuongNhap.Value = Convert.ToInt32(dataGridViewChiTietPhieuNhap.Rows[e.RowIndex].Cells[2].Value.ToString());
                txtGiaNhap.Text = dataGridViewChiTietPhieuNhap.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtThanhTien.Text = dataGridViewChiTietPhieuNhap.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void numSoLuongNhap_ValueChanged(object sender, EventArgs e)
        {
            if (numSoLuongNhap.Value == 0)
            {
                txtThanhTien.Text = "";
            }
            else
            {
                try
                {
                    float tmp = Convert.ToSingle(txtGiaNhap.Text) * Convert.ToInt32(numSoLuongNhap.Value);
                    txtThanhTien.Text=tmp.ToString("0");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Chưa Nhập Giá Nhập");
                }
                
            }
        }
        public void ClearText()
        {
            txtMaCTSP.Text = "";
            txtThanhTien.Text = "";
            txtGiaNhap.Text = "";
            numSoLuongNhap.Value = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            if(dataGridViewChiTietPhieuNhap.Rows.Count >0 && i >= 0 && txtGiaNhap.Text!="" && txtThanhTien.Text!="")
            {
                dataGridViewChiTietPhieuNhap.Rows[i].Cells[1].Value = comboxDonVi.Text;
                dataGridViewChiTietPhieuNhap.Rows[i].Cells[2].Value = numSoLuongNhap.Value;
                dataGridViewChiTietPhieuNhap.Rows[i].Cells[3].Value = txtGiaNhap.Text;
                dataGridViewChiTietPhieuNhap.Rows[i].Cells[4].Value = txtThanhTien.Text;
                txtTongTienNhap.Text = TongTienNhap().ToString("0") + "";
                ClearText();
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Chi Tiết Cần Cập Nhật");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dataGridViewChiTietPhieuNhap.Rows.Count < 0)
            {
                MessageBox.Show("Vui Lòng Nhập Chi Tiết Sản Phẩm");
            }
            else if (txtTongTienNhap.Text=="")
            {
                MessageBox.Show("Phiếu Chưa Có Sản Phẩm Cần Nhập");
            }
            else
            {
                PhieuNhap phieunhap = new PhieuNhap();
                phieunhap.MaPhieuNhap = Convert.ToInt32(txtMaPhieuNhap.Text);
                phieunhap.MaNhaCungCap = nhaCungCapBUS.MaNhaCungCap(comboxMaNhaCungCap.Text);
                phieunhap.MaNhanVien = Convert.ToInt32(txtMaNhanVien.Text.Split('-')[0]);
                phieunhap.NgayNhap = DateTime.Now;
                phieunhap.TenPhieuNhap = txtTenPhieuNhap.Text;
                phieunhap.TongTienNhap = Convert.ToSingle(txtTongTienNhap.Text);
                phieunhap.TrangThai = 1;
                if (phieuNhapBUS.ThemPhieuNhap(phieunhap))
                {
                    for (int i = 0; i < dataGridViewChiTietPhieuNhap.Rows.Count; i++)
                    {
                        ChiTietPhieuNhap chitietphieunhap = new ChiTietPhieuNhap();
                        chitietphieunhap.MaPhieuNhap = phieunhap.MaPhieuNhap;
                        chitietphieunhap.MaChiTietSanPham = Convert.ToInt32(dataGridViewChiTietPhieuNhap.Rows[i].Cells[0].Value.ToString());
                        chitietphieunhap.DonVi = dataGridViewChiTietPhieuNhap.Rows[i].Cells[1].Value.ToString();
                        chitietphieunhap.SoLuongNhap = Convert.ToInt32(dataGridViewChiTietPhieuNhap.Rows[i].Cells[2].Value.ToString());
                        chitietphieunhap.TienNhap = Convert.ToSingle(dataGridViewChiTietPhieuNhap.Rows[i].Cells[3].Value.ToString());
                        chitietphieunhap.ThanhTien = Convert.ToSingle(dataGridViewChiTietPhieuNhap.Rows[i].Cells[4].Value.ToString());

                        if (chiTietPhieuNhapBUS.ThemChiTietPhieuNhap(chitietphieunhap))
                        {
                            int soluongctnhap = chiTietSanPhamBUS.SoLuongCTNhap(chitietphieunhap.MaChiTietSanPham);
                            int soluongtonctnhap = chiTietSanPhamBUS.SoLuongCTTon(chitietphieunhap.MaChiTietSanPham);
                            if (chiTietSanPhamBUS.CapNhatCTSoLuongNhap(chitietphieunhap.MaChiTietSanPham, chitietphieunhap.SoLuongNhap+soluongctnhap) &&
                                chiTietSanPhamBUS.CapNhatCTSoLuongTon(chitietphieunhap.MaChiTietSanPham,soluongtonctnhap+chitietphieunhap.SoLuongNhap)
                                )
                            {
                                int masp = chiTietSanPhamBUS.MaSanPham(chitietphieunhap.MaChiTietSanPham);
                                int soluongsanphamnhap = sanPhamBUS.SoLuongNhap(masp);
                                int soluongsanphamton = sanPhamBUS.SoLuongTon(masp);
                                if (sanPhamBUS.CapNhatSoLuongNhap(masp,soluongsanphamnhap + chitietphieunhap.SoLuongNhap) &&
                                    sanPhamBUS.CapNhatSoLuongTon(masp, soluongsanphamton + chitietphieunhap.SoLuongNhap))
                                {

                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Có Lỗi Khi Nhập");
                            return;
                        }
                    }
                }
                LichSuHoatDong.LichSu(FormMain.MaTaiKhoan, "Tạo Phiếu Nhập Hàng: " +phieunhap.MaPhieuNhap+"-"+phieunhap.MaNhaCungCap+":"+ nhaCungCapBUS.TenNhaCungCap(phieunhap.MaNhaCungCap) + "-" +phieunhap.TongTienNhap.ToString("0"));
                this.Close();
            }
        }
    }
}
