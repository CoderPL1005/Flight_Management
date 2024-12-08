using DataLayer;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PHANQUYEN
    {
        Entities db;
        public PHANQUYEN()
        {
            db = Entities.CreateEntities();
        }
        public List<tb_PhanQuyen> getAll()
        {
            return db.tb_PhanQuyen.ToList();
        }
        public List<string> getIDChucVu()
        {
            List<string> tmp = new List<string>();
            List<tb_PhanQuyen> tmppq = getAll();
            foreach (var cv in tmppq)
            {
                tmp.Add(cv.IDCHUCVU);
            }
            return tmp.Distinct().ToList();
        }

        public void update(tb_PhanQuyen pq)
        { 
            
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }
    }
}
