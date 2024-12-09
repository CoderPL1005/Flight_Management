using BusinessLayer;
using DataLayer;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMIN
{
    public partial class frmFlight : DevExpress.XtraEditors.XtraForm
    {
        string loaiquyen;
        public frmFlight()
        {
            InitializeComponent();
        }
        public frmFlight(string loaiquyen)
        {
            InitializeComponent();
            this.loaiquyen = loaiquyen;
        }
        FLlight _flight;
        FLIGHT_SCHEDULE _flight_schedule;
        AIRCRAFT _aircraft;
        AIRPORT _aiport;
        bool _them;
        int _id;
        private void frmFlight_Load(object sender, EventArgs e)
        {
            _flight = new FLlight();
            _flight_schedule = new FLIGHT_SCHEDULE();
            _aircraft = new AIRCRAFT();
            _aiport = new AIRPORT();
            loadData();
            LoadTuyenBay();
            loadMayBay();
            loadArrivialTime();
            loadDepatureTime();
            loadStatus();
            showHideControl(true);
            _enabled(false);
            txtID.Enabled = false;
            if (loaiquyen == "Chỉ xem")
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThoat.Enabled = true;
            }
            else
            {
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThoat.Enabled = true;
            }
        }
        void loadData()
        {
            dtFlight.DataSource = _flight.getAll().Select(a => new
            {
                a.ID_FLIGHT,
                a.FLIGHT_ID,
                a.AIRCRAFT_ID,
                a.ARRIVAL_TIME,
                a.DEPARTURE_TIME,
                a.DATE,
                a.FLIGHT_STATUS
            }).ToList();
            dtFlight.Columns["ID_FLIGHT"].HeaderText = "ID_FLIGHT";
            dtFlight.Columns["ID_FLIGHT"].DisplayIndex = 0;
            dtFlight.Columns["ID_FLIGHT"].Width = 100;
            dtFlight.Columns["FLIGHT_ID"].HeaderText = "ROUTE_ID";
            dtFlight.Columns["FLIGHT_ID"].DisplayIndex = 1;
            dtFlight.Columns["FLIGHT_ID"].Width = 100;
            dtFlight.Columns["AIRCRAFT_ID"].HeaderText = "AIRCRAFT_ID";
            dtFlight.Columns["AIRCRAFT_ID"].DisplayIndex = 2;
            dtFlight.Columns["AIRCRAFT_ID"].Width = 100;
            dtFlight.Columns["DEPARTURE_TIME"].HeaderText = "DEPARTURE_TIME";
            dtFlight.Columns["DEPARTURE_TIME"].DisplayIndex = 3;
            dtFlight.Columns["DEPARTURE_TIME"].Width = 150;
            dtFlight.Columns["ARRIVAL_TIME"].HeaderText = "ARRIVAL_TIME";
            dtFlight.Columns["ARRIVAL_TIME"].DisplayIndex = 4;
            dtFlight.Columns["ARRIVAL_TIME"].Width = 250;
            dtFlight.Columns["DATE"].HeaderText = "DATE";
            dtFlight.Columns["DATE"].DisplayIndex = 5;
            dtFlight.Columns["DATE"].Width = 75;
            dtFlight.Columns["FLIGHT_STATUS"].HeaderText = "FLIGHT_STATUS";
            dtFlight.Columns["FLIGHT_STATUS"].DisplayIndex = 5;
            dtFlight.Columns["FLIGHT_STATUS"].Width = 75;
        }

        void LoadTuyenBay()
        {
             dtTuyenBay.DataSource = _flight_schedule.getAll().Select(a => new
             {
                 a.FLIGHT_ID,
                 a.ORIGIN_AIRPORT_ID,
                 a.DESTINATION_AIRPORT_ID,
                 a.FLIGHT_STATUS
             }).ToList();
             dtTuyenBay.Columns["FLIGHT_ID"].HeaderText = "FLIGHT_ID";
             dtTuyenBay.Columns["FLIGHT_ID"].DisplayIndex = 0;
             dtTuyenBay.Columns["FLIGHT_ID"].Width = 100;
             dtTuyenBay.Columns["ORIGIN_AIRPORT_ID"].HeaderText = "ORIGIN_AIPORT_ID";
             dtTuyenBay.Columns["ORIGIN_AIRPORT_ID"].DisplayIndex = 1;
             dtTuyenBay.Columns["ORIGIN_AIRPORT_ID"].Width = 100;
             dtTuyenBay.Columns["DESTINATION_AIRPORT_ID"].HeaderText = "DESTINATION_AIRPORT_ID";
             dtTuyenBay.Columns["DESTINATION_AIRPORT_ID"].DisplayIndex = 2;
             dtTuyenBay.Columns["DESTINATION_AIRPORT_ID"].Width = 100;
             dtTuyenBay.Columns["FLIGHT_STATUS"].HeaderText = "FLIGHT_STATUS";
             dtTuyenBay.Columns["FLIGHT_STATUS"].DisplayIndex = 3;
             dtTuyenBay.Columns["FLIGHT_STATUS"].Width = 75;
        }
        void loadMayBay()
        {
            dtMayBay.DataSource = _aircraft.getAll().Select(a => new
            {
                a.AIRCRAFT_ID,
                a.MODEL,
                a.MANUFACTURER,
                a.CAPACITY
            }).ToList();
            dtMayBay.Columns["AIRCRAFT_ID"].HeaderText = "AIRCRAFT_ID";
            dtMayBay.Columns["AIRCRAFT_ID"].DisplayIndex = 0;
            dtMayBay.Columns["AIRCRAFT_ID"].Width = 100;
            dtMayBay.Columns["MODEL"].HeaderText = "MODEL";
            dtMayBay.Columns["MODEL"].DisplayIndex = 1;
            dtMayBay.Columns["MODEL"].Width = 100;
            dtMayBay.Columns["MANUFACTURER"].HeaderText = "MANUFACTURER";
            dtMayBay.Columns["MANUFACTURER"].DisplayIndex = 2;
            dtMayBay.Columns["MANUFACTURER"].Width = 100;
            dtMayBay.Columns["CAPACITY"].HeaderText = "CAPACITY";
            dtMayBay.Columns["CAPACITY"].DisplayIndex = 3;
            dtMayBay.Columns["CAPACITY"].Width = 75;
        }

        void loadDepatureTime()
        {
            for(int i = 0; i < 24; i++)
            {
                cboDepatureTimeHour.Items.Add(i);
            }
            for(int i = 0; i < 60; i++)
            {
                cboDepatureTimeMinute.Items.Add(i);
            }
            for(int i = 0; i< 60; i++)
            {
                cboDepatureTimeSecond.Items.Add(i);
            }
        }

        void loadArrivialTime()
        {
            for (int i = 0; i < 24; i++)
            {
                cboArrivalTimeHour.Items.Add(i);
            }
            for (int i = 0; i < 60; i++)
            {
                cboArrivalTimeMinute.Items.Add(i);
            }
            for (int i = 0; i < 60; i++)
            {
                cboArrivalTimeSecond.Items.Add(i);
            }
        }

        void loadStatus()
        {
            cboStatus.Items.Add("Open");
            cboStatus.Items.Add("Delayed");
            cboStatus.Items.Add("Cancelled");
            cboStatus.Items.Add("On Hold");
            cboStatus.Items.Add("Completed");
        }

        void showHideControl(bool t)
        {
            btnThem.Visible = t;
            btnSua.Visible = t;
            btnXoa.Visible = t;
            btnThoat.Visible = t;
            btnLuu.Visible = !t;
            btnBoQua.Visible = !t;
        }
        void _enabled(bool t)
        {
            txtTuyenBay.Enabled = t;
            txtMayBay.Enabled = t;
            datNgayBay.Enabled = t;
            cboDepatureTimeHour.Enabled = t;
            cboDepatureTimeMinute.Enabled = t;
            cboDepatureTimeSecond.Enabled = t;
            cboArrivalTimeHour.Enabled = t;
            cboArrivalTimeMinute.Enabled = t;
            cboArrivalTimeSecond.Enabled = t;
            cboStatus.Enabled = t;
            panel2.Enabled = t;
            panel3.Enabled = t;
        }

        void _reset()
        {
            txtTuyenBay.Text = "";
            txtMayBay.Text = "";
            datNgayBay.Text = DateTime.Now.ToString();
            cboDepatureTimeHour.Text = "00";
            cboDepatureTimeMinute.Text ="00";
            cboDepatureTimeSecond.Text = "00";
            cboArrivalTimeHour.Text = "00";
            cboArrivalTimeMinute.Text = "00";
            cboArrivalTimeSecond.Text = "00";
            cboStatus.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            showHideControl(false);
            _enabled(true);
            _reset();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _them = false;
            _enabled(true);
            showHideControl(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _flight.delete(_id);
            }
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMayBay.Text.Trim()) || string.IsNullOrEmpty(cboStatus.Text.Trim()) || string.IsNullOrEmpty(txtTuyenBay.Text.Trim()))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                if (_them)
                {
                    tb_FLIGHT flight = new tb_FLIGHT();
                    flight.FLIGHT_ID = int.Parse(txtTuyenBay.Text);
                    flight.AIRCRAFT_ID = int.Parse(txtMayBay.Text);
                    int Departurehour = int.Parse(cboDepatureTimeHour.Text.Trim());
                    int Depatureminute = int.Parse(cboDepatureTimeMinute.Text.Trim());
                    int Depaturesecond = int.Parse(cboDepatureTimeSecond.Text.Trim());
                    TimeSpan DepatureTime = new TimeSpan(Departurehour, Depatureminute, Depaturesecond);
                    flight.DEPARTURE_TIME = DepatureTime;
                    int ArrivialHour = int.Parse(cboArrivalTimeHour.Text.Trim());
                    int ArrivialMinute = int.Parse(cboArrivalTimeMinute.Text.Trim());
                    int ArrivialSecond = int.Parse(cboArrivalTimeSecond.Text.Trim());
                    TimeSpan ArrvialTime = new TimeSpan(ArrivialHour, ArrivialMinute, ArrivialSecond);
                    flight.ARRIVAL_TIME = ArrvialTime;
                    flight.DATE = datNgayBay.Value;
                    flight.FLIGHT_STATUS = cboStatus.Text;
                    _flight.add(flight);
                }
                else
                {
                    tb_FLIGHT flight = _flight.getAllById(_id);
                    flight.FLIGHT_ID = int.Parse(txtTuyenBay.Text);
                    flight.AIRCRAFT_ID = int.Parse(txtMayBay.Text);
                    int Departurehour = int.Parse(cboDepatureTimeHour.Text.Trim());
                    int Depatureminute = int.Parse(cboDepatureTimeMinute.Text.Trim());
                    int Depaturesecond = int.Parse(cboDepatureTimeSecond.Text.Trim());
                    TimeSpan DepatureTime = new TimeSpan(Departurehour, Depatureminute, Depaturesecond);
                    flight.DEPARTURE_TIME = DepatureTime;
                    int ArrivialHour = int.Parse(cboArrivalTimeHour.Text.Trim());
                    int ArrivialMinute = int.Parse(cboArrivalTimeMinute.Text.Trim());
                    int ArrivialSecond = int.Parse(cboArrivalTimeSecond.Text.Trim());
                    TimeSpan ArrvialTime = new TimeSpan(ArrivialHour, ArrivialMinute, ArrivialSecond);
                    flight.ARRIVAL_TIME = ArrvialTime;
                    flight.DATE = datNgayBay.Value;
                    flight.FLIGHT_STATUS = cboStatus.Text;
                    _flight.update(flight);
                }
                _them = false;
                _enabled(false);
                loadData();
                showHideControl(true);
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            _them = false;
            showHideControl(true);
            _enabled(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtFlight_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Chọn toàn bộ hàng
            dtFlight.Rows[e.RowIndex].Selected = true;
            int rowIndex = e.RowIndex; // Lấy chỉ số hàng của ô được click

            if (rowIndex >= 0)
            {

                // Lấy dữ liệu từ hàng được click
                DataGridViewRow selectedRow = dtFlight.Rows[rowIndex];

                string ID = selectedRow.Cells["ID_FLIGHT"].Value.ToString();
                string FLIGHT_ID = selectedRow.Cells["FLIGHT_ID"].Value.ToString();
                string AIRCRAFT_ID = selectedRow.Cells["AIRCRAFT_ID"].Value.ToString();
                TimeSpan DEPARTURE_TIME = TimeSpan.Parse(selectedRow.Cells["DEPARTURE_TIME"].Value.ToString());
                string DATE = selectedRow.Cells["DATE"].Value.ToString();
                TimeSpan ARRIVAL_TIME = TimeSpan.Parse(selectedRow.Cells["ARRIVAL_TIME"].Value.ToString());
                string FLIGHT_STATUS = selectedRow.Cells["FLIGHT_STATUS"].Value.ToString();

                _id = int.Parse(ID);
                txtTuyenBay.Text = ID;
                txtMayBay.Text = FLIGHT_ID;
                datNgayBay.Text = DATE;
                cboStatus.Text = FLIGHT_STATUS;
                cboDepatureTimeHour.Text = DEPARTURE_TIME.Hours.ToString();
                cboDepatureTimeMinute.Text = DEPARTURE_TIME.Minutes.ToString();
                cboDepatureTimeSecond.Text = DEPARTURE_TIME.Seconds.ToString();
                cboArrivalTimeHour.Text = ARRIVAL_TIME.Hours.ToString();
                cboArrivalTimeMinute.Text = ARRIVAL_TIME.Minutes.ToString();
                cboArrivalTimeSecond.Text = ARRIVAL_TIME.Seconds.ToString();
            }
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm")
            {
                txtTimKiem.Text = "";
            }
        }

        private void dtTuyenBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Chọn toàn bộ hàng
            dtTuyenBay.Rows[e.RowIndex].Selected = true;
            int rowIndex = e.RowIndex; // Lấy chỉ số hàng của ô được click

            if (rowIndex >= 0)
            {

                // Lấy dữ liệu từ hàng được click
                DataGridViewRow selectedRow = dtTuyenBay.Rows[rowIndex];

                string ID = selectedRow.Cells["FLIGHT_ID"].Value.ToString();
                string ORIGIN_AIRPORT_ID = selectedRow.Cells["ORIGIN_AIRPORT_ID"].Value.ToString();
                string DESTINATION_AIRPORT_ID = selectedRow.Cells["DESTINATION_AIRPORT_ID"].Value.ToString();
                string STATUS = selectedRow.Cells["FLIGHT_STATUS"].Value.ToString();

                txtIDTuyenBay.Text = ID;
                cbOriginAiportID.Text = _aiport.getAirportName(int.Parse(ORIGIN_AIRPORT_ID));
                cbDetinationAiport.Text = _aiport.getAirportName(int.Parse(DESTINATION_AIRPORT_ID));
                cboAiportStatus.Text = STATUS;
            }
        }

        private void dtMayBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Chọn toàn bộ hàng
            dtMayBay.Rows[e.RowIndex].Selected = true;
            int rowIndex = e.RowIndex; // Lấy chỉ số hàng của ô được click

            if (rowIndex >= 0)
            {

                // Lấy dữ liệu từ hàng được click
                DataGridViewRow selectedRow = dtMayBay.Rows[rowIndex];
                
                string ID = selectedRow.Cells["AIRCRAFT_ID"].Value.ToString();
                string MODEL = selectedRow.Cells["MODEL"].Value.ToString();
                string CAPACITY = selectedRow.Cells["CAPACITY"].Value.ToString();
                string MANUFACTURER = selectedRow.Cells["MANUFACTURER"].Value.ToString();

                txtIDMayBay.Text = ID;
                txtModel.Text = MODEL;
                txtCapacity.Text = CAPACITY;
                txtManufacturer.Text = MANUFACTURER;
            }
        }

        private void dtTuyenBay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Chọn toàn bộ hàng
            dtTuyenBay.Rows[e.RowIndex].Selected = true;
            int rowIndex = e.RowIndex; // Lấy chỉ số hàng của ô được click

            if (rowIndex >= 0)
            {

                // Lấy dữ liệu từ hàng được click
                DataGridViewRow selectedRow = dtTuyenBay.Rows[rowIndex];

                string ID = selectedRow.Cells["FLIGHT_ID"].Value.ToString();
                txtTuyenBay.Text = ID;
            }
        }

        private void dtMayBay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Chọn toàn bộ hàng
            dtMayBay.Rows[e.RowIndex].Selected = true;
            int rowIndex = e.RowIndex; // Lấy chỉ số hàng của ô được click

            if (rowIndex >= 0)
            {

                // Lấy dữ liệu từ hàng được click
                DataGridViewRow selectedRow = dtMayBay.Rows[rowIndex];

                string ID = selectedRow.Cells["AIRCRAFT_ID"].Value.ToString();
                txtMayBay.Text = ID;
            }
        }
    }
}