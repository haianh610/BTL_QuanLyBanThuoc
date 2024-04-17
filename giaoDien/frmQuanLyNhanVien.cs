using System;
using System.Windows.Forms;

namespace BTL_QuanLyBanThuoc
{
    public partial class frmQuanLyNhanVien : Form
    {
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhoThuocTayDataSet.tblNhanVien' table. You can move, or remove it, as needed.
            tblNhanVienTableAdapter.Fill(quanLyKhoThuocTayDataSet11.tblNhanVien);

        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Cột bảng chạy từ 0 đến cột cuối
            txtMaNV.Text = dgvNhanVien.CurrentRow.Cells["sMaNVDataGridViewTextBoxColumn"].Value.ToString();
            txtTenNV.Text = dgvNhanVien.CurrentRow.Cells["sTenNVDataGridViewTextBoxColumn"].Value.ToString();
            cbxGioiTinh.SelectedIndex = int.Parse(dgvNhanVien.CurrentRow.Cells["bGioiTinhDataGridViewCheckBoxColumn"].Value.ToString());
            dtpNgaySinh.Value = DateTime.Parse(dgvNhanVien.CurrentRow.Cells["dNgaySinhDataGridViewTextBoxColumn"].Value.ToString());
            txtChucVu.Text = dgvNhanVien.CurrentRow.Cells["sChucVuDataGridViewTextBoxColumn"].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells["sDiaChiDataGridViewTextBoxColumn"].Value.ToString();
            txtSDT.Text = dgvNhanVien.CurrentRow.Cells["sSDTDataGridViewTextBoxColumn"].Value.ToString();
            dtpNgayVaoLam.Value = DateTime.Parse(dgvNhanVien.CurrentRow.Cells["dNgayVaoLamDataGridViewTextBoxColumn"].Value.ToString());
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvNhanVien_CellContentClick(sender, e);
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            NhanVien.themNV(dbConnect.ConnectionString, txtMaNV.Text, txtTenNV.Text, cbxGioiTinh.SelectedIndex, dtpNgaySinh.Value, txtChucVu.Text, txtDiaChi.Text, txtSDT.Text, dtpNgayVaoLam.Value);
            tblNhanVienTableAdapter.Fill(quanLyKhoThuocTayDataSet11.tblNhanVien);
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            NhanVien.suaNV(dbConnect.ConnectionString, txtMaNV.Text, txtTenNV.Text, cbxGioiTinh.SelectedIndex, dtpNgaySinh.Value, txtChucVu.Text, txtDiaChi.Text, txtSDT.Text, dtpNgayVaoLam.Value,1);
            tblNhanVienTableAdapter.Fill(quanLyKhoThuocTayDataSet11.tblNhanVien);
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            NhanVien.xoaNV(dbConnect.ConnectionString, txtMaNV.Text);
            tblNhanVienTableAdapter.Fill(quanLyKhoThuocTayDataSet11.tblNhanVien);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Program.checkMa(dbConnect.ConnectionString, "tblNhanVien", "sMaNV", txtMaNV.Text))
            {
                NhanVien.suaNV(dbConnect.ConnectionString, txtMaNV.Text, txtTenNV.Text, cbxGioiTinh.SelectedIndex, dtpNgaySinh.Value, txtChucVu.Text, txtDiaChi.Text, txtSDT.Text, dtpNgayVaoLam.Value,1);
                tblNhanVienTableAdapter.Fill(quanLyKhoThuocTayDataSet11.tblNhanVien);
            }
            else
            {
                NhanVien.themNV(dbConnect.ConnectionString, txtMaNV.Text, txtTenNV.Text, cbxGioiTinh.SelectedIndex, dtpNgaySinh.Value, txtChucVu.Text, txtDiaChi.Text, txtSDT.Text, dtpNgayVaoLam.Value);
                tblNhanVienTableAdapter.Fill(quanLyKhoThuocTayDataSet11.tblNhanVien);
            }
        }
    }
}
