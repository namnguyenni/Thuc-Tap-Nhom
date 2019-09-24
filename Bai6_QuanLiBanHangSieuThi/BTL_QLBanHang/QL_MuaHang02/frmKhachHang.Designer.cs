namespace QuanLyBanHang
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panelButton = new System.Windows.Forms.Panel();
            this.groupBoxTimKiem = new System.Windows.Forms.GroupBox();
            this.txtKHDiaChi = new System.Windows.Forms.TextBox();
            this.lblKHDiaChi = new System.Windows.Forms.Label();
            this.cmbKHLoai = new System.Windows.Forms.ComboBox();
            this.lblKHLoai = new System.Windows.Forms.Label();
            this.txtKHten = new System.Windows.Forms.TextBox();
            this.lblKHten = new System.Windows.Forms.Label();
            this.groupBoxThongKeKH = new System.Windows.Forms.GroupBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnKH = new System.Windows.Forms.Button();
            this.cmbLoaiKH = new System.Windows.Forms.ComboBox();
            this.lblLoaiKH = new System.Windows.Forms.Label();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txttenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lblSoDT = new System.Windows.Forms.Label();
            this.lblDiaCHi = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.panelKH = new System.Windows.Forms.Panel();
            this.lblTopic = new System.Windows.Forms.Label();
            this.pictureBoxKH = new System.Windows.Forms.PictureBox();
            this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblGhichu = new System.Windows.Forms.Label();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.panelButton.SuspendLayout();
            this.groupBoxTimKiem.SuspendLayout();
            this.groupBoxThongKeKH.SuspendLayout();
            this.panelKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column7,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column8});
            this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhachHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvKhachHang.Location = new System.Drawing.Point(0, 318);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.Size = new System.Drawing.Size(1063, 215);
            this.dgvKhachHang.TabIndex = 6;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "STT";
            this.Column5.FillWeight = 30F;
            this.Column5.HeaderText = "STT";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaKH";
            this.Column1.HeaderText = "Mã Khách Hàng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TenKH";
            this.Column2.HeaderText = "Tên Khách Hàng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "GT";
            this.Column7.HeaderText = "Giới Tính";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "DiaChi";
            this.Column3.HeaderText = "Địa Chỉ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "SDT";
            this.Column4.HeaderText = "Số Điện Thoại";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "LoaiKH";
            this.Column6.HeaderText = "Loại Khách Hàng";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "GhiChu";
            this.Column8.HeaderText = "Ghi chú";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.DarkGray;
            this.btnXoa.Location = new System.Drawing.Point(11, 125);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(128, 39);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.DarkGray;
            this.btnSua.Location = new System.Drawing.Point(11, 73);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(128, 37);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.BackgroundImage")));
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLuu.Enabled = false;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.Location = new System.Drawing.Point(11, 177);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(128, 38);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.Location = new System.Drawing.Point(11, 15);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(128, 41);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButton.Controls.Add(this.groupBoxTimKiem);
            this.panelButton.Controls.Add(this.groupBoxThongKeKH);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButton.Location = new System.Drawing.Point(0, 222);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(1063, 96);
            this.panelButton.TabIndex = 5;
            // 
            // groupBoxTimKiem
            // 
            this.groupBoxTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBoxTimKiem.Controls.Add(this.txtKHDiaChi);
            this.groupBoxTimKiem.Controls.Add(this.lblKHDiaChi);
            this.groupBoxTimKiem.Controls.Add(this.cmbKHLoai);
            this.groupBoxTimKiem.Controls.Add(this.lblKHLoai);
            this.groupBoxTimKiem.Controls.Add(this.txtKHten);
            this.groupBoxTimKiem.Controls.Add(this.lblKHten);
            this.groupBoxTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxTimKiem.Location = new System.Drawing.Point(543, 0);
            this.groupBoxTimKiem.Name = "groupBoxTimKiem";
            this.groupBoxTimKiem.Size = new System.Drawing.Size(518, 94);
            this.groupBoxTimKiem.TabIndex = 1;
            this.groupBoxTimKiem.TabStop = false;
            this.groupBoxTimKiem.Text = "Tìm Kiếm";
            // 
            // txtKHDiaChi
            // 
            this.txtKHDiaChi.Location = new System.Drawing.Point(344, 18);
            this.txtKHDiaChi.Name = "txtKHDiaChi";
            this.txtKHDiaChi.Size = new System.Drawing.Size(142, 25);
            this.txtKHDiaChi.TabIndex = 5;
            this.txtKHDiaChi.TextChanged += new System.EventHandler(this.txtKHDiaChi_TextChanged);
            // 
            // lblKHDiaChi
            // 
            this.lblKHDiaChi.AutoSize = true;
            this.lblKHDiaChi.Location = new System.Drawing.Point(275, 21);
            this.lblKHDiaChi.Name = "lblKHDiaChi";
            this.lblKHDiaChi.Size = new System.Drawing.Size(53, 17);
            this.lblKHDiaChi.TabIndex = 4;
            this.lblKHDiaChi.Text = "Địa Chỉ";
            // 
            // cmbKHLoai
            // 
            this.cmbKHLoai.FormattingEnabled = true;
            this.cmbKHLoai.Items.AddRange(new object[] {
            "Khách Sộp",
            "Khách Lẻ",
            "Khách VIP"});
            this.cmbKHLoai.Location = new System.Drawing.Point(94, 56);
            this.cmbKHLoai.Name = "cmbKHLoai";
            this.cmbKHLoai.Size = new System.Drawing.Size(127, 25);
            this.cmbKHLoai.TabIndex = 3;
            this.cmbKHLoai.SelectedIndexChanged += new System.EventHandler(this.cmbKHLoai_SelectedIndexChanged);
            // 
            // lblKHLoai
            // 
            this.lblKHLoai.AutoSize = true;
            this.lblKHLoai.Location = new System.Drawing.Point(11, 59);
            this.lblKHLoai.Name = "lblKHLoai";
            this.lblKHLoai.Size = new System.Drawing.Size(60, 17);
            this.lblKHLoai.TabIndex = 2;
            this.lblKHLoai.Text = "Loại KH";
            // 
            // txtKHten
            // 
            this.txtKHten.Location = new System.Drawing.Point(94, 18);
            this.txtKHten.Name = "txtKHten";
            this.txtKHten.Size = new System.Drawing.Size(127, 25);
            this.txtKHten.TabIndex = 1;
            this.txtKHten.TextChanged += new System.EventHandler(this.txtKHten_TextChanged);
            // 
            // lblKHten
            // 
            this.lblKHten.AutoSize = true;
            this.lblKHten.Location = new System.Drawing.Point(11, 21);
            this.lblKHten.Name = "lblKHten";
            this.lblKHten.Size = new System.Drawing.Size(57, 17);
            this.lblKHten.TabIndex = 0;
            this.lblKHten.Text = "Tên KH";
            // 
            // groupBoxThongKeKH
            // 
            this.groupBoxThongKeKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBoxThongKeKH.Controls.Add(this.btnThongKe);
            this.groupBoxThongKeKH.Controls.Add(this.dateTimePicker2);
            this.groupBoxThongKeKH.Controls.Add(this.label2);
            this.groupBoxThongKeKH.Controls.Add(this.dateTimePicker1);
            this.groupBoxThongKeKH.Controls.Add(this.label1);
            this.groupBoxThongKeKH.Controls.Add(this.btnRefresh);
            this.groupBoxThongKeKH.Controls.Add(this.btnKH);
            this.groupBoxThongKeKH.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxThongKeKH.Location = new System.Drawing.Point(0, 0);
            this.groupBoxThongKeKH.Name = "groupBoxThongKeKH";
            this.groupBoxThongKeKH.Size = new System.Drawing.Size(543, 94);
            this.groupBoxThongKeKH.TabIndex = 0;
            this.groupBoxThongKeKH.TabStop = false;
            this.groupBoxThongKeKH.Text = "Thống Kê";
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThongKe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThongKe.BackgroundImage")));
            this.btnThongKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThongKe.Location = new System.Drawing.Point(404, 60);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(102, 23);
            this.btnThongKe.TabIndex = 6;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(289, 59);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(109, 25);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đến";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(138, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(109, 25);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(11, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mua hàng từ ngày ";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(462, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 31);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnKH
            // 
            this.btnKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnKH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKH.BackgroundImage")));
            this.btnKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKH.ForeColor = System.Drawing.Color.Red;
            this.btnKH.Location = new System.Drawing.Point(11, 16);
            this.btnKH.Name = "btnKH";
            this.btnKH.Size = new System.Drawing.Size(199, 37);
            this.btnKH.TabIndex = 0;
            this.btnKH.Text = "Top 10 KH Mua Nhiều Nhất";
            this.btnKH.UseVisualStyleBackColor = false;
            this.btnKH.Click += new System.EventHandler(this.btnKH_Click);
            // 
            // cmbLoaiKH
            // 
            this.cmbLoaiKH.Enabled = false;
            this.cmbLoaiKH.FormattingEnabled = true;
            this.cmbLoaiKH.Items.AddRange(new object[] {
            "Khách VIP",
            "Khách Thường Xuyên",
            "Khách Lẻ"});
            this.cmbLoaiKH.Location = new System.Drawing.Point(306, 172);
            this.cmbLoaiKH.Name = "cmbLoaiKH";
            this.cmbLoaiKH.Size = new System.Drawing.Size(163, 25);
            this.cmbLoaiKH.TabIndex = 17;
            // 
            // lblLoaiKH
            // 
            this.lblLoaiKH.AutoSize = true;
            this.lblLoaiKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiKH.Location = new System.Drawing.Point(178, 175);
            this.lblLoaiKH.Name = "lblLoaiKH";
            this.lblLoaiKH.Size = new System.Drawing.Size(126, 19);
            this.lblLoaiKH.TabIndex = 16;
            this.lblLoaiKH.Text = "Loại Khách Hàng";
            // 
            // txtSoDT
            // 
            this.txtSoDT.Enabled = false;
            this.txtSoDT.Location = new System.Drawing.Point(652, 66);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(163, 25);
            this.txtSoDT.TabIndex = 15;
            // 
            // txtDC
            // 
            this.txtDC.Enabled = false;
            this.txtDC.Location = new System.Drawing.Point(652, 101);
            this.txtDC.Multiline = true;
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(163, 25);
            this.txtDC.TabIndex = 14;
            // 
            // txttenKH
            // 
            this.txttenKH.Enabled = false;
            this.txttenKH.Location = new System.Drawing.Point(306, 101);
            this.txttenKH.Name = "txttenKH";
            this.txttenKH.Size = new System.Drawing.Size(209, 25);
            this.txttenKH.TabIndex = 13;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Location = new System.Drawing.Point(306, 66);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(209, 25);
            this.txtMaKH.TabIndex = 12;
            // 
            // lblSoDT
            // 
            this.lblSoDT.AutoSize = true;
            this.lblSoDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDT.Location = new System.Drawing.Point(542, 69);
            this.lblSoDT.Name = "lblSoDT";
            this.lblSoDT.Size = new System.Drawing.Size(104, 19);
            this.lblSoDT.TabIndex = 11;
            this.lblSoDT.Text = "Số Điện Thoại";
            // 
            // lblDiaCHi
            // 
            this.lblDiaCHi.AutoSize = true;
            this.lblDiaCHi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaCHi.Location = new System.Drawing.Point(542, 104);
            this.lblDiaCHi.Name = "lblDiaCHi";
            this.lblDiaCHi.Size = new System.Drawing.Size(60, 19);
            this.lblDiaCHi.TabIndex = 10;
            this.lblDiaCHi.Text = "Địa Chỉ";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKH.Location = new System.Drawing.Point(178, 104);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(122, 19);
            this.lblTenKH.TabIndex = 9;
            this.lblTenKH.Text = "Tên Khách Hàng";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKH.Location = new System.Drawing.Point(178, 69);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(120, 19);
            this.lblMaKH.TabIndex = 8;
            this.lblMaKH.Text = "Mã Khách Hàng";
            // 
            // panelKH
            // 
            this.panelKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelKH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelKH.Controls.Add(this.lblTopic);
            this.panelKH.Controls.Add(this.pictureBoxKH);
            this.panelKH.Controls.Add(this.btnXoa);
            this.panelKH.Controls.Add(this.cmbGioiTinh);
            this.panelKH.Controls.Add(this.btnSua);
            this.panelKH.Controls.Add(this.lblGioiTinh);
            this.panelKH.Controls.Add(this.btnLuu);
            this.panelKH.Controls.Add(this.lblGhichu);
            this.panelKH.Controls.Add(this.btnThem);
            this.panelKH.Controls.Add(this.txtGhichu);
            this.panelKH.Controls.Add(this.cmbLoaiKH);
            this.panelKH.Controls.Add(this.lblLoaiKH);
            this.panelKH.Controls.Add(this.txtSoDT);
            this.panelKH.Controls.Add(this.txtDC);
            this.panelKH.Controls.Add(this.txttenKH);
            this.panelKH.Controls.Add(this.txtMaKH);
            this.panelKH.Controls.Add(this.lblSoDT);
            this.panelKH.Controls.Add(this.lblDiaCHi);
            this.panelKH.Controls.Add(this.lblTenKH);
            this.panelKH.Controls.Add(this.lblMaKH);
            this.panelKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelKH.Location = new System.Drawing.Point(0, 0);
            this.panelKH.Name = "panelKH";
            this.panelKH.Size = new System.Drawing.Size(1063, 222);
            this.panelKH.TabIndex = 4;
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopic.ForeColor = System.Drawing.Color.Red;
            this.lblTopic.Location = new System.Drawing.Point(342, 15);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(239, 27);
            this.lblTopic.TabIndex = 23;
            this.lblTopic.Text = "Thông Tin Khách Hàng";
            // 
            // pictureBoxKH
            // 
            this.pictureBoxKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBoxKH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxKH.BackgroundImage")));
            this.pictureBoxKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxKH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxKH.Location = new System.Drawing.Point(821, 5);
            this.pictureBoxKH.Name = "pictureBoxKH";
            this.pictureBoxKH.Size = new System.Drawing.Size(237, 210);
            this.pictureBoxKH.TabIndex = 22;
            this.pictureBoxKH.TabStop = false;
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.FormattingEnabled = true;
            this.cmbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Gay",
            "Less"});
            this.cmbGioiTinh.Location = new System.Drawing.Point(306, 137);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(121, 25);
            this.cmbGioiTinh.TabIndex = 21;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(178, 145);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(72, 19);
            this.lblGioiTinh.TabIndex = 20;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // lblGhichu
            // 
            this.lblGhichu.AutoSize = true;
            this.lblGhichu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhichu.Location = new System.Drawing.Point(542, 145);
            this.lblGhichu.Name = "lblGhichu";
            this.lblGhichu.Size = new System.Drawing.Size(60, 19);
            this.lblGhichu.TabIndex = 19;
            this.lblGhichu.Text = "Ghi chú";
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(652, 139);
            this.txtGhichu.Multiline = true;
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtGhichu.Size = new System.Drawing.Size(163, 60);
            this.txtGhichu.TabIndex = 18;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1063, 533);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.panelKH);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKhachHang";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.panelButton.ResumeLayout(false);
            this.groupBoxTimKiem.ResumeLayout(false);
            this.groupBoxTimKiem.PerformLayout();
            this.groupBoxThongKeKH.ResumeLayout(false);
            this.groupBoxThongKeKH.PerformLayout();
            this.panelKH.ResumeLayout(false);
            this.panelKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.ComboBox cmbLoaiKH;
        private System.Windows.Forms.Label lblLoaiKH;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txttenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lblSoDT;
        private System.Windows.Forms.Label lblDiaCHi;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Panel panelKH;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.PictureBox pictureBoxKH;
        private System.Windows.Forms.ComboBox cmbGioiTinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblGhichu;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.GroupBox groupBoxTimKiem;
        private System.Windows.Forms.TextBox txtKHDiaChi;
        private System.Windows.Forms.Label lblKHDiaChi;
        private System.Windows.Forms.ComboBox cmbKHLoai;
        private System.Windows.Forms.Label lblKHLoai;
        private System.Windows.Forms.TextBox txtKHten;
        private System.Windows.Forms.Label lblKHten;
        private System.Windows.Forms.GroupBox groupBoxThongKeKH;
        private System.Windows.Forms.Button btnKH;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;

    }
}