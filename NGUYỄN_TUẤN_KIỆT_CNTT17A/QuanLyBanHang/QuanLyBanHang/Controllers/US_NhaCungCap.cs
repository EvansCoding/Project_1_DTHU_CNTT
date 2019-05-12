using System;
using System.Windows.Forms;
using QuanLyBanHang.Models.BUS;
using QuanLyBanHang.Models;
using QuanLyBanHang.Views.Nhà_Cung_Cấp;

namespace QuanLyBanHang.Controllers
{
    public partial class US_NhaCungCap : UserControl
    {
        #region INIIALIZE
        public US_NhaCungCap()
        {
            InitializeComponent();
            timeTimer.Start();
            refreshDTGV();
        }
        #endregion

        #region METHODS
        private void refreshDTGV()
        {
            dtgvNhaCungCap.Rows.Clear();
            int ID = dtgvNhaCungCap.Rows.Count + 1;
            NhaCungCapBUS NV = new NhaCungCapBUS();
            foreach (NHACUNGCAP item in NV.loadSeach(textBox1.Text))
            {
                dtgvNhaCungCap.Rows.Add(ID, item.MANCC, item.TENNCC, item.DIACHI, item.SDT, item.FAX, item.EMAIL);
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
        private void bntAddNCC_Click(object sender, EventArgs e)
        {
            fAddNhaCungCap fAdd = new fAddNhaCungCap();
            DialogResult dialog = fAdd.ShowDialog();
            if (dialog == DialogResult.Cancel)
            {
                refreshDTGV();
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgvNhaCungCap.Rows)
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
                    try
                    {
                        string MNCC = row.Cells["MANCC"].Value.ToString();
                        NhaCungCapBUS NCC = new NhaCungCapBUS();
                        NCC.removeNCC(MNCC);
                    }
                    catch
                    {
                        MessageBox.Show("Có lỗi Xảy Ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            refreshDTGV();
        }
        #endregion
    }
}
