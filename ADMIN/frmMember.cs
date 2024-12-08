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
    public partial class frmMember : DevExpress.XtraEditors.XtraForm
    {
        string loaiquyen;
        public frmMember()
        {
            InitializeComponent();
        }
        public frmMember(string loaiquyen)
        {
            InitializeComponent();
            this.loaiquyen = loaiquyen;
        }
        MEMBER _member;
        bool _them;
        string _email;
        private void frmMember_Load(object sender, EventArgs e)
        {
            _member = new MEMBER();
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
            dtMember.DataSource = _member.getAll().Select(a => new
            {
                a.USERID,
                a.PASSWORD,
                a.DIENTHOAI,
                a.DIACHI,
                a.EMAIL,
                a.NGAYSINH,
                a.GIOITINH,
                a.DISABLED,
                a.HOTEN
            }).ToList();
            dtMember.Columns["USERID"].HeaderText = "ID";
            dtMember.Columns["USERID"].DisplayIndex = 0;
            dtMember.Columns["USERID"].Width = 100;
            dtMember.Columns["HOTEN"].HeaderText = "HOTEN";
            dtMember.Columns["HOTEN"].DisplayIndex = 2;
            dtMember.Columns["HOTEN"].Width = 100;
            dtMember.Columns["DIENTHOAI"].HeaderText = "DIENTHOAI";
            dtMember.Columns["DIENTHOAI"].DisplayIndex = 3;
            dtMember.Columns["DIENTHOAI"].Width = 100;
            dtMember.Columns["EMAIL"].HeaderText = "EMAIL";
            dtMember.Columns["EMAIL"].DisplayIndex = 4;
            dtMember.Columns["EMAIL"].Width = 150;
            dtMember.Columns["DIACHI"].HeaderText = "DIACHI";
            dtMember.Columns["DIACHI"].DisplayIndex = 5;
            dtMember.Columns["DIACHI"].Width = 250;
            dtMember.Columns["GIOITINH"].HeaderText = "GIOITINH";
            dtMember.Columns["GIOITINH"].DisplayIndex = 6;
            dtMember.Columns["GIOITINH"].Width = 75;
            dtMember.Columns["NGAYSINH"].HeaderText = "NGAYSINH";
            dtMember.Columns["NGAYSINH"].DisplayIndex = 7;
            dtMember.Columns["NGAYSINH"].Width = 150;
            dtMember.Columns["PASSWORD"].HeaderText = "PASSWORD";
            dtMember.Columns["PASSWORD"].DisplayIndex = 1;
            dtMember.Columns["PASSWORD"].Width = 150;
            dtMember.Columns["DISABLED"].HeaderText = "DISABLED";
            dtMember.Columns["DISABLED"].DisplayIndex = 8;
            dtMember.Columns["DISABLED"].Width = 75;
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
            txtTen.Enabled = t;
            txtDiaChi.Enabled = t;
            txtPassword.Enabled = t;
            txtDienThoai.Enabled = t;
            txtEmail.Enabled = t;
            cboGioitinh.Enabled = t;
            datNgaySinh.Enabled = t;
            chkDisabled.Enabled = t;
            txtID.Enabled = t;
        }
        void _reset()
        {
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtPassword.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            cboGioitinh.Text = "";
            datNgaySinh.Text = DateTime.Now.ToString();
            txtID.Text = "";
            chkDisabled.Checked = false;
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
                _member.delete(_email);
            }
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTen.Text.Trim()) || string.IsNullOrEmpty(cboGioitinh.Text.Trim()) || string.IsNullOrEmpty(txtDiaChi.Text.Trim()) || string.IsNullOrEmpty(txtDienThoai.Text.Trim()) || string.IsNullOrEmpty(txtEmail.Text.Trim()) || string.IsNullOrEmpty(txtID.Text.Trim()) || string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                if (_them)
                {
                    tb_Member member = new tb_Member();
                    member.USERID = txtID.Text;
                    member.HOTEN = txtTen.Text;
                    member.EMAIL = txtEmail.Text;
                    member.DIENTHOAI = txtDienThoai.Text;
                    member.DIACHI = txtDiaChi.Text;
                    member.GIOITINH = cboGioitinh.Text;
                    member.NGAYSINH = datNgaySinh.Value;
                    member.PASSWORD = txtPassword.Text;
                    member.DISABLED = chkDisabled.Checked;
                    _member.add(member);
                }
                else
                {
                    tb_Member member = _member.getAllByEmail(_email);
                    member.HOTEN = txtTen.Text;
                    member.USERID = txtID.Text;
                    member.DIENTHOAI = txtDienThoai.Text;
                    member.DIACHI = txtDiaChi.Text;
                    member.GIOITINH = cboGioitinh.Text;
                    member.NGAYSINH = datNgaySinh.Value;
                    member.PASSWORD = txtPassword.Text;
                    member.DISABLED = chkDisabled.Checked;
                    _member.update(member);
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

        private void dtMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Chọn toàn bộ hàng
            dtMember.Rows[e.RowIndex].Selected = true;
            int rowIndex = e.RowIndex; // Lấy chỉ số hàng của ô được click

            if (rowIndex >= 0)
            {

                // Lấy dữ liệu từ hàng được click
                DataGridViewRow selectedRow = dtMember.Rows[rowIndex];

                string ID = selectedRow.Cells["USERID"].Value.ToString();
                string HOTEN = selectedRow.Cells["HOTEN"].Value.ToString();
                string DIENTHOAI = selectedRow.Cells["DIENTHOAI"].Value.ToString();
                string EMAIL = selectedRow.Cells["EMAIL"].Value.ToString();
                string GIOITINH = selectedRow.Cells["GIOITINH"].Value.ToString();
                string NGAYSINH = selectedRow.Cells["NGAYSINH"].Value.ToString();
                string DIACHI = selectedRow.Cells["DIACHI"].Value.ToString();
                string PASSWORD = selectedRow.Cells["PASSWORD"].Value.ToString();
                bool DISABLED = bool.Parse(selectedRow.Cells["DISABLED"].Value.ToString());

                _email = EMAIL;
                txtID.Text = ID;
                txtTen.Text = HOTEN;
                txtDienThoai.Text = DIENTHOAI;
                txtEmail.Text = EMAIL;
                cboGioitinh.Text = GIOITINH;
                datNgaySinh.Text = NGAYSINH;
                txtDiaChi.Text = DIACHI;
                txtPassword.Text = PASSWORD;
                chkDisabled.Checked = DISABLED;
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