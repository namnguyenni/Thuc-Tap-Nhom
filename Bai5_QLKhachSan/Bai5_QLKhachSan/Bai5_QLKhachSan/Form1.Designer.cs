namespace Bai5_QLKhachSan
{
    partial class frmPHONG
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDodung = new System.Windows.Forms.Button();
            this.txtLoaiphong = new System.Windows.Forms.TextBox();
            this.txtTenphong = new System.Windows.Forms.TextBox();
            this.txtMaphong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txttk_tenphong = new System.Windows.Forms.TextBox();
            this.txttk_loaiphong = new System.Windows.Forms.TextBox();
            this.txttk_Maphong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(908, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Khaki;
            this.groupBox5.Controls.Add(this.btnDodung);
            this.groupBox5.Controls.Add(this.txtLoaiphong);
            this.groupBox5.Controls.Add(this.txtTenphong);
            this.groupBox5.Controls.Add(this.txtMaphong);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(517, 152);
            this.groupBox5.TabIndex = 55;
            this.groupBox5.TabStop = false;
            // 
            // btnDodung
            // 
            this.btnDodung.BackColor = System.Drawing.Color.Transparent;
            this.btnDodung.BackgroundImage = global::Bai5_QLKhachSan.Properties.Resources.pinkbutt;
            this.btnDodung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDodung.FlatAppearance.BorderSize = 0;
            this.btnDodung.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDodung.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDodung.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodung.Location = new System.Drawing.Point(359, 38);
            this.btnDodung.Name = "btnDodung";
            this.btnDodung.Size = new System.Drawing.Size(135, 57);
            this.btnDodung.TabIndex = 60;
            this.btnDodung.Text = "Đồ dùng trong phòng";
            this.btnDodung.UseVisualStyleBackColor = false;
            this.btnDodung.Click += new System.EventHandler(this.btnDodung_Click_1);
            // 
            // txtLoaiphong
            // 
            this.txtLoaiphong.Location = new System.Drawing.Point(196, 97);
            this.txtLoaiphong.Name = "txtLoaiphong";
            this.txtLoaiphong.Size = new System.Drawing.Size(136, 20);
            this.txtLoaiphong.TabIndex = 59;
            // 
            // txtTenphong
            // 
            this.txtTenphong.Location = new System.Drawing.Point(196, 58);
            this.txtTenphong.Name = "txtTenphong";
            this.txtTenphong.Size = new System.Drawing.Size(136, 20);
            this.txtTenphong.TabIndex = 58;
            // 
            // txtMaphong
            // 
            this.txtMaphong.Enabled = false;
            this.txtMaphong.Location = new System.Drawing.Point(196, 19);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Size = new System.Drawing.Size(136, 20);
            this.txtMaphong.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(81, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 56;
            this.label6.Text = "Tên phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 55;
            this.label5.Text = "Loại phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 54;
            this.label4.Text = "Mã phòng";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Khaki;
            this.groupBox4.Controls.Add(this.btnHuy);
            this.groupBox4.Controls.Add(this.btnLuu);
            this.groupBox4.Controls.Add(this.btnXoa);
            this.groupBox4.Controls.Add(this.btnSua);
            this.groupBox4.Controls.Add(this.btnThem);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.Location = new System.Drawing.Point(520, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(385, 152);
            this.groupBox4.TabIndex = 54;
            this.groupBox4.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Transparent;
            this.btnHuy.BackgroundImage = global::Bai5_QLKhachSan.Properties.Resources.bluebut;
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHuy.Location = new System.Drawing.Point(188, 50);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 35);
            this.btnHuy.TabIndex = 57;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Transparent;
            this.btnLuu.BackgroundImage = global::Bai5_QLKhachSan.Properties.Resources.bluebut;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLuu.Location = new System.Drawing.Point(188, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 35);
            this.btnLuu.TabIndex = 56;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BackgroundImage = global::Bai5_QLKhachSan.Properties.Resources.bluebut;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnXoa.Location = new System.Drawing.Point(87, 97);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 35);
            this.btnXoa.TabIndex = 55;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.BackgroundImage = global::Bai5_QLKhachSan.Properties.Resources.bluebut;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSua.Location = new System.Drawing.Point(87, 50);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 35);
            this.btnSua.TabIndex = 54;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BackgroundImage = global::Bai5_QLKhachSan.Properties.Resources.bluebut;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThem.Location = new System.Drawing.Point(87, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 35);
            this.btnThem.TabIndex = 53;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPhong);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(908, 271);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgvPhong
            // 
            this.dgvPhong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhong.Location = new System.Drawing.Point(3, 16);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.Size = new System.Drawing.Size(902, 252);
            this.dgvPhong.TabIndex = 0;
            this.dgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPHONG_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaPhong";
            this.Column1.HeaderText = "Mã phòng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TenPhong";
            this.Column2.HeaderText = "Tên phòng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "LoaiPhong";
            this.Column3.HeaderText = "Loại phòng";
            this.Column3.Name = "Column3";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txttk_tenphong);
            this.groupBox3.Controls.Add(this.txttk_loaiphong);
            this.groupBox3.Controls.Add(this.txttk_Maphong);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(908, 59);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(642, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tên phòng";
            // 
            // txttk_tenphong
            // 
            this.txttk_tenphong.Location = new System.Drawing.Point(755, 25);
            this.txttk_tenphong.Name = "txttk_tenphong";
            this.txttk_tenphong.Size = new System.Drawing.Size(136, 20);
            this.txttk_tenphong.TabIndex = 8;
            this.txttk_tenphong.TextChanged += new System.EventHandler(this.txttk_Tenphong_TextChanged);
            // 
            // txttk_loaiphong
            // 
            this.txttk_loaiphong.Location = new System.Drawing.Point(440, 25);
            this.txttk_loaiphong.Name = "txttk_loaiphong";
            this.txttk_loaiphong.Size = new System.Drawing.Size(136, 20);
            this.txttk_loaiphong.TabIndex = 7;
            this.txttk_loaiphong.TextChanged += new System.EventHandler(this.txttk_Loaiphong_TextChanged);
            // 
            // txttk_Maphong
            // 
            this.txttk_Maphong.Location = new System.Drawing.Point(168, 25);
            this.txttk_Maphong.Name = "txttk_Maphong";
            this.txttk_Maphong.Size = new System.Drawing.Size(136, 20);
            this.txttk_Maphong.TabIndex = 6;
            this.txttk_Maphong.TextChanged += new System.EventHandler(this.txttk_Maphong_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm theo : ";
            // 
            // frmPHONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 501);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPHONG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Phòng";
            this.Load += new System.EventHandler(this.frmPHONG_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox txttk_tenphong;
        private System.Windows.Forms.TextBox txttk_loaiphong;
        private System.Windows.Forms.TextBox txttk_Maphong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnDodung;
        private System.Windows.Forms.TextBox txtLoaiphong;
        private System.Windows.Forms.TextBox txtTenphong;
        private System.Windows.Forms.TextBox txtMaphong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}

