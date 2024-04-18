
namespace BTL_QuanLyBanThuoc
{
    partial class frmListHoaDon2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListHoaDon2));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.sMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgayLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fTongTienHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXemChiTiet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tblHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyKhoThuocTayDataSet11 = new BTL_QuanLyBanThuoc.QuanLyKhoThuocTayDataSet1();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnIn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbTrangThai = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbHoanThanh = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPhieuTam = new System.Windows.Forms.CheckBox();
            this.cbDaHuy = new System.Windows.Forms.CheckBox();
            this.gbThoiGian = new System.Windows.Forms.GroupBox();
            this.lbDen = new System.Windows.Forms.Label();
            this.lbTu = new System.Windows.Forms.Label();
            this.dtpDen = new System.Windows.Forms.DateTimePicker();
            this.dtpTu = new System.Windows.Forms.DateTimePicker();
            this.rbKhoangThoiGian = new System.Windows.Forms.RadioButton();
            this.rbToanThoiGian = new System.Windows.Forms.RadioButton();
            this.rbThangNay = new System.Windows.Forms.RadioButton();
            this.lbHoaDonTitle = new System.Windows.Forms.Label();
            this.tblHoaDonTableAdapter = new BTL_QuanLyBanThuoc.QuanLyKhoThuocTayDataSet1TableAdapters.tblHoaDonTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoThuocTayDataSet11)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbTrangThai.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.gbThoiGian.SuspendLayout();
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
            this.tableLayoutPanel3.Controls.Add(this.dgvHoaDon, 0, 1);
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
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.AutoGenerateColumns = false;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Inter", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaHD,
            this.dNgayLapDataGridViewTextBoxColumn,
            this.sMaNVDataGridViewTextBoxColumn,
            this.sMaKHDataGridViewTextBoxColumn,
            this.fTongTienHDDataGridViewTextBoxColumn,
            this.iTrangThai,
            this.colXemChiTiet});
            this.dgvHoaDon.DataSource = this.tblHoaDonBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.Location = new System.Drawing.Point(20, 59);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.Size = new System.Drawing.Size(1090, 692);
            this.dgvHoaDon.TabIndex = 6;
            this.dgvHoaDon.DataSourceChanged += new System.EventHandler(this.dgvHoaDon_DataSourceChanged);
            this.dgvHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellContentClick);
            this.dgvHoaDon.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvHoaDon_CellFormatting);
            // 
            // sMaHD
            // 
            this.sMaHD.DataPropertyName = "sMaHD";
            this.sMaHD.HeaderText = "Mã hóa đơn";
            this.sMaHD.Name = "sMaHD";
            this.sMaHD.ReadOnly = true;
            // 
            // dNgayLapDataGridViewTextBoxColumn
            // 
            this.dNgayLapDataGridViewTextBoxColumn.DataPropertyName = "dNgayLap";
            this.dNgayLapDataGridViewTextBoxColumn.HeaderText = "Thời gian";
            this.dNgayLapDataGridViewTextBoxColumn.Name = "dNgayLapDataGridViewTextBoxColumn";
            this.dNgayLapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sMaNVDataGridViewTextBoxColumn
            // 
            this.sMaNVDataGridViewTextBoxColumn.DataPropertyName = "sMaNV";
            this.sMaNVDataGridViewTextBoxColumn.HeaderText = "Mã nhân viên";
            this.sMaNVDataGridViewTextBoxColumn.Name = "sMaNVDataGridViewTextBoxColumn";
            this.sMaNVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sMaKHDataGridViewTextBoxColumn
            // 
            this.sMaKHDataGridViewTextBoxColumn.DataPropertyName = "sMaKH";
            this.sMaKHDataGridViewTextBoxColumn.HeaderText = "Mã khách hàng";
            this.sMaKHDataGridViewTextBoxColumn.Name = "sMaKHDataGridViewTextBoxColumn";
            this.sMaKHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fTongTienHDDataGridViewTextBoxColumn
            // 
            this.fTongTienHDDataGridViewTextBoxColumn.DataPropertyName = "fTongTienHD";
            this.fTongTienHDDataGridViewTextBoxColumn.HeaderText = "Tổng tiền hàng";
            this.fTongTienHDDataGridViewTextBoxColumn.Name = "fTongTienHDDataGridViewTextBoxColumn";
            this.fTongTienHDDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.colXemChiTiet.HeaderText = "Xem hóa đơn";
            this.colXemChiTiet.Name = "colXemChiTiet";
            this.colXemChiTiet.ReadOnly = true;
            this.colXemChiTiet.Text = "Xem chi tiết";
            this.colXemChiTiet.UseColumnTextForButtonValue = true;
            this.colXemChiTiet.Width = 65;
            // 
            // tblHoaDonBindingSource
            // 
            this.tblHoaDonBindingSource.DataMember = "tblHoaDon";
            this.tblHoaDonBindingSource.DataSource = this.quanLyKhoThuocTayDataSet11;
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
            this.panel2.Controls.Add(this.btnIn);
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
            this.btnThem.Text = "Thêm hóa đơn";
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
            // btnIn
            // 
            this.btnIn.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnIn.FlatAppearance.BorderSize = 0;
            this.btnIn.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Location = new System.Drawing.Point(825, 0);
            this.btnIn.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(132, 43);
            this.btnIn.TabIndex = 6;
            this.btnIn.Text = "In hóa đơn";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
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
            this.btnHuy.Text = "Hủy hóa đơn";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
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
            this.gbTrangThai.Controls.Add(this.tableLayoutPanel7);
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
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.40212F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.59788F));
            this.tableLayoutPanel7.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.cbHoanThanh, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.cbPhieuTam, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.cbDaHuy, 0, 2);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(5, 24);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(207, 101);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 33);
            this.label3.TabIndex = 10;
            this.label3.Text = "Đã hủy";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbHoanThanh
            // 
            this.cbHoanThanh.AutoSize = true;
            this.cbHoanThanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbHoanThanh.Location = new System.Drawing.Point(6, 37);
            this.cbHoanThanh.Name = "cbHoanThanh";
            this.cbHoanThanh.Size = new System.Drawing.Size(26, 25);
            this.cbHoanThanh.TabIndex = 6;
            this.cbHoanThanh.UseVisualStyleBackColor = true;
            this.cbHoanThanh.CheckedChanged += new System.EventHandler(this.cbHoanThanh_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Phiếu tạm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hoàn thành";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbPhieuTam
            // 
            this.cbPhieuTam.AutoSize = true;
            this.cbPhieuTam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbPhieuTam.Location = new System.Drawing.Point(6, 6);
            this.cbPhieuTam.Name = "cbPhieuTam";
            this.cbPhieuTam.Size = new System.Drawing.Size(26, 25);
            this.cbPhieuTam.TabIndex = 5;
            this.cbPhieuTam.UseVisualStyleBackColor = true;
            this.cbPhieuTam.CheckedChanged += new System.EventHandler(this.cbPhieuTam_CheckedChanged);
            // 
            // cbDaHuy
            // 
            this.cbDaHuy.AutoSize = true;
            this.cbDaHuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDaHuy.Location = new System.Drawing.Point(6, 68);
            this.cbDaHuy.Name = "cbDaHuy";
            this.cbDaHuy.Size = new System.Drawing.Size(26, 27);
            this.cbDaHuy.TabIndex = 9;
            this.cbDaHuy.UseVisualStyleBackColor = true;
            this.cbDaHuy.CheckedChanged += new System.EventHandler(this.cbDaHuy_CheckedChanged);
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
            this.gbThoiGian.Text = "Thời gian";
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
            this.lbHoaDonTitle.Text = "HÓA ĐƠN";
            this.lbHoaDonTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tblHoaDonTableAdapter
            // 
            this.tblHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // frmListHoaDon2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 787);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmListHoaDon2";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách hóa đơn";
            this.Load += new System.EventHandler(this.frmListHoaDon_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoThuocTayDataSet11)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbTrangThai.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.gbThoiGian.ResumeLayout(false);
            this.gbThoiGian.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource tblHoaDonBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private QuanLyKhoThuocTayDataSet1 quanLyKhoThuocTayDataSet11;
        private QuanLyKhoThuocTayDataSet1TableAdapters.tblHoaDonTableAdapter tblHoaDonTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbHoaDonTitle;
        private System.Windows.Forms.GroupBox gbThoiGian;
        private System.Windows.Forms.GroupBox gbTrangThai;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbHoanThanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbPhieuTam;
        private System.Windows.Forms.CheckBox cbDaHuy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnIn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgayLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fTongTienHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTrangThai;
        private System.Windows.Forms.DataGridViewButtonColumn colXemChiTiet;
    }
}