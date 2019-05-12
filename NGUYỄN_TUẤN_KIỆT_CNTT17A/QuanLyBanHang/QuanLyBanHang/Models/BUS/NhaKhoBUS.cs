using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyBanHang.Models.BUS
{
    class NhaKhoBUS
    {
        public IEnumerable loadInfoNhaKho()
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            return db.NHAKHOes.ToList();
        }
        public void InsertNhaKho(NHAKHO NK)
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            db.NHAKHOes.Add(NK);
            db.SaveChanges();
        }
        public IEnumerable<NHAKHO> loadSeach(string _strName)
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            return db.SeachNameNhaKHo(_strName).Select(p => new NHAKHO() { MANK = p.MANK, TENNK = p.TENNK, DIACHI = p.DIACHI });
        }
        public void removeNK(string _MaNK)
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            NHAKHO NK = db.NHAKHOes.Where(p => p.MANK == _MaNK).SingleOrDefault();
            db.NHAKHOes.Remove(NK);
            db.SaveChanges();
        }
        public IEnumerable loadMANK()
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            return db.NHAKHOes.Select(p => p.MANK).ToList();
        }
    }
}
