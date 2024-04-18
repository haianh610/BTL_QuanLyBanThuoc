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
    public partial class frmInHoaDon : Form
    {
        public frmInHoaDon(string maHD)
        {
            InitializeComponent();

            rptHoaDon1.SetParameterValue("@maHD", maHD);
        }
    }
}
