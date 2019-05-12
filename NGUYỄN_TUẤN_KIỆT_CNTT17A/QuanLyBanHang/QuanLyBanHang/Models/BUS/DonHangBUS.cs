using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanHang.Models.BUS
{
    class DonHangBUS
    {
        public void InsertDonHang(DONHANG DH)
        {
            try
            {
                var db = new QLTHONGTINMAYTINHEntities1();
                db.DONHANGs.Add(DH);
                db.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Khi Thêm Dư Liệu", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        public int SoLuong()
        {
            var db = new QLTHONGTINMAYTINHEntities1();
            return db.THONGTINDONHANGs.Sum(p => p.SOLUONG);
        }

    }
}
