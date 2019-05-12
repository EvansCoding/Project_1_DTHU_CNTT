using System;
using System.Windows.Forms;
using QuanLyBanHang.Models.BUS;
using QuanLyBanHang.Models;
using QuanLyBanHang.Views.Thống_Kê_Bán_Hàng;

namespace QuanLyBanHang.Controllers
{
    public partial class US_ThongKeBanHang : UserControl
    {
        #region INITIALIZE
        public US_ThongKeBanHang()
        {
            InitializeComponent();
            timerTime.Start();
            RefreshDTGV();
            cbbQuy.Hide();
        }
        #endregion

        #region METHODS
        private void RefreshDTGV()
        {
            dtgvThongKe.Rows.Clear();
            int ID = dtgvThongKe.Rows.Count + 1;
            ThongKe NV = new ThongKe();
            foreach ( THONGKEDONHANGDABAN item in NV.ThongKeSanPham())
            {
                dtgvThongKe.Rows.Add(ID, item.MADH, item.TENKH,item.TENNV,item.TIMEXUAT,item.THANHTIEN) ;
                ID++;
            }
            lbTongTien.Text = String.Format("{0:n0} VNĐ", NV.TongThanhTien());
        }
        #endregion

        #region EVENTS
        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lbTimer.Text = dateTime.ToString("hh:mm:ss");
        }
        private void CbbSelectThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSelectThongKe.SelectedItem.ToString() == "Quý")
            {
                cbbQuy.Show();
            }
            else cbbQuy.Hide();
        }
        private void BtnThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                string cbbSelected = cbbSelectThongKe.SelectedItem.ToString();
                if (cbbSelected == "Ngày" || cbbSelected == "Tháng" || cbbSelected == "Năm" || cbbSelected == "Tổng")
                {
                    dtgvThongKe.Rows.Clear();
                    int ID = dtgvThongKe.Rows.Count + 1;
                    ThongKe NV = new ThongKe();
                    string valueThongke = cbbSelectThongKe.SelectedItem.ToString();
                    foreach (THONGKEDONHANGDABAN item in NV.THONGKETHEONTN(dTimePicker.Value, valueThongke))
                    {
                        dtgvThongKe.Rows.Add(ID, item.MADH, item.TENKH, item.TENNV, item.TIMEXUAT, item.THANHTIEN);
                        ID++;
                    }

                    lbTongTien.Text = String.Format("{0:n0} VNĐ", NV.TongThanhTien());
                }

                if (cbbSelected == "Quý")
                {
                    dtgvThongKe.Rows.Clear();
                    int ID = dtgvThongKe.Rows.Count + 1;
                    ThongKe NV = new ThongKe();
                    string valueThongke = cbbQuy.SelectedItem.ToString();
                    foreach (THONGKEDONHANGDABAN item in NV.TKQuy(dTimePicker.Value, valueThongke))
                    {
                        dtgvThongKe.Rows.Add(ID, item.MADH, item.TENKH, item.TENNV, item.TIMEXUAT, item.THANHTIEN);
                        ID++;
                    }

                    lbTongTien.Text = String.Format("{0:n0} VNĐ", NV.TongThanhTien());
                }
            }
            catch (Exception)
            {
            }

        }
        #endregion

        private void DtgvThongKe_MouseDoubleClick(object sender, MouseEventArgs e)
        {
              string MaDH = dtgvThongKe.SelectedCells[0].OwningRow.Cells["MADH"].Value.ToString();
            fShowDonHang donHang = new fShowDonHang(MaDH);
            donHang.ShowDialog();
        }
    }
}
