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
    public partial class frmAirports : DevExpress.XtraEditors.XtraForm
    {
        string loaiquyen;
        public frmAirports()
        {
            InitializeComponent();
        }
        public frmAirports(string loaiquyen)
        {
            InitializeComponent();
            this.loaiquyen = loaiquyen;
        }
        AIRPORT _airports;
        bool _them;
        int _id;
        private void frmAirports_Load(object sender, EventArgs e)
        {
            _airports = new AIRPORT();
            loadData();
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
            dtAirports.DataSource = _airports.getAll().Select(a => new
            {
                a.AIRPORT_ID,
                a.AIPORT_NAME,
                a.CITY,
                a.COUNTRY
            }).ToList();
            dtAirports.Columns["AIRPORT_ID"].HeaderText = "ID";
            dtAirports.Columns["AIRPORT_ID"].DisplayIndex = 0;
            dtAirports.Columns["AIRPORT_ID"].Width = 100;
            dtAirports.Columns["AIPORT_NAME"].HeaderText = "AIPORT_NAME";
            dtAirports.Columns["AIPORT_NAME"].DisplayIndex = 1;
            dtAirports.Columns["AIPORT_NAME"].Width = 300;
            dtAirports.Columns["CITY"].HeaderText = "CITY";
            dtAirports.Columns["CITY"].DisplayIndex = 2;
            dtAirports.Columns["CITY"].Width = 150;
            dtAirports.Columns["COUNTRY"].HeaderText = "COUNTRY";
            dtAirports.Columns["COUNTRY"].DisplayIndex = 3;
            dtAirports.Columns["COUNTRY"].Width = 250;
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
            txtName.Enabled = t;
            txtCity.Enabled = t;
            txtCountry.Enabled = t;
        }
        void _reset()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtCity.Text = "";
            txtCountry.Text = "";
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
                _airports.delete(_id);
            }
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()) || string.IsNullOrEmpty(txtCountry.Text.Trim()) || string.IsNullOrEmpty(txtCountry.Text.Trim()))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                if (_them)
                {
                    tb_AIRPORTS airports = new tb_AIRPORTS();
                    airports.AIPORT_NAME = txtName.Text;
                    airports.CITY = txtCity.Text;
                    airports.COUNTRY = txtCountry.Text;
                    _airports.add(airports);
                }
                else
                {
                    tb_AIRPORTS airccrafts = _airports.getAllById(_id);
                    airccrafts.AIPORT_NAME = txtName.Text;
                    airccrafts.CITY = txtCity.Text;
                    airccrafts.COUNTRY = txtCountry.Text;
                    _airports.update(airccrafts);
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

        private void dtAirports_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Chọn toàn bộ hàng
            dtAirports.Rows[e.RowIndex].Selected = true;
            int rowIndex = e.RowIndex; // Lấy chỉ số hàng của ô được click

            if (rowIndex >= 0)
            {

                // Lấy dữ liệu từ hàng được click
                DataGridViewRow selectedRow = dtAirports.Rows[rowIndex];

                string ID = selectedRow.Cells["AIRPORT_ID"].Value.ToString();
                string AIPORT_NAME = selectedRow.Cells["AIPORT_NAME"].Value.ToString();
                string CITY = selectedRow.Cells["CITY"].Value.ToString();
                string COUNTRY = selectedRow.Cells["COUNTRY"].Value.ToString();

                _id = int.Parse(ID);
                txtID.Text = ID;
                txtName.Text = AIPORT_NAME;
                txtCountry.Text = COUNTRY;
                txtCity.Text = CITY;
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