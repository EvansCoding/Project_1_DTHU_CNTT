using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanHang.Models.BUS
{
    class KhachHangBUS
    {
        public KHACHHANG InfoKhachHang(string _phoneNumber)
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            return db.KHACHHANGs.Where(p => p.SDT == _phoneNumber).SingleOrDefault();
        }
        public void InsertKhachHang(KHACHHANG KH)
        {
            try
            {
                var db = new QLTHONGTINMAYTINHEntities1();
                db.KHACHHANGs.Add(KH);
                db.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Khi Thêm Dư Liệu", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        public IEnumerable loadInforKhachHang()
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            return db.KHACHHANGs.ToList();
        }
        public IEnumerable<KHACHHANG> loadSearch(string _strName)
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            return db.SeachNameKhachHang(_strName).Select(p => new KHACHHANG() { MAKH = p.MAKH, TENKH = p.TENKH, SDT = p.SDT, DIACHI = p.DIACHI, status = p.status });
        }
        public int SoLuongKH()
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            return db.KHACHHANGs.Count();
        }
        public IEnumerable listStatus(int _limitMoney)
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            return db.THONGKEDONHANGDABAN_1.Where(p => p.THANHTIEN >= _limitMoney).Select(a => a.MAKH).ToList();
        }
        public void insertStatus(string _strMAKH)
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            var result = db.KHACHHANGs.Where(p => p.MAKH == _strMAKH).SingleOrDefault();
            if(result != null)
            {
                result.status = 1;
                db.SaveChanges();
            }
        }
    }
}
