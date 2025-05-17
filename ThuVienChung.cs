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
    class ThuVienChung
    {
        //############################### CHỨC NĂNG ###############################

        //Hiển Thị
        public static void Hien(string table, DataGridView view)
        {
            using (SqlConnection cnn = new SqlConnection(dbConnect.ConnectionString))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select * from " + table;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tb");
                        ad.Fill(tb);
                        view.DataSource = tb;
                    }
                }
            }
        }

        public static void Hienn(string viewName, string DieuKien, DataGridView view)
        {
            using (SqlConnection cnn = new SqlConnection(dbConnect.ConnectionString))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select * from " + viewName + DieuKien;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tb");
                        ad.Fill(tb);
                        view.DataSource = tb;
                    }
                }
            }
        }

        //Xóa
        public static bool Xoa(string table, string collumn, string GiaTri)
        {
            if (!CheckExsit(table, collumn, GiaTri))
            {
                return false;
            }
            else
            {
                using (SqlConnection cnn = new SqlConnection(dbConnect.ConnectionString))
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "XoaTheoDieuKien";

                        cmd.Parameters.AddWithValue("@TenBang", table);
                        cmd.Parameters.AddWithValue("@TenCot", collumn);
                        cmd.Parameters.AddWithValue("@GiaTri", GiaTri);

                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        return i > 0;
                        cnn.Close();
                    }
                }
                return true;
            }
        }

        //Tìm Kiếm
        public static void TimKiem(string proc, string CotTamThoi, string GiaTri, DataGridView view)
        {
            // Sử dụng SqlConnection để kết nối với cơ sở dữ liệu
            using (SqlConnection cnn = new SqlConnection(dbConnect.ConnectionString))
            {
                // Tạo một đối tượng SqlCommand với câu truy vấn SQL và kết nối
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = proc;
                    cmd.Parameters.AddWithValue(CotTamThoi, GiaTri);
                    cnn.Open();
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tb");
                        ad.Fill(tb);
                        view.DataSource = tb;
                    }

                }
            }
        }



        //private void search_TenvaDonGia(string sTenHang, float fGiaBD, float fGiaKT)
        //{
        //    using (SqlConnection cnn = new SqlConnection(Connection.connection))
        //    {
        //        // Tạo một đối tượng SqlCommand với câu truy vấn SQL và kết nối
        //        using (SqlCommand cmd = cnn.CreateCommand())
        //        {
        //            cmd.CommandType = CommandType.Text;
        //            cmd.CommandText = "Select * from tblMatHang where sTenHang like '%' + @sTenHang + '%' and fDonGia between @fDonGiaBD and @fDonGiaKT";
        //            cmd.Parameters.AddWithValue("@sTenHang", sTenHang);
        //            cmd.Parameters.AddWithValue("@fDonGiaBD", fGiaBD);
        //            cmd.Parameters.AddWithValue("@fDonGiaKT", fGiaKT);
        //            cnn.Open();
        //            using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
        //            {
        //                DataTable tb = new DataTable("MH");
        //                ad.Fill(tb);
        //                MHview.DataSource = tb;
        //            }
        //            cnn.Close();
        //        }
        //    }
        //}


        //############################### KIỂM TRA ###############################

        // Kiểm Tra Tồn Tại
        public static bool CheckExsit(string TenBang, string TenCot, string GiaTri)
        {
            bool E = false;
            using (SqlConnection connection = new SqlConnection(dbConnect.ConnectionString))
            {
                string query = $"select count(*) from {TenBang} where {TenCot} = @GiaTri";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@GiaTri", GiaTri);

                    try
                    {
                        connection.Open();
                        //ExecuteScalar : trả về số lượng hàng SELECT 
                        //ExecuteNonQuery : trả về số lượng hàng bị ảnh hưởng
                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                        {
                            E = true;
                        }

                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Error" + ex.Message);

                    }

                }
            }
            return E;
        }



        //############################### LẤY DỮ LIỆU ###############################
        
        //Lấy Dữ Liệu Cũ
        public T LayGiaTriCu<T>(string tenBang, string tenCot, string tenCotMa, string Ma)
        {
            T giaTriCu = default(T);

            using (SqlConnection cnn = new SqlConnection(dbConnect.ConnectionString))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"SELECT {tenCot} FROM {tenBang} WHERE {tenCotMa} = @Ma";
                    cmd.Parameters.AddWithValue("@Ma", Ma);
                    cnn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        giaTriCu = (T)Convert.ChangeType(result, typeof(T));
                    }
                }
            }

            return giaTriCu;
        }


        //Lấy Dữ Liệu Để Hiện Thị
        public static void LayDuLieu(string table, string displayMember, string valueMember, ComboBox comboBox)
        {
            using (SqlConnection cnn = new SqlConnection(dbConnect.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from " + table, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        comboBox.DataSource = tb;
                        comboBox.DisplayMember = displayMember;
                        comboBox.ValueMember = valueMember;
                    }
                }
            }
        }


       


    }
}
