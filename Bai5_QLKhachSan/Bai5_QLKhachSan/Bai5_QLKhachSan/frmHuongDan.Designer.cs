namespace Bai5_QLKhachSan
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
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Cho thuê phòng");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Đồ dùng của khách sạn");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Đồ dùng theo phòng");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Khách thuê");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Phòng");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Trả phòng");
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
            treeNode3.Name = "gtChoThuePhong";
            treeNode3.Text = "Cho thuê phòng";
            treeNode4.Name = "gtDoDungCuaKhachSan";
            treeNode4.Text = "Đồ dùng của khách sạn";
            treeNode5.Name = "gtDoDungTheoPhong";
            treeNode5.Text = "Đồ dùng theo phòng";
            treeNode6.Name = "gtKhachThue";
            treeNode6.Text = "Khách thuê";
            treeNode7.Name = "gtPhong";
            treeNode7.Text = "Phòng";
            treeNode8.Name = "gtTraPhong";
            treeNode8.Text = "Trả phòng";
            treeNode9.Name = "gtChucNang";
            treeNode9.Text = "Các chức năng";
            treeNode10.Name = "gtPhanMem";
            treeNode10.Text = "Giới thiệu phần mềm";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.treeView1.Size = new System.Drawing.Size(172, 437);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trViewGioiThieu_AfterSelect);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(172, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(565, 277);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtGioiThieu
            // 
            this.txtGioiThieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGioiThieu.Location = new System.Drawing.Point(172, 277);
            this.txtGioiThieu.Multiline = true;
            this.txtGioiThieu.Name = "txtGioiThieu";
            this.txtGioiThieu.Size = new System.Drawing.Size(565, 160);
            this.txtGioiThieu.TabIndex = 4;
            this.txtGioiThieu.TextChanged += new System.EventHandler(this.txtGioiThieu_TextChanged);
            // 
            // frmHuongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 437);
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