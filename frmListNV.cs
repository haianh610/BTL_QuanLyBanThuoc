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
    public partial class frmListNV : Form
    {
        public frmListNV()
        {
            InitializeComponent();
        }

        private void frmListNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhoThuocTayDataSet11.tblNhanVien' table. You can move, or remove it, as needed.
            this.tblNhanVienTableAdapter.Fill(this.quanLyKhoThuocTayDataSet11.tblNhanVien);

        }

        private void txtTimKiemNV_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiemNV.TextLength > 1)
            {
                dgvNhanVien.DataSource = NhanVien.SearchNhanVien(txtTimKiemNV.Text);
            }
            if (txtTimKiemNV.TextLength == 0)
            {
                dgvNhanVien.DataSource = tblNhanVienBindingSource;
            }
        }

        private void btnChucVu_Click(object sender, EventArgs e)
        {

        }
    }
}
