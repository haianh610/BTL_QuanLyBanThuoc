using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_QuanLyBanThuoc.Code;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;


namespace BTL_QuanLyBanThuoc
{
    public partial class DanhSachPN : Form
    {
        public DanhSachPN()
        {
            InitializeComponent();
        }

        private void DanhSachPN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhoThuocTayDataSet8.tblPhieuNhap' table. You can move, or remove it, as needed.
            this.tblPhieuNhapTableAdapter6.Fill(this.quanLyKhoThuocTayDataSet8.tblPhieuNhap);
            tblPhieuNhapTableAdapter6.Adapter.SelectCommand.CommandText = "SELECT * FROM tblPhieuNhap WHERE iTrangThai != 2";
        }
        private void frmChiTietPhieuNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgvPhieuNhap.DataSource = PhieuNhap.locPhieuNhap(cbPhieuTam.Checked, cbHoanThanh.Checked, cbDaHuy.Checked, rbThangNay.Checked, txtTimKiem.Text, rbKhoangThoiGian.Checked, dtpTu.Value, dtpDen.Value);
        }

        private void dgvPhieuNhap_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvPhieuNhap.Columns[e.ColumnIndex].Name == "iTrangThai")
            {
                if (e.Value != null)
                {
                    int trangThai = int.Parse(e.Value.ToString());
                    if (trangThai == 1)
                    {
                        e.Value = "Hoàn thành";
                    }
                    else if (trangThai == 0)
                    {
                        e.Value = "Phiếu tạm";
                    }
                    else if (trangThai == 2)
                    {
                        e.Value = "Đã hủy";
                    }
                    e.FormattingApplied = true;
                }
            }
        }


        private void btnThemPN_Click_1(object sender, EventArgs e)
        {
            PhieuNhap hd = new PhieuNhap();
            //Về sau thay "NV001" dựa vào tài khoản đăng nhập
            bool success = PhieuNhap.themPN(dbConnect.ConnectionString, "BH01", out hd);
            if (success)
            {
                ChiTietPhieuNhap frm = new ChiTietPhieuNhap(hd);
                //MessageBox.Show(hd.sMaHD);
                //frm.txtMaHD.ReadOnly = true;
                this.tblPhieuNhapTableAdapter6.Fill(this.quanLyKhoThuocTayDataSet8.tblPhieuNhap);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Lỗi tạo Phiếu: ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaPN_Click_1(object sender, EventArgs e)
        {
            PhieuNhap.huyPN(dbConnect.ConnectionString, dgvPhieuNhap.CurrentRow.Cells["sMaPN"].Value.ToString());
            if (cbPhieuTam.Checked || cbHoanThanh.Checked || cbDaHuy.Checked)
                dgvPhieuNhap.DataSource = PhieuNhap.locPhieuNhap(cbPhieuTam.Checked, cbHoanThanh.Checked, cbDaHuy.Checked, rbThangNay.Checked, txtTimKiem.Text, rbKhoangThoiGian.Checked, dtpTu.Value, dtpDen.Value);
            else
                this.tblPhieuNhapTableAdapter6.Fill(this.quanLyKhoThuocTayDataSet8.tblPhieuNhap); 
        }

        private void cbPhieuTam_CheckedChanged_1(object sender, EventArgs e)
        {
            dgvPhieuNhap.DataSource = PhieuNhap.locPhieuNhap(cbPhieuTam.Checked, cbHoanThanh.Checked, cbDaHuy.Checked, rbThangNay.Checked, txtTimKiem.Text, rbKhoangThoiGian.Checked, dtpTu.Value, dtpDen.Value);
        }

        private void cbHoanThanh_CheckedChanged_1(object sender, EventArgs e)
        {
            dgvPhieuNhap.DataSource = PhieuNhap.locPhieuNhap(cbPhieuTam.Checked, cbHoanThanh.Checked, cbDaHuy.Checked, rbThangNay.Checked, txtTimKiem.Text, rbKhoangThoiGian.Checked, dtpTu.Value, dtpDen.Value);
        }

        private void cbDaHuy_CheckedChanged_1(object sender, EventArgs e)
        {
            dgvPhieuNhap.DataSource = PhieuNhap.locPhieuNhap(cbPhieuTam.Checked, cbHoanThanh.Checked, cbDaHuy.Checked, rbThangNay.Checked, txtTimKiem.Text, rbKhoangThoiGian.Checked, dtpTu.Value, dtpDen.Value);
        }
        private void dgvPhieuNhap_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPhieuNhap.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                if (dgvPhieuNhap.Columns[e.ColumnIndex].Name == "ColXemChiTiet")
                {
                    PhieuNhap selectedPhieuNhap = PhieuNhap.GetPN(dbConnect.ConnectionString, dgvPhieuNhap.CurrentRow.Cells["sMaPN"].Value.ToString());
                    if (selectedPhieuNhap.iTrangThai == 0)
                    {
                        ChiTietPhieuNhap frm = new ChiTietPhieuNhap(selectedPhieuNhap);
                        frm.FormClosed += frmChiTietPhieuNhap_FormClosed;
                        frm.ShowDialog();
                    }
                    else
                    {
                        ThongTinPN f2 = new ThongTinPN(selectedPhieuNhap);
                        f2.MdiParent = this.MdiParent;
                        f2.Show();
                    }
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.TextLength > 1)
            {
                dgvPhieuNhap.DataSource = PhieuNhap.locPhieuNhap(cbPhieuTam.Checked, cbHoanThanh.Checked, cbDaHuy.Checked, rbThangNay.Checked, txtTimKiem.Text, rbKhoangThoiGian.Checked, dtpTu.Value, dtpDen.Value);
            }
            if (txtTimKiem.TextLength == 0 || txtTimKiem.Text == "Tìm kiếm phiếu nhập theo mã phiếu nhập")
            {
                dgvPhieuNhap.DataSource = PhieuNhap.locPhieuNhap(cbPhieuTam.Checked, cbHoanThanh.Checked, cbDaHuy.Checked, rbThangNay.Checked, txtTimKiem.Text, rbKhoangThoiGian.Checked, dtpTu.Value, dtpDen.Value);
            }
        }

        private void rbToanThoiGian_CheckedChanged(object sender, EventArgs e)
        {
            dgvPhieuNhap.DataSource = PhieuNhap.locPhieuNhap(cbPhieuTam.Checked, cbHoanThanh.Checked, cbDaHuy.Checked, rbThangNay.Checked, txtTimKiem.Text, rbKhoangThoiGian.Checked, dtpTu.Value, dtpDen.Value);
        }

        private void rbThangNay_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThangNay.Checked)
            {
                dgvPhieuNhap.DataSource = PhieuNhap.locPhieuNhap(cbPhieuTam.Checked, cbHoanThanh.Checked, cbDaHuy.Checked, rbThangNay.Checked, txtTimKiem.Text, rbKhoangThoiGian.Checked, dtpTu.Value, dtpDen.Value);
            }
        }

        private void dtpTu_ValueChanged(object sender, EventArgs e)
        {
            dgvPhieuNhap.DataSource = PhieuNhap.locPhieuNhap(cbPhieuTam.Checked, cbHoanThanh.Checked, cbDaHuy.Checked, rbThangNay.Checked, txtTimKiem.Text, rbKhoangThoiGian.Checked, dtpTu.Value, dtpDen.Value);
        }

        private void dtpDen_ValueChanged(object sender, EventArgs e)
        {
            dgvPhieuNhap.DataSource = PhieuNhap.locPhieuNhap(cbPhieuTam.Checked, cbHoanThanh.Checked, cbDaHuy.Checked, rbThangNay.Checked, txtTimKiem.Text, rbKhoangThoiGian.Checked, dtpTu.Value, dtpDen.Value);
        }

        private void rbKhoangThoiGian_CheckedChanged(object sender, EventArgs e)
        {
            dgvPhieuNhap.DataSource = PhieuNhap.locPhieuNhap(cbPhieuTam.Checked, cbHoanThanh.Checked, cbDaHuy.Checked, rbThangNay.Checked, txtTimKiem.Text, rbKhoangThoiGian.Checked, dtpTu.Value, dtpDen.Value);
        }

        private void btnInPN_Click(object sender, EventArgs e)
        {
            FormInBaoCao frm = new FormInBaoCao(dgvPhieuNhap.CurrentRow.Cells["sMaPN"].Value.ToString());
            frm.Show();
        }
    }
}