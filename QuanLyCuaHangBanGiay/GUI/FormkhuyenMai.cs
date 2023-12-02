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
    public partial class FormkhuyenMai : Form
    {
        KhuyenMaiBUS khuyenMaiBUS=new KhuyenMaiBUS();
        public FormkhuyenMai()
        {
            InitializeComponent();
            formTimKiem2.txtTimKiem.TextChanged += new EventHandler(Search);
            formTimKiem2.btnTimKiem.Visible = false;
        }
        public void Search(object sender, EventArgs e)
        {
            if (formTimKiem2.txtTimKiem.Text == " " || formTimKiem2.txtTimKiem.Text == "")
            {
                formTimKiem2.btnTimKiem.Visible = false;
            }
            else
            {
                formTimKiem2.btnTimKiem.Visible = true;
            }
        }

        private void FormkhuyenMai_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            dataGridViewKhuyenMai.Rows.Clear();
            foreach(var i in khuyenMaiBUS.getAllList())
            {
                dataGridViewKhuyenMai.Rows.Add(i.MaKhuyenMai, i.MucKhuyenMai, i.DieuKien, i.ThoiGianBatDau, i.ThoiGianKetThuc);
            }
            dataGridViewKhuyenMai.ClearSelection();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridViewKhuyenMai.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcel = new Microsoft.Office.Interop.Excel.Application();
                xcel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < 6; i++)
                {
                    xcel.Cells[1, i] = dataGridViewKhuyenMai.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridViewKhuyenMai.Rows.Count; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        xcel.Cells[i + 2, j + 1] = dataGridViewKhuyenMai.Rows[i].Cells[j].Value.ToString();
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

        private void dataGridViewKhuyenMai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string tencot = dataGridViewKhuyenMai.Columns[e.ColumnIndex].Name;
            if (tencot == "Sua")
            {
                FormKhuyenMaiModel model = new FormKhuyenMaiModel();
                model.txtMaKhuyenMai.Text = dataGridViewKhuyenMai.Rows[e.RowIndex].Cells[0].Value.ToString();
                model.txtMucKhuyenMai.Text= dataGridViewKhuyenMai.Rows[e.RowIndex].Cells[1].Value.ToString();
                model.txtDieuKien.Text= dataGridViewKhuyenMai.Rows[e.RowIndex].Cells[2].Value.ToString();
                model.dateTimeThoiGianBatDau.Value= Convert.ToDateTime(dataGridViewKhuyenMai.Rows[e.RowIndex].Cells[3].Value.ToString());
                model.dateTimeThoiGianKetThuc.Value = Convert.ToDateTime(dataGridViewKhuyenMai.Rows[e.RowIndex].Cells[4].Value.ToString());
                LamMoiButtonSua(model);
                model.ShowDialog();
                LoadData();
            }
            else  if(tencot=="Xoa"){
                if (MessageBox.Show("Thông Báo", "Bạn Có Muốn Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (khuyenMaiBUS.XoaKhuyenMai(Convert.ToInt32(dataGridViewKhuyenMai.Rows[e.RowIndex].Cells[0].Value.ToString())))
                    {
                        MessageBox.Show("Xóa Thành Công");
                        LoadData();
                    }

                }
            }
            else if (tencot == "ChiTiet")
            {
                FormXemChiTietKhuyenMai khuyenmai = new FormXemChiTietKhuyenMai();
                khuyenmai.txtMaKhuyenMai.Text = dataGridViewKhuyenMai.Rows[e.RowIndex].Cells[0].Value.ToString();
                khuyenmai.txtMucKhuyenMai.Text = dataGridViewKhuyenMai.Rows[e.RowIndex].Cells[1].Value.ToString();
                khuyenmai.txtDieuKien.Text = dataGridViewKhuyenMai.Rows[e.RowIndex].Cells[2].Value.ToString();
                khuyenmai.txtThoiGianBatDau.Text = dataGridViewKhuyenMai.Rows[e.RowIndex].Cells[3].Value.ToString();
                khuyenmai.txtThoiGianKetThuc.Text = dataGridViewKhuyenMai.Rows[e.RowIndex].Cells[4].Value.ToString();
                khuyenmai.ShowDialog();
                dataGridViewKhuyenMai.ClearSelection();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormKhuyenMaiModel model=new FormKhuyenMaiModel();
            LamMoiButtonThem(model);
            model.ShowDialog();
            LoadData();
        }
        public void LamMoiButtonThem(FormKhuyenMaiModel model)
        {
            model.btnSua.Visible = false;
            model.btnThem.Visible = true;
            model.txtMaKhuyenMai.Visible = false;
            model.lbMaKhuyenMai.Visible = false;
        }
        public void LamMoiButtonSua(FormKhuyenMaiModel model)
        {
            model.btnSua.Visible = true;
            model.btnThem.Visible = false;
            model.txtMaKhuyenMai.Visible = true;
            model.lbMaKhuyenMai.Visible = true;
        }
    }
}
