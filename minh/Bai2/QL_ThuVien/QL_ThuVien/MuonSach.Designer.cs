namespace QL_ThuVien
{
    partial class MuonSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuonSach));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMuon = new System.Windows.Forms.Button();
            this.txtMaTL = new System.Windows.Forms.TextBox();
            this.lblMaTL = new System.Windows.Forms.Label();
            this.txtMaBD = new System.Windows.Forms.TextBox();
            this.lblMaBD = new System.Windows.Forms.Label();
            this.panelDatagridview = new System.Windows.Forms.Panel();
            this.gbSachMuon = new System.Windows.Forms.GroupBox();
            this.dgvSachMuon = new System.Windows.Forms.DataGridView();
            this.gbBanDoc = new System.Windows.Forms.GroupBox();
            this.dgvSachDaMuon = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panelDatagridview.SuspendLayout();
            this.gbSachMuon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachMuon)).BeginInit();
            this.gbBanDoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachDaMuon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnMuon);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.txtMaTL);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblMaTL);
            this.groupBox1.Controls.Add(this.txtMaBD);
            this.groupBox1.Controls.Add(this.lblMaBD);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1602, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnMuon
            // 
            this.btnMuon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMuon.BackgroundImage")));
            this.btnMuon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMuon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMuon.Location = new System.Drawing.Point(505, 26);
            this.btnMuon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.Size = new System.Drawing.Size(170, 67);
            this.btnMuon.TabIndex = 4;
            this.btnMuon.Text = "Mượn";
            this.btnMuon.UseVisualStyleBackColor = true;
            this.btnMuon.Click += new System.EventHandler(this.btnMuon_Click);
            // 
            // txtMaTL
            // 
            this.txtMaTL.Location = new System.Drawing.Point(198, 66);
            this.txtMaTL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaTL.Name = "txtMaTL";
            this.txtMaTL.Size = new System.Drawing.Size(229, 26);
            this.txtMaTL.TabIndex = 3;
            this.txtMaTL.TextChanged += new System.EventHandler(this.txtMaTL_TextChanged);
            // 
            // lblMaTL
            // 
            this.lblMaTL.AutoSize = true;
            this.lblMaTL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaTL.Location = new System.Drawing.Point(16, 69);
            this.lblMaTL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaTL.Name = "lblMaTL";
            this.lblMaTL.Size = new System.Drawing.Size(163, 23);
            this.lblMaTL.TabIndex = 2;
            this.lblMaTL.Text = "Nhập Mã Tài Liệu";
            // 
            // txtMaBD
            // 
            this.txtMaBD.Location = new System.Drawing.Point(198, 26);
            this.txtMaBD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaBD.Name = "txtMaBD";
            this.txtMaBD.Size = new System.Drawing.Size(229, 26);
            this.txtMaBD.TabIndex = 1;
            this.txtMaBD.TextChanged += new System.EventHandler(this.txtMaBD_TextChanged);
            // 
            // lblMaBD
            // 
            this.lblMaBD.AutoSize = true;
            this.lblMaBD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaBD.Location = new System.Drawing.Point(16, 27);
            this.lblMaBD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaBD.Name = "lblMaBD";
            this.lblMaBD.Size = new System.Drawing.Size(163, 23);
            this.lblMaBD.TabIndex = 0;
            this.lblMaBD.Text = "Nhập Mã Bạn Đọc";
            // 
            // panelDatagridview
            // 
            this.panelDatagridview.Controls.Add(this.gbSachMuon);
            this.panelDatagridview.Controls.Add(this.gbBanDoc);
            this.panelDatagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDatagridview.Location = new System.Drawing.Point(0, 156);
            this.panelDatagridview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDatagridview.Name = "panelDatagridview";
            this.panelDatagridview.Size = new System.Drawing.Size(1602, 517);
            this.panelDatagridview.TabIndex = 1;
            // 
            // gbSachMuon
            // 
            this.gbSachMuon.Controls.Add(this.dgvSachMuon);
            this.gbSachMuon.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbSachMuon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSachMuon.Location = new System.Drawing.Point(751, 0);
            this.gbSachMuon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSachMuon.Name = "gbSachMuon";
            this.gbSachMuon.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSachMuon.Size = new System.Drawing.Size(851, 517);
            this.gbSachMuon.TabIndex = 4;
            this.gbSachMuon.TabStop = false;
            this.gbSachMuon.Text = "Sách đã nhập";
            // 
            // dgvSachMuon
            // 
            this.dgvSachMuon.AllowUserToAddRows = false;
            this.dgvSachMuon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvSachMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.dgvSachMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSachMuon.Location = new System.Drawing.Point(4, 27);
            this.dgvSachMuon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSachMuon.Name = "dgvSachMuon";
            this.dgvSachMuon.Size = new System.Drawing.Size(843, 486);
            this.dgvSachMuon.TabIndex = 0;
            // 
            // gbBanDoc
            // 
            this.gbBanDoc.Controls.Add(this.dgvSachDaMuon);
            this.gbBanDoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbBanDoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbBanDoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBanDoc.Location = new System.Drawing.Point(0, 0);
            this.gbBanDoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbBanDoc.Name = "gbBanDoc";
            this.gbBanDoc.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbBanDoc.Size = new System.Drawing.Size(763, 517);
            this.gbBanDoc.TabIndex = 3;
            this.gbBanDoc.TabStop = false;
            this.gbBanDoc.Text = "Sách đã mượn";
            // 
            // dgvSachDaMuon
            // 
            this.dgvSachDaMuon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvSachDaMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachDaMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column15,
            this.Column6});
            this.dgvSachDaMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSachDaMuon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvSachDaMuon.Location = new System.Drawing.Point(4, 27);
            this.dgvSachDaMuon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSachDaMuon.Name = "dgvSachDaMuon";
            this.dgvSachDaMuon.Size = new System.Drawing.Size(755, 486);
            this.dgvSachDaMuon.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(900, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(337, 215);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.BackgroundImage")));
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHuy.Location = new System.Drawing.Point(63, 26);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(175, 67);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOK.BackgroundImage")));
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOK.Location = new System.Drawing.Point(739, 26);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(167, 67);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "Hoàn Tất Mượn";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaDauSach";
            this.Column1.HeaderText = "Mã đầu sách";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NhanDe";
            this.Column2.HeaderText = "Nhan đề";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TacGia";
            this.Column3.HeaderText = "Tác giả";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgayMuon";
            this.Column4.HeaderText = "Ngày mượn";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NgayTra";
            this.Column5.HeaderText = "Ngày trả";
            this.Column5.Name = "Column5";
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "HanTra";
            this.Column15.HeaderText = "Hạn trả";
            this.Column15.Name = "Column15";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "GhiChu";
            this.Column6.HeaderText = "Ghi chú";
            this.Column6.Name = "Column6";
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "MaNXB";
            this.Column14.HeaderText = "Mã NXB";
            this.Column14.Name = "Column14";
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "MaTL";
            this.Column13.HeaderText = "Thể loại";
            this.Column13.Name = "Column13";
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "NgonNgu";
            this.Column12.HeaderText = "Ngôn ngữ";
            this.Column12.Name = "Column12";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "DoMat";
            this.Column11.HeaderText = "Độ mật";
            this.Column11.Name = "Column11";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "SoLuong";
            this.Column10.HeaderText = "Số lượng";
            this.Column10.Name = "Column10";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "TacGia";
            this.Column9.HeaderText = "Tác giả";
            this.Column9.Name = "Column9";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "NhanDe";
            this.Column8.HeaderText = "Nhan đề";
            this.Column8.Name = "Column8";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MaDauSach";
            this.Column7.HeaderText = "Mã đầu sách";
            this.Column7.Name = "Column7";
            // 
            // MuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1602, 673);
            this.Controls.Add(this.panelDatagridview);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MuonSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mượn Sách";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelDatagridview.ResumeLayout(false);
            this.gbSachMuon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachMuon)).EndInit();
            this.gbBanDoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachDaMuon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMuon;
        private System.Windows.Forms.TextBox txtMaTL;
        private System.Windows.Forms.Label lblMaTL;
        private System.Windows.Forms.TextBox txtMaBD;
        private System.Windows.Forms.Label lblMaBD;
        private System.Windows.Forms.Panel panelDatagridview;
        private System.Windows.Forms.GroupBox gbSachMuon;
        private System.Windows.Forms.DataGridView dgvSachMuon;
        private System.Windows.Forms.GroupBox gbBanDoc;
        private System.Windows.Forms.DataGridView dgvSachDaMuon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}