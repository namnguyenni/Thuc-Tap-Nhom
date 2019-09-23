namespace QuanLyBanHang
{
    partial class frmHuongDan
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Đăng nhập");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Màn hình chính");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Bán hàng");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Hóa đơn bán");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("In hóa đơn bán");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Khách hàng");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Loại hàng");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Nhân viên");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Sản phẩm");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Thêm hóa đơn");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Thống kê");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Các chức năng", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Giới thiệu phần mềm", new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtGioiThieu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "gtDangNhap";
            treeNode1.Text = "Đăng nhập";
            treeNode2.Name = "gtManHinhChinh";
            treeNode2.Text = "Màn hình chính";
            treeNode3.Name = "gtBanHang";
            treeNode3.Text = "Bán hàng";
            treeNode4.Name = "gtHoaDonBan";
            treeNode4.Text = "Hóa đơn bán";
            treeNode5.Name = "gtInHDB";
            treeNode5.Text = "In hóa đơn bán";
            treeNode6.Name = "gtKhachHang";
            treeNode6.Text = "Khách hàng";
            treeNode7.Name = "gtLoaiHang";
            treeNode7.Text = "Loại hàng";
            treeNode8.Name = "gtNhanVien";
            treeNode8.Text = "Nhân viên";
            treeNode9.Name = "gtSanPham";
            treeNode9.Text = "Sản phẩm";
            treeNode10.Name = "gtThemHD";
            treeNode10.Text = "Thêm hóa đơn";
            treeNode11.Name = "gtThongKe";
            treeNode11.Text = "Thống kê";
            treeNode12.Name = "gtChucNang";
            treeNode12.Text = "Các chức năng";
            treeNode13.Name = "gtPhanMem";
            treeNode13.Text = "Giới thiệu phần mềm";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13});
            this.treeView1.Size = new System.Drawing.Size(172, 402);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trViewGioiThieu_AfterSelect);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(172, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 277);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtGioiThieu
            // 
            this.txtGioiThieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGioiThieu.Location = new System.Drawing.Point(172, 277);
            this.txtGioiThieu.Multiline = true;
            this.txtGioiThieu.Name = "txtGioiThieu";
            this.txtGioiThieu.Size = new System.Drawing.Size(399, 125);
            this.txtGioiThieu.TabIndex = 3;
            // 
            // frmHuongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 402);
            this.Controls.Add(this.txtGioiThieu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "frmHuongDan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hướng Dẫn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtGioiThieu;
    }
}