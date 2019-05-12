using QuanLyBanHang.Controllers;
using QuanLyBanHang.Models.BUS;
using QuanLyBanHang.Views;
using System;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class Form1 : Form
    {
        #region INITIALIZE
        public Form1(string _MANV)
        {
            InitializeComponent();
            loadUIbntHome();
            MANV = _MANV;
            loadQuyenAd(MANV);
        }
        #endregion

        #region PROPERTIES
        private string MANV;
        #endregion

        #region METHODS
        private void loadQuyenAd(string _MANV)
        {
            NhanVienBUS NV = new NhanVienBUS();
            if(NV.loadQuyen(_MANV) == 0)
            {
                this.btnKhachHang.Hide();
                this.btnNhanVien.Hide();
                this.btnSanPham.Hide();
                this.btnNhaCungCap.Hide();
                this.btnNhaKho.Hide();
            }
        }
        private void moveSlide(Control control)
        {
            pnlSlide.Top = control.Top;
            pnlSlide.Height = control.Height;
        }
        private void addControlsPanel(Control control)
        {
            control.Dock = DockStyle.Fill;
            pnlControl.Controls.Clear();
            pnlControl.Controls.Add(control);
        }
        private void loadUIbntHome()
        {
            US_ThongKe uC_ThongKe = new US_ThongKe();
            addControlsPanel(uC_ThongKe);
        }
        #endregion

        #region EVENTS
        private void btnHome_Click(object sender, EventArgs e)
        {
            moveSlide(btnHome);
            US_ThongKe uC_ThongKe = new US_ThongKe();
            addControlsPanel(uC_ThongKe);
        }
        private void btnBanHang_MouseClick(object sender, MouseEventArgs e)
        {
            moveSlide(btnBanHang);
            US_BanHang uS_BanHang = new US_BanHang(MANV);
            addControlsPanel(uS_BanHang);
        }
        private void btnThongKeBH_Click(object sender, EventArgs e)
        {
            moveSlide(btnThongKeBH);
            US_ThongKeBanHang uS_ThongKeBanHang = new US_ThongKeBanHang();
            addControlsPanel(uS_ThongKeBanHang);
        }
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            moveSlide(btnKhachHang);
            US_KhachHang uS_KhachHang = new US_KhachHang();
            addControlsPanel(uS_KhachHang);
        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            moveSlide(btnNhanVien);
            US_NhanVien uS_NhanVien = new US_NhanVien();
            addControlsPanel(uS_NhanVien);
        }
        private void btnSanPham_Click(object sender, EventArgs e)
        {
            moveSlide(btnSanPham);
            US_SanPham uS_SanPham = new US_SanPham();
            addControlsPanel(uS_SanPham);
        }
        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            moveSlide(btnNhaCungCap);
            US_NhaCungCap uS_NhaCung = new US_NhaCungCap();
            addControlsPanel(uS_NhaCung);
        }
        private void btnNhaKho_Click(object sender, EventArgs e)
        {
            moveSlide(btnNhaKho);
            US_NhaKho uS_NhaKho = new US_NhaKho();
            addControlsPanel(uS_NhaKho);
        }
        login log = new login();
        private void ptbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            log.Show();
        }
        #endregion     
    }
}
