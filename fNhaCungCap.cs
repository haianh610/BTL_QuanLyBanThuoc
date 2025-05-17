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


namespace BTL_QuanLyBanThuoc
{
    public partial class fNhaCungCap : Form
    {
        public fNhaCungCap()
        {
            InitializeComponent();
        }




        //###########################  CHỨC NĂNG THÊM-SỬA-XÓA-TÌM KIẾM ###########################################################################################
        //--------------------------BUTTON LƯU--------------------------
        private void btnLuuNCC_Click(object sender, EventArgs e)
        {
            int iTrangThai = 0;
            string sMaNCC, sTenNCC, sDiaChi, sSdtNCC,sMaSoThue;
            sMaNCC = txbMaNCC.Text;
            sTenNCC = txbTenNCC.Text;
            sDiaChi = txbDiaChi.Text;
            sSdtNCC = txbSDT.Text;
            sMaSoThue = txtMaSoThue.Text;


            ThuVienChung tv = new ThuVienChung();

            string Tencu = tv.LayGiaTriCu<string>("tblNhaCungCap", "sTenNCC", "sMaNCC", sMaNCC);
            string DiaChicu = tv.LayGiaTriCu<string>("tblNhaCungCap", "sDiaChi", "sMaNCC", sMaNCC);
            string Sdtcu = tv.LayGiaTriCu<string>("tblNhaCungCap", "sSdtNCC", "sMaNCC", sMaNCC);



            if (txbMaNCC.Text != "" && txbTenNCC.Text != "" && txbDiaChi.Text != "" && txbSDT.Text != "")
            {
                iTrangThai = 1;
            }
            else
            {
                MessageBox.Show("Thông tin nhà cung cấp chưa hoàn thiện! Thông tin đã được lưu nháp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bool Ma = ThuVienChung.CheckExsit("tblNhaCungCap", "sMaNCC", sMaNCC);
            if (NhaCungCap.checkThem(Ma, sTenNCC, Tencu, sDiaChi, DiaChicu, sSdtNCC, Sdtcu))
            {
                //btnSuaNCC.Visible = false;
                //btnThemNCC.Visible = true;

                //btnThem(btnThemNCC, EventArgs.Empty);


                bool t = NhaCungCap.ThemNCC(sMaNCC, sTenNCC, sDiaChi, sSdtNCC, iTrangThai,sMaSoThue);
                if (t)
                {
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ThuVienChung.Hien("vwNhaCungCap", viewNCC);
                }
                else
                {
                    MessageBox.Show("Nhà Cung Cấp đã tồn tại! Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (NhaCungCap.checkThem(Ma, sTenNCC, Tencu, sDiaChi, DiaChicu, sSdtNCC, Sdtcu) == false)
            {
                // Hiển thị cảnh báo thông tin chỉnh sửa
                List<string> thongTinChinhSua = new List<string>();


                if (sTenNCC != Tencu)
                { thongTinChinhSua.Add("Tên nhà cung cấp từ " + Tencu + " thành " + sTenNCC + ","); };

                if (sDiaChi != DiaChicu)
                { thongTinChinhSua.Add("Địa chỉ từ " + DiaChicu + " thành " + sDiaChi + ","); };

                if (sSdtNCC != Sdtcu)
                { thongTinChinhSua.Add("số điện thoại từ " + Sdtcu + " thành " + sSdtNCC + ","); };

                string message = "Nhà cung cấp đã tồn tại.Bạn chắc chắn muốn thực hiện sửa đổi nhà cung cấp " + sMaNCC + ":\n" +
                string.Join("\n", thongTinChinhSua.ToArray()) + "\nKhông thể hoàn tác sau khi sửa đổi.";

                DialogResult result = MessageBox.Show(message, "Xác nhận sửa đổi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    bool s = NhaCungCap.SuaNCC(sMaNCC, sTenNCC, sDiaChi, sSdtNCC,sMaSoThue);
                    if (s)
                    {
                        MessageBox.Show("Sửa thành công!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ThuVienChung.Hien("vwNhaCungCap", viewNCC);
                    }
                    else
                    { MessageBox.Show("Sửa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }


        //--------------------------BUTTON XÓA--------------------------
        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            ThuVienChung t = new ThuVienChung();
            string sMaNCC, sTenNCC, sDiaChi, sSdtNCC;
            sMaNCC = txbMaNCC.Text;
            sTenNCC = txbTenNCC.Text;
            int iTrangThai;

            if (txbMaNCC.Text == "" && txbTenNCC.Text == "" && txbDiaChi.Text == "" && txbSDT.Text == "")
            {
                MessageBox.Show("Nhập thông tin nhà cung cấp để xóa mặt hàng!!", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                iTrangThai = t.LayGiaTriCu<int>("tblNhaCungCap", "iTrangThai", "sMaNCC", sMaNCC);
                if (iTrangThai != 2)
                {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa Nhà cung cấp " + sMaNCC, "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        bool i = ThuVienChung.Xoa("tblNhaCungCap", "sMaNCC", sMaNCC);
                        if (i)
                        {
                            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ThuVienChung.Hien("vwNhaCungCap", viewNCC);
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nhà cung cấp đã ở trạng thái dừng cung cấp!", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }

            }
        }

        //--------------------------BUTTON TÌM KIẾM--------------------------
        private void txbTimNCC_TextChanged(object sender, EventArgs e)
        {
            string inputValue = txbTimNCC.Text;
            ThuVienChung.TimKiem("TimKiemNCC", "@inputValue", inputValue, viewNCC);
        }

        //######################################### SỰ KIỆN MÀN HÌNH ############################################################################
        // Datagridview
        private void viewNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbMaNCC.Text = viewNCC.CurrentRow.Cells["Mã Nhà Cung Cấp"].Value.ToString();
            txbTenNCC.Text = viewNCC.CurrentRow.Cells["Tên Nhà Cung Cấp"].Value.ToString();
            txbDiaChi.Text = viewNCC.CurrentRow.Cells["Địa Chỉ"].Value.ToString();
            txbSDT.Text = viewNCC.CurrentRow.Cells["Số Điện Thoại"].Value.ToString();
            txtMaSoThue.Text = viewNCC.CurrentRow.Cells["Mã số thuế"].Value.ToString();
        }
        // Form View
        private void fNhaCungCap_Load(object sender, EventArgs e)
        {
            ThuVienChung.Hien("vwNhaCungCap", viewNCC);
        }
        //-----------------------HIỂN THỊ LẠI CỘT TRẠNG THÁI-------------------------------
        private void viewNCC_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.viewNCC.Columns[e.ColumnIndex].Name == "Trạng Thái")
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
                        e.Value = "Dừng cung cấp";
                    }
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
