using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TAIKHOANNHANVIEN
    {
        Entities db;

        public TAIKHOANNHANVIEN()
        {
            db = Entities.CreateEntities();
        }

        public List<tb_TAIKHOANNHANVIEN> getAll()
        {
            return db.tb_TAIKHOANNHANVIEN.ToList();
        }

        public List<KeyValuePair<string, string>> getUserPass()
        {
            List<KeyValuePair<string, string>> tmp = new List<KeyValuePair<string, string>>();
            List<tb_TAIKHOANNHANVIEN> tmptk = getAll();
            foreach(var item in tmptk)
            {
                tmp.Add(new KeyValuePair<string, string>(item.USERNAME, item.PASSWORD));
            }
            return tmp;
        }

        public string getIDNhanVien(string username)
        {
            tb_TAIKHOANNHANVIEN tmp = db.tb_TAIKHOANNHANVIEN.FirstOrDefault(x => x.USERNAME == username);
            return tmp.IDNV;
        }
    }
}
