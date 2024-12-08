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
    public partial class frmTaiKhoanNhanVien : DevExpress.XtraEditors.XtraForm
    {
        string loaiquyen;
        public frmTaiKhoanNhanVien()
        {
            InitializeComponent();
        }
        public frmTaiKhoanNhanVien(string loaiquyen)
        {
            InitializeComponent();
            this.loaiquyen = loaiquyen;
        }
        TAIKHOANNHANVIEN _taikhoannhanvien;
        bool _them;
        string _id;
        private void frmTaiKhoanNhanVien_Load(object sender, EventArgs e)
        {
            _taikhoannhanvien = new TAIKHOANNHANVIEN();
            loadData();
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
            dtNhanVien.DataSource = _taikhoannhanvien.getAll().Select(a => new
            {
                a.IDTAIKHOAN,
                a.IDNV,
                a.USERNAME,
                a.PASSWORD
            }).ToList();
            dtNhanVien.Columns["IDTAIKHOAN"].HeaderText = "IDTAIKHOAN";
            dtNhanVien.Columns["IDTAIKHOAN"].DisplayIndex = 0;
            dtNhanVien.Columns["IDTAIKHOAN"].Width = 100;
            dtNhanVien.Columns["IDNV"].HeaderText = "IDNHANVIEN";
            dtNhanVien.Columns["IDNV"].DisplayIndex = 1;
            dtNhanVien.Columns["IDNV"].Width = 100;
            dtNhanVien.Columns["USERNAME"].HeaderText = "USERNAME";
            dtNhanVien.Columns["USERNAME"].DisplayIndex = 2;
            dtNhanVien.Columns["USERNAME"].Width = 100;
            dtNhanVien.Columns["PASSWORD"].HeaderText = "PASSWORD";
            dtNhanVien.Columns["PASSWORD"].DisplayIndex = 3;
            dtNhanVien.Columns["PASSWORD"].Width = 150;
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
            txtIDTaiKhoan.Enabled = t;
            txtIDNhanVien.Enabled = t;
            txtUssername.Enabled = t;
            txtPassword.Enabled = t;
        }
        void _reset()
        {
            txtIDTaiKhoan.Text = "";
            txtIDNhanVien.Text = "";
            txtUssername.Text = "";
            txtPassword.Text = "";
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
                _taikhoannhanvien.delete(_id);
            }
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUssername.Text.Trim()) || string.IsNullOrEmpty(txtPassword.Text.Trim()) || string.IsNullOrEmpty(txtIDTaiKhoan.Text.Trim()) || string.IsNullOrEmpty(txtIDNhanVien.Text.Trim()))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                if (_them)
                {
                    tb_TAIKHOANNHANVIEN taikhoannhanvien = new tb_TAIKHOANNHANVIEN();
                    taikhoannhanvien.IDTAIKHOAN = txtIDTaiKhoan.Text;
                    taikhoannhanvien.IDNV = txtIDNhanVien.Text;
                    taikhoannhanvien.USERNAME = txtUssername.Text;
                    taikhoannhanvien.PASSWORD = txtPassword.Text;
                    _taikhoannhanvien.add(taikhoannhanvien);
                }
                else
                {
                    tb_TAIKHOANNHANVIEN taikhoannhanvien = _taikhoannhanvien.getAllById(_id);
                    taikhoannhanvien.IDNV = txtIDNhanVien.Text;
                    taikhoannhanvien.USERNAME = txtUssername.Text;
                    taikhoannhanvien.PASSWORD = txtPassword.Text;
                    _taikhoannhanvien.update(taikhoannhanvien);
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

        private void dtNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Chọn toàn bộ hàng
            dtNhanVien.Rows[e.RowIndex].Selected = true;
            int rowIndex = e.RowIndex; // Lấy chỉ số hàng của ô được click

            if (rowIndex >= 0)
            {

                // Lấy dữ liệu từ hàng được click
                DataGridViewRow selectedRow = dtNhanVien.Rows[rowIndex];

                string IDTAIKHOAN = selectedRow.Cells["IDTAIKHOAN"].Value.ToString();
                string IDNV = selectedRow.Cells["IDNV"].Value.ToString();
                string USERNAME = selectedRow.Cells["USERNAME"].Value.ToString();
                string PASSWORD = selectedRow.Cells["PASSWORD"].Value.ToString();

                _id = IDTAIKHOAN;
                txtIDTaiKhoan.Text = IDTAIKHOAN;
                txtUssername.Text = USERNAME;
                txtIDNhanVien.Text = IDNV;
                txtPassword.Text = PASSWORD;
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