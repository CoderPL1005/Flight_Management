using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AIRPORT
    {
        Entities db;

        public AIRPORT()
        {
            db = Entities.CreateEntities();
        }

        public List<tb_AIRPORTS> getAll()
        {
            return db.tb_AIRPORTS.ToList();
        }


        public void add(tb_AIRPORTS airports)
        {
            try
            {
                db.tb_AIRPORTS.Add(airports);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }


        public void delete(int id)
        {
            tb_AIRPORTS tv = db.tb_AIRPORTS.OrderByDescending(x => x.AIRPORT_ID == id).FirstOrDefault();
            db.tb_AIRPORTS.Remove(tv);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }

        public tb_AIRPORTS getAllById(int id)
        {
            tb_AIRPORTS tmp = db.tb_AIRPORTS.FirstOrDefault(x => x.AIRPORT_ID == id);
            return tmp;
        }

        public void update(tb_AIRPORTS airports)
        {
            tb_AIRPORTS _airports = db.tb_AIRPORTS.FirstOrDefault(x => x.AIRPORT_ID == airports.AIRPORT_ID);
            _airports.AIPORT_NAME = airports.AIPORT_NAME;
            _airports.CITY = airports.CITY;
            _airports.COUNTRY = airports.COUNTRY;
            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Có lỗi trong quá trình xử lý" + e.Message);
            }
        }

        public int getIDAirport(string AirportName)
        {
            return db.tb_AIRPORTS.FirstOrDefault(x => x.CITY == AirportName).AIRPORT_ID;
        }

        public string getAirportName(int id)
        {
            return db.tb_AIRPORTS.FirstOrDefault(x => x.AIRPORT_ID == id).AIPORT_NAME.ToString();
        }

        public List<String> getAllCity()
        {
            List<tb_AIRPORTS> tmpAir = getAll();
            List<String> tmp = new List<string>();
            foreach(var air in tmpAir)
            {
                tmp.Add(air.CITY);
            }
            return tmp;
        }
    }
}
