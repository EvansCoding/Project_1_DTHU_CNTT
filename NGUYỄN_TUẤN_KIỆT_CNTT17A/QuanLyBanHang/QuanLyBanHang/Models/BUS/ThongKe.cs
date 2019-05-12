using System;
using System.Collections;
using System.Linq;


namespace QuanLyBanHang.Models.BUS
{
    class ThongKe
    {
        public IEnumerable ThongKeSanPham()
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            return db.THONGKEDONHANGDABANs.ToList();
        }

        public THONGKEDONHANGDABAN loadInfoDH(string _strMADH)
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            return db.THONGKEDONHANGDABANs.Where(p => p.MADH == _strMADH).SingleOrDefault();
        }
        public Decimal TongThanhTien()
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            return db.THONGKEDONHANGDABANs.Sum(p=> p.THANHTIEN);
        }
        public IEnumerable THONGKETHEONTN(DateTime dateTime, string strDate)
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            if(strDate == "Ngày")
                return db.THONGKEDONHANGDABANs.Where(p =>p.TIMEXUAT.Day == dateTime.Day && p.TIMEXUAT.Month == dateTime.Month && p.TIMEXUAT.Year == dateTime.Year).ToList();
            if (strDate == "Tháng")
                return db.THONGKEDONHANGDABANs.Where(p => p.TIMEXUAT.Month == dateTime.Month && p.TIMEXUAT.Year == dateTime.Year).ToList();
            if(strDate == "Năm")
                return db.THONGKEDONHANGDABANs.Where(p => p.TIMEXUAT.Year == dateTime.Year).ToList();
            return db.THONGKEDONHANGDABANs.ToList();
        }
        public IEnumerable TKQuy(DateTime dateTime, string strDate)
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            if(strDate == "Quý 1")
            return db.THONGKEDONHANGDABANs.Where(p => p.TIMEXUAT.Month >= 1 && p.TIMEXUAT.Month <= 3 && dateTime.Year == p.TIMEXUAT.Year).ToList();
            if (strDate == "Quý 2")
                return db.THONGKEDONHANGDABANs.Where(p => p.TIMEXUAT.Month >= 4 && p.TIMEXUAT.Month <= 6 && dateTime.Year == p.TIMEXUAT.Year).ToList();
            if (strDate == "Quý 3")
                return db.THONGKEDONHANGDABANs.Where(p => p.TIMEXUAT.Month >= 7 && p.TIMEXUAT.Month <= 9 && dateTime.Year == p.TIMEXUAT.Year).ToList();
            return db.THONGKEDONHANGDABANs.Where(p => p.TIMEXUAT.Month >= 10 && p.TIMEXUAT.Month <= 12 && dateTime.Year == p.TIMEXUAT.Year).ToList();
        }
    }
}
