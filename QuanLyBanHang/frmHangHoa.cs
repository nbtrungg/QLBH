using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using QuanLyBanHang.Class;

namespace QuanLyBanHang
{
    public partial class frmHangHoa : Form
    {
        DataTable tblH; //Bảng hàng
        public frmHangHoa()
        {
            InitializeComponent();
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            //txtMaHH.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            LoadDataGridView(); //Hiển thị bảng HANG
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from HANGHOA";
            tblH = Functions.GetDataToTable(sql);
            dgvHH.DataSource = tblH;
            dgvHH.Columns[0].HeaderText = "Mã Hàng";
            dgvHH.Columns[1].HeaderText = "Tên Hàng";
            dgvHH.Columns[2].HeaderText = "Nhà Cung Cấp";
            dgvHH.Columns[3].HeaderText = "Số Lượng";
            dgvHH.Columns[4].HeaderText = "Đơn Giá Nhập";
            dgvHH.Columns[5].HeaderText = "Đơn Giá Bán";
            dgvHH.Columns[0].Width = 80;
            dgvHH.Columns[1].Width = 140;
            dgvHH.Columns[2].Width = 80;
            dgvHH.Columns[3].Width = 120;
            dgvHH.Columns[4].Width = 120;
            dgvHH.Columns[5].Width = 120;
            dgvHH.AllowUserToAddRows = false;
            dgvHH.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvHH_Click(object sender, EventArgs e)
        {
            txtMaHH.Enabled = false;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHH.Focus();
                return;
            }
            if (tblH.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaHH.Text = dgvHH.CurrentRow.Cells["MAHH"].Value.ToString();
            txtTenHH.Text = dgvHH.CurrentRow.Cells["TENHH"].Value.ToString();
            txtSoLuong.Text = dgvHH.CurrentRow.Cells["SOLUONG"].Value.ToString();
            txtNCC.Text = dgvHH.CurrentRow.Cells["NCC"].Value.ToString();
            txtGiaNhap.Text = dgvHH.CurrentRow.Cells["DONGIANHAP"].Value.ToString();
            txtGiaXuat.Text = dgvHH.CurrentRow.Cells["DONGIABAN"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
        }
        private void ResetValue()
        {
            txtMaHH.Text = "";
            txtTenHH.Text = "";
            txtNCC.Text = "";
            txtSoLuong.Text = "";
            txtGiaNhap.Text = "";
            txtGiaXuat.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValue(); //Xoá trắng các textbox
            txtMaHH.Enabled = true; //cho phép nhập mới
            txtMaHH.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Luu lệnh sql
            if (txtMaHH.Text.Trim().Length == 0) //Nếu chua nhập mã hàng
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHH.Focus();
                return;
            }
            if (txtTenHH.Text.Trim().Length == 0) //N?u chua nhập tên khách hàng
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHH.Focus();
                return;
            }
            if (txtNCC.Text.Trim().Length == 0) //Nếu chua nhập NCC
            {
                MessageBox.Show("Bạn phải nhập nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNCC.Focus();
                return;
            }
            if (txtSoLuong.Text.Trim().Length == 0) //Nếu chua nhập dịa chỉ
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Focus();
                return;
            }
            if (txtGiaNhap.Text.Trim().Length == 0) //Nếu chua nhập giá nhập
            {
                MessageBox.Show("Bạn phải nhập đơn giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiaNhap.Focus();
                return;
            }
            if (txtGiaXuat.Text.Trim().Length == 0) //Nếu chua nhập giá xuất
            {
                MessageBox.Show("Bạn phải nhập đơn giá xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiaXuat.Focus();
                return;
            }
            sql = "Select MAHH From HANGHOA where MAHH=N'" + txtMaHH.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này dã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHH.Focus();
                return;
            }

            sql = "INSERT INTO HANGHOA VALUES(N'" +
                txtMaHH.Text + "',N'" + txtTenHH.Text + "',N'" + txtNCC.Text + "',N'" + txtSoLuong.Text + "',N'" + txtGiaNhap.Text + "',N'" + txtGiaXuat.Text + "')";
            Class.Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaHH.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Luu câu lệnh sql
            if (tblH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHH.Text == "") //nếu chua chọn bản ghi nào
            {
                MessageBox.Show("Bạn chua chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenHH.Text.Trim().Length == 0) //nếu chua nhập tên hàng
            {
                MessageBox.Show("Bạn chưa nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtNCC.Text.Trim().Length == 0) //nếu chua nhập SÐT
            {
                MessageBox.Show("Bạn chua nhập nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtSoLuong.Text.Trim().Length == 0) //nếu chua nhập địa chỉ
            {
                MessageBox.Show("Bạn chưa nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtGiaNhap.Text.Trim().Length == 0) //nếu chua nhập giá xuất
            {
                MessageBox.Show("Bạn chua nhập đơn giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtGiaXuat.Text.Trim().Length == 0) //nếu chua nhập giá nhập
            {
                MessageBox.Show("Bạn chưa nhập đơn giá xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE HANGHOA SET  TENHH=N'" + txtTenHH.Text.Trim().ToString() +
                  "',NCC=N'" + txtNCC.Text.Trim().ToString() +
                  "',SOLUONG='" + txtSoLuong.Text.ToString() +
                  "',DONGIANHAP=N'" + txtGiaNhap.Text.Trim().ToString() +
                  "',DONGIABAN='" + txtGiaXuat.Text.ToString() +
                  "' WHERE MAHH=N'" + txtMaHH.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();

            btnHuy.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHH.Text == "") //nếu chua chọn bản ghi nào
            {
                MessageBox.Show("Bạn chua chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE HANGHOA WHERE MAHH=N'" + txtMaHH.Text + "'";
                Class.Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValue();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaHH.Enabled = true;
        }

        private void btnDS_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT MAHH,TENHH,NCC,SOLUONG,DONGIANHAP,DONGIABAN FROM HANGHOA";
            tblH = Functions.GetDataToTable(sql);
            dgvHH.DataSource = tblH;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMaHH.Text == "") && (txtTenHH.Text == "") && (txtNCC.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from HANGHOA WHERE 1=1";
            if (txtMaHH.Text != "")
                sql += " AND MAHH LIKE N'%" + txtMaHH.Text + "%'";
            if (txtTenHH.Text != "")
                sql += " AND TENHH LIKE N'%" + txtTenHH.Text + "%'";
            if (txtNCC.Text != "")
                sql += " AND NCC LIKE N'%" + txtNCC.Text + "%'";
            tblH = Functions.GetDataToTable(sql);
            if (tblH.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + tblH.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvHH.DataSource = tblH;
            ResetValue();
        }
    }
}
