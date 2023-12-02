namespace GUI
{
    partial class FormXemChiTietNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormXemChiTietNhanVien));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbAnh = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtTuoi = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMaNhanVien = new System.Windows.Forms.Label();
            this.pictureAnhNhanVien = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAnhNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 56);
            this.panel1.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhân Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(212, 421);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(119, 47);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lbAnh
            // 
            this.lbAnh.AutoSize = true;
            this.lbAnh.Location = new System.Drawing.Point(258, 382);
            this.lbAnh.Name = "lbAnh";
            this.lbAnh.Size = new System.Drawing.Size(0, 16);
            this.lbAnh.TabIndex = 42;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(130, 179);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.ReadOnly = true;
            this.txtSoDienThoai.Size = new System.Drawing.Size(285, 22);
            this.txtSoDienThoai.TabIndex = 39;
            // 
            // txtTuoi
            // 
            this.txtTuoi.Location = new System.Drawing.Point(130, 138);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.ReadOnly = true;
            this.txtTuoi.Size = new System.Drawing.Size(285, 22);
            this.txtTuoi.TabIndex = 38;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(130, 101);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.ReadOnly = true;
            this.txtTenNhanVien.Size = new System.Drawing.Size(285, 22);
            this.txtTenNhanVien.TabIndex = 37;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(130, 63);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.ReadOnly = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(285, 22);
            this.txtMaNhanVien.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Hình Ảnh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Số Điện Thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tuổi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tên Nhân Viên";
            // 
            // lbMaNhanVien
            // 
            this.lbMaNhanVien.AutoSize = true;
            this.lbMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNhanVien.Location = new System.Drawing.Point(19, 63);
            this.lbMaNhanVien.Name = "lbMaNhanVien";
            this.lbMaNhanVien.Size = new System.Drawing.Size(103, 16);
            this.lbMaNhanVien.TabIndex = 31;
            this.lbMaNhanVien.Text = "Mã Nhân Viên";
            // 
            // pictureAnhNhanVien
            // 
            this.pictureAnhNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureAnhNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("pictureAnhNhanVien.Image")));
            this.pictureAnhNhanVien.Location = new System.Drawing.Point(170, 221);
            this.pictureAnhNhanVien.Name = "pictureAnhNhanVien";
            this.pictureAnhNhanVien.Size = new System.Drawing.Size(207, 158);
            this.pictureAnhNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAnhNhanVien.TabIndex = 40;
            this.pictureAnhNhanVien.TabStop = false;
            // 
            // FormXemChiTietNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(513, 480);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbAnh);
            this.Controls.Add(this.pictureAnhNhanVien);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtTuoi);
            this.Controls.Add(this.txtTenNhanVien);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbMaNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormXemChiTietNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormXemChiTietNhanVien";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAnhNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lbAnh;
        public System.Windows.Forms.PictureBox pictureAnhNhanVien;
        public System.Windows.Forms.TextBox txtSoDienThoai;
        public System.Windows.Forms.TextBox txtTuoi;
        public System.Windows.Forms.TextBox txtTenNhanVien;
        public System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbMaNhanVien;
    }
}