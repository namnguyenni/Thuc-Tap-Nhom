using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace skelot
{
    public partial class AdminView : Form
    {
        SqlCommand cm;
        SqlConnection cn;
        SqlDataReader dr;
        //string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Data.accdb";

        ListViewItem lst;
        frmLogin login = new frmLogin();

        public AdminView()
        {
            InitializeComponent();
        }

        private void AdminSearch_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(login.connection);
            cn.Open();
            this.getData();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            this.Hide();
          FrmAdminMenu AdminMenu = new FrmAdminMenu();
            AdminMenu.Show();
        }
        public void getData()
        {
            //code for Displaying data from Database to lstView.

            try
            {
                listView2.Items.Clear();
                listView2.Columns.Clear();
                listView2.Columns.Add("Product ID", 0);
                listView2.Columns.Add("Product Name", 190);
                listView2.Columns.Add("Price", 90);
                listView2.Columns.Add("Type", 100);
                listView2.Columns.Add("Size", 80);
                listView2.Columns.Add("Brand", 100);
                listView2.Columns.Add("Stock", 80);
                listView2.Columns.Add("Offered Price", 100);
                listView2.Columns.Add("Manufacturer", 190);

                string sql = @"Select * from tblProduct where Descrip like '" + txtSearch.Text + "%'";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    lst = listView2.Items.Add(dr[0].ToString());
                    lst.SubItems.Add(dr[1].ToString());
                    lst.SubItems.Add(dr[2].ToString());
                    lst.SubItems.Add(dr[3].ToString());
                    lst.SubItems.Add(dr[4].ToString());
                    lst.SubItems.Add(dr[5].ToString());
                    lst.SubItems.Add(dr[6].ToString());
                    lst.SubItems.Add(dr[7].ToString());
                    lst.SubItems.Add(dr[8].ToString());

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.getData();
        }
    }
}
