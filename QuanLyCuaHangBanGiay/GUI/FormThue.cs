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
    public partial class FormThue : Form
    {
        ThueBUS thueBUS=new ThueBUS();
        public FormThue()
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
        public void LoadData()
        {
            dataGridViewThue.Rows.Clear();
            foreach(var i in thueBUS.getThue())
            {
                dataGridViewThue.Rows.Add(i.MaThue, i.TenThue, i.MucThue);
            }
            dataGridViewThue.ClearSelection();
        }

        private void FormThue_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LamMoiButtonThem(FormThueModel model)
        {
            model.btnThem.Visible = true;
            model.btnSua.Visible = false;
            model.lbMaThue.Visible = false;
            model.txtMaThue.Visible = false;
        }
        public void LamMoiButtonSua(FormThueModel model)
        {
            model.btnThem.Visible = false;
            model.btnSua.Visible = true;
            model.lbMaThue.Visible = true;
            model.txtMaThue.Visible = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThueModel model=new FormThueModel();
            LamMoiButtonThem(model);
            model.ShowDialog();
            LoadData();

        }
        private void dataGridViewThue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string tencot = dataGridViewThue.Columns[e.ColumnIndex].Name;
            if (tencot == "Sua")
            {
                FormThueModel model = new FormThueModel();
                model.txtMaThue.Text = dataGridViewThue.Rows[e.RowIndex].Cells[0].Value.ToString();
                model.txtTenThue.Text= dataGridViewThue.Rows[e.RowIndex].Cells[1].Value.ToString();
                model.txtMucThue.Text= dataGridViewThue.Rows[e.RowIndex].Cells[2].Value.ToString();
                LamMoiButtonSua(model);
                model.ShowDialog();
                LoadData();
            }
            else if(tencot == "Xoa")
            {
                if (MessageBox.Show("Bạn Có Muốn Xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (thueBUS.XoaThue(Convert.ToInt32(dataGridViewThue.Rows[e.RowIndex].Cells[0].Value.ToString())))
                    {
                        MessageBox.Show("Xóa Thành Công");
                        LoadData();
                    }
                    
                }
            }
            else if (tencot == "ChiTiet")
            {
                  
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridViewThue.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcel = new Microsoft.Office.Interop.Excel.Application();
                xcel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < 4; i++)
                {
                    xcel.Cells[1, i] = dataGridViewThue.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridViewThue.Rows.Count; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        xcel.Cells[i + 2, j + 1] = dataGridViewThue.Rows[i].Cells[j].Value.ToString();
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
    }
}
