using ADMIN;
using BusinessLayer;
using DataLayer;
using DevExpress.Utils.Behaviors;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraReports.Design;
using DevExpress.XtraRichEdit.Layout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMIN
{
    public partial class frmDangNhapAdmin : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhapAdmin()
        {
            InitializeComponent();
        }

        TAIKHOANNHANVIEN _taikhoan;
        NHANVIEN _nhanvien;
        private void frmDangNhapAdmin_Load(object sender, EventArgs e)
        {
            btShowPass.ImageOptions.Image = imageList1.Images[0];
            _taikhoan = new TAIKHOANNHANVIEN();
            _nhanvien = new NHANVIEN();
        }
        private void simbutClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool check = true;
        private void simbutLogin_Click(object sender, EventArgs e)
        {
            foreach (var pairs in _taikhoan.getUserPass())
            {
                string username = pairs.Key;
                string pass = pairs.Value;
                if (txtUsername.Text == username)
                {
                    check = true;
                    if (txtPassword.Text == pass)
                    {
                        string IDNhanVien = _taikhoan.getIDNhanVien(username);
                        string IDChucVu = _nhanvien.getIDChucVu(IDNhanVien);
                        frmMain frmm = new frmMain(IDChucVu);
                        frmm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        lbPassword.Visible = true;
                        break;
                    }
                }
                else
                {
                    check = false;
                }
            }
            if (check == false)
            {
                lbUsername.Visible = true;
            }
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string enteredPass = txtPassword.Text;
                string enteredUsername = txtUsername.Text;

                simbutLogin_Click(sender, e);

                e.Handled = true;
            }
        }

        private void btShowPass_MouseDown(object sender, MouseEventArgs e)
        {
            btShowPass.ImageOptions.Image = imageList1.Images[1];
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btShowPass_MouseUp(object sender, MouseEventArgs e)
        {
            btShowPass.ImageOptions.Image = imageList1.Images[0];
            txtPassword.UseSystemPasswordChar = true;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            lbPassword.Visible = false;
            lbUsername.Visible = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lbPassword.Visible = false;
            lbUsername.Visible = false;
        }
    }
}