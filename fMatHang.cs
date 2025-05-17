using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using BTL_QuanLyBanThuoc.Code;

namespace BTL_QuanLyBanThuoc
{
    public partial class fMatHang : Form
    {
        public fMatHang()
        {
            InitializeComponent();
        }

        //######################################### SỰ KIỆN CHỨC NĂNG ############################################################################

        //--------------------------BUTTON LƯU--------------------------
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sMaLH, sMaHang, sTenHang, sDVT, sHangSX, sMaNCC;
            int iSoLuong;
            int iTrangThai = 0;
            double fDonGia;
            sMaLH = cbxDSLH.SelectedValue.ToString();
            sMaHang = txtMaHang.Text;
            sTenHang = txtTenHang.Text;
            //iSoLuong = int.Parse(txtSoLuong.Text);
            sDVT = txtDonVi.Text;
            //fDonGia = double.Parse(txtDonGia.Text);
            sHangSX = cbxDSHangSX.Text;
            sMaNCC = cbxDSNCC.SelectedValue.ToString();

               

                ThuVienChung tv = new ThuVienChung();
            string MaLHcu = tv.LayGiaTriCu<string>("tblMatHang", "sMaLH", "sMaHang", sMaHang);
            string Tencu = tv.LayGiaTriCu<string>("tblMatHang", "sTenHang", "sMaHang", sMaHang);
            string DVTcu = tv.LayGiaTriCu<string>("tblMatHang", "sDVT", "sMaHang", sMaHang);
            string HangSXcu = tv.LayGiaTriCu<string>("tblMatHang", "sHangSX", "sMaHang", sMaHang);
            int Soluongcu = tv.LayGiaTriCu<int>("tblMatHang", "iSoLuong", "sMaHang", sMaHang);
            double DonGiacu = tv.LayGiaTriCu<double>("tblMatHang", "fDonGia", "sMaHang", sMaHang);



