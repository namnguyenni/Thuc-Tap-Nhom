namespace BTL_QLNS
{
    partial class ManHinhChinh
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
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnPhongBan = new System.Windows.Forms.Button();
            this.btnDuan = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLicense = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.ForeColor = System.Drawing.Color.Red;
            this.btnNhanVien.Location = new System.Drawing.Point(54, 232);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(212, 56);
            this.btnNhanVien.TabIndex = 0;
            this.btnNhanVien.Text = "Quản lý nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnPhongBan
            // 
            this.btnPhongBan.ForeColor = System.Drawing.Color.Red;
            this.btnPhongBan.Location = new System.Drawing.Point(284, 232);
            this.btnPhongBan.Name = "btnPhongBan";
            this.btnPhongBan.Size = new System.Drawing.Size(212, 56);
            this.btnPhongBan.TabIndex = 1;
            this.btnPhongBan.Text = "Quản lý phòng ban";
            this.btnPhongBan.UseVisualStyleBackColor = true;
            this.btnPhongBan.Click += new System.EventHandler(this.btnPhongBan_Click);
            // 
            // btnDuan
            // 
            this.btnDuan.ForeColor = System.Drawing.Color.Red;
            this.btnDuan.Location = new System.Drawing.Point(519, 232);
            this.btnDuan.Name = "btnDuan";
            this.btnDuan.Size = new System.Drawing.Size(212, 56);
            this.btnDuan.TabIndex = 2;
            this.btnDuan.Text = "Quản lý dự án";
            this.btnDuan.UseVisualStyleBackColor = true;
            this.btnDuan.Click += new System.EventHandler(this.btnDuan_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.Image = global::BTL_QLNS.Properties.Resources.iconfinder_Undo_278852;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(1, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 32);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Trở lại";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.BackColor = System.Drawing.Color.Transparent;
            this.lblLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLicense.ForeColor = System.Drawing.Color.White;
            this.lblLicense.Location = new System.Drawing.Point(670, 430);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(102, 13);
            this.lblLicense.TabIndex = 6;
            this.lblLicense.Text = "Nam Dong products";
            // 
            // ManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BTL_QLNS.Properties.Resources.Nen_BTL;
            this.ClientSize = new System.Drawing.Size(784, 452);
            this.Controls.Add(this.lblLicense);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDuan);
            this.Controls.Add(this.btnPhongBan);
            this.Controls.Add(this.btnNhanVien);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ManHinhChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn Hình Chính";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnPhongBan;
        private System.Windows.Forms.Button btnDuan;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblLicense;
    }
}