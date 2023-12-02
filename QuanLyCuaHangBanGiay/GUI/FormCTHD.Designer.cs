namespace GUI
{
    partial class FormCTHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCTHD));
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMaHoaDon = new System.Windows.Forms.Label();
            this.lbTenHoaDon = new System.Windows.Forms.Label();
            this.lbMaNhanVien = new System.Windows.Forms.Label();
            this.lbNgayLap = new System.Windows.Forms.Label();
            this.lbKhachHang = new System.Windows.Forms.Label();
            this.lbSoDienThoai = new System.Windows.Forms.Label();
            this.dataGridViewChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.MaChiTietSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MauSac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KichCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTienThue = new System.Windows.Forms.Label();
            this.lbTienKhuyenMai = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.lbThanhTien = new System.Windows.Forms.Label();
            this.btnPDF = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(491, 588);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(113, 45);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 56);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(459, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chi Tiết Hóa Đơn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMaHoaDon
            // 
            this.lbMaHoaDon.AutoSize = true;
            this.lbMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHoaDon.Location = new System.Drawing.Point(12, 79);
            this.lbMaHoaDon.Name = "lbMaHoaDon";
            this.lbMaHoaDon.Size = new System.Drawing.Size(103, 18);
            this.lbMaHoaDon.TabIndex = 12;
            this.lbMaHoaDon.Text = "Mã Hóa Đơn";
            // 
            // lbTenHoaDon
            // 
            this.lbTenHoaDon.AutoSize = true;
            this.lbTenHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenHoaDon.Location = new System.Drawing.Point(12, 104);
            this.lbTenHoaDon.Name = "lbTenHoaDon";
            this.lbTenHoaDon.Size = new System.Drawing.Size(108, 18);
            this.lbTenHoaDon.TabIndex = 13;
            this.lbTenHoaDon.Text = "Tên Hóa Đơn";
            // 
            // lbMaNhanVien
            // 
            this.lbMaNhanVien.AutoSize = true;
            this.lbMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNhanVien.Location = new System.Drawing.Point(12, 130);
            this.lbMaNhanVien.Name = "lbMaNhanVien";
            this.lbMaNhanVien.Size = new System.Drawing.Size(112, 18);
            this.lbMaNhanVien.TabIndex = 14;
            this.lbMaNhanVien.Text = "Mã Nhân Viên";
            // 
            // lbNgayLap
            // 
            this.lbNgayLap.AutoSize = true;
            this.lbNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayLap.Location = new System.Drawing.Point(376, 79);
            this.lbNgayLap.Name = "lbNgayLap";
            this.lbNgayLap.Size = new System.Drawing.Size(78, 18);
            this.lbNgayLap.TabIndex = 15;
            this.lbNgayLap.Text = "Ngày Lập";
            // 
            // lbKhachHang
            // 
            this.lbKhachHang.AutoSize = true;
            this.lbKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhachHang.Location = new System.Drawing.Point(376, 104);
            this.lbKhachHang.Name = "lbKhachHang";
            this.lbKhachHang.Size = new System.Drawing.Size(99, 18);
            this.lbKhachHang.TabIndex = 16;
            this.lbKhachHang.Text = "Khách Hàng";
            // 
            // lbSoDienThoai
            // 
            this.lbSoDienThoai.AutoSize = true;
            this.lbSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoDienThoai.Location = new System.Drawing.Point(376, 130);
            this.lbSoDienThoai.Name = "lbSoDienThoai";
            this.lbSoDienThoai.Size = new System.Drawing.Size(115, 18);
            this.lbSoDienThoai.TabIndex = 17;
            this.lbSoDienThoai.Text = "Số Điện Thoại";
            // 
            // dataGridViewChiTietHoaDon
            // 
            this.dataGridViewChiTietHoaDon.AllowUserToAddRows = false;
            this.dataGridViewChiTietHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChiTietHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChiTietSanPham,
            this.TenSanPham,
            this.MauSac,
            this.KichCo,
            this.SoLuong,
            this.GiaSanPham,
            this.ThanhTien});
            this.dataGridViewChiTietHoaDon.Location = new System.Drawing.Point(0, 161);
            this.dataGridViewChiTietHoaDon.Name = "dataGridViewChiTietHoaDon";
            this.dataGridViewChiTietHoaDon.RowHeadersWidth = 51;
            this.dataGridViewChiTietHoaDon.RowTemplate.Height = 24;
            this.dataGridViewChiTietHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChiTietHoaDon.Size = new System.Drawing.Size(1120, 300);
            this.dataGridViewChiTietHoaDon.TabIndex = 18;
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
            // MauSac
            // 
            this.MauSac.HeaderText = "Màu Sắc";
            this.MauSac.MinimumWidth = 6;
            this.MauSac.Name = "MauSac";
            // 
            // KichCo
            // 
            this.KichCo.HeaderText = "Kích Cỡ";
            this.KichCo.MinimumWidth = 6;
            this.KichCo.Name = "KichCo";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // GiaSanPham
            // 
            this.GiaSanPham.HeaderText = "Giá Sản Phẩm";
            this.GiaSanPham.MinimumWidth = 6;
            this.GiaSanPham.Name = "GiaSanPham";
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            // 
            // lbTienThue
            // 
            this.lbTienThue.AutoSize = true;
            this.lbTienThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienThue.Location = new System.Drawing.Point(689, 474);
            this.lbTienThue.Name = "lbTienThue";
            this.lbTienThue.Size = new System.Drawing.Size(82, 18);
            this.lbTienThue.TabIndex = 19;
            this.lbTienThue.Text = "Tiền Thuế";
            this.lbTienThue.Click += new System.EventHandler(this.label8_Click);
            // 
            // lbTienKhuyenMai
            // 
            this.lbTienKhuyenMai.AutoSize = true;
            this.lbTienKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienKhuyenMai.Location = new System.Drawing.Point(689, 502);
            this.lbTienKhuyenMai.Name = "lbTienKhuyenMai";
            this.lbTienKhuyenMai.Size = new System.Drawing.Size(132, 18);
            this.lbTienKhuyenMai.TabIndex = 20;
            this.lbTienKhuyenMai.Text = "Tiền Khuyến Mãi";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(689, 564);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(83, 18);
            this.lbTongTien.TabIndex = 21;
            this.lbTongTien.Text = "Tổng Tiền";
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.AutoSize = true;
            this.lbThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhTien.Location = new System.Drawing.Point(689, 534);
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(91, 18);
            this.lbThanhTien.TabIndex = 22;
            this.lbThanhTien.Text = "Thành Tiền";
            // 
            // btnPDF
            // 
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnPDF.Image")));
            this.btnPDF.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPDF.Location = new System.Drawing.Point(1025, 77);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(72, 71);
            this.btnPDF.TabIndex = 23;
            this.btnPDF.Text = "PDF";
            this.btnPDF.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
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
            // FormCTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1122, 645);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.lbThanhTien);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.lbTienKhuyenMai);
            this.Controls.Add(this.lbTienThue);
            this.Controls.Add(this.dataGridViewChiTietHoaDon);
            this.Controls.Add(this.lbSoDienThoai);
            this.Controls.Add(this.lbKhachHang);
            this.Controls.Add(this.lbNgayLap);
            this.Controls.Add(this.lbMaNhanVien);
            this.Controls.Add(this.lbTenHoaDon);
            this.Controls.Add(this.lbMaHoaDon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCTHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCTHD";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMaHoaDon;
        private System.Windows.Forms.Label lbTenHoaDon;
        private System.Windows.Forms.Label lbMaNhanVien;
        private System.Windows.Forms.Label lbNgayLap;
        private System.Windows.Forms.Label lbKhachHang;
        private System.Windows.Forms.Label lbSoDienThoai;
        private System.Windows.Forms.DataGridView dataGridViewChiTietHoaDon;
        private System.Windows.Forms.Label lbTienThue;
        private System.Windows.Forms.Label lbTienKhuyenMai;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label lbThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChiTietSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MauSac;
        private System.Windows.Forms.DataGridViewTextBoxColumn KichCo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        public System.Windows.Forms.Button btnPDF;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}