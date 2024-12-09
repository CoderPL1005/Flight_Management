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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace FLIGHT.Support_Form
{
    public partial class frmCalendar : DevExpress.XtraEditors.XtraForm
    {
        public frmCalendar()
        {
            InitializeComponent();
        }
        string loaiChuyenBay;
        int countSoNgayDaChon = 1;
        Label txtkhoihanh;
        Label txttrove;
        Panel panthoigian;
        public frmCalendar(string loaiChuyenBay, Label txtkhoihanh,Label txttrove, Panel panthoigian)
        {
            InitializeComponent();
            this.loaiChuyenBay = loaiChuyenBay;
            this.txtkhoihanh = txtkhoihanh;
            this.txttrove = txttrove;
            this.panthoigian = panthoigian;
        }

        int months = DateTime.Now.Month - 1;
        int months2 = DateTime.Now.Month;
        int years = DateTime.Now.Year;
        string dateLeft = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
        string dateRight = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" +DateTime.Now.Year;
        void DisplayfirstMonth()
        {
            if (months == 12)
            {
                months = 0;
            }
            months += 1;
            string monthText = TextMonth(months);
            cal1Text.Text = monthText + " " + years;
            DateTime startoftheMonth = new DateTime(years, months, 1);
            int days = DateTime.DaysInMonth(years, months);
            int dayoftheWeek = (int)startoftheMonth.DayOfWeek + 1;

            DateTime today = DateTime.Now;

            for (int i = 1; i < dayoftheWeek; i++)
            {
                UserControl1 user = new UserControl1();
                flowLayoutPanel1.Controls.Add(user);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControl2 user2 = new UserControl2();
                user2.Days(i);

                // Kiểm tra nếu ngày là ngày hôm nay và thay đổi màu nền
                if (i == today.Day && months == today.Month && years == today.Year)
                {
                    // Đặt màu nền cho ngày hôm nay
                    foreach (Control label in user2.Controls)
                    {
                        if (label is Label)
                        {
                            label.BackColor = Color.FromArgb(0, 103, 136); // Màu của ngày hôm nay
                        }
                    }
                }

                // Vô hiệu hóa những ngày trước hôm nay
                if (new DateTime(years, months, i) < today)
                {
                    foreach (Control label in user2.Controls)
                    {
                        if (label is Label)
                        {
                            label.Enabled = false; // Vô hiệu hóa các ngày trước hôm nay
                            label.ForeColor = Color.FromArgb(120, 120, 120);
                        }
                    }
                }
                else
                {
                    // Thêm sự kiện Click cho các ngày có thể chọn
                    foreach (Control label in user2.Controls)
                    {
                        if (label is Label)
                        {
                            label.Click += ChonThoiGian;
                        }
                    }
                }

                flowLayoutPanel1.Controls.Add(user2);
            }
        }
        void DisplayNextMonth()
        {
            {
                if (months2 == 12)
                {
                    months2 = 0;
                    years += 1;
                }
                months2 += 1;
                string monthText = TextMonth(months2);
                cal2Text.Text = monthText + " " + years;
                DateTime startoftheMonth = new DateTime(years, months2, 1);
                int days = DateTime.DaysInMonth(years, months2);
                int dayoftheWeek = (int)startoftheMonth.DayOfWeek + 1;

                DateTime today = DateTime.Now;

                for (int i = 1; i < dayoftheWeek; i++)
                {
                    UserControl1 user = new UserControl1();
                    flowLayoutPanel2.Controls.Add(user);
                }

                for (int i = 1; i <= days; i++)
                {
                    UserControl2 user2 = new UserControl2();
                    user2.Days(i);

                    // Kiểm tra nếu ngày là ngày hôm nay và thay đổi màu nền
                    if (i == today.Day && months2 == today.Month && years == today.Year)
                    {
                        foreach (Control label in user2.Controls)
                        {
                            if (label is Label)
                            {
                                label.BackColor = Color.FromArgb(0, 103, 136); // Màu của ngày hôm nay
                            }
                        }
                    }

                    // Vô hiệu hóa những ngày trước hôm nay
                    if (new DateTime(years, months2, i) < today)
                    {
                        foreach (Control label in user2.Controls)
                        {
                            if (label is Label)
                            {
                                label.Enabled = false; // Vô hiệu hóa các ngày trước hôm nay
                                label.BackColor = Color.Gray; // Đặt màu xám cho các ngày không thể chọn
                            }
                        }
                    }
                    else
                    {
                        // Thêm sự kiện Click cho các ngày có thể chọn
                        foreach (Control label in user2.Controls)
                        {
                            if (label is Label)
                            {
                                label.Click += ChonThoiGianRight;
                            }
                        }
                    }

                    flowLayoutPanel2.Controls.Add(user2);
                }
            }
        }
        private void frmCalendar_Load(object sender, EventArgs e)
        {
            DisplayfirstMonth();
            DisplayNextMonth();
            txtKhoiHanh.Text = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            txtTroVe.Text = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            if (loaiChuyenBay == "Khứ hồi")
            {
                txtTroVe.Visible = true;
                labTroVe.Cursor = Cursors.Hand;
            }
            else
            {
                txtTroVe.Visible = false;
                labTroVe.Cursor = Cursors.Default;
            }
        }
        private void cal1Pre_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            DisplayRightMonth();
            DisplayLeftMonth();
        }

        private void cal2Next_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            DisplayfirstMonth();
            DisplayNextMonth();
        }

        void DisplayLeftMonth()
        {
            if (months == 1)
            {
                months = 13;
            }
            months = months - 1;
            string monthText = TextMonth(months);
            cal1Text.Text = monthText + " " + years;
            DateTime startoftheMonth = new DateTime(years, months, 1);
            int days = DateTime.DaysInMonth(years, months);
            int dayoftheWeek = (int)startoftheMonth.DayOfWeek + 1;

            for (int i = 1; i < dayoftheWeek; i++)
            {
                UserControl1 user = new UserControl1();
                flowLayoutPanel1.Controls.Add(user);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControl2 user2 = new UserControl2();
                user2.Days(i);
                foreach (Control label in user2.Controls)
                {
                    if (label is Label)
                    {
                        label.Click += ChonThoiGian;
                    }
                }
                if (new DateTime(years, months, i) < DateTime.Now)
                {
                    foreach (Control label in user2.Controls)
                    {
                        if (label is Label)
                        {
                            label.Enabled = false; // Vô hiệu hóa các ngày trước hôm nay
                            label.ForeColor = Color.FromArgb(120, 120, 120);
                        }
                    }
                }
                else
                {
                    // Thêm sự kiện Click cho các ngày có thể chọn
                    foreach (Control label in user2.Controls)
                    {
                        if (label is Label)
                        {
                            label.Click += ChonThoiGian;
                        }
                    }
                }
                flowLayoutPanel1.Controls.Add(user2);
                
            }
        }
        void DisplayRightMonth()
        {
            if (months2 == 2)
            {
                months2 -= 1;
                string monthText1 = TextMonth(months2);
                cal2Text.Text = monthText1 + " " + years;
                DateTime startoftheMonth1 = new DateTime(years, months2, 1);
                int days1 = DateTime.DaysInMonth(years, months2);
                int dayoftheWeek1 = (int)startoftheMonth1.DayOfWeek + 1;

                for (int i = 1; i < dayoftheWeek1; i++)
                {
                    UserControl1 user = new UserControl1();
                    flowLayoutPanel2.Controls.Add(user);
                }
                for (int i = 1; i <= days1; i++)
                {
                    UserControl2 user2 = new UserControl2();
                    user2.Days(i);
                    foreach (Control label in user2.Controls)
                    {
                        if (label is Label)
                        {
                            label.Click += ChonThoiGianRight;
                        }
                    }
                    if (new DateTime(years, months, i) < DateTime.Now)
                    {
                        foreach (Control label in user2.Controls)
                        {
                            if (label is Label)
                            {
                                label.Enabled = false; // Vô hiệu hóa các ngày trước hôm nay
                                label.ForeColor = Color.FromArgb(120, 120, 120);
                            }
                        }
                    }
                    else
                    {
                        // Thêm sự kiện Click cho các ngày có thể chọn
                        foreach (Control label in user2.Controls)
                        {
                            if (label is Label)
                            {
                                label.Click += ChonThoiGian;
                            }
                        }
                    }
                    flowLayoutPanel2.Controls.Add(user2);
                }
                months2 = 13;
                years -= 1;
                return;
            }
            months2 = months2 - 1;
            if (months2 == 0)
            {
                months2 = 12;
                years -= 1;
            }
            string monthText = TextMonth(months2);
            cal2Text.Text = monthText + " " + years;
            DateTime startoftheMonth = new DateTime(years, months2, 1);
            int days = DateTime.DaysInMonth(years, months2);
            int dayoftheWeek = (int)startoftheMonth.DayOfWeek + 1;

            for (int i = 1; i < dayoftheWeek; i++)
            {
                UserControl1 user = new UserControl1();
                flowLayoutPanel2.Controls.Add(user);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControl2 user2 = new UserControl2();
                user2.Days(i);
                foreach (Control label in user2.Controls)
                {
                    if (label is Label)
                    {
                        label.Click += ChonThoiGianRight;
                    }
                }
                flowLayoutPanel2.Controls.Add(user2);
            }
        }
        string TextMonth(int monthCheck)
        {
            string monthText = "";
            switch (monthCheck)
            {
                case 1:
                    monthText = "January";
                    break;
                case 2:
                    monthText = "February";
                    break;
                case 3:
                    monthText = "March";
                    break;
                case 4:
                    monthText = "April";
                    break;
                case 5:
                    monthText = "May";
                    break;
                case 6:
                    monthText = "June";
                    break;
                case 7:
                    monthText = "July";
                    break;
                case 8:
                    monthText = "August";
                    break;
                case 9:
                    monthText = "September";
                    break;
                case 10:
                    monthText = "October";
                    break;
                case 11:
                    monthText = "November";
                    break;
                case 12:
                    monthText = "December";
                    break;
            }
            return monthText;
        }

        int NumberMonth(string monthCheck)
        {
            int monthText = 0;
            switch (monthCheck)
            {
                case "January":
                    monthText = 1;
                    break;
                case "February":
                    monthText = 2;
                    break;
                case "March":
                    monthText = 3;
                    break;
                case "April":
                    monthText = 4;
                    break;
                case "May":
                    monthText = 5;
                    break;
                case "June":
                    monthText = 6;
                    break;
                case "July":
                    monthText = 7;
                    break;
                case "August":
                    monthText = 8;
                    break;
                case "September":
                    monthText = 9;
                    break;
                case "October":
                    monthText = 10;
                    break;
                case "November":
                    monthText = 11;
                    break;
                case "December":
                    monthText = 12;
                    break;
            }
            return monthText;
        }

        void ChonThoiGian(object sender, EventArgs e)
        {
                Label days = sender as Label;
                if (days.BackColor == Color.White)
                {
                    days.BackColor = Color.FromArgb(0, 103, 136);
                    countSoNgayDaChon++;
                }
                else
                {
                    days.BackColor = Color.White;
                    countSoNgayDaChon--;
                }
                int day = int.Parse(days.Text);
                string months = cal1Text.Text.Split(' ')[0];
                string years = cal1Text.Text.Split(' ')[1];
                dateLeft = day + "/" + NumberMonth(months) + "/" + years;
                if (loaiChuyenBay == "Một chiều")
                {
                    txtKhoiHanh.Text = dateLeft;
                }
                else
                {
                    if (countSoNgayDaChon == 1)
                    {
                        txtKhoiHanh.Text = dateLeft;
                    }
                    else
                    {
                        DateTime f1 = DateTime.ParseExact(dateLeft, "d/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                        DateTime f2 = DateTime.ParseExact(dateRight, "d/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                        if(f1 < f2)
                        {
                            txtKhoiHanh.Text = f1.ToString();
                            txtTroVe.Text = f2.ToString();
                        }
                        else
                        {
                            txtTroVe.Text = f1.Day + "/" +f1.Month +"/" + f1.Year;
                            txtKhoiHanh.Text = f2.Day +"/" +f2.Month +"/" +f2.Year;
                        }
                    }
                }
        }

        void ChonThoiGianRight(object sender, EventArgs e)
        {
            if (countSoNgayDaChon > 0 && countSoNgayDaChon < 3)
            {
                Label days = sender as Label;
                if (days.BackColor == Color.White)
                {
                    days.BackColor = Color.FromArgb(0, 103, 136);
                    countSoNgayDaChon++;
                }
                else
                {
                    days.BackColor = Color.White;
                    countSoNgayDaChon--;
                }
                int day = int.Parse(days.Text);
                string months = cal2Text.Text.Split(' ')[0];
                string years = cal2Text.Text.Split(' ')[1];
                dateRight = day + "/" + NumberMonth(months) + "/" + years;
                if (loaiChuyenBay == "Một chiều")
                {
                    txtKhoiHanh.Text = dateLeft;
                }
                else
                {
                    if (countSoNgayDaChon == 1)
                    {
                        txtKhoiHanh.Text = dateLeft;
                    }
                    else
                    {
                        DateTime f1 = DateTime.ParseExact(dateLeft, "d/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                        DateTime f2 = DateTime.ParseExact(dateRight, "d/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                        if (f1 < f2)
                        {
                            txtKhoiHanh.Text = f1.ToString();
                            txtTroVe.Text = f2.ToString();
                        }
                        else
                        {
                            txtTroVe.Text = f1.Day + "/" +f1.Month +"/" +f1.Year;
                            txtKhoiHanh.Text = f2.Day +"/" +f2.Month +"/" +f2.Year;
                        }
                    }
                }
            }
        }

        private void txtXacNhan_Click(object sender, EventArgs e)
        {
            txttrove.Text = txtTroVe.Text;
            txtkhoihanh.Text = txtKhoiHanh.Text;
            this.Close();
            panthoigian.Size = new System.Drawing.Size(0, 0);
        }
    }
}