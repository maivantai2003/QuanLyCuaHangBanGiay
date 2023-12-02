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
    public partial class FormQuanTri : Form
    {
        ChiTietQuyenBUS chiTietQuyenBUS=new ChiTietQuyenBUS();
        ChucNangBUS chucNangBUS = new ChucNangBUS();    
        FormNhomQuyen nhomquyen=null;
        FormChucNang chucNang = null;
        FormChiTietQuyen chiTietQuyen = null; 
        FormTaiKhoan taiKhoan = null;
        Form activeForm = null;
        int Maquyen;
        string Tenchucnang;
        public FormQuanTri(int maquyen, string tenchucnang)
        {
            InitializeComponent();
            btnTaiKhoan.Click += new EventHandler(Click);
            btnChucNang.Click += new EventHandler(Click);
            btnNhomQuyen.Click += new EventHandler(Click);
            btnChiTietQuyen.Click += new EventHandler(Click); 
            Maquyen = maquyen;
            Tenchucnang = tenchucnang;
            taiKhoan = new FormTaiKhoan();
            taiKhoan.btnThem.Visible = chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Thêm");
            taiKhoan.dataGridViewTaiKhoan.Columns["Sua"].Visible = chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Sửa");
            taiKhoan.dataGridViewTaiKhoan.Columns["Xoa"].Visible = chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Xóa");
            
            btnTaiKhoan.BackColor = SystemColors.GradientInactiveCaption;
            OpenForm(taiKhoan);

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
            panelQuanTri.Controls.Add(form);
            panelQuanTri.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            
            taiKhoan = new FormTaiKhoan();
            taiKhoan.btnThem.Visible = chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Thêm");
            taiKhoan.dataGridViewTaiKhoan.Columns["Sua"].Visible = chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Sửa");
            taiKhoan.dataGridViewTaiKhoan.Columns["Xoa"].Visible = chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Xóa");
            OpenForm(taiKhoan);
        }

        private void btnNhomQuyen_Click(object sender, EventArgs e)
        {
            nhomquyen=new FormNhomQuyen();
            nhomquyen.btnThem.Visible = chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Thêm");
            nhomquyen.dataGridViewNhomQuyen.Columns["Sua"].Visible = chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Sửa");
            nhomquyen.dataGridViewNhomQuyen.Columns["Xoa"].Visible = chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Xóa");
            OpenForm(nhomquyen);
        }

        private void btnChucNang_Click(object sender, EventArgs e)
        {
            chucNang=new FormChucNang();
            chucNang.btnThem.Visible = chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Thêm");
            chucNang.dataGridViewChucNang.Columns["Sua"].Visible = chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Sửa");
            chucNang.dataGridViewChucNang.Columns["Xoa"].Visible = chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Xóa");
            OpenForm(chucNang);
        }

        private void btnChiTietQuyen_Click(object sender, EventArgs e)
        {
            chiTietQuyen=new FormChiTietQuyen();
            chiTietQuyen.btnThem.Visible = chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Thêm");
            chiTietQuyen.dataGridViewChitietQuyen.Columns["Sua"].Visible = chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Sửa");
            chiTietQuyen.dataGridViewChitietQuyen.Columns["Xoa"].Visible = chiTietQuyenBUS.kiemTraHanhDong(Maquyen, chucNangBUS.getMaChucNang(Tenchucnang), "Xóa");
            OpenForm(chiTietQuyen);
        }
    }
}
