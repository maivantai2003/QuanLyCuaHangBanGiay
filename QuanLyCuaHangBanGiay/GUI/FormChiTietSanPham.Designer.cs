namespace GUI
{
    partial class FormChiTietSanPham
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
            this.dataGridViewChiTietSanPham = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.MaChiTietSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMauSac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKichCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnh = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewChiTietSanPham
            // 
            this.dataGridViewChiTietSanPham.AllowUserToAddRows = false;
            this.dataGridViewChiTietSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChiTietSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewChiTietSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiTietSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChiTietSanPham,
            this.MaSanPham,
            this.MaMauSac,
            this.MaKichCo,
            this.SoLuongNhap,
            this.SoLuongTon,
            this.HinhAnh});
            this.dataGridViewChiTietSanPham.Location = new System.Drawing.Point(2, 116);
            this.dataGridViewChiTietSanPham.Name = "dataGridViewChiTietSanPham";
            this.dataGridViewChiTietSanPham.RowHeadersWidth = 51;
            this.dataGridViewChiTietSanPham.RowTemplate.Height = 24;
            this.dataGridViewChiTietSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChiTietSanPham.Size = new System.Drawing.Size(1317, 248);
            this.dataGridViewChiTietSanPham.TabIndex = 1;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.DataPropertyName = "Sua";
            this.dataGridViewImageColumn1.HeaderText = "Sửa";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "Xóa";
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(1186, 384);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(133, 40);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // MaChiTietSanPham
            // 
            this.MaChiTietSanPham.DataPropertyName = "MaChiTietSanPham";
            this.MaChiTietSanPham.HeaderText = "Mã Chi Tiết Sản Phẩm";
            this.MaChiTietSanPham.MinimumWidth = 6;
            this.MaChiTietSanPham.Name = "MaChiTietSanPham";
            // 
            // MaSanPham
            // 
            this.MaSanPham.DataPropertyName = "MaSanPham";
            this.MaSanPham.HeaderText = "Mã Sản Phẩm";
            this.MaSanPham.MinimumWidth = 6;
            this.MaSanPham.Name = "MaSanPham";
            // 
            // MaMauSac
            // 
            this.MaMauSac.DataPropertyName = "MaMauSac";
            this.MaMauSac.HeaderText = "Mã Màu Sắc";
            this.MaMauSac.MinimumWidth = 6;
            this.MaMauSac.Name = "MaMauSac";
            // 
            // MaKichCo
            // 
            this.MaKichCo.DataPropertyName = "MaKichCo";
            this.MaKichCo.HeaderText = "Mã Kích Cỡ";
            this.MaKichCo.MinimumWidth = 6;
            this.MaKichCo.Name = "MaKichCo";
            // 
            // SoLuongNhap
            // 
            this.SoLuongNhap.DataPropertyName = "SoLuongNhap";
            this.SoLuongNhap.HeaderText = "Số Lượng Nhập";
            this.SoLuongNhap.MinimumWidth = 6;
            this.SoLuongNhap.Name = "SoLuongNhap";
            // 
            // SoLuongTon
            // 
            this.SoLuongTon.DataPropertyName = "SoLuongTon";
            this.SoLuongTon.HeaderText = "Số Lượng Tồn";
            this.SoLuongTon.MinimumWidth = 6;
            this.SoLuongTon.Name = "SoLuongTon";
            // 
            // HinhAnh
            // 
            this.HinhAnh.DataPropertyName = "HinhAnh";
            this.HinhAnh.HeaderText = "Hình Ảnh";
            this.HinhAnh.MinimumWidth = 6;
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HinhAnh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormChiTietSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1319, 670);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridViewChiTietSanPham);
            this.Name = "FormChiTietSanPham";
            this.Text = "FormChiTietSanPhamModel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewChiTietSanPham;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        public System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChiTietSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMauSac;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKichCo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTon;
        private System.Windows.Forms.DataGridViewImageColumn HinhAnh;
    }
}