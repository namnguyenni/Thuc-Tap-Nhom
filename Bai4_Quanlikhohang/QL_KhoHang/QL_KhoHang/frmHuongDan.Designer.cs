namespace QL_KhoHang
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
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Quản lý hàng hóa");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Quản lý khách hàng");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Quản lý nhà cung cấp");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Quản lý nhập xuất");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Thêm phiếu nhập");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Thêm phiếu xuất");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Các chức năng", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Giới thiệu phần mềm", new System.Windows.Forms.TreeNode[] {
            treeNode9});
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
            treeNode3.Name = "gtHangHoa";
            treeNode3.Text = "Quản lý hàng hóa";
            treeNode4.Name = "gtKhachHang";
            treeNode4.Text = "Quản lý khách hàng";
            treeNode5.Name = "gtNhaCungCap";
            treeNode5.Text = "Quản lý nhà cung cấp";
            treeNode6.Name = "gtNhapXuat";
            treeNode6.Text = "Quản lý nhập xuất";
            treeNode7.Name = "gtThemPN";
            treeNode7.Text = "Thêm phiếu nhập";
            treeNode8.Name = "gtThemPX";
            treeNode8.Text = "Thêm phiếu xuất";
            treeNode9.Name = "gtChucNang";
            treeNode9.Text = "Các chức năng";
            treeNode10.Name = "gtPhanMem";
            treeNode10.Text = "Giới thiệu phần mềm";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.treeView1.Size = new System.Drawing.Size(191, 378);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trViewGioiThieu_AfterSelect);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(191, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(502, 277);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtGioiThieu
            // 
            this.txtGioiThieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGioiThieu.Location = new System.Drawing.Point(191, 277);
            this.txtGioiThieu.Multiline = true;
            this.txtGioiThieu.Name = "txtGioiThieu";
            this.txtGioiThieu.Size = new System.Drawing.Size(502, 101);
            this.txtGioiThieu.TabIndex = 3;
            // 
            // frmHuongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 378);
            this.Controls.Add(this.txtGioiThieu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "frmHuongDan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHuongDan";
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