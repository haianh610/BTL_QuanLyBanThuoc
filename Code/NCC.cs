using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyBanThuoc
{
    public class NCC
    {
        public string sMaNCC { get; set; }
        public string sTenNCC { get; set; }
        public string sDiaChi { get; set; }
        public string sSDT { get; set; }
        public string sMaSoThue { get; set; }

        public NCC() //Overload Hóa đơn mới
        {
            // Initialize properties as needed
            sMaNCC = "";
            sTenNCC = "";
            sDiaChi = "";
            sSDT = "";
        }
        // Constructor
        public NCC(string maNCC, string tenNCC, string diaChi, string SDT,string maSoThue)
        {
            sMaNCC = maNCC;
            sTenNCC = tenNCC;
            sDiaChi = diaChi;
            sSDT = SDT;
            sMaSoThue = maSoThue;
        }

        public static NCC GetNCC(string maNCC)
        {
            NCC nhacungcap = new NCC();

            using (SqlConnection connection = new SqlConnection(dbConnect.ConnectionString))
            {
                string query = "SELECT * FROM tblNhaCungCap WHERE sMaNCC = @maNCC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@maNCC", maNCC);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        nhacungcap.sMaNCC = reader["sMaNCC"].ToString();
                        nhacungcap.sTenNCC = reader["sTenNCC"].ToString();
                        nhacungcap.sDiaChi = reader["sDiaChi"].ToString();
                        nhacungcap.sSDT = reader["sSdtNCC"].ToString();
                    }

                    reader.Close();
                    connection.Close();
                }
            }

            return nhacungcap;
        }

        //Tạo listKH để chứa thông tin các KQ tìm kiếm
        public static List<NCC> listNCC = new List<NCC>();

        public void SearchKhachHang(string timKiem)
        {
            using (SqlConnection connection = new SqlConnection(dbConnect.ConnectionString))
            {
                /*Tìm kiếm 
                 * Tìm kiếm MÃ khách hàng có (các) KÍ TỰ BẮT ĐẦU giống như textBox tìm kiếm
                 * Hoặc tìm kiếm các TÊN khách hàng có CHỨA tên giống thanh textBox tìm kiếm
                */
                string query = "SELECT * FROM tblNhaCungCap WHERE sMaNCC LIKE '" + timKiem + "%' OR sTenNCC LIKE N'%" + timKiem + "%' OR sSdtNCC LIKE '" + timKiem + "%'";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    //Xóa sạch list mỗi lần query tìm kiểm mới
                    //*(mỗi lần nhập thêm 1 ký tự vào bàn phím = query tìm kiểm mới)
                    listNCC.Clear();

                    //Nếu reader tìm thấy dữ liệu trong SQL (có hàng trong bảng tìm kiếm trả về)
                    if (reader.HasRows)
                    {
                        //Mỗi lần reader đọc từng bản ghi trong bảng tìm kiếm trả về
                        while (reader.Read())
                        {
                            //Tạo object KhachHang mới để lưu được data của bản ghi đó
                            NCC nhacungcap = new NCC();

                            //Truyền thông tin reader đọc được vào object
                            nhacungcap.sMaNCC = reader["sMaNCC"].ToString();
                            nhacungcap.sTenNCC = reader["sTenNCC"].ToString();
                            nhacungcap.sDiaChi = reader["sDiaChi"].ToString();
                            nhacungcap.sSDT = reader["sSdtNCC"].ToString();

                            //Thêm object KhachHang vào list các kết quả tìm kiếm
                            listNCC.Add(nhacungcap);
                        }
                    }

                    reader.Close();
                    command.Dispose();
                    connection.Close();
                }
            }
        }

        public static DataTable SearchHangTheoNCC(string timKiem)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(dbConnect.ConnectionString))
            {
                /*Tìm kiếm 
                 * Tìm kiếm MÃ hàng có (các) KÍ TỰ BẮT ĐẦU giống như textBox tìm kiếm
                 * Hoặc tìm kiếm các TÊN hàng có CHỨA tên giống thanh textBox tìm kiếm
                */
                string query = "SELECT * FROM tblMatHang WHERE sMaNCC LIKE '" + timKiem + "%'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    //Xóa sạch list mỗi lần query tìm kiểm mới
                    //*(mỗi lần nhập thêm 1 ký tự vào bàn phím = query tìm kiểm mới)


                    //Nếu reader tìm thấy dữ liệu trong SQL (có hàng trong bảng tìm kiếm trả về)
                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                    }

                    reader.Close();
                    command.Dispose();
                    connection.Close();
                }
            }
            return dt;
        }
    }
}