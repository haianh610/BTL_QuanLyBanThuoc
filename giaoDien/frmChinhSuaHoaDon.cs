using BTL_QuanLyBanThuoc.Code;
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
        public frmBanHang(HoaDon hd)
        {
            InitializeComponent();
            maHD = hd.sMaHD;
            maNV = hd.sMaNV;
            maKH = hd.sMaKH;
            ngayLap = hd.dNgayLap;
            tongTien = hd.fTongTien;
            trangThai = hd.iTrangThai;
            //trangThai = hd.iTrangThai;
            lbMaHD.Text =  "Mã HD: "+maHD;
            lbKhachHang.Text = maKH;
            lbNgayLap.Text = "Ngày lập: "+Convert.ToString(ngayLap);
            lbTongTien.Text = Convert.ToString(tongTien) + "đ";
            lbTrangThai.Text = HoaDon.checkTrangThaiHD(hd.iTrangThai);
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            this.sP_ChiTietHoaDonTableAdapter2.Fill(this.quanLyKhoThuocTayDataSet1.SP_ChiTietHoaDon, maHD);
            this.tblNhanVienTableAdapterDS1.Fill(this.quanLyKhoThuocTayDataSet1.tblNhanVien);
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
                timKiemControl timKiem = new timKiemControl();
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
                timKiemControl timKiem = new timKiemControl();
                timKiem.kqTimKiem(txtMaHang.Text);
                loadTimKiem();
                ketQuaContainer.Height = ketQuaContainer.Controls.Count * 54;
            }
            else
            {
                timKiemControl.maHang = "";
                ketQuaContainer.Height = 0;
            }
        }

        private bool daChonVaChuyen;
        //Timer check xem timKiemControl.chon đã true chưa (tức nà user đã chọn vào mặt hàng)
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Ng dùng kích vào control
            if(timKiemControl.chon == true)
            {


                txtMaHang.Text = timKiemControl.maHang +" - " +timKiemControl.tenHang;
                daChonVaChuyen = true;
                nudSoLuong.Focus();

                //ẩn kết quả
                ketQuaContainer.Height = 0;
                ketQuaContainer.Controls.Clear();
                //reset lại trạng thái chọn về false
                timKiemControl.chon = false;
                // Đã chọn và chuyển sang nudSoLuong
            }
            if(tongTien != 0)
            {
                pannelPhuongThucThanhToan.Visible = true;
                pannelTraTien.Visible = true;
            }
            else
            {
                pannelPhuongThucThanhToan.Visible = false;
                pannelTraTien.Visible = false;
            }
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {

            if (txtMaHang.TextLength >= 5)
            {
                if (ChucNangChiTietHoaDon.CheckExsitCTHD("sMaHD", "sMaHang", maHD, timKiemControl.maHang))
                {
                    MessageBox.Show("Đã có hàng này trong hóa đơn");
                }
                else
                {
                    ChucNangChiTietHoaDon.themChiTietHD(dbConnect.ConnectionString, maHD, timKiemControl.maHang, ((int)nudSoLuong.Value));
                    this.sP_ChiTietHoaDonTableAdapter2.Fill(this.quanLyKhoThuocTayDataSet1.SP_ChiTietHoaDon, maHD);
                    tongTien = HoaDon.GetHoaDon(dbConnect.ConnectionString,maHD).fTongTien;
                    lbTongTien.Text = Convert.ToString(tongTien)+"đ";
                }
                nudSoLuong.Value = 1;
                txtMaHang.Font = new Font("Inter", 12, FontStyle.Italic); // Font Inter, cỡ 12, bình thường
                txtMaHang.ForeColor = Color.Gray; // Màu chữ xám
                txtMaHang.Text = "Tìm kiếm sản phẩm (mã /tên)";
            }
        }

        private void txtMaHang_Enter(object sender, EventArgs e)
        {
            if(txtMaHang.Text == "Tìm kiếm sản phẩm (mã /tên)")
            {
                txtMaHang.Text = "";
                txtMaHang.Font = new Font("Inter", 14, FontStyle.Regular); // Font Inter, cỡ 14, bình thường
                txtMaHang.ForeColor = Color.Black; // Màu chữ đen
            }
            else
            {
                ketQuaContainer.Visible = true;
                ketQuaContainer.Height = ketQuaContainer.Controls.Count * 54;
            }


        }

        private void txtMaHang_Leave(object sender, EventArgs e)
        {
            if (!ketQuaContainer.ClientRectangle.Contains(ketQuaContainer.PointToClient(Cursor.Position)))
            {
                ketQuaContainer.Visible = false;
            }
            if (daChonVaChuyen==true)
                return;

            //txtMaHang.Font = new Font("Inter", 12, FontStyle.Italic); // Font Inter, cỡ 12, bình thường
            //txtMaHang.ForeColor = Color.Gray; // Màu chữ xám
            //txtMaHang.Text = "Tìm kiếm sản phẩm (mã /tên)";
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

        private void lbKhachThanhToan_Click(object sender, EventArgs e)
        {

        }
    }
}
