using BUS;
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
    public partial class FormCTSP : Form
    {
        ChiTietSanPhamBUS chitietsanpham=new ChiTietSanPhamBUS();
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

        public FormCTSP(int masanpham)
        {
            InitializeComponent();
            dataGridViewChiTietSanPham.ClearSelection();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            foreach (var i in chitietsanpham.DanhSachChiTietSanPham(masanpham))
            {
                string[] s = i.Split(',');

                dataGridViewChiTietSanPham.Rows.Add(s[0], s[3], s[4], s[5], s[1], s[2], s[6], chitietsanpham.HinhAnh(Convert.ToInt32(s[7])));
            }

        }        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
