using BUS;
using DTO;
using GUI.KIEMTRA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormSanPhamModel : Form
    {
        MauSacBUS mauSacBUS = new MauSacBUS();
        KichCoBUS kichCoBUS = new KichCoBUS();
        ChatLieuBUS chatLieuBUS = new ChatLieuBUS(); 
        TheLoaiBUS theLoaiBUS=new TheLoaiBUS();
        ThuongHieuBUS thuongHieuBUS = new ThuongHieuBUS();  
        SanPhamBUS sanPhamBUS = new SanPhamBUS();
        ChiTietSanPhamBUS chiTietSanPhamBUS = new ChiTietSanPhamBUS();
        int i;
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
        public FormSanPhamModel()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        public void LoadData(int masanpham)
        {
            foreach(var i in chiTietSanPhamBUS.DanhSachChiTietSanPham(masanpham))
            {
                string[] s = i.Split(',');
                dataGridChiTietSanPham.Rows.Add(s[1], s[2], chiTietSanPhamBUS.HinhAnh(Convert.ToInt32(s[7])));
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (comboxChatLieu.Text == "")
            {
                comboxChatLieu.Focus();
                MessageBox.Show("Không Được Để Trống");
                return;
            }
            else if (comboxTheLoai.Text == "")
            {
                comboxTheLoai.Focus();
                MessageBox.Show("Không Được Để Trống");
                return;
            }
            else if (comboxThuongHieu.Text == "")
            {
                comboxThuongHieu.Focus();
                MessageBox.Show("Không được đê trống");
                return;
            }
            else if (txtTenSanPham.Text == "")
            {
                txtTenSanPham.Focus();
                MessageBox.Show("Không Được Để Trống");
                return;
            }else if (KiemTraLoi.KiemTraRong(txtGiaNhap.Text))
            {
                txtGiaNhap.Focus();
                MessageBox.Show("Vui Lòng Nhập Giá");
                return;
            }
            else if (dataGridChiTietSanPham.Rows.Count <= 0)
            {
                MessageBox.Show("Vui Lòng Không Được Để Trống");
            }
            else
            {
                SanPham sanPham = new SanPham();
                sanPham.MaSanPham = Convert.ToInt32(txtMaSanPham.Text);
                sanPham.MaChatLieu = chatLieuBUS.MaChatLieu(comboxChatLieu.Text);
                sanPham.MaTheLoai = theLoaiBUS.MaTheLoai(comboxTheLoai.Text);
                sanPham.MaThuongHieu = thuongHieuBUS.MaThuongHieu(comboxThuongHieu.Text);
                sanPham.GiaNhap = Convert.ToSingle(txtGiaNhap.Text);
                sanPham.TenSanPham = txtTenSanPham.Text;
                sanPham.TrangThai = 1;
                sanPham.GiaSanPham = Convert.ToSingle(txtGiaSanPham.Text);
                sanPham.SoLuongTon = 0;
                sanPham.SoLuongNhap = 0;
                if (sanPhamBUS.ThemSanPham(sanPham))
                {
                    for (int i = 0; i < dataGridChiTietSanPham.Rows.Count; i++)
                    {
                        ChiTietSanPham chiTietSanPham = new ChiTietSanPham();
                        chiTietSanPham.MaSanPham = Convert.ToInt32(txtMaSanPham.Text);
                        chiTietSanPham.MaMauSac = Convert.ToInt32(mauSacBUS.MaMau(dataGridChiTietSanPham.Rows[i].Cells[0].Value.ToString()));
                        chiTietSanPham.MaKichCo = Convert.ToInt32(kichCoBUS.MaKichCo(dataGridChiTietSanPham.Rows[i].Cells[1].Value.ToString()));
                        MemoryStream ms = new MemoryStream((byte[])dataGridChiTietSanPham.Rows[i].Cells[2].Value);
                        chiTietSanPham.HinhAnh = ms.ToArray();
                        chiTietSanPham.TrangThai = 1;
                        chiTietSanPham.SoLuongNhap = 0;
                        chiTietSanPham.SoLuongTon = 0;
                        if (chiTietSanPhamBUS.ThemChiTietSanPham(chiTietSanPham)==false)
                        {
                            MessageBox.Show("Error");
                            return;
                        }
                    }
                }
                LichSuHoatDong.LichSu(FormMain.MaTaiKhoan, "Thêm Vào Sản Phẩm Mới: " + sanPham.MaSanPham + "-" + sanPham.TenSanPham);
                this.Dispose();
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtGiaNhap.Text=="" || txtGiaSanPham.Text=="" || txtTenSanPham.Text=="")
            {
                MessageBox.Show("Vui Lòng Không Được Để Trống");
            }
            else
            {
                SanPham sanPham = new SanPham();
                sanPham.MaSanPham = Convert.ToInt32(txtMaSanPham.Text);
                sanPham.MaChatLieu = chatLieuBUS.MaChatLieu(comboxChatLieu.Text);
                sanPham.MaTheLoai = theLoaiBUS.MaTheLoai(comboxTheLoai.Text);
                sanPham.MaThuongHieu = thuongHieuBUS.MaThuongHieu(comboxThuongHieu.Text);
                sanPham.TenSanPham = txtTenSanPham.Text;
                sanPham.GiaSanPham = Convert.ToSingle(txtGiaSanPham.Text);
                if (sanPhamBUS.SuaSanPham(sanPham))
                {
                    MessageBox.Show("Sửa Giá Sản Phẩm Thành Công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa Không Thành Công");
                }
            }
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            if (KiemTra(comboxTenMau.Text, comboxKichCo.Text))
            {
                MessageBox.Show("Chi Tiết Sản Phẩm Đã Có");
            }else if (pictureBoxAnhSanPham.Image==null)
            {
                MessageBox.Show("Vui Lòng Chọn Ảnh Sản Phẩm");
            }
            else
            {
                MemoryStream memstr = new MemoryStream();
                pictureBoxAnhSanPham.Image.Save(memstr, pictureBoxAnhSanPham.Image.RawFormat);
                dataGridChiTietSanPham.Rows.Add(comboxTenMau.Text, comboxKichCo.Text,memstr.ToArray());
            }
            
        }
        public bool KiemTra(string tenmau,string kichco)
        {
            for(int i=0;i<dataGridChiTietSanPham.Rows.Count;i++)
            {
                if(tenmau== dataGridChiTietSanPham.Rows[i].Cells[0].Value.ToString() && dataGridChiTietSanPham.Rows[i].Cells[1].Value.ToString() == kichco)
                {
                    return true;
                }
            }
            return false;
        }
        private void dataGridChiTietSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string tencot = dataGridChiTietSanPham.Columns[e.ColumnIndex].Name;
            if(tencot == "Xoa")
            {
                dataGridChiTietSanPham.Rows.RemoveAt(e.RowIndex);
                ClearText();
            }
            else
            {
                comboxTenMau.Text= dataGridChiTietSanPham.Rows[e.RowIndex].Cells[0].Value.ToString();
                comboxKichCo.Text = dataGridChiTietSanPham.Rows[e.RowIndex].Cells[1].Value.ToString();
                MemoryStream ms = new MemoryStream((byte[])dataGridChiTietSanPham.Rows[e.RowIndex].Cells[2].Value);
                pictureBoxAnhSanPham.Image = Image.FromStream(ms);
            }
            i=e.RowIndex;
            
        }
        public void ClearText()
        {
            comboxKichCo.DataSource = kichCoBUS.DanhSachTenKichCo();
            comboxTenMau.DataSource= mauSacBUS.DanhSachTenMauSac();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dataGridChiTietSanPham.Rows.Count>0)
            {
                if (KiemTra(comboxTenMau.Text, comboxKichCo.Text))
                {
                    MessageBox.Show("Chi Tiết Sản Phẩm Đã Có");
                }
                else
                {
                    dataGridChiTietSanPham.Rows[i].Cells[0].Value = comboxTenMau.Text;
                    dataGridChiTietSanPham.Rows[i].Cells[1].Value = comboxKichCo.Text;
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Chi Tiết Sản Phẩm Cần Cập Nhật");
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Select image(*.jpg;*.png;*Gif)|*.jpg;*.png;*Gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxAnhSanPham.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtGiaSanPham_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
