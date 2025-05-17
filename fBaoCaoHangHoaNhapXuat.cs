using CrystalDecisions.CrystalReports.Engine;
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
    public partial class fBaoCaoHangHoaNhapXuat : Form
    {
        public fBaoCaoHangHoaNhapXuat()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void report()
        {
            ReportDocument cryRPt = new ReportDocument();
            //Thay đường dẫn
            cryRPt.Load(@"C:\Users\Administrator\Source\Repos\BTL_QuanLyBanThuoc\BaoCaoHangHoaNhapXuat.rpt");
            BCHangHoaNhapXuat.ReportSource = cryRPt;
            BCHangHoaNhapXuat.Refresh();
        }
        

        private void btnFinish_Click(object sender, EventArgs e)
        {
            DateTime NgayBD = dtpNgayBD.Value;
            DateTime NgayKT = dtpNgayKT.Value;
            if(NgayBD > NgayKT)
            {
                MessageBox.Show("Thời gian không hợp lệ!", "Lỗi", MessageBoxButtons.RetryCancel , MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection cnn = new SqlConnection(dbConnect.ConnectionString))
                {
                    // Tạo một đối tượng SqlCommand với câu truy vấn SQL và kết nối
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "BaoCaoHangHoaNhapXuat";
                        cmd.Parameters.AddWithValue("@NgayBD", NgayBD);
                        cmd.Parameters.AddWithValue("@NgayKT", NgayKT);
                        cmd.Parameters.AddWithValue("@NguoiLap", txbNguoiLapBC.Text);
                        cnn.Open();
                        using (SqlDataAdapter ad = new SqlDataAdapter())
                        {
                            ad.SelectCommand = cmd;
                            DataTable tb = new DataTable("BCHangHoa");
                            ad.Fill(tb);
                            BaoCaoHangHoaNhapXuat cryRpt = new BaoCaoHangHoaNhapXuat();

                            cryRpt.SetDataSource(tb);
                            BCHangHoaNhapXuat.ReportSource = cryRpt;
                            BCHangHoaNhapXuat.Refresh();
                        }
                    }
                }
            }    
        }

       
    }
}
