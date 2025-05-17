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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        //--------------------------THÊM User--------------------------
        public static bool ThemUser(string sHoten, string sUsername, string sSDT, DateTime dNgaySinh, string sPassword)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyKhoThuoc"].ConnectionString;

            if (checkExit("tblUser", "sSDT", sSDT))
            {
                MessageBox.Show("\nTài khoản đã tồn tại!", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                //Ket noi Database (cnn : duong dan den Data)
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    //SqlCommand : thực thi lệnh (thêm, sửa, xóa, truy vấn) 
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "UP_ThemUser";

                        //Parameters : cách truyền tham số vào SQL
                        cmd.Parameters.AddWithValue("@sHoten", sHoten);
                        cmd.Parameters.AddWithValue("@sUsername", sUsername);
                        cmd.Parameters.AddWithValue("@sSDT", sSDT);
                        cmd.Parameters.AddWithValue("@dNgaySinh", dNgaySinh);
                        cmd.Parameters.AddWithValue("@sPassword", sPassword);

                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        cnn.Close();
                        return i > 0;
                    }
                }
                return true;
            }

        }



        public static bool checkExit(string TenBang, string TenCot, string Giatri)
        {
            string connectionString = dbConnect.ConnectionString;
            bool E = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"select count(*) from {TenBang} where {TenCot} = @Giatri";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Giatri", Giatri);
                    try
                    {
                        connection.Open();
                        //ExecuteScalar : trả về số lượng hàng SELECT 
                        //ExecuteNonQuery : trả về số lượng hàng bị ảnh hưởng
                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                        {
                            E = true;
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Error" + ex.Message);
                    }

                }
            }
            return E;
        }

        public bool checkPhonenumber(string sSDT)
        {
            // Biểu thức chính quy cho số điện thoại
            string pattern = @"^\+?(\d{1,3})?[-. ]?\(?\d{3}\)?[-. ]?\d{3}[-. ]?\d{4}$";

            // Tạo một đối tượng Regex để kiểm tra chuỗi
            Regex regex = new Regex(pattern);

            bool isValid = regex.IsMatch(sSDT);
            // Kiểm tra xem chuỗi phù hợp với biểu thức chính quy hay không
            return isValid;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string sHoten = txtHoten.Text;
            string sUsername = txtUsernameDK.Text;
            string sSDT = txtSDT_DK.Text;
            if(checkPhonenumber(sSDT))
            {
                DateTime dNgaySinh = dpNgaySinh.Value;
                string sPassword = txtPasswordDK.Text;

                if (checkExit("tblUser", "sSDT", sSDT) == false)
                {
                    bool i = ThemUser(sHoten, sUsername, sSDT, dNgaySinh, sPassword);
                    if (i)
                    {
                        MessageBox.Show("Đăng ký thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DangNhap DN = new DangNhap(txtSDT_DK.Text);
                        DN.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại!", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Lỗi",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            }    
            
        }

        private void linkDN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangNhap DN = new DangNhap("");
            DN.Show();
            this.Hide();

        }
    }
}
