using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SEATS { 
        Entities db;

        public SEATS()
        {
            db = Entities.CreateEntities();
        }

        public List<tb_SEATS> getAll()
        {
            return db.tb_SEATS.ToList();
        }


        public void add(tb_SEATS seat)
        {
            try
            {
                db.tb_SEATS.Add(seat);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }


        public void delete(int id)
        {
            tb_SEATS seat = db.tb_SEATS.OrderByDescending(x => x.SEAT_ID == id).FirstOrDefault();
            db.tb_SEATS.Remove(seat);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }

        public tb_SEATS getAllById(int id)
        {
            tb_SEATS tmp = db.tb_SEATS.FirstOrDefault(x => x.SEAT_ID == id);
            return tmp;
        }

        public void update(tb_SEATS seat)
        {
            tb_SEATS _seat = db.tb_SEATS.FirstOrDefault(x => x.SEAT_ID == seat.SEAT_ID);
            _seat.CLASS = seat.CLASS;
            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Có lỗi trong quá trình xử lý" + e.Message);
            }
        }

        public int CountSeatTypeTotal()
        {
            List<tb_SEATS> tmpSeatCount = getAll();
            return tmpSeatCount.Count;
        }

        public int getIDByClass(string Class)
        {
            return db.tb_SEATS.FirstOrDefault(x => x.CLASS == Class).SEAT_ID;
        }
    }
}
