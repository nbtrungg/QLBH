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
using COMExcel = Microsoft.Office.Interop.Excel;


namespace QuanLyBanHang
{
    public partial class frmBanHang : Form
    {
        DataTable tblCTHDB; //Bảng chi tiết hoá đơn bán
        public frmBanHang()
        {
            InitializeComponent();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            btnThemHD.Enabled = true;
            btnLuuHD.Enabled = false;
            btnXoaHD.Enabled = false;
            btnInHD.Enabled = false;
            txtMaHD.ReadOnly = true;
            txtTenNV.ReadOnly = true;
            txtTenKH.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtTenHH.ReadOnly = true;
            txtDonGia.ReadOnly = true;
            txtThanhTien.ReadOnly = true;
            txtTongTien.ReadOnly = true;
            txtGG.Text = "0";
            txtTongTien.Text = "0";
            Functions.FillCombo("SELECT MAKH, TENKH FROM KHACHHANG", cboMaKH, "MAKH", "MAKH");
            cboMaKH.SelectedIndex = -1;
            Functions.FillCombo("SELECT MANV, TENNV FROM NHANVIEN", cboMaNV, "MANV", "MANV");
            cboMaNV.SelectedIndex = -1;
            Functions.FillCombo("SELECT MAHH, TENHH FROM HANGHOA", cboMaHH, "MAHH", "MAHH");
            cboMaHH.SelectedIndex = -1;
            //Hiển thị thông tin của một hóa đơn được gọi từ form tìm kiếm
            if (txtMaHD.Text != "")
            {
                LoadInfoHoaDon();
                btnXoaHD.Enabled = true;
                btnInHD.Enabled = true;
            }
            LoadDataGridView();
        }
        //Nạp chi tiết hoá đơn
        private void LoadInfoHoaDon()
        {
            string str;
            str = "SELECT NGAYTAOHD FROM HOADON WHERE MAHD = N'" + txtMaHD.Text + "'";
            //dtpNgay.Value = DateTime.Parse(Functions.GetFieldValues(str));
            txtNgay.Text = Functions.ConvertDateTime(Functions.GetFieldValues(str));
            str = "SELECT MANV FROM HOADON WHERE MAHD = N'" + txtMaHD.Text + "'";
            cboMaNV.Text = Functions.GetFieldValues(str);
            str = "SELECT MAKH FROM HOADON WHERE MAHD = N'" + txtMaHD.Text + "'";
            cboMaKH.Text = Functions.GetFieldValues(str);
            str = "SELECT TONGTIEN FROM HOADON WHERE MAHD = N'" + txtMaHD.Text + "'";
            txtTongTien.Text = Functions.GetFieldValues(str);
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT a.MAHH, b.TENHH, a.SOLUONG, b.DONGIABAN, a.GIAMGIA,a.THANHTIEN FROM CHITIETHOADON AS a, HANGHOA AS b WHERE a.MaHD = N'" + txtMaHD.Text + "' AND a.MAHH=b.MAHH";
            tblCTHDB = Functions.GetDataToTable(sql);
            dgvHDBanHang.DataSource = tblCTHDB;
            dgvHDBanHang.Columns[0].HeaderText = "Mã hàng";
            dgvHDBanHang.Columns[1].HeaderText = "Tên hàng";
            dgvHDBanHang.Columns[2].HeaderText = "Số lượng";
            dgvHDBanHang.Columns[3].HeaderText = "Đơn giá";
            dgvHDBanHang.Columns[4].HeaderText = "Giảm giá %";
            dgvHDBanHang.Columns[5].HeaderText = "Thành tiền";
            dgvHDBanHang.Columns[0].Width = 80;
            dgvHDBanHang.Columns[1].Width = 130;
            dgvHDBanHang.Columns[2].Width = 80;
            dgvHDBanHang.Columns[3].Width = 100;
            dgvHDBanHang.Columns[4].Width = 100;
            dgvHDBanHang.Columns[5].Width = 150;
            dgvHDBanHang.AllowUserToAddRows = false;
            dgvHDBanHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            btnXoaHD.Enabled = false;
            btnLuuHD.Enabled = true;
            btnInHD.Enabled = false;
            btnThemHD.Enabled = false;
            ResetValues();
            txtMaHD.Text = Functions.CreateKey("HDB");
            LoadDataGridView();
        }
        //Nạp các giá trị về mặc định
        private void ResetValues()
        {
            txtMaHD.Text = "";
            //dtpNgay.Value = DateTime.Now.ToString("MM/dd/yyyy");
            txtNgay.Text = DateTime.Now.ToString("MM/dd/yyyy");
            cboMaNV.Text = "";
            cboMaKH.Text = "";
            txtTongTien.Text = "0";
            cboMaHH.Text = "";
            txtSL.Text = "";
            txtGG.Text = "0";
            txtThanhTien.Text = "0";
            txtTenNV.Text = "";
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcon, tong, Tongmoi;
            sql = "SELECT MAHD FROM HOADON WHERE MAHD=N'" + txtMaHD.Text + "'";
            if (!Functions.CheckKey(sql))
            {
                // Mã hóa đơn chưa có, tiến hành lưu các thông tin chung
                // Mã HDBan được sinh tự động do đó không có trường hợp trùng khóa
                if (txtNgay.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNgay.Focus();
                    return;
                }
                if (cboMaNV.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaNV.Focus();
                    return;
                }
                if (cboMaKH.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaKH.Focus();
                    return;
                }
                sql = "INSERT INTO HOADON(MAHD, NGAYTAOHD, MANV, MAKH, TONGTIEN) VALUES (N'" + txtMaHD.Text.Trim() + "','" +
                       /*Functions.ConvertDateTime()*/txtNgay.Text/*.Trim()dtpNgay.Value*/ + "',N'" + cboMaNV.SelectedValue + "',N'" +
                        cboMaKH.SelectedValue + "'," + txtTongTien.Text + ")";
                Functions.RunSQL(sql);
            }
            // Lưu thông tin của các mặt hàng
            if (cboMaHH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaHH.Focus();
                return;
            }
            if ((txtSL.Text.Trim().Length == 0) || (txtSL.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSL.Text = "";
                txtSL.Focus();
                return;
            }
            if (txtGG.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGG.Focus();
                return;
            }
            sql = "SELECT MAHH FROM CHITIETHOADON WHERE MAHH=N'" + cboMaHH.SelectedValue + "' AND MaHD = N'" + txtMaHD.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesHang();
                cboMaHH.Focus();
                return;
            }
            // Kiểm tra xem số lượng hàng trong kho còn đủ để cung cấp không?
            sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SOLUONG FROM HANGHOA WHERE MAHH = N'" + cboMaHH.SelectedValue + "'"));
            if (Convert.ToDouble(txtSL.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSL.Text = "";
                txtSL.Focus();
                return;
            }
            sql = "INSERT INTO CHITIETHOADON(MAHD,MAHH,SOLUONG,DONGIA, GIAMGIA,THANHTIEN) VALUES(N'" + txtMaHD.Text.Trim() + "',N'" + cboMaHH.SelectedValue + "'," + txtSL.Text + "," + txtDonGia.Text + "," + txtGG.Text + "," + txtThanhTien.Text + ")";
            Functions.RunSQL(sql);
            LoadDataGridView();
            // Cập nhật lại số lượng của mặt hàng vào bảng tblHang
            SLcon = sl - Convert.ToDouble(txtSL.Text);
            sql = "UPDATE HANGHOA SET SOLUONG =" + SLcon + " WHERE MAHH= N'" + cboMaHH.SelectedValue + "'";
            Functions.RunSQL(sql);
            // Cập nhật lại tổng tiền cho hóa đơn bán
            tong = Convert.ToDouble(Functions.GetFieldValues("SELECT TONGTIEN FROM HOADON WHERE MAHD = N'" + txtMaHD.Text + "'"));
            Tongmoi = tong + Convert.ToDouble(txtThanhTien.Text);
            sql = "UPDATE HOADON SET TONGTIEN =" + Tongmoi + " WHERE MAHD = N'" + txtMaHD.Text + "'";
            Functions.RunSQL(sql);
            txtTongTien.Text = Tongmoi.ToString();
            ResetValuesHang();
            btnXoaHD.Enabled = true;
            btnThemHD.Enabled = true;
            btnInHD.Enabled = true;
        }
        private void ResetValuesHang()
        {
            cboMaHH.Text = "";
            txtSL.Text = "";
            txtGG.Text = "0";
            txtThanhTien.Text = "0";
        }

        private void cboMaHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaHH.Text == "")
            {
                txtTenHH.Text = "";
                txtDonGia.Text = "";
            }
            // Khi chọn mã hàng thì các thông tin về hàng hiện ra
            str = "SELECT TENHH FROM HANGHOA WHERE MAHH =N'" + cboMaHH.SelectedValue + "'";
            txtTenHH.Text = Functions.GetFieldValues(str);
            str = "SELECT DONGIABAN FROM HANGHOA WHERE MAHH =N'" + cboMaHH.SelectedValue + "'";
            txtDonGia.Text = Functions.GetFieldValues(str);
        }