            if (txtMaHang.Text != "" && txtTenHang.Text != "" && cbxDSLH.Text != "" && cbxDSNCC.Text != "" && txtSoLuong.Text != "" && txtDonVi.Text != "" && txtDonGia.Text != "")
            {
                iTrangThai = 1;
                iSoLuong = int.Parse(txtSoLuong.Text);
                fDonGia = double.Parse(txtDonGia.Text);

            }
            else
            {
                iSoLuong = 0;
                fDonGia = 0;
                MessageBox.Show("Thông tin mặt hàng chưa hoàn thiện! Mặt hàng đã được lưu nháp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            bool Ma = ThuVienChung.CheckExsit("tblMatHang", "sMaHang", sMaHang);
            if (MatHang.checkThem(Ma, sMaLH, MaLHcu, sTenHang, Tencu, iSoLuong, Soluongcu, sDVT, DVTcu, DonGiacu, fDonGia, sHangSX, HangSXcu))
            {
                //btnSuaNCC.Visible = false;
                //btnThemNCC.Visible = true;

                //btnThem(btnThemNCC, EventArgs.Empty);
                

                bool t = MatHang.ThemMH(sMaLH, sMaHang, sTenHang, iSoLuong, sDVT, fDonGia, sHangSX, sMaNCC, iTrangThai);
                if (t)
                {
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ThuVienChung.Hien("vwMatHang", viewMH);
                }
                else
                {
                    MessageBox.Show("Mặt hàng đã tồn tại! Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                
            }
            else if (MatHang.checkThem(Ma, sMaLH, MaLHcu, sTenHang, Tencu, iSoLuong, Soluongcu, sDVT, DVTcu, DonGiacu, fDonGia, sHangSX, HangSXcu) == false)
            {
                // Hiển thị cảnh báo thông tin chỉnh sửa
                List<string> thongTinChinhSua = new List<string>();

                if (sMaLH != MaLHcu)
                { thongTinChinhSua.Add("Đơn vị tính từ " + DVTcu + " thành " + sDVT + ","); }

                if (sTenHang != Tencu)
                { thongTinChinhSua.Add("Tên mặt hàng từ " + Tencu + " thành " + sTenHang + ","); }

                if (iSoLuong != Soluongcu)
                { thongTinChinhSua.Add("Số lượng từ " + Soluongcu + " thành " + iSoLuong + ","); }

                if (sDVT != DVTcu)
                { thongTinChinhSua.Add("Đơn vị tính từ " + DVTcu + " thành " + sDVT + ","); }

                if (fDonGia != DonGiacu)
                { thongTinChinhSua.Add("Đơn gia từ " + DonGiacu + " thành " + fDonGia + ","); }

                if (sHangSX != HangSXcu)
                { thongTinChinhSua.Add("Hãng sản xuất từ " + HangSXcu + " thành " + sHangSX + ","); }


                string message = "Mặt hàng tồn tại.Bạn chắc chắn muốn thực hiện sửa đổi mặt hàng " + sMaHang + ":\n" +
                                 string.Join("\n", thongTinChinhSua.ToArray()) + "\nKhông thể hoàn tác sau khi sửa đổi.";

                DialogResult result = MessageBox.Show(message, "Xác nhận sửa đổi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    bool s = MatHang.SuaMH(sMaLH, sMaHang, sTenHang, iSoLuong, sDVT, fDonGia, sHangSX, sMaNCC);
                    if (s)
                    {
                        MessageBox.Show("Sửa thành công!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ThuVienChung.Hien("vwMatHang", viewMH);
                    }
                    else
                    { MessageBox.Show("Sửa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }


        //--------------------------BUTTON XÓA--------------------------
        private void btnXoaMH_Click(object sender, EventArgs e)
        {
            ThuVienChung t = new ThuVienChung();
            string sMaHang;
            int iTrangThai;
            if (txtMaHang.Text == "" && txtTenHang.Text == "" && cbxDSLH.Text == "" && cbxDSNCC.Text == "" )
            {
                MessageBox.Show("Nhập thông tin mặt hàng để xóa mặt hàng!!", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                sMaHang = txtMaHang.Text;
                iTrangThai = t.LayGiaTriCu<int>("tblMatHang","iTrangThai","sMaHang",sMaHang); 
                if(iTrangThai != 2)
                {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa mặt hàng " + sMaHang, "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        bool i = ThuVienChung.Xoa("tblMatHang", "sMaHang", sMaHang);
                        if (i)
                        {
                            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ThuVienChung.Hien("vwMatHang", viewMH);
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mặt hàng đã ở trạng thái ngừng bán!", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }

            }
        }

        //--------------------------BUTTON TÌM KIẾM--------------------------
        private void txbTimMH_TextChanged(object sender, EventArgs e)
        {
            string inputValue = txbTimMH.Text;
            ThuVienChung.TimKiem("TimKiemMH", "@inputValue", inputValue, viewMH);
        }



        //######################################### SỰ KIỆN MÀN HÌNH ############################################################################


        // Datagridview
        private void viewMH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbxDSLH.Text = viewMH.CurrentRow.Cells["Phân Loại"].Value.ToString();
            txtMaHang.Text = viewMH.CurrentRow.Cells["Mã Mặt Hàng"].Value.ToString();
            txtTenHang.Text = viewMH.CurrentRow.Cells["Tên Mặt Hàng"].Value.ToString();
            txtSoLuong.Text = viewMH.CurrentRow.Cells["Số Lượng"].Value.ToString();
            txtDonVi.Text = viewMH.CurrentRow.Cells["Đơn Vị"].Value.ToString();
            txtDonGia.Text = viewMH.CurrentRow.Cells["Đơn Giá"].Value.ToString();
            cbxDSHangSX.Text = viewMH.CurrentRow.Cells["Hãng SX"].Value.ToString();
            cbxDSNCC.Text = viewMH.CurrentRow.Cells["Nhà Cung Cấp"].Value.ToString();
        }

        // Form View
        private void fMatHang_Load(object sender, EventArgs e)
        {
            ThuVienChung.LayDuLieu("tblLoaiHang", "sTenLH", "sMaLH", cbxDSLH);
            ThuVienChung.LayDuLieu("tblNhaCungCap", "sTenNCC", "sMaNCC", cbxDSNCC);
            ThuVienChung.LayDuLieu("tblMatHang", "sHangSX", "sHangSX", cbxDSHangSX);
            ThuVienChung.Hien("vwMatHang", viewMH);
        }

        //-----------------------HIỂN THỊ LẠI CỘT TRẠNG THÁI-------------------------------
        private void viewMH_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.viewMH.Columns[e.ColumnIndex].Name == "Trạng Thái")
            {
                if (e.Value != null)
                {
                    int trangThai = int.Parse(e.Value.ToString());
                    if (trangThai == 1)
                    {
                        e.Value = "Hiện hành";
                    }
                    else if (trangThai == 0)
                    {
                        e.Value = "Lưu nháp";
                    }
                    else if (trangThai == 2)
                    {
                        e.Value = "Dừng bán";
                    }
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
