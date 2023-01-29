using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyBanHang.Class;

namespace QuanLyBanHang
{
    public partial class frmThongKe : Form
    {
        DataTable tblTK;
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            //LoadDataGridView(); //Hiển thị bảng KHACHHANG
        }
        private void LoadDataGridView()
        {
             /*string sql;
             sql = "SELECT MAHD, MANV, MAKH, TONGTIEN, NGAYTAOHD FROM HOADON";
             tblTK = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
             dgvThongKe.DataSource = tblTK; //Nguồn dữ liệu            
             dgvThongKe.Columns[0].HeaderText = "Mã Hoá Đơn";
             dgvThongKe.Columns[1].HeaderText = "Mã Nhân Viên";
             dgvThongKe.Columns[2].HeaderText = "Mã Khách Hàng";
             dgvThongKe.Columns[3].HeaderText = "Tổng Tiền (VNĐ)";
             dgvThongKe.Columns[4].HeaderText = "Ngày Tạo Hoá Đơn";
             dgvThongKe.Columns[0].Width = 110;
             dgvThongKe.Columns[1].Width = 200;
             dgvThongKe.Columns[2].Width = 100;
             dgvThongKe.Columns[3].Width = 100;
             dgvThongKe.Columns[4].Width = 100;
             dgvThongKe.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
             dgvThongKe.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
             */
        }
       
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT MAHD, MANV, MAKH, TONGTIEN, NGAYTAOHD FROM HOADON WHERE NGAYTAOHD >= N'" + dtpTu.Value.ToString("MM/dd/yyyy") + "'AND NGAYTAOHD <= N'" + dtpDen.Value.ToString("MM/dd/yyyy") + "'";
            tblTK = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvThongKe.DataSource = tblTK; //Nguồn dữ liệu            
            dgvThongKe.Columns[0].HeaderText = "Mã Hoá Đơn";
            dgvThongKe.Columns[1].HeaderText = "Mã Nhân Viên";
            dgvThongKe.Columns[2].HeaderText = "Mã Khách Hàng";
            dgvThongKe.Columns[3].HeaderText = "Tổng Tiền (VNĐ)";
            dgvThongKe.Columns[4].HeaderText = "Ngày Tạo Hoá Đơn";
            dgvThongKe.Columns[0].Width = 130;
            dgvThongKe.Columns[1].Width = 170;
            dgvThongKe.Columns[2].Width = 170;
            dgvThongKe.Columns[3].Width = 100;
            dgvThongKe.Columns[4].Width = 100;
            dgvThongKe.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvThongKe.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
            LoadDataGridView();
            int tien = dgvThongKe.Rows.Count;
            double thanhtien = 0;
            for (int i = 0; i < tien; i++)
            {
                thanhtien += double.Parse(dgvThongKe.Rows[i].Cells["TONGTIEN"].Value.ToString());
            }
            txtTongHD.Text = thanhtien.ToString();
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            string sql;

            sql = "SELECT MAHD, MANV, MAKH, TONGTIEN, NGAYTAOHD FROM HOADON";
             tblTK = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
             dgvThongKe.DataSource = tblTK; //Nguồn dữ liệu            
             dgvThongKe.Columns[0].HeaderText = "Mã Hoá Đơn";
             dgvThongKe.Columns[1].HeaderText = "Mã Nhân Viên";
             dgvThongKe.Columns[2].HeaderText = "Mã Khách Hàng";
             dgvThongKe.Columns[3].HeaderText = "Tổng Tiền (VNĐ)";
             dgvThongKe.Columns[4].HeaderText = "Ngày Tạo Hoá Đơn";
             dgvThongKe.Columns[0].Width = 130;
             dgvThongKe.Columns[1].Width = 170;
             dgvThongKe.Columns[2].Width = 170;
             dgvThongKe.Columns[3].Width = 100;
             dgvThongKe.Columns[4].Width = 100;
             dgvThongKe.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
             dgvThongKe.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
             LoadDataGridView();
             int tien = dgvThongKe.Rows.Count;
             double thanhtien = 0;
             for (int i = 0; i < tien; i++)
             {
                 thanhtien += double.Parse(dgvThongKe.Rows[i].Cells["TONGTIEN"].Value.ToString());
             }
             txtTongHD.Text = thanhtien.ToString();
        }
    }
}
