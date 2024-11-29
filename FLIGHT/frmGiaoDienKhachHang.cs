using BusinessLayer;
using DevExpress.Utils.ScrollAnnotations;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THUEPHONG;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace FLIGHT
{
    public partial class frmGiaoDienKhachHang : DevExpress.XtraEditors.XtraForm
    {
        string Username;
        string Password;
        MEMBER _member;
        public frmGiaoDienKhachHang()
        {
            InitializeComponent();
        }
        public frmGiaoDienKhachHang(string username, string password)
        {
            InitializeComponent();
            this.Username = username;
            this.Password = password;
        }
        private void frmGiaoDienKhachHang_Load(object sender, EventArgs e)
        {
            _member = new MEMBER();
        }
        private void butDangNhap_Click(object sender, EventArgs e)
        {
            if (UserSession.Username is null)
            {
                frmDangNhap frmdn = new frmDangNhap();
                panMain.Controls.Clear();
                frmdn.TopLevel = false;
                frmdn.Height = panMain.Height;
                frmdn.Width = panMain.Width;
                panMain.Controls.Add(frmdn);
                frmdn.Show();
                frmdn.RegistrationSuccessful += Frmdk_RegistrationSuccessful;
            }
            else
            {
                butDangKy.Visible = false;
                butDangNhap.Visible = false;
                toolStripSeparator2.Visible = false;
                toolStripSeparator1.Visible = false;
                butMain.Visible = true;
                string ImagePart = _member.getImagePart(UserSession.Username);
                if (!string.IsNullOrEmpty(ImagePart))
                {
                    string appDirectory = Application.StartupPath;
                    string fullImagePath = Path.Combine(appDirectory, ImagePart);

                    if (File.Exists(fullImagePath))
                    {
                        butMain.Image = Image.FromFile(fullImagePath);
                        butMain.DisplayStyle = ToolStripItemDisplayStyle.Image;
                    }
                    else
                    {
                        // Nếu không có ảnh, fallback về ký tự đầu tên
                        butMain.DisplayStyle = ToolStripItemDisplayStyle.Text;
                        butMain.Text = UserSession.Username[0].ToString().ToUpper();
                    }
                }
            }
        }

        private void butDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy frmdk = new frmDangKy();
            panMain.Controls.Clear();
            frmdk.TopLevel = false;
            frmdk.Height = panMain.Height;
            frmdk.Width = panMain.Width;
            panMain.Controls.Add(frmdk);
            frmdk.Show();
            frmdk.RegistrationSuccessful += Frmdk_RegistrationSuccessful;
        }
        private void Frmdk_RegistrationSuccessful(object sender, EventArgs e)
        {
            butDangKy.Visible = false;
            butDangNhap.Visible = false;
            toolStripSeparator2.Visible = false;
            toolStripSeparator1.Visible = false;
            butMain.Visible = true;
            string ImagePart = _member.getImagePart(UserSession.Username);
            if (ImagePart == "")
            {
                butMain.DisplayStyle = ToolStripItemDisplayStyle.Text;
                butMain.Text = UserSession.Username[0].ToString().ToUpper();
            }
            else
            {
                try
                {
                    // Xây dựng đường dẫn đầy đủ đến file ảnh
                    string appDirectory = Application.StartupPath;
                    string fullImagePath = Path.Combine(appDirectory, ImagePart);

                    if (File.Exists(fullImagePath))
                    {
                        // Tải ảnh và gán vào butMain
                        butMain.Image = Image.FromFile(fullImagePath);
                        butMain.DisplayStyle = ToolStripItemDisplayStyle.Image;
                    }
                    else
                    {
                        // Nếu ảnh không tồn tại, fallback về hiển thị text
                        butMain.DisplayStyle = ToolStripItemDisplayStyle.Text;
                        butMain.Text = UserSession.Username[0].ToString().ToUpper();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải ảnh: {ex.Message}");
                    // Fallback về hiển thị text nếu có lỗi
                    butMain.DisplayStyle = ToolStripItemDisplayStyle.Text;
                    butMain.Text = UserSession.Username[0].ToString().ToUpper();
                }
            }
        }
        private void butMain_Click(object sender, EventArgs e)
        {
            if(panel1.Visible == false)
            {
                panel1.Visible = true;
                panel1.BringToFront();
            }
            else
            {
                panel1.Visible = false;
            }
        }

        private void butDangXuat_Click(object sender, EventArgs e)
        {
            butDangNhap.Visible = true;
            butDangKy.Visible = true;
            toolStripSeparator1.Visible = true;
            toolStripSeparator2.Visible = true;
            butMain.Visible = false;
            panel1.Visible = false;
        }

        private void butAnh_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Chỉ cho phép chọn các tệp ảnh
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            // Mở hộp thoại và kiểm tra xem người dùng đã chọn tệp chưa
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string appDirectory = Application.StartupPath;
                string avatarDirectory = Path.Combine(appDirectory, "Avatars");

                // Đảm bảo thư mục Avatars tồn tại
                if (!Directory.Exists(avatarDirectory))
                {
                    Directory.CreateDirectory(avatarDirectory);
                }

                // Sao chép ảnh vào thư mục Avatars
                string fileName = Path.GetFileName(openFileDialog.FileName);
                string newPath = Path.Combine(avatarDirectory, fileName);
                File.Copy(openFileDialog.FileName, newPath, true);

                // Lưu đường dẫn tương đối vào cơ sở dữ liệu
                string relativePath = $"Avatars/{fileName}";
                _member.updateAvatar(UserSession.Username, relativePath);

                // Hiển thị ảnh đại diện
                butMain.DisplayStyle = ToolStripItemDisplayStyle.Image;
                butMain.Image = Image.FromFile(openFileDialog.FileName);
            }
            
        }
        private void butThongTin_Click(object sender, EventArgs e)
        {
            frmThongTin frmtt = new frmThongTin();
            panMain.Controls.Clear();
            frmtt.TopLevel = false;
            frmtt.Height = panMain.Height;
            frmtt.Width = panMain.Width;
            panMain.Controls.Add(frmtt);
            frmtt.Show();
        }

        private void butVeDat_Click(object sender, EventArgs e)
        {
            frmVeDat frmvd = new frmVeDat();
            panMain.Controls.Clear();
            frmvd.TopLevel = false;
            frmvd.Height = panMain.Height;
            frmvd.Width = panMain.Width;
            panMain.Controls.Add(frmvd);
            frmvd.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            panMain.Controls.Clear();
            panDatVe.Show();
        }

        private void butDatVe_Click(object sender, EventArgs e)
        {
            panMain.Controls.Clear();
        }

        private void dropDownButton1_Click(object sender, EventArgs e)
        {
            panSoKhach.Show();
        }
    }
}