namespace GUI
{
    partial class FormSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSanPham));
            this.dataGridViewSanPham = new System.Windows.Forms.DataGridView();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaThuongHieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChatLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sua = new System.Windows.Forms.DataGridViewImageColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.ChiTiet = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.formTimKiem2 = new GUI.formTimKiem();
            this.formTimKiem1 = new GUI.formTimKiem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewSanPham
            // 
            this.dataGridViewSanPham.AllowUserToAddRows = false;
            this.dataGridViewSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSanPham.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSanPham,
            this.MaThuongHieu,
            this.MaTheLoai,
            this.MaChatLieu,
            this.TenSanPham,
            this.GiaSanPham,
            this.GiaNhap,
            this.SoLuongNhap,
            this.SoLuongTon,
            this.Sua,
            this.Xoa,
            this.ChiTiet});
            this.dataGridViewSanPham.Location = new System.Drawing.Point(0, 95);
            this.dataGridViewSanPham.Name = "dataGridViewSanPham";
            this.dataGridViewSanPham.RowHeadersWidth = 51;
            this.dataGridViewSanPham.RowTemplate.Height = 24;
            this.dataGridViewSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSanPham.Size = new System.Drawing.Size(1310, 317);
            this.dataGridViewSanPham.TabIndex = 3;
            this.dataGridViewSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSanPham_CellContentClick);
            // 
            // MaSanPham
            // 
            this.MaSanPham.DataPropertyName = "MaSanPham";
            this.MaSanPham.HeaderText = "Mã SP";
            this.MaSanPham.MinimumWidth = 6;
            this.MaSanPham.Name = "MaSanPham";
            // 
            // MaThuongHieu
            // 
            this.MaThuongHieu.DataPropertyName = "MaThuongHieu";
            this.MaThuongHieu.HeaderText = "Thương Hiệu";
            this.MaThuongHieu.MinimumWidth = 6;
            this.MaThuongHieu.Name = "MaThuongHieu";
            // 
            // MaTheLoai
            // 
            this.MaTheLoai.DataPropertyName = "MaTheLoai";
            this.MaTheLoai.HeaderText = "Thể Loại";
            this.MaTheLoai.MinimumWidth = 6;
            this.MaTheLoai.Name = "MaTheLoai";
            // 
            // MaChatLieu
            // 
            this.MaChatLieu.DataPropertyName = "MaChatLieu";
            this.MaChatLieu.HeaderText = "Chất Liệu";
            this.MaChatLieu.MinimumWidth = 6;
            this.MaChatLieu.Name = "MaChatLieu";
            // 
            // TenSanPham
            // 
            this.TenSanPham.DataPropertyName = "TenSanPham";
            this.TenSanPham.HeaderText = "Tên SP";
            this.TenSanPham.MinimumWidth = 6;
            this.TenSanPham.Name = "TenSanPham";
            // 
            // GiaSanPham
            // 
            this.GiaSanPham.DataPropertyName = "GiaSanPham";
            this.GiaSanPham.HeaderText = "Giá SP";
            this.GiaSanPham.MinimumWidth = 6;
            this.GiaSanPham.Name = "GiaSanPham";
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "GiaNhap";
            this.GiaNhap.HeaderText = "Giá Nhập";
            this.GiaNhap.MinimumWidth = 6;
            this.GiaNhap.Name = "GiaNhap";
            // 
            // SoLuongNhap
            // 
            this.SoLuongNhap.DataPropertyName = "SoLuongNhap";
            this.SoLuongNhap.HeaderText = "SL Nhập";
            this.SoLuongNhap.MinimumWidth = 6;
            this.SoLuongNhap.Name = "SoLuongNhap";
            // 
            // SoLuongTon
            // 
            this.SoLuongTon.DataPropertyName = "SoLuongTon";
            this.SoLuongTon.HeaderText = "SL Tồn";
            this.SoLuongTon.MinimumWidth = 6;
            this.SoLuongTon.Name = "SoLuongTon";
            // 
            // Sua
            // 
            this.Sua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Sua.HeaderText = "Sửa";
            this.Sua.Image = ((System.Drawing.Image)(resources.GetObject("Sua.Image")));
            this.Sua.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Sua.MinimumWidth = 6;
            this.Sua.Name = "Sua";
            this.Sua.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Sua.Width = 60;
            // 
            // Xoa
            // 
            this.Xoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.Image = ((System.Drawing.Image)(resources.GetObject("Xoa.Image")));
            this.Xoa.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Xoa.MinimumWidth = 6;
            this.Xoa.Name = "Xoa";
            this.Xoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Xoa.Width = 60;
            // 
            // ChiTiet
            // 
            this.ChiTiet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ChiTiet.HeaderText = "Chi Tiết";
            this.ChiTiet.Image = ((System.Drawing.Image)(resources.GetObject("ChiTiet.Image")));
            this.ChiTiet.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ChiTiet.MinimumWidth = 6;
            this.ChiTiet.Name = "ChiTiet";
            this.ChiTiet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ChiTiet.Width = 81;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "Sửa";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "Xóa";
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn3.HeaderText = "Chi Tiết";
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn3.Width = 125;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnExport);
            this.flowLayoutPanel1.Controls.Add(this.btnImport);
            this.flowLayoutPanel1.Controls.Add(this.btnThem);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1069, 418);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(244, 75);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // btnExport
            // 
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExport.Location = new System.Drawing.Point(157, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(84, 71);
            this.btnExport.TabIndex = 13;
            this.btnExport.Text = "EXPORT";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.Image")));
            this.btnImport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImport.Location = new System.Drawing.Point(81, 3);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(70, 71);
            this.btnImport.TabIndex = 14;
            this.btnImport.Text = "IMPORT";
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(5, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 71);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.formTimKiem2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1313, 77);
            this.panel1.TabIndex = 11;
            // 
            // formTimKiem2
            // 
            this.formTimKiem2.BackColor = System.Drawing.SystemColors.Control;
            this.formTimKiem2.Location = new System.Drawing.Point(-1, 12);
            this.formTimKiem2.Name = "formTimKiem2";
            this.formTimKiem2.Size = new System.Drawing.Size(1311, 50);
            this.formTimKiem2.TabIndex = 0;
            this.formTimKiem2.Load += new System.EventHandler(this.formTimKiem2_Load);
            // 
            // formTimKiem1
            // 
            this.formTimKiem1.BackColor = System.Drawing.Color.Cyan;
            this.formTimKiem1.Dock = System.Windows.Forms.DockStyle.Top;
            this.formTimKiem1.Location = new System.Drawing.Point(0, 0);
            this.formTimKiem1.Name = "formTimKiem1";
            this.formTimKiem1.Size = new System.Drawing.Size(1313, 49);
            this.formTimKiem1.TabIndex = 0;
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1313, 670);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridViewSanPham);
            this.Name = "FormSanPham";
            this.Text = "FormSanPham";
            this.Load += new System.EventHandler(this.FormSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private formTimKiem formTimKiem1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        public System.Windows.Forms.DataGridView dataGridViewSanPham;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Button btnExport;
        public System.Windows.Forms.Button btnImport;
        public System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel1;
        private formTimKiem formTimKiem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuongHieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChatLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTon;
        private System.Windows.Forms.DataGridViewImageColumn Sua;
        private System.Windows.Forms.DataGridViewImageColumn Xoa;
        private System.Windows.Forms.DataGridViewImageColumn ChiTiet;
    }
}