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

namespace GUI
{
    public partial class FormPhieuTra : Form
    {
        NhanVienBUS nhanVienBUS=new NhanVienBUS();
        PhieuTraBUS phieuTraBUS=new PhieuTraBUS();
        HoaDonBUS hoaDonBUS=new HoaDonBUS();
        int Manhanvien;
        public FormPhieuTra(int manhanvien)
        {
            Manhanvien = manhanvien;
            InitializeComponent();
            formTimKiem2.txtTimKiem.TextChanged += new EventHandler(Search);
            formTimKiem2.btnTimKiem.Visible = false;
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormPhieuTraModel model=new FormPhieuTraModel();
            model.txtTenNhanVien.Text = Manhanvien+"-"+ nhanVienBUS.TenNhanVien(Manhanvien);
            model.txtMaPhieuTra.Text = phieuTraBUS.MaLonNhat() + 1 + "";
            model.comboBoxMaHoaDon.DataSource = hoaDonBUS.DanhSachMaHoaDon();
            model.txtNgayTra.Text = DateTime.Now.ToString("dd/MM/yyyy");
            LamMoiButtonThem(model);
            model.ShowDialog();
            LoadData();
        }
        public void LamMoiButtonThem(FormPhieuTraModel model)
        {
            model.btnThem.Visible = true;
        }
        public void LamMoiButtonSua(FormPhieuTraModel model)
        {
           
            model.btnThem.Visible = false;
        }
        public void LoadData()
        {
            dataGridViewPhieuTra.Rows.Clear();
            foreach(var i in phieuTraBUS.getPhieuTra())
            {
                dataGridViewPhieuTra.Rows.Add(i.MaPhieuTra,nhanVienBUS.TenNhanVien(Convert.ToInt32(i.MaNhanVien)),i.MaHoaDon,i.NgayTra,i.TongSoLuongTra,i.TongTienTra);
            }
            dataGridViewPhieuTra.ClearSelection();
        }
        public void LoadData(string text)
        {
            dataGridViewPhieuTra.Rows.Clear();
            foreach (var i in phieuTraBUS.TimKiemPhieuTra(text))
            {
                dataGridViewPhieuTra.Rows.Add(i.MaPhieuTra, nhanVienBUS.TenNhanVien(Convert.ToInt32(i.MaNhanVien)), i.MaHoaDon, i.NgayTra, i.TongSoLuongTra, i.TongTienTra);
            }
            dataGridViewPhieuTra.ClearSelection();
        }

        private void FormPhieuTra_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridViewPhieuTra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string tencot = dataGridViewPhieuTra.Columns[e.ColumnIndex].Name;
            if (tencot == "ChiTiet")                                             
            {
                int maphieutra = Convert.ToInt32(dataGridViewPhieuTra.Rows[e.RowIndex].Cells[0].Value.ToString());
                FormXemChiTietPhieuTra chitietphieutra=new FormXemChiTietPhieuTra(maphieutra);
                chitietphieutra.ShowDialog();
                dataGridViewPhieuTra.ClearSelection();
            }else if (tencot == "Xoa")
            {
                if (MessageBox.Show("Bạn Có Muốn Xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (phieuTraBUS.XoaPhieuTra(Convert.ToInt32(dataGridViewPhieuTra.Rows[e.RowIndex].Cells[0].Value.ToString())))
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridViewPhieuTra.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcel = new Microsoft.Office.Interop.Excel.Application();
                xcel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < 7; i++)
                {
                    xcel.Cells[1, i] = dataGridViewPhieuTra.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridViewPhieuTra.Rows.Count; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        xcel.Cells[i + 2, j + 1] = dataGridViewPhieuTra.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcel.Columns.AutoFit();
                xcel.Visible = true;
            }
        }
    }
}
