namespace GUI
{
    partial class FormKhuyenMaiModel
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtDieuKien = new System.Windows.Forms.TextBox();
            this.txtMucKhuyenMai = new System.Windows.Forms.TextBox();
            this.txtMaKhuyenMai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMaKhuyenMai = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeThoiGianBatDau = new System.Windows.Forms.DateTimePicker();
            this.dateTimeThoiGianKetThuc = new System.Windows.Forms.DateTimePicker();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 57);
            this.panel1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khuyến Mãi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnThem);
            this.flowLayoutPanel1.Controls.Add(this.btnSua);
            this.flowLayoutPanel1.Controls.Add(this.btnThoat);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(95, 375);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(223, 42);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(3, 2);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 37);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(113, 2);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(104, 37);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(3, 43);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(104, 38);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtDieuKien
            // 
            this.txtDieuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDieuKien.Location = new System.Drawing.Point(41, 207);
            this.txtDieuKien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDieuKien.Name = "txtDieuKien";
            this.txtDieuKien.Size = new System.Drawing.Size(364, 30);
            this.txtDieuKien.TabIndex = 30;
            // 
            // txtMucKhuyenMai
            // 
            this.txtMucKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMucKhuyenMai.Location = new System.Drawing.Point(41, 154);
            this.txtMucKhuyenMai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMucKhuyenMai.Name = "txtMucKhuyenMai";
            this.txtMucKhuyenMai.Size = new System.Drawing.Size(364, 30);
            this.txtMucKhuyenMai.TabIndex = 29;
            // 
            // txtMaKhuyenMai
            // 
            this.txtMaKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhuyenMai.Location = new System.Drawing.Point(41, 88);
            this.txtMaKhuyenMai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaKhuyenMai.Name = "txtMaKhuyenMai";
            this.txtMaKhuyenMai.ReadOnly = true;
            this.txtMaKhuyenMai.Size = new System.Drawing.Size(364, 30);
            this.txtMaKhuyenMai.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Thời Gian Kết Thúc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Thời gian Bắt Đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Điều Kiện";
            // 
            // lbMaKhuyenMai
            // 
            this.lbMaKhuyenMai.AutoSize = true;
            this.lbMaKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKhuyenMai.Location = new System.Drawing.Point(37, 66);
            this.lbMaKhuyenMai.Name = "lbMaKhuyenMai";
            this.lbMaKhuyenMai.Size = new System.Drawing.Size(137, 20);
            this.lbMaKhuyenMai.TabIndex = 24;
            this.lbMaKhuyenMai.Text = "Mã Khuyến Mãi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mức Khuyến Mãi";
            // 
            // dateTimeThoiGianBatDau
            // 
            this.dateTimeThoiGianBatDau.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeThoiGianBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeThoiGianBatDau.Location = new System.Drawing.Point(42, 266);
            this.dateTimeThoiGianBatDau.Name = "dateTimeThoiGianBatDau";
            this.dateTimeThoiGianBatDau.Size = new System.Drawing.Size(363, 22);
            this.dateTimeThoiGianBatDau.TabIndex = 33;
            this.dateTimeThoiGianBatDau.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimeThoiGianKetThuc
            // 
            this.dateTimeThoiGianKetThuc.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeThoiGianKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeThoiGianKetThuc.Location = new System.Drawing.Point(42, 320);
            this.dateTimeThoiGianKetThuc.Name = "dateTimeThoiGianKetThuc";
            this.dateTimeThoiGianKetThuc.Size = new System.Drawing.Size(363, 22);
            this.dateTimeThoiGianKetThuc.TabIndex = 34;
            // 
            // FormKhuyenMaiModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(450, 458);
            this.Controls.Add(this.dateTimeThoiGianKetThuc);
            this.Controls.Add(this.dateTimeThoiGianBatDau);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txtDieuKien);
            this.Controls.Add(this.txtMucKhuyenMai);
            this.Controls.Add(this.txtMaKhuyenMai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMaKhuyenMai);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKhuyenMaiModel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKhuyeMaiModel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Button btnThem;
        public System.Windows.Forms.Button btnSua;
        public System.Windows.Forms.Button btnThoat;
        public System.Windows.Forms.TextBox txtDieuKien;
        public System.Windows.Forms.TextBox txtMucKhuyenMai;
        public System.Windows.Forms.TextBox txtMaKhuyenMai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbMaKhuyenMai;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dateTimeThoiGianBatDau;
        public System.Windows.Forms.DateTimePicker dateTimeThoiGianKetThuc;
    }
}