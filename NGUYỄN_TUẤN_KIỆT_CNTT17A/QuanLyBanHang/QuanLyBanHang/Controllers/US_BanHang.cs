using System;
using System.Windows.Forms;
using QuanLyBanHang.Models.BUS;
using QuanLyBanHang.Class;
using QuanLyBanHang.Models;
using System.Text.RegularExpressions;
using QuanLyBanHang.Views;

namespace QuanLyBanHang.Controllers
{
    public partial class US_BanHang : UserControl
    {

        #region INITIALIZE
        public US_BanHang(string _MaNV)
        {
            InitializeComponent();
            loadCBBMaSanPham();
            showTime();
            lbMaDonHang.Text = showMa("DH");
            MaNV = _MaNV;
        }
        #endregion

        #region PROPERTTIES
        private string MaNV;
        private long lGia;
        private long LGia { get => lGia; set => lGia = value; }
        private int tongSoLuong;
        public int TongSoLuong { get => tongSoLuong; set => tongSoLuong = value; }
        private long tongThanhTien;
        public long TongThanhTien { get => tongThanhTien; set => tongThanhTien = value; }


        private string tbSDT;
        public string TbSDT { get => tbSDT; set => tbSDT = value; }

        private static bool checkKhachHangExist = false;
        #endregion

