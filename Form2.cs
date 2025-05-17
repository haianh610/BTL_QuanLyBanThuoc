using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLyBanThuoc
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhoThuocTayDataSet2.tblNhaCungCap' table. You can move, or remove it, as needed.
            this.tblNhaCungCapTableAdapter.Fill(this.quanLyKhoThuocTayDataSet2.tblNhaCungCap);

        }

        private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ma = cbo.Text.ToString();
            CrystalReportNCC_Hang1.SetParameterValue("@maNCC", ma);
            CrystalReportNCC_Hang1.Refresh();
        }
    }
}
