namespace QuanLyBanHang
{
    partial class frmHoaDonBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDonBan));
            this.panelHoaDon = new System.Windows.Forms.Panel();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxHoaDon = new System.Windows.Forms.GroupBox();
            this.tabControlTheoHoaDon = new System.Windows.Forms.TabControl();
            this.tabPageTheoNgay = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lbl1Ngay = new System.Windows.Forms.Label();
            this.dateTimePicker1Ngay = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRef = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxThongKeTien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCTHD = new System.Windows.Forms.Panel();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxCTHD = new System.Windows.Forms.GroupBox();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.picSP = new System.Windows.Forms.PictureBox();
            this.paneltemp = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panelHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.groupBoxHoaDon.SuspendLayout();
            this.tabControlTheoHoaDon.SuspendLayout();
            this.tabPageTheoNgay.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelCTHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.groupBoxCTHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHoaDon
            // 
            this.panelHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelHoaDon.Controls.Add(this.dgvHoaDon);
            this.panelHoaDon.Controls.Add(this.groupBoxHoaDon);
            this.panelHoaDon.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelHoaDon.Location = new System.Drawing.Point(0, 0);
            this.panelHoaDon.Name = "panelHoaDon";
            this.panelHoaDon.Size = new System.Drawing.Size(521, 532);
            this.panelHoaDon.TabIndex = 0;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.GridColor = System.Drawing.Color.Maroon;
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 218);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.Size = new System.Drawing.Size(517, 310);
            this.dgvHoaDon.TabIndex = 1;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.FillWeight = 35F;
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "MaHDB";
            this.Column2.HeaderText = "Mã Hóa Đơn";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 89;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.DataPropertyName = "MaKH";
            this.Column3.HeaderText = "Mã Khách Hàng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 88;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.DataPropertyName = "TenKH";
            this.Column4.HeaderText = "Tên Khách Hàng";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.DataPropertyName = "NgayBan";
            this.Column5.HeaderText = "Ngày Bán";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 88;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column6.DataPropertyName = "TongTien";
            this.Column6.HeaderText = "Tổng Tiền";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 89;
            // 
            // groupBoxHoaDon
            // 
            this.groupBoxHoaDon.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBoxHoaDon.Controls.Add(this.tabControlTheoHoaDon);
            this.groupBoxHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxHoaDon.Location = new System.Drawing.Point(0, 0);
            this.groupBoxHoaDon.Name = "groupBoxHoaDon";
            this.groupBoxHoaDon.Size = new System.Drawing.Size(517, 218);
            this.groupBoxHoaDon.TabIndex = 0;
            this.groupBoxHoaDon.TabStop = false;
            this.groupBoxHoaDon.Text = "Thống Kê Hóa Đơn Bán";
            // 
            // tabControlTheoHoaDon
            // 
            this.tabControlTheoHoaDon.Controls.Add(this.tabPageTheoNgay);
            this.tabControlTheoHoaDon.Controls.Add(this.tabPage2);
            this.tabControlTheoHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTheoHoaDon.Location = new System.Drawing.Point(3, 21);
            this.tabControlTheoHoaDon.Name = "tabControlTheoHoaDon";
            this.tabControlTheoHoaDon.SelectedIndex = 0;
            this.tabControlTheoHoaDon.Size = new System.Drawing.Size(511, 194);
            this.tabControlTheoHoaDon.TabIndex = 0;
            // 
            // tabPageTheoNgay
            // 
            this.tabPageTheoNgay.BackColor = System.Drawing.Color.Teal;
            this.tabPageTheoNgay.Controls.Add(this.btnPrint);
            this.tabPageTheoNgay.Controls.Add(this.btnRefresh);
            this.tabPageTheoNgay.Controls.Add(this.button2);
            this.tabPageTheoNgay.Controls.Add(this.button5);
            this.tabPageTheoNgay.Controls.Add(this.lbl1Ngay);
            this.tabPageTheoNgay.Controls.Add(this.dateTimePicker1Ngay);
            this.tabPageTheoNgay.Controls.Add(this.lblTime);
            this.tabPageTheoNgay.Controls.Add(this.dateTimePicker1);
            this.tabPageTheoNgay.Controls.Add(this.dateTimePicker2);
            this.tabPageTheoNgay.Controls.Add(this.label1);
            this.tabPageTheoNgay.Location = new System.Drawing.Point(4, 26);
            this.tabPageTheoNgay.Name = "tabPageTheoNgay";
            this.tabPageTheoNgay.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTheoNgay.Size = new System.Drawing.Size(503, 164);
            this.tabPageTheoNgay.TabIndex = 0;
            this.tabPageTheoNgay.Text = "Theo Ngày";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.MintCream;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(421, 14);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(66, 36);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Teal;
            this.button2.Location = new System.Drawing.Point(272, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 28);
            this.button2.TabIndex = 13;
            this.button2.Text = "Thống Kê Trong Nhiều Ngày";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Teal;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Teal;
            this.button5.Location = new System.Drawing.Point(39, 120);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(184, 28);
            this.button5.TabIndex = 12;
            this.button5.Text = "Thống Kê Trong 1 Ngày";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // lbl1Ngay
            // 
            this.lbl1Ngay.AutoSize = true;
            this.lbl1Ngay.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl1Ngay.Location = new System.Drawing.Point(6, 33);
            this.lbl1Ngay.Name = "lbl1Ngay";
            this.lbl1Ngay.Size = new System.Drawing.Size(40, 17);
            this.lbl1Ngay.TabIndex = 4;
            this.lbl1Ngay.Text = "Ngày";
            // 
            // dateTimePicker1Ngay
            // 
            this.dateTimePicker1Ngay.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker1Ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1Ngay.Location = new System.Drawing.Point(73, 27);
            this.dateTimePicker1Ngay.Name = "dateTimePicker1Ngay";
            this.dateTimePicker1Ngay.Size = new System.Drawing.Size(115, 25);
            this.dateTimePicker1Ngay.TabIndex = 5;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTime.Location = new System.Drawing.Point(6, 72);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(61, 17);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Từ Ngày";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(73, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(115, 25);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2015, 4, 27, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(222, 66);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(113, 25);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(194, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "=>";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Teal;
            this.tabPage2.Controls.Add(this.btnRef);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.comboBoxThongKeTien);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(503, 169);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Theo Hóa Đơn";
            // 
            // btnRef
            // 
            this.btnRef.BackColor = System.Drawing.Color.MintCream;
            this.btnRef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRef.ForeColor = System.Drawing.Color.Black;
            this.btnRef.Location = new System.Drawing.Point(431, 6);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(66, 27);
            this.btnRef.TabIndex = 15;
            this.btnRef.Text = "Refresh";
            this.btnRef.UseVisualStyleBackColor = false;
            this.btnRef.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(159, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Top 10 Hóa Đơn Tổng Tiền Lớn Nhất";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnMuaMax_Click);
            // 
            // comboBoxThongKeTien
            // 
            this.comboBoxThongKeTien.FormattingEnabled = true;
            this.comboBoxThongKeTien.Items.AddRange(new object[] {
            "<= 500.000",
            "500.000 -> 2.000.000",
            "2.000.000 -> 5.000.000",
            "5.000.000 -> 10.000.000",
            "> 10.000.000"});
            this.comboBoxThongKeTien.Location = new System.Drawing.Point(174, 105);
            this.comboBoxThongKeTien.Name = "comboBoxThongKeTien";
            this.comboBoxThongKeTien.Size = new System.Drawing.Size(221, 25);
            this.comboBoxThongKeTien.TabIndex = 4;
            this.comboBoxThongKeTien.SelectedIndexChanged += new System.EventHandler(this.comboBoxThongKeTien_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(90, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tổng Tiền";
            // 
            // panelCTHD
            // 
            this.panelCTHD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCTHD.Controls.Add(this.dgvCTHD);
            this.panelCTHD.Controls.Add(this.groupBoxCTHD);
            this.panelCTHD.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCTHD.Location = new System.Drawing.Point(564, 0);
            this.panelCTHD.Name = "panelCTHD";
            this.panelCTHD.Size = new System.Drawing.Size(501, 532);
            this.panelCTHD.TabIndex = 1;
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dgvCTHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTHD.GridColor = System.Drawing.Color.Maroon;
            this.dgvCTHD.Location = new System.Drawing.Point(0, 218);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.ReadOnly = true;
            this.dgvCTHD.Size = new System.Drawing.Size(497, 310);
            this.dgvCTHD.TabIndex = 1;
            this.dgvCTHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHD_CellClick);
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "MaHD";
            this.Column7.HeaderText = "Mã Hóa Đơn";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "MaSP";
            this.Column8.HeaderText = "Mã Sản Phẩm";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.DataPropertyName = "TenSP";
            this.Column9.HeaderText = "Tên Sản Phẩm";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.DataPropertyName = "SoLuong";
            this.Column10.HeaderText = "Số Lượng";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.DataPropertyName = "DonGia";
            this.Column11.HeaderText = "Giá Bán";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column12.DataPropertyName = "ThanhTien";
            this.Column12.HeaderText = "Tổng Tiền";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // groupBoxCTHD
            // 
            this.groupBoxCTHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBoxCTHD.Controls.Add(this.lblTenSP);
            this.groupBoxCTHD.Controls.Add(this.picSP);
            this.groupBoxCTHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxCTHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxCTHD.ForeColor = System.Drawing.Color.Bisque;
            this.groupBoxCTHD.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCTHD.Name = "groupBoxCTHD";
            this.groupBoxCTHD.Size = new System.Drawing.Size(497, 218);
            this.groupBoxCTHD.TabIndex = 0;
            this.groupBoxCTHD.TabStop = false;
            this.groupBoxCTHD.Text = "Thông Tin Hóa Đơn Bán";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.BackColor = System.Drawing.Color.White;
            this.lblTenSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTenSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTenSP.ForeColor = System.Drawing.Color.Black;
            this.lblTenSP.Location = new System.Drawing.Point(157, 192);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(2, 19);
            this.lblTenSP.TabIndex = 3;
            this.lblTenSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picSP
            // 
            this.picSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSP.Location = new System.Drawing.Point(183, 14);
            this.picSP.Name = "picSP";
            this.picSP.Size = new System.Drawing.Size(156, 164);
            this.picSP.TabIndex = 2;
            this.picSP.TabStop = false;
            // 
            // paneltemp
            // 
            this.paneltemp.BackColor = System.Drawing.Color.CadetBlue;
            this.paneltemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paneltemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneltemp.Location = new System.Drawing.Point(521, 0);
            this.paneltemp.Name = "paneltemp";
            this.paneltemp.Size = new System.Drawing.Size(43, 532);
            this.paneltemp.TabIndex = 2;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(421, 66);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(66, 34);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1065, 532);
            this.Controls.Add(this.paneltemp);
            this.Controls.Add(this.panelCTHD);
            this.Controls.Add(this.panelHoaDon);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHoaDonBan";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.frmHoaDonBan_Load);
            this.panelHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.groupBoxHoaDon.ResumeLayout(false);
            this.tabControlTheoHoaDon.ResumeLayout(false);
            this.tabPageTheoNgay.ResumeLayout(false);
            this.tabPageTheoNgay.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panelCTHD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.groupBoxCTHD.ResumeLayout(false);
            this.groupBoxCTHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHoaDon;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.GroupBox groupBoxHoaDon;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel panelCTHD;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.GroupBox groupBoxCTHD;
        private System.Windows.Forms.Panel paneltemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1Ngay;
        private System.Windows.Forms.Label lbl1Ngay;
        private System.Windows.Forms.TabControl tabControlTheoHoaDon;
        private System.Windows.Forms.TabPage tabPageTheoNgay;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxThongKeTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.PictureBox picSP;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Button btnPrint;
    }
}