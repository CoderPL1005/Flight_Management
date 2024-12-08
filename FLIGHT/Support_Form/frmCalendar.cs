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

namespace FLIGHT.Support_Form
{
    public partial class frmCalendar : DevExpress.XtraEditors.XtraForm
    {
        public frmCalendar()
        {
            InitializeComponent();
        }
        int months = DateTime.Now.Month - 1;
        int months2 = DateTime.Now.Month;
        int years = DateTime.Now.Year;
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

            for (int i = 1; i < dayoftheWeek; i++)
            {
                UserControl1 user = new UserControl1();
                flowLayoutPanel1.Controls.Add(user);


            }
            for (int i = 1; i <= days; i++)
            {
                UserControl2 user2 = new UserControl2();
                user2.Days(i);
                flowLayoutPanel1.Controls.Add(user2);
            }

        }
        void DisplayNextMonth()
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

            for (int i = 1; i < dayoftheWeek; i++)
            {
                UserControl1 user = new UserControl1();
                flowLayoutPanel2.Controls.Add(user);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControl2 user2 = new UserControl2();
                user2.Days(i);
                flowLayoutPanel2.Controls.Add(user2);
            }

        }
    }
}