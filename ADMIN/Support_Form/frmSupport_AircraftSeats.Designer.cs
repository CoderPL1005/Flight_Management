namespace ADMIN.Support_Form
{
    partial class frmSupport_AircraftSeats
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
            this.txtSoGhe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoaiGhe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSoGhe
            // 
            this.txtSoGhe.Location = new System.Drawing.Point(411, 79);
            this.txtSoGhe.Name = "txtSoGhe";
            this.txtSoGhe.Size = new System.Drawing.Size(116, 23);
            this.txtSoGhe.TabIndex = 80;
            this.txtSoGhe.TextChanged += new System.EventHandler(this.txtSoGhe_TextChanged);
            this.txtSoGhe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoGhe_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 79;
            this.label4.Text = "Số ghế";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(83, 79);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(237, 23);
            this.txtPrice.TabIndex = 78;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 77;
            this.label3.Text = "Giá ghế";
            // 
            // txtLoaiGhe
            // 
            this.txtLoaiGhe.Enabled = false;
            this.txtLoaiGhe.Location = new System.Drawing.Point(83, 23);
            this.txtLoaiGhe.Name = "txtLoaiGhe";
            this.txtLoaiGhe.Size = new System.Drawing.Size(444, 23);
            this.txtLoaiGhe.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 75;
            this.label1.Text = "Loại ghế";
            // 
            // frmSupport_AircraftSeats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 120);
            this.ControlBox = false;
            this.Controls.Add(this.txtSoGhe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLoaiGhe);
            this.Controls.Add(this.label1);
            this.Name = "frmSupport_AircraftSeats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoGhe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLoaiGhe;
        private System.Windows.Forms.Label label1;
    }
}