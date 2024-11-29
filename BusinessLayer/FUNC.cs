using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class FUNC
    {
        Entities db;
        public FUNC()
        {
            db = Entities.CreateEntities();
        }
        public List<tb_FUNC> getParent()
        {
            return db.tb_FUNC.Where(x => x.IGROUP == true && x.MENU == true).OrderBy(s => s.SORT).ToList();
        }
        public List<tb_FUNC> getChild(string parent)
        {
            return db.tb_FUNC.Where(x => x.IGROUP == false && x.MENU == true && x.PARENT == parent).OrderBy(s => s.SORT).ToList();
        }
        public List<tb_FUNC> getChild()
        {
            return db.tb_FUNC.Where(x => x.PARENT != null).ToList();
        }
        public List<string> getDescription()
        {
            List<string> tmp = new List<string>();
            List<tb_FUNC> tmpf = db.tb_FUNC.Where(x => x.PARENT != null).ToList();
            foreach (var f in tmpf)
            {
                tmp.Add(f.DESCRIPTION);
            }
            return tmp;
        }
        public string getFunccode(string description)
        {
            tb_FUNC tmp = db.tb_FUNC.FirstOrDefault(x => x.DESCRIPTION == description);
            return tmp.FUNC_CODE;
        }
        public string getDescription(string funccode)
        {
            tb_FUNC tmp = db.tb_FUNC.FirstOrDefault(x => x.FUNC_CODE == funccode);
            return tmp.DESCRIPTION;
        }
    }
}
