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
    public partial class FormLichSuHeThong : Form
    {
        public FormLichSuHeThong()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLichSuHeThong_Load(object sender, EventArgs e)
        {
            string t = Path.GetDirectoryName(Application.ExecutablePath);
            int index = t.LastIndexOf('\\');
            string sub = t.Substring(0, index - 4);
            string path = sub + @"\PHANHOI\lichsu.txt";
            string[] s = File.ReadAllLines(path);
            foreach (var i in s)
            {
                txtXemLichSu.Text += i + "\n";
            }
            Console.ReadLine();
        }
    }
}
