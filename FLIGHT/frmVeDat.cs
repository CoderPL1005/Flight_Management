using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using FLIGHT.Support_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLIGHTS
{
    public partial class frmVeDat : DevExpress.XtraEditors.XtraForm
    {
        public frmVeDat()
        {
            InitializeComponent();
        }
        MEMBER _member;
        VEDAT _vedat;
        private void frmVeDat_Load(object sender, EventArgs e)
        {
            _member = new MEMBER();
            _vedat = new VEDAT();
            string email = _member.getEmailByUserId(UserSession.Username);
            List<tb_VEDAT> tmp = _vedat.getAllByEmail(email);
            int yLocation = 0;
            foreach(var item in tmp)
            {
                frmSup_VeDat frm = new frmSup_VeDat(item.IDVEDAT.ToString(), item.AIRCRAFTSEATISD.ToString());
                frm.TopLevel = false;
                frm.Width = panel1.Width;
                panel1.Controls.Add(frm);
                frm.Location = new Point(0, yLocation);
                frm.Show();
                yLocation += frm.Height;
            }
        }
    }
}