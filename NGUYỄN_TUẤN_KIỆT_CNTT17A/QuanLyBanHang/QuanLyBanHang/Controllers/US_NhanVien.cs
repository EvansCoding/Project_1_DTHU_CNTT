using System;
using System.Windows.Forms;
using QuanLyBanHang.Models.BUS;
using QuanLyBanHang.Models;
using QuanLyBanHang.Views.Nhân_Viên;

namespace QuanLyBanHang.Controllers
{
    public partial class US_NhanVien : UserControl
    {
        #region INITIALIZE
        public US_NhanVien()
        {
            InitializeComponent();
            timeTimer.Start();
            refreshDTGV();
        }
        #endregion

        #region METHODS
        private string Sex(int _sex)
        {
            if (_sex == 0)
                return "Nữ";
            return "Nam";
        }
        private void refreshDTGV()
        {
            dtgvNhanVien.Rows.Clear();
            int ID = dtgvNhanVien.Rows.Count + 1;
            NhanVienBUS NV = new NhanVienBUS();
            foreach (NHANVIEN item in NV.loadSeach(textBox1.Text))
            {
                dtgvNhanVien.Rows.Add(ID, item.MANV, item.TENNV, Sex(item.SEX), item.DIACHI, item.SDT, item.EMAIL);
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
        private void bntAddNhanVien_Click(object sender, EventArgs e)
        {
            fAddNhanVien fAdd = new fAddNhanVien();
            DialogResult dialog = fAdd.ShowDialog();
            if (dialog == DialogResult.Cancel)
            {
                refreshDTGV();
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgvNhanVien.Rows)
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
                    string MNV = row.Cells["MaNV"].Value.ToString();
                    NhanVienBUS NV = new NhanVienBUS();
                    NV.removeNV(MNV);
                }
            }
            refreshDTGV();
        }
        #endregion
    }
}
