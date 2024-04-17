
namespace BTL_QuanLyBanThuoc
{
    partial class ThongKeChucVu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quanLyKhoThuocTayDataSet1 = new BTL_QuanLyBanThuoc.QuanLyKhoThuocTayDataSet1();
            this.tblNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblNhanVienTableAdapter = new BTL_QuanLyBanThuoc.QuanLyKhoThuocTayDataSet1TableAdapters.tblNhanVienTableAdapter();
            this.sMaNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sChucVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDiaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgayVaoLamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoThuocTayDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaNVDataGridViewTextBoxColumn,
            this.sTenNVDataGridViewTextBoxColumn,
            this.iGioiTinhDataGridViewTextBoxColumn,
            this.dNgaySinhDataGridViewTextBoxColumn,
            this.sChucVuDataGridViewTextBoxColumn,
            this.sDiaChiDataGridViewTextBoxColumn,
            this.dNgayVaoLamDataGridViewTextBoxColumn,
            this.sSDTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblNhanVienBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // quanLyKhoThuocTayDataSet1
            // 
            this.quanLyKhoThuocTayDataSet1.DataSetName = "QuanLyKhoThuocTayDataSet1";
            this.quanLyKhoThuocTayDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblNhanVienBindingSource
            // 
            this.tblNhanVienBindingSource.DataMember = "tblNhanVien";
            this.tblNhanVienBindingSource.DataSource = this.quanLyKhoThuocTayDataSet1;
            // 
            // tblNhanVienTableAdapter
            // 
            this.tblNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // sMaNVDataGridViewTextBoxColumn
            // 
            this.sMaNVDataGridViewTextBoxColumn.DataPropertyName = "sMaNV";
            this.sMaNVDataGridViewTextBoxColumn.HeaderText = "sMaNV";
            this.sMaNVDataGridViewTextBoxColumn.Name = "sMaNVDataGridViewTextBoxColumn";
            // 
            // sTenNVDataGridViewTextBoxColumn
            // 
            this.sTenNVDataGridViewTextBoxColumn.DataPropertyName = "sTenNV";
            this.sTenNVDataGridViewTextBoxColumn.HeaderText = "sTenNV";
            this.sTenNVDataGridViewTextBoxColumn.Name = "sTenNVDataGridViewTextBoxColumn";
            // 
            // iGioiTinhDataGridViewTextBoxColumn
            // 
            this.iGioiTinhDataGridViewTextBoxColumn.DataPropertyName = "iGioiTinh";
            this.iGioiTinhDataGridViewTextBoxColumn.HeaderText = "iGioiTinh";
            this.iGioiTinhDataGridViewTextBoxColumn.Name = "iGioiTinhDataGridViewTextBoxColumn";
            // 
            // dNgaySinhDataGridViewTextBoxColumn
            // 
            this.dNgaySinhDataGridViewTextBoxColumn.DataPropertyName = "dNgaySinh";
            this.dNgaySinhDataGridViewTextBoxColumn.HeaderText = "dNgaySinh";
            this.dNgaySinhDataGridViewTextBoxColumn.Name = "dNgaySinhDataGridViewTextBoxColumn";
            // 
            // sChucVuDataGridViewTextBoxColumn
            // 
            this.sChucVuDataGridViewTextBoxColumn.DataPropertyName = "sChucVu";
            this.sChucVuDataGridViewTextBoxColumn.HeaderText = "sChucVu";
            this.sChucVuDataGridViewTextBoxColumn.Name = "sChucVuDataGridViewTextBoxColumn";
            // 
            // sDiaChiDataGridViewTextBoxColumn
            // 
            this.sDiaChiDataGridViewTextBoxColumn.DataPropertyName = "sDiaChi";
            this.sDiaChiDataGridViewTextBoxColumn.HeaderText = "sDiaChi";
            this.sDiaChiDataGridViewTextBoxColumn.Name = "sDiaChiDataGridViewTextBoxColumn";
            // 
            // dNgayVaoLamDataGridViewTextBoxColumn
            // 
            this.dNgayVaoLamDataGridViewTextBoxColumn.DataPropertyName = "dNgayVaoLam";
            this.dNgayVaoLamDataGridViewTextBoxColumn.HeaderText = "dNgayVaoLam";
            this.dNgayVaoLamDataGridViewTextBoxColumn.Name = "dNgayVaoLamDataGridViewTextBoxColumn";
            // 
            // sSDTDataGridViewTextBoxColumn
            // 
            this.sSDTDataGridViewTextBoxColumn.DataPropertyName = "sSDT";
            this.sSDTDataGridViewTextBoxColumn.HeaderText = "sSDT";
            this.sSDTDataGridViewTextBoxColumn.Name = "sSDTDataGridViewTextBoxColumn";
            // 
            // ThongKeChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ThongKeChucVu";
            this.Text = "ThongKeChucVu";
            this.Load += new System.EventHandler(this.ThongKeChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoThuocTayDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private QuanLyKhoThuocTayDataSet1 quanLyKhoThuocTayDataSet1;
        private System.Windows.Forms.BindingSource tblNhanVienBindingSource;
        private QuanLyKhoThuocTayDataSet1TableAdapters.tblNhanVienTableAdapter tblNhanVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sChucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgayVaoLamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSDTDataGridViewTextBoxColumn;
    }
}