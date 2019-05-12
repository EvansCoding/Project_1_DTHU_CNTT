using System;
using System.Windows.Forms;
using QuanLyBanHang.Models.BUS;
using QuanLyBanHang.Models;
using QuanLyBanHang.Views.Sản_Phẩm;

namespace QuanLyBanHang.Controllers
{
    public partial class US_SanPham : UserControl
    {
        #region INITIALIZE
        public US_SanPham()
        {
            InitializeComponent();
            timeTimer.Start();
            refreshDTGV();
        }
        #endregion

        #region METHODS
        private void refreshDTGV()
        {
            dtgvSanPham.Rows.Clear();
            int ID = dtgvSanPham.Rows.Count + 1;
            SanPhamBUS NV = new SanPhamBUS();
            foreach (SANPHAM item in NV.loadSearch(textBox1.Text))
            {
                dtgvSanPham.Rows.Add(ID, item.MASP, item.TENSP, item.THUONGHIEU, item.THONGTIN, item.LOAISP, item.SOLUONG , item.GIANHAP,  item.GIABAN ,item.TIMENHAP, item.MANCC, item.MANK);
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            refreshDTGV();
        }
        private void bntAddSP_Click(object sender, EventArgs e)
        {
            fAddInfoSanPham fAdd = new fAddInfoSanPham();
            DialogResult dialog = fAdd.ShowDialog();
            if (dialog == DialogResult.Cancel)
            {
                refreshDTGV();
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgvSanPham.Rows)
            {
                bool check = true;
                try
                {
                    bool chk = bool.TryParse(row.Cells["check"].Value.ToString(), out check);
                }
                catch (Exception)
                {
                    check = false;
                }
                if (check)
                {
                    string MSP = row.Cells["MASP"].Value.ToString();
                    SanPhamBUS SP = new SanPhamBUS();
                    SP.removeSP(MSP);
                }
            }
            refreshDTGV();
        }
        #endregion
    }
}
