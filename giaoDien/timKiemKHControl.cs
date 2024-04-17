using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLyBanThuoc.giaoDien
{
    public partial class timKiemKHControl : UserControl
    {
        public timKiemKHControl()
        {
            InitializeComponent();
            // Gán cùng một event handler cho các control tương ứng
            lbTenKhach.Click += Control_Click;
            panel1.Click += Control_Click;
            lbMaKhach.Click += Control_Click;
            lbSDT.Click += Control_Click;

            // Gán event handler cho sự kiện MouseHover và MouseLeave của panel1 và lbSDT
            panel1.MouseHover += Control_MouseHover;
            panel1.MouseLeave += Control_MouseLeave;
            lbSDT.MouseHover += Control_MouseHover;
            lbSDT.MouseLeave += Control_MouseLeave;
            lbMaKhach.MouseHover += Control_MouseHover;
            lbMaKhach.MouseLeave += Control_MouseLeave;
            lbTenKhach.MouseHover += Control_MouseHover;
            lbTenKhach.MouseLeave += Control_MouseLeave;
        }

        public static string maKhach;
        public static string tenKhach;
        public static bool chonKhach = false;

        // Truyền thông tin từ KhachHang vào Control
        public void thongTin(KhachHang khachHang)
        {
            lbMaKhach.Text = khachHang.sMaKH;
            lbTenKhach.Text = khachHang.sTenKH;
            lbSDT.Text = khachHang.sSDT;
        }

        public void kqTimKiem(string timKiem)
        {
            // Tạo object KhachHang và tìm kiếm trong SQL theo ô tìm kiếm truyền vào
            KhachHang get = new KhachHang();
            get.SearchKhachHang(timKiem);

            // get đã chứa thông tin của object đó, gán thông tin object đó vào userControl timKiemControl
            // lbMaKhach.Text = get.sMaKH;
            // lbTenKhach.Text = get.sTenKH;
            // lbSDT.Text = get.sSDT;
        }

        private void Control_Click(object sender, EventArgs e)
        {
            chonKhach = true;
            maKhach = lbMaKhach.Text;
            tenKhach = lbTenKhach.Text;
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
            lbTenKhach.Click += handler;
            panel1.Click += handler;
            lbMaKhach.Click += handler;
            lbSDT.Click += handler;
        }

    }
}
