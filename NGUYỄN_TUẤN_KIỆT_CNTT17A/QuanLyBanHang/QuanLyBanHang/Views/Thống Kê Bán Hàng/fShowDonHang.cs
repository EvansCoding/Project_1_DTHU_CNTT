using QuanLyBanHang.Class;
using QuanLyBanHang.Models;
using QuanLyBanHang.Models.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Views.Thống_Kê_Bán_Hàng
{
    public partial class fShowDonHang : Form
    {
        public fShowDonHang(string _MADH)
        {
            InitializeComponent();
            loadTTDH(_MADH);
        }

        public void loadTTDH(string _MADH)
        {
            ThongKe thongKe = new ThongKe();
            lbMaDHshowDH.Text = thongKe.loadInfoDH(_MADH).MADH.ToString();
            lbTenKHshowDH.Text = thongKe.loadInfoDH(_MADH).TENKH.ToString();
            lbTenNVshowDH.Text = thongKe.loadInfoDH(_MADH).TENNV.ToString();
            lbTGianXuatshowDH.Text = thongKe.loadInfoDH(_MADH).TIMEXUAT.ToString();
            lbThanhTienhowDH.Text = String.Format("{0:n0} VNĐ", thongKe.loadInfoDH(_MADH).THANHTIEN);

            ThongTinDonHangBUS thongTin = new ThongTinDonHangBUS();
            int i = 1;
            foreach (cTTDONHANG item in thongTin.loadInfo(_MADH))
            {
                dtgvThongKe.Rows.Add(i, item.StrMASP, item.StrTENSP, item.ISOLUONG, item.DGIA);
                i++;
            }
        }

        private void PtbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
