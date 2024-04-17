
namespace BTL_QuanLyBanThuoc
{
    partial class frmNVtheoChucVu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            this.tblNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyKhoThuocTayDataSet11 = new BTL_QuanLyBanThuoc.QuanLyKhoThuocTayDataSet1();
            this.tblNhanVienTableAdapter = new BTL_QuanLyBanThuoc.QuanLyKhoThuocTayDataSet1TableAdapters.tblNhanVienTableAdapter();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.sMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgayVaoLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXemChiTiet = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoThuocTayDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Items.AddRange(new object[] {
            "Nhân viên bán hàng",
            "Nhân viên nhập hàng",
            "Quản lý"});
            this.cbbChucVu.Location = new System.Drawing.Point(140, 32);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(305, 21);
            this.cbbChucVu.TabIndex = 0;
            this.cbbChucVu.SelectedIndexChanged += new System.EventHandler(this.cboGioiTinh_SelectedIndexChanged);
            // 
            // tblNhanVienBindingSource
            // 
            this.tblNhanVienBindingSource.DataMember = "tblNhanVien";
            this.tblNhanVienBindingSource.DataSource = this.quanLyKhoThuocTayDataSet11;
            // 
            // quanLyKhoThuocTayDataSet11
            // 
            this.quanLyKhoThuocTayDataSet11.DataSetName = "QuanLyKhoThuocTayDataSet1";
            this.quanLyKhoThuocTayDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblNhanVienTableAdapter
            // 
            this.tblNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.AutoGenerateColumns = false;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaNV,
            this.sTenNV,
            this.iGioiTinh,
            this.dNgaySinh,
            this.sChucVu,
            this.sDiaChi,
            this.dNgayVaoLam,
            this.sSDT,
            this.colXemChiTiet});
            this.dgvNhanVien.DataSource = this.tblNhanVienBindingSource;
            this.dgvNhanVien.Location = new System.Drawing.Point(140, 66);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(10);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.Size = new System.Drawing.Size(1085, 620);
            this.dgvNhanVien.TabIndex = 7;
            // 
            // sMaNV
            // 
            this.sMaNV.DataPropertyName = "sMaNV";
            this.sMaNV.HeaderText = "Mã nhân viên";
            this.sMaNV.Name = "sMaNV";
            this.sMaNV.ReadOnly = true;
            // 
            // sTenNV
            // 
            this.sTenNV.DataPropertyName = "sTenNV";
            this.sTenNV.HeaderText = "Tên nhân viên";
            this.sTenNV.Name = "sTenNV";
            this.sTenNV.ReadOnly = true;
            // 
            // iGioiTinh
            // 
            this.iGioiTinh.DataPropertyName = "iGioiTinh";
            this.iGioiTinh.HeaderText = "Giới tính";
            this.iGioiTinh.Name = "iGioiTinh";
            this.iGioiTinh.ReadOnly = true;
            // 
            // dNgaySinh
            // 
            this.dNgaySinh.DataPropertyName = "dNgaySinh";
            this.dNgaySinh.HeaderText = "Ngày sinh";
            this.dNgaySinh.Name = "dNgaySinh";
            this.dNgaySinh.ReadOnly = true;
            // 
            // sChucVu
            // 
            this.sChucVu.DataPropertyName = "sChucVu";
            this.sChucVu.HeaderText = "Chức vụ";
            this.sChucVu.Name = "sChucVu";
            this.sChucVu.ReadOnly = true;
            // 
            // sDiaChi
            // 
            this.sDiaChi.DataPropertyName = "sDiaChi";
            this.sDiaChi.HeaderText = "Địa chỉ";
            this.sDiaChi.Name = "sDiaChi";
            this.sDiaChi.ReadOnly = true;
            // 
            // dNgayVaoLam
            // 
            this.dNgayVaoLam.DataPropertyName = "dNgayVaoLam";
            this.dNgayVaoLam.HeaderText = "Ngày vào làm";
            this.dNgayVaoLam.Name = "dNgayVaoLam";
            this.dNgayVaoLam.ReadOnly = true;
            // 
            // sSDT
            // 
            this.sSDT.DataPropertyName = "sSDT";
            this.sSDT.HeaderText = "Số điện thoại";
            this.sSDT.Name = "sSDT";
            this.sSDT.ReadOnly = true;
            // 
            // colXemChiTiet
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.colXemChiTiet.DefaultCellStyle = dataGridViewCellStyle2;
            this.colXemChiTiet.HeaderText = "Xem nhân viên";
            this.colXemChiTiet.Name = "colXemChiTiet";
            this.colXemChiTiet.ReadOnly = true;
            this.colXemChiTiet.Text = "Xem chi tiết";
            this.colXemChiTiet.UseColumnTextForButtonValue = true;
            // 
            // frmNVtheoChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 691);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.cbbChucVu);
            this.Name = "frmNVtheoChucVu";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoThuocTayDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbChucVu;
        private System.Windows.Forms.BindingSource tblNhanVienBindingSource;
        private QuanLyKhoThuocTayDataSet1 quanLyKhoThuocTayDataSet11;
        private QuanLyKhoThuocTayDataSet1TableAdapters.tblNhanVienTableAdapter tblNhanVienTableAdapter;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgayVaoLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSDT;
        private System.Windows.Forms.DataGridViewButtonColumn colXemChiTiet;
    }
}