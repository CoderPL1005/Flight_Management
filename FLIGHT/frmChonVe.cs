
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
using FLIGHTS;
using FLIGHT.Support_Form;

namespace FLIGHTS
{
    public partial class frmChonVe : DevExpress.XtraEditors.XtraForm
    {
        public frmChonVe()
        {
            InitializeComponent();
        }
        string loaiChuyenBay;
        string songuoiloaighe;
        string diemxuatphat;
        string diemden;
        string thoigianxuatphat;
        string thoigianquayve;
        public frmChonVe(string loaiChuyenBay, string songuoiloaighe, string diemxuatphat, string diemden, string thoigianxuatphat, string thoigianquayve)
        {
            this.loaiChuyenBay = loaiChuyenBay;
            this.songuoiloaighe = songuoiloaighe;
            this.diemden = diemden;
            this.diemxuatphat = diemxuatphat;
            this.thoigianquayve = thoigianquayve;
            this.thoigianxuatphat = thoigianxuatphat;
            InitializeComponent();
        }
        FLIGHT_SCHEDULE _flight_schedule;
        AIRPORT _airport;
        FLlight _flight;
        private void frmChonVe_Load(object sender, EventArgs e)
        {
            _flight_schedule = new FLIGHT_SCHEDULE();
            _airport = new AIRPORT();
            _flight = new FLlight();
            loadChuyenBayThoaMan();
        }

        void loadChuyenBayThoaMan()
        {

            int IDSanBayxuatPhat = _airport.getIDAirport(diemxuatphat);
            int IDSanBayDen = _airport.getIDAirport(diemden);
            List<tb_FLIGHT_SCHEDULES> ChuyenBayThoaManDiaDiem = _flight_schedule.getAllFlyStartWithID(IDSanBayxuatPhat, IDSanBayDen);
            List<tb_FLIGHT> ChuyenBayThoaManThoiGian = new List<tb_FLIGHT>();
            foreach(var item in ChuyenBayThoaManDiaDiem)
            {
                List<tb_FLIGHT> tmp = _flight.getAllByflightId(item.FLIGHT_ID);
                foreach(var item2 in tmp)
                {
                    DateTime tmpdate = DateTime.Parse(item2.DATE.ToString());
                    if((tmpdate.Day +"/"+tmpdate.Month+"/"+tmpdate.Year) == thoigianxuatphat){
                        ChuyenBayThoaManThoiGian.Add(item2);
                    }
                }
            }
            int yLocation = 0;
            foreach(var flight in ChuyenBayThoaManThoiGian)
            {
                var flightDetails = flight; // Lưu giá trị trong vòng lặp để tránh vấn đề closure
                Task.Run(() =>
                {
                    frmChonChuyenBay frm = new frmChonChuyenBay(
                        loaiChuyenBay,
                        songuoiloaighe,
                        diemxuatphat,
                        diemden,
                        thoigianxuatphat,
                        thoigianquayve,
                        DateTime.Parse(flightDetails.ARRIVAL_TIME.ToString()),
                        DateTime.Parse(flightDetails.DEPARTURE_TIME.ToString()),
                        int.Parse(flightDetails.AIRCRAFT_ID.ToString()));

                    frm.TopLevel = false;
                    frm.Width = panel1.Width;
                    frm.Location = new Point(0, yLocation);
                    yLocation += frm.Height;
                    Invoke(new Action(() =>
                    {
                        panel1.Controls.Add(frm);
                        
                        frm.Show();
                    }));
                });
            }
        }
    }
}