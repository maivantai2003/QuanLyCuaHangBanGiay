namespace GUI
{
    partial class FormBanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBanHang));
            this.dataGridViewDanhSachSanPham = new System.Windows.Forms.DataGridView();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChatLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThuongHieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KichCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnh = new System.Windows.Forms.DataGridViewImageColumn();
            this.SoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThemCT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.btnSuaCT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaSanPham = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietHoaDon)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDanhSachSanPham
            // 
            this.dataGridViewDanhSachSanPham.AllowUserToAddRows = false;
            this.dataGridViewDanhSachSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDanhSachSanPham.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDanhSachSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewDanhSachSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSanPham,
            this.TenSanPham,
            this.TheLoai,
            this.ChatLieu,
            this.ThuongHieu,
            this.MS,
            this.KichCo,
            this.GiaSP,
            this.HinhAnh,
            this.SoLuongTon});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDanhSachSanPham.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewDanhSachSanPham.GridColor = System.Drawing.Color.White;
            this.dataGridViewDanhSachSanPham.Location = new System.Drawing.Point(4, 43);
            this.dataGridViewDanhSachSanPham.Name = "dataGridViewDanhSachSanPham";
            this.dataGridViewDanhSachSanPham.ReadOnly = true;
            this.dataGridViewDanhSachSanPham.RowHeadersWidth = 51;
            this.dataGridViewDanhSachSanPham.RowTemplate.Height = 100;
            this.dataGridViewDanhSachSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDanhSachSanPham.Size = new System.Drawing.Size(1311, 214);
            this.dataGridViewDanhSachSanPham.TabIndex = 0;
            this.dataGridViewDanhSachSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDanhSachSanPham_CellContentClick);
            // 
            // MaSanPham
            // 
            this.MaSanPham.HeaderText = "Mã Sản Phẩm";
            this.MaSanPham.MinimumWidth = 6;
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.ReadOnly = true;
            // 
            // TenSanPham
            // 
            this.TenSanPham.HeaderText = "Tên SP";
            this.TenSanPham.MinimumWidth = 6;
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.ReadOnly = true;
            // 
            // TheLoai
            // 
            this.TheLoai.HeaderText = "Thể Loại";
            this.TheLoai.MinimumWidth = 6;
            this.TheLoai.Name = "TheLoai";
            this.TheLoai.ReadOnly = true;
            // 
            // ChatLieu
            // 
            this.ChatLieu.HeaderText = "Chất Liệu";
            this.ChatLieu.MinimumWidth = 6;
            this.ChatLieu.Name = "ChatLieu";
            this.ChatLieu.ReadOnly = true;
            // 
            // ThuongHieu
            // 
            this.ThuongHieu.HeaderText = "Thương Hiệu";
            this.ThuongHieu.MinimumWidth = 6;
            this.ThuongHieu.Name = "ThuongHieu";
            this.ThuongHieu.ReadOnly = true;
            // 
            // MS
            // 
            this.MS.HeaderText = "Màu Sắc";
            this.MS.MinimumWidth = 6;
            this.MS.Name = "MS";
            this.MS.ReadOnly = true;
            // 
            // KichCo
            // 
            this.KichCo.HeaderText = "Kích Cỡ";
            this.KichCo.MinimumWidth = 6;
            this.KichCo.Name = "KichCo";
            this.KichCo.ReadOnly = true;
            // 
            // GiaSP
            // 
            this.GiaSP.HeaderText = "Giá SP";
            this.GiaSP.MinimumWidth = 6;
            this.GiaSP.Name = "GiaSP";
            this.GiaSP.ReadOnly = true;
            // 
            // HinhAnh
            // 
            this.HinhAnh.HeaderText = "Hình Ảnh";
            this.HinhAnh.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.HinhAnh.MinimumWidth = 6;
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.ReadOnly = true;
            this.HinhAnh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HinhAnh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SoLuongTon
            // 
            this.SoLuongTon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SoLuongTon.HeaderText = "Số Lượng Tồn";
            this.SoLuongTon.MinimumWidth = 6;
            this.SoLuongTon.Name = "SoLuongTon";
            this.SoLuongTon.ReadOnly = true;
            this.SoLuongTon.Width = 120;
            // 
            // dataGridViewChiTietHoaDon
            // 
            this.dataGridViewChiTietHoaDon.AllowUserToAddRows = false;
            this.dataGridViewChiTietHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChiTietHoaDon.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewChiTietHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenSP,
            this.MSac,
            this.Kco,
            this.GiaSanPham,
            this.SoLuong,
            this.ThanhTien,
            this.Xoa});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewChiTietHoaDon.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewChiTietHoaDon.Location = new System.Drawing.Point(4, 364);
            this.dataGridViewChiTietHoaDon.Name = "dataGridViewChiTietHoaDon";
            this.dataGridViewChiTietHoaDon.ReadOnly = true;
            this.dataGridViewChiTietHoaDon.RowHeadersWidth = 51;
            this.dataGridViewChiTietHoaDon.RowTemplate.Height = 24;
            this.dataGridViewChiTietHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChiTietHoaDon.Size = new System.Drawing.Size(1311, 236);
            this.dataGridViewChiTietHoaDon.TabIndex = 1;
            this.dataGridViewChiTietHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChiTietHoaDon_CellContentClick);
            // 
            // TenSP
            // 
            this.TenSP.HeaderText = "Tên Sản Phẩm";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // MSac
            // 
            this.MSac.HeaderText = "Màu Sắc";
            this.MSac.MinimumWidth = 6;
            this.MSac.Name = "MSac";
            this.MSac.ReadOnly = true;
            // 
            // Kco
            // 
            this.Kco.HeaderText = "Kích Cỡ";
            this.Kco.MinimumWidth = 6;
            this.Kco.Name = "Kco";
            this.Kco.ReadOnly = true;
            // 
            // GiaSanPham
            // 
            this.GiaSanPham.HeaderText = "Giá Sản Phẩm";
            this.GiaSanPham.MinimumWidth = 6;
            this.GiaSanPham.Name = "GiaSanPham";
            this.GiaSanPham.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // Xoa
            // 
            this.Xoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.Image = ((System.Drawing.Image)(resources.GetObject("Xoa.Image")));
            this.Xoa.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Xoa.MinimumWidth = 6;
            this.Xoa.Name = "Xoa";
            this.Xoa.ReadOnly = true;
            this.Xoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Xoa.Width = 37;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn);
            this.flowLayoutPanel1.Controls.Add(this.btnHuy);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(546, 606);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(196, 47);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(3, 3);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(92, 37);
            this.btn.TabIndex = 0;
            this.btn.Text = "Tiếp Tục";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(101, 3);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(92, 37);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThemCT
            // 
            this.btnThemCT.Location = new System.Drawing.Point(997, 274);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(93, 33);
            this.btnThemCT.TabIndex = 3;
            this.btnThemCT.Text = "Thêm";
            this.btnThemCT.UseVisualStyleBackColor = true;
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(598, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số Lượng";
            // 
            // numericSoLuong
            // 
            this.numericSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericSoLuong.Location = new System.Drawing.Point(697, 280);
            this.numericSoLuong.Name = "numericSoLuong";
            this.numericSoLuong.Size = new System.Drawing.Size(252, 24);
            this.numericSoLuong.TabIndex = 5;
            this.numericSoLuong.ValueChanged += new System.EventHandler(this.numericSoLuong_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(598, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Thành Tiền";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(697, 313);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(252, 24);
            this.txtThanhTien.TabIndex = 7;
            // 
            // btnSuaCT
            // 
            this.btnSuaCT.Location = new System.Drawing.Point(997, 309);
            this.btnSuaCT.Name = "btnSuaCT";
            this.btnSuaCT.Size = new System.Drawing.Size(93, 33);
            this.btnSuaCT.TabIndex = 8;
            this.btnSuaCT.Text = "Sửa";
            this.btnSuaCT.UseVisualStyleBackColor = true;
            this.btnSuaCT.Click += new System.EventHandler(this.btnSuaCT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên Sản Phẩm";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSanPham.Location = new System.Drawing.Point(296, 278);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.ReadOnly = true;
            this.txtTenSanPham.Size = new System.Drawing.Size(252, 24);
            this.txtTenSanPham.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Giá Sản Phẩm";
            // 
            // txtGiaSanPham
            // 
            this.txtGiaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaSanPham.Location = new System.Drawing.Point(296, 310);
            this.txtGiaSanPham.Name = "txtGiaSanPham";
            this.txtGiaSanPham.ReadOnly = true;
            this.txtGiaSanPham.Size = new System.Drawing.Size(252, 24);
            this.txtGiaSanPham.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(4, 348);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1311, 264);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sản Phẩm Đã Chọn";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(4, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1311, 212);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sản Phẩm";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(150, 263);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(955, 79);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi Tiết Sản Phẩm Được Chọn";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "Xóa";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // txtTK
            // 
            this.txtTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.Location = new System.Drawing.Point(104, 12);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(273, 24);
            this.txtTK.TabIndex = 16;
            this.txtTK.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(384, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(54, 25);
            this.btnClear.TabIndex = 17;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1319, 670);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.txtGiaSanPham);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSuaCT);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericSoLuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThemCT);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridViewChiTietHoaDon);
            this.Controls.Add(this.dataGridViewDanhSachSanPham);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormBanHang";
            this.Text = "FormBanHang";
            this.Load += new System.EventHandler(this.FormBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietHoaDon)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn;
        public System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThemCT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Button btnSuaCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kco;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewImageColumn Xoa;
        public System.Windows.Forms.DataGridView dataGridViewDanhSachSanPham;
        public System.Windows.Forms.DataGridView dataGridViewChiTietHoaDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiaSanPham;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChatLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThuongHieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MS;
        private System.Windows.Forms.DataGridViewTextBoxColumn KichCo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaSP;
        private System.Windows.Forms.DataGridViewImageColumn HinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTon;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Button btnClear;
    }
}