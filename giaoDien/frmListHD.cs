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
    public partial class frmListHoaDon : Form
    {
        public frmListHoaDon()
        {
            InitializeComponent();
        }

        private void frmListHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhoThuocTayDataSet11.tblHoaDon' table. You can move, or remove it, as needed.
            this.tblHoaDonTableAdapter.Fill(this.quanLyKhoThuocTayDataSet11.tblHoaDon);
            this.tblHoaDonTableAdapter.Fill(this.quanLyKhoThuocTayDataSet11.tblHoaDon);
        }




        private void btnThemHD_Click_1(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            //Về sau thay "NV001" dựa vào tài khoản đăng nhập
            bool success = HoaDon.themHD(dbConnect.ConnectionString, "BH01", out hd); 
            if (success)
            {
                frmBanHang frm = new frmBanHang(hd);
                //MessageBox.Show(hd.sMaHD);
                //frm.txtMaHD.ReadOnly = true;
                this.tblHoaDonTableAdapter.Fill(this.quanLyKhoThuocTayDataSet11.tblHoaDon);
                frm.FormClosed += frmChiTietHoaDon_FormClosed;
                frm.Show();
            }
            else
            {
                MessageBox.Show("lỗi tạo đơn");
            }
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            HoaDon.xoaHD(dbConnect.ConnectionString, dgvHoaDon.CurrentRow.Cells["sMaHD"].Value.ToString());
            this.tblHoaDonTableAdapter.Fill(this.quanLyKhoThuocTayDataSet11.tblHoaDon);
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHoaDon.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                if (dgvHoaDon.Columns[e.ColumnIndex].Name == "colXemChiTiet")
                {
                    
                    HoaDon selectedHoaDon = HoaDon.GetHoaDon(dbConnect.ConnectionString, dgvHoaDon.CurrentRow.Cells["sMaHD"].Value.ToString());
                    if(selectedHoaDon.iTrangThai == 0)
                    {
                        frmBanHang frm = new frmBanHang(selectedHoaDon);
                        frm.FormClosed += frmChiTietHoaDon_FormClosed;
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

        private void frmChiTietHoaDon_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.tblHoaDonTableAdapter.Fill(this.quanLyKhoThuocTayDataSet11.tblHoaDon);
        }

        private void dgvHoaDon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvHoaDon.Columns[e.ColumnIndex].Name == "iTrangThai")
            {
                if (e.Value != null)
                {
                    int trangThai = int.Parse(e.Value.ToString());
                    if (trangThai == 1)
                    {
                        e.Value = "Hoàn thành";
                    }
                    else if(trangThai == 0)
                    {
                        e.Value = "Phiếu tạm";
                    }else if(trangThai == 3)
                    {
                        e.Value = "Đã hủy";
                    }
                    e.FormattingApplied = true;
                }
            }
        }

        private void cbPhieuTam_CheckedChanged(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = HoaDon.locTrangThaiHoaDon(cbPhieuTam.Checked, cbHoanThanh.Checked, cbDaHuy.Checked,radioButton1.Checked);
        }

        private void cbHoanThanh_CheckedChanged(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = HoaDon.locTrangThaiHoaDon(cbPhieuTam.Checked, cbHoanThanh.Checked, cbDaHuy.Checked,radioButton1.Checked);
        }

        private void cbDaHuy_CheckedChanged(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = HoaDon.locTrangThaiHoaDon(cbPhieuTam.Checked, cbHoanThanh.Checked, cbDaHuy.Checked, radioButton1.Checked);
        }

        private void dgvHoaDon_DataSourceChanged(object sender, EventArgs e)
        {
            this.dgvHoaDon.Sort(dgvHoaDon.Columns[0], ListSortDirection.Descending);
        }
    }
}
