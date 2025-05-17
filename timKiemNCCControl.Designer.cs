
namespace BTL_QuanLyBanThuoc
{
    partial class timKiemNCCControl
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
            this.lbTenNCC = new System.Windows.Forms.Label();
            this.lbMaNCC = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTenNCC
            // 
            this.lbTenNCC.AutoSize = true;
            this.lbTenNCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTenNCC.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNCC.ForeColor = System.Drawing.Color.Black;
            this.lbTenNCC.Location = new System.Drawing.Point(20, 5);
            this.lbTenNCC.Name = "lbTenNCC";
            this.lbTenNCC.Size = new System.Drawing.Size(52, 19);
            this.lbTenNCC.TabIndex = 6;
            this.lbTenNCC.Text = "label1";
            // 
            // lbMaNCC
            // 
            this.lbMaNCC.AutoSize = true;
            this.lbMaNCC.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbMaNCC.Font = new System.Drawing.Font("Inter", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNCC.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbMaNCC.Location = new System.Drawing.Point(0, 0);
            this.lbMaNCC.Name = "lbMaNCC";
            this.lbMaNCC.Size = new System.Drawing.Size(43, 16);
            this.lbMaNCC.TabIndex = 0;
            this.lbMaNCC.Text = "label1";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbSDT.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(97)))), ((int)(((byte)(214)))));
            this.lbSDT.Location = new System.Drawing.Point(422, 5);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(52, 19);
            this.lbSDT.TabIndex = 8;
            this.lbSDT.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbMaNCC);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 22);
            this.panel1.TabIndex = 7;
            // 
            // timKiemNCCControl
            // 
            this.Controls.Add(this.lbTenNCC);
            this.Controls.Add(this.lbSDT);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "timKiemNCCControl";
            this.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.Size = new System.Drawing.Size(494, 54);
            this.Load += new System.EventHandler(this.timKiemNCCControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTenNCC;
        private System.Windows.Forms.Label lbMaNCC;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Panel panel1;
    }
}
