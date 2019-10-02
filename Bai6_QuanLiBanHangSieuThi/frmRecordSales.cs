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
    public partial class frmRecordSales : Form
    {


        SqlCommand cm;
        SqlConnection cn;
        SqlDataReader dr;
        ListViewItem lst;
        //string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Data.accdb";
        double listAmount = 0;

        frmLogin login = new frmLogin();

        public frmRecordSales()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(login.connection);
            cn.Open();
            getData();
          //  getData2();
            timer1.Start();

            double value = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                value += double.Parse(listView1.Items[i].SubItems[4].Text);
            }
            lblTotal.Text = value.ToString("#,###,##0.00");
           
        }

        public void getData2()
        {
            try
            {

                listView1.Items.Clear();
                listView1.Columns.Clear();

                listView1.Columns.Add("Product ID", 120);
                listView1.Columns.Add("Product Name ", 120);
                listView1.Columns.Add("Unit Price", 120);
                listView1.Columns.Add("Quantity", 120);
                listView1.Columns.Add("Total Amount", 120);
                listView1.Columns.Add("Type", 120);
                listView1.Columns.Add("Size", 80);
                listView1.Columns.Add("Brand", 80);
                listView1.Columns.Add("Date", 207);

                string sql = @"Select * from tblRecord Order by DateTime DESC";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())

                {
                    lst = listView1.Items.Add(dr[0].ToString());
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

        public void getData()
        {
            try
            {

                listView1.Items.Clear();
                listView1.Columns.Clear();
             
                listView1.Columns.Add("Product ID", 120);
                listView1.Columns.Add("Product Name ", 120);
                listView1.Columns.Add("Unit Price", 120);
                listView1.Columns.Add("Quantity", 120);
                listView1.Columns.Add("Total Amount", 120);
                listView1.Columns.Add("Type", 120);
                listView1.Columns.Add("Size", 80);
                listView1.Columns.Add("Brand", 80);
                listView1.Columns.Add("Date", 207);

                string sql = @"Select * from tblRecord where Description like '" + txtSearch.Text + "%' Order by DateTime DESC";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    lst = listView1.Items.Add(dr[0].ToString());
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
        private void btnOkay_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FrmAdminMenu frmMenu = new FrmAdminMenu();
            frmMenu.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            getData();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double t = Convert.ToDouble(listView1.FocusedItem.SubItems[4].Text);
            listAmount = t;
            lblTempID.Text = listView1.FocusedItem.Text;
        }

 


        private void RemoveAll_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count == 0)
            {
                return;
            }

            if (MessageBox.Show("Do you really want to delete ALL records?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                DelTrail();
                deleteAll();
            }
        }
        public void DelTrail() 
        {

            try
            {
                string sql = @"INSERT INTO tblAuditTrail VALUES(@Dater,@TransacType,@Description,@Authority)";
                cm = new SqlCommand(sql, cn);
                cm.Parameters.AddWithValue("@Dater", lblTimer.Text);
                cm.Parameters.AddWithValue("@TransacType", "Deletion");
                cm.Parameters.AddWithValue("@Description", "All data has been DELETED from Sales Record!");
                cm.Parameters.AddWithValue("@Authority", "Admin");

                cm.ExecuteNonQuery();

            }
            catch (SqlException l)
            {
                MessageBox.Show(l.Message);
            }
        
        
        
        }
        public void deleteAll() 
        {
            try
            {
                foreach (ListViewItem del in listView1.Items)
                {
                  //  listView1.FocusedItem.Remove();
                    string del1 = "delete from tblRecord";
                    cm = new SqlCommand(del1, cn); 
                    cm.ExecuteNonQuery();
                }
                lblTotal.Text = "0.00";
                getData();
            

         
            }
            catch (Exception)
            {
                MessageBox.Show("No Items To Remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
     
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            string format = "MM-dd-yyy";
            lblTimer.Text = time.ToString(format);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection cn2 = new SqlConnection(cn.ConnectionString);
            cn2.Open();
            listView1.Items.Clear();
            string sql = "Select * from tblRecord where DateTime between '" + dateTimePicker1.Value + "' and '" + dateTimePicker2.Value + "'";
            cm = new SqlCommand(sql, cn2);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                SqlConnection cn1 = new SqlConnection(login.connection);
                cn1.Open();
                sql = "Select * from tblRecord where DateTime between '" + dateTimePicker1.Value + "' and '" + dateTimePicker2.Value + "'";
                cm = new SqlCommand(sql, cn1);
                dr = cm.ExecuteReader();
                while (dr.Read()) 
                {
                    lst = listView1.Items.Add(dr[0].ToString());
                    lst.SubItems.Add(dr[1].ToString());
                    lst.SubItems.Add(dr[2].ToString());
                    lst.SubItems.Add(dr[3].ToString());
                    lst.SubItems.Add(dr[4].ToString());
                    lst.SubItems.Add(dr[5].ToString());
                    lst.SubItems.Add(dr[6].ToString());
                    lst.SubItems.Add(dr[7].ToString());
                    lst.SubItems.Add(dr[8].ToString());


                    if (listView1.Items.Count - 1 != 0)
                    {
                        btnReport.Visible = true;
                    }
                    else
                    {


                    }
                
                }
                dr.Close();

                double value = 0;
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    value += double.Parse(listView1.Items[i].SubItems[4].Text);
                }
                lblTotal.Text = value.ToString("#,###,##0.00");
        
            }
            else
            {
                lblTotal.Text = "0.00";
                btnReport.Visible = false;
            }
            dr.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           // btnReport.Visible = false;
            ItemReport purchased = new ItemReport();
            purchased.LoadData("Select * from tblRecord where DateTime between '" + dateTimePicker1.Value + "' and '" + dateTimePicker2.Value + "'");
            purchased.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Dispose();
            frmRecordCashier RC = new frmRecordCashier();
            RC.Show();
        }

        private void lblTempID_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

     
    }
