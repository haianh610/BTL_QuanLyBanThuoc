
namespace BTL_QuanLyBanThuoc
{
    partial class frmMatHang
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
            this.MHview = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.TenHangHoa = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.MaLoaiHang = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.SoLuong = new System.Windows.Forms.Label();
            this.MaNCC = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.DonGia = new System.Windows.Forms.Label();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.DonVi = new System.Windows.Forms.Label();
            this.cbxMaLH = new System.Windows.Forms.ComboBox();
            this.cbxMaNCC = new System.Windows.Forms.ComboBox();
            this.txtHangSX = new System.Windows.Forms.TextBox();
            this.HangSX = new System.Windows.Forms.Label();
            this.dpNSX = new System.Windows.Forms.DateTimePicker();
            this.dpHSD = new System.Windows.Forms.DateTimePicker();
            this.txtTimTen = new System.Windows.Forms.TextBox();
            this.ckbTen = new System.Windows.Forms.CheckBox();
            this.ckbDonGia = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiaBD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiaKT = new System.Windows.Forms.TextBox();
            this.btnXoaMH = new System.Windows.Forms.Button();
            this.cbxLocLH = new System.Windows.Forms.ComboBox();
            this.cbxLocNCC = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.quanLyKhoThuocTayDataSet = new BTL_QuanLyBanThuoc.QuanLyKhoThuocTayDataSet();
            this.quanLyKhoThuocTayDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MHview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoThuocTayDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoThuocTayDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MHview
            // 
            this.MHview.AutoGenerateColumns = false;
            this.MHview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MHview.DataSource = this.quanLyKhoThuocTayDataSetBindingSource;
            this.MHview.Location = new System.Drawing.Point(381, 72);
            this.MHview.Name = "MHview";
            this.MHview.Size = new System.Drawing.Size(915, 414);
            this.MHview.TabIndex = 0;
            this.MHview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Reload);
            this.MHview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Reload);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1355, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(58, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHD.Location = new System.Drawing.Point(68, 53);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(92, 16);
            this.lbMaHD.TabIndex = 2;
            this.lbMaHD.Text = "1. Mã hóa đơn";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHang.Location = new System.Drawing.Point(64, 72);
            this.txtMaHang.Multiline = true;
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(222, 28);
            this.txtMaHang.TabIndex = 3;
            // 
            // TenHangHoa
            // 
            this.TenHangHoa.AutoSize = true;
            this.TenHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenHangHoa.Location = new System.Drawing.Point(67, 168);
            this.TenHangHoa.Name = "TenHangHoa";
            this.TenHangHoa.Size = new System.Drawing.Size(113, 16);
            this.TenHangHoa.TabIndex = 4;
            this.TenHangHoa.Text = "3. Tên hàng hóa : ";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHang.Location = new System.Drawing.Point(64, 187);
            this.txtTenHang.Multiline = true;
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(222, 28);
            this.txtTenHang.TabIndex = 5;
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(1209, 498);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(87, 44);
            this.Add.TabIndex = 6;
            this.Add.Text = "Lưu";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.btnLuu);
            // 
            // MaLoaiHang
            // 
            this.MaLoaiHang.AutoSize = true;
            this.MaLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaLoaiHang.Location = new System.Drawing.Point(67, 111);
            this.MaLoaiHang.Name = "MaLoaiHang";
            this.MaLoaiHang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MaLoaiHang.Size = new System.Drawing.Size(86, 16);
            this.MaLoaiHang.TabIndex = 7;
            this.MaLoaiHang.Text = "2. Phân loại : ";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(64, 244);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(222, 28);
            this.txtSoLuong.TabIndex = 10;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSize = true;
            this.SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoLuong.Location = new System.Drawing.Point(68, 225);
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Size = new System.Drawing.Size(83, 16);
            this.SoLuong.TabIndex = 9;
            this.SoLuong.Text = "4. Số lượng : ";
            // 
            // MaNCC
            // 
            this.MaNCC.AutoSize = true;
            this.MaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNCC.Location = new System.Drawing.Point(68, 559);
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Size = new System.Drawing.Size(120, 16);
            this.MaNCC.TabIndex = 11;
            this.MaNCC.Text = "10. Nhà cung cấp : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 451);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "8. HSD : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(68, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "7. NSX : ";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(64, 358);
            this.txtDonGia.Multiline = true;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(222, 28);
            this.txtDonGia.TabIndex = 18;
            // 
            // DonGia
            // 
            this.DonGia.AutoSize = true;
            this.DonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonGia.Location = new System.Drawing.Point(68, 339);
            this.DonGia.Name = "DonGia";
            this.DonGia.Size = new System.Drawing.Size(76, 16);
            this.DonGia.TabIndex = 17;
            this.DonGia.Text = "6. Đơn giá : ";
            // 
            // txtDonVi
            // 
            this.txtDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonVi.Location = new System.Drawing.Point(64, 302);
            this.txtDonVi.Multiline = true;
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(222, 28);
            this.txtDonVi.TabIndex = 20;
            // 
            // DonVi
            // 
            this.DonVi.AutoSize = true;
            this.DonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonVi.Location = new System.Drawing.Point(68, 283);
            this.DonVi.Name = "DonVi";
            this.DonVi.Size = new System.Drawing.Size(67, 16);
            this.DonVi.TabIndex = 19;
            this.DonVi.Text = "5. Đơn vị : ";
            // 
            // cbxMaLH
            // 
            this.cbxMaLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaLH.FormattingEnabled = true;
            this.cbxMaLH.Location = new System.Drawing.Point(64, 130);
            this.cbxMaLH.Name = "cbxMaLH";
            this.cbxMaLH.Size = new System.Drawing.Size(222, 23);
            this.cbxMaLH.TabIndex = 21;
            // 
            // cbxMaNCC
            // 
            this.cbxMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaNCC.FormattingEnabled = true;
            this.cbxMaNCC.Location = new System.Drawing.Point(64, 578);
            this.cbxMaNCC.Name = "cbxMaNCC";
            this.cbxMaNCC.Size = new System.Drawing.Size(222, 23);
            this.cbxMaNCC.TabIndex = 22;
            // 
            // txtHangSX
            // 
            this.txtHangSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHangSX.Location = new System.Drawing.Point(64, 522);
            this.txtHangSX.Multiline = true;
            this.txtHangSX.Name = "txtHangSX";
            this.txtHangSX.Size = new System.Drawing.Size(222, 28);
            this.txtHangSX.TabIndex = 24;
            // 
            // HangSX
            // 
            this.HangSX.AutoSize = true;
            this.HangSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HangSX.Location = new System.Drawing.Point(68, 503);
            this.HangSX.Name = "HangSX";
            this.HangSX.Size = new System.Drawing.Size(83, 16);
            this.HangSX.TabIndex = 23;
            this.HangSX.Text = "9. Hãng SX : ";
            // 
            // dpNSX
            // 
            this.dpNSX.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpNSX.Cursor = System.Windows.Forms.Cursors.Default;
            this.dpNSX.CustomFormat = "dd / MM / yyyy";
            this.dpNSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpNSX.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpNSX.Location = new System.Drawing.Point(64, 415);
            this.dpNSX.Name = "dpNSX";
            this.dpNSX.Size = new System.Drawing.Size(222, 24);
            this.dpNSX.TabIndex = 26;
            // 
            // dpHSD
            // 
            this.dpHSD.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpHSD.CustomFormat = "dd / MM / yyyy";
            this.dpHSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpHSD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpHSD.Location = new System.Drawing.Point(64, 470);
            this.dpHSD.Name = "dpHSD";
            this.dpHSD.Size = new System.Drawing.Size(222, 24);
            this.dpHSD.TabIndex = 27;
            // 
            // txtTimTen
            // 
            this.txtTimTen.Location = new System.Drawing.Point(432, 498);
            this.txtTimTen.Multiline = true;
            this.txtTimTen.Name = "txtTimTen";
            this.txtTimTen.Size = new System.Drawing.Size(268, 30);
            this.txtTimTen.TabIndex = 28;
            this.txtTimTen.TextChanged += new System.EventHandler(this.txtTimTen_TextChanged);
            // 
            // ckbTen
            // 
            this.ckbTen.Location = new System.Drawing.Point(381, 505);
            this.ckbTen.Name = "ckbTen";
            this.ckbTen.Size = new System.Drawing.Size(24, 23);
            this.ckbTen.TabIndex = 30;
            this.ckbTen.UseVisualStyleBackColor = true;
            // 
            // ckbDonGia
            // 
            this.ckbDonGia.Location = new System.Drawing.Point(381, 543);
            this.ckbDonGia.Name = "ckbDonGia";
            this.ckbDonGia.Size = new System.Drawing.Size(24, 23);
            this.ckbDonGia.TabIndex = 31;
            this.ckbDonGia.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 547);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Giá từ :";
            // 
            // txtGiaBD
            // 
            this.txtGiaBD.Location = new System.Drawing.Point(485, 544);
            this.txtGiaBD.Multiline = true;
            this.txtGiaBD.Name = "txtGiaBD";
            this.txtGiaBD.Size = new System.Drawing.Size(82, 30);
            this.txtGiaBD.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(575, 548);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "đến :";
            // 
            // txtGiaKT
            // 
            this.txtGiaKT.Location = new System.Drawing.Point(621, 543);
            this.txtGiaKT.Multiline = true;
            this.txtGiaKT.Name = "txtGiaKT";
            this.txtGiaKT.Size = new System.Drawing.Size(79, 30);
            this.txtGiaKT.TabIndex = 35;
            this.txtGiaKT.TextChanged += new System.EventHandler(this.txtGiaKT_TextChanged);
            // 
            // btnXoaMH
            // 
            this.btnXoaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMH.Location = new System.Drawing.Point(1098, 498);
            this.btnXoaMH.Name = "btnXoaMH";
            this.btnXoaMH.Size = new System.Drawing.Size(87, 44);
            this.btnXoaMH.TabIndex = 36;
            this.btnXoaMH.Text = "Xóa";
            this.btnXoaMH.UseVisualStyleBackColor = true;
            this.btnXoaMH.Click += new System.EventHandler(this.btnXoaMH_Click);
            // 
            // cbxLocLH
            // 
            this.cbxLocLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLocLH.FormattingEnabled = true;
            this.cbxLocLH.Location = new System.Drawing.Point(381, 28);
            this.cbxLocLH.Name = "cbxLocLH";
            this.cbxLocLH.Size = new System.Drawing.Size(222, 23);
            this.cbxLocLH.TabIndex = 37;
            // 
            // cbxLocNCC
            // 
            this.cbxLocNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLocNCC.FormattingEnabled = true;
            this.cbxLocNCC.Location = new System.Drawing.Point(1074, 28);
            this.cbxLocNCC.Name = "cbxLocNCC";
            this.cbxLocNCC.Size = new System.Drawing.Size(222, 23);
            this.cbxLocNCC.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(381, 9);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Loại hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1075, 9);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Nhà cung cấp:";
            // 
            // quanLyKhoThuocTayDataSet
            // 
            this.quanLyKhoThuocTayDataSet.DataSetName = "QuanLyKhoThuocTayDataSet";
            this.quanLyKhoThuocTayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLyKhoThuocTayDataSetBindingSource
            // 
            this.quanLyKhoThuocTayDataSetBindingSource.DataSource = this.quanLyKhoThuocTayDataSet;
            this.quanLyKhoThuocTayDataSetBindingSource.Position = 0;
            // 
            // frmMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1355, 624);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxLocNCC);
            this.Controls.Add(this.cbxLocLH);
            this.Controls.Add(this.btnXoaMH);
            this.Controls.Add(this.txtGiaKT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGiaBD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckbDonGia);
            this.Controls.Add(this.ckbTen);
            this.Controls.Add(this.txtTimTen);
            this.Controls.Add(this.dpHSD);
            this.Controls.Add(this.dpNSX);
            this.Controls.Add(this.txtHangSX);
            this.Controls.Add(this.HangSX);
            this.Controls.Add(this.cbxMaNCC);
            this.Controls.Add(this.cbxMaLH);
            this.Controls.Add(this.txtDonVi);
            this.Controls.Add(this.DonVi);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.DonGia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MaNCC);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.SoLuong);
            this.Controls.Add(this.MaLoaiHang);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.TenHangHoa);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.lbMaHD);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.MHview);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMatHang";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MHview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoThuocTayDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoThuocTayDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MHview;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label TenHangHoa;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label MaLoaiHang;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label SoLuong;
        private System.Windows.Forms.Label MaNCC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label DonGia;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.Label DonVi;
        private System.Windows.Forms.ComboBox cbxMaLH;
        private System.Windows.Forms.ComboBox cbxMaNCC;
        private System.Windows.Forms.TextBox txtHangSX;
        private System.Windows.Forms.Label HangSX;
        private System.Windows.Forms.DateTimePicker dpNSX;
        private System.Windows.Forms.DateTimePicker dpHSD;
        private System.Windows.Forms.TextBox txtTimTen;
        private System.Windows.Forms.CheckBox ckbTen;
        private System.Windows.Forms.CheckBox ckbDonGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiaBD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGiaKT;
        private System.Windows.Forms.Button btnXoaMH;
        private System.Windows.Forms.ComboBox cbxLocLH;
        private System.Windows.Forms.ComboBox cbxLocNCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource quanLyKhoThuocTayDataSetBindingSource;
        private QuanLyKhoThuocTayDataSet quanLyKhoThuocTayDataSet;
    }
}

