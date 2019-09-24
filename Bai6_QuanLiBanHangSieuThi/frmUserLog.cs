using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace skelot
{
    public partial class frmUserLog : Form
    {

        OleDbCommand cm;
        OleDbConnection cn;
        OleDbDataReader dr;
        ListViewItem lst;
        string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Data.accdb";


        public frmUserLog()
        {
            InitializeComponent();
        }
        public void getData()
        {
            try
            {

                listView1.Items.Clear();
                listView1.Columns.Clear();

                listView1.Columns.Add("User", 120);
                listView1.Columns.Add("Time Logged-In", 150);
                listView1.Columns.Add("Time Looged-out", 150);
          
                string sql = @"Select * from tblLog where User like '" + txtSearch.Text + "%'";
                cm = new OleDbCommand(sql, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    lst = listView1.Items.Add(dr[0].ToString());
                    lst.SubItems.Add(dr[1].ToString());
                    lst.SubItems.Add(dr[2].ToString());
        
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FrmAdminMenu frmAM = new FrmAdminMenu();
            frmAM.Show();
        }

        private void frmUserLog_Load(object sender, EventArgs e)
        {
            cn = new OleDbConnection(connection);
            cn.Open();
            getData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            getData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.FocusedItem.Remove();
                string del = "delete from tblLog where User='" + lst.SubItems[0].Text + "'";
                cm = new OleDbCommand(del, cn); cm.ExecuteNonQuery();
             

           
            }
            catch (Exception)
            {
                MessageBox.Show("No Item to Remove", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem del in listView1.Items)
                {
                    listView1.FocusedItem.Remove();
                    string del1 = "delete from tblLog where User='" + del.SubItems[0].Text + "'";
                    cm = new OleDbCommand(del1, cn); cm.ExecuteNonQuery();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("No Items To Remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
