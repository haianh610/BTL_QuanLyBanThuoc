
namespace BTL_QuanLyBanThuoc
{
    partial class frmQuanLyNhanVien
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
            this.lbMaNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbNgayVaoLam = new System.Windows.Forms.Label();
            this.cbxGioiTinh = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.quanLyKhoThuocTayDataSet11 = new BTL_QuanLyBanThuoc.QuanLyKhoThuocTayDataSet1();
            this.sMaNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sChucVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDiaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgayVaoLamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblNhanVienTableAdapter = new BTL_QuanLyBanThuoc.QuanLyKhoThuocTayDataSet1TableAdapters.tblNhanVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoThuocTayDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(22, 71);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(72, 13);
            this.lbMaNV.TabIndex = 0;
            this.lbMaNV.Text = "Mã nhân viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(119, 68);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 20);
            this.txtMaNV.TabIndex = 0;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(119, 113);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(100, 20);
            this.txtTenNV.TabIndex = 1;
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Location = new System.Drawing.Point(22, 116);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(76, 13);
            this.lbTenNV.TabIndex = 2;
            this.lbTenNV.Text = "Tên nhân viên";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Location = new System.Drawing.Point(22, 163);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(47, 13);
            this.lbGioiTinh.TabIndex = 4;
            this.lbGioiTinh.Text = "Giới tính";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Location = new System.Drawing.Point(22, 211);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(54, 13);
            this.lbNgaySinh.TabIndex = 6;
            this.lbNgaySinh.Text = "Ngày sinh";
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(119, 249);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(100, 20);
            this.txtChucVu.TabIndex = 4;
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Location = new System.Drawing.Point(22, 252);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(47, 13);
            this.lbChucVu.TabIndex = 8;
            this.lbChucVu.Text = "Chức vụ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(119, 290);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(200, 20);
            this.txtDiaChi.TabIndex = 5;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(22, 293);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(40, 13);
            this.lbDiaChi.TabIndex = 10;
            this.lbDiaChi.Text = "Địa chỉ";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(119, 333);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(130, 20);
            this.txtSDT.TabIndex = 6;
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(22, 336);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(70, 13);
            this.lbSDT.TabIndex = 12;
            this.lbSDT.Text = "Số điện thoại";
            // 
            // lbNgayVaoLam
            // 
            this.lbNgayVaoLam.AutoSize = true;
            this.lbNgayVaoLam.Location = new System.Drawing.Point(22, 379);
            this.lbNgayVaoLam.Name = "lbNgayVaoLam";
            this.lbNgayVaoLam.Size = new System.Drawing.Size(72, 13);
            this.lbNgayVaoLam.TabIndex = 14;
            this.lbNgayVaoLam.Text = "Ngày vào làm";
            // 
            // cbxGioiTinh
            // 
            this.cbxGioiTinh.FormattingEnabled = true;
            this.cbxGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbxGioiTinh.Location = new System.Drawing.Point(119, 163);
            this.cbxGioiTinh.Name = "cbxGioiTinh";
            this.cbxGioiTinh.Size = new System.Drawing.Size(121, 21);
            this.cbxGioiTinh.TabIndex = 2;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(119, 208);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtpNgaySinh.TabIndex = 3;
            // 
            // dtpNgayVaoLam
            // 
            this.dtpNgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayVaoLam.Location = new System.Drawing.Point(119, 379);
            this.dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            this.dtpNgayVaoLam.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayVaoLam.TabIndex = 7;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.AutoGenerateColumns = false;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaNVDataGridViewTextBoxColumn,
            this.sTenNVDataGridViewTextBoxColumn,
            this.iGioiTinhDataGridViewTextBoxColumn,
            this.dNgaySinhDataGridViewTextBoxColumn,
            this.sChucVuDataGridViewTextBoxColumn,
            this.sDiaChiDataGridViewTextBoxColumn,
            this.dNgayVaoLamDataGridViewTextBoxColumn,
            this.sSDTDataGridViewTextBoxColumn});
            this.dgvNhanVien.DataMember = "tblNhanVien";
            this.dgvNhanVien.DataSource = this.quanLyKhoThuocTayDataSet11;
            this.dgvNhanVien.Location = new System.Drawing.Point(25, 463);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.Size = new System.Drawing.Size(847, 397);
            this.dgvNhanVien.TabIndex = 19;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellContentClick);
            // 
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(377, 373);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(106, 37);
            this.btnThemNV.TabIndex = 20;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Location = new System.Drawing.Point(520, 373);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(106, 37);
            this.btnSuaNV.TabIndex = 9;
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.UseVisualStyleBackColor = true;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Location = new System.Drawing.Point(662, 373);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(106, 37);
            this.btnXoaNV.TabIndex = 10;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.UseVisualStyleBackColor = true;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(377, 310);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(106, 39);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // quanLyKhoThuocTayDataSet11
            // 
            this.quanLyKhoThuocTayDataSet11.DataSetName = "QuanLyKhoThuocTayDataSet1";
            this.quanLyKhoThuocTayDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sMaNVDataGridViewTextBoxColumn
            // 
            this.sMaNVDataGridViewTextBoxColumn.DataPropertyName = "sMaNV";
            this.sMaNVDataGridViewTextBoxColumn.HeaderText = "sMaNV";
            this.sMaNVDataGridViewTextBoxColumn.Name = "sMaNVDataGridViewTextBoxColumn";
            this.sMaNVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTenNVDataGridViewTextBoxColumn
            // 
            this.sTenNVDataGridViewTextBoxColumn.DataPropertyName = "sTenNV";
            this.sTenNVDataGridViewTextBoxColumn.HeaderText = "sTenNV";
            this.sTenNVDataGridViewTextBoxColumn.Name = "sTenNVDataGridViewTextBoxColumn";
            this.sTenNVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iGioiTinhDataGridViewTextBoxColumn
            // 
            this.iGioiTinhDataGridViewTextBoxColumn.DataPropertyName = "iGioiTinh";
            this.iGioiTinhDataGridViewTextBoxColumn.HeaderText = "iGioiTinh";
            this.iGioiTinhDataGridViewTextBoxColumn.Name = "iGioiTinhDataGridViewTextBoxColumn";
            this.iGioiTinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dNgaySinhDataGridViewTextBoxColumn
            // 
            this.dNgaySinhDataGridViewTextBoxColumn.DataPropertyName = "dNgaySinh";
            this.dNgaySinhDataGridViewTextBoxColumn.HeaderText = "dNgaySinh";
            this.dNgaySinhDataGridViewTextBoxColumn.Name = "dNgaySinhDataGridViewTextBoxColumn";
            this.dNgaySinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sChucVuDataGridViewTextBoxColumn
            // 
            this.sChucVuDataGridViewTextBoxColumn.DataPropertyName = "sChucVu";
            this.sChucVuDataGridViewTextBoxColumn.HeaderText = "sChucVu";
            this.sChucVuDataGridViewTextBoxColumn.Name = "sChucVuDataGridViewTextBoxColumn";
            this.sChucVuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sDiaChiDataGridViewTextBoxColumn
            // 
            this.sDiaChiDataGridViewTextBoxColumn.DataPropertyName = "sDiaChi";
            this.sDiaChiDataGridViewTextBoxColumn.HeaderText = "sDiaChi";
            this.sDiaChiDataGridViewTextBoxColumn.Name = "sDiaChiDataGridViewTextBoxColumn";
            this.sDiaChiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dNgayVaoLamDataGridViewTextBoxColumn
            // 
            this.dNgayVaoLamDataGridViewTextBoxColumn.DataPropertyName = "dNgayVaoLam";
            this.dNgayVaoLamDataGridViewTextBoxColumn.HeaderText = "dNgayVaoLam";
            this.dNgayVaoLamDataGridViewTextBoxColumn.Name = "dNgayVaoLamDataGridViewTextBoxColumn";
            this.dNgayVaoLamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sSDTDataGridViewTextBoxColumn
            // 
            this.sSDTDataGridViewTextBoxColumn.DataPropertyName = "sSDT";
            this.sSDTDataGridViewTextBoxColumn.HeaderText = "sSDT";
            this.sSDTDataGridViewTextBoxColumn.Name = "sSDTDataGridViewTextBoxColumn";
            this.sSDTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblNhanVienTableAdapter
            // 
            this.tblNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // frmQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 903);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoaNV);
            this.Controls.Add(this.btnSuaNV);
            this.Controls.Add(this.btnThemNV);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.dtpNgayVaoLam);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.cbxGioiTinh);
            this.Controls.Add(this.lbNgayVaoLam);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.lbSDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.txtChucVu);
            this.Controls.Add(this.lbChucVu);
            this.Controls.Add(this.lbNgaySinh);
            this.Controls.Add(this.lbGioiTinh);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.lbTenNV);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.lbMaNV);
            this.Name = "frmQuanLyNhanVien";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.frmQuanLyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoThuocTayDataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbNgayVaoLam;
        private System.Windows.Forms.ComboBox cbxGioiTinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgayVaoLam;
        private  System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn bGioiTinhDataGridViewCheckBoxColumn;
        public System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sChucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgayVaoLamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSDTDataGridViewTextBoxColumn;
        private QuanLyKhoThuocTayDataSet1 quanLyKhoThuocTayDataSet11;
        private QuanLyKhoThuocTayDataSet1TableAdapters.tblNhanVienTableAdapter tblNhanVienTableAdapter;
    }
}