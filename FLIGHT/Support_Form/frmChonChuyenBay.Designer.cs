namespace FLIGHT.Support_Form
{
    partial class frmChonChuyenBay
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
            this.label2 = new System.Windows.Forms.Label();
            this.butChonViTri = new System.Windows.Forms.Button();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLoaiGhe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtArrivial_Time = new System.Windows.Forms.TextBox();
            this.txtDeparture_time = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(27, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian xuất phát";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(214, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời gian đến nơi dự kiến";
            // 
            // butChonViTri
            // 
            this.butChonViTri.Font = new System.Drawing.Font("Tahoma", 10F);
            this.butChonViTri.Location = new System.Drawing.Point(589, 202);
            this.butChonViTri.Name = "butChonViTri";
            this.butChonViTri.Size = new System.Drawing.Size(104, 36);
            this.butChonViTri.TabIndex = 21;
            this.butChonViTri.Text = "Đặt ngay";
            this.butChonViTri.UseVisualStyleBackColor = true;
            this.butChonViTri.Click += new System.EventHandler(this.butChonViTri_Click);
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(646, 146);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(137, 23);
            this.txtGia.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(499, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Giá";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(646, 94);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(137, 23);
            this.txtSoLuong.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(499, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Số lượng còn lại";
            // 
            // txtLoaiGhe
            // 
            this.txtLoaiGhe.Location = new System.Drawing.Point(646, 44);
            this.txtLoaiGhe.Name = "txtLoaiGhe";
            this.txtLoaiGhe.Size = new System.Drawing.Size(137, 23);
            this.txtLoaiGhe.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(499, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Loại ghế";
            // 
            // txtArrivial_Time
            // 
            this.txtArrivial_Time.Location = new System.Drawing.Point(31, 121);
            this.txtArrivial_Time.Name = "txtArrivial_Time";
            this.txtArrivial_Time.Size = new System.Drawing.Size(164, 23);
            this.txtArrivial_Time.TabIndex = 22;
            // 
            // txtDeparture_time
            // 
            this.txtDeparture_time.Location = new System.Drawing.Point(229, 121);
            this.txtDeparture_time.Name = "txtDeparture_time";
            this.txtDeparture_time.Size = new System.Drawing.Size(182, 23);
            this.txtDeparture_time.TabIndex = 23;
            // 
            // frmChonChuyenBay
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 289);
            this.ControlBox = false;
            this.Controls.Add(this.txtDeparture_time);
            this.Controls.Add(this.txtArrivial_Time);
            this.Controls.Add(this.butChonViTri);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLoaiGhe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmChonChuyenBay";
            this.Load += new System.EventHandler(this.frmChonChuyenBay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butChonViTri;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLoaiGhe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtArrivial_Time;
        private System.Windows.Forms.TextBox txtDeparture_time;
    }
}