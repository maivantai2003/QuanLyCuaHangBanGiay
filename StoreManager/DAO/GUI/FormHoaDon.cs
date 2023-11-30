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
    public partial class FormHoaDon : Form
    {
        HoaDonBUS hoaDonBUS=new HoaDonBUS();
        KhachHangBUS khachHangBUS=new KhachHangBUS();
        NhanVienBUS NhanVienBUS=new NhanVienBUS();
        public FormHoaDon()
        {
            InitializeComponent();
            formTimKiem2.txtTimKiem.TextChanged += new EventHandler(Search);
            formTimKiem2.btnTimKiem.Visible = false;
        }
        public void LoadData()
        {
            dataGridViewHoaDon.Rows.Clear();
            foreach (var i in hoaDonBUS.getHoaDon())
            {
                dataGridViewHoaDon.Rows.Add(i.MaHoaDon,i.MaKhachHang,NhanVienBUS.TenNhanVien(i.MaNhanVien), i.TenHoaDon, i.NgayLapHoaDon, i.HinhThucThanhToan, i.ThanhTien.ToString("0"), i.TongTien.ToString("0"));
            }
            dataGridViewHoaDon.ClearSelection();
        }
        private void Search(object sender, EventArgs e)
        {
            if(formTimKiem2.txtTimKiem.Text=="" || formTimKiem2.txtTimKiem.Text == " ")
            {
                LoadData();
                formTimKiem2.btnTimKiem.Visible=false;  
            }
            else
            {
                LoadData(formTimKiem2.txtTimKiem.Text);
                formTimKiem2.btnTimKiem.Visible = true;
            }
        }
        public void LoadData(string text)
        {
            dataGridViewHoaDon.Rows.Clear();
            foreach(var i in hoaDonBUS.TimKiemHoaDon(text))
            {
                dataGridViewHoaDon.Rows.Add(i.MaHoaDon, i.MaKhachHang, i.MaNhanVien, i.TenHoaDon, i.NgayLapHoaDon, i.HinhThucThanhToan, i.ThanhTien.ToString("0"), i.TongTien.ToString("0"));
            }
            dataGridViewHoaDon.ClearSelection();
        }
        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridViewHoaDon.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcel = new Microsoft.Office.Interop.Excel.Application();
                xcel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < 9; i++)
                {
                    xcel.Cells[1, i] = dataGridViewHoaDon.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridViewHoaDon.Rows.Count; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        xcel.Cells[i + 2, j + 1] = dataGridViewHoaDon.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcel.Columns.AutoFit();
                xcel.Visible = true;
            }
        }

        private void dataGridViewHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string tencot = dataGridViewHoaDon.Columns[e.ColumnIndex].Name;
            if (tencot == "ChiTiet")
            {
                int mahoadon = Convert.ToInt32(dataGridViewHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString());

                FormCTHD chitiethoadon = new FormCTHD(mahoadon);
                chitiethoadon.ShowDialog(); 
            }
            else if(tencot=="Xoa")
            {
                if (MessageBox.Show("Bạn Có Muốn Xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (hoaDonBUS.XoaHoaDon(Convert.ToInt32(dataGridViewHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString())))
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
    }
}
