using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class NHANVIEN
    {
        Entities db;
        public NHANVIEN()
        {
            db = Entities.CreateEntities();
        }

        public List<tb_NHANVIEN> getAll()
        {
            return db.tb_NHANVIEN.ToList();
        }

        public string getIDChucVu(string idNhanVien)
        {
            tb_NHANVIEN tmp = db.tb_NHANVIEN.FirstOrDefault(x => x.IDNV == idNhanVien);
            return tmp.IDCHUCVU;
        }
    }
}
