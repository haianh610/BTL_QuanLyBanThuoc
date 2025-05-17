using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Configuration;

namespace BTL_QuanLyBanThuoc
{
    public partial class DangNhap : Form
    {
        public DangNhap(string sSDT)
        {
            InitializeComponent();
            txbMaNV.Text = sSDT;
        }

        public static string OP;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            ThuVienChung t = new ThuVienChung();
            string sMaNV = txbMaNV.Text;
            string sPassword = txtPasswordDN.Text;
            OP = txtPasswordDN.Text;
            string Pas = t.LayGiaTriCu<string>("tblUser", "sPassword", "sMaNV", sMaNV);
            if(ThuVienChung.CheckExsit("tblUser", "sMaNV", sMaNV))
            {
                if(sPassword == Pas)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    TrangChu TC = new TrangChu();
                    TC.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu!", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không hợp lệ!", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

        }

        private void ckbXemPw_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbXemPw.Checked)
            {
                txtPasswordDN.UseSystemPasswordChar = false;
                txtPasswordDN.PasswordChar = '\0'; // Sử dụng '\0' để hiển thị mật khẩu dưới dạng văn bản thường
            }
            else
            {
                txtPasswordDN.UseSystemPasswordChar = true;
                txtPasswordDN.PasswordChar = '*'; // Sử dụng '\0' để hiển thị mật khẩu dưới dạng văn bản thường
            }

        }


        private void linkDK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy DK = new DangKy();
            DK.Show();
            this.Hide();
            
        }
    }
}
