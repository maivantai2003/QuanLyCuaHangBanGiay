namespace GUI
{
    partial class FormQuanLyDanhMuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyDanhMuc));
            this.flowLayoutPanelButton = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThuongHieu = new System.Windows.Forms.Button();
            this.btnTheLoai = new System.Windows.Forms.Button();
            this.btnChatLieu = new System.Windows.Forms.Button();
            this.btnKichCo = new System.Windows.Forms.Button();
            this.btnMauSac = new System.Windows.Forms.Button();
            this.panelQuanLyDanhMuc = new System.Windows.Forms.Panel();
            this.flowLayoutPanelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelButton
            // 
            this.flowLayoutPanelButton.Controls.Add(this.btnThuongHieu);
            this.flowLayoutPanelButton.Controls.Add(this.btnTheLoai);
            this.flowLayoutPanelButton.Controls.Add(this.btnChatLieu);
            this.flowLayoutPanelButton.Controls.Add(this.btnKichCo);
            this.flowLayoutPanelButton.Controls.Add(this.btnMauSac);
            this.flowLayoutPanelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelButton.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelButton.Name = "flowLayoutPanelButton";
            this.flowLayoutPanelButton.Size = new System.Drawing.Size(1329, 80);
            this.flowLayoutPanelButton.TabIndex = 0;
            // 
            // btnThuongHieu
            // 
            this.btnThuongHieu.FlatAppearance.BorderSize = 0;
            this.btnThuongHieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuongHieu.Image = ((System.Drawing.Image)(resources.GetObject("btnThuongHieu.Image")));
            this.btnThuongHieu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThuongHieu.Location = new System.Drawing.Point(3, 3);
            this.btnThuongHieu.Name = "btnThuongHieu";
            this.btnThuongHieu.Size = new System.Drawing.Size(117, 77);
            this.btnThuongHieu.TabIndex = 0;
            this.btnThuongHieu.Text = "Thương Hiệu";
            this.btnThuongHieu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThuongHieu.UseVisualStyleBackColor = true;
            this.btnThuongHieu.Click += new System.EventHandler(this.btnThuongHieu_Click);
            // 
            // btnTheLoai
            // 
            this.btnTheLoai.FlatAppearance.BorderSize = 0;
            this.btnTheLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheLoai.Image = ((System.Drawing.Image)(resources.GetObject("btnTheLoai.Image")));
            this.btnTheLoai.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTheLoai.Location = new System.Drawing.Point(126, 3);
            this.btnTheLoai.Name = "btnTheLoai";
            this.btnTheLoai.Size = new System.Drawing.Size(117, 77);
            this.btnTheLoai.TabIndex = 1;
            this.btnTheLoai.Text = "Thể Loại";
            this.btnTheLoai.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTheLoai.UseVisualStyleBackColor = true;
            this.btnTheLoai.Click += new System.EventHandler(this.btnTheLoai_Click);
            // 
            // btnChatLieu
            // 
            this.btnChatLieu.FlatAppearance.BorderSize = 0;
            this.btnChatLieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChatLieu.Image = ((System.Drawing.Image)(resources.GetObject("btnChatLieu.Image")));
            this.btnChatLieu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChatLieu.Location = new System.Drawing.Point(249, 3);
            this.btnChatLieu.Name = "btnChatLieu";
            this.btnChatLieu.Size = new System.Drawing.Size(117, 77);
            this.btnChatLieu.TabIndex = 2;
            this.btnChatLieu.Text = "Chất Liệu";
            this.btnChatLieu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChatLieu.UseVisualStyleBackColor = true;
            this.btnChatLieu.Click += new System.EventHandler(this.btnChatLieu_Click);
            // 
            // btnKichCo
            // 
            this.btnKichCo.FlatAppearance.BorderSize = 0;
            this.btnKichCo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKichCo.Image = ((System.Drawing.Image)(resources.GetObject("btnKichCo.Image")));
            this.btnKichCo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKichCo.Location = new System.Drawing.Point(372, 3);
            this.btnKichCo.Name = "btnKichCo";
            this.btnKichCo.Size = new System.Drawing.Size(117, 77);
            this.btnKichCo.TabIndex = 3;
            this.btnKichCo.Text = "Kích Cỡ";
            this.btnKichCo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKichCo.UseVisualStyleBackColor = true;
            this.btnKichCo.Click += new System.EventHandler(this.btnKichCo_Click);
            // 
            // btnMauSac
            // 
            this.btnMauSac.FlatAppearance.BorderSize = 0;
            this.btnMauSac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMauSac.Image = ((System.Drawing.Image)(resources.GetObject("btnMauSac.Image")));
            this.btnMauSac.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMauSac.Location = new System.Drawing.Point(495, 3);
            this.btnMauSac.Name = "btnMauSac";
            this.btnMauSac.Size = new System.Drawing.Size(117, 77);
            this.btnMauSac.TabIndex = 4;
            this.btnMauSac.Text = "Màu Sắc";
            this.btnMauSac.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMauSac.UseVisualStyleBackColor = true;
            this.btnMauSac.Click += new System.EventHandler(this.btnMauSac_Click);
            // 
            // panelQuanLyDanhMuc
            // 
            this.panelQuanLyDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuanLyDanhMuc.Location = new System.Drawing.Point(0, 80);
            this.panelQuanLyDanhMuc.Name = "panelQuanLyDanhMuc";
            this.panelQuanLyDanhMuc.Size = new System.Drawing.Size(1329, 648);
            this.panelQuanLyDanhMuc.TabIndex = 1;
            // 
            // FormQuanLyDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1329, 728);
            this.Controls.Add(this.panelQuanLyDanhMuc);
            this.Controls.Add(this.flowLayoutPanelButton);
            this.Name = "FormQuanLyDanhMuc";
            this.Text = "FormQuanLyDanhMuc";
            this.flowLayoutPanelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButton;
        public System.Windows.Forms.Button btnThuongHieu;
        public System.Windows.Forms.Button btnTheLoai;
        public System.Windows.Forms.Button btnChatLieu;
        public System.Windows.Forms.Button btnKichCo;
        public System.Windows.Forms.Button btnMauSac;
        public System.Windows.Forms.Panel panelQuanLyDanhMuc;
    }
}