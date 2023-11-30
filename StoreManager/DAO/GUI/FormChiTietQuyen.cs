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
    public partial class FormChiTietQuyen : Form
    {
        ChiTietQuyenBUS chiTietQuyenBUS=new ChiTietQuyenBUS();
        NhomQuyenBUS nhomQuyenBUS=new NhomQuyenBUS();  
        ChucNangBUS chucNangBUS=new ChucNangBUS();  
        public FormChiTietQuyen()
        {
            InitializeComponent();
            formTimKiem2.txtTimKiem.TextChanged += new EventHandler(Search);
            formTimKiem2.btnTimKiem.Visible = false;    
        }

        private void FormChiTietQuyen_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void Search(object sender, EventArgs e)
        {
            if(formTimKiem2.txtTimKiem.Text==" " || formTimKiem2.txtTimKiem.Text == "")
            {
                LoadData();
                formTimKiem2.btnTimKiem.Visible = false;
            }
            else
            {
                LoadData(formTimKiem2.txtTimKiem.Text);
                formTimKiem2.btnTimKiem.Visible = true;
            }
        }
        private void dataGridViewChitietQuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = dataGridViewChitietQuyen.Columns[e.ColumnIndex].Name;
            if (name == "Sua")
            {
                FormChiTietQuyenModel model = new FormChiTietQuyenModel();
            }
            else if (name == "Xoa")
            {
                if(MessageBox.Show("Bạn Có Muốn Xóa","Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int MaNhomQuyen = Convert.ToInt32(nhomQuyenBUS.MaNhomQuyen(dataGridViewChitietQuyen.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    int MaChucNang= Convert.ToInt32(chucNangBUS.getMaChucNang(dataGridViewChitietQuyen.Rows[e.RowIndex].Cells[1].Value.ToString()));
                    string HanhDong = dataGridViewChitietQuyen.Rows[e.RowIndex].Cells[2].Value.ToString();
                    if (chiTietQuyenBUS.XoaChiTietQuyen(MaNhomQuyen,MaChucNang,HanhDong))
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
        public void LoadData()
        {
            dataGridViewChitietQuyen.Rows.Clear();
            foreach(var i in chiTietQuyenBUS.getChiTietQuyen())
            {
                dataGridViewChitietQuyen.Rows.Add(nhomQuyenBUS.TenNhomQuyen(i.MaNhomQuyen), chucNangBUS.TenChucNang(i.MaChucNang), i.HanhDong);
            }
            dataGridViewChitietQuyen.ClearSelection();
        }
        public void LoadData(string text)
        {
            dataGridViewChitietQuyen.Rows.Clear();
            foreach (var i in chiTietQuyenBUS.TimKiemChiTietQuyen(text))
            {
                dataGridViewChitietQuyen.Rows.Add(nhomQuyenBUS.TenNhomQuyen(i.MaNhomQuyen), chucNangBUS.TenChucNang(i.MaChucNang), i.HanhDong);
            }
            dataGridViewChitietQuyen.ClearSelection();
        }
        public void LamMoiButtonThem(FormChiTietQuyenModel model)
        {
            
            model.btnSua.Visible = false;
            model.btnThem.Visible = true;
        }
        public void LamMoiButtonSua(FormChiTietQuyenModel model) 
        {
            
            model.btnSua.Visible = true;
            model.btnThem.Visible = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            FormChiTietQuyenModel model = new FormChiTietQuyenModel();
            model.comboxChucNang.DataSource = chucNangBUS.MaChucNang();
            model.comboxNhomQuyen.DataSource = nhomQuyenBUS.DanhSachTenNhomQuyen();
            LamMoiButtonThem(model);
            model.ShowDialog();
            LoadData();
            
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridViewChitietQuyen.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcel = new Microsoft.Office.Interop.Excel.Application();
                xcel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < 4; i++)
                {
                    xcel.Cells[1, i] = dataGridViewChitietQuyen.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridViewChitietQuyen.Rows.Count; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        xcel.Cells[i + 2, j + 1] = dataGridViewChitietQuyen.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcel.Columns.AutoFit();
                xcel.Visible = true;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlBook;
            Microsoft.Office.Interop.Excel.Worksheet xlSheet;
            Microsoft.Office.Interop.Excel.Range xlRange;
            int xlRow;
            string tenFile;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tenFile = openFileDialog1.FileName;
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlBook = xlApp.Workbooks.Open(tenFile);
                xlSheet = xlBook.Worksheets["Sheet1"];
                xlRange = xlSheet.UsedRange;

                for (xlRow = 2; xlRow <= xlRange.Rows.Count; xlRow++)
                {
                    if (xlRange.Cells[xlRow, 1].Text != "")
                    {

                        int MaNhomQuyen = nhomQuyenBUS.MaNhomQuyen(xlRange.Cells[xlRow, 1].Text);
                        int MaChucNang = chucNangBUS.getMaChucNang(xlRange.Cells[xlRow, 2].Text);
                        string hanhdong = xlRange.Cells[xlRow, 3].Text;

                        if (chiTietQuyenBUS.kiemTraHanhDong(MaNhomQuyen, MaChucNang, hanhdong) == false)
                        {
                            ChiTietQuyen chiTietQuyen = new ChiTietQuyen();
                            chiTietQuyen.MaNhomQuyen = MaNhomQuyen;
                            chiTietQuyen.MaNhomQuyen = MaChucNang;
                            chiTietQuyen.HanhDong = hanhdong;
                            if (chiTietQuyenBUS.ThemChiTietQuyen(chiTietQuyen))
                            {

                            }
                        }
                    }

                }
                LoadData();
                xlBook.Close();
                xlApp.Quit();
            }
        }
    }
}
