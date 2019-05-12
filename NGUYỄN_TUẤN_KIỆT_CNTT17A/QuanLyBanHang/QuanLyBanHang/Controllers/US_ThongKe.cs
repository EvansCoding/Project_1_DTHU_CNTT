using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyBanHang.Models.BUS;
using QuanLyBanHang.Models;
using QuanLyBanHang.Class;

namespace QuanLyBanHang.Controllers
{
    public partial class US_ThongKe : UserControl
    {
        #region INITIALIZE
        public US_ThongKe()
        {
            InitializeComponent();
            load();
        }
        #endregion

        #region METHODS
        private void load()
        {
            ThongKe TK = new ThongKe();
            lbTongTien.Text = String.Format("{0:n0} VNĐ", TK.TongThanhTien());
            DonHangBUS DH = new DonHangBUS();
            lbSoLuong.Text = DH.SoLuong().ToString();
            KhachHangBUS KH = new KhachHangBUS();
            lbSoLuongKH.Text = KH.SoLuongKH().ToString();
            SanPhamBUS SP = new SanPhamBUS();

            foreach (var item in SP.loadSP())
            {
                SANPHAM S = (SANPHAM)item;
                showTheMost(S.TENSP, S.IMAGES);
            }
        }
        private void showTheMost(string _strName, string _pathImage)
        {
            System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#179BD7");
            Label label = new Label()
            {
                ForeColor = col,
                Height = 20,
                Width = 100,
                Text = _strName.Substring(7),
                TextAlign = ContentAlignment.TopCenter,
                Left = 25,
                Margin = this.Margin

            };
            var margin = label.Margin;
            margin.Left = 25;
            label.Margin = margin;
            cImages images = new cImages();
            Button btn;
            try
            {
                btn = new Button()
                {
                    Width = 100,
                    Height = 100,
                    BackgroundImageLayout = ImageLayout.Stretch,

                    BackgroundImage = Image.FromFile(images.pathImagesPNG(_pathImage)),
                };
            }
            catch (Exception)
            {

                btn = new Button()
                {
                    Width = 100,
                    Height = 100,
                    BackgroundImageLayout = ImageLayout.Stretch,

                    BackgroundImage = Image.FromFile(images.pathImagesJPG(_pathImage)),
                };
            }

            btn.Margin = margin;
            FlowLayoutPanel flowLayout = new FlowLayoutPanel()
            {
                Height = 165,
                Width = 150,

            };
            flowLayout.Controls.Add(btn);
            flowLayout.Controls.Add(label);
            flpnlSanPhamBanChayNhat.Controls.Add(flowLayout);
        }
        #endregion
    }
}
