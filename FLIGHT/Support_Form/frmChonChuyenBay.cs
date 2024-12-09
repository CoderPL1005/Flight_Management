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
    public partial class frmChonChuyenBay : DevExpress.XtraEditors.XtraForm
    {
        public frmChonChuyenBay()
        {
            InitializeComponent();
        }

        string loaiChuyenBay;
        string songuoiloaighe;
        string diemxuatphat;
        string diemden;
        string thoigianxuatphat;
        string thoigianquayve;
        DateTime arrivial_time;
        DateTime depature_time;
        int aircraft_id;
        SEATS _seat;
        AIRCRAFTSEATS _air;
        VEDAT _vedat;
        List<string> aircraftseatid = new List<string>();
        MEMBER _member;
        public frmChonChuyenBay(string loaiChuyenBay, string songuoiloaighe, string diemxuatphat, string diemden, string thoigianxuatphat, string thoigianquayve, DateTime arrivial_time, DateTime depature_time, int aircraft_id)
        {
            InitializeComponent();
            this.loaiChuyenBay = loaiChuyenBay;
            this.songuoiloaighe = songuoiloaighe;
            this.diemden = diemden;
            this.diemxuatphat = diemxuatphat;
            this.thoigianquayve = thoigianquayve;
            this.thoigianxuatphat = thoigianxuatphat;
            this.arrivial_time = arrivial_time;
            this.depature_time = depature_time;
            this.aircraft_id = aircraft_id;
        }

        private void frmChonChuyenBay_Load(object sender, EventArgs e)
        {
            _air = new AIRCRAFTSEATS();
            txtArrivial_Time.Text = depature_time.ToString();
            txtDeparture_time.Text = arrivial_time.ToString();
            txtLoaiGhe.Text = songuoiloaighe.Split(',')[1];
            _seat = new SEATS();
            _air = new AIRCRAFTSEATS();
            int seatID = _seat.getIDByClass(songuoiloaighe.Split(',')[1]);
            tb_AIRCRAFTSEATS tmpaircraft = new tb_AIRCRAFTSEATS();
            tmpaircraft = _air.getAllById(seatID);
            txtGia.Text = tmpaircraft.PRICE.ToString();

            List<tb_AIRCRAFTSEATS> tmp = _air.CountSeat(seatID, aircraft_id);
            txtSoLuong.Text = tmp.Count().ToString();
            _vedat = new VEDAT();
            _member = new MEMBER();
            foreach(var id in tmp)
            {
                aircraftseatid.Add(id.AIRCRAFTSEATSID.ToString());
            }
        }

        private void butChonViTri_Click(object sender, EventArgs e)
        {
                // Lấy số lượng ghế cần chọn
                int soLuongGhe = int.Parse(songuoiloaighe[0].ToString());

                // Kiểm tra số lượng ghế có đủ không
                if (aircraftseatid.Count < soLuongGhe)
                {
                    MessageBox.Show("Không đủ ghế trống để đặt!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tiến hành đặt ghế
                for (int i = 0; i < soLuongGhe; i++)
                {
                    // Tạo bản ghi đặt vé
                    tb_VEDAT vedat = new tb_VEDAT
                    {
                        AIRCRAFTSEATISD = int.Parse(aircraftseatid[i]),
                        EMAIL = _member.getEmailByUserId(UserSession.Username), // Lấy email của người dùng đăng nhập
                        TRANGTHAI = "Đã đăng ký"
                    };
                    _vedat.add(vedat);

                // Cập nhật trạng thái ghế
                tb_AIRCRAFTSEATS seat = _air.getAllBySeat(int.Parse(aircraftseatid[i].ToString()));
                    seat.AIRCRAFT_ID = seat.AIRCRAFT_ID;
                    seat.SEATS_ID = seat.SEATS_ID;
                    seat.SEAT_NUMBER = seat.SEAT_NUMBER;
                    seat.PRICE = seat.PRICE;
                    seat.DISABLED = true; // Đánh dấu ghế không còn trống
                    _air.update(seat);
                }

                MessageBox.Show("Đặt ghế thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật lại số lượng ghế hiển thị
                List<tb_AIRCRAFTSEATS> tmp = _air.CountSeat(
                    _seat.getIDByClass(songuoiloaighe.Split(',')[1]),
                    aircraft_id);
                txtSoLuong.Text = tmp.Count.ToString();
        }
    }
}