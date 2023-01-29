
namespace QuanLyBanHang
{
    partial class frmBanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTim = new System.Windows.Forms.Button();
            this.cboMaHD = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvHDBanHang = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtGG = new System.Windows.Forms.TextBox();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.cboMaHH = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnInHD = new System.Windows.Forms.Button();
            this.btnLuuHD = new System.Windows.Forms.Button();
            this.btnXoaHD = new System.Windows.Forms.Button();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBanHang)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.cboMaHD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 521);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 50);
            this.panel1.TabIndex = 0;
            // 
            // btnTim
            // 
            this.btnTim.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnTim.FlatAppearance.BorderSize = 3;
            this.btnTim.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Image = global::QuanLyBanHang.Properties.Resources.view;
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(377, 9);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 33);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // cboMaHD
            // 
            this.cboMaHD.FormattingEnabled = true;
            this.cboMaHD.Location = new System.Drawing.Point(143, 14);
            this.cboMaHD.Name = "cboMaHD";
            this.cboMaHD.Size = new System.Drawing.Size(213, 24);
            this.cboMaHD.TabIndex = 1;
            this.cboMaHD.DropDown += new System.EventHandler(this.cboMaHD_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÃ HOÁ ĐƠN:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(958, 521);
            this.splitContainer1.SplitterDistance = 189;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::QuanLyBanHang.Properties.Resources.abstract_line_background_isolated_white_lines_vector_design_eps_212036376;
            this.groupBox1.Controls.Add(this.txtNgay);
            this.groupBox1.Controls.Add(this.cboMaKH);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.cboMaNV);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 144);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung:";
            // 
            // cboMaKH
            // 
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(573, 21);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(230, 24);
            this.cboMaKH.TabIndex = 24;
            this.cboMaKH.SelectedIndexChanged += new System.EventHandler(this.cboMaKH_SelectedIndexChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(574, 107);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(230, 22);
            this.txtSDT.TabIndex = 23;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(574, 79);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(230, 22);
            this.txtDiaChi.TabIndex = 22;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(573, 51);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.ReadOnly = true;
            this.txtTenKH.Size = new System.Drawing.Size(231, 22);
            this.txtTenKH.TabIndex = 21;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(177, 111);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.ReadOnly = true;
            this.txtTenNV.Size = new System.Drawing.Size(239, 22);
            this.txtTenNV.TabIndex = 11;
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(177, 81);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(239, 24);
            this.cboMaNV.TabIndex = 10;
            this.cboMaNV.SelectedIndexChanged += new System.EventHandler(this.cboMaNV_SelectedIndexChanged);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(177, 25);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(239, 22);
            this.txtMaHD.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(502, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "SĐT:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(502, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "ĐỊA CHỈ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(502, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "TÊN KH:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(502, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "MÃ KH:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(87, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "TÊN NV:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(87, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "MÃ NV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(86, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "NGÀY BÁN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(87, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "MÃ HĐ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(336, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "HOÁ ĐƠN BÁN HÀNG";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvHDBanHang);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(12, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(935, 364);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hàng hoá:";
            // 
            // dgvHDBanHang
            // 
            this.dgvHDBanHang.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvHDBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDBanHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHDBanHang.Location = new System.Drawing.Point(3, 108);
            this.dgvHDBanHang.Name = "dgvHDBanHang";
            this.dgvHDBanHang.RowHeadersWidth = 51;
            this.dgvHDBanHang.RowTemplate.Height = 24;
            this.dgvHDBanHang.Size = new System.Drawing.Size(929, 145);
            this.dgvHDBanHang.TabIndex = 2;
            this.dgvHDBanHang.DoubleClick += new System.EventHandler(this.dgvHDBanHang_DoubleClick);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::QuanLyBanHang.Properties.Resources.abstract_line_background_isolated_white_lines_vector_design_eps_212036376;
            this.panel3.Controls.Add(this.txtThanhTien);
            this.panel3.Controls.Add(this.txtDonGia);
            this.panel3.Controls.Add(this.txtGG);
            this.panel3.Controls.Add(this.txtTenHH);
            this.panel3.Controls.Add(this.txtSL);
            this.panel3.Controls.Add(this.cboMaHH);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(929, 90);
            this.panel3.TabIndex = 1;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(741, 48);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(157, 22);
            this.txtThanhTien.TabIndex = 17;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(741, 18);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(157, 22);
            this.txtDonGia.TabIndex = 16;
            // 
            // txtGG
            // 
            this.txtGG.Location = new System.Drawing.Point(416, 48);
            this.txtGG.Name = "txtGG";
            this.txtGG.Size = new System.Drawing.Size(186, 22);
            this.txtGG.TabIndex = 15;
            this.txtGG.TextChanged += new System.EventHandler(this.txtGG_TextChanged);
            // 
            // txtTenHH
            // 
            this.txtTenHH.Location = new System.Drawing.Point(416, 18);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.ReadOnly = true;
            this.txtTenHH.Size = new System.Drawing.Size(186, 22);
            this.txtTenHH.TabIndex = 14;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(124, 49);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(132, 22);
            this.txtSL.TabIndex = 13;
            this.txtSL.TextChanged += new System.EventHandler(this.txtSL_TextChanged);
            this.txtSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSL_KeyPress);
            // 
            // cboMaHH
            // 
            this.cboMaHH.FormattingEnabled = true;
            this.cboMaHH.Location = new System.Drawing.Point(124, 18);
            this.cboMaHH.Name = "cboMaHH";
            this.cboMaHH.Size = new System.Drawing.Size(132, 24);
            this.cboMaHH.TabIndex = 12;
            this.cboMaHH.SelectedIndexChanged += new System.EventHandler(this.cboMaHH_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label15.Location = new System.Drawing.Point(635, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 17);
            this.label15.TabIndex = 11;
            this.label15.Text = "THÀNH TIỀN:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label16.Location = new System.Drawing.Point(635, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 17);
            this.label16.TabIndex = 10;
            this.label16.Text = "ĐƠN GIÁ:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(305, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "GIẢM GIÁ (%):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(305, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "TÊN HÀNG:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label13.Location = new System.Drawing.Point(25, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "SỐ LƯỢNG:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label14.Location = new System.Drawing.Point(25, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "MÃ HÀNG:";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::QuanLyBanHang.Properties.Resources.abstract_line_background_isolated_white_lines_vector_design_eps_212036376;
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.btnInHD);
            this.panel2.Controls.Add(this.btnLuuHD);
            this.panel2.Controls.Add(this.btnXoaHD);
            this.panel2.Controls.Add(this.btnThemHD);
            this.panel2.Controls.Add(this.txtTongTien);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(929, 108);
            this.panel2.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnHuy.FlatAppearance.BorderSize = 3;
            this.btnHuy.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnHuy.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Image = global::QuanLyBanHang.Properties.Resources.undo;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(734, 34);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(119, 35);
            this.btnHuy.TabIndex = 15;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnInHD
            // 
            this.btnInHD.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnInHD.FlatAppearance.BorderSize = 3;
            this.btnInHD.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnInHD.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnInHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHD.Image = global::QuanLyBanHang.Properties.Resources.printer2;
            this.btnInHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInHD.Location = new System.Drawing.Point(567, 34);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(119, 35);
            this.btnInHD.TabIndex = 14;
            this.btnInHD.Text = "In HĐ";
            this.btnInHD.UseVisualStyleBackColor = true;
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);
            // 
            // btnLuuHD
            // 
            this.btnLuuHD.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnLuuHD.FlatAppearance.BorderSize = 3;
            this.btnLuuHD.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnLuuHD.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnLuuHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuHD.Image = global::QuanLyBanHang.Properties.Resources.floppy_disk;
            this.btnLuuHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuHD.Location = new System.Drawing.Point(233, 34);
            this.btnLuuHD.Name = "btnLuuHD";
            this.btnLuuHD.Size = new System.Drawing.Size(119, 35);
            this.btnLuuHD.TabIndex = 13;
            this.btnLuuHD.Text = "Lưu";
            this.btnLuuHD.UseVisualStyleBackColor = true;
            this.btnLuuHD.Click += new System.EventHandler(this.btnLuuHD_Click);
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoaHD.FlatAppearance.BorderSize = 3;
            this.btnXoaHD.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnXoaHD.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnXoaHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaHD.Image = global::QuanLyBanHang.Properties.Resources.delete;
            this.btnXoaHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaHD.Location = new System.Drawing.Point(400, 34);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(119, 35);
            this.btnXoaHD.TabIndex = 12;
            this.btnXoaHD.Text = "Xoá";
            this.btnXoaHD.UseVisualStyleBackColor = true;
            this.btnXoaHD.Click += new System.EventHandler(this.btnXoaHD_Click);
            // 
            // btnThemHD
            // 
            this.btnThemHD.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThemHD.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnThemHD.FlatAppearance.BorderSize = 3;
            this.btnThemHD.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnThemHD.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnThemHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemHD.Image = global::QuanLyBanHang.Properties.Resources.add;
            this.btnThemHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemHD.Location = new System.Drawing.Point(66, 34);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(119, 35);
            this.btnThemHD.TabIndex = 10;
            this.btnThemHD.Text = "Thêm HĐ";
            this.btnThemHD.UseVisualStyleBackColor = false;
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(722, 7);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(157, 22);
            this.txtTongTien.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label18.Location = new System.Drawing.Point(574, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(147, 17);
            this.label18.TabIndex = 1;
            this.label18.Text = "TỔNG TIỀN (VNĐ):";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(15, 7);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(189, 17);
            this.label17.TabIndex = 0;
            this.label17.Text = "Nháy đúp 1 dòng để xoá!";
            // 
            // txtNgay
            // 
            this.txtNgay.Location = new System.Drawing.Point(177, 53);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(239, 22);
            this.txtNgay.TabIndex = 25;
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 571);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "frmBanHang";
            this.Text = "frmBanHang";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBanHang)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ComboBox cboMaHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboMaKH;
        private System.Windows.Forms.DataGridView dgvHDBanHang;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtGG;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.ComboBox cboMaHH;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.Button btnLuuHD;
        private System.Windows.Forms.Button btnXoaHD;
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtNgay;
    }
}