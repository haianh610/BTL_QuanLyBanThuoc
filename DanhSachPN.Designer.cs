
namespace BTL_QuanLyBanThuoc
{
    partial class DanhSachPN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachPN));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbTrangThai = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbHoanThanh = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPhieuTam = new System.Windows.Forms.CheckBox();
            this.cbDaHuy = new System.Windows.Forms.CheckBox();
            this.btnThemPN = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnInPN = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnHuyPN = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lbPhieuNhapTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyKhoThuocTayDataSet8 = new BTL_QuanLyBanThuoc.QuanLyKhoThuocTayDataSet();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbThoiGian = new System.Windows.Forms.GroupBox();
            this.lbDen = new System.Windows.Forms.Label();
            this.lbTu = new System.Windows.Forms.Label();
            this.dtpDen = new System.Windows.Forms.DateTimePicker();
            this.dtpTu = new System.Windows.Forms.DateTimePicker();
            this.rbKhoangThoiGian = new System.Windows.Forms.RadioButton();
            this.rbToanThoiGian = new System.Windows.Forms.RadioButton();
            this.rbThangNay = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tblPhieuNhapTableAdapter6 = new BTL_QuanLyBanThuoc.QuanLyKhoThuocTayDataSetTableAdapters.tblPhieuNhapTableAdapter();
            this.sMaPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColXemChiTiet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbTrangThai.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoThuocTayDataSet8)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbThoiGian.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTrangThai
            // 
            this.gbTrangThai.BackColor = System.Drawing.SystemColors.Control;
            this.gbTrangThai.Controls.Add(this.tableLayoutPanel7);
            this.gbTrangThai.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTrangThai.Location = new System.Drawing.Point(0, 247);
            this.gbTrangThai.Name = "gbTrangThai";
            this.gbTrangThai.Padding = new System.Windows.Forms.Padding(5);
            this.gbTrangThai.Size = new System.Drawing.Size(217, 131);
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
            this.tableLayoutPanel7.Location = new System.Drawing.Point(5, 22);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(207, 104);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 34);
            this.label3.TabIndex = 10;
            this.label3.Text = "Đã hủy";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbHoanThanh
            // 
            this.cbHoanThanh.AutoSize = true;
            this.cbHoanThanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbHoanThanh.Location = new System.Drawing.Point(6, 38);
            this.cbHoanThanh.Name = "cbHoanThanh";
            this.cbHoanThanh.Size = new System.Drawing.Size(26, 26);
            this.cbHoanThanh.TabIndex = 6;
            this.cbHoanThanh.UseVisualStyleBackColor = true;
            this.cbHoanThanh.CheckedChanged += new System.EventHandler(this.cbHoanThanh_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Phiếu tạm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 32);
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
            this.cbPhieuTam.Size = new System.Drawing.Size(26, 26);
            this.cbPhieuTam.TabIndex = 5;
            this.cbPhieuTam.UseVisualStyleBackColor = true;
            this.cbPhieuTam.CheckedChanged += new System.EventHandler(this.cbPhieuTam_CheckedChanged_1);
            // 
            // cbDaHuy
            // 
            this.cbDaHuy.AutoSize = true;
            this.cbDaHuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDaHuy.Location = new System.Drawing.Point(6, 70);
            this.cbDaHuy.Name = "cbDaHuy";
            this.cbDaHuy.Size = new System.Drawing.Size(26, 28);
            this.cbDaHuy.TabIndex = 9;
            this.cbDaHuy.UseVisualStyleBackColor = true;
            this.cbDaHuy.CheckedChanged += new System.EventHandler(this.cbDaHuy_CheckedChanged_1);
            // 
            // btnThemPN
            // 
            this.btnThemPN.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThemPN.FlatAppearance.BorderSize = 0;
            this.btnThemPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPN.Location = new System.Drawing.Point(493, 0);
            this.btnThemPN.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.btnThemPN.Name = "btnThemPN";
            this.btnThemPN.Size = new System.Drawing.Size(162, 43);
            this.btnThemPN.TabIndex = 4;
            this.btnThemPN.Text = "Thêm Phiếu Nhập";
            this.btnThemPN.UseVisualStyleBackColor = true;
            this.btnThemPN.Click += new System.EventHandler(this.btnThemPN_Click_1);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(655, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 43);
            this.panel3.TabIndex = 7;
            // 
            // btnInPN
            // 
            this.btnInPN.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInPN.FlatAppearance.BorderSize = 0;
            this.btnInPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInPN.Location = new System.Drawing.Point(670, 0);
            this.btnInPN.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.btnInPN.Name = "btnInPN";
            this.btnInPN.Size = new System.Drawing.Size(132, 43);
            this.btnInPN.TabIndex = 6;
            this.btnInPN.Text = "In Phiếu Nhập";
            this.btnInPN.UseVisualStyleBackColor = true;
            this.btnInPN.Click += new System.EventHandler(this.btnInPN_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(802, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 43);
            this.panel4.TabIndex = 8;
            // 
            // btnHuyPN
            // 
            this.btnHuyPN.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHuyPN.FlatAppearance.BorderSize = 0;
            this.btnHuyPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyPN.Location = new System.Drawing.Point(817, 0);
            this.btnHuyPN.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.btnHuyPN.Name = "btnHuyPN";
            this.btnHuyPN.Size = new System.Drawing.Size(132, 43);
            this.btnHuyPN.TabIndex = 5;
            this.btnHuyPN.Text = "Hủy Phiếu Nhập";
            this.btnHuyPN.UseVisualStyleBackColor = true;
            this.btnHuyPN.Click += new System.EventHandler(this.btnXoaPN_Click_1);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(41, 9);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(180, 26);
            this.txtTimKiem.TabIndex = 3;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lbPhieuNhapTitle
            // 
            this.lbPhieuNhapTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPhieuNhapTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhieuNhapTitle.Location = new System.Drawing.Point(0, 0);
            this.lbPhieuNhapTitle.Margin = new System.Windows.Forms.Padding(5);
            this.lbPhieuNhapTitle.Name = "lbPhieuNhapTitle";
            this.lbPhieuNhapTitle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lbPhieuNhapTitle.Size = new System.Drawing.Size(217, 51);
            this.lbPhieuNhapTitle.TabIndex = 1;
            this.lbPhieuNhapTitle.Text = "PHIẾU NHẬP";
            this.lbPhieuNhapTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThemPN);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnInPN);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnHuyPN);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.panel2.Size = new System.Drawing.Size(969, 43);
            this.panel2.TabIndex = 11;
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
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.AllowUserToAddRows = false;
            this.dgvPhieuNhap.AllowUserToDeleteRows = false;
            this.dgvPhieuNhap.AutoGenerateColumns = false;
            this.dgvPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaPN,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.iTrangThai,
            this.ColXemChiTiet});
            this.dgvPhieuNhap.DataSource = this.bindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhieuNhap.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(20, 59);
            this.dgvPhieuNhap.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.ReadOnly = true;
            this.dgvPhieuNhap.RowHeadersVisible = false;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(935, 605);
            this.dgvPhieuNhap.TabIndex = 6;
            this.dgvPhieuNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuNhap_CellContentClick_1);
            this.dgvPhieuNhap.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPhieuNhap_CellFormatting);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tblPhieuNhap";
            this.bindingSource1.DataSource = this.quanLyKhoThuocTayDataSet8;
            // 
            // quanLyKhoThuocTayDataSet8
            // 
            this.quanLyKhoThuocTayDataSet8.DataSetName = "QuanLyKhoThuocTayDataSet";
            this.quanLyKhoThuocTayDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.dgvPhieuNhap, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(226, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(975, 674);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbTrangThai);
            this.panel1.Controls.Add(this.gbThoiGian);
            this.panel1.Controls.Add(this.lbPhieuNhapTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 674);
            this.panel1.TabIndex = 7;
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
            this.gbThoiGian.TabIndex = 4;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 223F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1204, 680);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tblPhieuNhapTableAdapter6
            // 
            this.tblPhieuNhapTableAdapter6.ClearBeforeFill = true;
            // 
            // sMaPN
            // 
            this.sMaPN.DataPropertyName = "sMaPN";
            this.sMaPN.HeaderText = "Mã Phiếu Nhập";
            this.sMaPN.Name = "sMaPN";
            this.sMaPN.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "sMaNV";
            this.dataGridViewTextBoxColumn8.HeaderText = "Mã Nhân Viên";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "dNgayNhap";
            this.dataGridViewTextBoxColumn9.HeaderText = "Ngày Nhập";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "sMaNCC";
            this.dataGridViewTextBoxColumn10.HeaderText = "Mã NCC";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "fTongTienPN";
            this.dataGridViewTextBoxColumn11.HeaderText = "Tổng Tiền";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // iTrangThai
            // 
            this.iTrangThai.DataPropertyName = "iTrangThai";
            this.iTrangThai.HeaderText = "Trạng Thái";
            this.iTrangThai.Name = "iTrangThai";
            this.iTrangThai.ReadOnly = true;
            // 
            // ColXemChiTiet
            // 
            this.ColXemChiTiet.HeaderText = "Xem Phiếu Nhập";
            this.ColXemChiTiet.Name = "ColXemChiTiet";
            this.ColXemChiTiet.ReadOnly = true;
            this.ColXemChiTiet.Text = "Xem chi tiết";
            this.ColXemChiTiet.UseColumnTextForButtonValue = true;
            // 
            // DanhSachPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 680);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DanhSachPN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DanhSachPN";
            this.Load += new System.EventHandler(this.DanhSachPN_Load);
            this.gbTrangThai.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoThuocTayDataSet8)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gbThoiGian.ResumeLayout(false);
            this.gbThoiGian.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource tblPhieuNhapBindingSource;
        private QuanLyKhoThuocTayDataSet QuanLyKhoThuocTayDataSet;
        private QuanLyKhoThuocTayDataSet QuanLyKhoThuocTayDataSet1;
        private QuanLyKhoThuocTayDataSet quanLyKhoThuocTayDataSet2;
        private QuanLyKhoThuocTayDataSetTableAdapters.tblPhieuNhapTableAdapter tblPhieuNhapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaPNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgayNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaNCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fTongTienPNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTrangThaiDataGridViewTextBoxColumn;
        private QuanLyKhoThuocTayDataSet quanLyKhoThuocTayDataSet3;
        private QuanLyKhoThuocTayDataSetTableAdapters.tblPhieuNhapTableAdapter tblPhieuNhapTableAdapter1;
        private QuanLyKhoThuocTayDataSetTableAdapters.tblPhieuNhapTableAdapter tblPhieuNhapTableAdapter2;
        private QuanLyKhoThuocTayDataSet quanLyKhoThuocTayDataSet4;
        private QuanLyKhoThuocTayDataSet quanLyKhoThuocTayDataSet5;
        private QuanLyKhoThuocTayDataSetTableAdapters.tblPhieuNhapTableAdapter tblPhieuNhapTableAdapter3;
        private QuanLyKhoThuocTayDataSet quanLyKhoThuocTayDataSet6;
        private QuanLyKhoThuocTayDataSetTableAdapters.tblPhieuNhapTableAdapter tblPhieuNhapTableAdapter4;
        private QuanLyKhoThuocTayDataSet quanLyKhoThuocTayDataSet7;
        private QuanLyKhoThuocTayDataSetTableAdapters.tblPhieuNhapTableAdapter tblPhieuNhapTableAdapter5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox gbTrangThai;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbHoanThanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbPhieuTam;
        private System.Windows.Forms.CheckBox cbDaHuy;
        private System.Windows.Forms.Button btnThemPN;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnInPN;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnHuyPN;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbPhieuNhapTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private QuanLyKhoThuocTayDataSet quanLyKhoThuocTayDataSet8;
        private System.Windows.Forms.BindingSource bindingSource1;
        private QuanLyKhoThuocTayDataSetTableAdapters.tblPhieuNhapTableAdapter tblPhieuNhapTableAdapter6;
        private System.Windows.Forms.GroupBox gbThoiGian;
        private System.Windows.Forms.Label lbDen;
        private System.Windows.Forms.Label lbTu;
        private System.Windows.Forms.DateTimePicker dtpDen;
        private System.Windows.Forms.DateTimePicker dtpTu;
        private System.Windows.Forms.RadioButton rbKhoangThoiGian;
        private System.Windows.Forms.RadioButton rbToanThoiGian;
        private System.Windows.Forms.RadioButton rbThangNay;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTrangThai;
        private System.Windows.Forms.DataGridViewButtonColumn ColXemChiTiet;
    }
}