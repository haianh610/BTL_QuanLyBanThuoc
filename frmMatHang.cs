using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_QuanLyBanThuoc
{
    public partial class frmMatHang : Form
    {
        public frmMatHang()
        {
            InitializeComponent();
        }

        //###########################  CHỨC NĂNG THÊM-SỬA-XÓA-TÌM KIẾM ###########################################################################################

        //THÊM MẶT HÀNG
        public static bool ThemMH(string sMaLH, string sMaHang, string sTenHang, int iSoLuong, string sDVT, double fDonGia, DateTime dNSX, DateTime dHSD, string sHangSX, string sMaNCC)
        {
            bool Ma = checkExit("tblMatHang", "sMaHang", sMaHang);

            if (Ma == false)
            {
                //Ket noi Database (cnn : duong dan den Data)
                using (SqlConnection cnn = new SqlConnection(Connection.connection))
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "UP_ThemMH";

                        cmd.Parameters.AddWithValue("@sMaLH", sMaLH);
                        cmd.Parameters.AddWithValue("@sMaHang", sMaHang);
                        cmd.Parameters.AddWithValue("@sTenHang", sTenHang);
                        cmd.Parameters.AddWithValue("@iSoLuong", iSoLuong);
                        cmd.Parameters.AddWithValue("@sDVT", sDVT);
                        cmd.Parameters.AddWithValue("@fDonGia", fDonGia);
                        cmd.Parameters.AddWithValue("@dNSX", dNSX);
                        cmd.Parameters.AddWithValue("@dHSD", dHSD);
                        cmd.Parameters.AddWithValue("@sHangSX", sHangSX);
                        cmd.Parameters.AddWithValue("@sMaNCC", sMaNCC);

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

        //SỬA MẶT HÀNG
        public static bool SuaMH(string sMaLH, string sMaHang, string sTenHang, int iSoLuong, string sDVT, double fDonGia, DateTime dNSX, DateTime dHSD, string sHangSX, string sMaNCC)
        {

            string Tencu = LayGiaTriCu<string>("tblMatHang", "sTenHang", "sMaHang", sMaHang);
            string DVTcu = LayGiaTriCu<string>("tblMatHang", "sDVT", "sMaHang", sMaHang);
            string HangSXcu = LayGiaTriCu<string>("tblMatHang", "sHangSX", "sMaHang", sMaHang);

            int Soluongcu = LayGiaTriCu<int>("tblMatHang", "iSoLuong", "sMaHang", sMaHang);
            double DonGiacu = LayGiaTriCu<double>("tblMatHang", "fDonGia", "sMaHang", sMaHang);
            DateTime NSXcu = LayGiaTriCu<DateTime>("tblMatHang", "dNSX", "sMaHang", sMaHang);
            DateTime HSDcu = LayGiaTriCu<DateTime>("tblMatHang", "dHSD", "sMaHang", sMaHang);


            bool Ma = checkExit("tblMatHang", "sMaHang", sMaHang);

            if (Ma == true && (sTenHang != Tencu || iSoLuong != Soluongcu || sDVT != DVTcu || fDonGia != DonGiacu || dNSX != NSXcu || dHSD != HSDcu || sHangSX != HangSXcu))
            {
                using (SqlConnection cnn = new SqlConnection(Connection.connection))
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "suaMatHang";
                        cmd.Parameters.AddWithValue("@sMaHang", sMaHang);
                        cmd.Parameters.AddWithValue("@sMaLHmoi", sMaLH);
                        cmd.Parameters.AddWithValue("@sTenHangmoi", sTenHang);
                        cmd.Parameters.AddWithValue("@iSoLuongmoi", iSoLuong);
                        cmd.Parameters.AddWithValue("@sDVTmoi", sDVT);
                        cmd.Parameters.AddWithValue("@fDonGiamoi", fDonGia);
                        cmd.Parameters.AddWithValue("@dNSXmoi", dNSX);
                        cmd.Parameters.AddWithValue("@dHSDmoi", dHSD);
                        cmd.Parameters.AddWithValue("@sHangSXmoi", sHangSX);
                        cmd.Parameters.AddWithValue("@sMaNCCmoi", sMaNCC);

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

        //XÓA MẶT HÀNG
        public static bool XoaMH( string sMaHang, string sTenHang)
        {
            if (!checkExit("tblMatHang", "sMaHang", sMaHang) && !checkExit("tblMatHang", "sTenHang", sTenHang))
            {
                return false;
            }
            else
            {
                using (SqlConnection cnn = new SqlConnection(Connection.connection))
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "xoaMatHang";

                        cmd.Parameters.AddWithValue("@sMaHang", sMaHang);
                        cmd.Parameters.AddWithValue("@sTenHang", sTenHang);

                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        return i > 0;
                        cnn.Close();
                    }
                }
                return true;
            }
        }

        //TÌM KIẾM MẶT HÀNG
        private void search_TenHang(string sTenHang)
        {
            // Sử dụng SqlConnection để kết nối với cơ sở dữ liệu
            using (SqlConnection cnn = new SqlConnection(Connection.connection))
            {
                // Tạo một đối tượng SqlCommand với câu truy vấn SQL và kết nối
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "TimKiem_TenHang";
                    cmd.Parameters.AddWithValue("@sTenHang", sTenHang);
                    cnn.Open();
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("MH");
                        ad.Fill(tb);
                        MHview.DataSource = tb;
                    }

                }
            }
        }
        private void search_DonGia(float fGiaBD, float fGiaKT)
        {
            // Sử dụng SqlConnection để kết nối với cơ sở dữ liệu
            using (SqlConnection cnn = new SqlConnection(Connection.connection))
            {
                // Tạo một đối tượng SqlCommand với câu truy vấn SQL và kết nối
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "TimKiem_DonGia";
                    cmd.Parameters.AddWithValue("@fDonGiaBD", fGiaBD);
                    cmd.Parameters.AddWithValue("@fDonGiaKT", fGiaKT);

                    cnn.Open();
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("MH");
                        ad.Fill(tb);
                        MHview.DataSource = tb;
                    }
                    cnn.Close();

                }
            }
        }
        private void search_TenvaDonGia(string sTenHang, float fGiaBD, float fGiaKT)
        {
            using (SqlConnection cnn = new SqlConnection(Connection.connection))
            {
                // Tạo một đối tượng SqlCommand với câu truy vấn SQL và kết nối
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select * from tblMatHang where sTenHang like '%' + @sTenHang + '%' and fDonGia between @fDonGiaBD and @fDonGiaKT";
                    cmd.Parameters.AddWithValue("@sTenHang", sTenHang);
                    cmd.Parameters.AddWithValue("@fDonGiaBD", fGiaBD);
                    cmd.Parameters.AddWithValue("@fDonGiaKT", fGiaKT);
                    cnn.Open();
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("MH");
                        ad.Fill(tb);
                        MHview.DataSource = tb;
                    }
                    cnn.Close();
                }
            }
        }

        //HIỆN DS MẶT HÀNG
        public void HienMH()
        {
            // string sMaLH, string sMaHang, string sTenHang, int iSoLuong, string sDVT, double fDonGia, DateTime dNSX, DateTime dHSD, string sHangSX, string sMaNCC)
            using (SqlConnection cnn = new SqlConnection(Connection.connection))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select * from vwMatHang";
                    cnn.Open();
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("MH");
                        ad.Fill(tb);
                        MHview.DataSource = tb;
                    }

                }
            }
        }

        //###########################  CÁC HÀM CHECK ĐIỀU KIỆN  ###########################################################################################

        //Check MÃ Tồn Tại  
        public static bool checkExit(string TenBang, string TenCot, string GiaTri) //Sai chính tả :)))))
        {
            bool E = false;
            using (SqlConnection connection = new SqlConnection(Connection.connection))
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

        // LẤY GIÁ TRỊ CŨ
        public static T LayGiaTriCu<T>(string tenBang, string tenCot, string tenCotMa, string Ma)
        {
            T giaTriCu = default(T);

            using (SqlConnection cnn = new SqlConnection(Connection.connection))
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

        //CHECK ĐIỀU KIỆN THÊM - SỬA 
        //Đổi tên bool Ma, đọc gây hiểu lầm. nên đổi thành check tồn tại
        public bool checkThem(bool Ma,string sMaLH,string MaLHcu, string sTenHang, string Tencu, int iSoLuong, int Soluongcu, string sDVT, string DVTcu, double DonGiacu, double fDonGia, DateTime dNSX, DateTime NSXcu, DateTime dHSD, DateTime HSDcu, string sHangSX, string HangSXcu)
        {
            bool them = false;
            if ( (Ma == true && sMaLH == MaLHcu && sTenHang == Tencu && iSoLuong == Soluongcu && sDVT == DVTcu && fDonGia == DonGiacu && dNSX == NSXcu && dHSD == HSDcu && sHangSX == DVTcu ) || Ma == false)
            {
                //đúng thì thêm
                them = true;
            }
            else if (Ma == true && (sMaLH != MaLHcu || sTenHang != Tencu || iSoLuong != Soluongcu || sDVT != DVTcu || fDonGia != DonGiacu || dNSX != NSXcu || dHSD != HSDcu || sHangSX != HangSXcu))
            {
                //sai thì sửa
                them = false;
            }
            return them;
        }

        //######################################### SỰ KIỆN CHỨC NĂNG ############################################################################

        // Sự kiện nút Lưu
        private void btnLuu(object sender, EventArgs e)
        {
            string sMaLH, sMaHang, sTenHang, sDVT, sHangSX, sMaNCC;
            int iSoLuong;
            double fDonGia;
            DateTime dNSX, dHSD;
            sMaLH = cbxMaLH.SelectedValue.ToString();
            sMaHang = txtMaHang.Text;
            sTenHang = txtTenHang.Text;
            iSoLuong = int.Parse(txtSoLuong.Text);
            sDVT = txtDonVi.Text;
            fDonGia = double.Parse(txtDonGia.Text);
            dNSX = dpNSX.Value;
            dHSD = dpHSD.Value;
            sHangSX = txtHangSX.Text;
            sMaNCC = cbxMaNCC.SelectedValue.ToString();

            string MaLHcu = LayGiaTriCu<string>("tblMatHang","sMaLH", "sMaHang", sMaHang);
            string Tencu = LayGiaTriCu<string>("tblMatHang", "sTenHang", "sMaHang", sMaHang);
            string DVTcu = LayGiaTriCu<string>("tblMatHang", "sDVT", "sMaHang", sMaHang);
            string HangSXcu = LayGiaTriCu<string>("tblMatHang", "sHangSX", "sMaHang", sMaHang);

            int Soluongcu = LayGiaTriCu<int>("tblMatHang", "iSoLuong", "sMaHang", sMaHang);
            double DonGiacu = LayGiaTriCu<double>("tblMatHang", "fDonGia", "sMaHang", sMaHang);
            DateTime NSXcu = LayGiaTriCu<DateTime>("tblMatHang", "dNSX", "sMaHang", sMaHang);
            DateTime HSDcu = LayGiaTriCu<DateTime>("tblMatHang", "dHSD", "sMaHang", sMaHang);


            bool Ma = checkExit("tblMatHang", "sMaHang", sMaHang);

            if (checkThem(Ma, sMaLH, MaLHcu, sTenHang, Tencu, iSoLuong, Soluongcu, sDVT, DVTcu, DonGiacu, fDonGia, dNSX, NSXcu, dHSD, HSDcu, sHangSX, HangSXcu))
            {
                //btnSuaNCC.Visible = false;
                //btnThemNCC.Visible = true;

                //btnThem(btnThemNCC, EventArgs.Empty);
                bool t = ThemMH(sMaLH, sMaHang, sTenHang, iSoLuong, sDVT, fDonGia, dNSX, dHSD, sHangSX, sMaNCC);
                if (t)
                {
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienMH();
                }
                else
                {
                    MessageBox.Show("Nhà Cung Cấp đã tồn tại! Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (checkThem(Ma,sMaLH,MaLHcu, sTenHang, Tencu, iSoLuong, Soluongcu, sDVT, DVTcu, DonGiacu, fDonGia, dNSX, NSXcu, dHSD, HSDcu, sHangSX, HangSXcu) == false)
            {
                // Hiển thị cảnh báo thông tin chỉnh sửa
                List<string> thongTinChinhSua = new List<string>();

                if (sMaLH != MaLHcu)
                { thongTinChinhSua.Add("Đơn vị tính từ '" + DVTcu + "' thành '" + sDVT + "'"); }

                if (sTenHang != Tencu)
                { thongTinChinhSua.Add("Tên mặt hàng từ '" + Tencu + "' thành '" + sTenHang + "'"); }

                if (iSoLuong != Soluongcu)
                { thongTinChinhSua.Add("Số lượng từ '" + Soluongcu + "' thành '" + iSoLuong + "'"); }

                if (sDVT != DVTcu)
                { thongTinChinhSua.Add("Đơn vị tính từ '" + DVTcu + "' thành '" + sDVT + "'"); }

                if (sDVT != DVTcu)
                { thongTinChinhSua.Add("Đơn vị tính từ '" + DVTcu + "' thành '" + sDVT + "'"); }

                if (sDVT != DVTcu)
                { thongTinChinhSua.Add("Đơn vị tính từ '" + DVTcu + "' thành '" + sDVT + "'"); }



                string message = "Bạn chắc chắn muốn thực hiện sửa đổi mặt hàng " + sMaHang + ":\n" +
                                 string.Join("\n", thongTinChinhSua.ToArray()) + "\nKhông thể hoàn tác sau khi sửa đổi.";

                bool s = SuaMH(sMaLH, sMaHang, sTenHang, iSoLuong, sDVT, fDonGia, dNSX, dHSD, sHangSX, sMaNCC);
                if (s)
                {
                    DialogResult result = MessageBox.Show(message, "Xác nhận sửa đổi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show("Sửa thành công!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienMH();
                    }
                }
                else
                { MessageBox.Show("Sửa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void btnXoaMH_Click(object sender, EventArgs e)
        {
            string sTenHang, sMaHang;
            if(txtTenHang.Text == "" && txtMaHang.Text == "")
            {
                MessageBox.Show("Nhập tên hàng hóa hoặc mã hàng hóa để xóa mặt hàng!!", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                sTenHang = txtTenHang.Text;
                sMaHang = txtMaHang.Text;
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa mặt hàng " + sTenHang + " " + sMaHang, "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool i = XoaMH(sMaHang, sTenHang);
                    if (i)
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienMH();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                }
            }    
        }

        private void txtTimTen_TextChanged(object sender, EventArgs e)
        {
            string sTenHang;
            if (ckbTen.Checked && !ckbDonGia.Checked)
            {
                sTenHang = txtTimTen.Text;
                search_TenHang(sTenHang);
            }
            else if (ckbDonGia.Checked && !ckbTen.Checked)
            {
                txtGiaKT_TextChanged(sender, e);
            }    
            else if (ckbTen.Checked && ckbDonGia.Checked)
            {
                float fGiaBD, fGiaKT;
                if (txtGiaBD.Text == "")
                {
                    fGiaBD = 0;
                }
                else if (txtGiaKT.Text == "")
                {
                    fGiaKT = 0;
                    fGiaBD = float.Parse(txtGiaBD.Text);
                }
                else
                {
                    sTenHang = txtTimTen.Text;
                    fGiaBD = float.Parse(txtGiaBD.Text);
                    fGiaKT = float.Parse(txtGiaKT.Text);
                    search_TenvaDonGia(sTenHang, fGiaBD, fGiaKT);
                }
            }    
        }
        private void txtGiaKT_TextChanged(object sender, EventArgs e)
        {
            float fGiaBD,fGiaKT;

            if (ckbDonGia.Checked && !ckbTen.Checked)
            {
                if (txtGiaBD.Text == "")
                {
                    fGiaBD = 0;
                }
                else if (txtGiaKT.Text == "")
                {
                    fGiaKT = 0;
                    fGiaBD = float.Parse(txtGiaBD.Text);
                }
                else
                {
                    fGiaBD = float.Parse(txtGiaBD.Text);
                    fGiaKT = float.Parse(txtGiaKT.Text);
                    search_DonGia(fGiaBD, fGiaKT);
                }
            }
            else
            {
                txtTimTen_TextChanged(sender, e);
            }    
        }


        //######################################### SỰ KIỆN MÀN HÌNH ############################################################################

        // Lấy dữ liệu từ DS Loại Hàng
        private void DsLoaiHang()
        {
            using (SqlConnection cnn = new SqlConnection(Connection.connection))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblLoaiHang", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("LH");
                        ad.Fill(tb);
                        cbxMaLH.DataSource = tb;
                        cbxMaLH.DisplayMember = "sTenLH";
                        cbxMaLH.ValueMember = "sMaLH";
                    }
                }
            }
        }


        //Lấy dữ liệu từ DS Nhà Cung Cấp
        private void DsNCC()
        {
            using (SqlConnection cnn = new SqlConnection(Connection.connection))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblNhaCungCap", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("NCC");
                        ad.Fill(tb);
                        cbxMaNCC.DataSource = tb;
                        cbxMaNCC.DisplayMember = "sTenNCC";
                        cbxMaNCC.ValueMember = "sMaNCC";
                    }
                }
            }
        }

        private void MatHang_Load(object sender, EventArgs e)
        {
            DsLoaiHang();
            DsNCC();
            HienMH();

        }


        private void Reload(object sender, DataGridViewCellEventArgs e)
        {
            cbxMaLH.Text = MHview.CurrentRow.Cells["Mã Loại Hàng"].Value.ToString();
            txtMaHang.Text = MHview.CurrentRow.Cells["Mã Mặt Hàng"].Value.ToString();
            txtTenHang.Text = MHview.CurrentRow.Cells["Tên Mặt Hàng"].Value.ToString();
            txtSoLuong.Text = MHview.CurrentRow.Cells["Số Lượng"].Value.ToString();
            txtDonVi.Text = MHview.CurrentRow.Cells["Đơn Vị"].Value.ToString();
            txtDonGia.Text = MHview.CurrentRow.Cells["Đơn Giá"].Value.ToString();
            dpNSX.Text = MHview.CurrentRow.Cells["Ngày SX"].Value.ToString();
            dpHSD.Text = MHview.CurrentRow.Cells["Hạn SD"].Value.ToString();
            txtHangSX.Text = MHview.CurrentRow.Cells["Hãng SX"].Value.ToString();
            cbxMaNCC.Text = MHview.CurrentRow.Cells["Mã Nhà Cung Cấp"].Value.ToString();

        }
    }
}

