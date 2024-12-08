using BusinessLayer;
using DataLayer;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMIN
{
    public partial class frmAircraft : DevExpress.XtraEditors.XtraForm
    {
        string loaiquyen;
        public frmAircraft()
        {
            InitializeComponent();
        }
        public frmAircraft(string loaiquyen)
        {
            InitializeComponent();
            this.loaiquyen = loaiquyen;
        }
        AIRCRAFT _aircrafts;
        bool _them;
        int _id;
        private void frmAircraft_Load(object sender, EventArgs e)
        {
            _aircrafts = new AIRCRAFT();
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
            dtAircraft.DataSource = _aircrafts.getAll().Select(a => new
            {
                a.AIRCRAFT_ID,
                a.MODEL,
                a.CAPACITY,
                a.MANUFACTURER
            }).ToList();
            dtAircraft.Columns["AIRCRAFT_ID"].HeaderText = "ID";
            dtAircraft.Columns["AIRCRAFT_ID"].DisplayIndex = 0;
            dtAircraft.Columns["AIRCRAFT_ID"].Width = 100;
            dtAircraft.Columns["MODEL"].HeaderText = "MODEL";
            dtAircraft.Columns["MODEL"].DisplayIndex = 1;
            dtAircraft.Columns["MODEL"].Width = 300;
            dtAircraft.Columns["CAPACITY"].HeaderText = "CAPACITY";
            dtAircraft.Columns["CAPACITY"].DisplayIndex = 2;
            dtAircraft.Columns["CAPACITY"].Width = 150;
            dtAircraft.Columns["MANUFACTURER"].HeaderText = "MANUFACTURER";
            dtAircraft.Columns["MANUFACTURER"].DisplayIndex = 3;
            dtAircraft.Columns["MANUFACTURER"].Width = 250;
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
            txtModel.Enabled = t;
            txtManufacturer.Enabled = t;
            txtCapacity.Enabled = t;
        }
        void _reset()
        {
            txtID.Text = "";
            txtModel.Text = "";
            txtManufacturer.Text = "";
            txtCapacity.Text = "";
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
                _aircrafts.delete(_id);
            }
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtModel.Text.Trim()) || string.IsNullOrEmpty(txtCapacity.Text.Trim()) || string.IsNullOrEmpty(txtManufacturer.Text.Trim()))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                if (_them)
                {
                    tb_AIRCRAFT aircrafts = new tb_AIRCRAFT();
                    aircrafts.MODEL = txtModel.Text;
                    aircrafts.CAPACITY = int.Parse(txtCapacity.Text);
                    aircrafts.MANUFACTURER = txtManufacturer.Text;
                    _aircrafts.add(aircrafts);
                }
                else
                {
                    tb_AIRCRAFT airccrafts = _aircrafts.getAllById(_id);
                    airccrafts.MODEL = txtModel.Text;
                    airccrafts.CAPACITY = int.Parse(txtCapacity.Text);
                    airccrafts.MANUFACTURER = txtManufacturer.Text;
                    _aircrafts.update(airccrafts);
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

        private void dtAircraft_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Chọn toàn bộ hàng
            dtAircraft.Rows[e.RowIndex].Selected = true;
            int rowIndex = e.RowIndex; // Lấy chỉ số hàng của ô được click

            if (rowIndex >= 0)
            {

                // Lấy dữ liệu từ hàng được click
                DataGridViewRow selectedRow = dtAircraft.Rows[rowIndex];

                string ID = selectedRow.Cells["AIRCRAFT_ID"].Value.ToString();
                string MODEL = selectedRow.Cells["MODEL"].Value.ToString();
                string CAPACITY = selectedRow.Cells["CAPACITY"].Value.ToString();
                string MANUFACTURER = selectedRow.Cells["MANUFACTURER"].Value.ToString();

                _id = int.Parse(ID);
                txtID.Text = ID;
                txtModel.Text = MODEL;
                txtManufacturer.Text = MANUFACTURER;
                txtCapacity.Text = CAPACITY;
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