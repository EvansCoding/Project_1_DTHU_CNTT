using QuanLyBanHang.Class;
using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanHang.Models.BUS
{
    class ThongTinDonHangBUS
    {
        public void InsertThongTinDonHang(THONGTINDONHANG TTDH)
        {
            try
            {
                var db = new QLTHONGTINMAYTINHEntities1();
                db.THONGTINDONHANGs.Add(TTDH);
                db.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Khi Thêm Dư Liệu", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public decimal checkStatusKH(string _strMaDH)
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            return Convert.ToDecimal(db.THONGTINDONHANGs.Where(p => p.MADH == _strMaDH).Sum(s => s.TIEN));
        }

        public IEnumerable loadInfo(string _strMADH)
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            return db.loadINFORDONHANG(_strMADH).Select(p=> new cTTDONHANG() { StrMASP =p.MASP, StrTENSP = p.TENSP, ISOLUONG = p.SOLUONG, DGIA = p.GIABAN }).ToList();
        }
    }
}
