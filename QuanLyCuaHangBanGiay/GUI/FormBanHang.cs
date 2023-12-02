using BUS;
using GUI.KIEMTRA;
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
    public partial class FormBanHang : Form
    {
        HoaDonBUS hoaDonBUS=new HoaDonBUS();
        ChiTietSanPhamBUS chiTietSanPhamBUS=new ChiTietSanPhamBUS();
        NhanVienBUS nhanVienBUS=new NhanVienBUS();
        int Manhanvien;
        public FormBanHang(int MaNhanVien)
        {
            InitializeComponent();
            Manhanvien = MaNhanVien;
            btnClear.Text = "";
            btnClear.Visible = false;
        }
        int vt = 0;
        int i;
        string mausac, kickco;
        public void btnHuy_Click(object sender, EventArgs e)
        {
            Clear();
            dataGridViewDanhSachSanPham.Rows[vt].Selected=false;
            dataGridViewChiTietHoaDon.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewChiTietHoaDon.Rows.Count==0)
            {
                MessageBox.Show("Vui Lòng Nhập Sản Phẩm");
            }
            else
            {
                List<string> list = new List<string>();
                for (int i = 0; i < dataGridViewChiTietHoaDon.Rows.Count; i++)
                {
                    list.Add(dataGridViewChiTietHoaDon.Rows[i].Cells[0].Value.ToString() + "," + dataGridViewChiTietHoaDon.Rows[i].Cells[1].Value.ToString()
                        + "," + dataGridViewChiTietHoaDon.Rows[i].Cells[2].Value.ToString() + "," + dataGridViewChiTietHoaDon.Rows[i].Cells[3].Value.ToString()
                        + "," + dataGridViewChiTietHoaDon.Rows[i].Cells[4].Value.ToString() + "," + dataGridViewChiTietHoaDon.Rows[i].Cells[5].Value.ToString()
                        );
                }
                FormThanhToan formThanhToan = new FormThanhToan(list);
                formThanhToan.txtMaNhanVien.Text = Manhanvien + "-" + nhanVienBUS.TenNhanVien(Manhanvien);
                formThanhToan.ShowDialog();
                if(formThanhToan.TrangThai=="Thanh Toán")
                {
                    dataGridViewChiTietHoaDon.Rows.Clear();
                    LoadData();
                }
                
            }
        }

        private void dataGridViewDanhSachSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenSanPham.Text = dataGridViewDanhSachSanPham.Rows[e.RowIndex].Cells[1].Value.ToString();
            mausac= dataGridViewDanhSachSanPham.Rows[e.RowIndex].Cells[5].Value.ToString();
            kickco= dataGridViewDanhSachSanPham.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtGiaSanPham.Text= dataGridViewDanhSachSanPham.Rows[e.RowIndex].Cells[7].Value.ToString();
            vt = e.RowIndex;
        }
        public bool KiemTra(string tensanpham,string mausac,string kichco)
        {
            for(int i=0;i<dataGridViewChiTietHoaDon.Rows.Count;i++)
            {
                if (dataGridViewChiTietHoaDon.Rows[i].Cells[0].Value.ToString()==tensanpham && dataGridViewChiTietHoaDon.Rows[i].Cells[1].Value.ToString() == mausac
                    && dataGridViewChiTietHoaDon.Rows[i].Cells[2].Value.ToString() == kichco)
                {
                    vt = i;
                    return true;
                }
            }
            return false; 
        }
        private void btnThemCT_Click(object sender, EventArgs e)
        {
            if (KiemTra(txtTenSanPham.Text, mausac, kickco))
            {
                MessageBox.Show("Sản Phẩm Đã Có");
            }else if (numericSoLuong.Value==0)
            {
                MessageBox.Show("Vui Lòng Nhập Số Lượng Mua");
            }
            else
            {
                if (numericSoLuong.Value > Convert.ToInt32(dataGridViewDanhSachSanPham.Rows[vt].Cells[9].Value.ToString()))
                {
                    MessageBox.Show("Số Lượng Bán Không Hợp Lệ");
                }
                else
                {
                    dataGridViewChiTietHoaDon.Rows.Add(txtTenSanPham.Text, mausac, kickco, txtGiaSanPham.Text, numericSoLuong.Value, txtThanhTien.Text);
                    Clear();
                    dataGridViewDanhSachSanPham.Rows[vt].Selected = false;
                    txtTK.Text = "";
                }
                /*dataGridViewChiTietHoaDon.Rows.Add(txtTenSanPham.Text, mausac, kickco, txtGiaSanPham.Text, numericSoLuong.Value, txtThanhTien.Text);
                Clear();
                dataGridViewDanhSachSanPham.Rows[vt].Selected = false;*/
            }
        }
        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            if (dataGridViewChiTietHoaDon.Rows.Count>0)
            {
                dataGridViewChiTietHoaDon.Rows[i].Cells[4].Value = numericSoLuong.Value;
                dataGridViewChiTietHoaDon.Rows[i].Cells[5].Value = txtThanhTien.Text;
                Clear();
            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập Sản Phẩm Cần Sửa");
            }
        }
        public void Clear()
        {
            mausac = "";
            kickco = "";
            numericSoLuong.Value = 0;
            txtGiaSanPham.Text = "0";
            txtTenSanPham.Text = "";
            txtThanhTien.Text = "0";
        }
        private void numericSoLuong_ValueChanged(object sender, EventArgs e)
        {
            if (txtTenSanPham.Text!="" && txtGiaSanPham.Text!="")
            {
                float tmp = Convert.ToInt32(numericSoLuong.Value) * Convert.ToSingle(txtGiaSanPham.Text);
                txtThanhTien.Text = tmp.ToString("0");
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Sản Phẩm Cần Mua");
                numericSoLuong.Value = 0;
            }
            
        }

        private void dataGridViewChiTietHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i=e.RowIndex;
            string tencot = dataGridViewChiTietHoaDon.Columns[e.ColumnIndex].Name;
            if (tencot == "Xoa")
            {
                dataGridViewChiTietHoaDon.Rows.RemoveAt(i);
            }
            else
            {
                txtTenSanPham.Text = dataGridViewChiTietHoaDon.Rows[i].Cells[0].Value.ToString();
                txtGiaSanPham.Text= dataGridViewChiTietHoaDon.Rows[i].Cells[3].Value.ToString();
                numericSoLuong.Value = Convert.ToInt32(dataGridViewChiTietHoaDon.Rows[i].Cells[4].Value.ToString());
                txtThanhTien.Text= dataGridViewChiTietHoaDon.Rows[i].Cells[5].Value.ToString();
            }
        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (KiemTraLoi.KiemTraRong(txtTK.Text))
            {
                btnClear.Visible = false;
                LoadData();
            }
            else
            {
                btnClear.Visible = true;
                LoadData(txtTK.Text);
            }
        }
        public void LoadData()
        {
            dataGridViewDanhSachSanPham.Rows.Clear();
            foreach(var i in hoaDonBUS.DanhSachSanPham())
            {
                string[]s=i.Split(',');
                dataGridViewDanhSachSanPham.Rows.Add(s[0], s[1], s[2], s[3], s[4], s[5], s[6], s[7], chiTietSanPhamBUS.HinhAnh(Convert.ToInt32(s[9])), s[8]);

            }
            dataGridViewDanhSachSanPham.ClearSelection();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTK.Text = "";
            btnClear.Visible = false;   
        }

        public void LoadData(string text)
        {
            dataGridViewDanhSachSanPham.Rows.Clear();
            foreach (var i in hoaDonBUS.TimKiemSanPhamBan(text))
            {
                string[] s = i.Split(',');
                dataGridViewDanhSachSanPham.Rows.Add(s[0], s[1], s[2], s[3], s[4], s[5], s[6], s[7], chiTietSanPhamBUS.HinhAnh(Convert.ToInt32(s[9])), s[8]);

            }
            dataGridViewDanhSachSanPham.ClearSelection();
        }

    }
}
