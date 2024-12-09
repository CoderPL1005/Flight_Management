namespace ADMIN
{
    partial class frmVedat
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
            this.dtVeDat = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.butCheckin = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAircraftSeatID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dtVeDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtVeDat
            // 
            this.dtVeDat.BackgroundColor = System.Drawing.Color.White;
            this.dtVeDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtVeDat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtVeDat.GridColor = System.Drawing.Color.Black;
            this.dtVeDat.Location = new System.Drawing.Point(0, 47);
            this.dtVeDat.Name = "dtVeDat";
            this.dtVeDat.RowHeadersWidth = 51;
            this.dtVeDat.RowTemplate.Height = 24;
            this.dtVeDat.Size = new System.Drawing.Size(1497, 149);
            this.dtVeDat.TabIndex = 24;
            this.dtVeDat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtVeDat_CellClick);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(888, 12);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(210, 23);
            this.txtTimKiem.TabIndex = 23;
            this.txtTimKiem.Text = "Tìm kiếm";
            this.txtTimKiem.Click += new System.EventHandler(this.txtTimKiem_Click);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Enabled = false;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(580, 111);
            this.cboTrangThai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(150, 24);
            this.cboTrangThai.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(486, 116);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 47;
            this.label9.Text = "Trạng thái";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.butCheckin);
            this.groupControl1.Controls.Add(this.cboTrangThai);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.txtAircraftSeatID);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtEmail);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 196);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1497, 320);
            this.groupControl1.TabIndex = 22;
            this.groupControl1.Text = "Thông tin";
            // 
            // butCheckin
            // 
            this.butCheckin.Enabled = false;
            this.butCheckin.Font = new System.Drawing.Font("Tahoma", 12F);
            this.butCheckin.Location = new System.Drawing.Point(891, 56);
            this.butCheckin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butCheckin.Name = "butCheckin";
            this.butCheckin.Size = new System.Drawing.Size(148, 86);
            this.butCheckin.TabIndex = 51;
            this.butCheckin.Text = "Checkin";
            this.butCheckin.UseVisualStyleBackColor = true;
            this.butCheckin.Click += new System.EventHandler(this.butCheckin_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(148, 52);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(82, 23);
            this.txtID.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 56);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 16);
            this.label7.TabIndex = 41;
            this.label7.Text = "ID";
            // 
            // txtAircraftSeatID
            // 
            this.txtAircraftSeatID.Location = new System.Drawing.Point(190, 108);
            this.txtAircraftSeatID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAircraftSeatID.Name = "txtAircraftSeatID";
            this.txtAircraftSeatID.ReadOnly = true;
            this.txtAircraftSeatID.Size = new System.Drawing.Size(225, 23);
            this.txtAircraftSeatID.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "AircraftSeatID";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(336, 50);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(469, 23);
            this.txtEmail.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Email";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1497, 47);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // frmVedat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 516);
            this.ControlBox = false;
            this.Controls.Add(this.dtVeDat);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmVedat";
            this.Load += new System.EventHandler(this.frmVedat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtVeDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtVeDat;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAircraftSeatID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button butCheckin;
    }
}