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
    public partial class ReceiveOrder : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
       // string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Data.accdb";

        ListViewItem lst = new ListViewItem();

        frmLogin login = new frmLogin();

        public ReceiveOrder()
        {
            InitializeComponent();
          
            cn = new SqlConnection(login.connection);
            cn.Open();
            getData();
        }
        public void getData()
        {

            //displaying data from Database to lstview
            try
            {
                listView1.Items.Clear();
                listView1.Columns.Clear();
                listView1.Columns.Add("Order ID", 90);//0
                listView1.Columns.Add("PID", 90);//1
                listView1.Columns.Add("Product Name", 190);//2

                listView1.Columns.Add("Price", 90);//3
                listView1.Columns.Add("Offered Price", 80);//4
                listView1.Columns.Add("Type", 80);//5
                listView1.Columns.Add("Size", 80);//6
                listView1.Columns.Add("Brand", 90);//7
                listView1.Columns.Add("Items to Receive", 190);//8
                listView1.Columns.Add("Manufacturer", 190);//9
                listView1.Columns.Add("Date Orderded", 190);//10
                listView1.Columns.Add("Date of Delivery", 190);//11
                listView1.Columns.Add("Critical Limit", 80);

                string sql2 = @"Select * from tblNewOrder ORDER by DateOrder DESC";
                cm = new SqlCommand(sql2, cn);
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
                    lst.SubItems.Add(dr[10].ToString());
                    lst.SubItems.Add(dr[11].ToString());
                    lst.SubItems.Add(dr[12].ToString());         
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void ReceiveOrder_Load(object sender, EventArgs e)
        {
            timer1.Start();

          //  InitializeComponent();
          //  getData();
       
        
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
          


        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            //string format = "MMM-dd-yyy HH:mm:ss";
            lblDateNow.Text = time.ToString();

       
          //  lblItemReceive.Text = 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FrmAdminMenu frmAM = new FrmAdminMenu();
            frmAM.Show();
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtOrderID.Text = listView1.FocusedItem.Text;
            txtPID.Text = listView1.FocusedItem.SubItems[1].Text;


            txtName.Text = listView1.FocusedItem.SubItems[2].Text;
            txtPrice.Text = listView1.FocusedItem.SubItems[3].Text;
            txtNetPrice.Text = listView1.FocusedItem.SubItems[4].Text;
            txtType.Text = listView1.FocusedItem.SubItems[5].Text;
            txtSize.Text = listView1.FocusedItem.SubItems[6].Text;
            txtBrand.Text = listView1.FocusedItem.SubItems[7].Text;
            txtCritLimit.Text = listView1.FocusedItem.SubItems[12].Text;
            lblUnitPrice.Text = listView1.FocusedItem.SubItems[3].Text;

            //------------------------insert tblOrderNote------------------------------
            txtpcsleft.Text = listView1.FocusedItem.SubItems[8].Text;
            txtDueDate.Text = listView1.FocusedItem.SubItems[11].Text;
            txtDateOrdered.Text = listView1.FocusedItem.SubItems[10].Text;
            //-------------------------------------------------------------------------

            lblItemReceive.Text = listView1.FocusedItem.SubItems[8].Text;


            txtManufac.Text = listView1.FocusedItem.SubItems[9].Text;
            txtReceive.Text = "";
            txtReceive.Select();
            txtPayment.Text = "";
        }

        private void txtReceive_TextChanged(object sender, EventArgs e)
        {
            double netprice = 0;
            double qty = 0;
            double.TryParse(txtNetPrice.Text, out netprice);
            double.TryParse(txtReceive.Text, out qty);
            double SumP = (netprice * qty);
            lblTotal.Text = SumP.ToString("#,###,##0.00");

            txtTemp1.Text = txtReceive.Text;

            txtTempReceive.Text = txtReceive.Text;
            if (qty < 0)
            {

                MessageBox.Show("quantity should not be zero or below!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if(txtReceive.Text == "" || txtPayment.Text == "")
            {

                MessageBox.Show("Fill the Required Fields!","Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(listView1.Items.Count == -1)
            {

                Clear();
            
            }
            if(txtReceive.Text == "0")
            {
                return;
            
            }


            string PID = "";
            int stock1 = Convert.ToInt32(txtReceive.Text), stock2 = 0, sumStock = 0;
            if (txtPayment.Text == "" || txtReceive.Text == "")
            {

                MessageBox.Show("Fill the required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }
                double x = Convert.ToDouble(listView1.FocusedItem.SubItems[8].Text);

              //  txtTemp.Text = Convert.ToString(x);

                double qty = Convert.ToDouble(txtReceive.Text);
                if (qty > x)
                {

                    MessageBox.Show("Items ordered are limited!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                else 
                {

                    double pay = Convert.ToDouble(txtPayment.Text);
                    double bill = Convert.ToDouble(lblTotal.Text);

                    if (pay < bill)
                    {

                        MessageBox.Show("Insufficient Payment!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else 
                    {

                        string sql = "select * from tblProduct where ID like '" + txtPID.Text + "'";
                        cm = new SqlCommand(sql, cn);
                        dr = cm.ExecuteReader();
                        dr.Read();
                        if (dr.HasRows)
                        {
                            stock2 = Convert.ToInt32(dr[6]);
                            PID = Convert.ToString(dr[0]);
                        }
                        else
                        {
                            dr.Close();

                            string sql2 = @"INSERT INTO tblProduct VALUES(@ID,@Descrip,@Price,@Type,@Size,@Brand,@Stock,@NetPrice,@Manufacturer,@CritLimit)";
                            cm = new SqlCommand(sql2, cn);
                            cm.Parameters.AddWithValue("@ID", txtPID.Text);
                            cm.Parameters.AddWithValue("@Descrip", txtName.Text);
                            cm.Parameters.AddWithValue("@Price", txtPrice.Text);
                            cm.Parameters.AddWithValue("@Type", txtType.Text);
                            cm.Parameters.AddWithValue("@Size", txtSize.Text);
                            cm.Parameters.AddWithValue("@Brand", txtBrand.Text);
                            cm.Parameters.AddWithValue("@Stock", txtReceive.Text);
                            cm.Parameters.AddWithValue("@NetPrice", txtNetPrice.Text);
                            cm.Parameters.AddWithValue("@Manufacturer", txtManufac.Text);
                            cm.Parameters.AddWithValue("@CritLimit", txtCritLimit.Text);
                            cm.ExecuteNonQuery();
                            MessageBox.Show("Item successfully saved!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           
                            DeleteListOrder();
                            
                            InsertTrail();
                           
                            lblItemReceive.Text = txtFinalpcs.Text;
                            lblItemReceive.Text = "0";
                            lblChange.Text = "0.00";
                            txtReceive.Text = "";
                            txtPayment.Text = "";
                            lblUnitPrice.Text = "0.00";
                            getData();

                           // return;
                        }
                        dr.Close();

                        sumStock = stock2 + stock1;

                       string ID = PID;

                        if (txtPID.Text == ID)
                        { 
                            sql = "update tblProduct set Stock = '" + sumStock + "' where ID like '" + txtPID.Text + "'";
                        cm = new SqlCommand(sql, cn);
                        cm.ExecuteNonQuery();

                        InsertTrail();
                        //TrailUpdate();
                       
                        DeleteListOrder();


                        MessageBox.Show("Item successfully saved!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getData();
                        Clear();
                        lblItemReceive.Text = txtFinalpcs.Text;
                        lblItemReceive.Text = "0";
                        lblChange.Text = "0.00";
                        }
                    }

                }
       
        }
        public void InsertTrail() 
        {
          //  try
         //   {
                string sql = @"INSERT INTO tblAuditTrail VALUES(@Dater,@Transactype,@Description,@Authority)";
                cm = new SqlCommand(sql, cn);
                cm.Parameters.AddWithValue("@Dater", lblDateNow.Text);
                cm.Parameters.AddWithValue("@Transactype", "Insertion");
                cm.Parameters.AddWithValue("@Description", ""+txtName.Text + " has been inserted into database!");
                cm.Parameters.AddWithValue("@Authority", "Admin");


                cm.ExecuteNonQuery();
                //   MessageBox.Show("Record successfully saved!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);


         //   }
         //   catch (SqlException l)
         //   {
           //     MessageBox.Show("Re-input again. your username may already be taken!");
          //      MessageBox.Show(l.Message);
           // }
        
        
        }
        public void TrailUpdate() 
        {

           // try
           // {
                string sql = @"INSERT INTO tblAuditTrail VALUES(@Dater,@Transactype,@Description,@Authority)";
                cm = new SqlCommand(sql, cn);
                cm.Parameters.AddWithValue("@Dater", lblDateNow.Text);
                cm.Parameters.AddWithValue("@Transactype", "Insertion");
                cm.Parameters.AddWithValue("@Description", "Item: " + txtName.Text + " has its stock updated in the database!");
                cm.Parameters.AddWithValue("@Authority", "Admin");


                cm.ExecuteNonQuery();

           // }
           // catch (SqlException l)
           // {
             //   MessageBox.Show("Re-input again. your username may already be taken!");
            //    MessageBox.Show(l.Message);
          //  }
                
        }

        public void DeleteListOrder()
        {



            if (txtReceive.Text == txtpcsleft.Text)
            {
               // try
               // {
                    listView1.FocusedItem.Remove();
                    string del = "DELETE from tblNewOrder where IDOrder='" + txtOrderID.Text + "'";
                    cm = new SqlCommand(del, cn); cm.ExecuteNonQuery();
          

              //  }
               // catch (Exception)
               // {
               //     MessageBox.Show("No Item to Remove", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
              //  }
            }
            else 
            {

                int pcs = Convert.ToInt32(txtReceive.Text);
                int pcsleft = Convert.ToInt32(lblItemReceive.Text);
               
                if (pcs < pcsleft)
                {
                    int Finalpcs = pcsleft - pcs;

                    listView1.FocusedItem.SubItems[8].Text = Finalpcs.ToString();

                    //--------only for update------------
                    txtFinalpcs.Text = Finalpcs.ToString();
                    //-----------txt above is for update--------

                    //try
                  //  {

                        string up = @"UPDATE tblNewOrder SET [Stock] = '" + txtFinalpcs.Text + "' where [IDOrder]='" + txtOrderID.Text + "'";
                        cm = new SqlCommand(up, cn);



                        cm.Parameters.AddWithValue("@Stock", txtFinalpcs.Text);
                        cm.ExecuteNonQuery();

                        
                       // lblItemReceive.Text = "";
                   //   Clear();
                      // getData();

                    //}
                 //   catch (Exception ex)
                  //  {
                  //      MessageBox.Show(ex.Message, "No Items to Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   // }
            
            }

         //   string pcsl = listView1.FocusedItem.SubItems[8].Text;
           

            } 
        }
        public void Clear() 
        {

            txtPayment.Text = "0.00";
            txtPrice.Text = "";
            //txtReceive.Text = "0";
            txtBrand.Text = "";
            txtPID.Text = "";
            txtManufac.Text = "";
            txtNetPrice.Text = "";
            txtOrderID.Text = "";
            txtSize.Text = "";
            txtType.Text = "";
            txtName.Text = "";
            lblItemReceive.Text = "0";
            txtCritLimit.Text = "";
            lblUnitPrice.Text = "0.00";
        }
        private void btnNote_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "")
            {
                return;
            }

            try
            {
                string sql = @"INSERT INTO tblOrderNote VALUES(@OrderID,@PID,@Descrip,@Price,@NetPrice,@Type,@Size,@Brand,@Stock,@Manufacturer,@DateOrder,@DateDeliver)";
                cm = new SqlCommand(sql, cn);
             
                cm.Parameters.AddWithValue("@OrderID", txtOrderID.Text);
                cm.Parameters.AddWithValue("@PID", txtPID.Text);
                cm.Parameters.AddWithValue("@Descrip", txtName.Text);
              
                cm.Parameters.AddWithValue("@Price", txtPrice.Text);
                cm.Parameters.AddWithValue("@NetPrice", txtNetPrice.Text);
                cm.Parameters.AddWithValue("@Type", txtType.Text);
                cm.Parameters.AddWithValue("@Size", txtSize.Text);
                cm.Parameters.AddWithValue("@Brand", txtBrand.Text);

                //-----------------------------------------------------
                cm.Parameters.AddWithValue("@Stock", txtpcsleft.Text);
                //-----------------------------------------------------

                cm.Parameters.AddWithValue("@Manufacturer", txtManufac.Text);
                cm.Parameters.AddWithValue("@DateOrder", txtDateOrdered.Text);
                cm.Parameters.AddWithValue("@DateDeliver", txtDueDate.Text);
                cm.Parameters.AddWithValue("@CritLimit", txtCritLimit.Text);


                cm.ExecuteNonQuery();
                TemptDeleteOrder();
                getData();
                this.Clear();

            }
            catch (SqlException l)
            {
                MessageBox.Show("Re-input again.!");
                MessageBox.Show(l.Message);
            }
        }
        public void TemptDeleteOrder()
        {
        
              try
                {
                    listView1.FocusedItem.Remove();
                    string del = "DELETE from tblNewOrder where IDOrder='" + txtOrderID.Text + "'";
                    cm = new SqlCommand(del, cn); cm.ExecuteNonQuery();

                    // MessageBox.Show("Successfully Deleted!");
                    Clear();

                }
                catch (Exception)
                {
                    MessageBox.Show("No Item to Remove", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
      
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtOrderID.Text == "")
            {
                MessageBox.Show("Select Item to Delete!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
          

            if (MessageBox.Show("Do you really want to delete this Order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                DeleteTrail();
                deleteRecords();
            }
        }

        public void DeleteTrail()
        {
           // try
         //   {
                string sql = @"INSERT INTO tblAuditTrail VALUES(@Dater,@Transactype,@Description,@Authority)";
                cm = new SqlCommand(sql, cn);
                cm.Parameters.AddWithValue("@Dater", lblDateNow.Text);
                cm.Parameters.AddWithValue("@Transactype", "Deletion");
                cm.Parameters.AddWithValue("@Description", "Item: " + txtName.Text + " has been removed from Receive Form!");
                cm.Parameters.AddWithValue("@Authority", "Admin");


                cm.ExecuteNonQuery();
                //   MessageBox.Show("Record successfully saved!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);


           // }
          //  catch (SqlException l)
          //  {
             //   MessageBox.Show("Re-input again. your username may already be taken!");
            //    MessageBox.Show(l.Message);
         //   }


        }

        public void AllDelTrail()
        {

           // try
           // {
                string sql = @"INSERT INTO tblAuditTrail VALUES(@Dater,@Transactype,@Description,@Authority)";
                cm = new SqlCommand(sql, cn);
                cm.Parameters.AddWithValue("@Dater", lblDateNow.Text);
                cm.Parameters.AddWithValue("@Transactype", "Deletion");
                cm.Parameters.AddWithValue("@Description", "All Items from Receive form were REMOVED!");
                cm.Parameters.AddWithValue("@Authority", "Admin");

                cm.ExecuteNonQuery();

           // }
           // catch (SqlException l)
          //  {
           //     MessageBox.Show("Re-input again. your username may already be taken!");
          //      MessageBox.Show(l.Message);
         //   }

        }


        public void deleteRecords()
        {
           // try
          //  {
                listView1.FocusedItem.Remove();
                string del = "DELETE from tblNewOrder where IDOrder='" + txtOrderID.Text + "'";
                cm = new SqlCommand(del, cn); cm.ExecuteNonQuery();

                MessageBox.Show("Successfully Deleted!");
                Clear();

           // }
         //   catch (Exception)
          //  {
           //     MessageBox.Show("No Item to Remove", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

          //  }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count == 0)
            {

                return;
            }
            if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                AllDelTrail();
                DeleteAll();
                getData();
            }
        }
        public void DeleteAll() 
        {

           // try
         //   {
               // listView1.FocusedItem.Remove();
                string del = "DELETE * from tblNewOrder ";
                cm = new SqlCommand(del, cn); cm.ExecuteNonQuery();

                MessageBox.Show("Successfully Deleted!");
                Clear();

          //  }
          //  catch (Exception)
          //  {
         //       MessageBox.Show("No Item to Remove", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

           // }
        }

        private void txtPayment_TextChanged(object sender, EventArgs e)
        {
            if (txtPayment.Text == "")
            {
            }
            else
            {
                try
                {


                    double t = Convert.ToDouble(lblTotal.Text);
                    double c = Convert.ToDouble(txtPayment.Text);


                    if (c < t) //If Cash amount is Less Than to that of Total payment.
                    {
                        lblChange.Text = "0.00";
                    }
                    else if (t < 1 || c < 1)
                    {
                        lblChange.Text = "0.00";
                    }

                    else
                    {
                      double  _totalPayment = Convert.ToDouble(lblTotal.Text);
                      double  _cash = Convert.ToDouble(txtPayment.Text);
                      double   _change = _cash - _totalPayment;
                      lblChange.Text = _change.ToString("#,###,##0.00");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Fields are Empty!.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblChange.Text = "0.00";
                    txtPayment.Text = String.Empty;
                }
            }
        }


        private void txtReceive_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            FrmAdminMenu frm = new FrmAdminMenu();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmNotes Notes = new frmNotes();
            Notes.Show();
        }

    }
}
