using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class FLlight
    {
        Entities db;

        public FLlight()
        {
            db = Entities.CreateEntities();
        }

        public List<tb_FLIGHT> getAll()
        {
            return db.tb_FLIGHT.ToList();
        }


        public void add(tb_FLIGHT flights)
        {
            try
            {
                db.tb_FLIGHT.Add(flights);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }


        public void delete(int id)
        {
            tb_FLIGHT tv = db.tb_FLIGHT.OrderByDescending(x => x.ID_FLIGHT == id).FirstOrDefault();
            db.tb_FLIGHT.Remove(tv);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }

        public tb_FLIGHT getAllById(int id)
        {
            tb_FLIGHT tmp = db.tb_FLIGHT.FirstOrDefault(x => x.ID_FLIGHT == id);
            return tmp;
        }

        public void update(tb_FLIGHT flights)
        {
            tb_FLIGHT _flights = db.tb_FLIGHT.FirstOrDefault(x => x.ID_FLIGHT == flights.ID_FLIGHT);
            _flights.FLIGHT_ID = flights.FLIGHT_ID;
            _flights.AIRCRAFT_ID = flights.AIRCRAFT_ID;
            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Có lỗi trong quá trình xử lý" + e.Message);
            }
        }

        public List<tb_FLIGHT> getAllByflightId(int id)
        {
            return db.tb_FLIGHT.Where(x => x.FLIGHT_ID == id).ToList();
        }

        public List<tb_FLIGHT> getAllByAircraftID(int id)
        {
            return db.tb_FLIGHT.Where(x => x.AIRCRAFT_ID == id).ToList();
        }
    }
}
