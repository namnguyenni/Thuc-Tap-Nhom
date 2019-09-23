using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmInHDB : Form
    {
        public frmInHDB()
        {
            InitializeComponent();
        }
        public frmInHDB(string MaHDB, bool Ban)
        {
            InitializeComponent();
            txtMaHD.Text = MaHDB;
            if (Ban == true) InHDB();
            else InHDN();
        }
        private void frmInHDB_Load(object sender, EventArgs e)
        {        
            
        }

        private void InHDB()
        {
            // TODO: This line of code loads data into the 'DataSet1.InHDB' table. You can move, or remove it, as needed.
            //InHDBBindingSource.DataSource = null;
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.InHDBBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyBanHang.Report1.rdlc";
            try
            {
                //this.InHDBTableAdapter.ClearBeforeFill = true;

                this.InHDBTableAdapter.Fill(this.DataSet1.InHDB, txtMaHD.Text);

            }
            catch { }//MessageBox.Show("a"); }
            this.reportViewer1.RefreshReport();
        }

        private void InHDN()
        {
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.InHDNBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyBanHang.Report2.rdlc";
            try
            {
                //this.InHDBTableAdapter.ClearBeforeFill = true;

                this.InHDNTableAdapter.Fill(this.DataSet2.InHDN, txtMaHD.Text);

            }
            catch { }//MessageBox.Show("a"); }
            this.reportViewer1.RefreshReport();
        }

        private void InHDBBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
