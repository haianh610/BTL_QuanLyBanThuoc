using BTL_QuanLyBanThuoc.Code;
using BTL_QuanLyBanThuoc.giaoDien;
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
    public partial class frmBanHang2 : Form
    {
        private string maHD;
        private string maNV;
        private string maKH;
        private DateTime ngayLap;
        private float tongTien;
        private int trangThai;
        private int phuongThuc;
        private float khachThanhToan;
        
        public frmBanHang2(HoaDon hd)
        {
            InitializeComponent();
            maHD = hd.sMaHD;
            maNV = hd.sMaNV;
            maKH = hd.sMaKH;
            ngayLap = hd.dNgayLap;
            tongTien = hd.fTongTien;
            trangThai = hd.iTrangThai;
            phuongThuc = hd.iPhuongThucThanhToan;
            lbMaHD.Text =  "Mã HD: "+maHD;

            lbNgayLap.Text = "Ngày lập: "+Convert.ToString(ngayLap);
            lbTongTien.Text = Convert.ToString(tongTien) + "đ";
            lbTrangThai.Text = HoaDon.checkTrangThaiHD(trangThai);
            switch (phuongThuc)
            {
                case 1:
                    rbTienMat.Checked = true;
                    break;
                case 2:
                    rbChuyenKhoan.Checked = true;
                    break;
                case 3:
                    rbThe.Checked = true;
                    break;
            }
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            this.sP_ChiTietHoaDonTableAdapter2.Fill(this.quanLyKhoThuocTayDataSet1.SP_ChiTietHoaDon, maHD);
            this.tblNhanVienTableAdapterDS1.Fill(this.quanLyKhoThuocTayDataSet1.tblNhanVien);
            this.tblKhachHangTableAdapter2.Fill(this.quanLyKhoThuocTayDataSet1.tblKhachHang);
            tblMatHangTableAdapter1.Fill(this.quanLyKhoThuocTayDataSet1.tblMatHang);
            comboBox2.SelectedValue = maNV;
            cbbKhachHang.SelectedValue = maKH;
        }

        private void dgvChiTietHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvChiTietHD.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                if (dgvChiTietHD.Columns[e.ColumnIndex].Name == "colXoaHang")
                {

                    ChucNangChiTietHoaDon.xoaChiTietHD(dbConnect.ConnectionString, maHD, dgvChiTietHD.CurrentRow.Cells["sMaHang"].Value.ToString());
                    this.sP_ChiTietHoaDonTableAdapter2.Fill(this.quanLyKhoThuocTayDataSet1.SP_ChiTietHoaDon, maHD);
                    tongTien = HoaDon.GetHoaDon(dbConnect.ConnectionString, maHD).fTongTien;
                    lbTongTien.Text = Convert.ToString(tongTien) + "đ";
                }
            }
        }




        //Timer check xem timKiemControl.chon đã true chưa (tức nà user đã chọn vào mặt hàng)
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tongTien != 0)
            {
                panelPhuongThucThanhToan.Visible = true;
                pannelTraTien.Visible = true;
            }
            else
            {
                rbTienMat.Checked = false;
                panelPhuongThucThanhToan.Visible = false;
                pannelTraTien.Visible = false;
            }

            if(tongTien != 0)
            {
                panelPhuongThucThanhToan.Visible = true;
                pannelTraTien.Visible = true;
            }
            else
            {
                rbTienMat.Checked = false;
                panelPhuongThucThanhToan.Visible = false;
                pannelTraTien.Visible = false;
            }
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            bool loi = false;
            string loiTrungHang = "";
            string loiSoLuong = "";

            if (ChucNangChiTietHoaDon.CheckExsitCTHD(maHD, cbbMatHang.SelectedValue.ToString()))
            {
                loiTrungHang = "Đã có hàng này trong hóa đơn";
                loi = true;
            }

            if (((int)nudSoLuong.Value) <= 0)
            {
                loiSoLuong = "Số sản phẩm không thể nhỏ hơn hoặc bằng 0";
                loi = true;
            }

            if (loi == true)
            {
                MessageBox.Show(loiTrungHang + "\n" + loiSoLuong, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    ChucNangChiTietHoaDon.themChiTietHD(dbConnect.ConnectionString, maHD, cbbMatHang.SelectedValue.ToString(), ((int)nudSoLuong.Value));
                    this.sP_ChiTietHoaDonTableAdapter2.Fill(this.quanLyKhoThuocTayDataSet1.SP_ChiTietHoaDon, maHD);
                    tongTien = HoaDon.GetHoaDon(dbConnect.ConnectionString, maHD).fTongTien;
                    lbTongTien.Text = Convert.ToString(tongTien) + "đ";
                }
                catch
                {
                    MessageBox.Show("Mã nhập không đúng");
                }
            }
            nudSoLuong.Value = 1;
        }


        private void loadTimKiemKhachHang()
        {
            foreach (KhachHang khachHang in KhachHang.listKH)
            {
                timKiemKHControl timKiem = new timKiemKHControl();
                timKiem.thongTin(khachHang);
                // Thêm userControl timKiem vào Container (Container ở đây là "Flow layout pannel")
                ketQuaKHContainer.Controls.Add(timKiem);
            }
        }




        private void txtKhachThanhToan_TextChanged(object sender, EventArgs e)
        {
            if (txtKhachThanhToan.TextLength>=1)
            {
                // Kiểm tra xem văn bản có chứa ký tự không phải số không
                if (!float.TryParse(txtKhachThanhToan.Text, out _))
                {
                    // Nếu có ký tự không phải số, loại bỏ ký tự đó từ văn bản
                    txtKhachThanhToan.Text = txtKhachThanhToan.Text.Remove(txtKhachThanhToan.Text.Length - 1);
                    // Đặt con trỏ văn bản ở cuối
                    txtKhachThanhToan.SelectionStart = txtKhachThanhToan.Text.Length;
                }
                else
                {
                    // Nếu văn bản hợp lệ, tính toán và hiển thị 
                    float tienKhachTra = float.Parse(txtKhachThanhToan.Text);
                    float soTienTraKhach = tienKhachTra - tongTien;
                    txtSoTienTraKhach.Text = Convert.ToString(soTienTraKhach);
                }
            }
            else
                txtSoTienTraKhach.Text = "";
        }
        
        private int phuongThucRadioButton()
        {
            int phuongThuc;

            if (rbTienMat.Checked)
            {
                phuongThuc = 1;
            }
            else if (rbChuyenKhoan.Checked)
            {
                phuongThuc = 2;
            }
            else if (rbThe.Checked)
            {
                phuongThuc = 3;
            }
            else
                phuongThuc = 0;

            return phuongThuc;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            bool loi = false;
            string loiKhongCTHD="";
            string loiChuaNhapKhachThanhToan = "";
            string loiTienKhachTra="";
            string loiChuaNhapKhachHang = "";

            if(cbbKhachHang.SelectedValue == null)
            {
                loiChuaNhapKhachHang = "Chưa nhập khách hàng vào hóa đơn";
            }

            if (ChucNangChiTietHoaDon.CheckExsitCTHD(maHD)==false)
            {
                loiKhongCTHD = "\nChưa có chi tiết hóa đơn để thanh toán";
                loi = true;
            }
            if(tongTien !=0)
            {
                if (txtKhachThanhToan.TextLength <= 0|| txtKhachThanhToan.Text == "")
                {
                    loiChuaNhapKhachThanhToan = "\nChưa nhập số tiền khách thanh toàn";
                    loi = true;
                }else
                if (Convert.ToSingle(txtSoTienTraKhach.Text) < 0 || Convert.ToSingle(txtKhachThanhToan.Text) < tongTien)
                {
                    loiTienKhachTra = "\nTiền khách trả không được nhỏ hơn tổng tiền hóa đơn";
                    loi = true;
                }
            }

            if(loi == false)
            {
                trangThai = 1;
                maKH = timKiemKHControl.maKhach;
                maNV = comboBox2.SelectedValue.ToString();
                khachThanhToan = float.Parse(txtKhachThanhToan.Text);
                HoaDon HDluu = new HoaDon(maHD, maNV, maKH, ngayLap, tongTien, trangThai, phuongThucRadioButton(),khachThanhToan);
                HoaDon.suaHD(dbConnect.ConnectionString, HDluu);
                skipMessageClose = true;
                this.Close();
            }
            else
            {
                MessageBox.Show(loiChuaNhapKhachHang+loiKhongCTHD + loiTienKhachTra + loiChuaNhapKhachThanhToan, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }





        private void btnLuuTam_Click(object sender, EventArgs e)
        {
            trangThai = 0;
            maKH = timKiemKHControl.maKhach;
            maNV = comboBox2.SelectedValue.ToString();
            if (khachThanhToan != 0)
                khachThanhToan = float.Parse(txtKhachThanhToan.Text);
            if (maKH == "")
                maKH = null;
            HoaDon HDluu = new HoaDon(maHD, maNV, maKH, ngayLap, tongTien, trangThai, phuongThucRadioButton(), khachThanhToan);
            HoaDon.suaHD(dbConnect.ConnectionString, HDluu);
            skipMessageClose = true;
            this.Close();
        }

        private bool skipMessageClose = false;
        private void frmBanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (skipMessageClose==false)
            {
                DialogResult chon = MessageBox.Show("Hóa đơn chưa được lưu, bạn có muốn lưu tạm hóa đơn này chứ ?\n(Nếu chọn No sẽ xóa hết thông tin hóa đơn đang nhập)", "Lưu tạm hóa đơn", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (chon == DialogResult.Yes)
                {
                    btnLuuTam_Click(sender, e);
                }
                else if (chon == DialogResult.No)
                {
                    HoaDon.xoaHD(dbConnect.ConnectionString, maHD);
                }
                else if (chon == DialogResult.Cancel)
                    e.Cancel = true;
            }

        }
    }
}
