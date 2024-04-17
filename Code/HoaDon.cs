using System;
using System.Data;
using System.Data.SqlClient;

namespace BTL_QuanLyBanThuoc
{
    public class HoaDon
    {
        public string sMaHD { get; set; }
        public string sMaNV { get; set; }
        public string sMaKH { get; set; }
        public DateTime dNgayLap { get; set; }
        public float fTongTien { get; set; }
        public int iTrangThai { get; set; }
        public int iPhuongThucThanhToan { get; set; }
        public float fKhachThanhToan { get; set; }

        public HoaDon() //Overload Hóa đơn mới
        {
            // Initialize properties as needed
            sMaHD = "";
            sMaNV = "";
            sMaKH = "";
            dNgayLap = DateTime.Now;
            fTongTien = 0.0f;
            iTrangThai = 0;
        }
        // Constructor
        public HoaDon(string maHD, string maNV, string maKH, DateTime ngayLap, float tongTien, int trangThai, int phuongThuc, float khachThanhToan)
        {
            sMaHD = maHD;
            sMaNV = maNV;
            sMaKH = maKH;
            dNgayLap = ngayLap;
            fTongTien = tongTien;
            iTrangThai = trangThai;
            iPhuongThucThanhToan = phuongThuc;
            fKhachThanhToan = khachThanhToan;
        }
        public static HoaDon GetHoaDon(string connectionString, string maHD)
        {
            HoaDon hoaDon = new HoaDon();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM tblHoaDon WHERE sMaHD = @maHD";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@maHD", maHD);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        hoaDon.sMaHD = reader["sMaHD"].ToString();
                        hoaDon.sMaNV = reader["sMaNV"].ToString();
                        hoaDon.sMaKH = reader["sMaKH"].ToString();
                        hoaDon.iPhuongThucThanhToan = Convert.ToInt32(reader["iPhuongThucThanhToan"]);
                        hoaDon.iTrangThai = Convert.ToInt32(reader["iTrangThai"]);
                        hoaDon.dNgayLap = Convert.ToDateTime(reader["dNgayLap"]);
                        hoaDon.fTongTien = Convert.ToSingle(reader["fTongTienHD"]);
                        if(reader["fKhachThanhToan"] != DBNull.Value)
                            hoaDon.fKhachThanhToan = Convert.ToSingle(reader["fKhachThanhToan"]);
                    }

                    reader.Close();
                }
            }

            return hoaDon;
        }
        public static bool themHD(string connection, string maNV, out HoaDon newHD)
        {

            using (SqlConnection cnn = new SqlConnection(connection))
            {
                using (SqlCommand insertcmd = new SqlCommand("UP_ThemHoaDon", cnn))
                {
                    insertcmd.CommandType = CommandType.StoredProcedure;
                    insertcmd.Parameters.AddWithValue("@maNV", maNV);
                    //Làm tròn thời gian, fix lỗi tương thích thời gian giữa SQL và c#
                    DateTime now = DateTime.Now;
                    DateTime roundedNow = now.AddTicks(-(now.Ticks % TimeSpan.TicksPerSecond));

                    insertcmd.Parameters.AddWithValue("@ngayLap", roundedNow);

                    // Output parameter to capture the generated sMaHD
                    SqlParameter outputParam = new SqlParameter("@newMaHD", SqlDbType.VarChar, 20);
                    outputParam.Direction = ParameterDirection.Output;
                    insertcmd.Parameters.Add(outputParam);

                    cnn.Open();
                    int i = insertcmd.ExecuteNonQuery(); // i returns the number of affected rows
                    cnn.Close();


                    // Check if the insert was successful
                    if (i > 0)
                    {
                        newHD = GetHoaDon(dbConnect.ConnectionString, outputParam.Value.ToString());
                        return true;
                    }
                    else
                    {
                        newHD = null;
                        return false;
                    }
                }
            }
        }


        public static bool suaHD(string connection, HoaDon hd)
        {
            using (SqlConnection cnn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand("UP_SuaHoaDon", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maHD", hd.sMaHD);
                    cmd.Parameters.AddWithValue("@maNV", hd.sMaNV);
                    cmd.Parameters.AddWithValue("@maKH", hd.sMaKH);
                    cmd.Parameters.AddWithValue("@ngayLap", hd.dNgayLap);
                    cmd.Parameters.AddWithValue("@tongTien", hd.fTongTien);
                    cmd.Parameters.AddWithValue("@trangThai", hd.iTrangThai);
                    cmd.Parameters.AddWithValue("@phuongThuc", hd.iPhuongThucThanhToan);
                    cmd.Parameters.AddWithValue("@khachThanhToan", hd.fKhachThanhToan);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        public static bool xoaHD(string connection, string sMaHD)
        {
            using (SqlConnection cnn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand("UP_XoaHoaDon", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maHD", sMaHD);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        public static bool huyHD(string connection, string sMaHD)
        {
            using (SqlConnection cnn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand("UP_HuyHoaDon", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maHD", sMaHD);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        public static string checkTrangThaiHD(int checkTrangThai)
        {
            string trangThai;
            switch (checkTrangThai)
            {
                case 0:
                    trangThai = "Phiếu tạm";
                    break;
                case 1:
                    trangThai = "Hoàn thành";
                    break;
                case 2:
                    trangThai = "Đã hủy";
                    break;
                default:
                    trangThai = "Trạng thái không xác định";
                    break;
            }


            return trangThai;
        }

        public static DataTable locTrangThaiHoaDon(bool phieuTam, bool hoanThanh, bool daHuy, bool thangNay, string timKiem, bool khoangThoiGian, DateTime? startTime, DateTime? endTime)
        {
            DataTable tb = new DataTable();
            string sql = "SELECT * FROM tblHoaDon WHERE 1=1";
            {
                bool hasCondition = false;

                if (phieuTam)
                {
                    sql += (hasCondition ? " OR" : " AND (") + " iTrangThai = 0";
                    hasCondition = true;
                }

                if (hoanThanh)
                {
                    sql += (hasCondition ? " OR" : " AND (") + " iTrangThai = 1";
                    hasCondition = true;
                }

                if (daHuy)
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
                    sql += " AND MONTH(dNgayLap) = MONTH(GETDATE()) AND YEAR(dNgayLap) = YEAR(GETDATE())";
                }

                // Thêm điều kiện tìm kiếm hóa đơn
                if (!string.IsNullOrEmpty(timKiem))
                {
                    sql += " AND sMaHD LIKE @TimKiem";
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
                    if (!string.IsNullOrEmpty(timKiem))
                    {
                        cmd.Parameters.AddWithValue("@TimKiem", timKiem + "%");
                    }

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

    }
}
