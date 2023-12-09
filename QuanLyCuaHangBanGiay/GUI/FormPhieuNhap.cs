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
    public partial class FormPhieuNhap : Form
    {
        PhieuNhapBUS phieuNhapBUS=new PhieuNhapBUS();
        NhaCungCapBUS nhaCungCapBUS = new NhaCungCapBUS();
        NhanVienBUS nhanVienBUS=new NhanVienBUS();
        int Manhanvien;
        public FormPhieuNhap(int manhanvien)
        {
            InitializeComponent();
            Manhanvien=manhanvien;
            formTimKiem2.txtTimKiem.TextChanged += new EventHandler(Search);
            formTimKiem2.btnTimKiem.Visible = false;
        }

        /*private void btnThem_Click(object sender, EventArgs e)
        {
            FormPhieuNhapModel model=new FormPhieuNhapModel();
            model.txtMaPhieuNhap.Text = phieuNhapBUS.MaLonNhat() + 1+"";
            model.txtMaNhanVien.Text = ""+1+"-"+nhanVienBUS.TenNhanVien(1);
            model.txtTenPhieuNhap.Text = "Phiếu nhập hàng";
            model.txtNgayNhap.Text = DateTime.Now.ToString("dd/MM/yyyy");
            model.comboxMaNhaCungCap.DataSource = nhaCungCapBUS.DanhSachTenNhaCungCap();
            LamMoiButtonThem(model);
            model.ShowDialog();
            LoadData();
        }*/

        private void dataGridViewPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string tencot = dataGridViewPhieuNhap.Columns[e.ColumnIndex].Name;
            if (tencot == "ChiTiet")
            {
                FormXemChiTietPhieuNhap ctpn=new FormXemChiTietPhieuNhap(Convert.ToInt32(dataGridViewPhieuNhap.Rows[e.RowIndex].Cells[0].Value.ToString()));
                ctpn.ShowDialog();
                dataGridViewPhieuNhap.ClearSelection();
            }
            else if (tencot == "Xoa")
            {
                if(MessageBox.Show("Bạn Có Muốn Xóa","Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (phieuNhapBUS.XoaPhieuNhap(Convert.ToInt32(dataGridViewPhieuNhap.Rows[e.RowIndex].Cells[0].Value.ToString())))
                    {
                        MessageBox.Show("Xóa Thành Công");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa Không Thành Công");
                    }
                }
            }
        }
        public void Search(object sender, EventArgs e)
        {
            if (formTimKiem2.txtTimKiem.Text == " " || formTimKiem2.txtTimKiem.Text == "")
            {
                formTimKiem2.btnTimKiem.Visible = false;
                LoadData();
            }
            else
            {
                formTimKiem2.btnTimKiem.Visible = true;
                LoadData(formTimKiem2.txtTimKiem.Text);
            }
        }
        public void LoadData() 
        {
            dataGridViewPhieuNhap.Rows.Clear();
            foreach(var i in phieuNhapBUS.GetPhieuNhap())
            {
                if (i.TrangThai == 1)
                {
                    dataGridViewPhieuNhap.Rows.Add(i.MaPhieuNhap, nhaCungCapBUS.TenNhaCungCap(i.MaNhaCungCap), nhanVienBUS.TenNhanVien(i.MaNhanVien), i.NgayNhap, i.TenPhieuNhap, i.TongTienNhap.ToString("0"));
                }
            }
            dataGridViewPhieuNhap.ClearSelection();
        }
        public void LoadData(string text)
        {
            dataGridViewPhieuNhap.Rows.Clear();
            foreach (var i in phieuNhapBUS.TimKiemPhieuNhap(text))
            {
                if (i.TrangThai == 1)
                {
                    dataGridViewPhieuNhap.Rows.Add(i.MaPhieuNhap, nhaCungCapBUS.TenNhaCungCap(i.MaNhaCungCap), nhanVienBUS.TenNhanVien(i.MaNhanVien), i.TenPhieuNhap, i.NgayNhap, i.TongTienNhap.ToString("0"));
                }
            }
            dataGridViewPhieuNhap.ClearSelection();
        }
        public void LamMoiButtonThem(FormPhieuNhapModel model)
        {
            model.btnSua.Visible = false;
            model.btnThem.Visible = true;
        }
        public void LamMoiButtonSua(FormSanPhamModel model)
        {
            model.btnSua.Visible = true;
            model.btnThem.Visible = false;
        }
        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        /*private void btnThem_Click_1(object sender, EventArgs e)
        {
            FormPhieuNhapModel model = new FormPhieuNhapModel();
            model.txtMaPhieuNhap.Text = phieuNhapBUS.MaLonNhat() + 1 + "";
            model.txtMaNhanVien.Text = "" + 1 + "-" + nhanVienBUS.TenNhanVien(Manhanvien);
            model.txtTenPhieuNhap.Text = "Phiếu nhập hàng";
            model.txtNgayNhap.Text = DateTime.Now.ToString("dd/MM/yyyy");
            model.comboxMaNhaCungCap.DataSource = nhaCungCapBUS.DanhSachTenNhaCungCap();
            LamMoiButtonThem(model);
            model.ShowDialog();
            LoadData();
        }*/

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormPhieuNhapModel model = new FormPhieuNhapModel();
            
            model.txtMaPhieuNhap.Text = phieuNhapBUS.MaLonNhat() + 1 + "";
            model.txtMaNhanVien.Text = Manhanvien + "-" + nhanVienBUS.TenNhanVien(Manhanvien);
            model.txtTenPhieuNhap.Text = "Phiếu nhập hàng";
            model.txtNgayNhap.Text = DateTime.Now.ToString("dd/MM/yyyy");
            model.comboxMaNhaCungCap.DataSource = nhaCungCapBUS.DanhSachTenNhaCungCap();
            LamMoiButtonThem(model);
            model.ShowDialog();
            LoadData();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridViewPhieuNhap.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcel = new Microsoft.Office.Interop.Excel.Application();
                xcel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < 7; i++)
                {
                    xcel.Cells[1, i] = dataGridViewPhieuNhap.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridViewPhieuNhap.Rows.Count; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        xcel.Cells[i + 2, j + 1] = dataGridViewPhieuNhap.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcel.Columns.AutoFit();
                xcel.Visible = true;
            }
        }
    }
}
