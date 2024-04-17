using System;
using System.Data;
using System.Data.SqlClient;

namespace BTL_QuanLyBanThuoc
{
    public class ChiTietHoaDon
    {
        public string sMaHD { get; set; }
        public string sMaHang { get; set; }
        public int iSoLuong { get; set; }
        public float fThanhTien { get; set; }

        public ChiTietHoaDon() //Overload CT Hóa đơn mới
        {
            // Initialize properties as needed
            sMaHD = "";
            sMaHang= "";
            iSoLuong = 0;
            fThanhTien = 0.0f;
        }
        // Constructor
        public ChiTietHoaDon(string maHD, string maHang, int soLuong, float thanhTien)
        {
            sMaHD = maHD;
            sMaHang = maHang;
            iSoLuong = soLuong;
            fThanhTien = thanhTien;
        }
    }
    class ChucNangChiTietHoaDon
    {
        public static bool themChiTietHD(string connection, string sMaHD, string sMaHang, int iSoLuong)
        {
            using (SqlConnection cnn = new SqlConnection(connection))
            {
                using (SqlCommand insertcmd = new SqlCommand("UP_ThemChiTietHoaDon", cnn))
                {
                    insertcmd.CommandType = CommandType.StoredProcedure;
                    insertcmd.Parameters.AddWithValue("@maHD", sMaHD);
                    insertcmd.Parameters.AddWithValue("@maHang", sMaHang);
                    insertcmd.Parameters.AddWithValue("@soLuong", iSoLuong);

                    cnn.Open();
                    int i = insertcmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }


        public static bool suaChiTietHD(string connection, string sMaHD, string sMaHang, int iSoLuong, float fThanhTien)
        {
            using (SqlConnection cnn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand("UP_SuaChiTietHoaDon", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maHD", sMaHD);
                    cmd.Parameters.AddWithValue("@maHang", sMaHang);
                    cmd.Parameters.AddWithValue("@soLuong", iSoLuong);
                    cmd.Parameters.AddWithValue("@thanhTien", fThanhTien);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }


        public static bool xoaChiTietHD(string connection, string sMaHD, string sMaHang)
        {
            using (SqlConnection cnn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand("UP_XoaChiTietHoaDon", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maHD", sMaHD);
                    cmd.Parameters.AddWithValue("@maHang", sMaHang);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }
        public static bool CheckExsitCTHD(string maHD, string maHang)
        {
            bool E = false;
            using (SqlConnection connection = new SqlConnection(dbConnect.ConnectionString))
            {
                string query = $"select count(*) from tblChiTietHoaDon where sMaHang = @maHang AND sMaHD = @maHD";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@maHang", maHang);
                    cmd.Parameters.AddWithValue("@maHD", maHD);

                    connection.Open();
                    //ExecuteScalar : trả về số lượng hàng SELECT 
                    //ExecuteNonQuery : trả về số lượng hàng bị ảnh hưởng
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        E = true;
                    }
                }
            }
            return E;
        }
        public static bool CheckExsitCTHD(string maHD)
        {
            bool E = false;
            using (SqlConnection connection = new SqlConnection(dbConnect.ConnectionString))
            {
                string query = $"select count(*) from tblChiTietHoaDon where sMaHD = @maHD";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@maHD", maHD);

                    connection.Open();
                    //ExecuteScalar : trả về số lượng hàng SELECT 
                    //ExecuteNonQuery : trả về số lượng hàng bị ảnh hưởng
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        E = true;
                    }
                }
            }
            return E;
        }
    }
}
