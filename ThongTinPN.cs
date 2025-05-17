using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_QuanLyBanThuoc.Code;

namespace BTL_QuanLyBanThuoc
{
    public partial class ThongTinPN : Form
    {
        private string maPN;
        private string maNV;
        private DateTime ngayNhap;
        private string maNCC;
        private float tongTienPN;
        private int trangThai;
        private int phuongThuc;
        private float NCCThanhToan;
        public ThongTinPN(PhieuNhap pn)
        {
            InitializeComponent();
            maPN = pn.sMaPN;
            maNV = pn.sMaNV;
            maNCC = pn.sMaNCC;
            ngayNhap = pn.dNgayNhap;
            tongTienPN = pn.fTongTienPN;
            trangThai = pn.iTrangThai;
            lbPNHT.Text = maPN;
            lbKhachDaTraHT.Text = pn.fKhachThanhToan.ToString();
            lbNCCHT.Text = NCC.GetNCC(maNCC).sTenNCC;
            dtNgayNhap.Value = ngayNhap;
            lbTongTienHT.Text = Convert.ToString(tongTienPN);
            lbTrangThaiHT.Text = PhieuNhap.checkTrangThaiPN(trangThai);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ThongTinPN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhoThuocTayDataSet2.tblNhanVien' table. You can move, or remove it, as needed.
            this.tblNhanVienTableAdapter.Fill(this.quanLyKhoThuocTayDataSet2.tblNhanVien);
            this.tblNhanVienTableAdapter.Fill(this.quanLyKhoThuocTayDataSet2.tblNhanVien);
            this.sP_ChiTietPhieuNhapTableAdapter.Fill(this.quanLyKhoThuocTayDataSet2.SP_ChiTietPhieuNhap, maPN);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
