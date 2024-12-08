using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class FLIGHT_SCHEDULE { 
        Entities db;

        public FLIGHT_SCHEDULE()
        {
            db = Entities.CreateEntities();
        }

        public List<tb_FLIGHT_SCHEDULES> getAll()
        {
            return db.tb_FLIGHT_SCHEDULES.ToList();
        }


        public void add(tb_FLIGHT_SCHEDULES flights)
        {
            try
            {
                db.tb_FLIGHT_SCHEDULES.Add(flights);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }


        public void delete(int id)
        {
            tb_FLIGHT_SCHEDULES tv = db.tb_FLIGHT_SCHEDULES.OrderByDescending(x => x.FLIGHT_ID == id).FirstOrDefault();
            db.tb_FLIGHT_SCHEDULES.Remove(tv);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }

        public tb_FLIGHT_SCHEDULES getAllById(int id)
        {
            tb_FLIGHT_SCHEDULES tmp = db.tb_FLIGHT_SCHEDULES.FirstOrDefault(x => x.FLIGHT_ID == id);
            return tmp;
        }

        public void update(tb_FLIGHT_SCHEDULES flights)
        {
            tb_FLIGHT_SCHEDULES _flights = db.tb_FLIGHT_SCHEDULES.FirstOrDefault(x => x.FLIGHT_ID == flights.FLIGHT_ID);
            _flights.ORIGIN_AIRPORT_ID = flights.ORIGIN_AIRPORT_ID;
            _flights.DESTINATION_AIRPORT_ID = flights.DESTINATION_AIRPORT_ID;
            _flights.FLIGHT_STATUS = flights.FLIGHT_STATUS;
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
