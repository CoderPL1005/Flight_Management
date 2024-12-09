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

namespace FLIGHTS
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        MEMBER _member;

        private void txtUserId_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text == "Vui lòng nhập ID của quý khách")
            {
                txtUserId.Text = "";
            }
        }

        private void txtPassWord_Click(object sender, EventArgs e)
        {
            txtPassWord.UseSystemPasswordChar = true;
            if (txtPassWord.Text == "Vui lòng nhập mật khẩu của quý khách")
            {
                txtPassWord.Text = "";
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            _member = new MEMBER();
        }
        public event EventHandler RegistrationSuccessful; //biến để tạo sự kiện thông báo đăng ký thành công

        private void lbDangNhap_Click(object sender, EventArgs e)
        {
            if (_member.CheckPassWord(txtUserId.Text, txtPassWord.Text) == true)
            {
                tb_Member tv = _member.getAllByUserID(txtUserId.Text);
                UserSession.Username = tv.USERID;
                UserSession.Password = tv.PASSWORD;
                RegistrationSuccessful?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
            else
            {
                lbWarning.Text = "Tài khoản không hợp lệ.";
            }
        }

        private void txtPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lbDangNhap_Click(sender, e);
            }
        }
    }
}