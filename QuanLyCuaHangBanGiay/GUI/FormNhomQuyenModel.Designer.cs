namespace GUI
{
    partial class FormNhomQuyenModel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNhomQuyen = new System.Windows.Forms.TextBox();
            this.lbMaNhomQuyen = new System.Windows.Forms.Label();
            this.txtTenNhomQuyen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.bntThoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 56);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhóm Quyền";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaNhomQuyen
            // 
            this.txtMaNhomQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhomQuyen.Location = new System.Drawing.Point(25, 95);
            this.txtMaNhomQuyen.Name = "txtMaNhomQuyen";
            this.txtMaNhomQuyen.ReadOnly = true;
            this.txtMaNhomQuyen.Size = new System.Drawing.Size(341, 30);
            this.txtMaNhomQuyen.TabIndex = 25;
            // 
            // lbMaNhomQuyen
            // 
            this.lbMaNhomQuyen.AutoSize = true;
            this.lbMaNhomQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNhomQuyen.Location = new System.Drawing.Point(25, 72);
            this.lbMaNhomQuyen.Name = "lbMaNhomQuyen";
            this.lbMaNhomQuyen.Size = new System.Drawing.Size(147, 20);
            this.lbMaNhomQuyen.TabIndex = 24;
            this.lbMaNhomQuyen.Text = "Mã Nhóm Quyền";
            // 
            // txtTenNhomQuyen
            // 
            this.txtTenNhomQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhomQuyen.Location = new System.Drawing.Point(25, 154);
            this.txtTenNhomQuyen.Name = "txtTenNhomQuyen";
            this.txtTenNhomQuyen.Size = new System.Drawing.Size(341, 30);
            this.txtTenNhomQuyen.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tên Nhóm Quyền";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnThem);
            this.flowLayoutPanel1.Controls.Add(this.btnSua);
            this.flowLayoutPanel1.Controls.Add(this.bntThoat);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(78, 213);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(238, 50);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 41);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(122, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(113, 41);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // bntThoat
            // 
            this.bntThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThoat.Location = new System.Drawing.Point(3, 50);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(113, 41);
            this.bntThoat.TabIndex = 13;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // FormNhomQuyenModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(398, 295);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txtMaNhomQuyen);
            this.Controls.Add(this.lbMaNhomQuyen);
            this.Controls.Add(this.txtTenNhomQuyen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNhomQuyenModel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNhomQuyenModel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtMaNhomQuyen;
        public System.Windows.Forms.Label lbMaNhomQuyen;
        public System.Windows.Forms.TextBox txtTenNhomQuyen;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Button btnThem;
        public System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button bntThoat;
    }
}