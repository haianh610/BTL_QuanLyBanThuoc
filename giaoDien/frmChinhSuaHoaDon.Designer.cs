
namespace BTL_QuanLyBanThuoc
{
    partial class frmBanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnThemHang = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvChiTietHD = new System.Windows.Forms.DataGridView();
            this.sMaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXoaHang = new System.Windows.Forms.DataGridViewButtonColumn();
            this.sPChiTietHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyKhoThuocTayDataSet1 = new BTL_QuanLyBanThuoc.QuanLyKhoThuocTayDataSet1();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pannelPhuongThucThanhToan = new System.Windows.Forms.TableLayoutPanel();
            this.rbChuyenKhoan = new System.Windows.Forms.RadioButton();
            this.rbThe = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tblNhanVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbNgayLap = new System.Windows.Forms.Label();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbKhachHang = new System.Windows.Forms.TextBox();
            this.ketQuaContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tblNhanVienTableAdapterDS1 = new BTL_QuanLyBanThuoc.QuanLyKhoThuocTayDataSet1TableAdapters.tblNhanVienTableAdapter();
            this.sP_ChiTietHoaDonTableAdapter2 = new BTL_QuanLyBanThuoc.QuanLyKhoThuocTayDataSet1TableAdapters.SP_ChiTietHoaDonTableAdapter();
            this.rbTienMat = new System.Windows.Forms.RadioButton();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbKhachThanhToan = new System.Windows.Forms.Label();
            this.txtKhachThanhToan = new System.Windows.Forms.TextBox();
            this.lbSoTienTraKhach = new System.Windows.Forms.Label();
            this.txtSoTienTraKhach = new System.Windows.Forms.TextBox();
            this.pannelTraTien = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPChiTietHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoThuocTayDataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pannelPhuongThucThanhToan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pannelTraTien.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.28497F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.71503F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.960894F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.03911F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1424, 716);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(97)))), ((int)(((byte)(214)))));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 674F));
            this.tableLayoutPanel2.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel7, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(35, 10, 10, 10);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1424, 55);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.nudSoLuong);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(651, 13);
            this.panel5.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 4);
            this.panel5.Size = new System.Drawing.Size(86, 29);
            this.panel5.TabIndex = 1;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudSoLuong.Dock = System.Windows.Forms.DockStyle.Left;
            this.nudSoLuong.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.nudSoLuong.Location = new System.Drawing.Point(4, 3);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(81, 26);
            this.nudSoLuong.TabIndex = 2;
            this.nudSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.Leave += new System.EventHandler(this.nudSoLuong_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtMaHang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(38, 13);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(600, 29);
            this.panel1.TabIndex = 0;
            // 
            // txtMaHang
            // 
            this.txtMaHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaHang.Font = new System.Drawing.Font("Inter Italic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHang.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMaHang.Location = new System.Drawing.Point(5, 5);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(590, 20);
            this.txtMaHang.TabIndex = 0;
            this.txtMaHang.Text = "Tìm kiếm sản phẩm (mã /tên)";
            this.txtMaHang.TextChanged += new System.EventHandler(this.txtMaHang_TextChanged);
            this.txtMaHang.Enter += new System.EventHandler(this.txtMaHang_Enter);
            this.txtMaHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaHang_KeyDown);
            this.txtMaHang.Leave += new System.EventHandler(this.txtMaHang_Leave);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnThemHang);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(743, 13);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(38, 29);
            this.panel7.TabIndex = 2;
            // 
            // btnThemHang
            // 
            this.btnThemHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(97)))), ((int)(((byte)(214)))));
            this.btnThemHang.BackgroundImage = global::BTL_QuanLyBanThuoc.Properties.Resources.Add_NewPlus;
            this.btnThemHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThemHang.FlatAppearance.BorderSize = 0;
            this.btnThemHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemHang.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHang.ForeColor = System.Drawing.Color.DimGray;
            this.btnThemHang.Location = new System.Drawing.Point(0, 0);
            this.btnThemHang.Margin = new System.Windows.Forms.Padding(5);
            this.btnThemHang.Name = "btnThemHang";
            this.btnThemHang.Size = new System.Drawing.Size(38, 29);
            this.btnThemHang.TabIndex = 2;
            this.btnThemHang.UseVisualStyleBackColor = false;
            this.btnThemHang.Click += new System.EventHandler(this.btnThemHang_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.878F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.122F));
            this.tableLayoutPanel3.Controls.Add(this.dgvChiTietHD, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 58);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1418, 634);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // dgvChiTietHD
            // 
            this.dgvChiTietHD.AllowUserToAddRows = false;
            this.dgvChiTietHD.AllowUserToDeleteRows = false;
            this.dgvChiTietHD.AutoGenerateColumns = false;
            this.dgvChiTietHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvChiTietHD.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTietHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaHang,
            this.sTenHang,
            this.fDonGia,
            this.iSoLuong,
            this.fThanhTien,
            this.colXoaHang});
            this.dgvChiTietHD.DataSource = this.sPChiTietHoaDonBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiTietHD.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvChiTietHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietHD.Location = new System.Drawing.Point(40, 20);
            this.dgvChiTietHD.Margin = new System.Windows.Forms.Padding(20, 20, 0, 20);
            this.dgvChiTietHD.Name = "dgvChiTietHD";
            this.dgvChiTietHD.ReadOnly = true;
            this.dgvChiTietHD.RowHeadersVisible = false;
            this.dgvChiTietHD.RowTemplate.Height = 70;
            this.dgvChiTietHD.Size = new System.Drawing.Size(846, 594);
            this.dgvChiTietHD.TabIndex = 1;
            this.dgvChiTietHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietHD_CellContentClick);
            // 
            // sMaHang
            // 
            this.sMaHang.DataPropertyName = "Mã hàng";
            this.sMaHang.HeaderText = "Mã hàng";
            this.sMaHang.Name = "sMaHang";
            this.sMaHang.ReadOnly = true;
            this.sMaHang.Width = 105;
            // 
            // sTenHang
            // 
            this.sTenHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sTenHang.DataPropertyName = "Tên hàng";
            this.sTenHang.HeaderText = "Tên hàng";
            this.sTenHang.Name = "sTenHang";
            this.sTenHang.ReadOnly = true;
            // 
            // fDonGia
            // 
            this.fDonGia.DataPropertyName = "Đơn giá";
            this.fDonGia.HeaderText = "Đơn giá";
            this.fDonGia.Name = "fDonGia";
            this.fDonGia.ReadOnly = true;
            this.fDonGia.Width = 99;
            // 
            // iSoLuong
            // 
            this.iSoLuong.DataPropertyName = "Số lượng";
            this.iSoLuong.HeaderText = "Số lượng";
            this.iSoLuong.Name = "iSoLuong";
            this.iSoLuong.ReadOnly = true;
            this.iSoLuong.Width = 108;
            // 
            // fThanhTien
            // 
            this.fThanhTien.DataPropertyName = "Thành tiền";
            this.fThanhTien.HeaderText = "Thành tiền";
            this.fThanhTien.Name = "fThanhTien";
            this.fThanhTien.ReadOnly = true;
            this.fThanhTien.Width = 119;
            // 
            // colXoaHang
            // 
            this.colXoaHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colXoaHang.FillWeight = 1.265567F;
            this.colXoaHang.HeaderText = "Xóa hàng";
            this.colXoaHang.Name = "colXoaHang";
            this.colXoaHang.ReadOnly = true;
            this.colXoaHang.Text = "Xóa";
            this.colXoaHang.Width = 92;
            // 
            // sPChiTietHoaDonBindingSource
            // 
            this.sPChiTietHoaDonBindingSource.DataMember = "SP_ChiTietHoaDon";
            this.sPChiTietHoaDonBindingSource.DataSource = this.quanLyKhoThuocTayDataSet1;
            // 
            // quanLyKhoThuocTayDataSet1
            // 
            this.quanLyKhoThuocTayDataSet1.DataSetName = "QuanLyKhoThuocTayDataSet1";
            this.quanLyKhoThuocTayDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.pannelTraTien);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.lbTrangThai);
            this.panel2.Controls.Add(this.pannelPhuongThucThanhToan);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.tableLayoutPanel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.panel2.Location = new System.Drawing.Point(906, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(20);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(472, 594);
            this.panel2.TabIndex = 0;
            // 
            // pannelPhuongThucThanhToan
            // 
            this.pannelPhuongThucThanhToan.ColumnCount = 3;
            this.pannelPhuongThucThanhToan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pannelPhuongThucThanhToan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pannelPhuongThucThanhToan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pannelPhuongThucThanhToan.Controls.Add(this.rbTienMat, 0, 0);
            this.pannelPhuongThucThanhToan.Controls.Add(this.rbChuyenKhoan, 1, 0);
            this.pannelPhuongThucThanhToan.Controls.Add(this.rbThe, 2, 0);
            this.pannelPhuongThucThanhToan.Dock = System.Windows.Forms.DockStyle.Top;
            this.pannelPhuongThucThanhToan.Location = new System.Drawing.Point(10, 98);
            this.pannelPhuongThucThanhToan.MaximumSize = new System.Drawing.Size(700, 40);
            this.pannelPhuongThucThanhToan.Name = "pannelPhuongThucThanhToan";
            this.pannelPhuongThucThanhToan.RowCount = 1;
            this.pannelPhuongThucThanhToan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pannelPhuongThucThanhToan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pannelPhuongThucThanhToan.Size = new System.Drawing.Size(452, 29);
            this.pannelPhuongThucThanhToan.TabIndex = 7;
            // 
            // rbChuyenKhoan
            // 
            this.rbChuyenKhoan.AutoSize = true;
            this.rbChuyenKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbChuyenKhoan.Font = new System.Drawing.Font("Inter", 12F);
            this.rbChuyenKhoan.Location = new System.Drawing.Point(153, 3);
            this.rbChuyenKhoan.Name = "rbChuyenKhoan";
            this.rbChuyenKhoan.Size = new System.Drawing.Size(144, 23);
            this.rbChuyenKhoan.TabIndex = 0;
            this.rbChuyenKhoan.TabStop = true;
            this.rbChuyenKhoan.Text = "Chuyển khoản";
            this.rbChuyenKhoan.UseVisualStyleBackColor = true;
            // 
            // rbThe
            // 
            this.rbThe.AutoSize = true;
            this.rbThe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbThe.Font = new System.Drawing.Font("Inter", 12F);
            this.rbThe.Location = new System.Drawing.Point(303, 3);
            this.rbThe.Name = "rbThe";
            this.rbThe.Size = new System.Drawing.Size(146, 23);
            this.rbThe.TabIndex = 1;
            this.rbThe.TabStop = true;
            this.rbThe.Text = "Thẻ";
            this.rbThe.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tblNhanVienBindingSource1;
            this.comboBox1.DisplayMember = "sTenNV";
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.Font = new System.Drawing.Font("Inter", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(10, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(452, 27);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "sMaNV";
            // 
            // tblNhanVienBindingSource1
            // 
            this.tblNhanVienBindingSource1.DataMember = "tblNhanVien";
            this.tblNhanVienBindingSource1.DataSource = this.quanLyKhoThuocTayDataSet1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbNgayLap);
            this.panel6.Controls.Add(this.lbMaHD);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(10, 47);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(5);
            this.panel6.Size = new System.Drawing.Size(452, 24);
            this.panel6.TabIndex = 5;
            // 
            // lbNgayLap
            // 
            this.lbNgayLap.AutoSize = true;
            this.lbNgayLap.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbNgayLap.Font = new System.Drawing.Font("Inter", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayLap.Location = new System.Drawing.Point(5, 5);
            this.lbNgayLap.Name = "lbNgayLap";
            this.lbNgayLap.Size = new System.Drawing.Size(62, 16);
            this.lbNgayLap.TabIndex = 1;
            this.lbNgayLap.Text = "Ngày lập";
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbMaHD.Font = new System.Drawing.Font("Inter", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHD.Location = new System.Drawing.Point(393, 5);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(54, 16);
            this.lbMaHD.TabIndex = 1;
            this.lbMaHD.Text = "Mã HD:";
            this.lbMaHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Location = new System.Drawing.Point(10, 457);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(452, 2);
            this.label5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbTongTien);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 459);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(20);
            this.panel4.Size = new System.Drawing.Size(452, 64);
            this.panel4.TabIndex = 4;
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTongTien.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(97)))), ((int)(((byte)(214)))));
            this.lbTongTien.Location = new System.Drawing.Point(387, 20);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(45, 29);
            this.lbTongTien.TabIndex = 1;
            this.lbTongTien.Text = "0đ";
            this.lbTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.label3.Location = new System.Drawing.Point(20, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tổng tiền";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.27027F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.72973F));
            this.tableLayoutPanel4.Controls.Add(this.button3, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(10, 523);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(452, 61);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DimGray;
            this.button3.Location = new System.Drawing.Point(322, 5);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 51);
            this.button3.TabIndex = 1;
            this.button3.Text = "Lưu tạm";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(97)))), ((int)(((byte)(214)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(5, 5);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(307, 51);
            this.button2.TabIndex = 0;
            this.button2.Text = "Thanh toán";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.lbKhachHang);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(452, 37);
            this.panel3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(415, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 17);
            this.button1.TabIndex = 1;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lbKhachHang
            // 
            this.lbKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbKhachHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbKhachHang.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.lbKhachHang.Location = new System.Drawing.Point(10, 10);
            this.lbKhachHang.Name = "lbKhachHang";
            this.lbKhachHang.Size = new System.Drawing.Size(338, 14);
            this.lbKhachHang.TabIndex = 0;
            this.lbKhachHang.Text = "Nhập khách hàng";
            // 
            // ketQuaContainer
            // 
            this.ketQuaContainer.Location = new System.Drawing.Point(43, 52);
            this.ketQuaContainer.Name = "ketQuaContainer";
            this.ketQuaContainer.Size = new System.Drawing.Size(494, 0);
            this.ketQuaContainer.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tblNhanVienTableAdapterDS1
            // 
            this.tblNhanVienTableAdapterDS1.ClearBeforeFill = true;
            // 
            // sP_ChiTietHoaDonTableAdapter2
            // 
            this.sP_ChiTietHoaDonTableAdapter2.ClearBeforeFill = true;
            // 
            // rbTienMat
            // 
            this.rbTienMat.AutoSize = true;
            this.rbTienMat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbTienMat.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTienMat.Location = new System.Drawing.Point(3, 3);
            this.rbTienMat.Name = "rbTienMat";
            this.rbTienMat.Size = new System.Drawing.Size(144, 23);
            this.rbTienMat.TabIndex = 2;
            this.rbTienMat.TabStop = true;
            this.rbTienMat.Text = "Tiền mặt";
            this.rbTienMat.UseVisualStyleBackColor = true;
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.AutoSize = true;
            this.lbTrangThai.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTrangThai.Font = new System.Drawing.Font("Inter Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrangThai.Location = new System.Drawing.Point(10, 127);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Padding = new System.Windows.Forms.Padding(5);
            this.lbTrangThai.Size = new System.Drawing.Size(111, 33);
            this.lbTrangThai.TabIndex = 8;
            this.lbTrangThai.Text = "Trạng thái";
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(10, 160);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(452, 67);
            this.panel8.TabIndex = 9;
            // 
            // lbKhachThanhToan
            // 
            this.lbKhachThanhToan.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbKhachThanhToan.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhachThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbKhachThanhToan.Location = new System.Drawing.Point(0, 0);
            this.lbKhachThanhToan.Name = "lbKhachThanhToan";
            this.lbKhachThanhToan.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lbKhachThanhToan.Size = new System.Drawing.Size(150, 36);
            this.lbKhachThanhToan.TabIndex = 0;
            this.lbKhachThanhToan.Text = "Khách thanh toán: ";
            this.lbKhachThanhToan.Click += new System.EventHandler(this.lbKhachThanhToan_Click);
            // 
            // txtKhachThanhToan
            // 
            this.txtKhachThanhToan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKhachThanhToan.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtKhachThanhToan.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhachThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.txtKhachThanhToan.Location = new System.Drawing.Point(150, 0);
            this.txtKhachThanhToan.Name = "txtKhachThanhToan";
            this.txtKhachThanhToan.Size = new System.Drawing.Size(181, 27);
            this.txtKhachThanhToan.TabIndex = 1;
            this.txtKhachThanhToan.TextChanged += new System.EventHandler(this.txtKhachThanhToan_TextChanged);
            // 
            // lbSoTienTraKhach
            // 
            this.lbSoTienTraKhach.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbSoTienTraKhach.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTienTraKhach.Location = new System.Drawing.Point(0, 0);
            this.lbSoTienTraKhach.Name = "lbSoTienTraKhach";
            this.lbSoTienTraKhach.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lbSoTienTraKhach.Size = new System.Drawing.Size(150, 37);
            this.lbSoTienTraKhach.TabIndex = 10;
            this.lbSoTienTraKhach.Text = "Số tiền trả khách: ";
            // 
            // txtSoTienTraKhach
            // 
            this.txtSoTienTraKhach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoTienTraKhach.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSoTienTraKhach.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienTraKhach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.txtSoTienTraKhach.Location = new System.Drawing.Point(150, 0);
            this.txtSoTienTraKhach.Name = "txtSoTienTraKhach";
            this.txtSoTienTraKhach.ReadOnly = true;
            this.txtSoTienTraKhach.Size = new System.Drawing.Size(181, 27);
            this.txtSoTienTraKhach.TabIndex = 11;
            // 
            // pannelTraTien
            // 
            this.pannelTraTien.ColumnCount = 1;
            this.pannelTraTien.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pannelTraTien.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pannelTraTien.Controls.Add(this.panel10, 0, 1);
            this.pannelTraTien.Controls.Add(this.panel9, 0, 0);
            this.pannelTraTien.Dock = System.Windows.Forms.DockStyle.Top;
            this.pannelTraTien.Location = new System.Drawing.Point(10, 227);
            this.pannelTraTien.Name = "pannelTraTien";
            this.pannelTraTien.RowCount = 2;
            this.pannelTraTien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pannelTraTien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pannelTraTien.Size = new System.Drawing.Size(452, 85);
            this.pannelTraTien.TabIndex = 12;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtKhachThanhToan);
            this.panel9.Controls.Add(this.lbKhachThanhToan);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(93, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(356, 36);
            this.panel9.TabIndex = 13;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txtSoTienTraKhach);
            this.panel10.Controls.Add(this.lbSoTienTraKhach);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(93, 45);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(356, 37);
            this.panel10.TabIndex = 13;
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1424, 716);
            this.Controls.Add(this.ketQuaContainer);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmBanHang";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPChiTietHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoThuocTayDataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pannelPhuongThucThanhToan.ResumeLayout(false);
            this.pannelPhuongThucThanhToan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pannelTraTien.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbNgayLap;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox lbKhachHang;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvChiTietHD;
        private System.Windows.Forms.BindingSource sPChiTietHoaDonBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.FlowLayoutPanel ketQuaContainer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnThemHang;
        private System.Windows.Forms.ComboBox comboBox1;
        private QuanLyKhoThuocTayDataSet1 quanLyKhoThuocTayDataSet1;
        private QuanLyKhoThuocTayDataSet1TableAdapters.tblNhanVienTableAdapter tblNhanVienTableAdapterDS1;
        private QuanLyKhoThuocTayDataSet1TableAdapters.SP_ChiTietHoaDonTableAdapter sP_ChiTietHoaDonTableAdapter2;
        private System.Windows.Forms.BindingSource tblNhanVienBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn fDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn fThanhTien;
        private System.Windows.Forms.DataGridViewButtonColumn colXoaHang;
        private System.Windows.Forms.TableLayoutPanel pannelPhuongThucThanhToan;
        private System.Windows.Forms.RadioButton rbChuyenKhoan;
        private System.Windows.Forms.RadioButton rbThe;
        private System.Windows.Forms.RadioButton rbTienMat;
        private System.Windows.Forms.Label lbTrangThai;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtKhachThanhToan;
        private System.Windows.Forms.Label lbKhachThanhToan;
        private System.Windows.Forms.Label lbSoTienTraKhach;
        private System.Windows.Forms.TextBox txtSoTienTraKhach;
        private System.Windows.Forms.TableLayoutPanel pannelTraTien;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
    }
}