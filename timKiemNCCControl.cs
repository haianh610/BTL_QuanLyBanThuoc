using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BTL_QuanLyBanThuoc
{
    public partial class timKiemNCCControl : UserControl
    {
        public timKiemNCCControl()
        {
            InitializeComponent();
            // Gán cùng một event handler cho các control tương ứng
            lbTenNCC.Click += Control_Click;
            panel1.Click += Control_Click;
            lbMaNCC.Click += Control_Click;
            lbSDT.Click += Control_Click;

            // Gán event handler cho sự kiện MouseHover và MouseLeave của panel1 và lbSDT
            panel1.MouseHover += Control_MouseHover;
            panel1.MouseLeave += Control_MouseLeave;
            lbSDT.MouseHover += Control_MouseHover;
            lbSDT.MouseLeave += Control_MouseLeave;
            lbMaNCC.MouseHover += Control_MouseHover;
            lbMaNCC.MouseLeave += Control_MouseLeave;
            lbTenNCC.MouseHover += Control_MouseHover;
            lbTenNCC.MouseLeave += Control_MouseLeave;
        }

        public static string maNCC;
        public static string tenNCC;
        public static bool chonNCC = false;
        // Truyền thông tin từ NCC vào Control
        public void thongTin(NCC nhacungcap)
        {
            lbMaNCC.Text = nhacungcap.sMaNCC;
            lbTenNCC.Text = nhacungcap.sTenNCC;
            lbSDT.Text = nhacungcap.sSDT;
        }
        public void kqTimKiem(string timKiem)
        {
            // Tạo object KhachHang và tìm kiếm trong SQL theo ô tìm kiếm truyền vào
            NCC get = new NCC();
            get.SearchKhachHang(timKiem);

        }
        private void Control_Click(object sender, EventArgs e)
        {
            chonNCC = true;
            maNCC = lbMaNCC.Text;
            tenNCC = lbTenNCC.Text;
        }

        private void Control_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
        public void SubscribeToButtonClickEvent(EventHandler handler)
        {
            panel1.Click += handler;
            lbTenNCC.Click += handler;
            panel1.Click += handler;
            lbMaNCC.Click += handler;
            lbSDT.Click += handler;
        }
        private void timKiemNCCControl_Load(object sender, EventArgs e)
        {

        }
    }
}
