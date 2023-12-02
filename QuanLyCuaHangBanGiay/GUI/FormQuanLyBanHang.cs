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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace GUI
{
    public partial class FormQuanLyBanHang : Form
    {
        ChucNangBUS chucNangBUS=new ChucNangBUS();
        ChiTietQuyenBUS chiTietQuyenBUS = new ChiTietQuyenBUS();  
        FormHoaDon hoaDon=null;
        FormPhieuTra phieuTra=null;
        FormBanHang banHang = null;
        int Maquyen;
        string Tenchucnang;
        int Manhanvien;
        Form activeForm = null;
        public FormQuanLyBanHang(int maquyen, string tenchucnang,int manhanvien)
        {
            InitializeComponent();
            btnBanHang.Click += new EventHandler(Click);
            btnHoaDon.Click += new EventHandler(Click);
            btnPhieuTra.Click += new EventHandler(Click);
            Maquyen= maquyen;
            Tenchucnang= tenchucnang;
            Manhanvien= manhanvien;
            hoaDon = new FormHoaDon();
            hoaDon.dataGridViewHoaDon.Columns["Xoa"].Visible = chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Xóa");
            btnHoaDon.BackColor = SystemColors.GradientInactiveCaption;
            OpenForm(hoaDon);
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
        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            hoaDon = new FormHoaDon();
            hoaDon.dataGridViewHoaDon.Columns["Xoa"].Visible = chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Xóa");
            OpenForm(hoaDon);   
        }

        private void btnPhieuTra_Click(object sender, EventArgs e)
        {
            phieuTra = new FormPhieuTra(Manhanvien);
            phieuTra.btnThem.Visible= chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Thêm");
            phieuTra.dataGridViewPhieuTra.Columns["Xoa"].Visible = chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Xóa");
            OpenForm(phieuTra);
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
            panelQuanLyBanHang.Controls.Add(form);
            panelQuanLyBanHang.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            banHang = new FormBanHang(Manhanvien);
            OpenForm(banHang);
        }
    }
}
