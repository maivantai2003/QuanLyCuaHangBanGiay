using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace GUI
{
    public partial class FormSanPham : Form
    {
        SanPhamBUS sanPhamBUS=new SanPhamBUS();
        ChatLieuBUS chatLieuBUS=new ChatLieuBUS();  
        ThuongHieuBUS thuongHieuBUS = new ThuongHieuBUS(); 
        TheLoaiBUS theLoaiBUS = new TheLoaiBUS();
        MauSacBUS mauSacBUS = new MauSacBUS();
        KichCoBUS kichCoBUS=new KichCoBUS();
        ChiTietSanPhamBUS chiTietSanPhamBUS = new ChiTietSanPhamBUS();
        int i;
        public FormSanPham()
        {
            InitializeComponent();
            formTimKiem2.txtTimKiem.TextChanged += new EventHandler(Search);
            formTimKiem2.btnTimKiem.Visible = false;
        }
        /*private void btnThem_Click(object sender, EventArgs e)
        {
            FormSanPhamModel model = new FormSanPhamModel();
            model.txtMaSanPham.Text = (sanPhamBUS.KhoaLonNhat() + 1)+"";
            model.comboxChatLieu.DataSource = chatLieuBUS.DanhSachChatLieu();
            model.comboxTheLoai.DataSource = theLoaiBUS.DanhSachTheLoai();
            model.comboxThuongHieu.DataSource = thuongHieuBUS.DanhSachThuongHieu();
            model.comboxTenMau.DataSource = mauSacBUS.DanhSachTenMauSac();
            model.comboxKichCo.DataSource = kichCoBUS.DanhSachTenKichCo();
            LamMoiButtonThem(model);
            model.ShowDialog();
            LoadData();
        }*/
        public void LoadData()
        {
            dataGridViewSanPham.Rows.Clear();
            foreach(var i in sanPhamBUS.GetSanPham())
            {
                dataGridViewSanPham.Rows.Add(i.MaSanPham,thuongHieuBUS.TenThuongHieu(i.MaThuongHieu),theLoaiBUS.TenTheLoai(i.MaTheLoai),
                    chatLieuBUS.TenChatLieu(i.MaChatLieu),i.TenSanPham,i.GiaSanPham,i.GiaNhap.ToString("0"),i.SoLuongNhap,i.SoLuongTon);
            }
            dataGridViewSanPham.ClearSelection();
        }
        public void LoadData(string text)
        {
            dataGridViewSanPham.Rows.Clear();
            foreach (var i in sanPhamBUS.TimKiemSanPham(text))
            {
                dataGridViewSanPham.Rows.Add(i.MaSanPham, thuongHieuBUS.TenThuongHieu(i.MaThuongHieu), theLoaiBUS.TenTheLoai(i.MaTheLoai),
                    chatLieuBUS.TenChatLieu(i.MaChatLieu), i.TenSanPham, i.GiaSanPham.ToString("0"), i.GiaNhap.ToString("0"), i.SoLuongNhap, i.SoLuongTon);
            }
            dataGridViewSanPham.ClearSelection();
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
        private void dataGridViewSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            string name = dataGridViewSanPham.Columns[e.ColumnIndex].Name;
            if (name == "Sua")
            {
                FormSanPhamModel model=new FormSanPhamModel();
                model.txtMaSanPham.Text = dataGridViewSanPham.Rows[e.RowIndex].Cells[0].Value.ToString();
                model.txtTenSanPham.Text= dataGridViewSanPham.Rows[e.RowIndex].Cells[4].Value.ToString();
                model.comboxThuongHieu.Text= dataGridViewSanPham.Rows[e.RowIndex].Cells[1].Value.ToString();
                model.comboxTheLoai.Text= dataGridViewSanPham.Rows[e.RowIndex].Cells[2].Value.ToString();
                model.comboxChatLieu.Text = dataGridViewSanPham.Rows[e.RowIndex].Cells[3].Value.ToString();
                model.txtGiaSanPham.Text= dataGridViewSanPham.Rows[e.RowIndex].Cells[5].Value.ToString();
                model.txtGiaNhap.Text= dataGridViewSanPham.Rows[e.RowIndex].Cells[6].Value.ToString();
                model.txtGiaNhap.ReadOnly = false;
                model.txtGiaSanPham.ReadOnly = true;
                LamMoiButtonSua(model);
                model.txtGiaNhap.ReadOnly = true;
                model.txtGiaSanPham.ReadOnly = false;
                model.LoadData(Convert.ToInt32(model.txtMaSanPham.Text));
                model.ShowDialog();
                
                LoadData();
            }
            else if (name == "Xoa")
            {
                if(MessageBox.Show("Bạn Có Muốn Xóa","Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (sanPhamBUS.XoaSanPham(Convert.ToInt32(dataGridViewSanPham.Rows[e.RowIndex].Cells[0].Value.ToString())))
                    {
                        MessageBox.Show("Xóa Sản Phẩm Thành Công");
                        LoadData();
                    }
                }
            }
            else if (name == "ChiTiet")
            {
               FormXemChiTietSanPham ctsp=new FormXemChiTietSanPham(Convert.ToInt32(dataGridViewSanPham.Rows[e.RowIndex].Cells[0].Value.ToString()));
               ctsp.ShowDialog();
               dataGridViewSanPham.ClearSelection();
            }
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            btnImport.Visible = false;
            LoadData();
        }
        public void LamMoiButtonThem(FormSanPhamModel model)
        {
            model.btnSua.Visible = false;
            model.btnThem.Visible = true;
        }
        public void LamMoiButtonSua(FormSanPhamModel model)
        {
            model.btnSua.Visible = true;
            model.btnThem.Visible = false;
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            FormSanPhamModel model = new FormSanPhamModel();
            // (sanPhamBUS.KhoaLonNhat() + 1) + ""
            model.txtMaSanPham.Text = (sanPhamBUS.KhoaLonNhat() + 1) + "";
            model.comboxChatLieu.DataSource = chatLieuBUS.DanhSachChatLieu();
            model.comboxTheLoai.DataSource = theLoaiBUS.DanhSachTheLoai();
            model.comboxThuongHieu.DataSource = thuongHieuBUS.DanhSachThuongHieu();
            model.comboxTenMau.DataSource = mauSacBUS.DanhSachTenMauSac();
            model.comboxKichCo.DataSource = kichCoBUS.DanhSachTenKichCo();
            LamMoiButtonThem(model);
            model.ShowDialog();
            LoadData();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridViewSanPham.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcel = new Microsoft.Office.Interop.Excel.Application();
                xcel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < 10; i++)
                {
                    xcel.Cells[1, i] = dataGridViewSanPham.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridViewSanPham.Rows.Count; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        xcel.Cells[i + 2, j + 1] = dataGridViewSanPham.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcel.Columns.AutoFit();
                xcel.Visible = true;
            }
        }

        private void formTimKiem2_Load(object sender, EventArgs e)
        {

        }
    }
}
