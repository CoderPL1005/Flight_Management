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
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        string loaiquyen;
        public frmNhanVien()
        {
            InitializeComponent();
        }
        public frmNhanVien(string loaiquyen)
        {
            InitializeComponent();
            this.loaiquyen = loaiquyen;
        }
        NHANVIEN _nhanviens;
        CHUCVU _chucvu;
        bool _them;
        string _id;
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            _nhanviens = new NHANVIEN();
            _chucvu = new CHUCVU();
            loadData();
            loadChucvu();
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
        void loadChucvu()
        {
            foreach (var item in _chucvu.getAll())
            {
                cboChucVu.Items.Add(item.CHUCVU);
            }
        }
        void loadData()
        {
            dtNhanVien.DataSource = _nhanviens.getAll().Select(a => new
            {
                a.IDNV,
                a.HOTEN,
                a.DIENTHOAI,
                a.EMAIL,
                a.DIACHI,
                a.GIOITINH,
                a.NGAYSINH,
                a.NGAYVAOLAM,
                a.IDCHUCVU,
                a.DISABLED
            }).ToList();
            dtNhanVien.Columns["IDNV"].HeaderText = "ID";
            dtNhanVien.Columns["IDNV"].DisplayIndex = 0;
            dtNhanVien.Columns["IDNV"].Width = 100;
            dtNhanVien.Columns["HOTEN"].HeaderText = "ID";
            dtNhanVien.Columns["HOTEN"].DisplayIndex = 1;
            dtNhanVien.Columns["HOTEN"].Width = 100;
            dtNhanVien.Columns["DIENTHOAI"].HeaderText = "DIENTHOAI";
            dtNhanVien.Columns["DIENTHOAI"].DisplayIndex = 2;
            dtNhanVien.Columns["DIENTHOAI"].Width = 100;
            dtNhanVien.Columns["EMAIL"].HeaderText = "EMAIL";
            dtNhanVien.Columns["EMAIL"].DisplayIndex = 3;
            dtNhanVien.Columns["EMAIL"].Width = 150;
            dtNhanVien.Columns["DIACHI"].HeaderText = "DIACHI";
            dtNhanVien.Columns["DIACHI"].DisplayIndex = 4;
            dtNhanVien.Columns["DIACHI"].Width = 250;
            dtNhanVien.Columns["GIOITINH"].HeaderText = "GIOITINH";
            dtNhanVien.Columns["GIOITINH"].DisplayIndex = 5;
            dtNhanVien.Columns["GIOITINH"].Width = 75;
            dtNhanVien.Columns["NGAYSINH"].HeaderText = "NGAYSINH";
            dtNhanVien.Columns["NGAYSINH"].DisplayIndex = 6;
            dtNhanVien.Columns["NGAYSINH"].Width = 150;
            dtNhanVien.Columns["NGAYVAOLAM"].HeaderText = "NGAYVAOLAM";
            dtNhanVien.Columns["NGAYVAOLAM"].DisplayIndex = 7;
            dtNhanVien.Columns["NGAYVAOLAM"].Width = 150;
            dtNhanVien.Columns["IDCHUCVU"].HeaderText = "CHUCVU";
            dtNhanVien.Columns["IDCHUCVU"].DisplayIndex = 8;
            dtNhanVien.Columns["IDCHUCVU"].Width = 200;
            dtNhanVien.Columns["DISABLED"].HeaderText = "DISABLED";
            dtNhanVien.Columns["DISABLED"].DisplayIndex = 9;
            dtNhanVien.Columns["DISABLED"].Width = 75;
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
            cboChucVu.Enabled = t;
            txtDienThoai.Enabled = t;
            txtEmail.Enabled = t;
            cboGioitinh.Enabled = t;
            datNgaySinh.Enabled = t;
            datNgayVaoLam.Enabled = t;
            cboChucVu.Enabled = t;
            chkDisabled.Enabled = t;
        }
        void _reset()
        {
            txtTen.Text = "";
            txtDiaChi.Text = "";
            cboChucVu.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            cboGioitinh.Text = "";
            datNgaySinh.Text = DateTime.Now.ToString();
            datNgayVaoLam.Text = DateTime.Now.ToString();
            cboChucVu.Text = "";
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
                _nhanviens.delete(_id);
            }
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTen.Text.Trim()) || string.IsNullOrEmpty(cboGioitinh.Text.Trim()) || string.IsNullOrEmpty(txtDiaChi.Text.Trim()) || string.IsNullOrEmpty(txtDienThoai.Text.Trim()) || string.IsNullOrEmpty(txtEmail.Text.Trim()) || string.IsNullOrEmpty(cboChucVu.Text.Trim()))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                if (_them)
                {
                    tb_NHANVIEN nhanviens = new tb_NHANVIEN();
                    nhanviens.IDNV = _nhanviens.GetNewID();
                    nhanviens.HOTEN = txtTen.Text;
                    nhanviens.EMAIL = txtEmail.Text;
                    nhanviens.DIENTHOAI = txtDienThoai.Text;
                    nhanviens.DIACHI = txtDiaChi.Text;
                    nhanviens.GIOITINH = cboGioitinh.Text;
                    nhanviens.NGAYSINH = datNgaySinh.Value;
                    nhanviens.NGAYVAOLAM = datNgayVaoLam.Value;
                    nhanviens.IDCHUCVU = _chucvu.getIdChuVu(cboChucVu.Text);
                    nhanviens.DISABLED = chkDisabled.Checked;
                    _nhanviens.add(nhanviens);
                }
                else
                {
                    tb_NHANVIEN nhanviens = _nhanviens.getAllById(_id);
                    nhanviens.HOTEN = txtTen.Text;
                    nhanviens.EMAIL = txtEmail.Text;
                    nhanviens.DIENTHOAI = txtDienThoai.Text;
                    nhanviens.DIACHI = txtDiaChi.Text;
                    nhanviens.GIOITINH = cboGioitinh.Text;
                    nhanviens.NGAYSINH = datNgaySinh.Value;
                    nhanviens.NGAYVAOLAM = datNgayVaoLam.Value;
                    nhanviens.IDCHUCVU = _chucvu.getIdChuVu(cboChucVu.Text);
                    nhanviens.DISABLED = chkDisabled.Checked;
                    _nhanviens.update(nhanviens);
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

                string ID = selectedRow.Cells["IDNV"].Value.ToString();
                string HOTEN = selectedRow.Cells["HOTEN"].Value.ToString();
                string DIENTHOAI = selectedRow.Cells["DIENTHOAI"].Value.ToString();
                string EMAIL = selectedRow.Cells["EMAIL"].Value.ToString();
                string GIOITINH = selectedRow.Cells["GIOITINH"].Value.ToString();
                string NGAYSINH = selectedRow.Cells["NGAYSINH"].Value.ToString();
                string DIACHI = selectedRow.Cells["DIACHI"].Value.ToString();
                string NGAYVAOLAM = selectedRow.Cells["NGAYVAOLAM"].Value.ToString();
                string IDCHUCVU = selectedRow.Cells["IDCHUCVU"].Value.ToString();
                bool DISABLED = bool.Parse(selectedRow.Cells["DISABLED"].Value.ToString());

                _id = ID;
                txtID.Text = ID;
                txtTen.Text = HOTEN;
                txtDienThoai.Text = DIENTHOAI;
                txtEmail.Text = EMAIL;
                cboGioitinh.Text = GIOITINH;
                datNgaySinh.Text = NGAYSINH;
                txtDiaChi.Text = DIACHI;
                datNgayVaoLam.Text = NGAYVAOLAM;
                cboChucVu.Text = _chucvu.getChuVu(IDCHUCVU);
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