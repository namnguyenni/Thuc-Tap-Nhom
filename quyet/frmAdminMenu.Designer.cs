namespace skelot
{
    partial class FrmAdminMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trailsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.logTrailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditTrailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAndDeleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.requestOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criticalItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiveItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oldItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageProductsToolStripMenuItem,
            this.manageUsersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(944, 30);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageProductsToolStripMenuItem
            // 
            this.manageProductsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.logoutToolStripMenuItem1});
            this.manageProductsToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageProductsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.manageProductsToolStripMenuItem.Name = "manageProductsToolStripMenuItem";
            this.manageProductsToolStripMenuItem.Size = new System.Drawing.Size(79, 26);
            this.manageProductsToolStripMenuItem.Text = "Cài đặt";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.logoutToolStripMenuItem1.Text = "Đăng xuất";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem1,
            this.recordsToolStripMenuItem,
            this.itemsToolStripMenuItem});
            this.manageUsersToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageUsersToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(80, 26);
            this.manageUsersToolStripMenuItem.Text = "Quản lí";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem1
            // 
            this.updateToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.manageToolStripMenuItem});
            this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            this.updateToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.updateToolStripMenuItem1.Text = "Nhân viên";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.registerToolStripMenuItem.Text = "Thêm mới";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.manageToolStripMenuItem.Text = "Chỉnh sửa";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
            // 
            // recordsToolStripMenuItem
            // 
            this.recordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesToolStripMenuItem,
            this.trailsToolStripMenuItem2});
            this.recordsToolStripMenuItem.Name = "recordsToolStripMenuItem";
            this.recordsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.recordsToolStripMenuItem.Text = "Sổ sách";
            this.recordsToolStripMenuItem.Click += new System.EventHandler(this.recordsToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.salesToolStripMenuItem.Text = "Bán hàng";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // trailsToolStripMenuItem2
            // 
            this.trailsToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logTrailToolStripMenuItem,
            this.auditTrailToolStripMenuItem});
            this.trailsToolStripMenuItem2.Name = "trailsToolStripMenuItem2";
            this.trailsToolStripMenuItem2.Size = new System.Drawing.Size(216, 26);
            this.trailsToolStripMenuItem2.Text = "Lịch sử";
            // 
            // logTrailToolStripMenuItem
            // 
            this.logTrailToolStripMenuItem.Name = "logTrailToolStripMenuItem";
            this.logTrailToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.logTrailToolStripMenuItem.Text = "Đăng nhập/đăng xuất";
            this.logTrailToolStripMenuItem.Click += new System.EventHandler(this.logTrailToolStripMenuItem_Click_1);
            // 
            // auditTrailToolStripMenuItem
            // 
            this.auditTrailToolStripMenuItem.Name = "auditTrailToolStripMenuItem";
            this.auditTrailToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.auditTrailToolStripMenuItem.Text = "Kiểm toán";
            this.auditTrailToolStripMenuItem.Click += new System.EventHandler(this.auditTrailToolStripMenuItem_Click_1);
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.updateAndDeleteToolStripMenuItem1,
            this.requestOrderToolStripMenuItem,
            this.receiveItemsToolStripMenuItem});
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.itemsToolStripMenuItem.Text = "Hàng";
            this.itemsToolStripMenuItem.Click += new System.EventHandler(this.itemsToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.addToolStripMenuItem1.Text = "Đặt hàng mới";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click_1);
            // 
            // updateAndDeleteToolStripMenuItem1
            // 
            this.updateAndDeleteToolStripMenuItem1.Name = "updateAndDeleteToolStripMenuItem1";
            this.updateAndDeleteToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.updateAndDeleteToolStripMenuItem1.Text = "Sửa và xóa";
            this.updateAndDeleteToolStripMenuItem1.Click += new System.EventHandler(this.updateAndDeleteToolStripMenuItem1_Click);
            // 
            // requestOrderToolStripMenuItem
            // 
            this.requestOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criticalItemsToolStripMenuItem,
            this.restockToolStripMenuItem});
            this.requestOrderToolStripMenuItem.Name = "requestOrderToolStripMenuItem";
            this.requestOrderToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.requestOrderToolStripMenuItem.Text = "Bảo trì hàng";
            this.requestOrderToolStripMenuItem.Click += new System.EventHandler(this.requestOrderToolStripMenuItem_Click);
            // 
            // criticalItemsToolStripMenuItem
            // 
            this.criticalItemsToolStripMenuItem.Name = "criticalItemsToolStripMenuItem";
            this.criticalItemsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.criticalItemsToolStripMenuItem.Text = "Hàng cần thiết";
            this.criticalItemsToolStripMenuItem.Click += new System.EventHandler(this.criticalItemsToolStripMenuItem_Click);
            // 
            // restockToolStripMenuItem
            // 
            this.restockToolStripMenuItem.Name = "restockToolStripMenuItem";
            this.restockToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.restockToolStripMenuItem.Text = "Bổ sung";
            this.restockToolStripMenuItem.Click += new System.EventHandler(this.restockToolStripMenuItem_Click);
            // 
            // receiveItemsToolStripMenuItem
            // 
            this.receiveItemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newItemsToolStripMenuItem,
            this.oldItemsToolStripMenuItem});
            this.receiveItemsToolStripMenuItem.Name = "receiveItemsToolStripMenuItem";
            this.receiveItemsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.receiveItemsToolStripMenuItem.Text = "Nhận hàng";
            this.receiveItemsToolStripMenuItem.Click += new System.EventHandler(this.receiveItemsToolStripMenuItem_Click);
            // 
            // newItemsToolStripMenuItem
            // 
            this.newItemsToolStripMenuItem.Name = "newItemsToolStripMenuItem";
            this.newItemsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.newItemsToolStripMenuItem.Text = "Hàng mới";
            this.newItemsToolStripMenuItem.Click += new System.EventHandler(this.newItemsToolStripMenuItem_Click);
            // 
            // oldItemsToolStripMenuItem
            // 
            this.oldItemsToolStripMenuItem.Name = "oldItemsToolStripMenuItem";
            this.oldItemsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.oldItemsToolStripMenuItem.Text = "Hàng cần thiết";
            this.oldItemsToolStripMenuItem.Click += new System.EventHandler(this.oldItemsToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Admin";
            this.label1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(123, 416);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 60;
            this.label2.Text = "Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(57, 416);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 22);
            this.label10.TabIndex = 59;
            this.label10.Text = "Date:";
            // 
            // FrmAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(944, 475);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Date:";
            this.Load += new System.EventHandler(this.FrmAdminMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem recordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateAndDeleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receiveItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criticalItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oldItemsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem trailsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem logTrailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditTrailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restockToolStripMenuItem;
    }
}