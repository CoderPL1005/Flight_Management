namespace FLIGHT.Support_Form
{
    partial class frmSup_VeDat
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
            this.txtIDVe = new System.Windows.Forms.TextBox();
            this.txtAicraftId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArrivalTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDepatureTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.butHuy = new System.Windows.Forms.Button();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtGia1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Vé";
            // 
            // txtIDVe
            // 
            this.txtIDVe.Location = new System.Drawing.Point(139, 21);
            this.txtIDVe.Name = "txtIDVe";
            this.txtIDVe.Size = new System.Drawing.Size(268, 23);
            this.txtIDVe.TabIndex = 1;
            // 
            // txtAicraftId
            // 
            this.txtAicraftId.Location = new System.Drawing.Point(139, 62);
            this.txtAicraftId.Name = "txtAicraftId";
            this.txtAicraftId.Size = new System.Drawing.Size(268, 23);
            this.txtAicraftId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "AirCraft ID";
            // 
            // txtArrivalTime
            // 
            this.txtArrivalTime.Location = new System.Drawing.Point(139, 187);
            this.txtArrivalTime.Name = "txtArrivalTime";
            this.txtArrivalTime.Size = new System.Drawing.Size(268, 23);
            this.txtArrivalTime.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Arrival Time";
            // 
            // txtDepatureTime
            // 
            this.txtDepatureTime.Location = new System.Drawing.Point(139, 142);
            this.txtDepatureTime.Name = "txtDepatureTime";
            this.txtDepatureTime.Size = new System.Drawing.Size(268, 23);
            this.txtDepatureTime.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Depature Time";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(139, 107);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(268, 23);
            this.txtDate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date";
            // 
            // butHuy
            // 
            this.butHuy.Font = new System.Drawing.Font("Tahoma", 10F);
            this.butHuy.Location = new System.Drawing.Point(293, 262);
            this.butHuy.Name = "butHuy";
            this.butHuy.Size = new System.Drawing.Size(114, 60);
            this.butHuy.TabIndex = 10;
            this.butHuy.Text = "Hủy";
            this.butHuy.UseVisualStyleBackColor = true;
            this.butHuy.Click += new System.EventHandler(this.butHuy_Click);
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(139, 233);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(268, 23);
            this.txtGia.TabIndex = 12;
            // 
            // txtGia1
            // 
            this.txtGia1.AutoSize = true;
            this.txtGia1.Location = new System.Drawing.Point(25, 233);
            this.txtGia1.Name = "txtGia1";
            this.txtGia1.Size = new System.Drawing.Size(25, 16);
            this.txtGia1.TabIndex = 11;
            this.txtGia1.Text = "Giá";
            // 
            // frmSup_VeDat
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 323);
            this.ControlBox = false;
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtGia1);
            this.Controls.Add(this.butHuy);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDepatureTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtArrivalTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAicraftId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDVe);
            this.Controls.Add(this.label1);
            this.Name = "frmSup_VeDat";
            this.Load += new System.EventHandler(this.frmSup_VeDat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDVe;
        private System.Windows.Forms.TextBox txtAicraftId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArrivalTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDepatureTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button butHuy;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label txtGia1;
    }
}