namespace FLIGHT
{
    partial class frmDangNhap
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
            this.lbWarning = new System.Windows.Forms.Label();
            this.lbDangNhap = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.Enabled = false;
            this.lbWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(157)))), ((int)(((byte)(75)))));
            this.lbWarning.Location = new System.Drawing.Point(501, 738);
            this.lbWarning.Margin = new System.Windows.Forms.Padding(0);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(0, 16);
            this.lbWarning.TabIndex = 188;
            this.lbWarning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDangNhap
            // 
            this.lbDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.lbDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDangNhap.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lbDangNhap.ForeColor = System.Drawing.Color.White;
            this.lbDangNhap.Location = new System.Drawing.Point(1034, 349);
            this.lbDangNhap.Name = "lbDangNhap";
            this.lbDangNhap.Size = new System.Drawing.Size(223, 130);
            this.lbDangNhap.TabIndex = 3;
            this.lbDangNhap.Text = "Đăng nhập";
            this.lbDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDangNhap.Click += new System.EventHandler(this.lbDangNhap_Click);
            // 
            // txtPassWord
            // 
            this.txtPassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassWord.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPassWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(166)))), ((int)(((byte)(175)))));
            this.txtPassWord.Location = new System.Drawing.Point(633, 445);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(352, 23);
            this.txtPassWord.TabIndex = 2;
            this.txtPassWord.Text = "Vui lòng nhập mật khẩu của quý khách";
            this.txtPassWord.Click += new System.EventHandler(this.txtPassWord_Click);
            this.txtPassWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassWord_KeyDown);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label4.Location = new System.Drawing.Point(613, 433);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(381, 46);
            this.label4.TabIndex = 185;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserId
            // 
            this.txtUserId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserId.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtUserId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(166)))), ((int)(((byte)(175)))));
            this.txtUserId.Location = new System.Drawing.Point(633, 361);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(0);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(352, 23);
            this.txtUserId.TabIndex = 1;
            this.txtUserId.Text = "Vui lòng nhập ID của quý khách";
            this.txtUserId.Click += new System.EventHandler(this.txtUserId_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Location = new System.Drawing.Point(613, 349);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 46);
            this.label3.TabIndex = 183;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(395, 286);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(1574, 23);
            this.separatorControl1.TabIndex = 182;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label2.Location = new System.Drawing.Point(847, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 51);
            this.label2.TabIndex = 181;
            this.label2.Text = "Đăng nhập";
            // 
            // frmDangNhap
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1062);
            this.ControlBox = false;
            this.Controls.Add(this.lbWarning);
            this.Controls.Add(this.lbDangNhap);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.label2);
            this.Name = "frmDangNhap";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWarning;
        private System.Windows.Forms.Label lbDangNhap;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.Label label2;
    }
}