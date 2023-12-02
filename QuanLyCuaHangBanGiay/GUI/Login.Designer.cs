namespace GUI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPhone = new System.Windows.Forms.Button();
            this.btnGoogle = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imgLogin1 = new GUI.ImgLogin();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnPhone);
            this.panel1.Controls.Add(this.btnGoogle);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.txtTaiKhoan);
            this.panel1.Controls.Add(this.btnDangNhap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMatKhau);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 232);
            this.panel1.TabIndex = 6;
            // 
            // btnPhone
            // 
            this.btnPhone.Image = ((System.Drawing.Image)(resources.GetObject("btnPhone.Image")));
            this.btnPhone.Location = new System.Drawing.Point(304, 173);
            this.btnPhone.Name = "btnPhone";
            this.btnPhone.Size = new System.Drawing.Size(57, 56);
            this.btnPhone.TabIndex = 8;
            this.btnPhone.UseVisualStyleBackColor = true;
            this.btnPhone.Click += new System.EventHandler(this.btnPhone_Click);
            // 
            // btnGoogle
            // 
            this.btnGoogle.Image = ((System.Drawing.Image)(resources.GetObject("btnGoogle.Image")));
            this.btnGoogle.Location = new System.Drawing.Point(243, 173);
            this.btnGoogle.Name = "btnGoogle";
            this.btnGoogle.Size = new System.Drawing.Size(57, 56);
            this.btnGoogle.TabIndex = 7;
            this.btnGoogle.UseVisualStyleBackColor = true;
            this.btnGoogle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Location = new System.Drawing.Point(314, 130);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(118, 37);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(163, 18);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(344, 21);
            this.txtTaiKhoan.TabIndex = 2;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Location = new System.Drawing.Point(184, 130);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(118, 37);
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(163, 67);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(344, 21);
            this.txtMatKhau.TabIndex = 3;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(660, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.imgLogin1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 250);
            this.panel2.TabIndex = 7;
            // 
            // imgLogin1
            // 
            this.imgLogin1.Image = ((System.Drawing.Image)(resources.GetObject("imgLogin1.Image")));
            this.imgLogin1.ImageHover = ((System.Drawing.Image)(resources.GetObject("imgLogin1.ImageHover")));
            this.imgLogin1.ImageNormal = ((System.Drawing.Image)(resources.GetObject("imgLogin1.ImageNormal")));
            this.imgLogin1.Location = new System.Drawing.Point(0, 0);
            this.imgLogin1.Name = "imgLogin1";
            this.imgLogin1.Size = new System.Drawing.Size(660, 250);
            this.imgLogin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogin1.TabIndex = 0;
            this.imgLogin1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(660, 487);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel2;
        private ImgLogin imgLogin1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPhone;
        private System.Windows.Forms.Button btnGoogle;
    }
}