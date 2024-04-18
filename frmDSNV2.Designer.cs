
namespace BTL_QuanLyBanThuoc
{
    partial class frmDSNV2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSNV2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.tblNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyKhoThuocTayDataSet11 = new BTL_QuanLyBanThuoc.QuanLyKhoThuocTayDataSet1();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbTrangThai = new System.Windows.Forms.GroupBox();
            this.cbDaThoiViec = new System.Windows.Forms.CheckBox();
            this.cbDangLamViec = new System.Windows.Forms.CheckBox();
            this.gbThoiGian = new System.Windows.Forms.GroupBox();
            this.lbDen = new System.Windows.Forms.Label();
            this.lbTu = new System.Windows.Forms.Label();
            this.dtpDen = new System.Windows.Forms.DateTimePicker();
            this.dtpTu = new System.Windows.Forms.DateTimePicker();
            this.rbKhoangThoiGian = new System.Windows.Forms.RadioButton();
            this.rbToanThoiGian = new System.Windows.Forms.RadioButton();
            this.rbThangNay = new System.Windows.Forms.RadioButton();
            this.lbHoaDonTitle = new System.Windows.Forms.Label();
            this.tblNhanVienTableAdapter1 = new BTL_QuanLyBanThuoc.QuanLyKhoThuocTayDataSet1TableAdapters.tblNhanVienTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXemChiTiet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoThuocTayDataSet11)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbTrangThai.SuspendLayout();
            this.gbThoiGian.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 223F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1359, 767);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.dgvNhanVien, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(226, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1130, 761);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.AutoGenerateColumns = false;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Inter", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaNV,
            this.sTenNV,
            this.iGioiTinh,
            this.dNgaySinh,
            this.sChucVu,
            this.sDiaChi,
            this.iTrangThai,
            this.colXemChiTiet});
            this.dgvNhanVien.DataSource = this.tblNhanVienBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(20, 59);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.Size = new System.Drawing.Size(1090, 692);
            this.dgvNhanVien.TabIndex = 6;
            this.dgvNhanVien.DataSourceChanged += new System.EventHandler(this.dgvHoaDon_DataSourceChanged);
            this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellContentClick);
            this.dgvNhanVien.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvHoaDon_CellFormatting);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnCapNhat);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.panel2.Size = new System.Drawing.Size(1124, 43);
            this.panel2.TabIndex = 11;
            // 
            // btnThem
            // 
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(678, 0);
            this.btnThem.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(132, 43);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm nhân viên";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThemHD_Click_1);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(810, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 43);
            this.panel3.TabIndex = 7;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(825, 0);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(132, 43);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập nhật nhân viên";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(957, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 43);
            this.panel4.TabIndex = 8;
            // 
            // btnHuy
            // 
            this.btnHuy.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(972, 0);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(132, 43);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "nghỉ nhân viên";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnXoaHD_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.DimGray;
            this.txtTimKiem.Location = new System.Drawing.Point(41, 9);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(280, 27);
            this.txtTimKiem.TabIndex = 3;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbTrangThai);
            this.panel1.Controls.Add(this.gbThoiGian);
            this.panel1.Controls.Add(this.lbHoaDonTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 761);
            this.panel1.TabIndex = 7;
            // 
            // gbTrangThai
            // 
            this.gbTrangThai.BackColor = System.Drawing.SystemColors.Control;
            this.gbTrangThai.Controls.Add(this.cbDaThoiViec);
            this.gbTrangThai.Controls.Add(this.cbDangLamViec);
            this.gbTrangThai.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTrangThai.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTrangThai.Location = new System.Drawing.Point(0, 247);
            this.gbTrangThai.Name = "gbTrangThai";
            this.gbTrangThai.Padding = new System.Windows.Forms.Padding(5);
            this.gbTrangThai.Size = new System.Drawing.Size(217, 130);
            this.gbTrangThai.TabIndex = 3;
            this.gbTrangThai.TabStop = false;
            this.gbTrangThai.Text = "Trạng thái";
            // 
            // cbDaThoiViec
            // 
            this.cbDaThoiViec.AutoSize = true;
            this.cbDaThoiViec.Location = new System.Drawing.Point(22, 72);
            this.cbDaThoiViec.Name = "cbDaThoiViec";
            this.cbDaThoiViec.Size = new System.Drawing.Size(111, 23);
            this.cbDaThoiViec.TabIndex = 0;
            this.cbDaThoiViec.Text = "Đã thôi việc";
            this.cbDaThoiViec.UseVisualStyleBackColor = true;
            this.cbDaThoiViec.CheckedChanged += new System.EventHandler(this.cbDaThoiViec_CheckedChanged);
            // 
            // cbDangLamViec
            // 
            this.cbDangLamViec.AutoSize = true;
            this.cbDangLamViec.Location = new System.Drawing.Point(22, 35);
            this.cbDangLamViec.Name = "cbDangLamViec";
            this.cbDangLamViec.Size = new System.Drawing.Size(127, 23);
            this.cbDangLamViec.TabIndex = 0;
            this.cbDangLamViec.Text = "Đang làm việc";
            this.cbDangLamViec.UseVisualStyleBackColor = true;
            this.cbDangLamViec.CheckedChanged += new System.EventHandler(this.cbDangLamViec_CheckedChanged);
            // 
            // gbThoiGian
            // 
            this.gbThoiGian.Controls.Add(this.lbDen);
            this.gbThoiGian.Controls.Add(this.lbTu);
            this.gbThoiGian.Controls.Add(this.dtpDen);
            this.gbThoiGian.Controls.Add(this.dtpTu);
            this.gbThoiGian.Controls.Add(this.rbKhoangThoiGian);
            this.gbThoiGian.Controls.Add(this.rbToanThoiGian);
            this.gbThoiGian.Controls.Add(this.rbThangNay);
            this.gbThoiGian.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbThoiGian.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThoiGian.Location = new System.Drawing.Point(0, 51);
            this.gbThoiGian.Name = "gbThoiGian";
            this.gbThoiGian.Padding = new System.Windows.Forms.Padding(10);
            this.gbThoiGian.Size = new System.Drawing.Size(217, 196);
            this.gbThoiGian.TabIndex = 2;
            this.gbThoiGian.TabStop = false;
            this.gbThoiGian.Text = "Ngày vào làm";
            // 
            // lbDen
            // 
            this.lbDen.AutoSize = true;
            this.lbDen.Font = new System.Drawing.Font("Inter", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDen.Location = new System.Drawing.Point(26, 161);
            this.lbDen.Name = "lbDen";
            this.lbDen.Size = new System.Drawing.Size(33, 16);
            this.lbDen.TabIndex = 2;
            this.lbDen.Text = "Đến";
            // 
            // lbTu
            // 
            this.lbTu.AutoSize = true;
            this.lbTu.Font = new System.Drawing.Font("Inter", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTu.Location = new System.Drawing.Point(26, 128);
            this.lbTu.Name = "lbTu";
            this.lbTu.Size = new System.Drawing.Size(23, 16);
            this.lbTu.TabIndex = 2;
            this.lbTu.Text = "Từ";
            // 
            // dtpDen
            // 
            this.dtpDen.CustomFormat = "dd/MM/yyyy";
            this.dtpDen.Font = new System.Drawing.Font("Inter", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDen.Location = new System.Drawing.Point(62, 158);
            this.dtpDen.Name = "dtpDen";
            this.dtpDen.Size = new System.Drawing.Size(124, 23);
            this.dtpDen.TabIndex = 1;
            this.dtpDen.Value = new System.DateTime(2024, 4, 16, 0, 0, 0, 0);
            this.dtpDen.ValueChanged += new System.EventHandler(this.dtpDen_ValueChanged);
            // 
            // dtpTu
            // 
            this.dtpTu.CustomFormat = "dd/MM/yyyy";
            this.dtpTu.Font = new System.Drawing.Font("Inter", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTu.Location = new System.Drawing.Point(62, 125);
            this.dtpTu.Name = "dtpTu";
            this.dtpTu.Size = new System.Drawing.Size(124, 23);
            this.dtpTu.TabIndex = 1;
            this.dtpTu.Value = new System.DateTime(2024, 4, 16, 0, 0, 0, 0);
            this.dtpTu.ValueChanged += new System.EventHandler(this.dtpTu_ValueChanged);
            // 
            // rbKhoangThoiGian
            // 
            this.rbKhoangThoiGian.AutoSize = true;
            this.rbKhoangThoiGian.Location = new System.Drawing.Point(11, 94);
            this.rbKhoangThoiGian.Name = "rbKhoangThoiGian";
            this.rbKhoangThoiGian.Size = new System.Drawing.Size(146, 23);
            this.rbKhoangThoiGian.TabIndex = 0;
            this.rbKhoangThoiGian.Text = "Khoảng thời gian";
            this.rbKhoangThoiGian.UseVisualStyleBackColor = true;
            this.rbKhoangThoiGian.CheckedChanged += new System.EventHandler(this.rbKhoangThoiGian_CheckedChanged);
            // 
            // rbToanThoiGian
            // 
            this.rbToanThoiGian.AutoSize = true;
            this.rbToanThoiGian.Checked = true;
            this.rbToanThoiGian.Location = new System.Drawing.Point(11, 36);
            this.rbToanThoiGian.Name = "rbToanThoiGian";
            this.rbToanThoiGian.Size = new System.Drawing.Size(127, 23);
            this.rbToanThoiGian.TabIndex = 0;
            this.rbToanThoiGian.TabStop = true;
            this.rbToanThoiGian.Text = "Toàn thời gian";
            this.rbToanThoiGian.UseVisualStyleBackColor = true;
            this.rbToanThoiGian.CheckedChanged += new System.EventHandler(this.rbToanThoiGian_CheckedChanged);
            // 
            // rbThangNay
            // 
            this.rbThangNay.AutoSize = true;
            this.rbThangNay.Location = new System.Drawing.Point(11, 65);
            this.rbThangNay.Name = "rbThangNay";
            this.rbThangNay.Size = new System.Drawing.Size(101, 23);
            this.rbThangNay.TabIndex = 0;
            this.rbThangNay.Text = "Tháng này";
            this.rbThangNay.UseVisualStyleBackColor = true;
            this.rbThangNay.CheckedChanged += new System.EventHandler(this.rbThangNay_CheckedChanged);
            // 
            // lbHoaDonTitle
            // 
            this.lbHoaDonTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbHoaDonTitle.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoaDonTitle.Location = new System.Drawing.Point(0, 0);
            this.lbHoaDonTitle.Margin = new System.Windows.Forms.Padding(5);
            this.lbHoaDonTitle.Name = "lbHoaDonTitle";
            this.lbHoaDonTitle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lbHoaDonTitle.Size = new System.Drawing.Size(217, 51);
            this.lbHoaDonTitle.TabIndex = 1;
            this.lbHoaDonTitle.Text = "NHÂN VIÊN";
            this.lbHoaDonTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tblNhanVienTableAdapter1
            // 
            this.tblNhanVienTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
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
            // iTrangThai
            // 
            this.iTrangThai.DataPropertyName = "iTrangThai";
            this.iTrangThai.HeaderText = "Trạng thái";
            this.iTrangThai.Name = "iTrangThai";
            this.iTrangThai.ReadOnly = true;
            // 
            // colXemChiTiet
            // 
            this.colXemChiTiet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.colXemChiTiet.DefaultCellStyle = dataGridViewCellStyle2;
            this.colXemChiTiet.HeaderText = "Xem nhân viên";
            this.colXemChiTiet.Name = "colXemChiTiet";
            this.colXemChiTiet.ReadOnly = true;
            this.colXemChiTiet.Text = "Xem";
            this.colXemChiTiet.UseColumnTextForButtonValue = true;
            this.colXemChiTiet.Width = 72;
            // 
            // frmDSNV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 787);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmDSNV2";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách hóa đơn";
            this.Load += new System.EventHandler(this.frmListHoaDon_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoThuocTayDataSet11)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gbTrangThai.ResumeLayout(false);
            this.gbTrangThai.PerformLayout();
            this.gbThoiGian.ResumeLayout(false);
            this.gbThoiGian.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnHuy;
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
        private System.Windows.Forms.Label lbDen;
        private System.Windows.Forms.Label lbTu;
        private System.Windows.Forms.BindingSource tblNhanVienBindingSource;
        private System.Windows.Forms.GroupBox gbTrangThai;
        private System.Windows.Forms.CheckBox cbDaThoiViec;
        private System.Windows.Forms.CheckBox cbDangLamViec;
        private QuanLyKhoThuocTayDataSet1TableAdapters.tblNhanVienTableAdapter tblNhanVienTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTrangThai;
        private System.Windows.Forms.DataGridViewButtonColumn colXemChiTiet;
    }
}