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
using System.Data.OleDb;
using DTO;

namespace GUI
{
    public partial class FormChatLieu : Form
    {
        ChatLieuBUS chatLieuBUS=new ChatLieuBUS();
        public FormChatLieu()
        {
            InitializeComponent();
            formTimKiem1.btnTimKiem.Visible = false;
            formTimKiem1.txtTimKiem.TextChanged += new EventHandler(Search);
        }

        private void FormChatLieu_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void Search(object sender, EventArgs e)
        {
            if (formTimKiem1.txtTimKiem.Text == "")
            {
                formTimKiem1.btnTimKiem.Visible = false;
                LoadData();
            }
            else
            {
                formTimKiem1.btnTimKiem.Visible = true;
                LoadData(formTimKiem1.txtTimKiem.Text);
            }
        }
        public void LoadData()
        {
            dataGridViewChatLieu.Rows.Clear();  
            foreach(var i in chatLieuBUS.getChatLieu())
            {
                dataGridViewChatLieu.Rows.Add(i.MaChatLieu, i.TenChatLieu);
            }
            dataGridViewChatLieu.ClearSelection();
        }
        public void LoadData(string text)
        {
            dataGridViewChatLieu.Rows.Clear();
            foreach (var i in chatLieuBUS.TimKiemChatLieu(text))
            {
                dataGridViewChatLieu.Rows.Add(i.MaChatLieu, i.TenChatLieu);
                
            }
            dataGridViewChatLieu.ClearSelection();
        }
        public void LamMoiButtonThem(FormChatLieuModel model)
        {
            model.lbMaChatLieu.Visible=false;
            model.txtMaChatLieu.Visible = false;
            model.btnThem.Visible = true;
            model.btnSua.Visible = false;
        }
        public void LamMoiButtonSua(FormChatLieuModel model)
        {
            model.lbMaChatLieu.Visible = true;
            model.txtMaChatLieu.Visible = true;
            model.btnThem.Visible = false;
            model.btnSua.Visible = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            FormChatLieuModel model = new FormChatLieuModel();
            LamMoiButtonThem(model);
            model.ShowDialog();
            LoadData();
        }

        private void dataGridViewChatLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string tencot = dataGridViewChatLieu.Columns[e.ColumnIndex].Name;
            if (tencot == "Sua")
            {
                FormChatLieuModel model = new FormChatLieuModel();
                LamMoiButtonSua(model);
                model.txtMaChatLieu.Text = dataGridViewChatLieu.Rows[e.RowIndex].Cells[0].Value.ToString();
                model.txtTenChatLieu.Text= dataGridViewChatLieu.Rows[e.RowIndex].Cells[1].Value.ToString();
                model.ShowDialog();
                LoadData();
                
            }else if(tencot == "Xoa")
            {
                if (MessageBox.Show("Bạn Có Muốn Xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (chatLieuBUS.XoaChatLieu(Convert.ToInt32(dataGridViewChatLieu.Rows[e.RowIndex].Cells[0].Value.ToString())))
                    {
                        MessageBox.Show("Xóa Thành Công");
                        LoadData();
                    }
                }
            }
            else if (tencot == "ChiTiet")
            {
                FormXemChiTietChatLieu chatLieu=new FormXemChiTietChatLieu();
                chatLieu.txtMaChatLieu.Text= dataGridViewChatLieu.Rows[e.RowIndex].Cells[0].Value.ToString();
                chatLieu.txtTenChatLieu.Text= dataGridViewChatLieu.Rows[e.RowIndex].Cells[1].Value.ToString();
                chatLieu.ShowDialog();
                dataGridViewChatLieu.ClearSelection();
            }
            
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridViewChatLieu.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcel = new Microsoft.Office.Interop.Excel.Application();
                xcel.Application.Workbooks.Add(Type.Missing);
                for(int i = 1; i < 3; i++)
                {
                    xcel.Cells[1, i] = dataGridViewChatLieu.Columns[i - 1].HeaderText;
                }
                for(int i = 0; i < dataGridViewChatLieu.Rows.Count; i++)
                {
                    for(int j = 0; j < 2; j++)
                    {
                        xcel.Cells[i + 2, j + 1] = dataGridViewChatLieu.Rows[i].Cells[j].Value.ToString() ;
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
                xlApp=new Microsoft.Office.Interop.Excel.Application();
                xlBook = xlApp.Workbooks.Open(tenFile);
                xlSheet = xlBook.Worksheets["Sheet1"];
                xlRange = xlSheet.UsedRange;
                
                for (xlRow=2;xlRow<=xlRange.Rows.Count;xlRow++)
                {
                    if (xlRange.Cells[xlRow, 1].Text!="")
                    {
                        if(chatLieuBUS.KiemTraChatLieu(xlRange.Cells[xlRow, 2].Text)==false)
                        {
                            ChatLieu chatLieu=new ChatLieu();
                            chatLieu.TenChatLieu = xlRange.Cells[xlRow, 2].Text;
                            chatLieu.TrangThai = 1;
                            if (chatLieuBUS.ThemChatLieu(chatLieu))
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
