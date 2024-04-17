
namespace BTL_QuanLyBanThuoc
{
    partial class frmListNV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListNV));
            this.quanLyKhoThuocTayDataSet11 = new BTL_QuanLyBanThuoc.QuanLyKhoThuocTayDataSet1();
            this.lbNhanVienTitile = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnXoaHD = new System.Windows.Forms.Button();
            this.btnInHD = new System.Windows.Forms.Button();
            this.btnChucVu = new System.Windows.Forms.Button();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTimKiemNV = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tblNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblNhanVienTableAdapter = new BTL_QuanLyBanThuoc.QuanLyKhoThuocTayDataSet1TableAdapters.tblNhanVienTableAdapter();
            this.sMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgayVaoLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXemChiTiet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoThuocTayDataSet11)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // quanLyKhoThuocTayDataSet11
            // 
            this.quanLyKhoThuocTayDataSet11.DataSetName = "QuanLyKhoThuocTayDataSet1";
            this.quanLyKhoThuocTayDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbNhanVienTitile
            // 
            this.lbNhanVienTitile.AutoSize = true;
            this.lbNhanVienTitile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNhanVienTitile.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhanVienTitile.Location = new System.Drawing.Point(5, 5);
            this.lbNhanVienTitile.Margin = new System.Windows.Forms.Padding(5);
            this.lbNhanVienTitile.Name = "lbNhanVienTitile";
            this.lbNhanVienTitile.Size = new System.Drawing.Size(117, 22);
            this.lbNhanVienTitile.TabIndex = 0;
            this.lbNhanVienTitile.Text = "NHÂN VIÊN";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.lbNhanVienTitile, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 5);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.77778F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.77778F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.77778F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(127, 681);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dgvNhanVien, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(136, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.569343F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.43066F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1105, 685);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.5017F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.23891F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.06485F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.06485F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.06485F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.06485F));
            this.tableLayoutPanel2.Controls.Add(this.btnXoaHD, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnInHD, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnChucVu, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnThemHD, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1099, 39);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoaHD.Location = new System.Drawing.Point(547, 3);
            this.btnXoaHD.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(163, 33);
            this.btnXoaHD.TabIndex = 4;
            this.btnXoaHD.Text = "Xóa hóa đơn";
            this.btnXoaHD.UseVisualStyleBackColor = true;
            // 
            // btnInHD
            // 
            this.btnInHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInHD.Location = new System.Drawing.Point(734, 3);
            this.btnInHD.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(163, 33);
            this.btnInHD.TabIndex = 3;
            this.btnInHD.Text = "In hóa đơn";
            this.btnInHD.UseVisualStyleBackColor = true;
            // 
            // btnChucVu
            // 
            this.btnChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChucVu.Location = new System.Drawing.Point(921, 3);
            this.btnChucVu.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.btnChucVu.Name = "btnChucVu";
            this.btnChucVu.Size = new System.Drawing.Size(166, 33);
            this.btnChucVu.TabIndex = 2;
            this.btnChucVu.Text = "Nhân viên theo giới tính";
            this.btnChucVu.UseVisualStyleBackColor = true;
            this.btnChucVu.Click += new System.EventHandler(this.btnChucVu_Click);
            // 
            // btnThemHD
            // 
            this.btnThemHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThemHD.Location = new System.Drawing.Point(360, 3);
            this.btnThemHD.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(163, 33);
            this.btnThemHD.TabIndex = 1;
            this.btnThemHD.Text = "Thêm hóa đơn";
            this.btnThemHD.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel6.Controls.Add(this.txtTimKiemNV, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(200, 33);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // txtTimKiemNV
            // 
            this.txtTimKiemNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiemNV.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemNV.Location = new System.Drawing.Point(33, 3);
            this.txtTimKiemNV.Name = "txtTimKiemNV";
            this.txtTimKiemNV.Size = new System.Drawing.Size(134, 27);
            this.txtTimKiemNV.TabIndex = 0;
            this.txtTimKiemNV.TextChanged += new System.EventHandler(this.txtTimKiemNV_TextChanged);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(173, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
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
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(10, 55);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(10);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.Size = new System.Drawing.Size(1085, 620);
            this.dgvNhanVien.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.69132F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.30869F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1244, 691);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tblNhanVienBindingSource
            // 
            this.tblNhanVienBindingSource.DataMember = "tblNhanVien";
            this.tblNhanVienBindingSource.DataSource = this.quanLyKhoThuocTayDataSet11;
            // 
            // tblNhanVienTableAdapter
            // 
            this.tblNhanVienTableAdapter.ClearBeforeFill = true;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.colXemChiTiet.DefaultCellStyle = dataGridViewCellStyle1;
            this.colXemChiTiet.HeaderText = "Xem nhân viên";
            this.colXemChiTiet.Name = "colXemChiTiet";
            this.colXemChiTiet.ReadOnly = true;
            this.colXemChiTiet.Text = "Xem chi tiết";
            this.colXemChiTiet.UseColumnTextForButtonValue = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmListNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 691);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmListNV";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmListNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoThuocTayDataSet11)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QuanLyKhoThuocTayDataSet1 quanLyKhoThuocTayDataSet11;
        private System.Windows.Forms.Label lbNhanVienTitile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnXoaHD;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.Button btnChucVu;
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox txtTimKiemNV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource tblNhanVienBindingSource;
        private QuanLyKhoThuocTayDataSet1TableAdapters.tblNhanVienTableAdapter tblNhanVienTableAdapter;
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