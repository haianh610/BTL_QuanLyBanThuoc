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
    public partial class ChiTietPhieuNhap : Form
    {
        private string maPN;
        private string maNV;
        private DateTime ngayNhap;
        private string maNCC;
        private float tongTienPN;
        private int trangThai;
        private int phuongThuc;
        private float NCCThanhToan;
        public ChiTietPhieuNhap(PhieuNhap pn)
        {
            InitializeComponent();
            maPN = pn.sMaPN;
            maNV = pn.sMaNV;
            maNCC = pn.sMaNCC;
            ngayNhap = pn.dNgayNhap;
            tongTienPN = pn.fTongTienPN;
            trangThai = pn.iTrangThai;
            phuongThuc = pn.iPhuongThucThanhToan;
            lbMaPN.Text = "Mã PN: " + maPN;
            lbNgayLap.Text = "Ngày Nhập: " + Convert.ToString(ngayNhap);
            lbTongTien.Text = Convert.ToString(tongTienPN) + "đ";
            lbTrangThai.Text = PhieuNhap.checkTrangThaiPN(trangThai);
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

        private void ChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhoThuocTayDataSet2.tblNhanVien' table. You can move, or remove it, as needed.
            //this.tblNhanVienTableAdapter.Fill(this.quanLyKhoThuocTayDataSet.tblNhanVien);
            this.sP_ChiTietPhieuNhapTableAdapter.Fill(this.quanLyKhoThuocTayDataSet2.SP_ChiTietPhieuNhap, maPN);
            this.tblNhaCungCapTableAdapter1.Fill(this.quanLyKhoThuocTayDataSet2.tblNhaCungCap);
            this.tblNhanVienTableAdapter.Fill(this.quanLyKhoThuocTayDataSet1.tblNhanVien);
            comboBox2.SelectedValue = maNV;
            cbbNhaCungCap.SelectedValue = maNCC;
        }

        private void lbKhachHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvChiTietPN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvChiTietPhieuNhap.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                if (dgvChiTietPhieuNhap.Columns[e.ColumnIndex].Name == "colXoaHang")
                {
                    ChucNangChiTietPhieuNhap.xoaChiTietPN(dbConnect.ConnectionString, maPN, dgvChiTietPhieuNhap.CurrentRow.Cells["sMaHang"].Value.ToString());
                    this.sP_ChiTietPhieuNhapTableAdapter.Fill(this.quanLyKhoThuocTayDataSet2.SP_ChiTietPhieuNhap, maPN);
                    tongTienPN = PhieuNhap.GetPN(dbConnect.ConnectionString, maPN).fTongTienPN;
                    lbTongTien.Text = Convert.ToString(tongTienPN) + "đ";
                }
            }
        }
        // KeyDown dùng làm gì
        private void txtMaHang_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void loadTimKiem()
        {
            foreach (MatHang mh in MatHang.listMH)
            {
                timKiemMHPNControl timKiem = new timKiemMHPNControl();
                timKiem.thongTin(mh);
                //Thêm userControl timKiem vào Container (Container ở đây là "Flow layout pannel")
                ketQuaContainer.Controls.Add(timKiem);
            }
        }

        private void txtMaHang_TextChanged(object sender, EventArgs e)
        {
            if (txtMaHang.TextLength >= 1)
            {
                //Xóa kết quá tìm kiếm mỗi khi thay đổi chữ trong textbox
                ketQuaContainer.Controls.Clear();

                //Truyền text ở ô tìm kiếm vào hàm kqTimKiem
                timKiemMHPNControl timKiem = new timKiemMHPNControl();
                timKiem.kqTimKiem(txtMaHang.Text);
                loadTimKiem();
                ketQuaContainer.Height = ketQuaContainer.Controls.Count * 54;
            }
            else
            {
                timKiemMHPNControl.maHang = "";
                ketQuaContainer.Height = 0;
            }
        }
        private bool daChonVaChuyen;
        public void chonHang(object sender, EventArgs e)
        {
            txtMaHang.Text = timKiemMHPNControl.maHang + " - " + timKiemMHPNControl.tenHang;
            daChonVaChuyen = true;
            nudSoLuong.Focus();

            //ẩn kết quả
            ketQuaContainer.Height = 0;
            ketQuaContainer.Controls.Clear();
            //reset lại trạng thái chọn về false
            timKiemMHPNControl.chon = false;
            // Đã chọn và chuyển sang nudSoLuong
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Ng dùng kích vào control
            if (timKiemMHPNControl.chon == true)
            {
                txtMaHang.Text = timKiemMHPNControl.maHang + " - " + timKiemMHPNControl.tenHang;
                daChonVaChuyen = true;
                nudSoLuong.Focus();

                //ẩn kết quả
                ketQuaContainer.Height = 0;
                ketQuaContainer.Controls.Clear();
                //reset lại trạng thái chọn về false
                timKiemMHPNControl.chon = false;
                // Đã chọn và chuyển sang nudSoLuong
            }
            if (tongTienPN != 0)
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
        private void txtMaHang_Enter(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "Tìm kiếm sản phẩm (mã /tên)")
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
            if (daChonVaChuyen == true)
                return;
            if (txtMaHang.TextLength == 0)
            {
                nudSoLuong.Value = 1;
                txtMaHang.Font = new Font("Inter", 12, FontStyle.Italic); // Font Inter, cỡ 12, bình thường
                txtMaHang.ForeColor = Color.Gray; // Màu chữ xám
                txtMaHang.Text = "Tìm kiếm sản phẩm (mã /tên)";
            }
        }



        private void rbThe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "Tìm kiếm sản phẩm (mã /tên)")
                return;
            float giaNhap = float.Parse(txtGiaNhap.Text);
            bool loi = false;
            string loiTrungHang = "";
            string loiSoLuong = "";

            if (ChucNangChiTietPhieuNhap.CheckExistCTPN(maPN, timKiemMHPNControl.maHang)
                || ChucNangChiTietPhieuNhap.CheckExistCTPN(maPN, txtMaHang.Text))
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
                        ChucNangChiTietPhieuNhap.themChiTietPN(dbConnect.ConnectionString, maPN, txtMaHang.Text, ((int)nudSoLuong.Value), giaNhap,dtpNSX.Value,dtpHSD.Value);
                        this.sP_ChiTietPhieuNhapTableAdapter.Fill(this.quanLyKhoThuocTayDataSet2.SP_ChiTietPhieuNhap, maPN);
                        tongTienPN = PhieuNhap.GetPN(dbConnect.ConnectionString, maPN).fTongTienPN;
                        lbTongTien.Text = Convert.ToString(tongTienPN) + "đ";
                        timKiemMHPNControl.maHang = null;
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
                        ChucNangChiTietPhieuNhap.themChiTietPN(dbConnect.ConnectionString, maPN, timKiemMHPNControl.maHang, ((int)nudSoLuong.Value),giaNhap,dtpNSX.Value,dtpHSD.Value);
                        this.sP_ChiTietPhieuNhapTableAdapter.Fill(this.quanLyKhoThuocTayDataSet2.SP_ChiTietPhieuNhap, maPN);
                        tongTienPN = PhieuNhap.GetPN(dbConnect.ConnectionString, maPN).fTongTienPN;
                        lbTongTien.Text = Convert.ToString(tongTienPN) + "đ";
                        timKiemMHPNControl.maHang = null;
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


        private void nudSoLuong_Leave(object sender, EventArgs e)
        {
            daChonVaChuyen = false;
        }
        private void txtNCCThanhToan_TextChanged(object sender, EventArgs e)
        {
            if (txtNCCThanhToan.TextLength >= 1)
            {
                // Kiểm tra xem văn bản có chứa ký tự không phải số không
                if (!float.TryParse(txtNCCThanhToan.Text, out _))
                {
                    // Nếu có ký tự không phải số, loại bỏ ký tự đó từ văn bản
                    txtNCCThanhToan.Text = txtNCCThanhToan.Text.Remove(txtNCCThanhToan.Text.Length - 1);
                    // Đặt con trỏ văn bản ở cuối
                    txtNCCThanhToan.SelectionStart = txtNCCThanhToan.Text.Length;
                }
                else
                {
                    // Nếu văn bản hợp lệ, tính toán và hiển thị 
                    float tienKhachTra = float.Parse(txtNCCThanhToan.Text);
                    float soTienTraKhach = tienKhachTra - tongTienPN;
                    txtSoTienTra.Text = Convert.ToString(soTienTraKhach);
                }
            }
            else
                txtSoTienTra.Text = "";
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
            string loiKhongCTPN = "";
            string loiChuaNhapNCCThanhToan = "";
            string loiTienKhachTra = "";

            if (ChucNangChiTietPhieuNhap.CheckExistCTPN(maPN) == false)
            {
                loiKhongCTPN = "Chưa có chi tiết hóa đơn để thanh toán";
                loi = true;
            }
            if (tongTienPN != 0)
            {
                if (txtNCCThanhToan.TextLength <= 0 || txtNCCThanhToan.Text == "")
                {
                    loiChuaNhapNCCThanhToan = "\nChưa nhập số tiền khách thanh toán";
                    loi = true;
                }
                else
                if (Convert.ToSingle(txtSoTienTra.Text) < 0 || Convert.ToSingle(txtNCCThanhToan.Text) < tongTienPN)
                {
                    loiTienKhachTra = "\nTiền khách trả không được nhỏ hơn tổng tiền hóa đơn";
                    loi = true;
                }
            }

            if (loi == false)
            {
                trangThai = 1;
                maNCC = cbbNhaCungCap.SelectedValue.ToString();
                maNV = comboBox2.SelectedValue.ToString();
                NCCThanhToan = float.Parse(txtNCCThanhToan.Text);
                PhieuNhap HDluu = new PhieuNhap(maPN, maNV, ngayNhap, maNCC, tongTienPN, trangThai, phuongThucRadioButton(), NCCThanhToan);
                PhieuNhap.suaPN(dbConnect.ConnectionString, HDluu);
                this.Close();
            }
            else
            {
                MessageBox.Show(loiKhongCTPN + loiTienKhachTra + loiChuaNhapNCCThanhToan, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


    }
}
