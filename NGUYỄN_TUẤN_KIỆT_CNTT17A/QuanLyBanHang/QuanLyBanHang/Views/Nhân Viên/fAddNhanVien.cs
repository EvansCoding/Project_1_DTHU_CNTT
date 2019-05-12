using QuanLyBanHang.Models;
using QuanLyBanHang.Models.BUS;
using System;
using System.Windows.Forms;

namespace QuanLyBanHang.Views.Nhân_Viên
{
    public partial class fAddNhanVien : Form
    {
        #region INITIALIZE
        public fAddNhanVien()
        {
            InitializeComponent();
        }
        #endregion

        #region EVENTS
        private void btnAdd_Click(object sender, EventArgs e)
        {
            NHANVIEN NV = new NHANVIEN();
            NV.MANV = "DH" + DateTime.Now.ToString("ddMMyyyyhhmmssfff");
            NV.TENNV = tbTenNV.Text;
            NV.SEX = int.Parse(cbbSEX.SelectedIndex.ToString());
            NV.DIACHI = rtbDiaChiNhanVien.Text;
            NV.SDT = tbSDTNhanVien.Text;
            NV.EMAIL = tbEmailNhanVien.Text;
            NV.PASSWORD = tbPass.Text;
            NV.QUYEN = Convert.ToInt32(cbbQUYEN.SelectedIndex);
            NhanVienBUS NVBUS = new NhanVienBUS();
            NVBUS.InsertNV(NV);
            this.Dispose();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion
    }
}
