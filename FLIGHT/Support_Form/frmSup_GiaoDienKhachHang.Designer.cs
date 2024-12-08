namespace FLIGHT.Support_Form
{
    partial class frmSup_GiaoDienKhachHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboLoaiGhe = new System.Windows.Forms.ComboBox();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.labHanhKhach = new System.Windows.Forms.Label();
            this.labDecrease = new System.Windows.Forms.Label();
            this.labIncrease = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khoang dịch vụ";
            // 
            // cboLoaiGhe
            // 
            this.cboLoaiGhe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiGhe.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cboLoaiGhe.FormattingEnabled = true;
            this.cboLoaiGhe.Location = new System.Drawing.Point(20, 61);
            this.cboLoaiGhe.Name = "cboLoaiGhe";
            this.cboLoaiGhe.Size = new System.Drawing.Size(240, 29);
            this.cboLoaiGhe.TabIndex = 1;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(2, 102);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(295, 23);
            this.separatorControl1.TabIndex = 2;
            // 
            // labHanhKhach
            // 
            this.labHanhKhach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labHanhKhach.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labHanhKhach.Location = new System.Drawing.Point(70, 130);
            this.labHanhKhach.Name = "labHanhKhach";
            this.labHanhKhach.Size = new System.Drawing.Size(140, 30);
            this.labHanhKhach.TabIndex = 3;
            this.labHanhKhach.Text = "1 hành khách";
            this.labHanhKhach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labDecrease
            // 
            this.labDecrease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labDecrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labDecrease.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labDecrease.Location = new System.Drawing.Point(20, 130);
            this.labDecrease.Name = "labDecrease";
            this.labDecrease.Size = new System.Drawing.Size(50, 30);
            this.labDecrease.TabIndex = 4;
            this.labDecrease.Text = "-";
            this.labDecrease.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labDecrease.Click += new System.EventHandler(this.labDecrease_Click);
            // 
            // labIncrease
            // 
            this.labIncrease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labIncrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labIncrease.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labIncrease.Location = new System.Drawing.Point(210, 130);
            this.labIncrease.Name = "labIncrease";
            this.labIncrease.Size = new System.Drawing.Size(50, 30);
            this.labIncrease.TabIndex = 5;
            this.labIncrease.Text = "+";
            this.labIncrease.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labIncrease.Click += new System.EventHandler(this.labIncrease_Click);
            // 
            // frmSup_GiaoDienKhachHang
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 186);
            this.ControlBox = false;
            this.Controls.Add(this.labIncrease);
            this.Controls.Add(this.labDecrease);
            this.Controls.Add(this.labHanhKhach);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.cboLoaiGhe);
            this.Controls.Add(this.label1);
            this.Name = "frmSup_GiaoDienKhachHang";
            this.Load += new System.EventHandler(this.frmSup_GiaoDienKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLoaiGhe;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.Label labHanhKhach;
        private System.Windows.Forms.Label labDecrease;
        private System.Windows.Forms.Label labIncrease;
    }
}