        private void cboMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaKH.Text == "")
            {
                txtTenKH.Text = "";
                txtDiaChi.Text = "";
                txtSDT.Text = "";
            }
            //Khi chọn Mã khách hàng thì các thông tin của khách hàng sẽ hiện ra
            str = "Select TENKH from KHACHHANG where MAKH = N'" + cboMaKH.SelectedValue + "'";
            txtTenKH.Text = Functions.GetFieldValues(str);
            str = "Select DIACHI from KHACHHANG where MAKH = N'" + cboMaKH.SelectedValue + "'";
            txtDiaChi.Text = Functions.GetFieldValues(str);
            str = "Select SDT from KHACHHANG where MAKH= N'" + cboMaKH.SelectedValue + "'";
            txtSDT.Text = Functions.GetFieldValues(str);
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi số lượng thì thực hiện tính lại thành tiền
            double tt, sl, dg, gg;
            if (txtSL.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSL.Text);
            if (txtGG.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGG.Text);
            if (txtDonGia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhTien.Text = tt.ToString();
        }

        private void txtGG_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi giảm giá thì tính lại thành tiền
            double tt, sl, dg, gg;
            if (txtSL.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSL.Text);
            if (txtGG.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGG.Text);
            if (txtDonGia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhTien.Text = tt.ToString();
        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaNV.Text == "")
            {
                txtTenNV.Text = "";
            }
            //Khi chọn Mã khách hàng thì các thông tin của khách hàng sẽ hiện ra
            str = "Select TENNV from NHANVIEN where MANV = N'" + cboMaNV.SelectedValue + "'";
            txtTenNV.Text = Functions.GetFieldValues(str);
            
        }

        private void cboMaHD_DropDown(object sender, EventArgs e)
        {
            Functions.FillCombo("SELECT MAHD FROM HOADON", cboMaHD, "MAHD", "MAHD");
            cboMaHD.SelectedIndex = -1;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cboMaHD.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaHD.Focus();
                return;
            }
            txtMaHD.Text = cboMaHD.Text;
            LoadInfoHoaDon();
            LoadDataGridView();
            btnXoaHD.Enabled = true;
            btnLuuHD.Enabled = true;
            btnInHD.Enabled = true;
            cboMaHD.SelectedIndex = -1;
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "CỬA HÀNG THIẾT BỊ ĐIỆN TỬ";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "TP. THỦ ĐỨC";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: 0352240547";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "SELECT a.MAHD, a.NGAYTAOHD, a.TONGTIEN, b.TENKH, b.DIACHI, b.SDT, c.TENNV FROM HOADON AS a, KHACHHANG AS b, NHANVIEN AS c WHERE a.MAHD = N'" + txtMaHD.Text + "' AND a.MAKH = b.MAKH AND a.MANV = c.MANV";
            tblThongtinHD = Functions.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            sql = "SELECT b.TENHH, a.SOLUONG, b.DONGIABAN, a.GIAMGIA, a.THANHTIEN " +
                  "FROM CHITIETHOADON AS a , HANGHOA AS b WHERE a.MAHD = N'" +
                  txtMaHD.Text + "' AND a.MAHH = b.MAHH";
            tblThongtinHang = Functions.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Giảm giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString() + "%";
                }
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            //exRange.Range["A1:F1"].Value = "Bằng chữ: " + Functions.ChuyenSoSangChu(tblThongtinHD.Rows[0][2].ToString());
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "THỦ ĐỨC, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa đơn bán hàng";
            exApp.Visible = true;
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            double sl, slcon, slxoa;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "SELECT MAHH,SOLUONG FROM CHITIETHOADON WHERE MAHD = N'" + txtMaHD.Text + "'";
                DataTable tblHang = Functions.GetDataToTable(sql);
                for (int hang = 0; hang <= tblHang.Rows.Count - 1; hang++)
                {
                    // Cập nhật lại số lượng cho các mặt hàng
                    sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SOLUONG FROM HANGHOA WHERE MAHH = N'" + tblHang.Rows[hang][0].ToString() + "'"));
                    slxoa = Convert.ToDouble(tblHang.Rows[hang][1].ToString());
                    slcon = sl + slxoa;
                    sql = "UPDATE HANGHOA SET SOLUONG =" + slcon + " WHERE MAHH= N'" + tblHang.Rows[hang][0].ToString() + "'";
                    Functions.RunSQL(sql);
                }

                //Xóa chi tiết hóa đơn
                sql = "DELETE CHITIETHOADON WHERE MAHD=N'" + txtMaHD.Text + "'";
                Functions.RunSQL(sql);

                //Xóa hóa đơn
                sql = "DELETE HOADON WHERE MAHD=N'" + txtMaHD.Text + "'";
                Functions.RunSQL(sql);
                ResetValues();
                LoadDataGridView();
                btnXoaHD.Enabled = false;
                btnInHD.Enabled = false;
            }
        }

        private void dgvHDBanHang_DoubleClick(object sender, EventArgs e)
        {
            string MaHangxoa, sql;
            Double ThanhTienxoa, SoLuongxoa, sl, slcon, tong, tongmoi;
            if (tblCTHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 
                MaHangxoa = dgvHDBanHang.CurrentRow.Cells["MAHH"].Value.ToString();
                SoLuongxoa = Convert.ToDouble(dgvHDBanHang.CurrentRow.Cells["SOLUONG"].Value.ToString());
                ThanhTienxoa = Convert.ToDouble(dgvHDBanHang.CurrentRow.Cells["THANHTIEN"].Value.ToString());
                sql = "DELETE CHITIETHOADON WHERE MAHD=N'" + txtMaHD.Text + "' AND MAHH = N'" + MaHangxoa + "'";
                Functions.RunSQL(sql);
                // Cập nhật lại số lượng cho các mặt hàng
                sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SOLUONG FROM HANGHOA WHERE MAHH = N'" + MaHangxoa + "'"));
                slcon = sl + SoLuongxoa;
                sql = "UPDATE HANGHOA SET SOLUONG =" + slcon + " WHERE MAHH= N'" + MaHangxoa + "'";
                Functions.RunSQL(sql);
                // Cập nhật lại tổng tiền cho hóa đơn bán
                tong = Convert.ToDouble(Functions.GetFieldValues("SELECT TONGTIEN FROM HOADON WHERE MAHD = N'" + txtMaHD.Text + "'"));
                tongmoi = tong - ThanhTienxoa;
                sql = "UPDATE HOADON SET TONGTIEN =" + tongmoi + " WHERE MAHD = N'" + txtMaHD.Text + "'";
                Functions.RunSQL(sql);
                txtTongTien.Text = tongmoi.ToString();
                LoadDataGridView();
            }
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnXoaHD.Enabled = true;
            btnThemHD.Enabled = true;
            txtNgay.Text = "";

        }
    }
}
