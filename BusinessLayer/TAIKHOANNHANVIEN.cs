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


        public string getIDTaiKhoanByUsername(string username)
        {
            return db.tb_TAIKHOANNHANVIEN.FirstOrDefault(x => x.USERNAME == username).IDTAIKHOAN;
        }


        public tb_TAIKHOANNHANVIEN getAllByIDTaiKhoan(string ID)
        {
            return db.tb_TAIKHOANNHANVIEN.FirstOrDefault(x => x.IDTAIKHOAN == ID);
        }

        public void update(tb_TAIKHOANNHANVIEN nhanvien)
        {
            tb_TAIKHOANNHANVIEN _nhanvien = db.tb_TAIKHOANNHANVIEN.FirstOrDefault(x => x.IDTAIKHOAN == nhanvien.IDTAIKHOAN);
            _nhanvien.USERNAME = nhanvien.USERNAME;
            _nhanvien.PASSWORD = nhanvien.PASSWORD;
            _nhanvien.IDNV = nhanvien.IDNV;
            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Có lỗi trong quá trình xử lý" + e.Message);
            }
        }

        public void delete(string id)
        {
            tb_TAIKHOANNHANVIEN tv = db.tb_TAIKHOANNHANVIEN.OrderByDescending(x => x.IDTAIKHOAN == id).FirstOrDefault();
            db.tb_TAIKHOANNHANVIEN.Remove(tv);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }
        public void add(tb_TAIKHOANNHANVIEN nhanviens)
        {
            try
            {
                db.tb_TAIKHOANNHANVIEN.Add(nhanviens);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }
        public tb_TAIKHOANNHANVIEN getAllById(string id)
        {
            tb_TAIKHOANNHANVIEN tmp = db.tb_TAIKHOANNHANVIEN.FirstOrDefault(x => x.IDTAIKHOAN == id);
            return tmp;
        }
    }
}
