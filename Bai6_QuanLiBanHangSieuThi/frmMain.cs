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
    public partial class FrmBookStore : Form
    {
        SqlCommand cm;
        SqlConnection cn;
        SqlDataReader dr;

        frmLogin login = new frmLogin();
    



        ListViewItem lst;
        double Total, temp;
        double _totalPayment, _cash, _change;
        double FinStock;

        double CurrQty;
        double CurrStock;
   
        public FrmBookStore()
        {
            InitializeComponent();
            cn = new SqlConnection(login.connection);
            cn.Open();
          
            timer1.Start();
        }
        public void pass(string user, string Time) {

            lblUser.Text = user;
            lblTimeLoggedIn.Text = Time;
        
        
        }
        public void getData()
        {
            //displaying data from Database to lstview
            try
            {
                listView1.Items.Clear();
                listView1.Columns.Clear();
                listView1.Columns.Add("Product ID",0);
                listView1.Columns.Add("Product Name", 210);
                
                listView1.Columns.Add("Price", 90);
                listView1.Columns.Add("Type", 80);
                listView1.Columns.Add("Size", 80);
                listView1.Columns.Add("Brand", 80);
                listView1.Columns.Add("Stock", 80);
                listView1.Columns.Add("CritLimit", 0);
               
                string sql2 = @"Select * from tblProduct where Descrip like '" + txtSearch.Text + "%'";
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
                    lst.SubItems.Add(dr[9].ToString());
                    if(Convert.ToInt32(dr[6].ToString()) == 0)
                    {

                        lst.ForeColor = Color.Crimson;
                    
                    
                    }else if(Convert.ToInt32(dr[6].ToString()) <= Convert.ToInt32(dr[9].ToString()))
                    {
                        lst.ForeColor = Color.Orange;                    
                    }          
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

  

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            string format = "MM-dd-yyy";
            lblTimer.Text = time.ToString(format);
            lblDate.Text = time.ToString();
        }



        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtQuantity.Select();
            txtID.Text = listView1.FocusedItem.Text;
            txtDesc.Text = listView1.FocusedItem.SubItems[1].Text;
            txtPrice.Text = listView1.FocusedItem.SubItems[2].Text;
           
           

           
            txtType.Text = listView1.FocusedItem.SubItems[3].Text;
            txtSize.Text = listView1.FocusedItem.SubItems[4].Text;
            txtBrand.Text = listView1.FocusedItem.SubItems[5].Text;
            txtStock.Text = listView1.FocusedItem.SubItems[6].Text;
            lblCrit.Text = listView1.FocusedItem.SubItems[7].Text;

            txtQuantity.Text = "0";
            txtQuantity.Focus();
            txtSum.Text = "0.00";
            /*
            lst = listView2.Items.Add(txtID.Text);
            lst.SubItems.Add(txtDesc.Text);
            lst.SubItems.Add(txtPrice.Text);
            lst.SubItems.Add(txtQuantity.Text);
            lst.SubItems.Add(txtSum.Text);
            lst.SubItems.Add(txtType.Text);
            lst.SubItems.Add(txtSize.Text);
            lst.SubItems.Add(txtBrand.Text);*/

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.getData();

            if (comboBox2.Text == "Nhãn hiệu")
            {

                this.getBrand();

            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            double price = 0;
            double qty = 0;
            double.TryParse(txtPrice.Text, out price);
            double.TryParse(txtQuantity.Text, out qty);
            double SumP = (price * qty);
            txtSum.Text = SumP.ToString("#,###,##0.00");

            if(qty < 0)
            {

                MessageBox.Show("Positive Integers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tempID = listView2.FocusedItem.SubItems[0].Text;
            txtID2.Text = tempID;
            double tempQty = Convert.ToDouble(listView2.FocusedItem.SubItems[3].Text);
            txtQty2.Text = Convert.ToString(tempQty);

            double t = Convert.ToDouble(listView2.FocusedItem.SubItems[4].Text);//Converts and passes the total amount from index 4 from lstview2(Cart)
            temp = t;//passed to t
           // txtQuantity.Select();
        }

        private void FrmBookStore_Load(object sender, EventArgs e)
        {
            panel2.Hide();

            this.getData();
            
        }
        public void decrementStock() 
        {

             CurrQty = Convert.ToDouble(txtQuantity.Text);
             CurrStock = Convert.ToDouble(listView1.FocusedItem.SubItems[6].Text);

                FinStock = CurrStock - CurrQty;

                listView1.FocusedItem.SubItems[6].Text = FinStock.ToString();

                //--------only for update------------
                txtStock2.Text = FinStock.ToString();
                //-----------txt above is for update--------

                try
                {

                    string up = @"UPDATE tblProduct SET [Stock] = '" + txtStock2.Text + "' where [ID]='" + txtID.Text + "'";
                    cm = new SqlCommand(up, cn);



                    cm.Parameters.AddWithValue("@Stock", txtStock2.Text);
                    cm.ExecuteNonQuery();


                    getData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No Items to Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }
        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
          
            if(txtID.Text == "" || txtQuantity.Text == "")
            {
                MessageBox.Show("Please select product from the list OR input Quantity if empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
                return;
            }

            int SaleQty = Convert.ToInt32(txtQuantity.Text);
            CurrQty = Convert.ToDouble(txtQuantity.Text);
            CurrStock = Convert.ToDouble(listView1.FocusedItem.SubItems[6].Text);
             if (SaleQty == 0 || CurrStock == 0)
            {
                MessageBox.Show("Quantity or Stock is unavailable!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
                return;
            }else if (CurrStock < 0){
                return;
            }else if(CurrQty > CurrStock)
            {
                MessageBox.Show("Limited Stock Available!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else
             {
                decrementStock();
                if (listView2.Items.Count == 0)
                {
                    lst = listView2.Items.Add(txtID.Text);
                    lst.SubItems.Add(txtDesc.Text);
                    lst.SubItems.Add(txtPrice.Text);
                    lst.SubItems.Add(txtQuantity.Text);
                    lst.SubItems.Add(txtSum.Text);
                    lst.SubItems.Add(txtType.Text);
                    lst.SubItems.Add(txtSize.Text);
                    lst.SubItems.Add(txtBrand.Text);

                   

                    double total = Convert.ToDouble(txtSum.Text);
                    Total += total;
                    txtBill.Text = Total.ToString("#,###,###0.00");
                    txtDesc.Text = "";
                    txtPrice.Text = "";

                    txtQuantity.Text = "";
                    txtSum.Text = "";
                    txtID.Text = "";
                    txtType.Text = "";
                    txtBrand.Text = "";
                    txtSize.Text = "";
                    txtStock.Text = "";


                   
                    txtChange.Text = "0.00";

                    panel2.Show();
                  //  groupBox3.Visible = false;

                    return;
                }

         
                //Updating quantities and Total amount if same ID.
                for (int j = 0; j <= listView2.Items.Count - 1; j++)
                {
                    if (listView2.Items[j].SubItems[0].Text == txtID.Text)
                    {

                        listView2.Items[j].SubItems[3].Text = (Convert.ToInt32(listView2.Items[j].SubItems[3].Text) + Convert.ToInt32(txtQuantity.Text)).ToString();
                        listView2.Items[j].SubItems[4].Text = (Convert.ToDouble(listView2.Items[j].SubItems[4].Text) + Convert.ToDouble(txtSum.Text)).ToString("#,###,##0.00");

                        double tempTotal = Convert.ToDouble(txtSum.Text);

                        txtBill.Text = listView2.Items[j].SubItems[4].Text;

                        Total += tempTotal;
                        txtBill.Text = Total.ToString("#,###,###0.00");

                        txtDesc.Text = "";
                        txtPrice.Text = "";
                        txtType.Text = "";
                        txtQuantity.Text = "";
                        txtSum.Text = "";
                        txtID.Text = "";
                        txtPayment.Text = "";
                        txtSize.Text = "";
                        txtBrand.Text = "";
                        txtChange.Text = "0.00";
                        lblCrit.Text = "0";

                        return;
                    }
                }
                

                ListViewItem lst2 = new ListViewItem();
                lst2 = listView2.Items.Add(txtID.Text);
                lst2.SubItems.Add(txtDesc.Text);
                lst2.SubItems.Add(txtPrice.Text);
                lst2.SubItems.Add(txtQuantity.Text);
                lst2.SubItems.Add(txtSum.Text);
                lst2.SubItems.Add(txtType.Text);
                lst2.SubItems.Add(txtSize.Text);
                lst2.SubItems.Add(txtBrand.Text);

                double total2 = Convert.ToDouble(txtSum.Text);
                Total += total2;
                txtBill.Text = Total.ToString("#,###,###0.00");

                txtDesc.Text = "";
                txtPrice.Text = "";

                txtType.Text = "";
                txtQuantity.Text = "";
                txtSum.Text = "";
                txtID.Text = "";
                txtPayment.Text = "";
                txtBrand.Text = "";
                txtSize.Text = "";
                txtChange.Text = "0.00";
                txtStock.Text = "";
                lblCrit.Text = "0";

                return;
            
            }

        }

        private void btnSettle_Click(object sender, EventArgs e)
        {
            if (txtBill.Text == "")
            {
                MessageBox.Show("Enter total payment", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBill.Focus();
                return;
            }
            if (txtPayment.Text == "")
            {
                MessageBox.Show("Enter your Payment.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPayment.Focus();
                return;
            }

            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("No Product to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Convert.ToDouble(txtBill.Text) > Convert.ToDouble(txtPayment.Text))
            {
                MessageBox.Show("Insufficient Cash!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPayment.SelectAll();
                txtPayment.Focus();
                return;

            }

           

           
            foreach (ListViewItem li in listView2.Items)
            {
                string sql = @"INSERT INTO tblRecord([ID],[Description],[Price],[Quantity],[TotalSum],[Type],[Size],[Brand],[DateTime]) VALUES(@row1,@row2,@row3,@row4,@row5,@row6,@row7,@row8,@Date1)";
                cm = new SqlCommand(sql, cn);

                cm.Parameters.AddWithValue("@row1", li.SubItems[0].Text);
                cm.Parameters.AddWithValue("@row2", li.SubItems[1].Text);
                cm.Parameters.AddWithValue("@row3", li.SubItems[2].Text);
                cm.Parameters.AddWithValue("@row4", li.SubItems[3].Text);
                cm.Parameters.AddWithValue("@row5", li.SubItems[4].Text);
                cm.Parameters.AddWithValue("@row6", li.SubItems[5].Text);
                cm.Parameters.AddWithValue("@row7", li.SubItems[6].Text);
                cm.Parameters.AddWithValue("@row8", li.SubItems[7].Text);
             
                cm.Parameters.AddWithValue("@Date1", lblDate.Text);
                cm.ExecuteNonQuery(); //ExecuteNonQuery passes a connection string to database or SQL.

                string sql2 = @"INSERT INTO tblCashierRecord([Cashier],[PID],[Descrip],[Price],[Quantity],[TotalSum],[Type],[Size],[Brand],[DateTime]) VALUES(@row1,@row2,@row3,@row4,@row5,@row6,@row7,@row8,@row9,@row10)";
                cm = new SqlCommand(sql2, cn);

                cm.Parameters.AddWithValue("@row1", lblUser.Text);
                cm.Parameters.AddWithValue("@row2", li.SubItems[0].Text);
                cm.Parameters.AddWithValue("@row3", li.SubItems[1].Text);
                cm.Parameters.AddWithValue("@row4", li.SubItems[2].Text);
                cm.Parameters.AddWithValue("@row5", li.SubItems[3].Text);
                cm.Parameters.AddWithValue("@row6", li.SubItems[4].Text);
                cm.Parameters.AddWithValue("@row7", li.SubItems[5].Text);
                cm.Parameters.AddWithValue("@row8", li.SubItems[6].Text);
                cm.Parameters.AddWithValue("@row9", li.SubItems[7].Text);

                cm.Parameters.AddWithValue("@row10", lblTimer.Text);
                cm.ExecuteNonQuery();
            }


            Total = 0;
          

            getData();
            MessageBox.Show("Successfully saved" + "\nYour Change is: " + txtChange.Text, "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);

            listView2.Items.Clear();
           
            txtBill.Text = "";
            txtChange.Text = "";
            txtPayment.Text = "";
            txtStock.Text = "";
            panel2.Visible = false;
        }

        private void btnDelOR_Click(object sender, EventArgs e)
        {
            try
            {
                double val1 = 0;
                double val2 = 0;
                /*double.TryParse method converts the string representation of a number in a specified string or style.*/

                double.TryParse(temp.ToString(), out val1);//the value of index 4 from lstview2 and assigned to variable 'temp' is converted to double.
                double.TryParse(txtBill.Text, out val2);//Value from txtBill is converted to double
                listView2.FocusedItem.Remove();
                Total = val2 - val1;
                txtBill.Text = Total.ToString("#,###,##0.00");

                RemoveStock();

            }
            catch (Exception)
            {
                MessageBox.Show("No items to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void RemoveStock() 
        {


            for (int j = 0; j <= listView1.Items.Count - 1; j++)
            {
                if (listView1.Items[j].SubItems[0].Text == txtID2.Text)
                {

                    listView1.Items[j].SubItems[6].Text = (Convert.ToInt32(listView1.Items[j].SubItems[6].Text) + Convert.ToInt32(txtQty2.Text)).ToString();
               try
                    {
                        string up = @"UPDATE tblProduct SET [Stock] = '" + listView1.Items[j].SubItems[6].Text + "' where [ID]='" + txtID2.Text + "'";
                        cm = new SqlCommand(up, cn);



                        cm.Parameters.AddWithValue("@Stock", listView1.Items[j].SubItems[6].Text);
                        cm.ExecuteNonQuery();

                        txtID2.Text = "";
                        getData();

                        //        MessageBox.Show("Successfully Updated!");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "No Items to Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
         
                    return;
                }
            }
        }

        private void txtChange_TextChanged(object sender, EventArgs e)
        {
           
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
                   

                    double t = Convert.ToDouble(txtBill.Text);
                    double c = Convert.ToDouble(txtPayment.Text);
                   

                    if (c < t) //If Cash amount is Less Than to that of Total payment.
                    {
                        txtChange.Text = "0.00";
                    }else if(t < 1 || c < 1)
                    {
                        txtChange.Text = "0.00";
                    }
                    else
                    {
                        _totalPayment = Convert.ToDouble(txtBill.Text);
                        _cash = Convert.ToDouble(txtPayment.Text);
                        _change = _cash - _totalPayment;
                        txtChange.Text = _change.ToString("#,###,##0.00");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Numerics Only.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtChange.Text = "0.00";
                    txtPayment.Text = String.Empty;
                }
            }
        }

    

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (comboBox1.Text == "Mặc định")
            {

                getData();

            }
            else 
            {

                getType();
            
            }
        }
        public void getType() 
        {
           //displaying data from Database to lstview
            try
            {
                listView1.Items.Clear();
                listView1.Columns.Clear();
                listView1.Columns.Add("Product ID",0);
                listView1.Columns.Add("Product Name", 210);
                
                listView1.Columns.Add("Price", 90);
                listView1.Columns.Add("Type", 80);
                listView1.Columns.Add("Size", 80);
                listView1.Columns.Add("Brand", 80);
                listView1.Columns.Add("Stock", 80);
                listView1.Columns.Add("CritLimit", 0);
               
                string sql2 = @"Select * from tblProduct where Type like '" + comboBox1.Text + "%'";
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
                    lst.SubItems.Add(dr[9].ToString());

                    if (Convert.ToInt32(dr[6].ToString()) == 0)
                    {

                        lst.ForeColor = Color.Crimson;


                    }
                    else if (Convert.ToInt32(dr[6].ToString()) <=  (Convert.ToInt32(dr[9].ToString())))
                    {
                        lst.ForeColor = Color.Orange;

                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            getBrand();
        }


        public void getBrand()
        {
            //displaying data from Database to lstview
            try
            {
                listView1.Items.Clear();
                listView1.Columns.Clear();
                listView1.Columns.Add("Product ID", 0);
                listView1.Columns.Add("Product Name", 210);

                listView1.Columns.Add("Price", 90);
                listView1.Columns.Add("Type", 80);
                listView1.Columns.Add("Size", 80);
                listView1.Columns.Add("Brand", 80);
                listView1.Columns.Add("Stock", 80);
                listView1.Columns.Add("CritLimit", 0);


                string sql2 = @"Select * from tblProduct where Brand like '" + txtSearch.Text + "%'";
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
                    lst.SubItems.Add(dr[9].ToString());

                    if (Convert.ToInt32(dr[6].ToString()) == 0)
                    {

                        lst.ForeColor = Color.Crimson;


                    }
                    else if (Convert.ToInt32(dr[6].ToString()) <= (Convert.ToInt32(dr[9].ToString())))
                    {
                        lst.ForeColor = Color.Orange;

                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void InsertTrail()
        {

            try
            {
                string sql = @"INSERT INTO tblLogTrail VALUES(@Dater,@Descrip,@Authority)";
                cm = new SqlCommand(sql, cn);
                cm.Parameters.AddWithValue("@Dater", lblTimer.Text);
                cm.Parameters.AddWithValue("@Descrip", "User: " + lblUser.Text + " has Logged out!");
                cm.Parameters.AddWithValue("@Authority", "Cashier");


                cm.ExecuteNonQuery();
                //   MessageBox.Show("Record successfully saved!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (SqlException l)
            {
                MessageBox.Show("Re-input again. your username may already be taken!");
                MessageBox.Show(l.Message);
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView2.Items.Count > 0)
            {

                MessageBox.Show("Transactions is still in progress. Remove item(s) from CART.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;

            }
            else
            {


                InsertTrail();


                this.Close();

                frmLogin frm1 = new frmLogin();
                frm1.Show();
            }
        }

        private void txtBill_TextChanged(object sender, EventArgs e)
        {

        }
     
    }
}
