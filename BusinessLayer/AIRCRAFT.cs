using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AIRCRAFT
    {
        Entities db;

        public AIRCRAFT()
        {
            db = Entities.CreateEntities();
        }

        public List<tb_AIRCRAFT> getAll()
        {
            return db.tb_AIRCRAFT.ToList();
        }


        public void add(tb_AIRCRAFT aircrafts)
        {
            try
            {
                db.tb_AIRCRAFT.Add(aircrafts);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }


        public void delete(int id)
        {
            tb_AIRCRAFT tv = db.tb_AIRCRAFT.OrderByDescending(x => x.AIRCRAFT_ID == id).FirstOrDefault();
            db.tb_AIRCRAFT.Remove(tv);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }

        public tb_AIRCRAFT getAllById(int id)
        {
            tb_AIRCRAFT tmp = db.tb_AIRCRAFT.FirstOrDefault(x => x.AIRCRAFT_ID == id);
            return tmp;
        }

        public void update(tb_AIRCRAFT aircrafts)
        {
            tb_AIRCRAFT _aircrafts = db.tb_AIRCRAFT.FirstOrDefault(x => x.AIRCRAFT_ID == aircrafts.AIRCRAFT_ID);
            _aircrafts.MODEL = aircrafts.MODEL;
            _aircrafts.CAPACITY = aircrafts.CAPACITY;
            _aircrafts.MANUFACTURER = aircrafts.MANUFACTURER;
            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Có lỗi trong quá trình xử lý" + e.Message);
            }
        }
    }
}
