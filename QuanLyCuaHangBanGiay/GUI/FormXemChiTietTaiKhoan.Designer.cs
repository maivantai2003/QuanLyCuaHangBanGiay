namespace GUI
{
    partial class FormXemChiTietTaiKhoan
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
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMaTaiKhoan = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtTenNhomQuyen = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(169, 171);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.ReadOnly = true;
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(373, 22);
            this.txtTenTaiKhoan.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tài Khoản";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(245, 283);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(117, 38);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(169, 220);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.ReadOnly = true;
            this.txtMatKhau.Size = new System.Drawing.Size(373, 22);
            this.txtMatKhau.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Mật Khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tên Tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tên Nhóm Quyền";
            // 
            // lbMaTaiKhoan
            // 
            this.lbMaTaiKhoan.AutoSize = true;
            this.lbMaTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaTaiKhoan.Location = new System.Drawing.Point(26, 77);
            this.lbMaTaiKhoan.Name = "lbMaTaiKhoan";
            this.lbMaTaiKhoan.Size = new System.Drawing.Size(102, 16);
            this.lbMaTaiKhoan.TabIndex = 22;
            this.lbMaTaiKhoan.Text = "Mã Tài Khoản";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 56);
            this.panel1.TabIndex = 21;
            // 
            // txtMaTaiKhoan
            // 
            this.txtMaTaiKhoan.Location = new System.Drawing.Point(169, 74);
            this.txtMaTaiKhoan.Name = "txtMaTaiKhoan";
            this.txtMaTaiKhoan.ReadOnly = true;
            this.txtMaTaiKhoan.Size = new System.Drawing.Size(373, 22);
            this.txtMaTaiKhoan.TabIndex = 29;
            // 
            // txtTenNhomQuyen
            // 
            this.txtTenNhomQuyen.Location = new System.Drawing.Point(169, 123);
            this.txtTenNhomQuyen.Name = "txtTenNhomQuyen";
            this.txtTenNhomQuyen.ReadOnly = true;
            this.txtTenNhomQuyen.Size = new System.Drawing.Size(373, 22);
            this.txtTenNhomQuyen.TabIndex = 30;
            // 
            // FormXemChiTietTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 349);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtTenNhomQuyen);
            this.Controls.Add(this.txtMaTaiKhoan);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMaTaiKhoan);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormXemChiTietTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormXemChiTietTaiKhoan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnThoat;
        public System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbMaTaiKhoan;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtMaTaiKhoan;
        public System.Windows.Forms.TextBox txtTenNhomQuyen;
    }
}