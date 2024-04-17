using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_QuanLyBanThuoc
{
    public static class dbConnect
    {
        public static string ConnectionString { get; } = ConfigurationManager.ConnectionStrings["db_qlthuoc"].ConnectionString;
    }
    class Program
    {
        static void Main(string[] args)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["db_qlthuoc"].ConnectionString;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TrangChu());
        }


        //public static bool xoaNXB(string connection, string sMaNXB)
        //{
        //    string deletesql = "DELETE FROM tblNXB WHERE sMaNXB=" + sMaNXB + "";
        //    using (SqlConnection cnn = new SqlConnection(connection))
        //    {
        //        using (SqlCommand cmddelete = new SqlCommand(deletesql, cnn))
        //        {
        //            cmddelete.CommandType = System.Data.CommandType.Text;
        //            cnn.Open();
        //            int i = cmddelete.ExecuteNonQuery();
        //            cnn.Close();
        //            return i > 0;
        //        }
        //    }
        //}



        public static bool checkMa(string connectionString, string TenBang, string TenCot, string Ma)
        {
            bool E = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"select count(*) from {TenBang} where {TenCot} = @Ma";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Ma", Ma);

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

                    }

                }
            }
            return E;
        }
    }
}