using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyBanThuoc
{
    public class KhachHang
    {
        public string sMaKH { get; set; }
        public string sTenKH { get; set; }
        public string sDiaChi { get; set; }
        public string sSDT { get; set; }
        public int iNamSinh { get; set; }
        public int iGioiTinh { get; set; }

        public KhachHang() //Overload Hóa đơn mới
        {
            // Initialize properties as needed
            sMaKH = "";
            sTenKH = "";
            sDiaChi = "";
            sSDT = "";
            iNamSinh = 0;
            iGioiTinh = -1;
        }
        // Constructor
        public KhachHang(string maKH, string tenKH, string diaChi, string SDT, int namSInh, int gioiTinh)
        {
            sMaKH = maKH;
            sTenKH = tenKH;
            sDiaChi = diaChi;
            sSDT = SDT;
            iNamSinh = namSInh;
            iGioiTinh = gioiTinh;
        }

        public static KhachHang GetKhachHang(string maKH)
        {
            KhachHang khachhang = new KhachHang();

            using (SqlConnection connection = new SqlConnection(dbConnect.ConnectionString))
            {
                string query = "SELECT * FROM tblKhachHang WHERE sMaKH = @maKH";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@maKH", maKH);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                       khachhang.sMaKH = reader["sMaKH"].ToString();
                       khachhang.sTenKH = reader["sTenKH"].ToString();
                       khachhang.sDiaChi = reader["sDiaChi"].ToString();
                       khachhang.sSDT = reader["sDiaChi"].ToString();
                       khachhang.iNamSinh= Convert.ToInt32(reader["iNamSinh"]);
                       khachhang.iGioiTinh = Convert.ToInt32(reader["iGioiTinh"]);
                    }

                    reader.Close();
                    connection.Close();
                }
            }

            return khachhang;
        }

        //Tạo listKH để chứa thông tin các KQ tìm kiếm
        public static List<KhachHang> listKH = new List<KhachHang>();

        public void SearchKhachHang(string timKiem)
        {
            using (SqlConnection connection = new SqlConnection(dbConnect.ConnectionString))
            {
                /*Tìm kiếm 
                 * Tìm kiếm MÃ khách hàng có (các) KÍ TỰ BẮT ĐẦU giống như textBox tìm kiếm
                 * Hoặc tìm kiếm các TÊN khách hàng có CHỨA tên giống thanh textBox tìm kiếm
                */
                string query = "SELECT * FROM tblKhachHang WHERE sMaKH LIKE '" + timKiem + "%' OR sTenKH LIKE N'%" + timKiem + "%' OR sSDT LIKE '" + timKiem + "%'";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    //Xóa sạch list mỗi lần query tìm kiểm mới
                    //*(mỗi lần nhập thêm 1 ký tự vào bàn phím = query tìm kiểm mới)
                    listKH.Clear();

                    //Nếu reader tìm thấy dữ liệu trong SQL (có hàng trong bảng tìm kiếm trả về)
                    if (reader.HasRows)
                    {
                        //Mỗi lần reader đọc từng bản ghi trong bảng tìm kiếm trả về
                        while (reader.Read())
                        {
                            //Tạo object KhachHang mới để lưu được data của bản ghi đó
                            KhachHang khachHang = new KhachHang();

                            //Truyền thông tin reader đọc được vào object
                            khachHang.sMaKH = reader["sMaKH"].ToString();
                            khachHang.sTenKH = reader["sTenKH"].ToString();
                            khachHang.sDiaChi = reader["sDiaChi"].ToString();
                            khachHang.sSDT = reader["sSDT"].ToString();
                            khachHang.iNamSinh = Convert.ToInt32(reader["iNamSinh"]);
                            khachHang.iGioiTinh = Convert.ToInt32(reader["iGioiTinh"]);

                            //Thêm object KhachHang vào list các kết quả tìm kiếm
                            listKH.Add(khachHang);
                        }
                    }

                    reader.Close();
                    command.Dispose();
                    connection.Close();
                }
            }
        }

    }
}
