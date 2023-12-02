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
    public partial class FormNhanVienModel : Form
    {
        NhanVienBUS nhanVienBUS=new NhanVienBUS();
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
        public FormNhanVienModel()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (KiemTraLoi.KiemTraRong(txtSoDienThoai.Text))
                {
                    MessageBox.Show("Không Được Để Trống");
                    txtSoDienThoai.Focus();
                    return;
                }else if (KiemTraLoi.KiemTraRong(txtTenNhanVien.Text))
                {
                    MessageBox.Show("Không Được Để Trống");
                    txtTenNhanVien.Focus();
                    return;
                }else if (KiemTraLoi.KiemTraRong(txtTuoi.Text))
                {
                    MessageBox.Show("Không Được Để Trống");
                    txtTuoi.Focus();
                    return;
                }else if (KiemTraLoi.KiemTraSoDienThoai(txtSoDienThoai.Text)==false)
                {
                    MessageBox.Show("Số Điện Thoại Không Hợp Lệ");
                    txtSoDienThoai.Focus();
                    return;
                }
                try
                {
                    int tuoi = Convert.ToInt32(txtTuoi.Text);
                    if (tuoi < 0)
                    {
                        MessageBox.Show("Số Tuổi Không Hợp Lệ");
                        return;
                    }
                    else
                    {
                        NhanVien nhanVien = new NhanVien();
                        nhanVien.Tuoi= tuoi;
                        nhanVien.TenNhanVien = txtTenNhanVien.Text;
                        nhanVien.SoDienThoai= txtSoDienThoai.Text;
                        MemoryStream memstr = new MemoryStream();
                        pictureAnhNhanVien.Image.Save(memstr, pictureAnhNhanVien.Image.RawFormat);
                        nhanVien.HinhAnh = memstr.ToArray();
                        nhanVien.TrangThai = 1;
                        if (nhanVienBUS.ThemNhanVien(nhanVien))
                        {
                            MessageBox.Show("Thêm Thành Công");
                        }
                        this.Dispose(); 
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show("Vui Lòng Nhập Tuổi Là Số");
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSoDienThoai.Text == "")
                {
                    MessageBox.Show("Không Được Để Trống");
                    txtSoDienThoai.Focus();
                    return;
                }
                else if (txtTenNhanVien.Text == "")
                {
                    MessageBox.Show("Không Được Để Trống");
                    txtTenNhanVien.Focus();
                    return;
                }
                else if (txtTuoi.Text == "")
                {
                    MessageBox.Show("Không Được Để Trống");
                    txtTuoi.Focus();
                    return;
                }
                try
                {
                    int tuoi = Convert.ToInt32(txtTuoi.Text);
                    if (tuoi < 0)
                    {
                        MessageBox.Show("Số Tuổi Không Hợp Lệ");
                        return;
                    }
                    else
                    {
                        NhanVien nhanVien = new NhanVien();
                        nhanVien.MaNhanVien = Convert.ToInt32(txtMaNhanVien.Text);
                        nhanVien.Tuoi = tuoi;
                        nhanVien.TenNhanVien = txtTenNhanVien.Text;
                        nhanVien.SoDienThoai = txtSoDienThoai.Text;
                        MemoryStream memstr=new MemoryStream();
                        pictureAnhNhanVien.Image.Save(memstr, pictureAnhNhanVien.Image.RawFormat);
                        nhanVien.HinhAnh = memstr.ToArray();
                        if (nhanVienBUS.SuaNhanVien(nhanVien))
                        {
                            MessageBox.Show("Sửa Thành Công");

                        }
                        this.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());   
                    MessageBox.Show("Vui Lòng Nhập Tuổi Là Số");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Select image(*,JpG;*.png;*Gif)|*,JpG;*.png;*Gif";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureAnhNhanVien.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void txtTuoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
