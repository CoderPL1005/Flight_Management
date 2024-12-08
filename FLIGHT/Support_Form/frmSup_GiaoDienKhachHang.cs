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

namespace FLIGHT.Support_Form
{
    public partial class frmSup_GiaoDienKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmSup_GiaoDienKhachHang()
        {
            InitializeComponent();
        }
        SEATS _seats;
        List<tb_SEATS> seats;
        int sokhach = 0;
        private void frmSup_GiaoDienKhachHang_Load(object sender, EventArgs e)
        {
            _seats = new SEATS();
            seats = _seats.getAll();
            loadSeatType();
        }

        void loadSeatType()
        {
            foreach(var item in seats)
            {
                cboLoaiGhe.Items.Add(item.CLASS);
            }
        }

        private void labIncrease_Click(object sender, EventArgs e)
        {
            labDecrease.Enabled = true;
            sokhach = int.Parse(labHanhKhach.Text[0].ToString());
            if (sokhach < 9)
            {
                labIncrease.Enabled = true;
                sokhach++;
                if(sokhach == 9)
                {
                    labIncrease.Enabled = false;
                }
                labHanhKhach.Text = sokhach.ToString() + " hành khách";
            }
            else
            {
                labIncrease.Enabled = false;
            }
        }

        private void labDecrease_Click(object sender, EventArgs e)
        {
            labIncrease.Enabled = true;
            sokhach = int.Parse(labHanhKhach.Text[0].ToString());
            if (sokhach > 1)
            {
                labDecrease.Enabled = true;
                sokhach--;
                if(sokhach == 1)
                {
                    labDecrease.Enabled = false;
                }
                labHanhKhach.Text = sokhach.ToString() + " hành khách";
            }
            else
            {
                labDecrease.Enabled = false;
            }
        }
    }
}