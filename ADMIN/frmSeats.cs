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
    public partial class frmSeats : DevExpress.XtraEditors.XtraForm
    {
        string loaiquyen;
        public frmSeats()
        {
            InitializeComponent();
        }
        public frmSeats(string loaiquyen)
        {
            InitializeComponent();
            this.loaiquyen = loaiquyen;
        }
        SEATS _seat;
        bool _them;
        int _id;
        private void frmSeats_Load(object sender, EventArgs e)
        {
            _seat = new SEATS();
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
            dtSeat.DataSource = _seat.getAll().Select(a => new
            {
                a.SEAT_ID,
                a.CLASS
            }).ToList();
            dtSeat.Columns["SEAT_ID"].HeaderText = "SEAT_ID";
            dtSeat.Columns["SEAT_ID"].DisplayIndex = 0;
            dtSeat.Columns["SEAT_ID"].Width = 100;
            dtSeat.Columns["CLASS"].HeaderText = "ROUTE_ID";
            dtSeat.Columns["CLASS"].DisplayIndex = 1;
            dtSeat.Columns["CLASS"].Width = 100;
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
            txtClass.Enabled = t;
        }

        void _reset()
        {
            txtID.Text = "";
            txtClass.Text = "";
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
                _seat.delete(_id);
            }
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClass.Text.Trim())){ 
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                if (_them)
                {
                    tb_SEATS seat = new tb_SEATS();
                    seat.CLASS = txtClass.Text;
                    _seat.add(seat);
                }
                else
                {
                    tb_SEATS seat = _seat.getAllById(_id);
                    seat.CLASS = txtClass.Text;
                    _seat.update(seat);
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

        private void dtSeat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Chọn toàn bộ hàng
            dtSeat.Rows[e.RowIndex].Selected = true;
            int rowIndex = e.RowIndex; // Lấy chỉ số hàng của ô được click

            if (rowIndex >= 0)
            {

                // Lấy dữ liệu từ hàng được click
                DataGridViewRow selectedRow = dtSeat.Rows[rowIndex];

                string ID = selectedRow.Cells["SEAT_ID"].Value.ToString();
                string CLASS = selectedRow.Cells["CLASS"].Value.ToString();

                _id = int.Parse(ID);
                txtID.Text = ID;
                txtClass.Text = CLASS;
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