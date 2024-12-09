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
    public partial class frmVedat : DevExpress.XtraEditors.XtraForm
    {
        string loaiquyen;
        public frmVedat()
        {
            InitializeComponent();
        }
        public frmVedat(string loaiquyen)
        {
            InitializeComponent();
            this.loaiquyen = loaiquyen;
        }
        VEDAT _vedat;
        bool _them;
        int _id;
        private void frmVedat_Load(object sender, EventArgs e)
        {
            _vedat = new VEDAT();
            loadData();
            txtID.Enabled = false;
        }
        void loadData()
        {
            dtVeDat.DataSource = _vedat.getAll().Select(a => new
            {
                a.IDVEDAT,
                a.AIRCRAFTSEATISD,
                a.EMAIL,
                a.TRANGTHAI
            }).ToList();
            dtVeDat.Columns["IDVEDAT"].HeaderText = "ID";
            dtVeDat.Columns["IDVEDAT"].DisplayIndex = 0;
            dtVeDat.Columns["IDVEDAT"].Width = 100;
            dtVeDat.Columns["AIRCRAFTSEATISD"].HeaderText = "AIRCRAFTSEATISD";
            dtVeDat.Columns["AIRCRAFTSEATISD"].DisplayIndex = 1;
            dtVeDat.Columns["AIRCRAFTSEATISD"].Width = 300;
            dtVeDat.Columns["EMAIL"].HeaderText = "EMAIL";
            dtVeDat.Columns["EMAIL"].DisplayIndex = 2;
            dtVeDat.Columns["EMAIL"].Width = 150;
            dtVeDat.Columns["TRANGTHAI"].HeaderText = "TRANGTHAI";
            dtVeDat.Columns["TRANGTHAI"].DisplayIndex = 3;
            dtVeDat.Columns["TRANGTHAI"].Width = 250;
        }
        void _reset()
        {
            txtID.Text = "";
            txtAircraftSeatID.Text = "";
            txtEmail.Text = "";
            cboTrangThai.Text = "";
        }

        private void dtVeDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Chọn toàn bộ hàng
            dtVeDat.Rows[e.RowIndex].Selected = true;
            int rowIndex = e.RowIndex; // Lấy chỉ số hàng của ô được click

            if (rowIndex >= 0)
            {

                // Lấy dữ liệu từ hàng được click
                DataGridViewRow selectedRow = dtVeDat.Rows[rowIndex];

                string ID = selectedRow.Cells["IDVEDAT"].Value.ToString();
                string AIRCRAFTSEATISD = selectedRow.Cells["AIRCRAFTSEATISD"].Value.ToString();
                string EMAIL = selectedRow.Cells["EMAIL"].Value.ToString();
                string TRANGTHAI = selectedRow.Cells["TRANGTHAI"].Value.ToString();

                _id = int.Parse(ID);
                txtID.Text = ID;
                txtAircraftSeatID.Text = AIRCRAFTSEATISD;
                cboTrangThai.Text = TRANGTHAI;
                txtEmail.Text = EMAIL;
            }
            butCheckin.Enabled = true;
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm")
            {
                txtTimKiem.Text = "";
            }
        }

        private void butCheckin_Click(object sender, EventArgs e)
        {
            tb_VEDAT ve = _vedat.getAllByID(int.Parse(txtID.Text));
            ve.TRANGTHAI = "Confirmed";
            _vedat.update(ve);
            dtVeDat.Controls.Clear();
            loadData();
        }
    }
}