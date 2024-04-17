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
    public partial class ThongKeChucVu : Form
    {
        public ThongKeChucVu()
        {
            InitializeComponent();
        }

        private void ThongKeChucVu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhoThuocTayDataSet1.tblNhanVien' table. You can move, or remove it, as needed.
            this.tblNhanVienTableAdapter.Fill(this.quanLyKhoThuocTayDataSet1.tblNhanVien);

        }
    }
}
