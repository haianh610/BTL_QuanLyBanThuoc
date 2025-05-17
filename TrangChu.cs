using System;
using System.Windows.Forms;

namespace BTL_QuanLyBanThuoc
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void loạiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLoaiHang LH = new fLoaiHang();
            LH.MdiParent = this;
            LH.Show();
        }

        private void mặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fMatHang MH = new fMatHang();
            MH.MdiParent = this;
            MH.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNhaCungCap NCC = new fNhaCungCap();
            NCC.MdiParent = this;
            NCC.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string SDT = "";
            DangNhap DN = new DangNhap(SDT);
            DN.MdiParent = this;
            DN.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien NV = new frmQuanLyNhanVien();
            NV.MdiParent = this;
            NV.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListHoaDon2 HD = new frmListHoaDon2();
            HD.MdiParent = this;
            HD.Show();
        }

        private void danhSáchHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListHoaDon2 HD = new frmListHoaDon2();
            HD.MdiParent = this;
            HD.Show();
        }

        private void nVMoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSNV2 NV = new frmDSNV2();
            NV.MdiParent = this;
            NV.Show();
        }

        private void báoCáoNhậpXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBaoCaoHangHoaNhapXuat frm = new fBaoCaoHangHoaNhapXuat();
            frm.MdiParent = this;
            frm.Show();
        }

        private void danhSáchPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachPN frm = new DanhSachPN();
            frm.MdiParent = this;
            frm.Show();
        }

        private void timHangNCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
