using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyBanThuoc.Code
{
    public class SourceChiTietPhieuNhap
    {
        public string sMaPN { get; set; }
        public string sMaHang { get; set; }
        public float fGiaNhap { get; set; }
        public int iSoLuong { get; set; }
        public float fThanhTien { get; set; }
        public DateTime dNSX { get; set; }
        public DateTime dHSD { get; set; }

        public SourceChiTietPhieuNhap() //Overload CT Hóa đơn mới
        {
            // Initialize properties as needed
            sMaPN = "";
            sMaHang = "";
            fGiaNhap = 0.0f;
            iSoLuong = 0;
            fThanhTien = 0.0f;
            dNSX = DateTime.Parse("");
            dHSD = DateTime.Parse("");
        }
        // Constructor
        public SourceChiTietPhieuNhap(string maPN, string maHang,float giaNhap, int soLuong, float thanhTien,DateTime NSX, DateTime HSD)
        {
            sMaPN = maPN;
            sMaHang = maHang;
            fGiaNhap = giaNhap;
            iSoLuong = soLuong;
            fThanhTien = thanhTien;
            dNSX = NSX;
            dHSD = HSD;
        }
    }
    class ChucNangChiTietPhieuNhap
    {
        public static bool themChiTietPN(string connection, string maPN, string maHang,int soLuong,float giaNhap,DateTime nsx, DateTime hsd)
        {
            using (SqlConnection cnn = new SqlConnection(connection))
            {
                using (SqlCommand insertcmd = new SqlCommand("UP_ThemChiTietPhieuNhap", cnn))
                {
                    insertcmd.CommandType = CommandType.StoredProcedure;
                    insertcmd.Parameters.AddWithValue("@maPN", maPN);
                    insertcmd.Parameters.AddWithValue("@maHang", maHang);
                    insertcmd.Parameters.AddWithValue("@soLuong", soLuong);
                    insertcmd.Parameters.AddWithValue("@giaNhap", giaNhap);
                    insertcmd.Parameters.AddWithValue("@NSX", nsx);
                    insertcmd.Parameters.AddWithValue("@HSD", hsd);
                    cnn.Open();
                    int i = insertcmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }


        public static bool suaChiTietPN(string connection, string maPN, string maHang, float giaNhap, int soLuong, float thanhTien, DateTime NSX, DateTime HSD)
        {
            using (SqlConnection cnn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand("UP_SuaChiTietPhieuNhap", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maPN", maPN);
                    cmd.Parameters.AddWithValue("@maHang", maHang);
                    cmd.Parameters.AddWithValue("@soLuong", soLuong);
                    cmd.Parameters.AddWithValue("@thanhTien", thanhTien);
                    cmd.Parameters.AddWithValue("@giaNhap", giaNhap);
                    cmd.Parameters.AddWithValue("@NSX", NSX);
                    cmd.Parameters.AddWithValue("@HSD", HSD);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }


        public static bool xoaChiTietPN(string connection, string maPN, string maHang)
        {
            using (SqlConnection cnn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand("UP_XoaChiTietPhieuNhap", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maPN", maPN);
                    cmd.Parameters.AddWithValue("@maHang", maHang);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }
        public static bool CheckExistCTPN(string maPN, string maHang)
        {
            bool E = false;
            using (SqlConnection connection = new SqlConnection(dbConnect.ConnectionString))
            {
                string query = $"select count(*) from tblChiTietPhieuNhap where sMaHang = @maHang AND sMaPN = @maPN";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@maHang", maHang);
                    cmd.Parameters.AddWithValue("@maPN", maPN);

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
        public static bool CheckExistCTPN(string maPN)
        {
            bool E = false;
            using (SqlConnection connection = new SqlConnection(dbConnect.ConnectionString))
            {
                string query = $"select count(*) from tblChiTietPhieuNhap where sMaPN = @maPN";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@maPN", maPN);

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
