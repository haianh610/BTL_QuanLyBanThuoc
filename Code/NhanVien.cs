using System;
using System.Data;
using System.Data.SqlClient;

namespace BTL_QuanLyBanThuoc
{
    public class NhanVien
    {
        // Đặt các giá trị có trong object NhanVien
        public string sMaNV { get; set; }
        public string sTenNV { get; set; }
        public int iGioiTinh { get; set; }
        public DateTime dNgaySinh { get; set; }
        public string sChucVu { get; set; }
        public string sDiaChi { get; set; }
        public string sSDT { get; set; }
        public DateTime dNgayVaoLam { get; set; }
        public int iTrangThai { get; set; } // Thêm trạng thái nhân viên

        // Hàm khởi tạo mặc định
        public NhanVien()
        {
            // Khởi tạo object nhân viên chưa có thông tin
            sMaNV = "";
            sTenNV = "";
            iGioiTinh = 0; // Giả sử 0 là không xác định
            dNgaySinh = DateTime.MinValue;
            sChucVu = "";
            sDiaChi = "";
            sSDT = "";
            dNgayVaoLam = DateTime.MinValue;
            iTrangThai = 0; // Giả sử 0 là không xác định
        }

        // Hàm khởi tạo với thông tin nhân viên
        public NhanVien(string maNV, string tenNV, int gioiTinh, DateTime ngaySinh, string chucVu, string diaChi, string sdt, DateTime ngayVaoLam, int trangThai)
        {
            sMaNV = maNV;
            sTenNV = tenNV;
            iGioiTinh = gioiTinh;
            dNgaySinh = ngaySinh;
            sChucVu = chucVu;
            sDiaChi = diaChi;
            sSDT = sdt;
            dNgayVaoLam = ngayVaoLam;
            iTrangThai = trangThai;
        }

        public static NhanVien GetNhanVien(string maNV)
        {
            NhanVien nhanVien = new NhanVien();

            using (SqlConnection connection = new SqlConnection(dbConnect.ConnectionString))
            {
                string query = "SELECT * FROM tblNhanVien WHERE sMaNV = @maNV";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@maNV", maNV);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        nhanVien.sMaNV = reader["sMaNV"].ToString();
                        nhanVien.sTenNV = reader["sTenNV"].ToString();
                        nhanVien.iGioiTinh = Convert.ToInt32(reader["iGioiTinh"]);
                        nhanVien.dNgaySinh = Convert.ToDateTime(reader["dNgaySinh"]);
                        nhanVien.sChucVu = reader["sChucVu"].ToString();
                        nhanVien.sDiaChi = reader["sDiaChi"].ToString();
                        nhanVien.sSDT = reader["sSDT"].ToString();
                        nhanVien.dNgayVaoLam = Convert.ToDateTime(reader["dNgayVaoLam"]);
                        nhanVien.iTrangThai = Convert.ToInt32(reader["iTrangThai"]);
                    }

                    reader.Close();
                    connection.Close();
                }
            }

            return nhanVien;
        }


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

        public static bool suaNV(string connection, string sMaNV, string sTenNV, int bGioiTinh, DateTime dNgaySinh, string sChucVu, string sDiaChi, string sSDT, DateTime dNgayVaoLam, int iTrangThai)
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
                    cmd.Parameters.AddWithValue("@trangThai", iTrangThai);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }
        public static bool thoiViecNV(string sMaNV)
        {
            using (SqlConnection cnn = new SqlConnection(dbConnect.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("UP_ThoiViecNhanVien", cnn))
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

        public static bool huyThoiViecNV(string sMaNV)
        {
            using (SqlConnection cnn = new SqlConnection(dbConnect.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("UP_HuyThoiViecNhanVien", cnn))
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
