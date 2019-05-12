using QuanLyBanHang.Models;
using QuanLyBanHang.Models.BUS;
using System;
using System.Windows.Forms;

namespace QuanLyBanHang.Views.Nhà_Kho
{
    public partial class fAddNhaKho : Form
    {
        #region INITIALIZE
        public fAddNhaKho()
        {
            InitializeComponent();
        }
        #endregion

        #region EVENTS
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.Empty != tbMaNK.Text && String.Empty != tbTenNK.Text && String.Empty != rtbDiaChi.Text)
                {
                    NHAKHO NK = new NHAKHO();
                    NK.MANK = tbMaNK.Text;
                    NK.TENNK = tbTenNK.Text;
                    NK.DIACHI = rtbDiaChi.Text;

                    NhaKhoBUS nhaKhoBUS = new NhaKhoBUS();
                    nhaKhoBUS.InsertNhaKho(NK);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Dữ Liệu Không Chính Xác!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                tbMaNK.Clear();
                tbTenNK.Clear();
                rtbDiaChi.Clear();
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
