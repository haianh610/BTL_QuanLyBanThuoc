using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyBanThuoc.Code
{
    public class MatHang
    {
        //Đặt các giá trị có trong object MatHang
        public string sMaHang { get; set; }
        public string sMaLH { get; set; }
        public string sTenHang { get; set; }
        public string sHangSX { get; set; }
        public string sDVT { get; set; }
        public float fDonGia { get; set; }
        public int iSoLuong { get; set; }

        //Overload cho việc khởi tạo object mặt hàng mới
        public MatHang() 
        {
            // Khởi tạo object MatHang chưa có thông tin (thay đổi giá trị khởi tạo tùy thuộc vào null trong SQL)
            sMaHang = "";
            sMaLH = "";
            sTenHang = "";
            sHangSX = "";
            sDVT = "";
            fDonGia = 0;
            iSoLuong = 0;
        }
        //Khởi tạo object Mặt hàng có đầy đủ thông tin
        public MatHang(string maHang, string maLH, string tenHang, string hangSX, string DVT, float donGia, int soLuong, DateTime NSX, DateTime HSD)
        {
            sMaHang = maHang;
            sMaLH = maLH;
            sTenHang = tenHang;
            sHangSX = hangSX;
            sDVT = DVT;
            fDonGia = donGia;
            iSoLuong = soLuong;
        }

        //Hàm lấy thông tin của mặt hàng
        //(nhưng cái này làm trước khi nghiên cứu cái tìm kiếm nên nó đang hao hao cái tìm kiếm)
        //Đọc ở phần tìm kiếm (ngay dưới) có giải thích
        public static MatHang GetMatHang(string connectionString, string maHang)
        {
            MatHang matHang = new MatHang();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM tblMatHang WHERE sMaHang = @maHang";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@maHang", maHang);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        matHang.sMaHang = reader["sMaHang"].ToString();
                        matHang.sTenHang = reader["sTenHang"].ToString();
                        matHang.iSoLuong = Convert.ToInt32(reader["iSoLuong"].ToString());
                        matHang.fDonGia = Convert.ToSingle(reader["fDonGia"]);
                    }

                    reader.Close();
                }
            }
            //Trả về object mặt hàng
            return matHang;
        }


        //Tạo listMH để chứa thông tin các KQ tìm kiếm
        public static List<MatHang> listMH = new List<MatHang>();

        public void SearchMatHang(string connectionString, string timKiem)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                /*Tìm kiếm 
                 * Tìm kiếm MÃ hàng có (các) KÍ TỰ BẮT ĐẦU giống như textBox tìm kiếm
                 * Hoặc tìm kiếm các TÊN hàng có CHỨA tên giống thanh textBox tìm kiếm
                */
                string query = "SELECT * FROM tblMatHang WHERE sMaHang LIKE '"+ timKiem+"%' OR sTenHang LIKE N'%"+timKiem+"%'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    //Xóa sạch list mỗi lần query tìm kiểm mới
                    //*(mỗi lần nhập thêm 1 ký tự vào bàn phím = query tìm kiểm mới)
                    listMH.Clear();

                    //Nếu reader tìm thấy dữ liệu trong SQL (có hàng trong bảng tìm kiếm trả về)
                    if (reader.HasRows)
                    {
                        //Mỗi lần reader đọc từng bản ghi trong bảng tìm kiếm trả về
                        while (reader.Read())
                        {
                            //Tạo object MatHang mới để lưu được data của bản ghi đó
                            MatHang matHang = new MatHang();

                            //Truyền thông tin reader đọc được vào object
                            //(do tìm kiếm chỉ cần hiện nhanh 3 thông tin đó nên chỉ lấy 3)
                            matHang.sMaHang = reader["sMaHang"].ToString();
                            matHang.sTenHang = reader["sTenHang"].ToString();
                            matHang.iSoLuong = Convert.ToInt32(reader["iSoLuong"].ToString());
                            matHang.fDonGia = Convert.ToSingle(reader["fDonGia"]);

                            //Thêm object MatHang vào list các kết quả tìm kiếm
                            listMH.Add(matHang);
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
