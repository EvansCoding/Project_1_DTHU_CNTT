using QuanLyBanHang.Models.BUS;
using System;
using System.Windows.Forms;

namespace QuanLyBanHang.Views
{
    public partial class login : Form
    {
        #region INITIALIZE
        public login()
        {
            InitializeComponent();
        }
        #endregion

        #region EVENTS
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            NhanVienBUS NV = new NhanVienBUS();
            if (NV.loginSuss(tbMaNK.Text, tbPass.Text))
            {
                this.Hide();
                Form1 ad = new Form1(tbMaNK.Text);
                ad.Show();
            }
            else
            {
                MessageBox.Show("Thông Tin Không Chính Xác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
