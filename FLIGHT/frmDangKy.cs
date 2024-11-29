using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using FLIGHT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Xml.Linq;

namespace THUEPHONG
{
    public partial class frmDangKy : DevExpress.XtraEditors.XtraForm
    {
        public frmDangKy()
        {
            InitializeComponent();
        }
        bool checkNamePass = false;
        bool checkEmailPass = false;
        bool checkPhonePass = false;
        bool checkGioiTinhPass = false;
        bool checkNgaySinhPass = false;
        bool checkDiaChiPass = false;
        bool checkUserIDPass = false;
        bool checkPassPass = false;
        bool checkConfirmPassPass = false;
        MEMBER _member;
        private void frmDangKy_Load(object sender, EventArgs e)
        {
            _member = new MEMBER();
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "Nhập họ tên của quý khách")
            {
                txtName.Text = "";
            }
        }

        private void txtBirthday_Click(object sender, EventArgs e)
        {
            if (txtBirthday.Text == "YYYY/MM/DD")
            {
                txtBirthday.Text = "";
            }
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "example@gmail.com")
            {
                txtEmail.Text = "";
            }
        }

        private void txtPhone_Click(object sender, EventArgs e)
        {
            if (txtPhone.Text == "Số điện thoại liên hệ")
            {
                txtPhone.Text = "";
            }
        }

        private void txtDiaChi_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "Địa chỉ")
            {
                txtDiaChi.Text = "";
            }
        }

        private void txtUserId_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text == "Nhập ID của quý khách")
            {
                txtUserId.Text = "";
            }
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "Vui lòng nhập mật khẩu của quý khách")
            {
                txtPass.Text = "";
            }
            WarningTextChanged("lbNoticePass", "Phải chứa từ 8 đến 20 ký tự.");
        }

        private void txtConfirmPass_Click(object sender, EventArgs e)
        {
            if (txtConfirmPass.Text == "Xác nhận mật khẩu của quý khách")
            {
                txtConfirmPass.Text = "";
            }
        }
        Stack<char> CharInput = new Stack<char>();
        
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char inputchar = e.KeyChar;
            if (inputchar != (char)Keys.Back)
            {
                CharInput.Push(inputchar);
            }
            else if (inputchar == (char)Keys.Back && CharInput.Count() > 0)
            {
                CharInput.Pop();
            }
        }
        
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Count() < 2)
            {
                WarningTextChanged("lbNoticeName", "Vui lòng nhập tối thiểu 2 ký tự.");
                foreach (var item in CharInput)
                {
                    if (char.IsDigit(item))
                    {
                        WarningTextChanged("lbNoticeName", "Chỉ có thể nhập dấu cách và chữ cái tiếng Anh (không có ký tự đặc biệt).");
                    }
                }
                checkNamePass = false;
            }
            else if (txtName.Text.Count() >= 2)
            {
                WarningTextChanged("lbNoticeName", "Good!");
                foreach (var item in CharInput)
                {
                    if (char.IsDigit(item))
                    {
                        WarningTextChanged("lbNoticeName", "Chỉ có thể nhập dấu cách và chữ cái tiếng Anh (không có ký tự đặc biệt).");
                        checkNamePass = false;
                        break;
                    }
                    else
                    {
                        checkNamePass = true;
                    }
                }
                bool tmpCheck = false;
                foreach (var item in CharInput)
                {
                    if (char.IsLetter(item))
                    {
                        tmpCheck = true;
                        break;
                    }
                }
                if (tmpCheck == false)
                {
                    WarningTextChanged("lbNoticeName", "Tên phải chứa chữ cái.");
                    checkNamePass = false;
                }
            }
            if (checkPhonePass == true && checkNamePass == true && checkEmailPass == true && checkGioiTinhPass == true && checkNgaySinhPass == true && checkDiaChiPass == true && checkUserIDPass == true && checkPassPass == true && checkConfirmPassPass == true)
            {
                lbNext.Enabled = true;
                lbNext.BackColor = Color.FromArgb(173, 158, 135);
                lbNext.ForeColor = Color.White;
                lbNext.Cursor = Cursors.Hand;
            }
            else
            {
                lbNext.Enabled = false;
                lbNext.BackColor = Color.FromArgb(232, 232, 232);
                lbNext.ForeColor = Color.White;
                lbNext.Cursor = Cursors.No;
            }
        }
        
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text.Length < 10)
            {
                WarningTextChanged("lbWarningPhone", "Là trường bắt buộc.");
                checkPhonePass = false;
            }
            else if (txtPhone.Text.Length == 10)
            {
                WarningTextChanged("lbWarningPhone", "Good!");
                checkPhonePass = true;
            }

            if (checkPhonePass == true && checkNamePass == true && checkEmailPass == true && checkGioiTinhPass == true && checkNgaySinhPass == true && checkDiaChiPass == true && checkUserIDPass == true && checkPassPass == true && checkConfirmPassPass == true)
            {
                lbNext.Enabled = true;
                lbNext.BackColor = Color.FromArgb(173, 158, 135);
                lbNext.ForeColor = Color.White;
                lbNext.Cursor = Cursors.Hand;
            }
            else
            {
                lbNext.Enabled = false;
                lbNext.BackColor = Color.FromArgb(232, 232, 232);
                lbNext.ForeColor = Color.White;
                lbNext.Cursor = Cursors.No;
            }
        }
        
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || txtPhone.Text.Length > 9)
            {
                e.Handled = true;
            }
        }
        
        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back && txtPhone.Text.Length > 0)
            {
                txtPhone.Text = txtPhone.Text.Substring(0, txtPhone.Text.Length - 1);
                txtPhone.SelectionStart = txtPhone.Text.Length;
                e.Handled = true; // Đánh dấu sự kiện xử lý
            }
        }

        public void WarningTextChanged(string textName, string textText)
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is Label)
                {
                    Label label = (Label)control;
                    if (label.Name == textName)
                    {
                        label.Text = textText;
                    }
                }
            }
        }
        
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                WarningTextChanged("lbWarningEmail", "Là trường bắt buộc.");
                lbKiemTraEmail.Enabled = false;
                lbKiemTraEmail.BackColor = Color.Gainsboro;
            }
            else
            {
                if (!IsValidEmail(txtEmail.Text))
                {
                    WarningTextChanged("lbWarningEmail", "Định dạng địa chỉ email không hợp lệ.");
                    lbKiemTraEmail.Enabled = false;
                    lbKiemTraEmail.BackColor = Color.Gainsboro;
                }
                else
                {
                    WarningTextChanged("lbWarningEmail", "Vui lòng kiểm tra về tính có sẵn!");
                    lbKiemTraEmail.Enabled = true;
                    lbKiemTraEmail.BackColor = Color.FromArgb(85, 85, 85);
                }

            }

        }
        private bool IsValidEmail(string email)
        {
            // Sử dụng biểu thức chính quy để kiểm tra định dạng email
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
        bool CheckEmailDisabled = false;
        
        private void lbKiemTraEmail_Click(object sender, EventArgs e)
        {
            CheckEmailDisabled = false;
            List<string> EmailCheck = _member.getEmail();
            foreach (var email in EmailCheck)
            {
                if (email == txtEmail.Text)
                {
                    CheckEmailDisabled = true;
                    break;
                }
            }
            if (CheckEmailDisabled == true)
            {
                WarningTextChanged("lbWarningEmail", "Email đã tồn tại.");
                checkEmailPass = false;
            }
            else
            {
                WarningTextChanged("lbWarningEmail", "Có thể sử dụng email này");
                checkEmailPass = true;
            }
            if (checkPhonePass == true && checkNamePass == true && checkEmailPass == true && checkGioiTinhPass == true && checkNgaySinhPass == true && checkDiaChiPass == true && checkUserIDPass == true && checkPassPass == true && checkConfirmPassPass == true)
            {
                lbNext.Enabled = true;
                lbNext.BackColor = Color.FromArgb(173, 158, 135);
                lbNext.ForeColor = Color.White;
                lbNext.Cursor = Cursors.Hand;
            }
            else
            {
                lbNext.Enabled = false;
                lbNext.BackColor = Color.FromArgb(232, 232, 232);
                lbNext.ForeColor = Color.White;
                lbNext.Cursor = Cursors.No;
            }
        }

        private void txtBirthday_TextChanged(object sender, EventArgs e)
        {
            string input = txtBirthday.Text;

            if (IsValidDateFormat(input))
            {
                DateTime birthDate;
                if (DateTime.TryParse(input, out birthDate))
                {
                    int age = CalculateAge(birthDate);

                    if (age < 18)
                    {
                        WarningTextChanged("lbNoticeNgaySinh", "Vui lòng kiểm tra ngày sinh của quý khách. Trẻ em dưới 18 tuổi không thể sử dụng.");
                        checkNgaySinhPass = false;
                    }
                    else
                    {
                        WarningTextChanged("lbNoticeNgaySinh", "Good!");
                        checkNgaySinhPass = true;
                    }
                }
                else
                {
                    WarningTextChanged("lbNoticeNgaySinh", "Vui lòng kiểm tra ngày sinh của quý vị (năm, tháng, ngày theo định dạng YYYY/MM/DD)");
                    checkNgaySinhPass = false;
                }
            }
            else
            {
                WarningTextChanged("lbNoticeNgaySinh", "Vui lòng kiểm tra ngày sinh của quý vị (năm, tháng, ngày theo định dạng YYYY/MM/DD)");
                checkNgaySinhPass = false;
            }
            if (checkPhonePass == true && checkNamePass == true && checkEmailPass == true && checkGioiTinhPass == true && checkNgaySinhPass == true && checkDiaChiPass == true && checkUserIDPass == true && checkPassPass == true && checkConfirmPassPass == true)
            {
                lbNext.Enabled = true;
                lbNext.BackColor = Color.FromArgb(173, 158, 135);
                lbNext.ForeColor = Color.White;
                lbNext.Cursor = Cursors.Hand;
            }
            else
            {
                lbNext.Enabled = false;
                lbNext.BackColor = Color.FromArgb(232, 232, 232);
                lbNext.ForeColor = Color.White;
                lbNext.Cursor = Cursors.No;
            }
        }
        public bool IsValidDateFormat(string input)
        {
            DateTime date;
            return DateTime.TryParseExact(input, "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out date);
        }
        
        private int CalculateAge(DateTime birthDate)
        {
            DateTime currentDate = DateTime.Today;
            int age = currentDate.Year - birthDate.Year;
            if (birthDate > currentDate.AddYears(-age))
            {
                age--;
            }
            return age;
        }
        
        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                checkGioiTinhPass = true;
            }
            if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                checkGioiTinhPass = false;
            }
            if (checkPhonePass == true && checkNamePass == true && checkEmailPass == true && checkGioiTinhPass == true && checkNgaySinhPass == true && checkDiaChiPass == true && checkUserIDPass == true && checkPassPass == true && checkConfirmPassPass == true)
            {
                lbNext.Enabled = true;
                lbNext.BackColor = Color.FromArgb(173, 158, 135);
                lbNext.ForeColor = Color.White;
                lbNext.Cursor = Cursors.Hand;
            }
            else
            {
                lbNext.Enabled = false;
                lbNext.BackColor = Color.FromArgb(232, 232, 232);
                lbNext.ForeColor = Color.White;
                lbNext.Cursor = Cursors.No;
            }
        }
        
        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "")
            {
                WarningTextChanged("lbNoticeDiaChi", "Là trường bắt buộc.");
                checkDiaChiPass = false;
            }
            else
            {
                WarningTextChanged("lbNoticeDiaChi", "Good!");
                checkDiaChiPass = true;
            }
            if (checkPhonePass == true && checkNamePass == true && checkEmailPass == true && checkGioiTinhPass == true && checkNgaySinhPass == true && checkDiaChiPass == true && checkUserIDPass == true && checkPassPass == true && checkConfirmPassPass == true)
            {
                lbNext.Enabled = true;
                lbNext.BackColor = Color.FromArgb(173, 158, 135);
                lbNext.ForeColor = Color.White;
                lbNext.Cursor = Cursors.Hand;
            }
            else
            {
                lbNext.Enabled = false;
                lbNext.BackColor = Color.FromArgb(232, 232, 232);
                lbNext.ForeColor = Color.White;
                lbNext.Cursor = Cursors.No;
            }
        }
        
        private void txtUserId_TextChanged(object sender, EventArgs e)
        {
            if (txtUserId.Text.Length < 4)
            {
                WarningTextChanged("lbNoticeUserID", "Quý khách không thể sử dụng ít hơn 4 ký tự.");
            }
            else
            {
                WarningTextChanged("lbNoticeUserID", "Vui lòng hoàn thành kiểm tra về trùng lặp.");
                lbCheckUSERID.Enabled = true;
                lbCheckUSERID.BackColor = Color.FromArgb(85, 85, 85);

            }
        }
        
        private void txtUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = true;
                WarningTextChanged("lbNoticeUserID", "Ký tự không hợp lệ.");
            }
        }
        bool checkUserIDdisabled = false;
        
        private void lbCheckUSERID_Click(object sender, EventArgs e)
        {
            checkUserIDdisabled = false;
            List<string> UserID = _member.getUserID();
            foreach (var userid in UserID)
            {
                if (userid == txtUserId.Text)
                {
                    checkUserIDdisabled = true;
                }
            }
            if (checkUserIDdisabled == true)
            {
                WarningTextChanged("lbNoticeUserID", "UserID đã tồn tại.");
                checkUserIDPass = false;
            }
            else
            {
                WarningTextChanged("lbNoticeUserID", "Có thể sử dụng UserID này.");
                checkUserIDPass = true;
            }
            if (checkPhonePass == true && checkNamePass == true && checkEmailPass == true && checkGioiTinhPass == true && checkNgaySinhPass == true && checkDiaChiPass == true && checkUserIDPass == true && checkPassPass == true && checkConfirmPassPass == true)
            {
                lbNext.Enabled = true;
                lbNext.BackColor = Color.FromArgb(173, 158, 135);
                lbNext.ForeColor = Color.White;
                lbNext.Cursor = Cursors.Hand;
            }
            else
            {
                lbNext.Enabled = false;
                lbNext.BackColor = Color.FromArgb(232, 232, 232);
                lbNext.ForeColor = Color.White;
                lbNext.Cursor = Cursors.No;
            }
        }
        private bool IsValidPassword(string password)
        {
            // Kiểm tra chiều dài từ 8 đến 20 ký tự
            if (password.Length < 8 || password.Length > 20)
                return false;


            return true;
        }
        string pass = "";
        string passConfirm = "";
        
        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (IsValidPassword(txtPass.Text) == true)
            {
                WarningTextChanged("lbNoticePass", "Good!");
                pass = txtPass.Text;
                if (pass != passConfirm && passConfirm != "")
                {
                    WarningTextChanged("lbNoticePass", "Mật khẩu không khớp.");
                    checkPassPass = false;
                }
                else
                {
                    checkPassPass = true;
                }
            }
            else
            {
                WarningTextChanged("lbNoticePass", "Phải chứa từ 8 đến 20 ký tự.");
                checkPassPass = false;
            }
            if (checkPhonePass == true && checkNamePass == true && checkEmailPass == true && checkGioiTinhPass == true && checkNgaySinhPass == true && checkDiaChiPass == true && checkUserIDPass == true && checkPassPass == true && checkConfirmPassPass == true)
            {
                lbNext.Enabled = true;
                lbNext.BackColor = Color.FromArgb(173, 158, 135);
                lbNext.ForeColor = Color.White;
                lbNext.Cursor = Cursors.Hand;
            }
            else
            {
                lbNext.Enabled = false;
                lbNext.BackColor = Color.FromArgb(232, 232, 232);
                lbNext.ForeColor = Color.White;
                lbNext.Cursor = Cursors.No;
            }
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmPass.Text == pass)
            {
                WarningTextChanged("lbNoticePass", "Good!");
                passConfirm = txtConfirmPass.Text;
                checkConfirmPassPass = true;
            }
            else
            {
                WarningTextChanged("lbNoticePass", "Mật khẩu không khớp.");
                checkConfirmPassPass = false;
            }
            if (checkPhonePass == true && checkNamePass == true && checkEmailPass == true && checkGioiTinhPass == true && checkNgaySinhPass == true && checkDiaChiPass == true && checkUserIDPass == true && checkPassPass == true && checkConfirmPassPass == true)
            {
                lbNext.Enabled = true;
                lbNext.BackColor = Color.FromArgb(173, 158, 135);
                lbNext.ForeColor = Color.White;
                lbNext.Cursor = Cursors.Hand;
            }
            else
            {
                lbNext.Enabled = false;
                lbNext.BackColor = Color.FromArgb(232, 232, 232);
                lbNext.ForeColor = Color.White;
                lbNext.Cursor = Cursors.No;
            }
        }
        
        private void checkBox2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                checkGioiTinhPass = true;
            }
            if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                checkGioiTinhPass = false;
            }
            if (checkPhonePass == true && checkNamePass == true && checkEmailPass == true && checkGioiTinhPass == true && checkNgaySinhPass == true && checkDiaChiPass == true && checkUserIDPass == true && checkPassPass == true && checkConfirmPassPass == true)
            {
                lbNext.Enabled = true;
                lbNext.BackColor = Color.FromArgb(173, 158, 135);
                lbNext.ForeColor = Color.White;
                lbNext.Cursor = Cursors.Hand;
            }
            else
            {
                lbNext.Enabled = false;
                lbNext.BackColor = Color.FromArgb(232, 232, 232);
                lbNext.ForeColor = Color.White;
                lbNext.Cursor = Cursors.No;
            }
        }
        public event EventHandler RegistrationSuccessful; //biến để tạo sự kiện thông báo đăng ký thành công
        private void lbNext_Click(object sender, EventArgs e)
        {
            tb_Member tv = new tb_Member();
            tv.USERID = txtUserId.Text;
            tv.EMAIL = txtEmail.Text;
            tv.PASSWORD = txtPass.Text;
            tv.HOTEN = txtName.Text;
            if (checkBox1.Checked == true)
            {
                tv.GIOITINH = "Nam";
            }
            else
            {
                tv.GIOITINH = "Nữ";
            }
            tv.NGAYSINH = DateTime.ParseExact(txtBirthday.Text, "yyyy/MM/dd", CultureInfo.InvariantCulture);
            tv.DIACHI = txtDiaChi.Text;
            tv.DIENTHOAI = txtPhone.Text;
            tv.IMAGE_PART = "";
            _member.add(tv);
            UserSession.Username = tv.USERID;
            UserSession.Password = tv.PASSWORD;
            RegistrationSuccessful?.Invoke(this, EventArgs.Empty);
            this.Close();
        }
    }
}