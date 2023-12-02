namespace GUI
{
    partial class FormPhieuTraModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhieuTraModel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxMaHoaDon = new System.Windows.Forms.ComboBox();
            this.txtTongTienTra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTongSoLuongTra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNgayTra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaPhieuTra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCapNhatChiTietPhieuTra = new System.Windows.Forms.Button();
            this.btnThemChiTietPhieuTra = new System.Windows.Forms.Button();
            this.numericSLTra = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGiaSanPham = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLyDoTra = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaChiTietSanPham = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.MaChiTietSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MauSac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KichCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewChiTietPhieuTra = new System.Windows.Forms.DataGridView();
            this.MaCTSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDoTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSLTra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietPhieuTra)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1616, 56);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(744, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phiếu Trả";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxMaHoaDon);
            this.groupBox1.Controls.Add(this.txtTongTienTra);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTongSoLuongTra);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNgayTra);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTenNhanVien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaPhieuTra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 275);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu Trả";
            // 
            // comboBoxMaHoaDon
            // 
            this.comboBoxMaHoaDon.FormattingEnabled = true;
            this.comboBoxMaHoaDon.Location = new System.Drawing.Point(137, 67);
            this.comboBoxMaHoaDon.Name = "comboBoxMaHoaDon";
            this.comboBoxMaHoaDon.Size = new System.Drawing.Size(238, 24);
            this.comboBoxMaHoaDon.TabIndex = 12;
            this.comboBoxMaHoaDon.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaHoaDon_SelectedIndexChanged);
            // 
            // txtTongTienTra
            // 
            this.txtTongTienTra.Location = new System.Drawing.Point(137, 245);
            this.txtTongTienTra.Name = "txtTongTienTra";
            this.txtTongTienTra.ReadOnly = true;
            this.txtTongTienTra.Size = new System.Drawing.Size(238, 22);
            this.txtTongTienTra.TabIndex = 11;
            this.txtTongTienTra.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tổng Tiền Trả";
            // 
            // txtTongSoLuongTra
            // 
            this.txtTongSoLuongTra.Location = new System.Drawing.Point(137, 201);
            this.txtTongSoLuongTra.Name = "txtTongSoLuongTra";
            this.txtTongSoLuongTra.ReadOnly = true;
            this.txtTongSoLuongTra.Size = new System.Drawing.Size(238, 22);
            this.txtTongSoLuongTra.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tổng Số Lượng Trả";
            // 
            // txtNgayTra
            // 
            this.txtNgayTra.Location = new System.Drawing.Point(137, 159);
            this.txtNgayTra.Name = "txtNgayTra";
            this.txtNgayTra.ReadOnly = true;
            this.txtNgayTra.Size = new System.Drawing.Size(238, 22);
            this.txtNgayTra.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày Trả";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(137, 117);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.ReadOnly = true;
            this.txtTenNhanVien.Size = new System.Drawing.Size(238, 22);
            this.txtTenNhanVien.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Hóa Đơn";
            // 
            // txtMaPhieuTra
            // 
            this.txtMaPhieuTra.Location = new System.Drawing.Point(137, 27);
            this.txtMaPhieuTra.Name = "txtMaPhieuTra";
            this.txtMaPhieuTra.ReadOnly = true;
            this.txtMaPhieuTra.Size = new System.Drawing.Size(238, 22);
            this.txtMaPhieuTra.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phiếu Trả";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtThanhTien);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btnCapNhatChiTietPhieuTra);
            this.groupBox2.Controls.Add(this.btnThemChiTietPhieuTra);
            this.groupBox2.Controls.Add(this.numericSLTra);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtGiaSanPham);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtLyDoTra);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtMaChiTietSanPham);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(398, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 275);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Phiếu Trả";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(95, 191);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(296, 22);
            this.txtThanhTien.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "Thành Tiền";
            // 
            // btnCapNhatChiTietPhieuTra
            // 
            this.btnCapNhatChiTietPhieuTra.Location = new System.Drawing.Point(238, 227);
            this.btnCapNhatChiTietPhieuTra.Name = "btnCapNhatChiTietPhieuTra";
            this.btnCapNhatChiTietPhieuTra.Size = new System.Drawing.Size(155, 40);
            this.btnCapNhatChiTietPhieuTra.TabIndex = 9;
            this.btnCapNhatChiTietPhieuTra.Text = "Cập Nhật";
            this.btnCapNhatChiTietPhieuTra.UseVisualStyleBackColor = true;
            this.btnCapNhatChiTietPhieuTra.Click += new System.EventHandler(this.btnCapNhatChiTietPhieuTra_Click);
            // 
            // btnThemChiTietPhieuTra
            // 
            this.btnThemChiTietPhieuTra.Location = new System.Drawing.Point(95, 227);
            this.btnThemChiTietPhieuTra.Name = "btnThemChiTietPhieuTra";
            this.btnThemChiTietPhieuTra.Size = new System.Drawing.Size(137, 40);
            this.btnThemChiTietPhieuTra.TabIndex = 8;
            this.btnThemChiTietPhieuTra.Text = "Thêm";
            this.btnThemChiTietPhieuTra.UseVisualStyleBackColor = true;
            this.btnThemChiTietPhieuTra.Click += new System.EventHandler(this.btnThemChiTietPhieuTra_Click);
            // 
            // numericSLTra
            // 
            this.numericSLTra.BackColor = System.Drawing.Color.White;
            this.numericSLTra.Location = new System.Drawing.Point(95, 163);
            this.numericSLTra.Name = "numericSLTra";
            this.numericSLTra.Size = new System.Drawing.Size(296, 22);
            this.numericSLTra.TabIndex = 7;
            this.numericSLTra.ValueChanged += new System.EventHandler(this.numericSLTra_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Số Lượng";
            // 
            // txtGiaSanPham
            // 
            this.txtGiaSanPham.Location = new System.Drawing.Point(95, 123);
            this.txtGiaSanPham.Name = "txtGiaSanPham";
            this.txtGiaSanPham.ReadOnly = true;
            this.txtGiaSanPham.Size = new System.Drawing.Size(297, 22);
            this.txtGiaSanPham.TabIndex = 5;
            this.txtGiaSanPham.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Giá Sản Phẩm";
            // 
            // txtLyDoTra
            // 
            this.txtLyDoTra.Location = new System.Drawing.Point(97, 73);
            this.txtLyDoTra.Name = "txtLyDoTra";
            this.txtLyDoTra.Size = new System.Drawing.Size(297, 37);
            this.txtLyDoTra.TabIndex = 3;
            this.txtLyDoTra.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Lý Do Trả";
            // 
            // txtMaChiTietSanPham
            // 
            this.txtMaChiTietSanPham.Location = new System.Drawing.Point(97, 19);
            this.txtMaChiTietSanPham.Name = "txtMaChiTietSanPham";
            this.txtMaChiTietSanPham.ReadOnly = true;
            this.txtMaChiTietSanPham.Size = new System.Drawing.Size(297, 22);
            this.txtMaChiTietSanPham.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã CTSP";
            // 
            // dataGridViewChiTietHoaDon
            // 
            this.dataGridViewChiTietHoaDon.AllowUserToAddRows = false;
            this.dataGridViewChiTietHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChiTietHoaDon.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewChiTietHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChiTietSanPham,
            this.TenSanPham,
            this.MauSac,
            this.KichCo,
            this.SLuong,
            this.GiaSP,
            this.ThanhTien});
            this.dataGridViewChiTietHoaDon.Location = new System.Drawing.Point(798, 71);
            this.dataGridViewChiTietHoaDon.Name = "dataGridViewChiTietHoaDon";
            this.dataGridViewChiTietHoaDon.RowHeadersWidth = 51;
            this.dataGridViewChiTietHoaDon.RowTemplate.Height = 24;
            this.dataGridViewChiTietHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChiTietHoaDon.Size = new System.Drawing.Size(816, 554);
            this.dataGridViewChiTietHoaDon.TabIndex = 13;
            this.dataGridViewChiTietHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChiTietHoaDon_CellContentClick);
            // 
            // MaChiTietSanPham
            // 
            this.MaChiTietSanPham.HeaderText = "Mã CTSP";
            this.MaChiTietSanPham.MinimumWidth = 6;
            this.MaChiTietSanPham.Name = "MaChiTietSanPham";
            // 
            // TenSanPham
            // 
            this.TenSanPham.HeaderText = "Tên SP";
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
            // SLuong
            // 
            this.SLuong.HeaderText = "Số Lượng";
            this.SLuong.MinimumWidth = 6;
            this.SLuong.Name = "SLuong";
            // 
            // GiaSP
            // 
            this.GiaSP.HeaderText = "Giá SP";
            this.GiaSP.MinimumWidth = 6;
            this.GiaSP.Name = "GiaSP";
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            // 
            // dataGridViewChiTietPhieuTra
            // 
            this.dataGridViewChiTietPhieuTra.AllowUserToAddRows = false;
            this.dataGridViewChiTietPhieuTra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChiTietPhieuTra.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewChiTietPhieuTra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewChiTietPhieuTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiTietPhieuTra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCTSP,
            this.LyDoTra,
            this.GiaSanPham,
            this.SoLuong,
            this.ThanhT,
            this.Xoa});
            this.dataGridViewChiTietPhieuTra.Location = new System.Drawing.Point(4, 345);
            this.dataGridViewChiTietPhieuTra.Name = "dataGridViewChiTietPhieuTra";
            this.dataGridViewChiTietPhieuTra.RowHeadersWidth = 51;
            this.dataGridViewChiTietPhieuTra.RowTemplate.Height = 24;
            this.dataGridViewChiTietPhieuTra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChiTietPhieuTra.Size = new System.Drawing.Size(788, 280);
            this.dataGridViewChiTietPhieuTra.TabIndex = 14;
            this.dataGridViewChiTietPhieuTra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChiTietPhieuTra_CellContentClick);
            // 
            // MaCTSP
            // 
            this.MaCTSP.HeaderText = "Mã CTSP";
            this.MaCTSP.MinimumWidth = 6;
            this.MaCTSP.Name = "MaCTSP";
            // 
            // LyDoTra
            // 
            this.LyDoTra.HeaderText = "Lý Do Trả";
            this.LyDoTra.MinimumWidth = 6;
            this.LyDoTra.Name = "LyDoTra";
            // 
            // GiaSanPham
            // 
            this.GiaSanPham.HeaderText = "Giá Sản Phẩm";
            this.GiaSanPham.MinimumWidth = 6;
            this.GiaSanPham.Name = "GiaSanPham";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // ThanhT
            // 
            this.ThanhT.HeaderText = "Thành Tiền";
            this.ThanhT.MinimumWidth = 6;
            this.ThanhT.Name = "ThanhT";
            // 
            // Xoa
            // 
            this.Xoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.Image = ((System.Drawing.Image)(resources.GetObject("Xoa.Image")));
            this.Xoa.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Xoa.MinimumWidth = 6;
            this.Xoa.Name = "Xoa";
            this.Xoa.Width = 37;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnThem);
            this.flowLayoutPanel1.Controls.Add(this.btnThoat);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(681, 644);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(249, 45);
            this.flowLayoutPanel1.TabIndex = 28;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(117, 37);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(126, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(117, 38);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FormPhieuTraModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1616, 701);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridViewChiTietPhieuTra);
            this.Controls.Add(this.dataGridViewChiTietHoaDon);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPhieuTraModel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPhieuTraModel";
            this.Load += new System.EventHandler(this.FormPhieuTraModel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSLTra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietPhieuTra)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtMaPhieuTra;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtTongTienTra;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtTongSoLuongTra;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtNgayTra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtMaChiTietSanPham;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox txtLyDoTra;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtGiaSanPham;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridViewChiTietHoaDon;
        private System.Windows.Forms.DataGridView dataGridViewChiTietPhieuTra;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Button btnThem;
        public System.Windows.Forms.Button btnThoat;
        public System.Windows.Forms.NumericUpDown numericSLTra;
        private System.Windows.Forms.Button btnCapNhatChiTietPhieuTra;
        private System.Windows.Forms.Button btnThemChiTietPhieuTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChiTietSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MauSac;
        private System.Windows.Forms.DataGridViewTextBoxColumn KichCo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        public System.Windows.Forms.ComboBox comboBoxMaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCTSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDoTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhT;
        private System.Windows.Forms.DataGridViewImageColumn Xoa;
        public System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label12;
    }
}