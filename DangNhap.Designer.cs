
namespace BTL_QuanLyBanThuoc
{
    partial class DangNhap
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
            this.QuanLyKhoThuocTay = new System.Windows.Forms.Label();
            this.txbMaNV = new System.Windows.Forms.TextBox();
            this.txtPasswordDN = new System.Windows.Forms.TextBox();
            this.sMaNV = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.linkDK = new System.Windows.Forms.LinkLabel();
            this.ckbXemPw = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // QuanLyKhoThuocTay
            // 
            this.QuanLyKhoThuocTay.AutoSize = true;
            this.QuanLyKhoThuocTay.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanLyKhoThuocTay.Location = new System.Drawing.Point(229, 69);
            this.QuanLyKhoThuocTay.Name = "QuanLyKhoThuocTay";
            this.QuanLyKhoThuocTay.Size = new System.Drawing.Size(287, 24);
            this.QuanLyKhoThuocTay.TabIndex = 0;
            this.QuanLyKhoThuocTay.Text = "QUẢN LÝ KHO THUỐC TÂY";
            // 
            // txbMaNV
            // 
            this.txbMaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaNV.Location = new System.Drawing.Point(332, 130);
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(211, 26);
            this.txbMaNV.TabIndex = 1;
            // 
            // txtPasswordDN
            // 
            this.txtPasswordDN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordDN.Location = new System.Drawing.Point(332, 186);
            this.txtPasswordDN.Name = "txtPasswordDN";
            this.txtPasswordDN.PasswordChar = '*';
            this.txtPasswordDN.Size = new System.Drawing.Size(211, 26);
            this.txtPasswordDN.TabIndex = 2;
            // 
            // sMaNV
            // 
            this.sMaNV.AutoSize = true;
            this.sMaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sMaNV.Location = new System.Drawing.Point(218, 133);
            this.sMaNV.Name = "sMaNV";
            this.sMaNV.Size = new System.Drawing.Size(97, 19);
            this.sMaNV.TabIndex = 4;
            this.sMaNV.Text = "Mã nhân viên :";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(220, 188);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(76, 19);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password :";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(339, 234);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(99, 38);
            this.btnDangNhap.TabIndex = 7;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // linkDK
            // 
            this.linkDK.AutoSize = true;
            this.linkDK.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkDK.Location = new System.Drawing.Point(280, 287);
            this.linkDK.Name = "linkDK";
            this.linkDK.Size = new System.Drawing.Size(201, 17);
            this.linkDK.TabIndex = 8;
            this.linkDK.TabStop = true;
            this.linkDK.Text = "Bạn chưa có tài khoản? Đăng ký";
            this.linkDK.Visible = false;
            this.linkDK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDK_LinkClicked);
            // 
            // ckbXemPw
            // 
            this.ckbXemPw.AutoSize = true;
            this.ckbXemPw.Location = new System.Drawing.Point(522, 192);
            this.ckbXemPw.Name = "ckbXemPw";
            this.ckbXemPw.Size = new System.Drawing.Size(15, 14);
            this.ckbXemPw.TabIndex = 9;
            this.ckbXemPw.UseVisualStyleBackColor = true;
            this.ckbXemPw.CheckedChanged += new System.EventHandler(this.ckbXemPw_CheckedChanged);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ckbXemPw);
            this.Controls.Add(this.linkDK);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.sMaNV);
            this.Controls.Add(this.txtPasswordDN);
            this.Controls.Add(this.txbMaNV);
            this.Controls.Add(this.QuanLyKhoThuocTay);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuanLyKhoThuocTay;
        private System.Windows.Forms.TextBox txbMaNV;
        private System.Windows.Forms.TextBox txtPasswordDN;
        private System.Windows.Forms.Label sMaNV;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.LinkLabel linkDK;
        private System.Windows.Forms.CheckBox ckbXemPw;
    }
}