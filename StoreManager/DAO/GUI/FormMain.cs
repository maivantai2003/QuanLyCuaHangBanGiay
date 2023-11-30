using BUS;
using DTO;
using GUI.KIEMTRA;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace GUI
{
    public partial class FormMain : Form
    {
        int i = 0,j=0;
        Form activeForm = null;
        ChiTietQuyenBUS chitietquyenBUS = null;
        ChucNangBUS chucNang = null;
        FormNhanVien formNhanVien = null;
        FormHome formHome = null;
        FormSanPham formSanPham = null;
        FormPhieuNhap formPhieuNhap = null;
        FormQuanLyDanhMuc danhmuc=null;
        FormQuanTri quanTri = null;    
        FormQuanLyBanHang banHang = null;
        FormNhaCungCap formNhaCungCap = null;
        FormThue formThue=null;
        FormkhuyenMai formKhuyenMai = null;
        FormThongKe formThongKe = null;
        FormKhachHang formKhachHang = null;
        NhanVienBUS nhanVien = null;
        NhomQuyenBUS nhomQuyenBUS = null;
        public int MaQuyen;
        //
        public static int MaTaiKhoan;
        //Bo viền
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
        private string ToBgr(Color c) => $"{c.B:X2}{c.G:X2}{c.R:X2}";

        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        const int DWWMA_CAPTION_COLOR = 35;
        const int DWWMA_BORDER_COLOR = 34;
        const int DWMWA_TEXT_COLOR = 36;
        public void CustomWindow(Color captionColor, Color fontColor, Color borderColor, IntPtr handle)
        {
            IntPtr hWnd = handle;
            //Change caption color
            int[] caption = new int[] { int.Parse(ToBgr(captionColor), System.Globalization.NumberStyles.HexNumber) };
            DwmSetWindowAttribute(hWnd, DWWMA_CAPTION_COLOR, caption, 4);
            //Change font color
            int[] font = new int[] { int.Parse(ToBgr(fontColor), System.Globalization.NumberStyles.HexNumber) };
            DwmSetWindowAttribute(hWnd, DWMWA_TEXT_COLOR, font, 4);
            //Change border color
            int[] border = new int[] { int.Parse(ToBgr(borderColor), System.Globalization.NumberStyles.HexNumber) };
            DwmSetWindowAttribute(hWnd, DWWMA_BORDER_COLOR, border, 4);
        }
        public FormMain(int maquyen, int mataikhoan, string chucnang)
        {
            InitializeComponent();
            chitietquyenBUS = new ChiTietQuyenBUS();
            chucNang =new ChucNangBUS();
            nhanVien = new NhanVienBUS();
            nhomQuyenBUS = new NhomQuyenBUS();
            string name = nhanVien.TenNhanVien(mataikhoan);
            lbTenNhanVien.Text = "Tên Nhân Viên: " + name;
            lbChucVu.Text = "Chức Vụ: " + nhomQuyenBUS.TenNhomQuyen(maquyen);
            if (nhomQuyenBUS.TenNhomQuyen(maquyen) == "Admin" || nhomQuyenBUS.TenNhomQuyen(maquyen)=="Quản Lý")
            {
                lbLichSu.Visible = true;
            }
            else
            {
                lbLichSu.Visible = false;
            }
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            Button btnHome = new Button();
            btnHome.Text = "Trang Chủ";
            string t= Path.GetDirectoryName(Application.ExecutablePath);
            int index = t.LastIndexOf('\\');
            string sub= t.Substring(0, index-4);
            string path = sub+@"\IMG\";
            btnHome.Image = Image.FromFile(path+ "home.png");
            btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnHome.Size = new System.Drawing.Size(248, 43);
            btnHome.Padding=new System.Windows.Forms.Padding(17, 0, 0, 0);
            btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += new EventHandler(Click);
            btnHome.BackColor= SystemColors.GradientInactiveCaption;
            
            panelButton.Controls.Add(btnHome);
            OpenForm(new FormHome());
            string[] tmp = null;
            if (!String.IsNullOrEmpty(chucnang))
            {
                tmp = chucnang.Split(',');
                foreach (var i in tmp)
                {
                    string tenchucnang = chucNang.TenChucNang(Convert.ToInt32(i));
                    Button btn = new Button();
                    btn.Text = tenchucnang;
                    
                    if (btn.Text == "Danh Mục Sản Phẩm")
                    {
                        btn.Image = Image.FromFile(path + "order.png");
                      
                    }
                    else if (btn.Text == "Quản Trị")
                    {
                        btn.Image = Image.FromFile(path + "management.png");
                      
                    }
                    else if (btn.Text == "Nhập Hàng")
                    {
                        btn.Image = Image.FromFile(path + "package.png");
                      
                    }
                    else if (btn.Text == "Bán Hàng")
                    {
                        btn.Image = Image.FromFile(path + "trade.png");
                       
                    }
                    else if (btn.Text == "Trang Chủ")
                    {
                        btn.Image = Image.FromFile(path + "home.png");
                       
                    }
                    else if (btn.Text == "Nhân Viên")
                    {
                        btn.Image = Image.FromFile(path + "employee.png");
                       
                    }
                    else if (btn.Text == "Nhà Cung Cấp")
                    {
                        btn.Image = Image.FromFile(path + "inventory.png");
                        
                    }
                    else if (btn.Text == "Khuyến Mãi")
                    {
                        btn.Image = Image.FromFile(path + "promotion.png");
                       
                    }
                    else if (btn.Text == "Thuế")
                    {
                        btn.Image = Image.FromFile(path + "tax.png");
                       
                    }
                    else if (btn.Text == "Thống Kê")
                    {
                        btn.Image = Image.FromFile(path + "analysis.png");
                      
                    }
                    else if (btn.Text == "Sản Phẩm")
                    {
                        btn.Image = Image.FromFile(path + "product.png");
                       
                    }
                    else if (btn.Text == "Khách Hàng")
                    {
                        btn.Image = Image.FromFile(path + "specialist.png");
                        

                    }
                    btn.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
                    btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                    btn.Size= new System.Drawing.Size(248, 43);
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.UseVisualStyleBackColor = true;
                    btn.Click += new EventHandler(Click);
                    panelButton.Controls.Add(btn);
                }
            }
            MaQuyen = maquyen;
            MaTaiKhoan = mataikhoan;
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
            panelMain.Controls.Add(form);
            panelMain.Tag = form;
            form.BringToFront();
            form.Show();
        }
        public void Click(object sender, EventArgs e) {
            Button check = sender as Button;
            int maChucNang = chucNang.getMaChucNang(check.Text);
            check.BackColor = SystemColors.GradientInactiveCaption;

            foreach (Button button in panelButton.Controls.OfType<Button>())
            {
                if (button != check)
                {
                    button.BackColor = SystemColors.Window;
                   
                }
            }
            if (check.Text == "Danh Mục Sản Phẩm")
            {
                danhmuc = new FormQuanLyDanhMuc(MaQuyen, check.Text);
                OpenForm(danhmuc);
            }
            else if (check.Text == "Quản Trị")
            {
                quanTri = new FormQuanTri(MaQuyen, check.Text);
                OpenForm(quanTri);
            } else if (check.Text == "Nhập Hàng")
            {
                formPhieuNhap = new FormPhieuNhap(MaTaiKhoan);
                formPhieuNhap.btnThem.Visible= chitietquyenBUS.kiemTraHanhDong(MaQuyen, maChucNang, "Thêm");
                formPhieuNhap.dataGridViewPhieuNhap.Columns["Xoa"].Visible = chitietquyenBUS.kiemTraHanhDong(MaQuyen, maChucNang, "Xóa");
                OpenForm(formPhieuNhap);
            } else if (check.Text == "Bán Hàng")
            {
                banHang = new FormQuanLyBanHang(MaQuyen, check.Text, MaTaiKhoan);
                OpenForm(banHang);
            } else if (check.Text == "Trang Chủ")
            {
                formHome = new FormHome();
                OpenForm(formHome);
            } else if (check.Text == "Nhân Viên")
            {
                formNhanVien = new FormNhanVien();
                formNhanVien.btnThem.Visible= chitietquyenBUS.kiemTraHanhDong(MaQuyen, maChucNang, "Thêm");
                formNhanVien.dataGridViewNhanVien.Columns["Sua"].Visible= chitietquyenBUS.kiemTraHanhDong(MaQuyen, maChucNang, "Sửa");
                formNhanVien.dataGridViewNhanVien.Columns["Xoa"].Visible= chitietquyenBUS.kiemTraHanhDong(MaQuyen, maChucNang, "Xóa");
                OpenForm(formNhanVien);
            } else if (check.Text == "Nhà Cung Cấp")
            {
                formNhaCungCap = new FormNhaCungCap();
                formNhaCungCap.btnThem.Visible= chitietquyenBUS.kiemTraHanhDong(MaQuyen, maChucNang, "Thêm");
                formNhaCungCap.dataGridViewNhaCungCap.Columns["Sua"].Visible= chitietquyenBUS.kiemTraHanhDong(MaQuyen, maChucNang, "Sửa");
                formNhaCungCap.dataGridViewNhaCungCap.Columns["Xoa"].Visible= chitietquyenBUS.kiemTraHanhDong(MaQuyen, maChucNang, "Xóa");
                OpenForm(formNhaCungCap);
            }
            else if (check.Text == "Khuyến Mãi")
            {
                formKhuyenMai = new FormkhuyenMai();
                formKhuyenMai.btnThem.Visible= chitietquyenBUS.kiemTraHanhDong(MaQuyen, maChucNang, "Thêm");
                formKhuyenMai.dataGridViewKhuyenMai.Columns["Sua"].Visible= chitietquyenBUS.kiemTraHanhDong(MaQuyen, maChucNang, "Sửa");
                formKhuyenMai.dataGridViewKhuyenMai.Columns["Xoa"].Visible= chitietquyenBUS.kiemTraHanhDong(MaQuyen, maChucNang, "Xóa");
                OpenForm(formKhuyenMai);
            } else if (check.Text == "Thuế")
            {
                formThue = new FormThue();
                formThue.btnThem.Visible= chitietquyenBUS.kiemTraHanhDong(MaQuyen, maChucNang, "Thêm");
                formThue.dataGridViewThue.Columns["Sua"].Visible= chitietquyenBUS.kiemTraHanhDong(MaQuyen, maChucNang, "Sửa");
                formThue.dataGridViewThue.Columns["Xoa"].Visible= chitietquyenBUS.kiemTraHanhDong(MaQuyen, maChucNang, "Xóa");
                OpenForm(formThue);
            } else if (check.Text == "Thống Kê")
            {
                formThongKe = new FormThongKe();
                OpenForm(formThongKe);
            } else if (check.Text=="Sản Phẩm") {
                formSanPham = new FormSanPham();
                formSanPham.btnThem.Visible = chitietquyenBUS.kiemTraHanhDong(MaQuyen, maChucNang, "Thêm");
                formSanPham.dataGridViewSanPham.Columns["Sua"].Visible= chitietquyenBUS.kiemTraHanhDong(MaQuyen, maChucNang, "Sửa");
                formSanPham.dataGridViewSanPham.Columns["Xoa"].Visible= chitietquyenBUS.kiemTraHanhDong(MaQuyen, maChucNang, "Xóa");
                OpenForm(formSanPham);
            }else if(check.Text=="Khách Hàng")
            {
                formKhachHang=new FormKhachHang();
                OpenForm(formKhachHang);
            }
        } 
        private void SiderbarTime_Tick(object sender, EventArgs e)
        {
           
        }
        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            string t = Path.GetDirectoryName(Application.ExecutablePath);
            int index = t.LastIndexOf('\\');
            string sub = t.Substring(0, index - 4);

            string path = sub + @"\PHANHOI\phanhoi.txt";
            if (KiemTraLoi.KiemTraRong(txtPhanHoi.Text))
            {
                MessageBox.Show("Vui Lòng Nhập Nội Dung Phản Hồi");
            }
            else
            {
                string txt = DateTime.Now + ":" + MaTaiKhoan + "-" + nhanVien.TenNhanVien(MaTaiKhoan) + "\n" + "Nội Dung Phản Hồi: " + txtPhanHoi.Text + "\n"+"Trả Lời Phản Hồi:"+"\n" + "-----";
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(txt);
                }
                MessageBox.Show("Cám Ơn Bạn Đã Gửi Phản Hồi Để Góp Ý Những Sai Sót Về Hệ Thống");
                txtPhanHoi.Text = "";
            }
            
        }
        private void txtPhanHoi_MouseHover(object sender, EventArgs e)
        {
            this.txtPhanHoi.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelButton_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormXemPhanHoi xemPhanHoi = new FormXemPhanHoi();  
            xemPhanHoi.ShowDialog(); 
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormXemPhanHoi xemLichSu = new FormXemPhanHoi();
            xemLichSu.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLichSuHeThong lichsu=new FormLichSuHeThong();
            lichsu.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            LichSuHoatDong.LichSu(MaTaiKhoan, "Đã Đăng Xuất Khỏi Hệ Thống");
            this.Dispose();
            new Login().ShowDialog();
        }
    }
}
