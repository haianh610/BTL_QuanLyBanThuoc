using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace BTL_QuanLyBanThuoc
{
    public class PhieuNhap
    {
        public string sMaPN { get; set; }
        public string sMaNV { get; set; }
        public DateTime dNgayNhap { get; set; }
        public string sMaNCC { get; set; }
        public float fTongTienPN { get; set; }
        public int iTrangThai { get; set; }
        public int iPhuongThucThanhToan { get; set; }
        public float fKhachThanhToan { get; set; }


        public PhieuNhap() //Overload Phieu Nhap mới
        {
            // Initialize properties as needed
            sMaPN = "";
            sMaNV = "";
            sMaNCC = "";
            dNgayNhap = DateTime.Now;
            fTongTienPN = 0.0f;
            iTrangThai = 0;
        }
        // Constructor
        public PhieuNhap(string MaPN, string MaNV, DateTime NgayNhap, string MaNCC, float TongTien, int TrangThai, int phuongThuc, float khachThanhToan)
        {
            sMaPN = MaPN;
            sMaNV = MaNV;
            dNgayNhap = NgayNhap;
            sMaNCC = MaNCC;
            fTongTienPN = TongTien;
            iTrangThai = TrangThai;
            iPhuongThucThanhToan = phuongThuc;
            fKhachThanhToan = khachThanhToan;
        }
        public static PhieuNhap GetPN(string connectionString, string MaPN)
        {
            PhieuNhap PN = new PhieuNhap();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM tblPhieuNhap WHERE sMaPN = @MaPN";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaPN", MaPN);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Giải thích đoạn này 
                        PN.sMaPN = reader["sMaPN"].ToString();
                        PN.sMaNV = reader["sMaNV"].ToString();
                        PN.sMaNCC = reader["sMaNCC"].ToString();
                        object phuongThucThanhToanValue = reader["iPhuongThucThanhToan"];
                        if (phuongThucThanhToanValue != DBNull.Value)
                        {
                            PN.iPhuongThucThanhToan = Convert.ToInt32(phuongThucThanhToanValue);
                        }
                        PN.iTrangThai = Convert.ToInt32(reader["iTrangThai"]);
                        PN.dNgayNhap = Convert.ToDateTime(reader["dNgayNhap"]);
                        object tongTienPNValue = reader["fTongTienPN"];
                        if (tongTienPNValue != DBNull.Value)
                        {
                            PN.fTongTienPN = Convert.ToSingle(tongTienPNValue);
                        }
                        if (reader["fKhachThanhToan"] != DBNull.Value)
                            PN.fKhachThanhToan = Convert.ToSingle(reader["fKhachThanhToan"]);
                    }

                    reader.Close();
                }
            }

            return PN;
        }
        public static bool themPN(string connection, string maNV, out PhieuNhap newPN)
        {

            using (SqlConnection cnn = new SqlConnection(connection))
            {
                using (SqlCommand insertcmd = new SqlCommand("UP_ThemPN", cnn))
                {
                    insertcmd.CommandType = CommandType.StoredProcedure;
                    insertcmd.Parameters.AddWithValue("@maNV", maNV);
                    // lỗi tương thích thời gian là lỗi gì
                    //Làm tròn thời gian, fix lỗi tương thích thời gian giữa SQL và c#
                    DateTime now = DateTime.Now;
                    DateTime roundedNow = now.AddTicks(-(now.Ticks % TimeSpan.TicksPerSecond));

                    insertcmd.Parameters.AddWithValue("@ngayNhap", roundedNow);

                    // Output parameter to capture the generated sMaPN
                    SqlParameter outputParam = new SqlParameter("@newMaPN", SqlDbType.VarChar, 20);
                    outputParam.Direction = ParameterDirection.Output;
                    insertcmd.Parameters.Add(outputParam);

                    cnn.Open();
                    int i = insertcmd.ExecuteNonQuery(); // i returns the number of affected rows
                    cnn.Close();


                    // Check if the insert was successful
                    if (i > 0)
                    {
                        newPN = GetPN(dbConnect.ConnectionString, outputParam.Value.ToString());
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("\nMa da ton tai!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        newPN = null;
                        return false;
                    }
                }
            }
        }


        public static bool suaPN(string connection, PhieuNhap PN)
        {

            using (SqlConnection cnn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand("UP_SuaPhieuNhap", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPN", PN.sMaPN);
                    cmd.Parameters.AddWithValue("@maNV", PN.sMaNV);
                    cmd.Parameters.AddWithValue("@NgayNhap", PN.dNgayNhap);
                    cmd.Parameters.AddWithValue("@MaNCC", PN.sMaNCC);
                    cmd.Parameters.AddWithValue("@TongTienPN", PN.fTongTienPN);
                    cmd.Parameters.AddWithValue("@TrangThai", PN.iTrangThai);
                    cmd.Parameters.AddWithValue("@phuongThuc", PN.iPhuongThucThanhToan);
                    cmd.Parameters.AddWithValue("@khachThanhToan", PN.fKhachThanhToan);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        public static bool xoaPN(string connection, string sMaPN)
        {
            using (SqlConnection cnn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand("UP_XoaPN", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPN", sMaPN);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        public static bool huyPN(string connection, string sMaPN)
        {
            using (SqlConnection cnn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand("pr_HuyPN", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPN", sMaPN);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }
        public static string checkTrangThaiPN(int checkTrangThai)
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
        // Giải thích hàm locHoaDon
        public static DataTable locPhieuNhap(bool phieuTam, bool hoanThanh, bool daHuy, bool thangNay, string timKiem, bool khoangThoiGian, DateTime? startTime, DateTime? endTime)
        {
            DataTable tb = new DataTable();
            string sql = "SELECT * FROM tblPhieuNhap WHERE 1=1";
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
                sql += " AND MONTH(dNgayNhap) = MONTH(GETDATE()) AND YEAR(dNgayNhap) = YEAR(GETDATE())";
            }

            // Thêm điều kiện tìm kiếm hóa đơn
            if (!string.IsNullOrEmpty(timKiem))
            {
                sql += " AND sMaPN LIKE @TimKiem";
            }

            // Thêm điều kiện lọc từ mốc thời gian này đến mốc thời gian khác nếu khoangThoiGian là true
            if (khoangThoiGian && startTime.HasValue && endTime.HasValue)
            {
                sql += " AND dNgayNhap BETWEEN @StartTime AND @EndTime";
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
