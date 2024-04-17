using BTL_QuanLyBanThuoc.Code;
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
    public partial class timKiemMHControl : UserControl
    {
        public timKiemMHControl()
        {
            InitializeComponent();
            // Gán cùng một event handler cho các control tương ứng
            lbTenHang.Click += Control_Click;
            panel1.Click += Control_Click;
            lbMaHang.Click += Control_Click;
            lbSoLuong.Click += Control_Click;
            lbGiaHang.Click += Control_Click;

            // Gán event handler cho sự kiện MouseHover và MouseLeave của panel1 và lbGiaHang
            panel1.MouseHover += Control_MouseHover;
            //panel1.MouseLeave += Control_MouseLeave;
            lbGiaHang.MouseHover += Control_MouseHover;
            //lbGiaHang.MouseLeave += Control_MouseLeave;
            lbSoLuong.MouseHover += Control_MouseHover;
            //lbSoLuong.MouseLeave += Control_MouseLeave;
            lbMaHang.MouseHover += Control_MouseHover;
            //lbMaHang.MouseLeave += Control_MouseLeave;
            lbTenHang.MouseHover += Control_MouseHover;
            //lbTenHang.MouseLeave += Control_MouseLeave;
        }
        public static string maHang;
        public static string tenHang;
        public static bool chon = false;

        //Truyền thông tin từ MatHang vào Control
        public void thongTin(MatHang mh)
        {
            lbMaHang.Text = mh.sMaHang;
            lbTenHang.Text = mh.sTenHang;
            lbSoLuong.Text = "Tồn: "+Convert.ToString(mh.iSoLuong);
            lbGiaHang.Text = Convert.ToString(mh.fDonGia);
        }

        public void kqTimKiem(string timKiem)
        {
            //Tạo object MatHang và tìm kiếm trong SQL theo ô tìm kiếm truyền vào
            MatHang get = new MatHang();
            get.SearchMatHang(dbConnect.ConnectionString,timKiem);

            //get đã chứa thông tin của object đó, gán thông tin object đó vào userControl timKiemControl
            //lbMaHang.Text = get.sMaHang;
            //lbTenHang.Text = get.sTenHang;
            //lbSoLuong.Text = Convert.ToString(get.iSoLuong);
        }
        private void Control_Click(object sender, EventArgs e)
        {
            chon = true;
            maHang = lbMaHang.Text;
            tenHang = lbTenHang.Text;
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
            lbTenHang.Click += handler;
            panel1.Click += handler;
            lbMaHang.Click += handler;
            lbSoLuong.Click += handler;
            lbGiaHang.Click += handler;
        }
    }
}
