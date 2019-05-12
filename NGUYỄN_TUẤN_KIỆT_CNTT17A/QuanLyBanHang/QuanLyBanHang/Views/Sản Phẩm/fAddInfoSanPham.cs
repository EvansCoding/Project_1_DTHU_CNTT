using QuanLyBanHang.Models;
using QuanLyBanHang.Models.BUS;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyBanHang.Views.Sản_Phẩm
{
    public partial class fAddInfoSanPham : Form
    {
        #region INITIALIZE
        public fAddInfoSanPham()
        {
            InitializeComponent();
        }
        #endregion

        #region METHODS
        private void pathImage()
        {
            string fName = tbImages.Text + ".jpg";
            string folder = Application.StartupPath + "\\Images\\";
            string pathString = System.IO.Path.Combine(folder, fName);
            Image image = ptbImage.Image;
            image.Save(pathString);
        }
        private void loadDB()
        {
            NhaKhoBUS nhaKhoBUS = new NhaKhoBUS();
            cbbMaKhoAddSanPham.DataSource = nhaKhoBUS.loadMANK();
            NhaCungCapBUS nhaCungCapBUS = new NhaCungCapBUS();
            cbbMaNCCAddSanPham.DataSource = nhaCungCapBUS.loadMANCC();
        }
        #endregion

        #region EVENTS
        private void btnAddAddSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                SANPHAM SP = new SANPHAM();
                SP.MASP = tbMaSPAddSanPham.Text;
                SP.TENSP = tbTenSPAddSanPham.Text;
                SP.THUONGHIEU = tbThuongHieuAddSanPham.Text;
                SP.THONGTIN = rtbThongTinAddSanPham.Text;
                SP.GIANHAP = Convert.ToDecimal(tbGiaAddSanPham.Text);
                SP.GIABAN = Convert.ToDecimal((SP.GIANHAP * (decimal)0.05) + SP.GIANHAP);
                SP.LOAISP = tbLoaiSP.Text;
                SP.IMAGES = tbImages.Text;
                SP.SOLUONG = Convert.ToInt32(nudSLuong.Value);
                SP.MANK = cbbMaKhoAddSanPham.Text;
                SP.MANCC = cbbMaNCCAddSanPham.Text;
                SP.TIMENHAP = DateTime.Now;

                SanPhamBUS SPBUS = new SanPhamBUS();
                SPBUS.insertSP(SP);
                pathImage();
                this.Dispose();
            }
            catch { }
        }

        private void btnCloseAddSanPham_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void fAddInfoSanPham_Load(object sender, EventArgs e)
        {
            loadDB();
        }

        private void PtbImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != null)
            {
                open.Filter = "(*.jpg;*.png;)| *.jpg; *png;";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image = Image.FromFile(open.FileName);
                }
            }
        }
        #endregion
    }
}
