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
    public partial class frmBanHang : Form
    {
        private string maHD;
        private string maNV;
        private string maKH;
        private DateTime ngayLap;
        private float tongTien;
        private int trangThai;
        private int phuongThuc;
        private float khachThanhToan;
        
        public frmBanHang(HoaDon hd)
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
            txtKhachHang.Text = maKH;
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
            //timKiemMHControl.SubscribeToButtonClickEvent(chonHang);
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            this.sP_ChiTietHoaDonTableAdapter2.Fill(this.quanLyKhoThuocTayDataSet1.SP_ChiTietHoaDon, maHD);
            this.tblNhanVienTableAdapterDS1.Fill(this.quanLyKhoThuocTayDataSet1.tblNhanVien);
            comboBox2.SelectedValue = maNV;
            //string sql = "SELECT * FROM tblNhanVien ";
            //System.Data.SqlClient.SqlDataAdapter ad = new System.Data.SqlClient.SqlDataAdapter(sql, dbConnect.ConnectionString);
            //DataTable dt = new DataTable();
            //ad.Fill(dt);
            //comboBox1.DataSource = dt;
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

        private void txtMaHang_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ChucNangChiTietHoaDon.themChiTietHD(dbConnect.ConnectionString, maHD, txtMaHang.Text, ((int)nudSoLuong.Value));
                this.sP_ChiTietHoaDonTableAdapter2.Fill(this.quanLyKhoThuocTayDataSet1.SP_ChiTietHoaDon, maHD);

            }
        }

        private void loadTimKiem()
        {
            foreach(MatHang mh in MatHang.listMH)
            {
                timKiemMHControl timKiem = new timKiemMHControl();
                timKiem.thongTin(mh);
                //Thêm userControl timKiem vào Container (Container ở đây là "Flow layout pannel")
                ketQuaContainer.Controls.Add(timKiem);
            }
        }

        private void txtMaHang_TextChanged(object sender, EventArgs e)
        {
            if(txtMaHang.TextLength >= 1)
            {
                //Xóa kết quá tìm kiếm mỗi khi thay đổi chữ trong textbox
                ketQuaContainer.Controls.Clear();

                //Truyền text ở ô tìm kiếm vào hàm kqTimKiem
                timKiemMHControl timKiem = new timKiemMHControl();
                timKiem.kqTimKiem(txtMaHang.Text);
                loadTimKiem();
                ketQuaContainer.Height = ketQuaContainer.Controls.Count * 54;
            }
            else
            {
                timKiemMHControl.maHang = "";
                ketQuaContainer.Height = 0;
            }
        }

        public void chonHang(object sender, EventArgs e)
        {
            txtMaHang.Text = timKiemMHControl.maHang + " - " + timKiemMHControl.tenHang;
            daChonVaChuyen = true;
            nudSoLuong.Focus();

            //ẩn kết quả
            ketQuaContainer.Height = 0;
            ketQuaContainer.Controls.Clear();
            //reset lại trạng thái chọn về false
            timKiemMHControl.chon = false;
            // Đã chọn và chuyển sang nudSoLuong
        }

        private bool daChonVaChuyen;
        //Timer check xem timKiemControl.chon đã true chưa (tức nà user đã chọn vào mặt hàng)
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timKiemKHControl.chonKhach == true)
            {


                txtKhachHang.Text = timKiemKHControl.maKhach + " - " + timKiemKHControl.tenKhach;
                //daChonVaChuyen = true;

                //ẩn kết quả
                ketQuaKHContainer.Height = 0;
                ketQuaKHContainer.Controls.Clear();
                //reset lại trạng thái chọn về false
                timKiemKHControl.chonKhach = false;
                // Đã chọn và chuyển sang nudSoLuong
            }
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
            //Ng dùng kích vào control
            if (timKiemMHControl.chon == true)
            {


                txtMaHang.Text = timKiemMHControl.maHang +" - " +timKiemMHControl.tenHang;
                daChonVaChuyen = true;
                nudSoLuong.Focus();

                //ẩn kết quả
                ketQuaContainer.Height = 0;
                ketQuaContainer.Controls.Clear();
                //reset lại trạng thái chọn về false
                timKiemMHControl.chon = false;
                // Đã chọn và chuyển sang nudSoLuong
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
            if (txtMaHang.Text == "Tìm kiếm sản phẩm (mã /tên)")
                return;
            bool loi = false;
            string loiTrungHang = "";
            string loiSoLuong = "";

            if (ChucNangChiTietHoaDon.CheckExsitCTHD(maHD, timKiemMHControl.maHang)
                || ChucNangChiTietHoaDon.CheckExsitCTHD(maHD, txtMaHang.Text))
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
                if (txtMaHang.TextLength == 6)
                {
                    try
                    {
                        ChucNangChiTietHoaDon.themChiTietHD(dbConnect.ConnectionString, maHD, txtMaHang.Text, ((int)nudSoLuong.Value));
                        this.sP_ChiTietHoaDonTableAdapter2.Fill(this.quanLyKhoThuocTayDataSet1.SP_ChiTietHoaDon, maHD);
                        tongTien = HoaDon.GetHoaDon(dbConnect.ConnectionString, maHD).fTongTien;
                        lbTongTien.Text = Convert.ToString(tongTien) + "đ";
                        timKiemMHControl.maHang = null;
                    }
                    catch
                    {
                        MessageBox.Show("Mã nhập không đúng");
                    }
                }
                if (txtMaHang.TextLength > 6 && txtMaHang.Text != "Tìm kiếm sản phẩm (mã /tên)")
                {
                    try
                    {
                        ChucNangChiTietHoaDon.themChiTietHD(dbConnect.ConnectionString, maHD, timKiemMHControl.maHang, ((int)nudSoLuong.Value));
                        this.sP_ChiTietHoaDonTableAdapter2.Fill(this.quanLyKhoThuocTayDataSet1.SP_ChiTietHoaDon, maHD);
                        tongTien = HoaDon.GetHoaDon(dbConnect.ConnectionString, maHD).fTongTien;
                        lbTongTien.Text = Convert.ToString(tongTien) + "đ";
                        timKiemMHControl.maHang = null;
                    }
                    catch
                    {
                        MessageBox.Show("Mã nhập không đúng");
                    }
                }
            }
            nudSoLuong.Value = 1;
            txtMaHang.Font = new Font("Inter", 12, FontStyle.Italic); // Font Inter, cỡ 12, bình thường
            txtMaHang.ForeColor = Color.Gray; // Màu chữ xám
            txtMaHang.Text = "Tìm kiếm sản phẩm (mã /tên)";
        }

        private void txtMaHang_Enter(object sender, EventArgs e)
        {
            if(txtMaHang.Text == "Tìm kiếm sản phẩm (mã /tên)")
            {
                txtMaHang.Text = "";
                txtMaHang.Font = new Font("Inter", 12, FontStyle.Regular); // Font Inter, cỡ 14, bình thường
                txtMaHang.ForeColor = Color.Black; // Màu chữ đen
            }
            else
            {
                ketQuaContainer.Height = ketQuaContainer.Controls.Count * 54;
            }


        }

        private void txtMaHang_Leave(object sender, EventArgs e)
        {
            if (!ketQuaContainer.ClientRectangle.Contains(ketQuaContainer.PointToClient(Cursor.Position)))
            {
                ketQuaContainer.Height = 0;
            }
            if (daChonVaChuyen==true)
                return;
            if(txtMaHang.TextLength == 0)
            {
                nudSoLuong.Value = 1;
                txtMaHang.Font = new Font("Inter", 12, FontStyle.Italic); // Font Inter, cỡ 12, bình thường
                txtMaHang.ForeColor = Color.Gray; // Màu chữ xám
                txtMaHang.Text = "Tìm kiếm sản phẩm (mã /tên)";
            }
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

        private void txtKhachHang_TextChanged(object sender, EventArgs e)
        {
            if (txtKhachHang.TextLength >= 1)
            {
                // Xóa kết quả tìm kiếm mỗi khi thay đổi chữ trong textbox
                ketQuaKHContainer.Controls.Clear();

                // Truyền text ở ô tìm kiếm vào hàm kqTimKiem
                timKiemKHControl timKiem = new timKiemKHControl();
                timKiem.kqTimKiem(txtKhachHang.Text);
                loadTimKiemKhachHang();
                ketQuaKHContainer.Height = ketQuaKHContainer.Controls.Count * 54;
            }
            else
            {
                timKiemKHControl.maKhach = "";
                ketQuaKHContainer.Height = 0;
            }
        }


        private void nudSoLuong_Leave(object sender, EventArgs e)
        {
            daChonVaChuyen = false;
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

            if(txtKhachHang.TextLength==0||timKiemKHControl.maKhach == null)
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

        private void txtKhachHang_Enter(object sender, EventArgs e)
        {
            if (txtKhachHang.Text == "Nhập khách hàng")
            {
                txtKhachHang.Text = "";
                txtKhachHang.Font = new Font("Inter", 12, FontStyle.Regular); // Font Inter, cỡ 14, bình thường
                txtKhachHang.ForeColor = Color.Black; // Màu chữ đen
            }
            else
            {
                ketQuaKHContainer.Height = ketQuaKHContainer.Controls.Count * 54;
            }
        }

        private void txtKhachHang_Leave(object sender, EventArgs e)
        {
            if (!ketQuaKHContainer.ClientRectangle.Contains(ketQuaKHContainer.PointToClient(Cursor.Position)))
            {
                ketQuaKHContainer.Height = 0;
            }
            if (txtKhachHang.TextLength == 0)
            {
                txtKhachHang.Font = new Font("Inter", 12, FontStyle.Italic); // Font Inter, cỡ 12, bình thường
                txtKhachHang.ForeColor = Color.Gray; // Màu chữ xám
                txtKhachHang.Text = "Nhập khách hàng";
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
