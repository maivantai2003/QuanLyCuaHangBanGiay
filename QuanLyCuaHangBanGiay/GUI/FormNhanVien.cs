using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormNhanVien : Form
    {
        NhanVienBUS nhanVienBUS=new NhanVienBUS();
        public FormNhanVien()
        {
            InitializeComponent();
            formTimKiem2.btnTimKiem.Visible = false;
            formTimKiem2.txtTimKiem.TextChanged += new EventHandler(Search);
        }
        private void Search(object sender, EventArgs e)
        {
            if (formTimKiem2.txtTimKiem.Text == "" || formTimKiem2.txtTimKiem.Text == " ")
            {
                LoadData();
                formTimKiem2.btnTimKiem.Visible = false;
            }
            else
            {
                formTimKiem2.btnTimKiem.Visible = true;
                LoadData(formTimKiem2.txtTimKiem.Text);
            }
        }
        private void dataGridViewNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string tencot = dataGridViewNhanVien.Columns[e.ColumnIndex].Name;
            if (tencot == "Sua")
            {
                FormNhanVienModel model = new FormNhanVienModel();
                model.txtMaNhanVien.Text= dataGridViewNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                model.txtTenNhanVien.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                model.txtTuoi.Text= dataGridViewNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                model.txtSoDienThoai.Text= dataGridViewNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                MemoryStream ms = new MemoryStream((byte[])dataGridViewNhanVien.CurrentRow.Cells[4].Value);
                model.pictureAnhNhanVien.Image = Image.FromStream(ms);
                LamMoiButtonSua(model);
                model.ShowDialog();
                LoadData();
            }
            else if (tencot == "Xoa")
            {
                if(MessageBox.Show("Bạn Có Muốn Xóa","Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    if (nhanVienBUS.XoaNhanVien(Convert.ToInt32(dataGridViewNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString())))
                    {
                        MessageBox.Show("Xóa Thành Công");
                        LoadData();
                        
                    }
                }
            }else if(tencot == "ChiTiet")
            {
                FormXemChiTietNhanVien chiTietNhanVien = new FormXemChiTietNhanVien();
                chiTietNhanVien.txtMaNhanVien.Text= dataGridViewNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString(); 
                chiTietNhanVien.txtTenNhanVien.Text= dataGridViewNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                chiTietNhanVien.txtTuoi.Text= dataGridViewNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                chiTietNhanVien.txtSoDienThoai.Text= dataGridViewNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                MemoryStream ms=new MemoryStream((byte[])dataGridViewNhanVien.CurrentRow.Cells[4].Value);
                chiTietNhanVien.pictureAnhNhanVien.Image = Image.FromStream(ms);
                chiTietNhanVien.ShowDialog();
                dataGridViewNhanVien.ClearSelection();
            }
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            dataGridViewNhanVien.Rows.Clear();
            foreach(var i in nhanVienBUS.getNhanVien())
            {
                dataGridViewNhanVien.Rows.Add(i.MaNhanVien, i.TenNhanVien, i.Tuoi, i.SoDienThoai, i.HinhAnh);
            }
            dataGridViewNhanVien.ClearSelection();
        }
        public void LoadData(string text)
        {
            dataGridViewNhanVien.Rows.Clear();
            foreach (var i in nhanVienBUS.TimKiemNhanVien(text))
            {
                dataGridViewNhanVien.Rows.Add(i.MaNhanVien, i.TenNhanVien, i.Tuoi, i.SoDienThoai, i.HinhAnh);
            }
            dataGridViewNhanVien.ClearSelection();
        }
        public void LamMoiButtonSua(FormNhanVienModel model)
        {
            model.lbMaNhanVien.Visible = true;
            model.txtMaNhanVien.Visible = true;
            model.btnSua.Visible = true;
            model.btnThem.Visible = false;
            model.btnThoat.Visible = true;
        }
        public void LamMoiButtonThem(FormNhanVienModel model)
        {
            model.lbMaNhanVien.Visible = false;
            model.txtMaNhanVien.Visible = false;
            model.btnSua.Visible = false;
            model.btnThem.Visible = true;
            model.btnThoat.Visible = true;
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            FormNhanVienModel model = new FormNhanVienModel();
            LamMoiButtonThem(model);
            model.ShowDialog();
            LoadData();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridViewNhanVien.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcel = new Microsoft.Office.Interop.Excel.Application();
                xcel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < 6; i++)
                {
                    xcel.Cells[1, i] = dataGridViewNhanVien.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridViewNhanVien.Rows.Count; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        xcel.Cells[i + 2, j + 1] = dataGridViewNhanVien.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcel.Columns.AutoFit();
                xcel.Visible = true;
            }
        }
    }
}
