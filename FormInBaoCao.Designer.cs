
namespace BTL_QuanLyBanThuoc
{
    partial class FormInBaoCao
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
            this.CrystalReportView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.inPhieuNhap1 = new BTL_QuanLyBanThuoc.InPhieuNhap();
            this.SuspendLayout();
            // 
            // CrystalReportView
            // 
            this.CrystalReportView.ActiveViewIndex = 0;
            this.CrystalReportView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrystalReportView.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrystalReportView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrystalReportView.Location = new System.Drawing.Point(0, 0);
            this.CrystalReportView.Name = "CrystalReportView";
            this.CrystalReportView.ReportSource = this.inPhieuNhap1;
            this.CrystalReportView.Size = new System.Drawing.Size(957, 655);
            this.CrystalReportView.TabIndex = 0;
            // 
            // FormInBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 655);
            this.Controls.Add(this.CrystalReportView);
            this.Name = "FormInBaoCao";
            this.Text = "FormInBaoCao";
            this.Load += new System.EventHandler(this.FormInBaoCao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrystalReportView;
        private InPhieuNhap inPhieuNhap1;
    }
}