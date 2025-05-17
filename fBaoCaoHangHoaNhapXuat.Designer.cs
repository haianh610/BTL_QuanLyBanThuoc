
namespace BTL_QuanLyBanThuoc
{
    partial class fBaoCaoHangHoaNhapXuat
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
            this.BCHangHoaNhapXuat = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txbNguoiLapBC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.btnFinish = new System.Windows.Forms.Button();
            this.BaoCaoHangHoaNhapXuat1 = new BTL_QuanLyBanThuoc.BaoCaoHangHoaNhapXuat();
            this.SuspendLayout();
            // 
            // BCHangHoaNhapXuat
            // 
            this.BCHangHoaNhapXuat.ActiveViewIndex = -1;
            this.BCHangHoaNhapXuat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BCHangHoaNhapXuat.Cursor = System.Windows.Forms.Cursors.Default;
            this.BCHangHoaNhapXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.BCHangHoaNhapXuat.Location = new System.Drawing.Point(0, 0);
            this.BCHangHoaNhapXuat.Name = "BCHangHoaNhapXuat";
            this.BCHangHoaNhapXuat.Size = new System.Drawing.Size(1350, 865);
            this.BCHangHoaNhapXuat.TabIndex = 0;
            this.BCHangHoaNhapXuat.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // txbNguoiLapBC
            // 
            this.txbNguoiLapBC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNguoiLapBC.Location = new System.Drawing.Point(400, 893);
            this.txbNguoiLapBC.Multiline = true;
            this.txbNguoiLapBC.Name = "txbNguoiLapBC";
            this.txbNguoiLapBC.Size = new System.Drawing.Size(276, 31);
            this.txbNguoiLapBC.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 901);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Người lập :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 930);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày bắt đầu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(280, 961);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày kết thúc :";
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.CausesValidation = false;
            this.dtpNgayBD.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBD.Location = new System.Drawing.Point(400, 928);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(139, 26);
            this.dtpNgayBD.TabIndex = 5;
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKT.Location = new System.Drawing.Point(400, 959);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(139, 26);
            this.dtpNgayKT.TabIndex = 6;
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(1054, 937);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(78, 43);
            this.btnFinish.TabIndex = 7;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // fBaoCaoHangHoaNhapXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 1061);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.dtpNgayKT);
            this.Controls.Add(this.dtpNgayBD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNguoiLapBC);
            this.Controls.Add(this.BCHangHoaNhapXuat);
            this.Name = "fBaoCaoHangHoaNhapXuat";
            this.Text = "fBaoCaoHangHoaNhapXuat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer BCHangHoaNhapXuat;
        private BaoCaoHangHoaNhapXuat BaoCaoHangHoaNhapXuat1;
        private System.Windows.Forms.TextBox txbNguoiLapBC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.Button btnFinish;
    }
}