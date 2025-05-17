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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = NCC.SearchHangTheoNCC(txtTim.Text);
            if (dataGridView1.RowCount == 0)
                MessageBox.Show("Không tìm thấy !");
        }
    }
}
