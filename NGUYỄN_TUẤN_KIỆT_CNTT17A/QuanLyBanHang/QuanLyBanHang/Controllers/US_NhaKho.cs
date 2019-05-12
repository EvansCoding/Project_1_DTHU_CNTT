using System;
using System.Windows.Forms;
using QuanLyBanHang.Models.BUS;
using QuanLyBanHang.Models;
using QuanLyBanHang.Views.Nhà_Kho;

namespace QuanLyBanHang.Controllers
{
    public partial class US_NhaKho : UserControl
    {
        #region INITIALIZE
        public US_NhaKho()
        {
            InitializeComponent();
            timeTimer.Start();
            refreshDTGV();
        }
        #endregion

        #region METHODS
        private void refreshDTGV()
        {
            dtgvNhaKho.Rows.Clear();
            int ID = dtgvNhaKho.Rows.Count + 1;
            NhaKhoBUS NV = new NhaKhoBUS();
            foreach (NHAKHO item in NV.loadSeach(textBox1.Text))
            {
                dtgvNhaKho.Rows.Add(ID, item.MANK, item.TENNK, item.DIACHI);
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
        private void bntAdd_Click(object sender, EventArgs e)
        {
            fAddNhaKho fAddNhaKho = new fAddNhaKho();
            DialogResult dialog = fAddNhaKho.ShowDialog();
            if (dialog == DialogResult.Cancel)
            {
                refreshDTGV();
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dtgvNhaKho.Rows)
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
                        string MNV = row.Cells["MANK"].Value.ToString();
                        NhaKhoBUS NV = new NhaKhoBUS();
                        NV.removeNK(MNV);
                    }
                }
                refreshDTGV();
            }
            catch { }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            refreshDTGV();
        }
        #endregion
    }
}
