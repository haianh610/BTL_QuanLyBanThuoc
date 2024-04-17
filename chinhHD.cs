using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLyBanThuoc
{
    public partial class chinhHD : Form
    {
        private string maHD;
        private string maNV;
        private string maKH;
        private DateTime ngayLap;
        private float tongTien;
        private int trangThai;
        public chinhHD(HoaDon hd)
        {
            InitializeComponent();
            maHD = hd.sMaHD;
            maNV = hd.sMaNV;
            maKH = hd.sMaKH;
            ngayLap = hd.dNgayLap;
            tongTien = hd.fTongTien;
            trangThai = hd.iTrangThai;
            lbHDHT.Text = maHD;
            lbKhachDaTraHT.Text = hd.fKhachThanhToan.ToString();
            lbKhachHangHT.Text = KhachHang.GetKhachHang(maKH).sTenKH;
            dtpNgayLap.Value = ngayLap;
            lbTongTienHT.Text = Convert.ToString(tongTien);
            lbTrangThaiHT.Text = HoaDon.checkTrangThaiHD(trangThai);
        }

        private void chinhHD_Load(object sender, EventArgs e)
        {
            this.sP_ChiTietHoaDonTableAdapter.Fill(this.quanLyKhoThuocTayDataSet1.SP_ChiTietHoaDon, maHD);
            this.tblNhanVienTableAdapter.Fill(this.quanLyKhoThuocTayDataSet1.tblNhanVien);
            cbbNguoiBan.SelectedValue = maNV;
            lbTongSoLuongHT.Text = dgvChiTietHD.RowCount.ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
