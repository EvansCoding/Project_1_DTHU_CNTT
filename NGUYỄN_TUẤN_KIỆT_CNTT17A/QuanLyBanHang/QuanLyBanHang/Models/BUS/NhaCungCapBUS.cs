using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyBanHang.Models.BUS
{
    class NhaCungCapBUS
    {
        public IEnumerable loadNCC()
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            return db.NHACUNGCAPs.ToList();
        }
        public IEnumerable<NHACUNGCAP> loadSeach(string _strName)
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            return db.SeachNameNhaCungCap(_strName).Select(p => new NHACUNGCAP() { MANCC = p.MANCC, TENNCC = p.TENNCC, DIACHI = p.DIACHI, SDT = p.SDT, FAX = p.FAX, EMAIL = p.EMAIL });
        }
        public void InsertNCC(NHACUNGCAP NCC)
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            db.NHACUNGCAPs.Add(NCC);
            db.SaveChanges();
        }
        public void removeNCC (string _MaNCC)
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            NHACUNGCAP NCC = db.NHACUNGCAPs.Where(p => p.MANCC == _MaNCC).SingleOrDefault();
            db.NHACUNGCAPs.Remove(NCC);
            db.SaveChanges();
        }    
        public IEnumerable loadMANCC()
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            return db.NHACUNGCAPs.Select(p => p.MANCC).ToList();
        }
    }
}
