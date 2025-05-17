
namespace BTL_QuanLyBanThuoc
{
    partial class fLoaiHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLoaiHang));
            this.lbHoaDonTitle = new System.Windows.Forms.Label();
            this.gbLH = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbDungBanLH = new System.Windows.Forms.CheckBox();
            this.ckbLuuNhapLH = new System.Windows.Forms.CheckBox();
            this.ckbHienHanhLH = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMaLH = new System.Windows.Forms.TextBox();
            this.btnXoaLH = new System.Windows.Forms.Button();
            this.btnLuuLH = new System.Windows.Forms.Button();
            this.TenLH = new System.Windows.Forms.Label();
            this.txbTenLH = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.txbTimLH = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnImportLH = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.viewLH = new System.Windows.Forms.DataGridView();
            this.gbLH.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewLH)).BeginInit();
            this.SuspendLayout();
            // 
            // lbHoaDonTitle
            // 
            this.lbHoaDonTitle.AutoSize = true;
            this.lbHoaDonTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoaDonTitle.Location = new System.Drawing.Point(5, 5);
            this.lbHoaDonTitle.Margin = new System.Windows.Forms.Padding(5);
            this.lbHoaDonTitle.Name = "lbHoaDonTitle";
            this.lbHoaDonTitle.Size = new System.Drawing.Size(134, 25);
            this.lbHoaDonTitle.TabIndex = 0;
            this.lbHoaDonTitle.Text = "LOẠI HÀNG";
            // 
            // gbLH
            // 
            this.gbLH.Controls.Add(this.groupBox1);
            this.gbLH.Controls.Add(this.label1);
            this.gbLH.Controls.Add(this.txbMaLH);
            this.gbLH.Controls.Add(this.btnXoaLH);
            this.gbLH.Controls.Add(this.btnLuuLH);
            this.gbLH.Controls.Add(this.TenLH);
            this.gbLH.Controls.Add(this.txbTenLH);
            this.gbLH.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbLH.Location = new System.Drawing.Point(3, 39);
            this.gbLH.Name = "gbLH";
            this.gbLH.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel4.SetRowSpan(this.gbLH, 2);
            this.gbLH.Size = new System.Drawing.Size(336, 626);
            this.gbLH.TabIndex = 1;
            this.gbLH.TabStop = false;
            this.gbLH.Text = "Thông Tin Loại Hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbDungBanLH);
            this.groupBox1.Controls.Add(this.ckbLuuNhapLH);
            this.groupBox1.Controls.Add(this.ckbHienHanhLH);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(336, 326);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xem Danh Sách";
            // 
            // ckbDungBanLH
            // 
            this.ckbDungBanLH.AutoSize = true;
            this.ckbDungBanLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbDungBanLH.Location = new System.Drawing.Point(30, 96);
            this.ckbDungBanLH.Name = "ckbDungBanLH";
            this.ckbDungBanLH.Size = new System.Drawing.Size(90, 22);
            this.ckbDungBanLH.TabIndex = 2;
            this.ckbDungBanLH.Text = "Dừng bán";
            this.ckbDungBanLH.UseVisualStyleBackColor = true;
            this.ckbDungBanLH.CheckedChanged += new System.EventHandler(this.ckbDungBanLH_CheckedChanged);
            // 
            // ckbLuuNhapLH
            // 
            this.ckbLuuNhapLH.AutoSize = true;
            this.ckbLuuNhapLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbLuuNhapLH.Location = new System.Drawing.Point(30, 64);
            this.ckbLuuNhapLH.Name = "ckbLuuNhapLH";
            this.ckbLuuNhapLH.Size = new System.Drawing.Size(87, 22);
            this.ckbLuuNhapLH.TabIndex = 1;
            this.ckbLuuNhapLH.Text = "Lưu nháp";
            this.ckbLuuNhapLH.UseVisualStyleBackColor = true;
            this.ckbLuuNhapLH.CheckedChanged += new System.EventHandler(this.ckbLuuNhapLH_CheckedChanged);
            // 
            // ckbHienHanhLH
            // 
            this.ckbHienHanhLH.AutoSize = true;
            this.ckbHienHanhLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbHienHanhLH.Location = new System.Drawing.Point(30, 32);
            this.ckbHienHanhLH.Name = "ckbHienHanhLH";
            this.ckbHienHanhLH.Size = new System.Drawing.Size(93, 22);
            this.ckbHienHanhLH.TabIndex = 0;
            this.ckbHienHanhLH.Text = "Hiện hành";
            this.ckbHienHanhLH.UseVisualStyleBackColor = true;
            this.ckbHienHanhLH.CheckedChanged += new System.EventHandler(this.ckbHienHanhLH_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 51);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "1. Mã loại hàng : ";
            // 
            // txbMaLH
            // 
            this.txbMaLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaLH.Location = new System.Drawing.Point(58, 71);
            this.txbMaLH.Multiline = true;
            this.txbMaLH.Name = "txbMaLH";
            this.txbMaLH.Size = new System.Drawing.Size(222, 28);
            this.txbMaLH.TabIndex = 39;
            // 
            // btnXoaLH
            // 
            this.btnXoaLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLH.Location = new System.Drawing.Point(89, 199);
            this.btnXoaLH.Name = "btnXoaLH";
            this.btnXoaLH.Size = new System.Drawing.Size(87, 42);
            this.btnXoaLH.TabIndex = 37;
            this.btnXoaLH.Text = "Xóa";
            this.btnXoaLH.UseVisualStyleBackColor = true;
            this.btnXoaLH.Click += new System.EventHandler(this.btnXoaLH_Click);
            // 
            // btnLuuLH
            // 
            this.btnLuuLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuLH.Location = new System.Drawing.Point(193, 197);
            this.btnLuuLH.Name = "btnLuuLH";
            this.btnLuuLH.Size = new System.Drawing.Size(87, 44);
            this.btnLuuLH.TabIndex = 38;
            this.btnLuuLH.Text = "Lưu";
            this.btnLuuLH.UseVisualStyleBackColor = true;
            this.btnLuuLH.Click += new System.EventHandler(this.btnLuuLH_Click);
            // 
            // TenLH
            // 
            this.TenLH.AutoSize = true;
            this.TenLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenLH.Location = new System.Drawing.Point(17, 127);
            this.TenLH.Name = "TenLH";
            this.TenLH.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TenLH.Size = new System.Drawing.Size(112, 16);
            this.TenLH.TabIndex = 29;
            this.TenLH.Text = "2. Tên loại hàng : ";
            // 
            // txbTenLH
            // 
            this.txbTenLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenLH.Location = new System.Drawing.Point(58, 147);
            this.txbTenLH.Multiline = true;
            this.txbTenLH.Name = "txbTenLH";
            this.txbTenLH.Size = new System.Drawing.Size(222, 28);
            this.txbTenLH.TabIndex = 28;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.lbHoaDonTitle, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.gbLH, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 5);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.57319F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.081664F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.85208F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.33898F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(342, 668);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.7492F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.2508F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1532, 678);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.viewLH, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(351, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.613139F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.38686F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1178, 672);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.65461F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.61483F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.674502F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.855334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.94575F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.164557F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnImportLH, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnThem, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1172, 51);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel6.Controls.Add(this.txbTimLH, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(461, 45);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // txbTimLH
            // 
            this.txbTimLH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbTimLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTimLH.Location = new System.Drawing.Point(84, 3);
            this.txbTimLH.Multiline = true;
            this.txbTimLH.Name = "txbTimLH";
            this.txbTimLH.Size = new System.Drawing.Size(374, 39);
            this.txbTimLH.TabIndex = 0;
            this.txbTimLH.TextChanged += new System.EventHandler(this.txbTimLH_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnImportLH
            // 
            this.btnImportLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportLH.Location = new System.Drawing.Point(1062, 3);
            this.btnImportLH.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.btnImportLH.Name = "btnImportLH";
            this.btnImportLH.Size = new System.Drawing.Size(87, 44);
            this.btnImportLH.TabIndex = 6;
            this.btnImportLH.Text = "Import";
            this.btnImportLH.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(934, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 44);
            this.btnThem.TabIndex = 41;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // viewLH
            // 
            this.viewLH.AllowUserToAddRows = false;
            this.viewLH.AllowUserToDeleteRows = false;
            this.viewLH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewLH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewLH.Location = new System.Drawing.Point(10, 67);
            this.viewLH.Margin = new System.Windows.Forms.Padding(10);
            this.viewLH.Name = "viewLH";
            this.viewLH.ReadOnly = true;
            this.viewLH.RowHeadersVisible = false;
            this.viewLH.Size = new System.Drawing.Size(1158, 595);
            this.viewLH.TabIndex = 6;
            this.viewLH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewLH_CellContentClick);
            this.viewLH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewLH_CellContentClick);
            this.viewLH.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.viewLH_CellFormatting);
            // 
            // fLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 678);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "fLoaiHang";
            this.Text = "fLoaiHang";
            this.Load += new System.EventHandler(this.fLoaiHang_Load);
            this.gbLH.ResumeLayout(false);
            this.gbLH.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewLH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbHoaDonTitle;
        private System.Windows.Forms.GroupBox gbLH;
        private System.Windows.Forms.Button btnLuuLH;
        private System.Windows.Forms.Label TenLH;
        private System.Windows.Forms.TextBox txbTenLH;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox txbTimLH;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnImportLH;
        private System.Windows.Forms.Button btnXoaLH;
        private System.Windows.Forms.DataGridView viewLH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMaLH;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbDungBanLH;
        private System.Windows.Forms.CheckBox ckbLuuNhapLH;
        private System.Windows.Forms.CheckBox ckbHienHanhLH;
    }
}