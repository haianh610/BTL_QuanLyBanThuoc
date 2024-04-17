using System;
using System.Data;
using System.Data.SqlClient;

namespace BTL_QuanLyBanThuoc
{
    class NhanVien
    {
        ////Đặt các giá trị có trong object MatHang
        //public string sMaNV { get; set; }
        //public string sMaLH { get; set; }
        //public string sTenHang { get; set; }
        //public string sHangSX { get; set; }
        //public string sDVT { get; set; }
        //public float fDonGia { get; set; }
        //public int iSoLuong { get; set; }

        ////Overload cho việc khởi tạo object mặt hàng mới
        //public NhanVien()
        //{
        //    // Khởi tạo object MatHang chưa có thông tin (thay đổi giá trị khởi tạo tùy thuộc vào null trong SQL)

        //    sMaLH = "";
        //    sTenHang = "";
        //    sHangSX = "";
        //    sDVT = "";
        //    fDonGia = 0;
        //    iSoLuong = 0;
        //}

        //public NhanVien(string maHang, string maLH, string tenHang, string hangSX, string DVT, float donGia, int soLuong, DateTime NSX, DateTime HSD)
        //{

        //    sMaLH = maLH;
        //    sTenHang = tenHang;
        //    sHangSX = hangSX;
        //    sDVT = DVT;
        //    fDonGia = donGia;
        //    iSoLuong = soLuong;
        //}

        public static bool themNV(string connection, string sMaNV, string sTenNV, int iGioiTinh, DateTime dNgaySinh, string sChucVu, string sDiaChi, string sSDT, DateTime dNgayVaoLam)
        {
            using (SqlConnection cnn = new SqlConnection(connection))
            {
                using (SqlCommand insertcmd = new SqlCommand("UP_ThemNhanVien", cnn))
                {
                    insertcmd.CommandType = CommandType.StoredProcedure;
                    insertcmd.Parameters.AddWithValue("@maNV", sMaNV);
                    insertcmd.Parameters.AddWithValue("@tenNV", sTenNV);
                    insertcmd.Parameters.AddWithValue("@gioiTinh", iGioiTinh);
                    insertcmd.Parameters.AddWithValue("@ngaySinh", dNgaySinh);
                    insertcmd.Parameters.AddWithValue("@chucVu", sChucVu);
                    insertcmd.Parameters.AddWithValue("@diaChi", sDiaChi);
                    insertcmd.Parameters.AddWithValue("@sdt", sSDT);
                    insertcmd.Parameters.AddWithValue("@ngayVaoLam", dNgayVaoLam);
                    insertcmd.Parameters.AddWithValue("@trangThai", 1);

                    cnn.Open();
                    int i = insertcmd.ExecuteNonQuery(); // i trả lại số cột bị ảnh hưởng
                    cnn.Close();
                    return i > 0; //Nếu số cột bị ảnh hưởng từ 1 trở lên thì báo true để thành công
                }
            }
        }

        public static bool suaNV(string connection, string sMaNV, string sTenNV, int bGioiTinh, DateTime dNgaySinh, string sChucVu, string sDiaChi, string sSDT, DateTime dNgayVaoLam)
        {
            using (SqlConnection cnn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand("UP_SuaNhanVien", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maNV", sMaNV);
                    cmd.Parameters.AddWithValue("@tenNV", sTenNV);
                    cmd.Parameters.AddWithValue("@gioiTinh", bGioiTinh);
                    cmd.Parameters.AddWithValue("@ngaySinh", dNgaySinh);
                    cmd.Parameters.AddWithValue("@chucVu", sChucVu);
                    cmd.Parameters.AddWithValue("@diaChi", sDiaChi);
                    cmd.Parameters.AddWithValue("@sdt", sSDT);
                    cmd.Parameters.AddWithValue("@ngayVaoLam", dNgayVaoLam);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        public static bool xoaNV(string connection, string sMaNV)
        {
            using (SqlConnection cnn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand("UP_XoaNhanVien", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maNV", sMaNV);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }
        public static DataTable SearchNhanVien(string timKiem)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(dbConnect.ConnectionString))
            {
                /*Tìm kiếm 
                 * Tìm kiếm MÃ hàng có (các) KÍ TỰ BẮT ĐẦU giống như textBox tìm kiếm
                 * Hoặc tìm kiếm các TÊN hàng có CHỨA tên giống thanh textBox tìm kiếm
                */
                string query = "SELECT * FROM tblNhanvien WHERE sMaNV LIKE '" + timKiem + "%' OR sTenNV LIKE N'%" + timKiem + "%'";

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

        public static DataTable locNhanVien(bool dangLamViec, bool daThoiViec, bool thangNay, string timKiem, bool khoangThoiGian, DateTime? startTime, DateTime? endTime)
        {
            DataTable tb = new DataTable();
            string sql = "SELECT * FROM tblNhanVien WHERE 1=1";
            {
                bool hasCondition = false;

                if (dangLamViec)
                {
                    sql += (hasCondition ? " OR" : " AND (") + " iTrangThai = 1";
                    hasCondition = true;
                }

                if (daThoiViec)
                {
                    sql += (hasCondition ? " OR" : " AND (") + " iTrangThai = 2";
                    hasCondition = true;
                }
                if (hasCondition)
                    sql += ")";
                else
                    sql += " AND iTrangThai != 2";

                if (thangNay)
                {
                    sql += " AND MONTH(dNgayVaoLam) = MONTH(GETDATE()) AND YEAR(dNgayVaoLam) = YEAR(GETDATE())";
                }

                // Thêm điều kiện tìm kiếm hóa đơn
                if (!string.IsNullOrEmpty(timKiem))
                {
                    sql += " AND sMaNV LIKE '" + timKiem + "%' OR sTenNV LIKE N'%" + timKiem + "%'";
                }

                // Thêm điều kiện lọc từ mốc thời gian này đến mốc thời gian khác nếu khoangThoiGian là true
                if (khoangThoiGian && startTime.HasValue && endTime.HasValue)
                {
                    sql += " AND dNgayLap BETWEEN @StartTime AND @EndTime";
                }
            }

            using (SqlConnection cnn = new SqlConnection(dbConnect.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    // Thêm tham số cho tìm kiếm
                    //if (!string.IsNullOrEmpty(timKiem))
                    //{
                    //    cmd.Parameters.AddWithValue("@TimKiem", timKiem + "%");
                    //}

                    // Thêm tham số cho mốc thời gian nếu khoangThoiGian là true
                    if (khoangThoiGian && startTime.HasValue && endTime.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@StartTime", startTime.Value);
                        cmd.Parameters.AddWithValue("@EndTime", endTime.Value);
                    }

                    cnn.Open();
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        tb.Load(rd);
                    }
                    rd.Close();
                    cmd.Dispose();
                    cnn.Close();
                    return tb;
                }
            }
        }

        public static DataTable SearchChucVuNhanVien(string chucVu)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(dbConnect.ConnectionString))
            {
                /*Tìm kiếm 
                 * Tìm kiếm MÃ hàng có (các) KÍ TỰ BẮT ĐẦU giống như textBox tìm kiếm
                 * Hoặc tìm kiếm các TÊN hàng có CHỨA tên giống thanh textBox tìm kiếm
                */
                string query = "SELECT * FROM tblNhanvien WHERE sChucVu = N'" + chucVu +"'";

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
