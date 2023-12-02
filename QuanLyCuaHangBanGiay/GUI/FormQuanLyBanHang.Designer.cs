namespace GUI
{
    partial class FormQuanLyBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyBanHang));
            this.flowLayoutPanelButton = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnPhieuTra = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.panelQuanLyBanHang = new System.Windows.Forms.Panel();
            this.flowLayoutPanelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelButton
            // 
            this.flowLayoutPanelButton.Controls.Add(this.btnHoaDon);
            this.flowLayoutPanelButton.Controls.Add(this.btnPhieuTra);
            this.flowLayoutPanelButton.Controls.Add(this.btnBanHang);
            this.flowLayoutPanelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelButton.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelButton.Name = "flowLayoutPanelButton";
            this.flowLayoutPanelButton.Size = new System.Drawing.Size(1329, 80);
            this.flowLayoutPanelButton.TabIndex = 1;
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnHoaDon.Image")));
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHoaDon.Location = new System.Drawing.Point(3, 3);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(117, 77);
            this.btnHoaDon.TabIndex = 1;
            this.btnHoaDon.Text = "Hóa Đơn";
            this.btnHoaDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnPhieuTra
            // 
            this.btnPhieuTra.FlatAppearance.BorderSize = 0;
            this.btnPhieuTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieuTra.Image = ((System.Drawing.Image)(resources.GetObject("btnPhieuTra.Image")));
            this.btnPhieuTra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPhieuTra.Location = new System.Drawing.Point(126, 3);
            this.btnPhieuTra.Name = "btnPhieuTra";
            this.btnPhieuTra.Size = new System.Drawing.Size(117, 77);
            this.btnPhieuTra.TabIndex = 2;
            this.btnPhieuTra.Text = "Phiếu Trả";
            this.btnPhieuTra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPhieuTra.UseVisualStyleBackColor = true;
            this.btnPhieuTra.Click += new System.EventHandler(this.btnPhieuTra_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.FlatAppearance.BorderSize = 0;
            this.btnBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanHang.Image = ((System.Drawing.Image)(resources.GetObject("btnBanHang.Image")));
            this.btnBanHang.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBanHang.Location = new System.Drawing.Point(249, 3);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(117, 77);
            this.btnBanHang.TabIndex = 3;
            this.btnBanHang.Text = "Bán Hàng";
            this.btnBanHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBanHang.UseVisualStyleBackColor = true;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // panelQuanLyBanHang
            // 
            this.panelQuanLyBanHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuanLyBanHang.Location = new System.Drawing.Point(0, 80);
            this.panelQuanLyBanHang.Name = "panelQuanLyBanHang";
            this.panelQuanLyBanHang.Size = new System.Drawing.Size(1329, 648);
            this.panelQuanLyBanHang.TabIndex = 2;
            // 
            // FormQuanLyBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1329, 728);
            this.Controls.Add(this.panelQuanLyBanHang);
            this.Controls.Add(this.flowLayoutPanelButton);
            this.Name = "FormQuanLyBanHang";
            this.Text = "FormQuanLyBanHang";
            this.flowLayoutPanelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButton;
        public System.Windows.Forms.Button btnHoaDon;
        public System.Windows.Forms.Button btnPhieuTra;
        public System.Windows.Forms.Panel panelQuanLyBanHang;
        public System.Windows.Forms.Button btnBanHang;
    }
}