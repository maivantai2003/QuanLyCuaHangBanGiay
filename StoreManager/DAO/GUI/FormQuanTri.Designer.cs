namespace GUI
{
    partial class FormQuanTri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanTri));
            this.flowLayoutPanelButton = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnNhomQuyen = new System.Windows.Forms.Button();
            this.btnChucNang = new System.Windows.Forms.Button();
            this.btnChiTietQuyen = new System.Windows.Forms.Button();
            this.panelQuanTri = new System.Windows.Forms.Panel();
            this.flowLayoutPanelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelButton
            // 
            this.flowLayoutPanelButton.Controls.Add(this.btnTaiKhoan);
            this.flowLayoutPanelButton.Controls.Add(this.btnNhomQuyen);
            this.flowLayoutPanelButton.Controls.Add(this.btnChucNang);
            this.flowLayoutPanelButton.Controls.Add(this.btnChiTietQuyen);
            this.flowLayoutPanelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelButton.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelButton.Name = "flowLayoutPanelButton";
            this.flowLayoutPanelButton.Size = new System.Drawing.Size(1329, 80);
            this.flowLayoutPanelButton.TabIndex = 0;
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiKhoan.Image")));
            this.btnTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTaiKhoan.Location = new System.Drawing.Point(3, 3);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(117, 77);
            this.btnTaiKhoan.TabIndex = 1;
            this.btnTaiKhoan.Text = "Tài Khoản";
            this.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnNhomQuyen
            // 
            this.btnNhomQuyen.FlatAppearance.BorderSize = 0;
            this.btnNhomQuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhomQuyen.Image = ((System.Drawing.Image)(resources.GetObject("btnNhomQuyen.Image")));
            this.btnNhomQuyen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNhomQuyen.Location = new System.Drawing.Point(126, 3);
            this.btnNhomQuyen.Name = "btnNhomQuyen";
            this.btnNhomQuyen.Size = new System.Drawing.Size(117, 77);
            this.btnNhomQuyen.TabIndex = 2;
            this.btnNhomQuyen.Text = "Nhóm Quyền";
            this.btnNhomQuyen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNhomQuyen.UseVisualStyleBackColor = true;
            this.btnNhomQuyen.Click += new System.EventHandler(this.btnNhomQuyen_Click);
            // 
            // btnChucNang
            // 
            this.btnChucNang.FlatAppearance.BorderSize = 0;
            this.btnChucNang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChucNang.Image = ((System.Drawing.Image)(resources.GetObject("btnChucNang.Image")));
            this.btnChucNang.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChucNang.Location = new System.Drawing.Point(249, 3);
            this.btnChucNang.Name = "btnChucNang";
            this.btnChucNang.Size = new System.Drawing.Size(117, 77);
            this.btnChucNang.TabIndex = 3;
            this.btnChucNang.Text = "Chức Năng";
            this.btnChucNang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChucNang.UseVisualStyleBackColor = true;
            this.btnChucNang.Click += new System.EventHandler(this.btnChucNang_Click);
            // 
            // btnChiTietQuyen
            // 
            this.btnChiTietQuyen.FlatAppearance.BorderSize = 0;
            this.btnChiTietQuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTietQuyen.Image = ((System.Drawing.Image)(resources.GetObject("btnChiTietQuyen.Image")));
            this.btnChiTietQuyen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChiTietQuyen.Location = new System.Drawing.Point(372, 3);
            this.btnChiTietQuyen.Name = "btnChiTietQuyen";
            this.btnChiTietQuyen.Size = new System.Drawing.Size(117, 77);
            this.btnChiTietQuyen.TabIndex = 4;
            this.btnChiTietQuyen.Text = "Chi Tiết Quyền";
            this.btnChiTietQuyen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChiTietQuyen.UseVisualStyleBackColor = true;
            this.btnChiTietQuyen.Click += new System.EventHandler(this.btnChiTietQuyen_Click);
            // 
            // panelQuanTri
            // 
            this.panelQuanTri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuanTri.Location = new System.Drawing.Point(0, 80);
            this.panelQuanTri.Name = "panelQuanTri";
            this.panelQuanTri.Size = new System.Drawing.Size(1329, 648);
            this.panelQuanTri.TabIndex = 1;
            // 
            // FormQuanTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1329, 728);
            this.Controls.Add(this.panelQuanTri);
            this.Controls.Add(this.flowLayoutPanelButton);
            this.Name = "FormQuanTri";
            this.Text = "FormQuanTri";
            this.flowLayoutPanelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButton;
        public System.Windows.Forms.Button btnTaiKhoan;
        public System.Windows.Forms.Button btnNhomQuyen;
        public System.Windows.Forms.Button btnChucNang;
        public System.Windows.Forms.Button btnChiTietQuyen;
        public System.Windows.Forms.Panel panelQuanTri;
    }
}