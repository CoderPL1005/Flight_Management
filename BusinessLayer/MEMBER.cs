using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class MEMBER
    {
        Entities db;
        
        public MEMBER()
        {
            db = Entities.CreateEntities();
        }

        public List<tb_Member> getAll()
        {
            return db.tb_Member.ToList();
        }

        public List<string> getEmail()
        {
            List<tb_Member> tmpMember = getAll();
            List<string> tmp = new List<string>();
            foreach(var member in tmpMember)
            {
                tmp.Add(member.EMAIL);
            }
            return tmp;
        }

        public string getImagePart(string USERID)
        {
            tb_Member tmp = db.tb_Member.FirstOrDefault(x => x.USERID == USERID);
            return tmp.IMAGE_PART;
        }
        public List<string> getUserID()
        {
            List<tb_Member> tmpMember = getAll();
            List<string> tmp = new List<string>();
            foreach (var member in tmpMember)
            {
                tmp.Add(member.USERID);
            }
            return tmp;
        }

        public void add(tb_Member tv)
        {
            try
            {
                db.tb_Member.Add(tv);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }

        public bool CheckPassWord(string userID, string password)
        {
            List<tb_Member> tv = getAll();
            foreach (var thanhvien in tv)
            {
                if (thanhvien.USERID == userID)
                {
                    if (thanhvien.PASSWORD == password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public tb_Member getAllByUserId(string userID)
        {
            tb_Member tmp = db.tb_Member.FirstOrDefault(x => x.USERID == userID);
            return tmp;
        }
        public void updateAvatar(string USERID, string IMAGE_PART)
        {
            tb_Member _tv = db.tb_Member.FirstOrDefault(x => x.USERID == USERID);
            _tv.IMAGE_PART = IMAGE_PART;
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
            tb_Member tv = db.tb_Member.OrderByDescending(x => x.USERID == id).FirstOrDefault();
            db.tb_Member.Remove(tv);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }
    }
}
