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
            //LoaiHang LH = new LoaiHang();
            //LH.MdiParent = this;
            //LH.Show();
        }

        private void mặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MatHang MH = new MatHang();
            //MH.MdiParent = this;
            //MH.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NhaCungCap NCC = new NhaCungCap();
            //NCC.MdiParent = this;
            //NCC.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string SDT = "";
            //DangNhap DN = new DangNhap(SDT);
            //DN.MdiParent = this;
            //DN.Show();
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
    }
}
