using BusinessLayer;
using DataLayer;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Filtering.Templates;
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
    public partial class frmFlight_Schedules : DevExpress.XtraEditors.XtraForm
    {
        string loaiquyen;
        public frmFlight_Schedules()
        {
            InitializeComponent();
        }
        public frmFlight_Schedules(string loaiquyen)
        {
            InitializeComponent();
            this.loaiquyen = loaiquyen;
        }
        FLIGHT_SCHEDULE _Flights;
        AIRPORT _Airports;
        AIRCRAFT _Aircrafts;
        bool _them;
        int _id;
        private void frmFlightSchedules_Load(object sender, EventArgs e)
        {
            _Flights = new FLIGHT_SCHEDULE();
            _Airports = new AIRPORT();
            _Aircrafts = new AIRCRAFT();
            loadData();
            showHideControl(true);
            _enabled(false);
            loadStatus();
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

        void loadStatus()
        {
            cboStatus.Items.Add("Open");
            cboStatus.Items.Add("Delayed");
            cboStatus.Items.Add("Cancelled");
            cboStatus.Items.Add("On Hold");
            cboStatus.Items.Add("Completed");
        }

        void loadData()
        {
            dtFlights.DataSource = _Flights.getAll().Select(a => new
            {
                a.FLIGHT_ID,
                a.ORIGIN_AIRPORT_ID,
                a.DESTINATION_AIRPORT_ID,
                a.FLIGHT_STATUS
            }).ToList();
            dtFlights.Columns["FLIGHT_ID"].HeaderText = "ID";
            dtFlights.Columns["FLIGHT_ID"].DisplayIndex = 0;
            dtFlights.Columns["FLIGHT_ID"].Width = 100;
            dtFlights.Columns["ORIGIN_AIRPORT_ID"].HeaderText = "ORIGIN_AIRPORT_ID";
            dtFlights.Columns["ORIGIN_AIRPORT_ID"].DisplayIndex = 1;
            dtFlights.Columns["ORIGIN_AIRPORT_ID"].Width = 300;
            dtFlights.Columns["DESTINATION_AIRPORT_ID"].HeaderText = "DESTINATION_AIRPORT_ID";
            dtFlights.Columns["DESTINATION_AIRPORT_ID"].DisplayIndex = 2;
            dtFlights.Columns["DESTINATION_AIRPORT_ID"].Width = 150;
            dtFlights.Columns["FLIGHT_STATUS"].HeaderText = "FLIGHT_STATUS";
            dtFlights.Columns["FLIGHT_STATUS"].DisplayIndex = 3;
            dtFlights.Columns["FLIGHT_STATUS"].Width = 150;

            cbOriginAiportID.Items.Clear();
            cbDetinationAiport.Items.Clear();
            List<tb_AIRPORTS> aiports = _Airports.getAll();
            foreach(var airportItem in aiports)
            {
                cbOriginAiportID.Items.Add(airportItem.AIPORT_NAME);
                cbDetinationAiport.Items.Add(airportItem.AIPORT_NAME);
            }
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
            cbOriginAiportID.Enabled = t;
            cbDetinationAiport.Enabled = t;
            cboStatus.Enabled = t;
        }
        void _reset()
        {
            cbOriginAiportID.Text = "";
            cbDetinationAiport.Text = "";
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
                _Flights.delete(_id);
            }
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(cbOriginAiportID.Text.Trim()) || string.IsNullOrEmpty(cbDetinationAiport.Text.Trim()) || string.IsNullOrEmpty(cboStatus.Text.Trim()))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else if(cbOriginAiportID.Text == cbDetinationAiport.Text)
            {
                MessageBox.Show("Origin Aiport không thể trùng Destination Aiport");
            }
            else
            {
                if (_them)
                {
                    tb_FLIGHT_SCHEDULES flights = new tb_FLIGHT_SCHEDULES();
                    flights.ORIGIN_AIRPORT_ID = _Airports.getIDAirport(cbOriginAiportID.Text);
                    flights.DESTINATION_AIRPORT_ID = _Airports.getIDAirport(cbDetinationAiport.Text);
                    flights.FLIGHT_STATUS = cboStatus.Text;
                    _Flights.add(flights);
                }
                else
                {
                    tb_FLIGHT_SCHEDULES flights = _Flights.getAllById(_id);
                    flights.ORIGIN_AIRPORT_ID = _Airports.getIDAirport(cbOriginAiportID.Text);
                    flights.DESTINATION_AIRPORT_ID = _Airports.getIDAirport(cbDetinationAiport.Text);
                    flights.FLIGHT_STATUS = cboStatus.Text;
                    _Flights.update(flights);
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

        private void dtFlights_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Chọn toàn bộ hàng
            dtFlights.Rows[e.RowIndex].Selected = true;
            int rowIndex = e.RowIndex; // Lấy chỉ số hàng của ô được click

            if (rowIndex >= 0)
            {

                // Lấy dữ liệu từ hàng được click
                DataGridViewRow selectedRow = dtFlights.Rows[rowIndex];

                string ID = selectedRow.Cells["FLIGHT_ID"].Value.ToString();
                string ORIGIN_AIRPORT_ID = selectedRow.Cells["ORIGIN_AIRPORT_ID"].Value.ToString();
                string DESTINATION_AIRPORT_ID = selectedRow.Cells["DESTINATION_AIRPORT_ID"].Value.ToString();
                string STATUS = selectedRow.Cells["FLIGHT_STATUS"].Value.ToString();

                _id = int.Parse(ID);
                txtID.Text = ID;
                cbOriginAiportID.Text = _Airports.getAirportName(int.Parse(ORIGIN_AIRPORT_ID));
                cbDetinationAiport.Text = _Airports.getAirportName(int.Parse(DESTINATION_AIRPORT_ID));
                cboStatus.Text = STATUS;
            }
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm")
            {
                txtTimKiem.Text = "";
            }
        }
    }
}