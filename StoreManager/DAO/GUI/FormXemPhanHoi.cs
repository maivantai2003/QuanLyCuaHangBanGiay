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
    public partial class FormXemPhanHoi : Form
    {
        public FormXemPhanHoi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormXemLichSu_Load(object sender, EventArgs e)
        {
            string t = Path.GetDirectoryName(Application.ExecutablePath);
            int index = t.LastIndexOf('\\');
            string sub = t.Substring(0, index - 4);
            string path = sub + @"\PHANHOI\phanhoi.txt";
            string[]s=File.ReadAllLines(path);
            foreach(var i in s)
            {
                txtPhanHoi.Text += i + "\n";
            }
            Console.ReadLine();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string t = Path.GetDirectoryName(Application.ExecutablePath);
            int index = t.LastIndexOf('\\');
            string sub = t.Substring(0, index - 4);
            string path = sub + @"\PHANHOI\phanhoi.txt";
            File.WriteAllText(path,txtPhanHoi.Text);
        }
    }
}
