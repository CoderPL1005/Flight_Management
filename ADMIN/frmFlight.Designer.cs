namespace ADMIN
{
    partial class frmFlight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFlight));
            this.dtFlight = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.datNgayBay = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboArrivalTimeSecond = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboArrivalTimeMinute = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboArrivalTimeHour = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboDepatureTimeSecond = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboDepatureTimeMinute = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboDepatureTimeHour = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTuyenBay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMayBay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtMayBay = new System.Windows.Forms.DataGridView();
            this.panMayBay = new System.Windows.Forms.Panel();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtIDMayBay = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panTuyenBay = new System.Windows.Forms.Panel();
            this.cboAiportStatus = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbDetinationAiport = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbOriginAiportID = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtIDTuyenBay = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtTuyenBay = new System.Windows.Forms.DataGridView();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBoQua = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtFlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtMayBay)).BeginInit();
            this.panMayBay.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panTuyenBay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTuyenBay)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtFlight
            // 
            this.dtFlight.BackgroundColor = System.Drawing.Color.White;
            this.dtFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtFlight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtFlight.GridColor = System.Drawing.Color.Black;
            this.dtFlight.Location = new System.Drawing.Point(0, 47);
            this.dtFlight.Name = "dtFlight";
            this.dtFlight.RowHeadersWidth = 51;
            this.dtFlight.RowTemplate.Height = 24;
            this.dtFlight.Size = new System.Drawing.Size(1411, 449);
            this.dtFlight.TabIndex = 24;
            this.dtFlight.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtFlight_CellClick);
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
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.panel1);
            this.groupControl1.Controls.Add(this.panel3);
            this.groupControl1.Controls.Add(this.panel2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 496);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1411, 566);
            this.groupControl1.TabIndex = 22;
            this.groupControl1.Text = "Thông tin";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboStatus);
            this.panel1.Controls.Add(this.datNgayBay);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cboArrivalTimeSecond);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cboArrivalTimeMinute);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cboArrivalTimeHour);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cboDepatureTimeSecond);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cboDepatureTimeMinute);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cboDepatureTimeHour);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTuyenBay);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtMayBay);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(343, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 536);
            this.panel1.TabIndex = 31;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(105, 33);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(218, 23);
            this.txtID.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 69;
            this.label2.Text = "ID chuyến bay";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(84, 275);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(146, 24);
            this.cboStatus.TabIndex = 68;
            // 
            // datNgayBay
            // 
            this.datNgayBay.Location = new System.Drawing.Point(105, 133);
            this.datNgayBay.Name = "datNgayBay";
            this.datNgayBay.Size = new System.Drawing.Size(200, 23);
            this.datNgayBay.TabIndex = 66;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 280);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 16);
            this.label13.TabIndex = 67;
            this.label13.Text = "STATUS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(400, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 65;
            this.label9.Text = "Second";
            // 
            // cboArrivalTimeSecond
            // 
            this.cboArrivalTimeSecond.FormattingEnabled = true;
            this.cboArrivalTimeSecond.Location = new System.Drawing.Point(345, 227);
            this.cboArrivalTimeSecond.Name = "cboArrivalTimeSecond";
            this.cboArrivalTimeSecond.Size = new System.Drawing.Size(49, 24);
            this.cboArrivalTimeSecond.TabIndex = 64;
            this.cboArrivalTimeSecond.Text = "00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(294, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 16);
            this.label10.TabIndex = 63;
            this.label10.Text = "Minute";
            // 
            // cboArrivalTimeMinute
            // 
            this.cboArrivalTimeMinute.FormattingEnabled = true;
            this.cboArrivalTimeMinute.Location = new System.Drawing.Point(239, 227);
            this.cboArrivalTimeMinute.Name = "cboArrivalTimeMinute";
            this.cboArrivalTimeMinute.Size = new System.Drawing.Size(49, 24);
            this.cboArrivalTimeMinute.TabIndex = 62;
            this.cboArrivalTimeMinute.Text = "00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(199, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 16);
            this.label11.TabIndex = 61;
            this.label11.Text = "Hour";
            // 
            // cboArrivalTimeHour
            // 
            this.cboArrivalTimeHour.FormattingEnabled = true;
            this.cboArrivalTimeHour.Location = new System.Drawing.Point(144, 227);
            this.cboArrivalTimeHour.Name = "cboArrivalTimeHour";
            this.cboArrivalTimeHour.Size = new System.Drawing.Size(49, 24);
            this.cboArrivalTimeHour.TabIndex = 60;
            this.cboArrivalTimeHour.Text = "00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 16);
            this.label12.TabIndex = 59;
            this.label12.Text = "ARRIVAL TIME";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(400, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 58;
            this.label8.Text = "Second";
            // 
            // cboDepatureTimeSecond
            // 
            this.cboDepatureTimeSecond.FormattingEnabled = true;
            this.cboDepatureTimeSecond.Location = new System.Drawing.Point(345, 173);
            this.cboDepatureTimeSecond.Name = "cboDepatureTimeSecond";
            this.cboDepatureTimeSecond.Size = new System.Drawing.Size(49, 24);
            this.cboDepatureTimeSecond.TabIndex = 57;
            this.cboDepatureTimeSecond.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 56;
            this.label6.Text = "Minute";
            // 
            // cboDepatureTimeMinute
            // 
            this.cboDepatureTimeMinute.FormattingEnabled = true;
            this.cboDepatureTimeMinute.Location = new System.Drawing.Point(239, 173);
            this.cboDepatureTimeMinute.Name = "cboDepatureTimeMinute";
            this.cboDepatureTimeMinute.Size = new System.Drawing.Size(49, 24);
            this.cboDepatureTimeMinute.TabIndex = 55;
            this.cboDepatureTimeMinute.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 54;
            this.label5.Text = "Hour";
            // 
            // cboDepatureTimeHour
            // 
            this.cboDepatureTimeHour.FormattingEnabled = true;
            this.cboDepatureTimeHour.Location = new System.Drawing.Point(144, 173);
            this.cboDepatureTimeHour.Name = "cboDepatureTimeHour";
            this.cboDepatureTimeHour.Size = new System.Drawing.Size(49, 24);
            this.cboDepatureTimeHour.TabIndex = 53;
            this.cboDepatureTimeHour.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 52;
            this.label4.Text = "DEPARTURE TIME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "DATE";
            // 
            // txtTuyenBay
            // 
            this.txtTuyenBay.Location = new System.Drawing.Point(105, 82);
            this.txtTuyenBay.Name = "txtTuyenBay";
            this.txtTuyenBay.Size = new System.Drawing.Size(218, 23);
            this.txtTuyenBay.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 45;
            this.label7.Text = "Tuyến bay";
            // 
            // txtMayBay
            // 
            this.txtMayBay.Location = new System.Drawing.Point(403, 82);
            this.txtMayBay.Name = "txtMayBay";
            this.txtMayBay.Size = new System.Drawing.Size(218, 23);
            this.txtMayBay.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Máy bay";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtMayBay);
            this.panel3.Controls.Add(this.panMayBay);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(982, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(427, 536);
            this.panel3.TabIndex = 29;
            // 
            // dtMayBay
            // 
            this.dtMayBay.BackgroundColor = System.Drawing.Color.White;
            this.dtMayBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMayBay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtMayBay.GridColor = System.Drawing.Color.Black;
            this.dtMayBay.Location = new System.Drawing.Point(0, 0);
            this.dtMayBay.MultiSelect = false;
            this.dtMayBay.Name = "dtMayBay";
            this.dtMayBay.RowHeadersWidth = 51;
            this.dtMayBay.RowTemplate.Height = 24;
            this.dtMayBay.Size = new System.Drawing.Size(427, 291);
            this.dtMayBay.TabIndex = 1;
            this.dtMayBay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtMayBay_CellClick);
            this.dtMayBay.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtMayBay_CellDoubleClick);
            // 
            // panMayBay
            // 
            this.panMayBay.Controls.Add(this.txtManufacturer);
            this.panMayBay.Controls.Add(this.label21);
            this.panMayBay.Controls.Add(this.txtCapacity);
            this.panMayBay.Controls.Add(this.label20);
            this.panMayBay.Controls.Add(this.txtModel);
            this.panMayBay.Controls.Add(this.label19);
            this.panMayBay.Controls.Add(this.txtIDMayBay);
            this.panMayBay.Controls.Add(this.label18);
            this.panMayBay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panMayBay.Location = new System.Drawing.Point(0, 291);
            this.panMayBay.Name = "panMayBay";
            this.panMayBay.Size = new System.Drawing.Size(427, 245);
            this.panMayBay.TabIndex = 0;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(92, 151);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(189, 23);
            this.txtManufacturer.TabIndex = 31;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 154);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(83, 16);
            this.label21.TabIndex = 30;
            this.label21.Text = "Manufacturer";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(92, 110);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(181, 23);
            this.txtCapacity.TabIndex = 29;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(25, 114);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 16);
            this.label20.TabIndex = 28;
            this.label20.Text = "Capacity";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(92, 64);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(294, 23);
            this.txtModel.TabIndex = 27;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(45, 67);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 16);
            this.label19.TabIndex = 26;
            this.label19.Text = "Model";
            // 
            // txtIDMayBay
            // 
            this.txtIDMayBay.Enabled = false;
            this.txtIDMayBay.Location = new System.Drawing.Point(92, 21);
            this.txtIDMayBay.Name = "txtIDMayBay";
            this.txtIDMayBay.Size = new System.Drawing.Size(81, 23);
            this.txtIDMayBay.TabIndex = 25;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(67, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 16);
            this.label18.TabIndex = 24;
            this.label18.Text = "ID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panTuyenBay);
            this.panel2.Controls.Add(this.dtTuyenBay);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(2, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 536);
            this.panel2.TabIndex = 28;
            // 
            // panTuyenBay
            // 
            this.panTuyenBay.Controls.Add(this.cboAiportStatus);
            this.panTuyenBay.Controls.Add(this.label16);
            this.panTuyenBay.Controls.Add(this.cbDetinationAiport);
            this.panTuyenBay.Controls.Add(this.label14);
            this.panTuyenBay.Controls.Add(this.cbOriginAiportID);
            this.panTuyenBay.Controls.Add(this.label15);
            this.panTuyenBay.Controls.Add(this.comboBox1);
            this.panTuyenBay.Controls.Add(this.txtIDTuyenBay);
            this.panTuyenBay.Controls.Add(this.label17);
            this.panTuyenBay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panTuyenBay.Location = new System.Drawing.Point(0, 291);
            this.panTuyenBay.Name = "panTuyenBay";
            this.panTuyenBay.Size = new System.Drawing.Size(341, 245);
            this.panTuyenBay.TabIndex = 1;
            // 
            // cboAiportStatus
            // 
            this.cboAiportStatus.FormattingEnabled = true;
            this.cboAiportStatus.Location = new System.Drawing.Point(158, 153);
            this.cboAiportStatus.Name = "cboAiportStatus";
            this.cboAiportStatus.Size = new System.Drawing.Size(146, 24);
            this.cboAiportStatus.TabIndex = 84;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(97, 158);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 16);
            this.label16.TabIndex = 83;
            this.label16.Text = "STATUS";
            // 
            // cbDetinationAiport
            // 
            this.cbDetinationAiport.FormattingEnabled = true;
            this.cbDetinationAiport.Items.AddRange(new object[] {
            "1, 2",
            "2, 3"});
            this.cbDetinationAiport.Location = new System.Drawing.Point(158, 114);
            this.cbDetinationAiport.Name = "cbDetinationAiport";
            this.cbDetinationAiport.Size = new System.Drawing.Size(171, 24);
            this.cbDetinationAiport.TabIndex = 82;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 16);
            this.label14.TabIndex = 81;
            this.label14.Text = "DESTINATION AIRPORT";
            // 
            // cbOriginAiportID
            // 
            this.cbOriginAiportID.FormattingEnabled = true;
            this.cbOriginAiportID.Items.AddRange(new object[] {
            "1, 2",
            "2, 3"});
            this.cbOriginAiportID.Location = new System.Drawing.Point(158, 63);
            this.cbOriginAiportID.Name = "cbOriginAiportID";
            this.cbOriginAiportID.Size = new System.Drawing.Size(171, 24);
            this.cbOriginAiportID.TabIndex = 80;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(48, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 16);
            this.label15.TabIndex = 79;
            this.label15.Text = "ORIGIN AIRPORT";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(589, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 24);
            this.comboBox1.TabIndex = 78;
            // 
            // txtIDTuyenBay
            // 
            this.txtIDTuyenBay.Enabled = false;
            this.txtIDTuyenBay.Location = new System.Drawing.Point(158, 18);
            this.txtIDTuyenBay.Name = "txtIDTuyenBay";
            this.txtIDTuyenBay.Size = new System.Drawing.Size(81, 23);
            this.txtIDTuyenBay.TabIndex = 72;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(133, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 16);
            this.label17.TabIndex = 71;
            this.label17.Text = "ID";
            // 
            // dtTuyenBay
            // 
            this.dtTuyenBay.BackgroundColor = System.Drawing.Color.White;
            this.dtTuyenBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTuyenBay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtTuyenBay.GridColor = System.Drawing.Color.Black;
            this.dtTuyenBay.Location = new System.Drawing.Point(0, 0);
            this.dtTuyenBay.MultiSelect = false;
            this.dtTuyenBay.Name = "dtTuyenBay";
            this.dtTuyenBay.RowHeadersWidth = 51;
            this.dtTuyenBay.RowTemplate.Height = 24;
            this.dtTuyenBay.Size = new System.Drawing.Size(341, 536);
            this.dtTuyenBay.TabIndex = 0;
            this.dtTuyenBay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtTuyenBay_CellClick);
            this.dtTuyenBay.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtTuyenBay_CellDoubleClick);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(0, 1, 500, 2);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 44);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // btnThoat
            // 
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(51, 44);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.toolStripSeparator1,
            this.btnSua,
            this.toolStripSeparator2,
            this.btnXoa,
            this.toolStripSeparator3,
            this.btnLuu,
            this.toolStripSeparator4,
            this.btnBoQua,
            this.toolStripSeparator5,
            this.btnThoat,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1411, 47);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.Image = global::ADMIN.Properties.Resources._3669292_playlist_add_ic_icon;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(50, 44);
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(38, 44);
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(39, 44);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 47);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(37, 44);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLuu.Visible = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 47);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Image = ((System.Drawing.Image)(resources.GetObject("btnBoQua.Image")));
            this.btnBoQua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(60, 44);
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBoQua.Visible = false;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // frmFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 1062);
            this.ControlBox = false;
            this.Controls.Add(this.dtFlight);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmFlight";
            this.Load += new System.EventHandler(this.frmFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtFlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtMayBay)).EndInit();
            this.panMayBay.ResumeLayout(false);
            this.panMayBay.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panTuyenBay.ResumeLayout(false);
            this.panTuyenBay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTuyenBay)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtFlight;
        private System.Windows.Forms.TextBox txtTimKiem;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnBoQua;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panTuyenBay;
        private System.Windows.Forms.DataGridView dtTuyenBay;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panMayBay;
        private System.Windows.Forms.DataGridView dtMayBay;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtIDTuyenBay;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbDetinationAiport;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbOriginAiportID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboAiportStatus;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtIDMayBay;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.DateTimePicker datNgayBay;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboArrivalTimeSecond;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboArrivalTimeMinute;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboArrivalTimeHour;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboDepatureTimeSecond;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboDepatureTimeMinute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboDepatureTimeHour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTuyenBay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMayBay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label label21;
    }
}