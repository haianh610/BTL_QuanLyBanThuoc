using System;
using System.Configuration;
using System.Data.SqlClient;

namespace BTL_QuanLyBanThuoc
{
    class ConsoleApp
    {
        public static void MenuConsoleApp()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["db_qlthuoc"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection())
            {
                int n = 0;
                do
                {
                    Console.WriteLine("____________________________________");
                    Console.WriteLine("1.Them Nhan vien");
                    Console.WriteLine("2.Hien Nhan Vien");
                    Console.WriteLine("3.Sua nhan vien");
                    Console.WriteLine("4.Xoa nhan vien");
                    Console.WriteLine("5.Sap Xep Theo Ten Nha Xuat Ban");
                    Console.WriteLine("6.Them Nha Xuat Ban Bang Proc");
                    Console.WriteLine("____________________________________");
                    Console.Write("Chon chuc nang: ");

                    n = int.Parse(Console.ReadLine());

                    switch (n)
                    {
                        case 1:
                            themNVconsole();
                            break;

                        case 2:

                            hienDSNV(dbConnect.ConnectionString);
                            break;

                        case 3:
                            suaNVconsole();
                            break;

                        case 4:
                            xoaNVconsole();
                            break;

                        //case 5:
                        //    sapXep(connectionString);
                        //    break;

                        //case 6:
                        //    string tenNxb;
                        //    Console.Write("\nTen NXB Can Tim: ");
                        //    tenNxb = Convert.ToString(Console.ReadLine());
                        //    timTenNhaXB(connectionString, tenNxb);
                        //    break;
                        default:
                            Console.WriteLine("Lua Chon Khong Hop Le");
                            break;
                    }
                } while (n != 6);
            }
        }
        private static void themNVconsole()
        {
            bool i = false;
            do
            {
                string sMaNV; string sTenNV; int bGioiTinh; DateTime dNgaySinh; string sChucVu; string sDiaChi; string sSDT; DateTime dNgayVaoLam;
                Console.Write("\nNhap Ma nhan vien: ");
                sMaNV = Convert.ToString(Console.ReadLine());
                string Ma = sMaNV;
                if (Program.checkMa(dbConnect.ConnectionString, "tblNhanVien", "sMaNV", Ma))
                {
                    Console.Write("\nMa da ton tai!\n");
                    break;
                }
                Console.Write("\nNhap Ten nhan vien: ");
                sTenNV = Convert.ToString(Console.ReadLine());
                Console.Write("\nNhap gioi tinh");
                bGioiTinh = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nNhap ngay sinh: ");
                dNgaySinh = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Nhap chuc vu: ");
                sChucVu = Console.ReadLine();
                Console.Write("\nNhap Dia Chi: ");
                sDiaChi = Convert.ToString(Console.ReadLine());
                Console.Write("\nNhap So Dien Thoai: ");
                sSDT = Convert.ToString(Console.ReadLine());
                Console.Write("\nNhap ngay vao lam: ");
                dNgayVaoLam = Convert.ToDateTime(Console.ReadLine());


                NhanVien.themNV(dbConnect.ConnectionString, sMaNV, sTenNV, bGioiTinh, dNgaySinh, sChucVu, sDiaChi, sSDT, dNgayVaoLam);
                Console.WriteLine("Them Thanh Cong");

                i = true;
            } while (i == false);
        }
        public static void hienDSNV(string connection)
        {
            Console.WriteLine("\nMaNV" + "\t\tTenNV" + "\tGioiTinh" + "\tNgaySinh" + "\tChucVu" + "\tDiaChi" + "\tDiaChi" + "\tSDT" + "\tNgayVaoLam");
            using (SqlConnection cnn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT* FROM tblNhanVien", cnn))
                {
                    cnn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}", rd["sMaNV"], rd["sTenNV"], rd["bGioiTinh"], rd["dNgaySinh"], rd["sChucVu"], rd["sDiaChi"], rd["sSDT"], rd["dNgayVaoLam"]);
                        }
                        rd.Close();
                        cnn.Close();
                    }

                }
            }
        }
        private static void suaNVconsole()
        {
            bool i;
            do
            {
                string sMaNV; string sTenNV; int bGioiTinh; DateTime dNgaySinh; string sChucVu; string sDiaChi; string sSDT; DateTime dNgayVaoLam;
                Console.Write("\nNhap Ma nhan vien: ");
                sMaNV = Convert.ToString(Console.ReadLine());
                string Ma = sMaNV;
                if (Program.checkMa(dbConnect.ConnectionString, "tblNhanVien", "sMaNV", Ma) == false)
                {
                    Console.Write("\nMa khong ton tai!\n");
                    break;
                }
                else
                {
                    Console.WriteLine("Nhan vien dang sua: ");
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = new SqlConnection(dbConnect.ConnectionString);
                        cmd.CommandText = "SELECT * FROM tblNhanVien WHERE sMaNV='" + Ma + "'";
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Connection.Open();
                        SqlDataReader rd = cmd.ExecuteReader();
                        rd.Read();
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}", rd["sMaNV"], rd["sTenNV"], rd["bGioiTinh"], rd["dNgaySinh"], rd["sChucVu"], rd["sDiaChi"], rd["sSDT"], rd["dNgayVaoLam"]);
                        rd.Close();
                        cmd.Connection.Close();
                    }
                }

                Console.Write("\nNhap Ten nhan vien: ");
                sTenNV = Convert.ToString(Console.ReadLine());
                Console.Write("\nNhap gioi tinh");
                bGioiTinh = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nNhap ngay sinh: ");
                dNgaySinh = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Nhap chuc vu: ");
                sChucVu = Console.ReadLine();
                Console.Write("\nNhap Dia Chi: ");
                sDiaChi = Convert.ToString(Console.ReadLine());
                Console.Write("\nNhap So Dien Thoai: ");
                sSDT = Convert.ToString(Console.ReadLine());
                Console.Write("\nNhap ngay vao lam: ");
                dNgayVaoLam = Convert.ToDateTime(Console.ReadLine());


                NhanVien.suaNV(dbConnect.ConnectionString, sMaNV, sTenNV, bGioiTinh, dNgaySinh, sChucVu, sDiaChi, sSDT, dNgayVaoLam);
                Console.WriteLine("Sua Thanh Cong");

                i = true;
            } while (i == false);
        }
        private static void xoaNVconsole()
        {
            bool i = false;
            do
            {
                string sMaNV;
                Console.Write("\nNhap Ma nhan vien: ");
                sMaNV = Convert.ToString(Console.ReadLine());
                NhanVien.xoaNV(dbConnect.ConnectionString, sMaNV);
                Console.WriteLine("Xoa Thanh Cong");

                i = true;
            } while (i == false);
        }
    }
}
