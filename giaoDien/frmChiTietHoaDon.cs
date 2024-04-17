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
    public partial class frmChiTietHoaDon : Form
    {
        private string maHD;
        private string maNV;
        private string maKH;
        private DateTime ngayLap;
        private float tongTien;
        private int trangThai;
        public frmChiTietHoaDon(HoaDon hd)
        {
            InitializeComponent();
            maHD = hd.sMaHD;
            maNV = hd.sMaNV;
            maKH = hd.sMaKH;
            ngayLap = hd.dNgayLap;
            tongTien = hd.fTongTien;
            //trangThai = hd.iTrangThai;
            txtMaHD.Text = hd.sMaHD;
            cboMaKH.Text = maKH;
        }



        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhoThuocTayDataSet.tblNhanVien' table. You can move, or remove it, as needed.
            //this.tblNhanVienTableAdapter.Fill(this.quanLyKhoThuocTayDataSet.tblNhanVien);
            // TODO: This line of code loads data into the 'quanLyKhoThuocTayDataSet.vw_ChiTietHoaDon' table. You can move, or remove it, as needed.
            this.tblKhachHangTableAdapter1.Fill(this.quanLyKhoThuocTayDataSet.tblKhachHang);
            this.tblMatHangTableAdapter1.Fill(this.quanLyKhoThuocTayDataSet.tblMatHang);
            this.tblNhanVienTableAdapter.Fill(this.quanLyKhoThuocTayDataSet.tblNhanVien);
            this.sP_ChiTietHoaDonTableAdapter.Fill(this.quanLyKhoThuocTayDataSet.SP_ChiTietHoaDon, maHD);
        }
        private void btnThemCTHD_Click(object sender, EventArgs e)
        {
            //if (Program.checkMa(dbConnect.ConnectionString, "tblChiTietHoaDon", "sMaHang", cboMaHang.Text))
            //{
            //    MessageBox.Show("Đã có hàng");
            //    return;
            //}
            
            
                ChucNangChiTietHoaDon.themChiTietHD(dbConnect.ConnectionString, maHD, cboMaHang.Text, ((int)nudSoLuong.Value));
                this.sP_ChiTietHoaDonTableAdapter.Fill(this.quanLyKhoThuocTayDataSet.SP_ChiTietHoaDon, txtMaHD.Text);
                txtTongTien.Text = Convert.ToString(Convert.ToInt32(txtTongTien.Text) + Convert.ToInt32(txtThanhTien.Text));
            
        }

        private void btnXoaCTHD_Click(object sender, EventArgs e)
        {
            ChucNangChiTietHoaDon.xoaChiTietHD(dbConnect.ConnectionString, maHD,cboMaHang.Text);
            this.sP_ChiTietHoaDonTableAdapter.Fill(this.quanLyKhoThuocTayDataSet.SP_ChiTietHoaDon, txtMaHD.Text);
            txtTongTien.Text = Convert.ToString(Convert.ToInt32(txtTongTien.Text) - Convert.ToInt32(txtThanhTien.Text));
        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            HoaDon luuHD = new HoaDon();
            luuHD.sMaHD = txtMaHD.Text;
            luuHD.sMaKH = cboMaKH.Text;
            luuHD.sMaNV = cboMaNV.Text;
            luuHD.dNgayLap = dtpNgayBan.Value;
            luuHD.fTongTien = float.Parse(txtTongTien.Text);
            luuHD.iTrangThai = 1;

            HoaDon.suaHD(dbConnect.ConnectionString, luuHD);      
            this.Close();
        }

        private void btnHuyHD_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show("Chắc chắn hủy Hóa đơn "+txtMaHD.Text+" không ? ", "Some Title", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (chon == DialogResult.Yes)
            {
                HoaDon.huyHD(dbConnect.ConnectionString, txtMaHD.Text);
                this.Close();
            }
            else if (chon == DialogResult.No)
            {
                //do something else
            }
        }

        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            float thanhTien = int.Parse(txtDonGia.Text) * Convert.ToInt32(nudSoLuong.Value);
            txtThanhTien.Text = Convert.ToString(thanhTien);
        }

        private void btnSuaCTHD_Click(object sender, EventArgs e)
        {
            ChucNangChiTietHoaDon.suaChiTietHD(dbConnect.ConnectionString, maHD, cboMaHang.Text, nudSoLuong.DecimalPlaces, float.Parse(txtThanhTien.Text));
            this.sP_ChiTietHoaDonTableAdapter.Fill(this.quanLyKhoThuocTayDataSet.SP_ChiTietHoaDon, txtMaHD.Text);
            txtTongTien.Text = Convert.ToString(Convert.ToInt32(txtTongTien.Text) + Convert.ToInt32(txtThanhTien.Text));
        }
    }
}
