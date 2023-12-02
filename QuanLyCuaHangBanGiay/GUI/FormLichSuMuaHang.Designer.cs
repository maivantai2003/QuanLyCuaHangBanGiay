namespace GUI
{
    partial class FormLichSuMuaHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLichSuMuaHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewLichSuMuaHang = new System.Windows.Forms.DataGridView();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiTiet = new System.Windows.Forms.DataGridViewImageColumn();
            this.lbTenKhachHang = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLichSuMuaHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1328, 56);
            this.panel1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(557, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lịch Sử Mua Hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewLichSuMuaHang
            // 
            this.dataGridViewLichSuMuaHang.AllowUserToAddRows = false;
            this.dataGridViewLichSuMuaHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLichSuMuaHang.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLichSuMuaHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLichSuMuaHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLichSuMuaHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoaDon,
            this.NgayMua,
            this.TongTien,
            this.ChiTiet});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLichSuMuaHang.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewLichSuMuaHang.Location = new System.Drawing.Point(0, 149);
            this.dataGridViewLichSuMuaHang.Name = "dataGridViewLichSuMuaHang";
            this.dataGridViewLichSuMuaHang.RowHeadersWidth = 51;
            this.dataGridViewLichSuMuaHang.RowTemplate.Height = 24;
            this.dataGridViewLichSuMuaHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLichSuMuaHang.Size = new System.Drawing.Size(1328, 432);
            this.dataGridViewLichSuMuaHang.TabIndex = 22;
            this.dataGridViewLichSuMuaHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLichSuMuaHang_CellContentClick);
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.HeaderText = "Mã Hóa Đơn";
            this.MaHoaDon.MinimumWidth = 6;
            this.MaHoaDon.Name = "MaHoaDon";
            // 
            // NgayMua
            // 
            this.NgayMua.HeaderText = "Ngày Mua";
            this.NgayMua.MinimumWidth = 6;
            this.NgayMua.Name = "NgayMua";
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            // 
            // ChiTiet
            // 
            this.ChiTiet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ChiTiet.HeaderText = "Chi Tiết";
            this.ChiTiet.Image = ((System.Drawing.Image)(resources.GetObject("ChiTiet.Image")));
            this.ChiTiet.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ChiTiet.MinimumWidth = 6;
            this.ChiTiet.Name = "ChiTiet";
            this.ChiTiet.Width = 58;
            // 
            // lbTenKhachHang
            // 
            this.lbTenKhachHang.AutoSize = true;
            this.lbTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKhachHang.Location = new System.Drawing.Point(14, 71);
            this.lbTenKhachHang.Name = "lbTenKhachHang";
            this.lbTenKhachHang.Size = new System.Drawing.Size(121, 16);
            this.lbTenKhachHang.TabIndex = 23;
            this.lbTenKhachHang.Text = "Tên Khách Hàng";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.Location = new System.Drawing.Point(17, 111);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(105, 16);
            this.lbSDT.TabIndex = 24;
            this.lbSDT.Text = "Số Điện Thoại";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(588, 587);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(126, 37);
            this.btnThoat.TabIndex = 25;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FormLichSuMuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 636);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lbSDT);
            this.Controls.Add(this.lbTenKhachHang);
            this.Controls.Add(this.dataGridViewLichSuMuaHang);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLichSuMuaHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDonHangDaMua";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLichSuMuaHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewLichSuMuaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewImageColumn ChiTiet;
        private System.Windows.Forms.Label lbTenKhachHang;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Button btnThoat;
    }
}