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
    public partial class frmDSNV : Form
    {
        public frmDSNV()
        {
            InitializeComponent();
        }

        private void frmListHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhoThuocTayDataSet11.tblHoaDon' table. You can move, or remove it, as needed.
            this.tblNhanVienTableAdapter1.Fill(this.quanLyKhoThuocTayDataSet11.tblNhanVien);
            tblNhanVienTableAdapter1.Adapter.SelectCommand.CommandText = "SELECT * FROM tblNhanVien WHERE iTrangThai != 2";
            this.tblNhanVienTableAdapter1.Fill(this.quanLyKhoThuocTayDataSet11.tblNhanVien);
            this.dgvNhanVien.Sort(dgvNhanVien.Columns[0], ListSortDirection.Descending);
        }




        private void btnThemHD_Click_1(object sender, EventArgs e)
        {
            frmThemNV frm = new frmThemNV();
            frm.FormClosed += frmThemNV_Closed;
            frm.Show();
        }

        private void frmThemNV_Closed(object sender, FormClosedEventArgs e)
        {
            if (cbDangLamViec.Checked || cbDaThoiViec.Checked)
                dgvNhanVien.DataSource = tblNhanVienBindingSource;
            else
                this.tblNhanVienTableAdapter1.Fill(this.quanLyKhoThuocTayDataSet11.tblNhanVien);
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            NhanVien.xoaNV(dbConnect.ConnectionString, dgvNhanVien.CurrentRow.Cells["sMaNV"].Value.ToString());
            if (cbDangLamViec.Checked || cbDaThoiViec.Checked)
                dgvNhanVien.DataSource = tblNhanVienBindingSource;
            else
                this.tblNhanVienTableAdapter1.Fill(this.quanLyKhoThuocTayDataSet11.tblNhanVien);
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhanVien.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                if (dgvNhanVien.Columns[e.ColumnIndex].Name == "colXemChiTiet")
                {
                    
                    HoaDon selectedHoaDon = HoaDon.GetHoaDon(dbConnect.ConnectionString, dgvNhanVien.CurrentRow.Cells["sMaHD"].Value.ToString());
                    if(selectedHoaDon.iTrangThai == 0)
                    {
                        frmBanHang frm = new frmBanHang(selectedHoaDon);
                        frm.FormClosed += frmBanHang_FormClosed;
                        frm.ShowDialog();
                    }
                    else
                    {
                        chinhHD f2 = new chinhHD(selectedHoaDon);
                        f2.MdiParent = this.MdiParent;
                        f2.Show();
                    }
                }
            }
        }

        private void frmBanHang_FormClosed(object sender, FormClosedEventArgs e)
        {
             dgvNhanVien.DataSource = NhanVien.locNhanVien(cbDangLamViec.Checked, cbDaThoiViec.Checked, rbThangNay.Checked, txtTimKiem.Text, rbKhoangThoiGian.Checked, dtpTu.Value, dtpDen.Value);
        }

        private void dgvHoaDon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvNhanVien.Columns[e.ColumnIndex].Name == "iTrangThai")
            {
                if (e.Value != null)
                {
                    int trangThai = int.Parse(e.Value.ToString());
                    if (trangThai == 1)
                    {
                        e.Value = "Đang làm việc";
                    }else if(trangThai == 2)
                    {
                        e.Value = "Đã thôi việc";
                    }
                    e.FormattingApplied = true;
                }
            }

            if (this.dgvNhanVien.Columns[e.ColumnIndex].Name == "iGioiTinh")
            {
                if (e.Value != null)
                {
                    int gioiTinh = int.Parse(e.Value.ToString());
                    if (gioiTinh == 0)
                    {
                        e.Value = "Nam";
                    }
                    else if (gioiTinh == 1)
                    {
                        e.Value = "Nữ";
                    }
                    e.FormattingApplied = true;
                }
            }
        }


        private void dgvHoaDon_DataSourceChanged(object sender, EventArgs e)
        {
            if(dgvNhanVien.RowCount>0)
                this.dgvNhanVien.Sort(dgvNhanVien.Columns[0], ListSortDirection.Descending);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.TextLength > 1)
            {
                dgvNhanVien.DataSource = NhanVien.locNhanVien(cbDangLamViec.Checked, cbDaThoiViec.Checked, rbThangNay.Checked, txtTimKiem.Text, rbKhoangThoiGian.Checked, dtpTu.Value, dtpDen.Value);
            }
            if (txtTimKiem.TextLength == 0)
            {
                dgvNhanVien.DataSource = NhanVien.locNhanVien(cbDangLamViec.Checked,cbDaThoiViec.Checked,rbThangNay.Checked,txtTimKiem.Text,rbKhoangThoiGian.Checked,dtpTu.Value,dtpDen.Value);
            }
        }

        private void rbToanThoiGian_CheckedChanged(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = NhanVien.locNhanVien(cbDangLamViec.Checked, cbDaThoiViec.Checked, rbThangNay.Checked, txtTimKiem.Text, rbKhoangThoiGian.Checked, dtpTu.Value, dtpDen.Value);
        }

        private void rbThangNay_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThangNay.Checked)
            {
                dgvNhanVien.DataSource = NhanVien.locNhanVien(cbDangLamViec.Checked, cbDaThoiViec.Checked, rbThangNay.Checked, txtTimKiem.Text, rbKhoangThoiGian.Checked, dtpTu.Value, dtpDen.Value);
            }

        }

        private void cbDangLamViec_CheckedChanged(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = NhanVien.locNhanVien(cbDangLamViec.Checked, cbDaThoiViec.Checked, rbThangNay.Checked, txtTimKiem.Text, rbKhoangThoiGian.Checked, dtpTu.Value, dtpDen.Value);
        }

        private void cbDaThoiViec_CheckedChanged(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = NhanVien.locNhanVien(cbDangLamViec.Checked, cbDaThoiViec.Checked, rbThangNay.Checked, txtTimKiem.Text, rbKhoangThoiGian.Checked, dtpTu.Value, dtpDen.Value);
        }
    }
}
