﻿namespace GUI
{
    partial class FormChatLieu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChatLieu));
            this.dataGridViewChatLieu = new System.Windows.Forms.DataGridView();
            this.MaChatLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChatLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sua = new System.Windows.Forms.DataGridViewImageColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.ChiTiet = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.formTimKiem1 = new GUI.formTimKiem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChatLieu)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewChatLieu
            // 
            this.dataGridViewChatLieu.AllowUserToAddRows = false;
            this.dataGridViewChatLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChatLieu.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewChatLieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewChatLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChatLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChatLieu,
            this.TenChatLieu,
            this.Sua,
            this.Xoa,
            this.ChiTiet});
            this.dataGridViewChatLieu.Location = new System.Drawing.Point(3, 83);
            this.dataGridViewChatLieu.Name = "dataGridViewChatLieu";
            this.dataGridViewChatLieu.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridViewChatLieu.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewChatLieu.RowTemplate.Height = 24;
            this.dataGridViewChatLieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChatLieu.Size = new System.Drawing.Size(1316, 317);
            this.dataGridViewChatLieu.TabIndex = 7;
            this.dataGridViewChatLieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChatLieu_CellContentClick);
            // 
            // MaChatLieu
            // 
            this.MaChatLieu.DataPropertyName = "MaChatLieu";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MaChatLieu.DefaultCellStyle = dataGridViewCellStyle8;
            this.MaChatLieu.HeaderText = "Mã Chất Liệu";
            this.MaChatLieu.MinimumWidth = 6;
            this.MaChatLieu.Name = "MaChatLieu";
            // 
            // TenChatLieu
            // 
            this.TenChatLieu.DataPropertyName = "TenChatLieu";
            this.TenChatLieu.HeaderText = "Tên Chất Liệu";
            this.TenChatLieu.MinimumWidth = 6;
            this.TenChatLieu.Name = "TenChatLieu";
            // 
            // Sua
            // 
            this.Sua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Sua.HeaderText = "Sửa";
            this.Sua.Image = ((System.Drawing.Image)(resources.GetObject("Sua.Image")));
            this.Sua.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Sua.MinimumWidth = 6;
            this.Sua.Name = "Sua";
            this.Sua.Width = 37;
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
            // ChiTiet
            // 
            this.ChiTiet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ChiTiet.HeaderText = "Chi Tiết";
            this.ChiTiet.Image = ((System.Drawing.Image)(resources.GetObject("ChiTiet.Image")));
            this.ChiTiet.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ChiTiet.MinimumWidth = 6;
            this.ChiTiet.Name = "ChiTiet";
            this.ChiTiet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnExport);
            this.flowLayoutPanel1.Controls.Add(this.btnImport);
            this.flowLayoutPanel1.Controls.Add(this.btnThem);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1074, 403);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(245, 75);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // btnExport
            // 
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExport.Location = new System.Drawing.Point(158, 3);
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
            this.btnImport.Location = new System.Drawing.Point(82, 3);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(70, 71);
            this.btnImport.TabIndex = 14;
            this.btnImport.Text = "IMPORT";
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(6, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 71);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.formTimKiem1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1319, 77);
            this.panel1.TabIndex = 9;
            // 
            // formTimKiem1
            // 
            this.formTimKiem1.BackColor = System.Drawing.SystemColors.Control;
            this.formTimKiem1.Location = new System.Drawing.Point(2, 12);
            this.formTimKiem1.Name = "formTimKiem1";
            this.formTimKiem1.Size = new System.Drawing.Size(1314, 50);
            this.formTimKiem1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Excel Document|*.xls;*.xlsx";
            // 
            // FormChatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1319, 670);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridViewChatLieu);
            this.Name = "FormChatLieu";
            this.Text = "FormChatLieu";
            this.Load += new System.EventHandler(this.FormChatLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChatLieu)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        public System.Windows.Forms.DataGridView dataGridViewChatLieu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Button btnExport;
        public System.Windows.Forms.Button btnImport;
        public System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel1;
        private formTimKiem formTimKiem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChatLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChatLieu;
        private System.Windows.Forms.DataGridViewImageColumn Sua;
        private System.Windows.Forms.DataGridViewImageColumn Xoa;
        private System.Windows.Forms.DataGridViewImageColumn ChiTiet;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}