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
    public partial class frmRecordCashier : Form
    {

        SqlCommand cm;
        SqlConnection cn;
        SqlDataReader dr;
        ListViewItem lst;

        double listAmount = 0;

        frmLogin login = new frmLogin();

        public frmRecordCashier()
        {
            InitializeComponent();
        }
        public void getCashier()
        {

            try
            {


                string sql2 = @"Select * from tblLogin";
                cm = new SqlCommand(sql2, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    cboSort.Items.Add(dr[5].ToString());

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmRecordCashier_Load(object sender, EventArgs e)
        {

            cn = new SqlConnection(login.connection);
            cn.Open();
            getCashier();
            getData2();
           timer1.Start();

            double value = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                value += double.Parse(listView1.Items[i].SubItems[5].Text);
            }
            lblTotal.Text = value.ToString("#,###,##0.00");
       
        }
          public void getData2()
        {
           

                listView1.Items.Clear();
                listView1.Columns.Clear();

                listView1.Columns.Add("Cashier", 120);
                listView1.Columns.Add("Product ID", 120);
                listView1.Columns.Add("Product Name ", 120);
                listView1.Columns.Add("Unit Price", 120);
                listView1.Columns.Add("Quantity", 120);
                listView1.Columns.Add("Total Amount", 120);
                listView1.Columns.Add("Type", 120);
                listView1.Columns.Add("Size", 80);
                listView1.Columns.Add("Brand", 100);
                listView1.Columns.Add("Date", 207);

                string sql = @"Select * from tblCashierRecord Order by DateTime DESC";
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
                    lst.SubItems.Add(dr[9].ToString());
                }
                dr.Close();

                double value = 0;
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    value += double.Parse(listView1.Items[i].SubItems[5].Text);
                }
                lblTotal.Text = value.ToString("#,###,##0.00");
          
        }
          //public void getCashierResult()
          //{
          //    try
          //    {

          //        listView1.Items.Clear();
          //        listView1.Columns.Clear();

          //        listView1.Columns.Add("Cashier", 120);
          //        listView1.Columns.Add("Product ID", 120);
          //        listView1.Columns.Add("Product Name ", 120);
          //        listView1.Columns.Add("Unit Price", 120);
          //        listView1.Columns.Add("Quantity", 120);
          //        listView1.Columns.Add("Total Amount", 120);
          //        listView1.Columns.Add("Type", 120);
          //        listView1.Columns.Add("Size", 80);
          //        listView1.Columns.Add("Brand", 100);
          //        listView1.Columns.Add("Date", 207);

          //        string sql = @"Select * from tblCashierRecord Order by DateTime DESC";
          //        cm = new SqlCommand(sql, cn);
          //        dr = cm.ExecuteReader();
          //        while (dr.Read())
          //        {
          //            lst = listView1.Items.Add(dr[0].ToString());
          //            lst.SubItems.Add(dr[1].ToString());
          //            lst.SubItems.Add(dr[2].ToString());
          //            lst.SubItems.Add(dr[3].ToString());
          //            lst.SubItems.Add(dr[4].ToString());
          //            lst.SubItems.Add(dr[5].ToString());
          //            lst.SubItems.Add(dr[6].ToString());
          //            lst.SubItems.Add(dr[7].ToString());
          //            lst.SubItems.Add(dr[8].ToString());
          //            lst.SubItems.Add(dr[9].ToString());
          //        }
          //        dr.Close();

          //        double value = 0;
          //        for (int i = 0; i < listView1.Items.Count; i++)
          //        {
          //            value += double.Parse(listView1.Items[i].SubItems[5].Text);
          //        }
          //        lblTotal.Text = value.ToString("#,###,##0.00");
          //    }
          //    catch (Exception ex)
          //    {
          //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          //    }
          //}
          public void getData()
          {
             

                  listView1.Items.Clear();
                  listView1.Columns.Clear();

                  listView1.Columns.Add("Cashier", 120);
                  listView1.Columns.Add("Product ID", 120);
                  listView1.Columns.Add("Product Name ", 120);
                  listView1.Columns.Add("Unit Price", 120);
                  listView1.Columns.Add("Quantity", 120);
                  listView1.Columns.Add("Total Amount", 120);
                  listView1.Columns.Add("Type", 120);
                  listView1.Columns.Add("Size", 80);
                  listView1.Columns.Add("Brand", 100);
                  listView1.Columns.Add("Date", 207);

                  string sql = @"Select * from tblCashierRecord where Descrip like '" + txtSearch.Text + "%' Order by DateTime DESC";
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
                      lst.SubItems.Add(dr[9].ToString());
                  }
                  dr.Close();

                  double value = 0;
                  for (int i = 0; i < listView1.Items.Count; i++)
                  {
                      value += double.Parse(listView1.Items[i].SubItems[5].Text);
                  }
                  lblTotal.Text = value.ToString("#,###,##0.00");

           
          }

          public void getData3()
          {
            

                  listView1.Items.Clear();
                  listView1.Columns.Clear();

                  listView1.Columns.Add("Cashier", 120);
                  listView1.Columns.Add("Product ID", 120);
                  listView1.Columns.Add("Product Name ", 120);
                  listView1.Columns.Add("Unit Price", 120);
                  listView1.Columns.Add("Quantity", 120);
                  listView1.Columns.Add("Total Amount", 120);
                  listView1.Columns.Add("Type", 120);
                  listView1.Columns.Add("Size", 80);
                  listView1.Columns.Add("Brand", 100);
                  listView1.Columns.Add("Date", 207);

                  SqlConnection cn1 = new SqlConnection(cn.ConnectionString);
                  cn1.Open();
                  string sql = @"Select * from tblCashierRecord where Cashier like '" + cboSort.Text + "%' Order by DateTime DESC";
                  cm = new SqlCommand(sql, cn);
                  SqlDataReader dr1 = cm.ExecuteReader();
                  while (dr1.Read())
                  {
                      lst = listView1.Items.Add(dr1[0].ToString());
                      lst.SubItems.Add(dr1[1].ToString());
                      lst.SubItems.Add(dr1[2].ToString());
                      lst.SubItems.Add(dr1[3].ToString());
                      lst.SubItems.Add(dr1[4].ToString());
                      lst.SubItems.Add(dr1[5].ToString());
                      lst.SubItems.Add(dr1[6].ToString());
                      lst.SubItems.Add(dr1[7].ToString());
                      lst.SubItems.Add(dr1[8].ToString());
                      lst.SubItems.Add(dr1[9].ToString());
                  }
                  dr1.Close();

                  double value = 0;
                  for (int i = 0; i < listView1.Items.Count; i++)
                  {
                      value += double.Parse(listView1.Items[i].SubItems[5].Text);
                  }
                  lblTotal.Text = value.ToString("#,###,##0.00");
            
          }

          private void listView1_SelectedIndexChanged(object sender, EventArgs e)
          {
              double t = Convert.ToDouble(listView1.FocusedItem.SubItems[5].Text);
              listAmount = t;
              lblTempID.Text = listView1.FocusedItem.Text;
          }

          private void timer1_Tick(object sender, EventArgs e)
          {
              DateTime time = DateTime.Now;
              string format = "MM-dd-yyy";
              lblTimer.Text = time.ToString(format);
          }

          private void txtSearch_TextChanged(object sender, EventArgs e)
          {
              getData();
          }

          private void cboSort_SelectedIndexChanged(object sender, EventArgs e)
          {            
              getData3();

              if(cboSort.Text == "-SELECT-")
              {

                  getData2();
              }
          }

          private void btnOkay_Click(object sender, EventArgs e)
          {
              this.Dispose();
              frmRecordSales RS = new frmRecordSales();
              RS.Show();
          }


          private void button1_Click(object sender, EventArgs e)
          {
              getData2();
              cboSort.SelectedIndex = 0;

              if(cboSort.Text == "-SELECT-")
              {
                  getData2();
              }
          }

          private void RemoveAll_Click(object sender, EventArgs e)
          {
              if (listView1.Items.Count == 0)
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
                  cm.Parameters.AddWithValue("@Description", "All data has been DELETED from Users Record!");
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
                      string del1 = "delete from tblCashierRecord";
                      cm = new SqlCommand(del1, cn);
                      cm.ExecuteNonQuery();
                  }
                  lblTotal.Text = "0.00";
                  getData2();

              }
              catch (Exception)
              {
                  MessageBox.Show("No Items To Remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }


          }

          private void button2_Click(object sender, EventArgs e)
          {

              SqlConnection cn2 = new SqlConnection(cn.ConnectionString);
              cn2.Open();
              listView1.Items.Clear();
              string sql = "Select * from tblCashierRecord where Cashier like '" + cboSort.Text + "' and DateTime between '" + dateTimePicker1.Value + "' and '" + dateTimePicker2.Value + "'";
              cm = new SqlCommand(sql, cn2);
              dr = cm.ExecuteReader();
              dr.Read();
              if (dr.HasRows)
              {
                  SqlConnection cn1 = new SqlConnection(login.connection);
                  cn1.Open();
                  sql = "Select * from tblCashierRecord where Cashier like '" + cboSort.Text + "' and DateTime between '" + dateTimePicker1.Value + "' and '" + dateTimePicker2.Value + "'";
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
                      lst.SubItems.Add(dr[9].ToString());


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
                      value += double.Parse(listView1.Items[i].SubItems[5].Text);
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

    }
}
