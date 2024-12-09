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
    public partial class frmSup_VeDat : DevExpress.XtraEditors.XtraForm
    {
        public frmSup_VeDat()
        {
            InitializeComponent();
        }
        string idvedat;
        string aircraftseatid;
        AIRCRAFTSEATS _air;
        FLlight _flight;
        VEDAT _vedat;
        public frmSup_VeDat(string idvedat, string aircraftseatid)
        {
            InitializeComponent();
            this.idvedat = idvedat;
            this.aircraftseatid = aircraftseatid;
        }
        private void frmSup_VeDat_Load(object sender, EventArgs e)
        {
            _flight = new FLlight();
            _vedat = new VEDAT();
            _air = new AIRCRAFTSEATS();
            txtIDVe.Text = idvedat;
            tb_AIRCRAFTSEATS tmp = _air.getAllBySeat(int.Parse(aircraftseatid));
            txtAicraftId.Text = tmp.AIRCRAFT_ID.ToString();
            txtGia.Text = tmp.PRICE.ToString();
            List<tb_FLIGHT> tmpflight = _flight.getAllByAircraftID(int.Parse(tmp.AIRCRAFT_ID.ToString()));
            foreach(var tmpf in tmpflight)
            {
                txtArrivalTime.Text = tmpf.ARRIVAL_TIME.ToString();
                txtDepatureTime.Text = tmpf.DEPARTURE_TIME.ToString();
                txtDate.Text = tmpf.DATE.ToString();
            }
        }


        private void butHuy_Click(object sender, EventArgs e)
        {
            _vedat.delete(int.Parse(txtIDVe.Text));
            this.Dispose();
        }

    }
}