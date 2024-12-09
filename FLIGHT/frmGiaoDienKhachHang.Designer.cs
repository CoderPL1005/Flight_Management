namespace FLIGHTS
{
    partial class frmGiaoDienKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoDienKhachHang));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butDangXuat = new System.Windows.Forms.Button();
            this.butVeDat = new System.Windows.Forms.Button();
            this.butThongTin = new System.Windows.Forms.Button();
            this.butAnh = new System.Windows.Forms.Button();
            this.panMain = new System.Windows.Forms.Panel();
            this.toolMain = new System.Windows.Forms.ToolStripButton();
            this.butMain = new System.Windows.Forms.ToolStripButton();
            this.butDangNhap = new System.Windows.Forms.ToolStripButton();
            this.butDangKy = new System.Windows.Forms.ToolStripButton();
            this.butDatVe = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMain,
            this.butMain,
            this.toolStripSeparator2,
            this.butDangNhap,
            this.toolStripSeparator1,
            this.butDangKy,
            this.toolStripSeparator3,
            this.butDatVe});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1940, 50);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 50);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.butDangXuat);
            this.panel1.Controls.Add(this.butVeDat);
            this.panel1.Controls.Add(this.butThongTin);
            this.panel1.Controls.Add(this.butAnh);
            this.panel1.Location = new System.Drawing.Point(1783, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 200);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // butDangXuat
            // 
            this.butDangXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.butDangXuat.Location = new System.Drawing.Point(0, 150);
            this.butDangXuat.Margin = new System.Windows.Forms.Padding(0);
            this.butDangXuat.Name = "butDangXuat";
            this.butDangXuat.Size = new System.Drawing.Size(157, 50);
            this.butDangXuat.TabIndex = 4;
            this.butDangXuat.Text = "Đăng xuất";
            this.butDangXuat.UseVisualStyleBackColor = true;
            this.butDangXuat.Click += new System.EventHandler(this.butDangXuat_Click);
            // 
            // butVeDat
            // 
            this.butVeDat.Dock = System.Windows.Forms.DockStyle.Top;
            this.butVeDat.Location = new System.Drawing.Point(0, 100);
            this.butVeDat.Margin = new System.Windows.Forms.Padding(0);
            this.butVeDat.Name = "butVeDat";
            this.butVeDat.Size = new System.Drawing.Size(157, 50);
            this.butVeDat.TabIndex = 3;
            this.butVeDat.Text = "Vé đặt";
            this.butVeDat.UseVisualStyleBackColor = true;
            this.butVeDat.Click += new System.EventHandler(this.butVeDat_Click);
            // 
            // butThongTin
            // 
            this.butThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.butThongTin.Location = new System.Drawing.Point(0, 50);
            this.butThongTin.Margin = new System.Windows.Forms.Padding(0);
            this.butThongTin.Name = "butThongTin";
            this.butThongTin.Size = new System.Drawing.Size(157, 50);
            this.butThongTin.TabIndex = 2;
            this.butThongTin.Text = "Thông tin";
            this.butThongTin.UseVisualStyleBackColor = true;
            this.butThongTin.Click += new System.EventHandler(this.butThongTin_Click);
            // 
            // butAnh
            // 
            this.butAnh.Dock = System.Windows.Forms.DockStyle.Top;
            this.butAnh.Location = new System.Drawing.Point(0, 0);
            this.butAnh.Margin = new System.Windows.Forms.Padding(0);
            this.butAnh.Name = "butAnh";
            this.butAnh.Size = new System.Drawing.Size(157, 50);
            this.butAnh.TabIndex = 1;
            this.butAnh.Text = "Chọn ảnh đại diện";
            this.butAnh.UseVisualStyleBackColor = true;
            this.butAnh.Click += new System.EventHandler(this.butAnh_Click);
            // 
            // panMain
            // 
            this.panMain.AutoScroll = true;
            this.panMain.BackColor = System.Drawing.Color.White;
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Location = new System.Drawing.Point(0, 50);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(1940, 741);
            this.panMain.TabIndex = 3;
            // 
            // toolMain
            // 
            this.toolMain.Image = global::FLIGHT.Properties.Resources._8546973_pinterest_p_icon;
            this.toolMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMain.Name = "toolMain";
            this.toolMain.Size = new System.Drawing.Size(76, 47);
            this.toolMain.Text = "Airline";
            this.toolMain.Click += new System.EventHandler(this.toolMain_Click);
            // 
            // butMain
            // 
            this.butMain.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.butMain.AutoSize = false;
            this.butMain.Image = ((System.Drawing.Image)(resources.GetObject("butMain.Image")));
            this.butMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butMain.Name = "butMain";
            this.butMain.Size = new System.Drawing.Size(50, 50);
            this.butMain.Visible = false;
            this.butMain.Click += new System.EventHandler(this.butMain_Click);
            // 
            // butDangNhap
            // 
            this.butDangNhap.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.butDangNhap.AutoSize = false;
            this.butDangNhap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.butDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("butDangNhap.Image")));
            this.butDangNhap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butDangNhap.Margin = new System.Windows.Forms.Padding(0);
            this.butDangNhap.Name = "butDangNhap";
            this.butDangNhap.Size = new System.Drawing.Size(100, 50);
            this.butDangNhap.Text = "Đăng nhập";
            this.butDangNhap.Click += new System.EventHandler(this.butDangNhap_Click);
            // 
            // butDangKy
            // 
            this.butDangKy.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.butDangKy.AutoSize = false;
            this.butDangKy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.butDangKy.Image = ((System.Drawing.Image)(resources.GetObject("butDangKy.Image")));
            this.butDangKy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butDangKy.Name = "butDangKy";
            this.butDangKy.Size = new System.Drawing.Size(100, 50);
            this.butDangKy.Text = "Đăng ký";
            this.butDangKy.Click += new System.EventHandler(this.butDangKy_Click);
            // 
            // butDatVe
            // 
            this.butDatVe.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.butDatVe.AutoSize = false;
            this.butDatVe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.butDatVe.Image = ((System.Drawing.Image)(resources.GetObject("butDatVe.Image")));
            this.butDatVe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butDatVe.Name = "butDatVe";
            this.butDatVe.Size = new System.Drawing.Size(100, 50);
            this.butDatVe.Text = "Đặt vé";
            this.butDatVe.Click += new System.EventHandler(this.butDatVe_Click);
            // 
            // frmGiaoDienKhachHang
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1940, 791);
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.IconOptions.Image = global::FLIGHT.Properties.Resources._7208682_application_cat_pet_icon;
            this.Name = "frmGiaoDienKhachHang";
            this.Text = "Airline";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGiaoDienKhachHang_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolMain;
        private System.Windows.Forms.ToolStripButton butMain;
        private System.Windows.Forms.ToolStripButton butDangNhap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton butDangKy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butVeDat;
        private System.Windows.Forms.Button butThongTin;
        private System.Windows.Forms.Button butAnh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button butDangXuat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton butDatVe;
        private System.Windows.Forms.Panel panMain;
    }
}