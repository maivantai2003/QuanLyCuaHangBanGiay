using BUS;
using DTO;
using GUI.KIEMTRA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GUI
{
    public partial class FormChatLieuModel : Form
    {
        ChatLieuBUS chatLieuBUS=new ChatLieuBUS();
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
        public FormChatLieuModel()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ChatLieu chatLieu = new ChatLieu();
            chatLieu.TenChatLieu = txtTenChatLieu.Text;
            chatLieu.TrangThai = 1;
            if (KiemTraLoi.KiemTraRong(txtTenChatLieu.Text))
            {
                MessageBox.Show("Vui Lòng Nhập");
            }
            else
            {
                if (chatLieuBUS.KiemTraChatLieu(txtTenChatLieu.Text))
                {
                    MessageBox.Show("Chất Liệu Đã  Tồn Tại");
                }
                else
                {
                    if (chatLieuBUS.ThemChatLieu(chatLieu))
                    {
                        MessageBox.Show("Thêm thành công");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ChatLieu chatLieu = new ChatLieu();
            chatLieu.MaChatLieu = Convert.ToInt32(txtMaChatLieu.Text);
            chatLieu.TenChatLieu = txtTenChatLieu.Text;
            
            if (KiemTraLoi.KiemTraRong(txtTenChatLieu.Text))
            {
                MessageBox.Show("Vui Lòng Nhập");
            }
            else
            {
                if (chatLieuBUS.KiemTraChatLieu(txtTenChatLieu.Text))
                {
                    MessageBox.Show("Chất Liệu Đã  Tồn Tại");
                }
                else
                {
                    if (chatLieuBUS.SuaChatLieu(chatLieu))
                    {
                        MessageBox.Show("Sửa thành công");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
            }
        }
    }
}
