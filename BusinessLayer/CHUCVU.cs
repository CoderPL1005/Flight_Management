using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CHUCVU
    {
        Entities db;

        public CHUCVU()
        {
            db = Entities.CreateEntities();
        }

        public List<tb_CHUCVU> getAll()
        {
            return db.tb_CHUCVU.ToList();
        }
    }
}
