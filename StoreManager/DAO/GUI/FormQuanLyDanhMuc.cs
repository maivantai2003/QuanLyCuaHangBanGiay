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
    public partial class FormQuanLyDanhMuc : Form
    {
        ChiTietQuyenBUS chiTietQuyenBUS=new ChiTietQuyenBUS();
        ChucNangBUS chucNangBUS=new ChucNangBUS();  
        Form activeForm = null;
        public FormTheLoai theLoai = new FormTheLoai();
        public FormThuongHieu thuongHieu =new FormThuongHieu();
        public FormChatLieu chatLieu = new FormChatLieu();
        public FormKichCo kichCo =new FormKichCo();
        public FormMauSac mauSac = new FormMauSac();
        int Maquyen;
        string Tenchucnang;
        //int Mataikhoan;

        public FormQuanLyDanhMuc(int maquyen, string tenchucnang)
        {
            InitializeComponent();
            btnMauSac.Click += new EventHandler(Click);
            btnKichCo.Click += new EventHandler(Click);
            btnTheLoai.Click+=new EventHandler(Click); 
            btnChatLieu.Click+= new EventHandler(Click);
            btnThuongHieu.Click += new EventHandler(Click);
            Maquyen = maquyen;
            Tenchucnang = tenchucnang;
            thuongHieu = new FormThuongHieu();
            thuongHieu.dataGridViewThuongHieu.Columns["Xoa"].Visible = chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Xóa");
            thuongHieu.dataGridViewThuongHieu.Columns["Sua"].Visible = chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Sửa");
            thuongHieu.btnThem.Visible = chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Thêm");
           
            btnThuongHieu.BackColor = SystemColors.GradientInactiveCaption;
            OpenForm(thuongHieu);
        }

        private void BtnThuongHieu_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void Click(object sender, EventArgs e)
        {
            Button check = sender as Button;
            check.BackColor = SystemColors.GradientInactiveCaption;
            foreach (Button button in flowLayoutPanelButton.Controls.OfType<Button>())
            {
                if (button != check)
                {
                    button.BackColor = SystemColors.Window;
                }
            }
        }
        public void OpenForm(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            else
            {
                activeForm = form;
            }
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelQuanLyDanhMuc.Controls.Add(form);
            panelQuanLyDanhMuc.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void btnThuongHieu_Click(object sender, EventArgs e)
        {
            thuongHieu=new FormThuongHieu();
            thuongHieu.dataGridViewThuongHieu.Columns["Xoa"].Visible = chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Xóa");
            thuongHieu.dataGridViewThuongHieu.Columns["Sua"].Visible= chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Sửa");
            thuongHieu.btnThem.Visible= chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Thêm");
            OpenForm(thuongHieu);
        }
        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            theLoai=new FormTheLoai();
            theLoai.btnThem.Visible = chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Thêm");
            theLoai.dataGridViewTheLoai.Columns["Sua"].Visible = chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Sửa") ;
            theLoai.dataGridViewTheLoai.Columns["Xoa"].Visible = chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Xóa");
            OpenForm(theLoai);
        }

        private void btnChatLieu_Click(object sender, EventArgs e)
        {
            chatLieu=new FormChatLieu();
            chatLieu.btnThem.Visible= chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Thêm");
            chatLieu.dataGridViewChatLieu.Columns["Sua"].Visible= chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Sửa");
            chatLieu.dataGridViewChatLieu.Columns["Xoa"].Visible = chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Xóa");
            OpenForm(chatLieu);
        }

        private void btnKichCo_Click(object sender, EventArgs e)
        {
            kichCo=new FormKichCo();
            kichCo.btnThem.Visible= chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Thêm");
            kichCo.dataGridViewKichCo.Columns["Sua"].Visible= chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Sửa");
            kichCo.dataGridViewKichCo.Columns["Xoa"].Visible= chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Xóa");
            OpenForm(kichCo);
        }

        private void btnMauSac_Click(object sender, EventArgs e)
        {
            mauSac=new FormMauSac(); 
            mauSac.btnThem.Visible = chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Thêm");
            mauSac.dataGridViewMauSac.Columns["Sua"].Visible= chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Sửa");
            mauSac.dataGridViewMauSac.Columns["Xoa"].Visible = chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Xóa"); ;
            OpenForm(mauSac);
        }
    }
}
