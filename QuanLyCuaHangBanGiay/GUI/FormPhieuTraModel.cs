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
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormPhieuTraModel : Form
    {
        ChiTietHoaDonBUS chiTietHoaDonBUS=new ChiTietHoaDonBUS();
        PhieuTraBUS phieuTraBUS=new PhieuTraBUS();
        ChiTietPhieuTraBUS chiTietPhieuTraBUS=new ChiTietPhieuTraBUS();
        SanPhamBUS sanPhamBUS = new SanPhamBUS();
        ChiTietSanPhamBUS chiTietSanPhamBUS = new ChiTietSanPhamBUS();
        HoaDonBUS hoaDonBUS=new HoaDonBUS();
        int i;
        int j;
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
        public FormPhieuTraModel()
        {

            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dataGridViewChiTietPhieuTra.Rows.Count<=0)
            {
                MessageBox.Show("Chưa Có Chi Tiết Phiếu Trả Nào");
            }
            else
            {
                if (KiemTraLoi.KiemTraRong(comboBoxMaHoaDon.Text))
                {
                    MessageBox.Show("Hóa Đơn Không Hợp Lệ");
                }
                else if (dataGridViewChiTietPhieuTra.Rows.Count <= 0)
                {
                    MessageBox.Show("Vui Lòng Nhập Chi Tiết Phiếu Trả");
                }
                else
                {
                    PhieuTra phieuTra = new PhieuTra();
                    phieuTra.MaPhieuTra = Convert.ToInt32(txtMaPhieuTra.Text);
                    phieuTra.MaHoaDon = Convert.ToInt32(comboBoxMaHoaDon.Text);
                    phieuTra.MaNhanVien = Convert.ToInt32(txtTenNhanVien.Text.Split('-')[0]);
                    phieuTra.NgayTra = DateTime.Now;
                    phieuTra.TongSoLuongTra = Convert.ToInt32(txtTongSoLuongTra.Text);
                    phieuTra.TongTienTra = Convert.ToSingle(txtTongTienTra.Text);
                    phieuTra.TrangThai = 1;
                    if (phieuTraBUS.ThemPhieuTra(phieuTra))
                    {
                        for (int i = 0; i < dataGridViewChiTietPhieuTra.Rows.Count; i++)
                        {
                            ChiTietPhieuTra chiTietPhieuTra = new ChiTietPhieuTra();
                            chiTietPhieuTra.MaPhieuTra = phieuTra.MaPhieuTra;
                            chiTietPhieuTra.MaChiTietSanPham = Convert.ToInt32(dataGridViewChiTietPhieuTra.Rows[i].Cells[0].Value.ToString());
                            chiTietPhieuTra.LyDoTra = dataGridViewChiTietPhieuTra.Rows[i].Cells[1].Value.ToString();
                            chiTietPhieuTra.GiaSanPham = Convert.ToSingle(dataGridViewChiTietPhieuTra.Rows[i].Cells[2].Value.ToString());
                            chiTietPhieuTra.SoLuong = Convert.ToInt32(dataGridViewChiTietPhieuTra.Rows[i].Cells[3].Value.ToString());
                            chiTietPhieuTra.ThanhTien = Convert.ToSingle(dataGridViewChiTietPhieuTra.Rows[i].Cells[4].Value.ToString());
                            if (chiTietPhieuTraBUS.ThemChiTietPhieuTra(chiTietPhieuTra))
                            {
                                int soluongchitietton = chiTietSanPhamBUS.SoLuongCTTon(chiTietPhieuTra.MaChiTietSanPham);
                                if (chiTietSanPhamBUS.CapNhatCTSoLuongTon(chiTietPhieuTra.MaChiTietSanPham,soluongchitietton+ chiTietPhieuTra.SoLuong))
                                {
                                    int masanpham = chiTietSanPhamBUS.MaSanPham(chiTietPhieuTra.MaChiTietSanPham);
                                    int soluongspton = sanPhamBUS.SoLuongTon(masanpham);
                                    if (sanPhamBUS.CapNhatSoLuongTon(masanpham, soluongspton + chiTietPhieuTra.SoLuong))
                                    {

                                    }
                                }
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                    LichSuHoatDong.LichSu(FormMain.MaTaiKhoan,"Tạo Phiếu Trả Hàng: "+ phieuTra.TongTienTra+" - Số Sản Phẩm Trả: "+phieuTra.TongSoLuongTra);
                    this.Dispose();
                }
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e) { 

        }

        private void FormPhieuTraModel_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewChiTietPhieuTra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            j=e.RowIndex;
            string tencot = dataGridViewChiTietPhieuTra.Columns[e.ColumnIndex].Name;
            if (tencot == "Xoa")
            {
                if (dataGridViewChiTietPhieuTra.Rows.Count>0)
                {
                    dataGridViewChiTietPhieuTra.Rows.RemoveAt(j);
                    txtTongSoLuongTra.Text = TongSoLuong() + "";
                    txtTongTienTra.Text = TongTienTra() + "";
                }
                
            }
            else
            {

            }
        }

        private void dataGridViewChiTietHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            txtMaChiTietSanPham.Text = dataGridViewChiTietHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtGiaSanPham.Text= dataGridViewChiTietHoaDon.Rows[e.RowIndex].Cells[5].Value.ToString();

        }
        public bool KiemTraChiTietPhieuTra(string machitietsanpham)
        {
            for(int i=0;i<dataGridViewChiTietPhieuTra.Rows.Count;i++)
            {
                if (dataGridViewChiTietPhieuTra.Rows[i].Cells[0].Value.ToString() == machitietsanpham)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnThemChiTietPhieuTra_Click(object sender, EventArgs e)
        {
            int mahoadon = Convert.ToInt32(comboBoxMaHoaDon.Text);
            DateTime tmp = hoaDonBUS.NgayMua(mahoadon);
            DateTime ngaytra = DateTime.Now;
            TimeSpan span = ngaytra.Subtract(tmp);
            int numberOfDays = span.Days;
            if (phieuTraBUS.KiemTraHoaDon(mahoadon)==false)
            {
                if (numberOfDays < 2)
                {
                    if (KiemTraChiTietPhieuTra(txtMaChiTietSanPham.Text))
                    {
                        MessageBox.Show("Sản Phẩm Trả Đã Tồn Tại");
                    }
                    else if (numericSLTra.Value > Convert.ToInt32(dataGridViewChiTietHoaDon.Rows[i].Cells[4].Value.ToString()))
                    {
                        MessageBox.Show("Số Lượng Trả Không Được Lớn Hơn Số Lượng Mua");
                    }
                    else if (KiemTraLoi.KiemTraRong(txtMaChiTietSanPham.Text))
                    {
                        MessageBox.Show("Mã Chi Tiết Sản Phẩm Chưa Có");
                    }
                    else if (numericSLTra.Value == 0)
                    {
                        MessageBox.Show("Vui Lòng Nhập Số Lượng Trả");
                    }
                    else if (KiemTraLoi.KiemTraRong(numericSLTra.Value.ToString()))
                    {
                        MessageBox.Show("Số Lượng Sản Phẩm Trả  Chưa Có");
                    }
                    else if (KiemTraLoi.KiemTraRong(txtLyDoTra.Text))
                    {
                        MessageBox.Show("Vui Lòng Nhập Lý Do Trả");
                    }
                    else
                    {
                        dataGridViewChiTietPhieuTra.Rows.Add(txtMaChiTietSanPham.Text, txtLyDoTra.Text, txtGiaSanPham.Text, numericSLTra.Value, txtThanhTien.Text);
                        txtTongSoLuongTra.Text = TongSoLuong() + "";
                        txtTongTienTra.Text = TongTienTra() + "";
                        Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Đã Quá Số Ngày Trả Hàng");
                    Clear();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Sản Phẩm Đã Được Đổi Trả");
                Clear();
                return;
            }
           
           

        }
        public void Clear()
        {
            txtMaChiTietSanPham.Text = "";
            txtGiaSanPham.Text = "0";
            txtLyDoTra.Text = "";
            numericSLTra.Value = 0;
            txtThanhTien.Text="0";
        }
        public int TongSoLuong()
        {
            int tmp = 0;
            for(int i=0;i<dataGridViewChiTietPhieuTra.Rows.Count;i++) {
                tmp += Convert.ToInt32(dataGridViewChiTietPhieuTra.Rows[i].Cells[3].Value.ToString());
            }
            return tmp;
        }
        public float TongTienTra()
        {
            float tmp = 0.0f;
            for (int i = 0; i < dataGridViewChiTietPhieuTra.Rows.Count; i++) {
                tmp += Convert.ToSingle(dataGridViewChiTietPhieuTra.Rows[i].Cells[4].Value.ToString());
            }
            return tmp;
        }
        private void btnCapNhatChiTietPhieuTra_Click(object sender, EventArgs e)
        {
            if (KiemTraLoi.KiemTraRong(txtMaChiTietSanPham.Text))
            {
                MessageBox.Show("Mã Chi Tiết Sản Phẩm Chưa Có");
            }
            else if (numericSLTra.Value == 0)
            {
                MessageBox.Show("Vui Lòng Nhập Số Lượng Trả");
            }
            else if (KiemTraLoi.KiemTraRong(numericSLTra.Value.ToString()))
            {
                MessageBox.Show("Số Lượng Sản Phẩm Trả  Chưa Có");
            }
            else if (KiemTraLoi.KiemTraRong(txtLyDoTra.Text))
            {
                MessageBox.Show("Vui Lòng Nhập Lý Do Trả");
            }
        }

        private void txtMaHoaDon_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBoxMaHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear();
            if (KiemTraLoi.KiemTraRong(comboBoxMaHoaDon.Text))
            {
                MessageBox.Show("Vui Lòng Chọn Hóa Đơn");
            }else
            {
                List<string> ChiTietHoaDon = chiTietHoaDonBUS.ChiTietHoaDon(Convert.ToInt32(comboBoxMaHoaDon.Text));
                dataGridViewChiTietHoaDon.Rows.Clear();
                foreach (var i in ChiTietHoaDon)
                {
                    string[] s = i.Split(',');
                    dataGridViewChiTietHoaDon.Rows.Add(s[0], s[1], s[2], s[3], s[4], s[5], s[6]);
                }
            }
           
        }

        private void numericSLTra_ValueChanged(object sender, EventArgs e)
        {
            if(numericSLTra.Value > 0)
            {
                float tmp=Convert.ToSingle(txtGiaSanPham.Text)*Convert.ToInt32(numericSLTra.Value);
                txtThanhTien.Text = tmp + "";
            }
            
        }
    }
}
