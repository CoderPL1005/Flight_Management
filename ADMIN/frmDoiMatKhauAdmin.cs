using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMIN
{
    public partial class frmDoiMatKhauAdmin : DevExpress.XtraEditors.XtraForm
    {

        string IDTaiKhoan;
        public frmDoiMatKhauAdmin(string IDTaiKhoan)
        {
            InitializeComponent();
            this.IDTaiKhoan = IDTaiKhoan;
        }

        TAIKHOANNHANVIEN _nhanvien;
        List<tb_TAIKHOANNHANVIEN> _checkNhanVien;
        private void frmDoiMatKhauAdmin_Load(object sender, EventArgs e)
        {
            _nhanvien = new TAIKHOANNHANVIEN();
            _checkNhanVien = _nhanvien.getAll();
            txtUserName.Text = _nhanvien.getAllByIDTaiKhoan(IDTaiKhoan).USERNAME;
        }

        private void butConfirm_Click(object sender, EventArgs e)
        {
            if(txtOldPass.Text != _nhanvien.getAllByIDTaiKhoan(IDTaiKhoan).PASSWORD)
            {
                MessageBox.Show("Mật khẩu cũ không chính xác!");
            }
            else if (txtNewPass.Text != txtRetypePass.Text)
            {
                MessageBox.Show("Cofrim Pass Incorrect!");
            }
            else
            {
                tb_TAIKHOANNHANVIEN nhanvien = new tb_TAIKHOANNHANVIEN();
                nhanvien.IDTAIKHOAN = IDTaiKhoan;
                nhanvien.USERNAME = txtUserName.Text;
                nhanvien.PASSWORD = txtNewPass.Text;
                nhanvien.IDNV = _nhanvien.getAllByIDTaiKhoan(IDTaiKhoan).IDNV;
                _nhanvien.update(nhanvien);
                this.Close();
            }
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRetypePass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                butConfirm_Click(sender, e);

                e.Handled = true;
            }
        }
    }
}