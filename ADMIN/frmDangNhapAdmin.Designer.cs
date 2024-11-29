namespace ADMIN
{
    partial class frmDangNhapAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhapAdmin));
            this.btShowPass = new DevExpress.XtraEditors.SimpleButton();
            this.labPassword = new DevExpress.XtraEditors.LabelControl();
            this.labUsername = new DevExpress.XtraEditors.LabelControl();
            this.labLogin = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbUsername = new DevExpress.XtraEditors.SimpleButton();
            this.lbPassword = new DevExpress.XtraEditors.SimpleButton();
            this.simbutClose = new DevExpress.XtraEditors.SimpleButton();
            this.simbutLogin = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btShowPass
            // 
            this.btShowPass.Location = new System.Drawing.Point(500, 233);
            this.btShowPass.Margin = new System.Windows.Forms.Padding(5);
            this.btShowPass.Name = "btShowPass";
            this.btShowPass.Size = new System.Drawing.Size(39, 23);
            this.btShowPass.TabIndex = 22;
            this.btShowPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btShowPass_MouseDown);
            this.btShowPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btShowPass_MouseUp);
            // 
            // labPassword
            // 
            this.labPassword.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labPassword.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labPassword.Appearance.Options.UseFont = true;
            this.labPassword.Appearance.Options.UseForeColor = true;
            this.labPassword.Location = new System.Drawing.Point(57, 229);
            this.labPassword.Margin = new System.Windows.Forms.Padding(5);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(97, 24);
            this.labPassword.TabIndex = 21;
            this.labPassword.Text = "Password";
            // 
            // labUsername
            // 
            this.labUsername.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labUsername.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labUsername.Appearance.Options.UseFont = true;
            this.labUsername.Appearance.Options.UseForeColor = true;
            this.labUsername.Location = new System.Drawing.Point(57, 133);
            this.labUsername.Margin = new System.Windows.Forms.Padding(5);
            this.labUsername.Name = "labUsername";
            this.labUsername.Size = new System.Drawing.Size(102, 24);
            this.labUsername.TabIndex = 20;
            this.labUsername.Text = "Username";
            // 
            // labLogin
            // 
            this.labLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.labLogin.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labLogin.Appearance.Options.UseFont = true;
            this.labLogin.Appearance.Options.UseForeColor = true;
            this.labLogin.Location = new System.Drawing.Point(277, 51);
            this.labLogin.Margin = new System.Windows.Forms.Padding(5);
            this.labLogin.Name = "labLogin";
            this.labLogin.Size = new System.Drawing.Size(128, 51);
            this.labLogin.TabIndex = 19;
            this.labLogin.Text = "Log in";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(181, 233);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(358, 23);
            this.txtPassword.TabIndex = 16;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(182, 137);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(357, 23);
            this.txtUsername.TabIndex = 15;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "8666649_eye_off_icon.png");
            this.imageList1.Images.SetKeyName(1, "392505_eye_preview_see_seen_view_icon.png");
            // 
            // lbUsername
            // 
            this.lbUsername.ImageOptions.Image = global::ADMIN.Properties.Resources.warning_16x163;
            this.lbUsername.Location = new System.Drawing.Point(277, 168);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(5);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(262, 45);
            this.lbUsername.TabIndex = 23;
            this.lbUsername.Text = "Tài khoản không hợp lệ";
            this.lbUsername.Visible = false;
            // 
            // lbPassword
            // 
            this.lbPassword.ImageOptions.Image = global::ADMIN.Properties.Resources.warning_16x162;
            this.lbPassword.Location = new System.Drawing.Point(240, 264);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(5);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(299, 45);
            this.lbPassword.TabIndex = 24;
            this.lbPassword.Text = "Mật khẩu không chính xác";
            this.lbPassword.Visible = false;
            // 
            // simbutClose
            // 
            this.simbutClose.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.simbutClose.Appearance.Options.UseFont = true;
            this.simbutClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simbutClose.ImageOptions.Image")));
            this.simbutClose.Location = new System.Drawing.Point(397, 330);
            this.simbutClose.Margin = new System.Windows.Forms.Padding(5);
            this.simbutClose.Name = "simbutClose";
            this.simbutClose.Size = new System.Drawing.Size(142, 45);
            this.simbutClose.TabIndex = 18;
            this.simbutClose.Text = "Close";
            this.simbutClose.Click += new System.EventHandler(this.simbutClose_Click);
            // 
            // simbutLogin
            // 
            this.simbutLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.simbutLogin.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simbutLogin.Appearance.Options.UseFont = true;
            this.simbutLogin.Appearance.Options.UseForeColor = true;
            this.simbutLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simbutLogin.ImageOptions.Image")));
            this.simbutLogin.Location = new System.Drawing.Point(194, 330);
            this.simbutLogin.Margin = new System.Windows.Forms.Padding(5);
            this.simbutLogin.Name = "simbutLogin";
            this.simbutLogin.Size = new System.Drawing.Size(142, 45);
            this.simbutLogin.TabIndex = 17;
            this.simbutLogin.Text = "Login";
            this.simbutLogin.Click += new System.EventHandler(this.simbutLogin_Click);
            // 
            // frmDangNhapAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 427);
            this.ControlBox = false;
            this.Controls.Add(this.btShowPass);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.labUsername);
            this.Controls.Add(this.labLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.simbutClose);
            this.Controls.Add(this.simbutLogin);
            this.Name = "frmDangNhapAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDangNhapAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btShowPass;
        private DevExpress.XtraEditors.LabelControl labPassword;
        private DevExpress.XtraEditors.LabelControl labUsername;
        private DevExpress.XtraEditors.LabelControl labLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SimpleButton lbPassword;
        private DevExpress.XtraEditors.SimpleButton lbUsername;
        private DevExpress.XtraEditors.SimpleButton simbutClose;
        private DevExpress.XtraEditors.SimpleButton simbutLogin;
    }
}