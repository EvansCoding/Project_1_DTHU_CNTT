using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace QuanLyBanHang.Models.BUS
{
    class SanPhamBUS
    {
        private int amountToDB(string _MaSp)
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            return db.SANPHAMs.Where(p => p.MASP == _MaSp).Select(p => p.SOLUONG).SingleOrDefault();
        }
        public void soLuongSauKhiBan(string _MaSp, int _SoLuong)
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            db.UpdateSoLuong(_MaSp, amountToDB(_MaSp) - _SoLuong); // Proc SQL
            db.SaveChanges();
        }
        public SANPHAM loadInfoSanPhamToDB(string _MaSP)
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            return db.SANPHAMs.Where(p => p.MASP == _MaSP).SingleOrDefault();
        }
        public IEnumerable loadMaSanPham()
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            return db.SANPHAMs.Select(p => p.MASP).ToList();
        }
        public int SoLuongTrongKho(string _MaSanPham)
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            return db.SANPHAMs.Where(p => p.MASP == _MaSanPham).Select(p => p.SOLUONG).SingleOrDefault();
        }
        public IEnumerable<SANPHAM> loadSearch(string _strName)
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            return db.SeachNameSanPham(_strName).Select(p => new SANPHAM() { MASP = p.MASP, TENSP = p.TENSP, THUONGHIEU = p.THUONGHIEU, THONGTIN = p.THONGTIN, LOAISP = p.LOAISP, SOLUONG = p.SOLUONG, GIANHAP = p.GIANHAP, GIABAN = p.GIABAN, TIMENHAP = p.TIMENHAP, MANCC = p.MANCC, MANK = p.MANK, IMAGES = p.IMAGES });
        }
        public void removeSP(string _MaSP)
        {
            try
            {
                var db = new QLTHONGTINMAYTINHEntities1();
                SANPHAM SP = db.SANPHAMs.Where(p => p.MASP == _MaSP).SingleOrDefault();
                db.SANPHAMs.Remove(SP);
                db.SaveChanges();
            }
            catch { }
        }
        public void insertSP(SANPHAM SP)
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            db.SANPHAMs.Add(SP);
            db.SaveChanges();
        }
        public IEnumerable loadSP()
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            return db.Top_5_SP().Select(p => new SANPHAM() { TENSP = p.TENSP, IMAGES = p.IMAGES }).ToList();
        }
    }
}
