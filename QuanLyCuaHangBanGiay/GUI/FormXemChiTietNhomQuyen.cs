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
    public partial class FormXemChiTietNhomQuyen : Form
    {
        public FormXemChiTietNhomQuyen()
        {
            InitializeComponent();
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
