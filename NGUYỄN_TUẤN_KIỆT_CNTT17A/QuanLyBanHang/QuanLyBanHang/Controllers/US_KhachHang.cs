using System;
using System.Windows.Forms;
using QuanLyBanHang.Models.BUS;
using QuanLyBanHang.Models;

namespace QuanLyBanHang.Controllers
{
    public partial class US_KhachHang : UserControl
    {
        #region INITIALIZE
        public US_KhachHang()
        {
            InitializeComponent();
            timeTimer.Start();
            refreshDTGV();
        }
        #endregion

        #region METHODS
        private string Status(int _Status)
        {
            if (_Status == 1) return "VIP";
            else return "Member";
        }
        public void refreshDTGV()
        {
            dtgvKhachHang.Rows.Clear();
            int ID = dtgvKhachHang.Rows.Count + 1;
            KhachHangBUS KH = new KhachHangBUS();
            foreach (KHACHHANG item in KH.loadSearch(tbSearch.Text))
            {
                dtgvKhachHang.Rows.Add(ID, item.MAKH, item.TENKH, item.SDT, item.DIACHI, Status(item.status));
                ID++;
            }
        }
        #endregion

        #region EVENTS
        private void timeTimer_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lbTimer.Text = dateTime.ToString("hh:mm:ss");
        }
        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            refreshDTGV();
        }
        #endregion

    }
}
