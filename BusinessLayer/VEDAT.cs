using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class VEDAT
    {
        Entities db;

        public VEDAT()
        {
            db = Entities.CreateEntities();
        }

        public List<tb_VEDAT> getAll()
        {
            return db.tb_VEDAT.ToList();
        }


        public void add(tb_VEDAT vedat)
        {
            try
            {
                db.tb_VEDAT.Add(vedat);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }


        public void delete(int id)
        {
            tb_VEDAT tv = db.tb_VEDAT.OrderByDescending(x => x.IDVEDAT == id).FirstOrDefault();
            db.tb_VEDAT.Remove(tv);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }

        public void update(tb_VEDAT nhanviens)
        {
            tb_VEDAT _nhanvien = db.tb_VEDAT.FirstOrDefault(x => x.IDVEDAT == nhanviens.IDVEDAT);
            _nhanvien.AIRCRAFTSEATISD = nhanviens.AIRCRAFTSEATISD;
            _nhanvien.EMAIL = nhanviens.EMAIL;
            _nhanvien.TRANGTHAI = nhanviens.TRANGTHAI;
            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Có lỗi trong quá trình xử lý" + e.Message);
            }
        }
        public tb_VEDAT getAllByID(int id)
        {
            return db.tb_VEDAT.FirstOrDefault(x => x.IDVEDAT == id);
        }

        public List<tb_VEDAT> getAllByEmail(string email)
        {
            return db.tb_VEDAT.Where(x => x.EMAIL == email).ToList();
        }
    }
}
