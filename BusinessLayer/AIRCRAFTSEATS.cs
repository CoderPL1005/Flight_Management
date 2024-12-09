using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AIRCRAFTSEATS
    {
        Entities db;

        public AIRCRAFTSEATS()
        {
            db = Entities.CreateEntities();
        }

        public List<tb_AIRCRAFTSEATS> getAll()
        {
            return db.tb_AIRCRAFTSEATS.ToList();
        }


        public void add(tb_AIRCRAFTSEATS seat)
        {
            try
            {
                db.tb_AIRCRAFTSEATS.Add(seat);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }


        public void delete(int id)
        {
            tb_AIRCRAFTSEATS seat = db.tb_AIRCRAFTSEATS.OrderByDescending(x => x.AIRCRAFTSEATSID == id).FirstOrDefault();
            db.tb_AIRCRAFTSEATS.Remove(seat);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }

        public tb_AIRCRAFTSEATS getAllById(int id)
        {
            tb_AIRCRAFTSEATS tmp = db.tb_AIRCRAFTSEATS.FirstOrDefault(x => x.SEATS_ID == id);
            return tmp;
        }

        public tb_AIRCRAFTSEATS getAllBySeat(int id)
        {
            return db.tb_AIRCRAFTSEATS.FirstOrDefault(x => x.AIRCRAFTSEATSID == id);
        }

        public void update(tb_AIRCRAFTSEATS seat)
        {
            tb_AIRCRAFTSEATS _seat = db.tb_AIRCRAFTSEATS.FirstOrDefault(x => x.AIRCRAFTSEATSID == seat.AIRCRAFTSEATSID);
            _seat.AIRCRAFT_ID = seat.AIRCRAFT_ID;
            _seat.SEATS_ID = seat.SEATS_ID;
            _seat.SEAT_NUMBER = seat.SEAT_NUMBER;
            _seat.PRICE = seat.PRICE;
            _seat.DISABLED = seat.DISABLED;
            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Có lỗi trong quá trình xử lý" + e.Message);
            }
        }

        public string GetNewSeatNumber(string Class)
        {
            string prefix = Class[0].ToString();

            var latestSeatNumber = db.tb_AIRCRAFTSEATS.Where(x => x.SEAT_NUMBER.StartsWith(prefix)).OrderByDescending(x => x.SEAT_NUMBER).FirstOrDefault();
            if (latestSeatNumber != null)
            {
                int latestID = int.Parse(latestSeatNumber.SEAT_NUMBER.Substring(1)); // Bỏ qua hai ký tự đầu tiên và lấy phần số
                string newID = prefix + (latestID + 1).ToString(); // Format mã nhân viên bắt đầu bằng chữ "NV" và đủ 5 ký tự số
                return newID;
            }
            else
            {
                return prefix + "1";
            }
        }

        public List<tb_AIRCRAFTSEATS> CountSeat(int Seat_id, int aircraft_id)
        {
            return db.tb_AIRCRAFTSEATS.Where(x => x.SEATS_ID == Seat_id && x.AIRCRAFT_ID == aircraft_id).ToList();
        }
    }
}
