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
    public partial class FormLichSuMuaHang : Form
    {
        public FormLichSuMuaHang(List<string> lichsumuahang,string tenkhachhang,string sodienthoai)
        {
            InitializeComponent();
            lbTenKhachHang.Text = "Tên Khách Hàng: " + tenkhachhang;
            lbSDT.Text = "Số Điện Thoại: " + sodienthoai;
            foreach (var i in lichsumuahang)
            {
                string[] s = i.Split(',');
                dataGridViewLichSuMuaHang.Rows.Add(s[0], s[1], s[2]);
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewLichSuMuaHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string tencot = dataGridViewLichSuMuaHang.Columns[e.ColumnIndex].Name;
            if (tencot == "ChiTiet")
            {
                int mahoadon = Convert.ToInt32(dataGridViewLichSuMuaHang.Rows[e.RowIndex].Cells[0].Value.ToString());
                FormXemChiTietHoaDon chitiethoadon = new FormXemChiTietHoaDon(mahoadon);
                chitiethoadon.ShowDialog();
            }
        }
    }
}
