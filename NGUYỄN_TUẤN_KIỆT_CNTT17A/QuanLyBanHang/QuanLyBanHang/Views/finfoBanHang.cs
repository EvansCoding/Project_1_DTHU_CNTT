using QuanLyBanHang.Class;
using QuanLyBanHang.Models;
using QuanLyBanHang.Models.BUS;
using System;
using System.Windows.Forms;

namespace QuanLyBanHang.Views
{
    public partial class finfoBanHang : Form
    {
        #region INITIALIZE
        public finfoBanHang()
        {
            InitializeComponent();
        }
        #endregion

        #region METHODS
        public void loadInfoSanPham(string _MaSP)
        {
            SanPhamBUS SPBUS = new SanPhamBUS();
            SANPHAM SP = SPBUS.loadInfoSanPhamToDB(_MaSP);

            lbMaSPInfo.Text = SP.MASP.ToString();
            lbTenSPinfo.Text = SP.TENSP.ToString();
            rtbChiTietInfo.Text = SP.THONGTIN.ToString();
            lbGiaInfo.Text = String.Format("{0:n0} VNĐ", SP.GIABAN);
            cImages images = new cImages();
            images.Images(ptbInfoSanPham, SP.IMAGES);
        }
        #endregion

        #region EVENTS
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion
    }
}
