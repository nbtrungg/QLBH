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
    public partial class frmNhanVien : Form
    {
        DataTable tblNV;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            LoadDataGridView(); //Hiển thị bảng NHANVIEN
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MANV, TENNV, CMND, CHUCVU FROM NHANVIEN";
            tblNV = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvNhanVien.DataSource = tblNV; //Nguồn dữ liệu            
            dgvNhanVien.Columns[0].HeaderText = "Mã Nhân Viên";
            dgvNhanVien.Columns[1].HeaderText = "Tên Nhân Viên";
            dgvNhanVien.Columns[2].HeaderText = "CMND";
            dgvNhanVien.Columns[3].HeaderText = "Chức Vụ";
            dgvNhanVien.Columns[0].Width = 100;
            dgvNhanVien.Columns[1].Width = 200;
            dgvNhanVien.Columns[2].Width = 180;
            dgvNhanVien.Columns[3].Width = 180;
            dgvNhanVien.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvNhanVien.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Focus();
                return;
            }
            if (tblNV.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaNV.Text = dgvNhanVien.CurrentRow.Cells["MANV"].Value.ToString();
            txtTenNV.Text = dgvNhanVien.CurrentRow.Cells["TENNV"].Value.ToString();
            txtCMND.Text = dgvNhanVien.CurrentRow.Cells["CMND"].Value.ToString();
            txtChucVu.Text = dgvNhanVien.CurrentRow.Cells["CHUCVU"].Value.ToString();
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
            txtMaNV.Enabled = true; //cho phép nhập mới
            txtMaNV.Focus();
        }
        private void ResetValue()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtCMND.Text = "";
            txtChucVu.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaNV.Text.Trim().Length == 0) //Nếu chưa nhập mã nhân viên
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Focus();
                return;
            }
            if (txtTenNV.Text.Trim().Length == 0) //Nếu chưa nhập tên nhân viên
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNV.Focus();
                return;
            }
            if (txtCMND.Text.Trim().Length == 0) //Nếu chưa nhập CMND
            {
                MessageBox.Show("Bạn phải nhập CMND", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCMND.Focus();
                return;
            }
            if (txtChucVu.Text.Trim().Length == 0) //Nếu chưa nhập chức vụ
            {
                MessageBox.Show("Bạn phải nhập chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtChucVu.Focus();
                return;
            }
            sql = "Select MANV From NHANVIEN where MANV=N'" + txtMaNV.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }

            sql = "INSERT INTO NHANVIEN VALUES(N'" +
                txtMaNV.Text + "',N'" + txtTenNV.Text + "',N'" + txtCMND.Text + "',N'" + txtChucVu.Text + "')";
            Class.Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaNV.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNV.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenNV.Text.Trim().Length == 0) //nếu chưa nhập tên nhân viên
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtCMND.Text.Trim().Length == 0) //nếu chưa nhập CMND
            {
                MessageBox.Show("Bạn chưa nhập CMND", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtChucVu.Text.Trim().Length == 0) //nếu chưa nhập chức vụ
            {
                MessageBox.Show("Bạn chưa nhập chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE NHANVIEN SET  TENNV=N'" + txtTenNV.Text.Trim().ToString() +
                  "',CMND=N'" + txtCMND.Text.Trim().ToString() +
                  "',CHUCVU='" + txtChucVu.Text.ToString() +
                  "' WHERE MANV=N'" + txtMaNV.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();

            btnHuy.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNV.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE NHANVIEN WHERE MANV=N'" + txtMaNV.Text + "'";
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
            txtMaNV.Enabled = false;
        }

    }
}