        #region METHODS
        private void checkPhoneNumber(string _phoneNumber)
        {
            KhachHangBUS info = new KhachHangBUS();
            try
            {
                if (info.InfoKhachHang(_phoneNumber) != null)
                {
                    tbSDTKhachHangBH.Text = info.InfoKhachHang(_phoneNumber).SDT.ToString();
                    tbMaKhachHangBH.Text = info.InfoKhachHang(_phoneNumber).MAKH.ToString();
                    tbHoTenKhachHangBH.Text = info.InfoKhachHang(_phoneNumber).TENKH.ToString();
                    rtbDiaChiKhachHangBH.Text = info.InfoKhachHang(_phoneNumber).DIACHI.ToString();
                    pnlInfoKhachHang.Enabled = false;
                    checkKhachHangExist = true;
                }
                else
                {
                    MessageBox.Show("Phone Numbers Don't Exist", "Don't Exist", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    tbMaKhachHangBH.Text = showMa("KH");
                    checkKhachHangExist = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi từ DataBase", "Lỗi!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void loadCBBMaSanPham()
        {
            SanPhamBUS info = new SanPhamBUS();
            cbbMaSanPhamBH.DataSource = info.loadMaSanPham();
        }

        private void addDataToDTGVTemp()
        {
            try
            {
                int ID = dtgvBanHang.RowCount + 1;
                string MaSP = cbbMaSanPhamBH.SelectedItem.ToString();
                string NameSanPham = tbTenSanPhamBH.Text;
                int SoLuong = Convert.ToInt32(nudSoLuongBH.Value);
                long GiaSanPham = LGia;

                if (dtgvBanHang.Rows.Count >= 1)
                {
                    if (checkMaSPExist(MaSP))
                    {
                        MessageBox.Show("Sản Phẩm Đã Có Trong Đơn Hàng!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }
                if (checkSoLuongTrongKho(MaSP) == 0)
                {
                    MessageBox.Show("Sản Phẩm Hết Hàng...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if ((checkSoLuongTrongKho(MaSP) - (int)nudSoLuongBH.Value) >= 0 && (int)nudSoLuongBH.Value > 0)
                {
                    dtgvBanHang.Rows.Add(ID, MaSP, NameSanPham, SoLuong, GiaSanPham);
                    nudSoLuongBH.Value = 0;
                    showThongKe();
                }
                else
                {
                    MessageBox.Show("Số lượng của Sản Phẩm còn: " + checkSoLuongTrongKho(MaSP), "Sản Phẩm", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Mã Sản Phẩm Không Đúng!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private bool checkMaSPExist(string _MaSP)
        {
            for (int i = 0; i < dtgvBanHang.Rows.Count; i++)
            {
                if (_MaSP == dtgvBanHang.Rows[i].Cells[1].Value.ToString())
                    return true;
            }
            return false;
        }

        private void removeDataToDTGVTemp()
        {
            try
            {
                int countRow = dtgvBanHang.Rows.Count;
                if (countRow > 0)
                {
                    int MaDH = Convert.ToInt32(dtgvBanHang.SelectedCells[0].OwningRow.Cells["ID"].Value);
                    dtgvBanHang.Rows.RemoveAt(MaDH - 1);
                    showThongKe();
                    for (int i = 0; i < countRow - 1; i++)
                    {
                        dtgvBanHang.Rows[i].Cells[0].Value = i + 1;
                    }
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Error Data invalid!!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showThongKe()
        {
            TongSoLuong = 0;
            TongThanhTien = 0;
            foreach (DataGridViewRow item in dtgvBanHang.Rows)
            {
                TongSoLuong += Convert.ToInt32(item.Cells[3].Value);
                TongThanhTien += Convert.ToInt64(item.Cells[4].Value) * Convert.ToInt32(item.Cells[3].Value);
            }
            lbThongKeSoLuong.Text = TongSoLuong.ToString();
            lbThanhTien.Text = String.Format("{0:n0} VNĐ", TongThanhTien);
        }

        private void showTime()
        {
            lbTimeBanHang.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void ClearAll()
        {
            pnlInfoKhachHang.Enabled = true;
            tbSDTKhachHangBH.Clear();

            tbMaKhachHangBH.Clear();
            tbHoTenKhachHangBH.Clear();
            rtbDiaChiKhachHangBH.Clear();
            dtgvBanHang.Rows.Clear();
            lbMaDonHang.Text = "";
            lbThanhTien.Text = "0";
            lbThongKeSoLuong.Text = "0";
        }

        private static string showMa(string _TienTo)
        {
            DateTime dt = DateTime.Now;
            return (_TienTo + dt.Year + dt.Month + dt.Day + dt.Hour + dt.Minute + dt.Second + dt.Millisecond);
        }

        private bool checkNullInfoKhacHang()
        {
            string strPattern = @"[\s]+";
            Regex rgx = new Regex(strPattern);

            KHACHHANG KH = new KHACHHANG();
            KH.SDT = rgx.Replace(tbSDTKhachHangBH.Text, " ");
            KH.TENKH = rgx.Replace(tbHoTenKhachHangBH.Text, " ");
            KH.DIACHI = rgx.Replace(rtbDiaChiKhachHangBH.Text, " ");

            if (KH.SDT == String.Empty || KH.TENKH == String.Empty || KH.DIACHI == String.Empty)
            {
                return true;
            }
            return false;
        }

        private int checkSoLuongTrongKho(string _MaSP)
        {
            SanPhamBUS SoLuongCon = new SanPhamBUS();
            return SoLuongCon.SoLuongTrongKho(_MaSP);
        }

        private void Export_Data()
        {
            try
            {
                KhachHangBUS infoKH = new KhachHangBUS();
                if (!checkKhachHangExist)
                {
                    KHACHHANG KH = new KHACHHANG();
                    KH.MAKH = tbMaKhachHangBH.Text;
                    KH.TENKH = tbHoTenKhachHangBH.Text;
                    KH.SDT = tbSDTKhachHangBH.Text;
                    KH.DIACHI = rtbDiaChiKhachHangBH.Text;
                    KH.status = 0;
                    infoKH.InsertKhachHang(KH);
                }

                DONHANG DH = new DONHANG();
                DH.MADH = lbMaDonHang.Text;
                DH.MAKH = tbMaKhachHangBH.Text;
                DH.MANV = MaNV;
                DH.TIMEXUAT = DateTime.Now;
                DH.THANHTIEN = TongThanhTien;

                DonHangBUS infoDH = new DonHangBUS();
                infoDH.InsertDonHang(DH);

                foreach (DataGridViewRow item in dtgvBanHang.Rows)
                {
                    THONGTINDONHANG TTDH = new THONGTINDONHANG();
                    TTDH.MADH = lbMaDonHang.Text;
                    TTDH.MASP = item.Cells[1].Value.ToString();
                    TTDH.SOLUONG = Convert.ToInt32(item.Cells[3].Value);
                    TTDH.TIEN = Convert.ToDecimal(item.Cells[4].Value);

                    ThongTinDonHangBUS infoTTDH = new ThongTinDonHangBUS();
                    infoTTDH.InsertThongTinDonHang(TTDH);

                    SanPhamBUS SP = new SanPhamBUS();
                    SP.soLuongSauKhiBan(TTDH.MASP.ToString(), Convert.ToInt32(TTDH.SOLUONG));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xuất Hiện Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateStatusBanHang()
        {
            KhachHangBUS KH = new KhachHangBUS();
            foreach (var item in KH.listStatus(100000000))
            {

                KH.insertStatus(item.ToString());
            }
        }
        #endregion

        #region EVENTS

        private void cbbMaSanPhamBH_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                SanPhamBUS info = new SanPhamBUS();
                var d = info.loadInfoSanPhamToDB(cbbMaSanPhamBH.SelectedItem.ToString());

                tbTenSanPhamBH.Text = d.TENSP.ToString();
                rtbThongTinBH.Text = d.THONGTIN.ToString();
                LGia = Convert.ToInt64(d.GIABAN);
                lbGiaBH.Text = String.Format("{0:n0} VNĐ", LGia);
                nudSoLuongBH.Value = 0;

                cImages images = new cImages();
                images.Images(ptbSanPham, d.IMAGES.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi!!");
            }
        }

        private void btnAddSanPham_Click(object sender, EventArgs e)
        {
            if (checkNullInfoKhacHang())
            {
                MessageBox.Show("Thông Tin Khách Hàng Không Chính Xác!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else addDataToDTGVTemp();
        }

        private void btnDeleteSanPham_Click(object sender, EventArgs e)
        {
            removeDataToDTGVTemp();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
            lbMaDonHang.Text = showMa("DH");
        }

        private void btnSearchNumberPhone_MouseClick(object sender, MouseEventArgs e)
        {
            checkPhoneNumber(tbSDTKhachHangBH.Text);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (checkNullInfoKhacHang())
            {
                MessageBox.Show("Thông Tin Khách Hàng Không Chính Xác", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Export_Data();
                    MessageBox.Show("Export Thành Công!", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ClearAll();
                    loadCBBMaSanPham();
                    lbMaDonHang.Text = showMa("DH");
                }
            }
            updateStatusBanHang();
        }


        private void dtgvBanHang_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string MaSP = dtgvBanHang.SelectedCells[0].OwningRow.Cells["MaSP"].Value.ToString();
            finfoBanHang infoBH = new finfoBanHang();
            infoBH.loadInfoSanPham(MaSP);
            infoBH.ShowDialog();
        }
        #endregion
    }
}
