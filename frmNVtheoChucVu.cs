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
    public partial class frmNVtheoChucVu : Form
    {
        public frmNVtheoChucVu()
        {
            InitializeComponent();

            this.tblNhanVienTableAdapter.Fill(this.quanLyKhoThuocTayDataSet11.tblNhanVien);
        }



        private void cboGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbChucVu.SelectedItem.ToString() == "Nhân viên bán hàng")
            {
                dgvNhanVien.DataSource = NhanVien.SearchChucVuNhanVien(cbbChucVu.Text);
            }
            else if(cbbChucVu.SelectedItem.ToString() == "Quản lý")
            {
                dgvNhanVien.DataSource = NhanVien.SearchChucVuNhanVien(cbbChucVu.Text);
            }else if(cbbChucVu.SelectedItem.ToString() == "Nhân viên nhập hàng")
            {
                dgvNhanVien.DataSource = NhanVien.SearchChucVuNhanVien(cbbChucVu.Text);
            }
        }
    }
}
