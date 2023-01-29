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
    public partial class frmKhachHang : Form
    {
        DataTable tblKH;
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            txtMaKH.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            LoadDataGridView(); //Hiển thị bảng KHACHHANG
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MAKH, TENKH, SDT, DIACHI FROM KHACHHANG";
            tblKH = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvKH.DataSource = tblKH; //Nguồn dữ liệu            
            dgvKH.Columns[0].HeaderText = "Mã Khách Hàng";
            dgvKH.Columns[1].HeaderText = "Tên Khách Hàng";
            dgvKH.Columns[2].HeaderText = "Số Điện Thoại";
            dgvKH.Columns[3].HeaderText = "Địa Chỉ";
            dgvKH.Columns[0].Width = 110;
            dgvKH.Columns[1].Width = 200;
            dgvKH.Columns[2].Width = 100;
            dgvKH.Columns[3].Width = 300;
            dgvKH.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvKH.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void dgvKH_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKH.Focus();
                return;
            }
            if (tblKH.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaKH.Text = dgvKH.CurrentRow.Cells["MAKH"].Value.ToString();
            txtTenKH.Text = dgvKH.CurrentRow.Cells["TENKH"].Value.ToString();
            txtSDT.Text = dgvKH.CurrentRow.Cells["SDT"].Value.ToString();
            txtDiaChi.Text = dgvKH.CurrentRow.Cells["DIACHI"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValue(); //Xoá trắng các textbox
            txtMaKH.Enabled = true; //cho phép nhập mới
            txtMaKH.Focus();
        }
        private void ResetValue()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Luu lệnh sql
            if (txtMaKH.Text.Trim().Length == 0) //Nếu chua nhập mã khách hàng
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKH.Focus();
                return;
            }
            if (txtTenKH.Text.Trim().Length == 0) //N?u chua nhập tên khách hàng
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKH.Focus();
                return;
            }
            if (txtSDT.Text.Trim().Length == 0) //Nếu chua nhập SDT
            {
                MessageBox.Show("Bạn phải nhập số diện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0) //Nếu chua nhập dịa chỉ
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }
            sql = "Select MAKH From KHACHHANG where MAKH=N'" + txtMaKH.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã khách hàng này dã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKH.Focus();
                return;
            }

            sql = "INSERT INTO KHACHHANG VALUES(N'" +
                txtMaKH.Text + "',N'" + txtTenKH.Text + "',N'" + txtSDT.Text + "',N'" + txtDiaChi.Text + "')";
            Class.Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaKH.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Luu câu lệnh sql
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaKH.Text == "") //nếu chua chọn bản ghi nào
            {
                MessageBox.Show("Bạn chua chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenKH.Text.Trim().Length == 0) //nếu chua nhập tên khách hàng
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtSDT.Text.Trim().Length == 0) //nếu chua nhập SÐT
            {
                MessageBox.Show("Bạn chua nhập số diện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0) //nếu chua nhập địa chỉ
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE KHACHHANG SET  TENKH=N'" + txtTenKH.Text.Trim().ToString() +
                  "',SDT=N'" + txtSDT.Text.Trim().ToString() +
                  "',DIACHI=N'" + txtDiaChi.Text.Trim().ToString() +
                  "' WHERE MAKH=N'" + txtMaKH.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();

            btnHuy.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaKH.Text == "") //nếu chua chọn bản ghi nào
            {
                MessageBox.Show("Bạn chua chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE KHACHHANG WHERE MAKH=N'" + txtMaKH.Text + "'";
                Class.Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValue();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaKH.Enabled = false;
        }
    }
}
