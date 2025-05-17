
namespace BTL_QuanLyBanThuoc
{
    partial class timKiemMHPNControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTenHang = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.lbMaHang = new System.Windows.Forms.Label();
            this.lbGiaNhap = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTenHang
            // 
            this.lbTenHang.AutoSize = true;
            this.lbTenHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenHang.ForeColor = System.Drawing.Color.Black;
            this.lbTenHang.Location = new System.Drawing.Point(20, 5);
            this.lbTenHang.Name = "lbTenHang";
            this.lbTenHang.Size = new System.Drawing.Size(52, 18);
            this.lbTenHang.TabIndex = 3;
            this.lbTenHang.Text = "label1";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuong.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbSoLuong.Location = new System.Drawing.Point(409, 0);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(45, 16);
            this.lbSoLuong.TabIndex = 1;
            this.lbSoLuong.Text = "label1";
            // 
            // lbMaHang
            // 
            this.lbMaHang.AutoSize = true;
            this.lbMaHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHang.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbMaHang.Location = new System.Drawing.Point(0, 0);
            this.lbMaHang.Name = "lbMaHang";
            this.lbMaHang.Size = new System.Drawing.Size(45, 16);
            this.lbMaHang.TabIndex = 0;
            this.lbMaHang.Text = "label1";
            // 
            // lbGiaNhap
            // 
            this.lbGiaNhap.AutoSize = true;
            this.lbGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(97)))), ((int)(((byte)(214)))));
            this.lbGiaNhap.Location = new System.Drawing.Point(422, 5);
            this.lbGiaNhap.Name = "lbGiaNhap";
            this.lbGiaNhap.Size = new System.Drawing.Size(52, 18);
            this.lbGiaNhap.TabIndex = 5;
            this.lbGiaNhap.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbSoLuong);
            this.panel1.Controls.Add(this.lbMaHang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 22);
            this.panel1.TabIndex = 1;
            // 
            // timKiemMHPNControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbTenHang);
            this.Controls.Add(this.lbGiaNhap);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "timKiemMHPNControl";
            this.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.Size = new System.Drawing.Size(494, 54);
            this.Load += new System.EventHandler(this.timKiemMHPNControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTenHang;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label lbMaHang;
        private System.Windows.Forms.Label lbGiaNhap;
        private System.Windows.Forms.Panel panel1;
    }
}
