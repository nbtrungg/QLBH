using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.Class;

namespace QuanLyBanHang
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            Functions.Connect();  //Mở kết nối
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Functions.Disconnect(); //Đóng kết nối
            Application.Exit(); //Thoát
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            // Xóa hết controls đang tồn tại trong pnlContain (nếu có)
            this.panel2.Controls.Clear();
            frm.TopLevel = false;

            // Gắn vào panel
            this.panel2.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            // Hiển thị form
            frm.Show();

        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            // Xóa hết controls đang tồn tại trong pnlContain (nếu có)
            this.panel2.Controls.Clear();
            frm.TopLevel = false;

            // Gắn vào panel
            this.panel2.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            // Hiển thị form
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            frmHangHoa frm = new frmHangHoa();
            // Xóa hết controls đang tồn tại trong pnlContain (nếu có)
            this.panel2.Controls.Clear();
            frm.TopLevel = false;

            // Gắn vào panel
            this.panel2.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            // Hiển thị form
            frm.Show();
        }

        private void mnuThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe frm = new frmThongKe();
            // Xóa hết controls đang tồn tại trong pnlContain (nếu có)
            this.panel2.Controls.Clear();
            frm.TopLevel = false;

            // Gắn vào panel
            this.panel2.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            // Hiển thị form
            frm.Show();
        }

        private void mnuBanHang_Click(object sender, EventArgs e)
        {
            frmBanHang frm = new frmBanHang();
            // Xóa hết controls đang tồn tại trong pnlContain (nếu có)
            this.panel2.Controls.Clear();
            frm.TopLevel = false;
            // Gắn vào panel
            this.panel2.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            // Hiển thị form
            frm.Show();
        }
    }
}
