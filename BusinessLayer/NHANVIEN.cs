using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
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


        public void add(tb_NHANVIEN nhanviens)
        {
            try
            {
                db.tb_NHANVIEN.Add(nhanviens);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }


        public void delete(string id)
        {
            tb_NHANVIEN tv = db.tb_NHANVIEN.OrderByDescending(x => x.IDNV == id).FirstOrDefault();
            db.tb_NHANVIEN.Remove(tv);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }

        public tb_NHANVIEN getAllById(string id)
        {
            tb_NHANVIEN tmp = db.tb_NHANVIEN.FirstOrDefault(x => x.IDNV == id);
            return tmp;
        }

        public void update(tb_NHANVIEN nhanviens)
        {
            tb_NHANVIEN _nhanvien = db.tb_NHANVIEN.FirstOrDefault(x => x.IDNV == nhanviens.IDNV);
            _nhanvien.HOTEN = nhanviens.HOTEN;
            _nhanvien.DIENTHOAI = nhanviens.DIENTHOAI;
            _nhanvien.EMAIL = nhanviens.EMAIL;
            _nhanvien.GIOITINH = nhanviens.GIOITINH;
            _nhanvien.NGAYSINH = nhanviens.NGAYSINH;
            _nhanvien.DIACHI = nhanviens.DIACHI;
            _nhanvien.NGAYVAOLAM = nhanviens.NGAYVAOLAM;
            _nhanvien.IDCHUCVU = nhanviens.IDCHUCVU;
            _nhanvien.DISABLED = nhanviens.DISABLED;
            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Có lỗi trong quá trình xử lý" + e.Message);
            }
        }
        public string GetNewID()
        {
            var latestNhanVien = db.tb_NHANVIEN.OrderByDescending(x => x.IDNV).FirstOrDefault();
            if (latestNhanVien != null)
            {
                int latestID = int.Parse(latestNhanVien.IDNV.Substring(2)); // Bỏ qua hai ký tự đầu tiên (chữ "NV") và lấy phần số
                string newID = "NV" + (latestID + 1).ToString().PadLeft(5, '0'); // Format mã nhân viên bắt đầu bằng chữ "NV" và đủ 5 ký tự số
                return newID;
            }
            else
            {
                // Trường hợp không có nhân viên nào trong cơ sở dữ liệu
                return "NV00001";
            }
        }
        public string getIDChucVu(string idNhanVien)
        {
            return db.tb_NHANVIEN.FirstOrDefault(x => x.IDNV == idNhanVien).IDCHUCVU;
        }
    }
}
