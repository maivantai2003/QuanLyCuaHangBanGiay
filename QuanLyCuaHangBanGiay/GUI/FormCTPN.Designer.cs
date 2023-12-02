namespace GUI
{
    partial class FormCTPN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCTPN));
            this.btnThoat = new System.Windows.Forms.Button();
            this.dataGridViewChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPDF = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lbMaPhieuNhap = new System.Windows.Forms.Label();
            this.lbTenNhanVien = new System.Windows.Forms.Label();
            this.lbNgayNhap = new System.Windows.Forms.Label();
            this.lbNhaCungCap = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.MaChiTietSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KichCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietPhieuNhap)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(549, 563);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(113, 45);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dataGridViewChiTietPhieuNhap
            // 
            this.dataGridViewChiTietPhieuNhap.AllowUserToAddRows = false;
            this.dataGridViewChiTietPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChiTietPhieuNhap.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewChiTietPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiTietPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChiTietSanPham,
            this.TenSanPham,
            this.Mau,
            this.KichCo,
            this.SoLuongNhap,
            this.DonVi,
            this.TienNhap,
            this.ThanhTien});
            this.dataGridViewChiTietPhieuNhap.Location = new System.Drawing.Point(4, 171);
            this.dataGridViewChiTietPhieuNhap.Name = "dataGridViewChiTietPhieuNhap";
            this.dataGridViewChiTietPhieuNhap.RowHeadersWidth = 51;
            this.dataGridViewChiTietPhieuNhap.RowTemplate.Height = 24;
            this.dataGridViewChiTietPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChiTietPhieuNhap.Size = new System.Drawing.Size(1186, 340);
            this.dataGridViewChiTietPhieuNhap.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1199, 56);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(498, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chi Tiết Phiếu Nhập";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPDF
            // 
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnPDF.Image")));
            this.btnPDF.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPDF.Location = new System.Drawing.Point(1115, 94);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(72, 71);
            this.btnPDF.TabIndex = 11;
            this.btnPDF.Text = "PDF";
            this.btnPDF.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click_1);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // lbMaPhieuNhap
            // 
            this.lbMaPhieuNhap.AutoSize = true;
            this.lbMaPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPhieuNhap.Location = new System.Drawing.Point(4, 76);
            this.lbMaPhieuNhap.Name = "lbMaPhieuNhap";
            this.lbMaPhieuNhap.Size = new System.Drawing.Size(112, 16);
            this.lbMaPhieuNhap.TabIndex = 12;
            this.lbMaPhieuNhap.Text = "Mã Phiếu Nhập";
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.AutoSize = true;
            this.lbTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNhanVien.Location = new System.Drawing.Point(7, 113);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.lbTenNhanVien.Size = new System.Drawing.Size(109, 16);
            this.lbTenNhanVien.TabIndex = 13;
            this.lbTenNhanVien.Text = "Tên Nhân Viên";
            // 
            // lbNgayNhap
            // 
            this.lbNgayNhap.AutoSize = true;
            this.lbNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayNhap.Location = new System.Drawing.Point(272, 76);
            this.lbNgayNhap.Name = "lbNgayNhap";
            this.lbNgayNhap.Size = new System.Drawing.Size(85, 16);
            this.lbNgayNhap.TabIndex = 14;
            this.lbNgayNhap.Text = "Ngày Nhập";
            // 
            // lbNhaCungCap
            // 
            this.lbNhaCungCap.AutoSize = true;
            this.lbNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhaCungCap.Location = new System.Drawing.Point(272, 113);
            this.lbNhaCungCap.Name = "lbNhaCungCap";
            this.lbNhaCungCap.Size = new System.Drawing.Size(106, 16);
            this.lbNhaCungCap.TabIndex = 15;
            this.lbNhaCungCap.Text = "Nhà Cung Cấp";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(947, 533);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(78, 16);
            this.lbTongTien.TabIndex = 16;
            this.lbTongTien.Text = "Tổng Tiền";
            // 
            // MaChiTietSanPham
            // 
            this.MaChiTietSanPham.HeaderText = "Mã Sản Phẩm";
            this.MaChiTietSanPham.MinimumWidth = 6;
            this.MaChiTietSanPham.Name = "MaChiTietSanPham";
            // 
            // TenSanPham
            // 
            this.TenSanPham.HeaderText = "Tên Sản Phẩm";
            this.TenSanPham.MinimumWidth = 6;
            this.TenSanPham.Name = "TenSanPham";
            // 
            // Mau
            // 
            this.Mau.HeaderText = "Màu";
            this.Mau.MinimumWidth = 6;
            this.Mau.Name = "Mau";
            // 
            // KichCo
            // 
            this.KichCo.HeaderText = "Kích Cỡ";
            this.KichCo.MinimumWidth = 6;
            this.KichCo.Name = "KichCo";
            // 
            // SoLuongNhap
            // 
            this.SoLuongNhap.HeaderText = "Số Lượng Nhập";
            this.SoLuongNhap.MinimumWidth = 6;
            this.SoLuongNhap.Name = "SoLuongNhap";
            // 
            // DonVi
            // 
            this.DonVi.HeaderText = "Đơn Vị";
            this.DonVi.MinimumWidth = 6;
            this.DonVi.Name = "DonVi";
            // 
            // TienNhap
            // 
            this.TienNhap.HeaderText = "Tiền Nhập";
            this.TienNhap.MinimumWidth = 6;
            this.TienNhap.Name = "TienNhap";
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            // 
            // FormCTPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1199, 632);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.lbNhaCungCap);
            this.Controls.Add(this.lbNgayNhap);
            this.Controls.Add(this.lbTenNhanVien);
            this.Controls.Add(this.lbMaPhieuNhap);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewChiTietPhieuNhap);
            this.Controls.Add(this.btnThoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCTPN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCTPN";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietPhieuNhap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridViewChiTietPhieuNhap;
        public System.Windows.Forms.Button btnPDF;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lbMaPhieuNhap;
        private System.Windows.Forms.Label lbTenNhanVien;
        private System.Windows.Forms.Label lbNgayNhap;
        private System.Windows.Forms.Label lbNhaCungCap;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChiTietSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mau;
        private System.Windows.Forms.DataGridViewTextBoxColumn KichCo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}