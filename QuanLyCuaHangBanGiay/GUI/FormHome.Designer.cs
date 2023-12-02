namespace GUI
{
    partial class FormHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.tmChangeImg = new System.Windows.Forms.Timer(this.components);
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.picHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.SuspendLayout();
            // 
            // tmChangeImg
            // 
            this.tmChangeImg.Enabled = true;
            this.tmChangeImg.Interval = 2000;
            this.tmChangeImg.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.White;
            this.imageList.Images.SetKeyName(0, "banner9.jpg");
            this.imageList.Images.SetKeyName(1, "banner6.jpg");
            this.imageList.Images.SetKeyName(2, "banner8.jpg");
            // 
            // picHome
            // 
            this.picHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picHome.Location = new System.Drawing.Point(0, 0);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(1329, 728);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHome.TabIndex = 0;
            this.picHome.TabStop = false;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1329, 728);
            this.Controls.Add(this.picHome);
            this.Name = "FormHome";
            this.Text = "FormHome";
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.Timer tmChangeImg;
        private System.Windows.Forms.ImageList imageList;
    }
}