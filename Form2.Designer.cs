
namespace BTL_QuanLyBanThuoc
{
    partial class Form2
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
            this.cbo = new System.Windows.Forms.ComboBox();
            this.tblNhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyKhoThuocTayDataSet2 = new BTL_QuanLyBanThuoc.QuanLyKhoThuocTayDataSet2();
            this.cachedBaoCaoHangHoaNhapXuat1 = new BTL_QuanLyBanThuoc.CachedBaoCaoHangHoaNhapXuat();
            this.tblNhaCungCapTableAdapter = new BTL_QuanLyBanThuoc.QuanLyKhoThuocTayDataSet2TableAdapters.tblNhaCungCapTableAdapter();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReportNCC_Hang1 = new BTL_QuanLyBanThuoc.CrystalReportNCC_Hang();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhaCungCapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoThuocTayDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo
            // 
            this.cbo.DataSource = this.tblNhaCungCapBindingSource;
            this.cbo.DisplayMember = "sMaNCC";
            this.cbo.FormattingEnabled = true;
            this.cbo.Location = new System.Drawing.Point(25, 25);
            this.cbo.Name = "cbo";
            this.cbo.Size = new System.Drawing.Size(242, 21);
            this.cbo.TabIndex = 0;
            this.cbo.ValueMember = "sMaNCC";
            this.cbo.SelectedIndexChanged += new System.EventHandler(this.cbo_SelectedIndexChanged);
            // 
            // tblNhaCungCapBindingSource
            // 
            this.tblNhaCungCapBindingSource.DataMember = "tblNhaCungCap";
            this.tblNhaCungCapBindingSource.DataSource = this.quanLyKhoThuocTayDataSet2;
            // 
            // quanLyKhoThuocTayDataSet2
            // 
            this.quanLyKhoThuocTayDataSet2.DataSetName = "QuanLyKhoThuocTayDataSet2";
            this.quanLyKhoThuocTayDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblNhaCungCapTableAdapter
            // 
            this.tblNhaCungCapTableAdapter.ClearBeforeFill = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 76);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.CrystalReportNCC_Hang1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(885, 518);
            this.crystalReportViewer1.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 594);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.cbo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblNhaCungCapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoThuocTayDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo;
        private CachedBaoCaoHangHoaNhapXuat cachedBaoCaoHangHoaNhapXuat1;
        private QuanLyKhoThuocTayDataSet2 quanLyKhoThuocTayDataSet2;
        private System.Windows.Forms.BindingSource tblNhaCungCapBindingSource;
        private QuanLyKhoThuocTayDataSet2TableAdapters.tblNhaCungCapTableAdapter tblNhaCungCapTableAdapter;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalReportNCC_Hang CrystalReportNCC_Hang1;
    }
}