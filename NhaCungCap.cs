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
    class NhaCungCap
    {
        //###########################  CHỨC NĂNG THÊM-SỬA-XÓA-TÌM KIẾM ###########################################################################################

        // THÊM NHÀ CUNG CẤP
        public static bool ThemNCC(string sMaNCC, string sTenNCC, string sDiaChi, string sSdtNCC, int iTrangThai,string sMaSoThue)
        {
            bool Ma = ThuVienChung.CheckExsit("tblNhaCungCap", "sMaNCC", sMaNCC);

            if (Ma == false)
            {
                //Ket noi Database (cnn : duong dan den Data)
                using (SqlConnection cnn = new SqlConnection(dbConnect.ConnectionString))
                {
                    //SqlCommand : thực thi lệnh (thêm, sửa, xóa, truy vấn) 
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "UP_ThemNCC";
                        //Parameters : cách truyền tham số vào SQL
                        cmd.Parameters.AddWithValue("@sMaNCC", sMaNCC);
                        cmd.Parameters.AddWithValue("@sTenNCC", sTenNCC);
                        cmd.Parameters.AddWithValue("@sDiaChi", sDiaChi);
                        cmd.Parameters.AddWithValue("@sSdtNCC", sSdtNCC);
                        cmd.Parameters.AddWithValue("@iTrangThai", iTrangThai);
                        cmd.Parameters.AddWithValue("@sMaSoThue", sMaSoThue);
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

        //SỬA NHÀ CUNG CẤP
        public static bool SuaNCC(string sMaNCC, string sTenNCC, string sDiaChi, string sSdtNCC,string sMaSoThue)
        {
            ThuVienChung t = new ThuVienChung();

            string Tencu = t.LayGiaTriCu<string>("tblNhaCungCap", "sTenNCC", "sMaNCC", sMaNCC);
            string DiaChicu = t.LayGiaTriCu<string>("tblNhaCungCap", "sDiaChi", "sMaNCC", sMaNCC);
            string Sdtcu = t.LayGiaTriCu<string>("tblNhaCungCap", "sSdtNCC", "sMaNCC", sMaNCC);

            bool Ma = ThuVienChung.CheckExsit("tblNhaCungCap", "sMaNCC", sMaNCC);

            if (Ma == true && (sTenNCC != Tencu || sDiaChi != DiaChicu || sSdtNCC != Sdtcu))
            {
                using (SqlConnection cnn = new SqlConnection(dbConnect.ConnectionString))
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "suaNhaCungCap";

                        cmd.Parameters.AddWithValue("@sMaNCC", sMaNCC);
                        cmd.Parameters.AddWithValue("@sTenNCCmoi", sTenNCC);
                        cmd.Parameters.AddWithValue("@sDiaChimoi", sDiaChi);
                        cmd.Parameters.AddWithValue("@sSdtNCCmoi", sSdtNCC);
                        cmd.Parameters.AddWithValue("@sMaSoThue", sMaSoThue);
                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        cnn.Close();
                        return i > 0;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }


        //CHECK ĐIỀU KIỆN THÊM - SỬA
        public static bool checkThem(bool Ma, string sTenNCC, string Tencu, string sDiaChi, string DiaChicu, string sSdtNCC, string Sdtcu)
        {
            bool them = false;
            if ((Ma == true && sTenNCC == Tencu && sDiaChi == DiaChicu && sSdtNCC == Sdtcu) || Ma == false)
            {
                //đúng thì thêm
                them = true;
            }
            else if (Ma == true && (sTenNCC != Tencu || sDiaChi != DiaChicu || sSdtNCC != Sdtcu))
            {
                //sai thì sửa
                them = false;
            }
            return them;  
        }

    }
}
