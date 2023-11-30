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
    public partial class FormKhachHang : Form
    {
        KhachHangBUS khachHangBUS=new KhachHangBUS();
        HoaDonBUS hoaDonBUS = new HoaDonBUS();  
        public FormKhachHang()
        {
            InitializeComponent();
            formTimKiem2.txtTimKiem.TextChanged += new EventHandler(Search);
            formTimKiem2.btnTimKiem.Visible = false;
        }
        public void LoadData()
        {
            dataGridViewKhachHang.Rows.Clear();
            foreach(var i in khachHangBUS.getKhachHang())
            {
                dataGridViewKhachHang.Rows.Add(i.MaKhachHang,i.TenKhachHang,i.Tuoi,i.SoDienThoai,i.DiaChi);
            }
            dataGridViewKhachHang.ClearSelection();
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
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData(string text)
        {
            dataGridViewKhachHang.Rows.Clear();
            foreach (var i in khachHangBUS.TimKiemKhachHang(text))
            {
                dataGridViewKhachHang.Rows.Add(i.MaKhachHang, i.TenKhachHang, i.Tuoi, i.SoDienThoai, i.DiaChi);
            }
            dataGridViewKhachHang.ClearSelection();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridViewKhachHang.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcel = new Microsoft.Office.Interop.Excel.Application();
                xcel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < 6; i++)
                {
                    xcel.Cells[1, i] = dataGridViewKhachHang.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridViewKhachHang.Rows.Count; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        xcel.Cells[i + 2, j + 1] = dataGridViewKhachHang.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcel.Columns.AutoFit();
                xcel.Visible = true;
            }
            else
            {
                MessageBox.Show("Chưa Có Thông Tin");
            }
        }

        private void dataGridViewKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string tencot = dataGridViewKhachHang.Columns[e.ColumnIndex].Name;
            if (tencot == "ChiTiet")
            {
                int makhachhang = Convert.ToInt32(dataGridViewKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString());
                FormLichSuMuaHang lichsumuahang=new FormLichSuMuaHang(hoaDonBUS.LichSuMuaHang(makhachhang), dataGridViewKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString(), dataGridViewKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString());
                lichsumuahang.ShowDialog();
                dataGridViewKhachHang.ClearSelection();
            }
        }
    }
}
