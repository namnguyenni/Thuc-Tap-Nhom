namespace QuanLyBanHang
{
    partial class frmInHDB
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.InHDNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet2 = new QuanLyBanHang.DataSet2();
            this.InHDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new QuanLyBanHang.DataSet1();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.InHDBTableAdapter = new QuanLyBanHang.DataSet1TableAdapters.InHDBTableAdapter();
            this.InHDNTableAdapter = new QuanLyBanHang.DataSet2TableAdapters.InHDNTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.InHDNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InHDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // InHDNBindingSource
            // 
            this.InHDNBindingSource.DataMember = "InHDN";
            this.InHDNBindingSource.DataSource = this.DataSet2;
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // InHDBBindingSource
            // 
            this.InHDBBindingSource.DataMember = "InHDB";
            this.InHDBBindingSource.DataSource = this.DataSet1;
            this.InHDBBindingSource.CurrentChanged += new System.EventHandler(this.InHDBBindingSource_CurrentChanged);
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(1, 1);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(10, 25);
            this.txtMaHD.TabIndex = 3;
            this.txtMaHD.Visible = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.InHDNBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyBanHang.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(674, 603);
            this.reportViewer1.TabIndex = 5;
            // 
            // InHDBTableAdapter
            // 
            this.InHDBTableAdapter.ClearBeforeFill = true;
            // 
            // InHDNTableAdapter
            // 
            this.InHDNTableAdapter.ClearBeforeFill = true;
            // 
            // frmInHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(674, 603);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.txtMaHD);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInHDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IN HÓA ĐƠN BÁN";
            this.Load += new System.EventHandler(this.frmInHDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InHDNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InHDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaHD;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource InHDBBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.InHDBTableAdapter InHDBTableAdapter;
        private System.Windows.Forms.BindingSource InHDNBindingSource;
        private DataSet2 DataSet2;
        private DataSet2TableAdapters.InHDNTableAdapter InHDNTableAdapter;
    }
}