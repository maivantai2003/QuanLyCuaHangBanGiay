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
    public partial class ImgLogin : PictureBox
    {
        public ImgLogin()
        {
            InitializeComponent();
        }
        private Image NormalImage;
        private Image HoverImage;
        public Image ImageNormal { get { return NormalImage; } set { NormalImage = value; } }
        public Image ImageHover { get { return HoverImage; } set { HoverImage = value; } }

    }
}
