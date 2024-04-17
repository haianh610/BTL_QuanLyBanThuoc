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
    public partial class frmThemNV : Form
    {
        bool them = false;
        public frmThemNV()
        {
            InitializeComponent();
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool loi = false;
            string loiKhongMaNV = "";
            string loiTenNhanVien = "";
            string loiChuaNhapGioiTinh = "";
            string loiChuaDuTuoi = "";
            string loiChucVu = "";
            string loiSDT = "";
            string loiTrungMa = "";
            if (txtMaNhanVien.TextLength < 3)
            {
                loiKhongMaNV = "Chưa nhập mã nhân viên";
                loi = true;
            }else if (Program.checkMa(dbConnect.ConnectionString, "tblNhanVien", "sMaNV", txtMaNhanVien.Text))
            {
                loiTrungMa = "Đã có mã nhân viên này trong hệ thống";
                loi = true;
            }
            if (txtTenNhanVien.TextLength == 0)
            {
                loiTenNhanVien = " \nChưa nhập tên nhân viên";
                loi = true;
            }
            if ((rbNam.Checked||rbNu.Checked) == false)
            {
                loiChuaNhapGioiTinh = "\nChưa chọn giới tính";
                loi = true;
            }
            if(dtpNgayVaoLam.Value.Year - dtpNgaySinh.Value.Year < 18)
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
                them = true;
                MessageBox.Show("Đã thêm");

                NhanVien.themNV(dbConnect.ConnectionString, txtMaNhanVien.Text, txtTenNhanVien.Text,gt,dtpNgaySinh.Value,txtChucVu.Text,txtDiaChi.Text,txtSDT.Text,dtpNgayVaoLam.Value);
                this.Close();
            }
            else
            {
                MessageBox.Show(loiKhongMaNV+loiTrungMa +loiTenNhanVien+ loiChuaNhapGioiTinh+loiChuaDuTuoi+loiChucVu+loiSDT, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemNV_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (them == false)
            {
                DialogResult result = MessageBox.Show("Nhân viên chưa được lưu, bạn có muốn lưu nhân viên này không ?", "Lưu nhân viên", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    btnLuu_Click(sender, e);
                    e.Cancel = true;
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

    }
}
