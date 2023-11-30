namespace GUI
{
    partial class FormXemChiTietNhomQuyen
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
            this.label2 = new System.Windows.Forms.Label();
            this.bntThoat = new System.Windows.Forms.Button();
            this.txtMaNhomQuyen = new System.Windows.Forms.TextBox();
            this.lbMaNhomQuyen = new System.Windows.Forms.Label();
            this.txtTenNhomQuyen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhóm Quyền";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bntThoat
            // 
            this.bntThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThoat.Location = new System.Drawing.Point(204, 199);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(113, 41);
            this.bntThoat.TabIndex = 13;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // txtMaNhomQuyen
            // 
            this.txtMaNhomQuyen.Location = new System.Drawing.Point(150, 83);
            this.txtMaNhomQuyen.Name = "txtMaNhomQuyen";
            this.txtMaNhomQuyen.ReadOnly = true;
            this.txtMaNhomQuyen.Size = new System.Drawing.Size(299, 22);
            this.txtMaNhomQuyen.TabIndex = 32;
            // 
            // lbMaNhomQuyen
            // 
            this.lbMaNhomQuyen.AutoSize = true;
            this.lbMaNhomQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNhomQuyen.Location = new System.Drawing.Point(13, 86);
            this.lbMaNhomQuyen.Name = "lbMaNhomQuyen";
            this.lbMaNhomQuyen.Size = new System.Drawing.Size(120, 16);
            this.lbMaNhomQuyen.TabIndex = 31;
            this.lbMaNhomQuyen.Text = "Mã Nhóm Quyền";
            // 
            // txtTenNhomQuyen
            // 
            this.txtTenNhomQuyen.Location = new System.Drawing.Point(150, 140);
            this.txtTenNhomQuyen.Name = "txtTenNhomQuyen";
            this.txtTenNhomQuyen.ReadOnly = true;
            this.txtTenNhomQuyen.Size = new System.Drawing.Size(299, 22);
            this.txtTenNhomQuyen.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tên Nhóm Quyền";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 56);
            this.panel1.TabIndex = 28;
            // 
            // FormXemChiTietNhomQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 255);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.txtMaNhomQuyen);
            this.Controls.Add(this.lbMaNhomQuyen);
            this.Controls.Add(this.txtTenNhomQuyen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormXemChiTietNhomQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormXemChiTietNhomQuyen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntThoat;
        public System.Windows.Forms.TextBox txtMaNhomQuyen;
        public System.Windows.Forms.Label lbMaNhomQuyen;
        public System.Windows.Forms.TextBox txtTenNhomQuyen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}