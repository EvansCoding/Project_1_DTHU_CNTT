using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace QuanLyBanHang.Models.BUS
{
    class NhanVienBUS
    {
        public IEnumerable loadInfoNhanVien()
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            return db.NHANVIENs.ToList();
        }
        public IEnumerable<NHANVIEN> loadSeach(string _strName)
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            return db.seachName(_strName).Select(p => new NHANVIEN() { MANV = p.MANV, TENNV = p.TENNV, SEX = p.SEX, DIACHI = p.DIACHI, SDT = p.SDT, EMAIL = p.EMAIL });           
        }
        public void InsertNV(NHANVIEN NV)
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            db.NHANVIENs.Add(NV);
            db.SaveChanges();
        }
        public void removeNV(string _MaNV)
        {
            try
            {
                var db = new QLTHONGTINMAYTINHEntities1();
                NHANVIEN NV = db.NHANVIENs.Where(p => p.MANV == _MaNV).SingleOrDefault();
                db.NHANVIENs.Remove(NV);
                db.SaveChanges();
            }
            catch
            {

            }
        }
        public bool loginSuss(string _ID, string _Pass)
        {
            var db = new QLTHONGTINMAYTINHEntities1();

            var result = db.NHANVIENs.Where(p => p.MANV == _ID && p.PASSWORD == _Pass).SingleOrDefault();
            if (result != null)
                return true;
            return false;
        }
        public int loadQuyen(string _MANV)
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            var result = db.NHANVIENs.Where(p => p.MANV == _MANV).SingleOrDefault();
            if (result != null)
            {
                if (result.QUYEN == 1) return 1;
                else return 0;
            }
            else  return -1;
        }
    }
}
