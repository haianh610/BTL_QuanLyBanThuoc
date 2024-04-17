
namespace BTL_QuanLyBanThuoc
{
    partial class frmDSNV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDSNV
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "frmDSNV";
            this.Load += new System.EventHandler(this.frmListHoaDon_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private QuanLyKhoThuocTayDataSet1 quanLyKhoThuocTayDataSet11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbHoaDonTitle;
        private System.Windows.Forms.GroupBox gbThoiGian;
        private System.Windows.Forms.GroupBox gbTrangThai;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtpTu;
        private System.Windows.Forms.RadioButton rbKhoangThoiGian;
        private System.Windows.Forms.RadioButton rbThangNay;
        private System.Windows.Forms.DateTimePicker dtpDen;
        private System.Windows.Forms.RadioButton rbToanThoiGian;
        private System.Windows.Forms.BindingSource tblNhanVienBindingSource;
        private QuanLyKhoThuocTayDataSet1TableAdapters.tblNhanVienTableAdapter tblNhanVienTableAdapter1;
        private System.Windows.Forms.CheckBox cbDaThoiViec;
        private System.Windows.Forms.CheckBox cbDangLamViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sChucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgayVaoLamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTrangThai;
        private System.Windows.Forms.DataGridViewButtonColumn colXemChiTiet;
    }
}