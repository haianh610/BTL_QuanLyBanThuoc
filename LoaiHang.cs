using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace BTL_QuanLyBanThuoc
{
    class LoaiHang
    {
        public string sMaLH { get; set; }
        public string sTenLH { get; set; }

        public LoaiHang()
        {
            // Khởi tạo object MatHang chưa có thông tin (thay đổi giá trị khởi tạo tùy thuộc vào null trong SQL)
            sMaLH = "";
            sTenLH = "";
        }

        public LoaiHang(string maLH, string tenLH)
        {
            sMaLH = maLH;
            sTenLH = tenLH;
        }


        public static LoaiHang GetLoaiHang(string maLH)
        {
            LoaiHang loaihang = new LoaiHang();

            using (SqlConnection connection = new SqlConnection(dbConnect.ConnectionString))
            {
                string query = "SELECT * FROM tblLoaiHang WHERE sMaLH = @maLH";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@maLH", maLH);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        loaihang.sMaLH = reader["sMaLH"].ToString();
                        loaihang.sTenLH = reader["sTenLH"].ToString();
                        
                    }

                    reader.Close();
                }
            }
            //Trả về object loại hàng
            return loaihang;
        }



        //###########################  CHỨC NĂNG THÊM-SỬA-XÓA-TÌM KIẾM ###########################################################################################
        //THÊM LOẠI HÀNG
        public static bool ThemLH(string sMaLH,string sTenLH, int iTrangThai)
        {
            //string sMaLH = fLoaiHang.viewLH.CurrentRow.Cells["Mã Loại Hàng"].Value.ToString();
            bool Ma = ThuVienChung.CheckExsit("tblLoaiHang", "sMaLH", sMaLH);
            //sMaLH = fLoaiHang.viewLH.CurrentRow.Cells["Mã Loại Hàng"].Value.ToString();

            if (Ma == false)
            {
                //Ket noi Database (cnn : duong dan den Data)
                using (SqlConnection cnn = new SqlConnection(dbConnect.ConnectionString))
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "UP_ThemLH";
                        cmd.Parameters.AddWithValue("@sTenLH", sTenLH);
                        cmd.Parameters.AddWithValue("@iTrangThai", iTrangThai);
                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        cnn.Close();
                        return i > 0;
                    }
                }
                return true;
            }
            else
            { return false; }

        }

        //SỬA LOẠI HÀNG
        public static bool SuaLH(string sMaLH, string sTenLH)
        {
            //string connectionString = ConfigurationManager.ConnectionStrings["QuanLyKhoThuoc"].ConnectionString;


            if (ThuVienChung.CheckExsit("tblLoaiHang", "sMaLH", sMaLH) == false)
            {
                MessageBox.Show("\nKhông tồn tại loại hàng có mã " + sMaLH + "!", "Eror", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                using (SqlConnection cnn = new SqlConnection(dbConnect.ConnectionString))
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "suaLoaiHang";

                        cmd.Parameters.AddWithValue("@sMaLH", sMaLH);
                        cmd.Parameters.AddWithValue("@sTenLHmoi", sTenLH);
                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        cnn.Close();
                        return i > 0;
                    }
                }
            }
        }






    }
}
