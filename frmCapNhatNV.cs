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
    public partial class frmCapNhatNV : Form
    {
        private string maNV;
        private string tenNV;
        private int gioiTinh;
        private DateTime ngaySinh;
        private string chucVu;
        private string diaChi;
        private string sdt;
        private DateTime ngayVaoLam;
        private int trangThai;
        
        bool skip = false;
        public frmCapNhatNV(NhanVien nv)
        {
            InitializeComponent();
            maNV = nv.sMaNV;
            tenNV = nv.sTenNV;
            gioiTinh = nv.iGioiTinh;
            ngaySinh = nv.dNgaySinh;
            chucVu = nv.sChucVu;
            diaChi = nv.sDiaChi;
            sdt = nv.sSDT;
            ngayVaoLam = nv.dNgayVaoLam;
            trangThai = nv.iTrangThai;
            txtMaNhanVien.Text = maNV;
            txtMaNhanVien.ReadOnly = true;
            txtTenNhanVien.Text = tenNV;
            txtChucVu.Text = chucVu;
            txtDiaChi.Text = diaChi;
            txtSDT.Text = sdt;
            dtpNgaySinh.Value = ngaySinh;
            dtpNgayVaoLam.Value = ngayVaoLam;
            if (gioiTinh == 0)
                rbNam.Checked = true;
            else
                rbNu.Checked = true;
            if (trangThai == 1)
                btnLamViec.Visible = false;
            else
                btnThoiViec.Visible = false;
        }

        private int checkGioiTinh(int gt)
        {
            if (rbNam.Checked)
                return 0;
            else
                return 1;
        }

        private bool checkDaThayDoi()
        {
            NhanVien nvCu = NhanVien.GetNhanVien(maNV);
            NhanVien nvMoi = new NhanVien(maNV, txtTenNhanVien.Text, checkGioiTinh(gioiTinh), dtpNgaySinh.Value, txtChucVu.Text, txtDiaChi.Text, txtSDT.Text, dtpNgayVaoLam.Value, trangThai);
            bool hasChanged = nvCu.sMaNV != nvMoi.sMaNV ||
                              nvCu.sTenNV != nvMoi.sTenNV ||
                              nvCu.iGioiTinh != nvMoi.iGioiTinh ||
                              nvCu.dNgaySinh != nvMoi.dNgaySinh ||
                              nvCu.sChucVu != nvMoi.sChucVu ||
                              nvCu.sDiaChi != nvMoi.sDiaChi ||
                              nvCu.sSDT != nvMoi.sSDT ||
                              nvCu.dNgayVaoLam != nvMoi.dNgayVaoLam ||
                              nvCu.iTrangThai != nvMoi.iTrangThai;

            return hasChanged;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool loi = false;
            string loiTenNhanVien = "";
            string loiChuaNhapGioiTinh = "";
            string loiChuaDuTuoi = "";
            string loiChucVu = "";
            string loiSDT = "";


            if (txtTenNhanVien.TextLength == 0)
            {
                loiTenNhanVien = " \nChưa nhập tên nhân viên";
                loi = true;
            }
            if ((rbNam.Checked || rbNu.Checked) == false)
            {
                loiChuaNhapGioiTinh = "\nChưa chọn giới tính";
                loi = true;
            }
            if (dtpNgayVaoLam.Value.Year - dtpNgaySinh.Value.Year < 18)
            {
                loiChuaDuTuoi = "\nNhân viên không được dưới 18 tuổi";
                loi = true;
            }
            if (txtChucVu.TextLength == 0)
            {
                loiChucVu = " \nChưa nhập chức vụ";
                loi = true;
            }

            if (txtSDT.TextLength != 10)
            {
                loiSDT = " \nChưa nhập số điện thoại hoặc không đúng";
                loi = true;
            }

            if (loi == false)
            {
                int gt;
                if (rbNam.Checked) gt = 0;
                else gt = 1;
                skip = true;
                MessageBox.Show("Đã thêm");

                NhanVien.suaNV(dbConnect.ConnectionString, txtMaNhanVien.Text, txtTenNhanVien.Text, gt, dtpNgaySinh.Value, txtChucVu.Text, txtDiaChi.Text, txtSDT.Text, dtpNgayVaoLam.Value,trangThai);
                this.Close();
            }
            else
            {
                MessageBox.Show(loiTenNhanVien + loiChuaNhapGioiTinh + loiChuaDuTuoi + loiChucVu + loiSDT, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            skip = true;
            this.Close();
        }

        private void frmThemNV_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkDaThayDoi() == false)
                skip = true;
            if (skip == false)
            {
                DialogResult result = MessageBox.Show("Nhân viên chưa được lưu, bạn có muốn lưu nhân viên này không ?", "Lưu nhân viên", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    btnLuu_Click(sender, e);
                }
                else if (result == DialogResult.No)
                {

                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if (txtSDT.TextLength >= 1)
            {
                // Kiểm tra xem văn bản có chứa ký tự không phải số không
                if (!float.TryParse(txtSDT.Text, out _))
                {
                    // Nếu có ký tự không phải số, loại bỏ ký tự đó từ văn bản
                    txtSDT.Text = txtSDT.Text.Remove(txtSDT.Text.Length - 1);
                    // Đặt con trỏ văn bản ở cuối
                    txtSDT.SelectionStart = txtSDT.Text.Length;
                }
            }
            if (txtSDT.TextLength > 10)
            {
                txtSDT.Text = txtSDT.Text.Remove(txtSDT.Text.Length - 1);
                txtSDT.SelectionStart = txtSDT.Text.Length;
            }

        }

        private void btnThoiViec_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muồn nhân viên " + maNV + " " + tenNV + " thôi việc ?", "Thôi việc nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                NhanVien.thoiViecNV(maNV);
                skip = true;
                this.Close();
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void btnLamViec_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muồn nhân viên " + maNV + " " + tenNV + " làm việc trở lại ?", "Hủy thôi việc nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                NhanVien.huyThoiViecNV(maNV);
                skip = true;
                this.Close();
            }
        }
    }
}
