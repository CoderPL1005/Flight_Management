using ADMIN.Support_Form;
using BusinessLayer;
using DataLayer;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Senders;
using DevExpress.XtraReports.Design;
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
    public partial class frmAirCraftSeats : DevExpress.XtraEditors.XtraForm
    {
        string loaiquyen;
        public frmAirCraftSeats()
        {
            InitializeComponent();
        }
        public frmAirCraftSeats(string loaiquyen)
        {
            InitializeComponent();
            this.loaiquyen = loaiquyen;
        }
        SEATS _seat;
        AIRCRAFTSEATS _aircraftseat;
        AIRCRAFT _aircraft;
        bool _them;
        int _id;
        private void frmAirCraftSeats_Load(object sender, EventArgs e)
        {
            _seat = new SEATS();
            _aircraft = new AIRCRAFT();
            _aircraftseat = new AIRCRAFTSEATS();
            loadData();
            loadMayBay();
            loadLoaiGhe();
            showHideControl(true);
            _enabled(false);
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
            dtAircraftSeat.DataSource = _aircraftseat.getAll().Select(a => new
            {
                a.AIRCRAFTSEATSID,
                a.AIRCRAFT_ID,
                a.SEATS_ID,
                a.SEAT_NUMBER,
                a.PRICE
            }).ToList();
            dtAircraftSeat.Columns["AIRCRAFTSEATSID"].HeaderText = "AIRCRAFTSEATSID";
            dtAircraftSeat.Columns["AIRCRAFTSEATSID"].DisplayIndex = 0;
            dtAircraftSeat.Columns["AIRCRAFTSEATSID"].Width = 100;
            dtAircraftSeat.Columns["SEATS_ID"].HeaderText = "SEAT_ID";
            dtAircraftSeat.Columns["SEATS_ID"].DisplayIndex = 1;
            dtAircraftSeat.Columns["SEATS_ID"].Width = 100;
            dtAircraftSeat.Columns["AIRCRAFT_ID"].HeaderText = "AIRCRAFT_ID";
            dtAircraftSeat.Columns["AIRCRAFT_ID"].DisplayIndex = 1;
            dtAircraftSeat.Columns["AIRCRAFT_ID"].Width = 100;
            dtAircraftSeat.Columns["SEAT_NUMBER"].HeaderText = "SEAT_NUMBER";
            dtAircraftSeat.Columns["SEAT_NUMBER"].DisplayIndex = 2;
            dtAircraftSeat.Columns["SEAT_NUMBER"].Width = 150;
            dtAircraftSeat.Columns["PRICE"].HeaderText = "PRICE";
            dtAircraftSeat.Columns["PRICE"].DisplayIndex = 3;
            dtAircraftSeat.Columns["PRICE"].Width = 250;
        }

        void loadLoaiGhe()
        {
            int yLocation = 0;
            List<tb_SEATS> seatShow = _seat.getAll();
            for (int count = 1; count <= _seat.CountSeatTypeTotal(); count++)
            {
                frmSupport_AircraftSeats frmsup = new frmSupport_AircraftSeats();
                frmsup.TopLevel = false;
                frmsup.Width = panel1.Width;
                panel3.Controls.Add(frmsup);
                frmsup.Location = new Point(0, yLocation);
                yLocation += frmsup.Height + 10;
                foreach(Control control in frmsup.Controls)
                {
                    if(control is TextBox)
                    {
                        if(control.Name == "txtLoaiGhe")
                        {
                            control.Text = seatShow[count - 1].CLASS;
                        }
                        else if(control.Name == "txtSoGhe")
                        {
                            control.TextChanged += CheckSeatNumber;
                            control.Leave += DecreaseSeatTotal;
                        }
                    }
                }
                frmsup.Show();
            }
        }

        void DecreaseSeatTotal(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (textbox.Text != "")
            {
                int TotalSeatLeft = int.Parse(txtTongGhe.Text);
                TotalSeatLeft = int.Parse(txtTongGhe.Text) - int.Parse(textbox.Text);
                txtTongGhe.Text = TotalSeatLeft.ToString();
            }
        }

        void CheckSeatNumber(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (textbox.Text != "")
            {
                if (int.Parse(textbox.Text) > int.Parse(txtTongGhe.Text))
                {
                    MessageBox.Show("Số ghế không được vượt quá tổng số!");
                    textbox.Text = "";
                }
            }
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
            txtMayBay.Enabled = t;
            txtTongGhe.Enabled = t;
            panel2.Enabled = t;
        }

        void _reset()
        {
            txtMayBay.Text = "";
            txtTongGhe.Text = "";
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
                _aircraftseat.delete(_id);
            }
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMayBay.Text.Trim()) || string.IsNullOrEmpty(txtTongGhe.Text.Trim()))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                if (_them)
                {
                    tb_AIRCRAFTSEATS aircraftseat = new tb_AIRCRAFTSEATS();
                    aircraftseat.AIRCRAFT_ID = int.Parse(txtMayBay.Text);
                    foreach(Control control in panel3.Controls)
                    {
                        int tmp = 0;
                        string ClassSeat = "";
                        if(control is frmSupport_AircraftSeats)
                        {
                            foreach(Control textbox in control.Controls)
                            {
                                if(textbox.Name == "txtSoGhe")
                                {
                                    tmp = int.Parse(textbox.Text);
                                }
                                else if(textbox.Name == "txtLoaiGhe")
                                {
                                    aircraftseat.SEATS_ID = _seat.getIDByClass(textbox.Text);
                                    ClassSeat = textbox.Text;
                                }
                                else if(textbox.Name == "txtPrice")
                                {
                                    aircraftseat.PRICE = int.Parse(textbox.Text);
                                }
                            }
                        }
                        for(int i =0; i<tmp; i++)
                        {
                            aircraftseat.SEAT_NUMBER = _aircraftseat.GetNewSeatNumber(ClassSeat);
                            _aircraftseat.add(aircraftseat);
                        }   
                    }
                }
                else
                {
                    tb_AIRCRAFTSEATS aircraftseat = _aircraftseat.getAllById(_id);
                    aircraftseat.AIRCRAFT_ID = int.Parse(txtMayBay.Text);
                    _aircraftseat.update(aircraftseat);
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

        private void dtAircraftSeat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Chọn toàn bộ hàng
            dtAircraftSeat.Rows[e.RowIndex].Selected = true;
            int rowIndex = e.RowIndex; // Lấy chỉ số hàng của ô được click

            if (rowIndex >= 0)
            {

                // Lấy dữ liệu từ hàng được click
                DataGridViewRow selectedRow = dtAircraftSeat.Rows[rowIndex];

                string ID = selectedRow.Cells["AIRCRAFTSEATSID"].Value.ToString();
                string SEATS_ID = selectedRow.Cells["SEATS_ID"].Value.ToString();
                string AIRCRAFT_ID = selectedRow.Cells["AIRCRAFT_ID"].Value.ToString();
                string PRICE = selectedRow.Cells["PRICE"].Value.ToString();
                string SEAT_NUMBER = selectedRow.Cells["SEAT_NUMBER"].Value.ToString();

                _id = int.Parse(ID);
                txtMayBay.Text = AIRCRAFT_ID;
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
                string CAPACITY = selectedRow.Cells["CAPACITY"].Value.ToString();

                txtMayBay.Text = ID;
                txtTongGhe.Text = CAPACITY;
            }
        }
    }
}