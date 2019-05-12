using QuanLyBanHang.Models;
using QuanLyBanHang.Models.BUS;
using System;
using System.Windows.Forms;

namespace QuanLyBanHang.Views.Nhà_Cung_Cấp
{
    public partial class fAddNhaCungCap : Form
    {
        #region INITIALIZE
        public fAddNhaCungCap()
        {
            InitializeComponent();
        }
        #endregion

        #region EVENTS
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                NHACUNGCAP NCC = new NHACUNGCAP();
                NCC.MANCC = tbMaNCCAddNhaCungCap.Text;
                NCC.TENNCC = tbTenNCCAddNhaCungCap.Text;
                NCC.DIACHI = rtbDiaChiAddNhaCC.Text;
                NCC.SDT = tbSDTaddNhaCC.Text;
                NCC.FAX = tbFaxAddNhaCC.Text;
                NCC.EMAIL = tbEmailAddNhaCC.Text;

                NhaCungCapBUS NCCBUS = new NhaCungCapBUS();
                NCCBUS.InsertNCC(NCC);
                this.Dispose();
            }
            catch
            {
                tbMaNCCAddNhaCungCap.Clear();
                tbTenNCCAddNhaCungCap.Clear();
                rtbDiaChiAddNhaCC.Clear();
                tbSDTaddNhaCC.Clear();
                tbFaxAddNhaCC.Clear();
                tbEmailAddNhaCC.Clear();
                MessageBox.Show("Có lỗi Xảy Ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion
    }
}
