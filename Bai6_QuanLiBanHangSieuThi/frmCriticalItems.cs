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
    public partial class frmCriticalItems : Form
    {

        SqlCommand cm;
        SqlConnection cn;
        SqlDataReader dr;
       // string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Data.accdb";
        ListViewItem lst;
        frmLogin login = new frmLogin();


        public frmCriticalItems()
        {
            InitializeComponent();
            cn = new SqlConnection(login.connection);
            cn.Open();
           
        }

        public void Clear() 
        {


            txtStock.Text = "";
            txtBrand.Text = "";
            txtName.Text = "";
            txtIDCode.Text = "";
            txtOrderID.Text = "";
            txtNetPrice.Text = "";
            txtPrice.Text = "";
            txtSize.Text = "";
            cboManufac.Text = "";
            txtType.Text = "";
            txtDays.Text = "";
            cboManufac.Text = "";
        
        }
        public void generateID()
        {

            var chars = "#123123PAKKALISUDANINGPROGRAMMING!";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 5)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            txtOrderID.Text ="RoID:" + result;



        }
        public void getOutStock()
        {
            //displaying data from Database to lstview
          //  try
           // {
                listView2.Items.Clear();
                listView2.Columns.Clear();
                listView2.Columns.Add("Product ID", 100);
                listView2.Columns.Add("Product Name", 210);

                listView2.Columns.Add("Price", 90);
                listView2.Columns.Add("Offered Price", 100);
                listView2.Columns.Add("Type", 80);
                listView2.Columns.Add("Size", 100);
                listView2.Columns.Add("Brand", 80);
                listView2.Columns.Add("Stock", 95);
                listView2.Columns.Add("Manufacturer", 100);
                listView2.Columns.Add("CritLimit", 95);

                string sql2 = @"Select * from tblProduct where Stock like '" + 0 + "' ";
                cm = new SqlCommand(sql2, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    lst = listView2.Items.Add(dr[0].ToString());//ID
                    lst.SubItems.Add(dr[1].ToString());//NAme
                    lst.SubItems.Add(dr[2].ToString());//Price
                    lst.SubItems.Add(dr[7].ToString());//Net Price
                    lst.SubItems.Add(dr[3].ToString());//Type
                    lst.SubItems.Add(dr[4].ToString());//Size
                    lst.SubItems.Add(dr[5].ToString());//Brand
                    lst.SubItems.Add(dr[6].ToString());//Stock
                    lst.SubItems.Add(dr[8].ToString());//Manufacturer
                    lst.SubItems.Add(dr[9].ToString());
                

                    if (Convert.ToInt32(dr[6].ToString()) == 0)
                    {

                        lst.ForeColor = Color.Crimson;


                    }
                    else if (Convert.ToInt32(dr[6].ToString()) < Convert.ToInt32(dr[9].ToString()))
                    {
                        lst.ForeColor = Color.Orange;

                    }
                }
                dr.Close();
         //   }
          //  catch (Exception ex)
          //  {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         //   }
        }
        public void Search()
        {
            //displaying data from Database to lstview
            //  try
            // {
            listView2.Items.Clear();
            listView2.Columns.Clear();
            listView2.Columns.Add("Product ID", 100);
            listView2.Columns.Add("Product Name", 210);

            listView2.Columns.Add("Price", 90);
            listView2.Columns.Add("Offered Price", 100);
            listView2.Columns.Add("Type", 80);
            listView2.Columns.Add("Size", 100);
            listView2.Columns.Add("Brand", 80);
            listView2.Columns.Add("Stock", 95);
            listView2.Columns.Add("Manufacturer", 100);

            listView2.Columns.Add("CritLimit", 95);

            string sql2 = @"Select * from tblProduct where Descrip like '" + txtSearch.Text + "%'";
            cm = new SqlCommand(sql2, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                lst = listView2.Items.Add(dr[0].ToString());//ID
                lst.SubItems.Add(dr[1].ToString());//NAme
                lst.SubItems.Add(dr[2].ToString());//Price
                lst.SubItems.Add(dr[7].ToString());//Net Price
                lst.SubItems.Add(dr[3].ToString());//Type
                lst.SubItems.Add(dr[4].ToString());//Size
                lst.SubItems.Add(dr[5].ToString());//Brand
                lst.SubItems.Add(dr[6].ToString());//Stock
                lst.SubItems.Add(dr[8].ToString());//Manufacturer
                lst.SubItems.Add(dr[9].ToString());

                if (Convert.ToInt32(dr[6].ToString()) == 0)
                {

                    lst.ForeColor = Color.Crimson;


                }
                else if (Convert.ToInt32(dr[6].ToString()) < Convert.ToInt32(dr[9].ToString()))
                {
                    lst.ForeColor = Color.Orange;

                }
            }
            dr.Close();
            //   }
            //  catch (Exception ex)
            //  {
            //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //   }
        }




        public void getUnderStock()
        {
            //displaying data from Database to lstview
         //   try
         //   {
                listView2.Items.Clear();
                listView2.Columns.Clear();
                listView2.Columns.Add("Product ID", 100);
                listView2.Columns.Add("Product Name", 210);
                listView2.Columns.Add("Price", 90);
                listView2.Columns.Add("Offered Price", 100);
                listView2.Columns.Add("Type", 80);
                listView2.Columns.Add("Size", 100);
                listView2.Columns.Add("Brand", 80);
                listView2.Columns.Add("Stock", 95);
                listView2.Columns.Add("Manufacturer", 170);
                listView2.Columns.Add("CritLimit", 95);

                string sql2 = @"Select * from tblProduct";
                cm = new SqlCommand(sql2, cn);
                dr = cm.ExecuteReader();
                while (dr.Read() == true)
                {

                    if ((Convert.ToInt64(dr[6]) <= Convert.ToInt32(dr[9].ToString())) && Convert.ToInt64(dr[6]) >= 1)
                    {

                        lst = listView2.Items.Add(dr[0].ToString());//ID
                        lst.SubItems.Add(dr[1].ToString());//NAme
                        lst.SubItems.Add(dr[2].ToString());//Price
                        lst.SubItems.Add(dr[7].ToString());//Net Price
                        lst.SubItems.Add(dr[3].ToString());//Type
                        lst.SubItems.Add(dr[4].ToString());//Size
                        lst.SubItems.Add(dr[5].ToString());//Brand
                        lst.SubItems.Add(dr[6].ToString());//Stock
                        lst.SubItems.Add(dr[8].ToString());//Manufacturer
                        lst.SubItems.Add(dr[9].ToString());

                        if (Convert.ToInt32(dr[6].ToString()) == 0)
                        {

                            lst.ForeColor = Color.Crimson;


                        }
                        else if (Convert.ToInt32(dr[6].ToString()) < Convert.ToInt32(dr[9].ToString()))
                        {
                            lst.ForeColor = Color.Orange;

                        }
                    }
                }
                dr.Close();
           // }
            //catch (Exception ex)
           // {
               // MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           // }
        }

    
        private void frmCriticalItems_Load(object sender, EventArgs e)
        {
            cboManufac.SelectedIndex = 0;
           
            generateID();
            getManufacturer();
            timer1.Start();
        }

        public void getManufacturer()
        {

            try
            {


                string sql2 = @"Select * from tblManufacturer";
                cm = new SqlCommand(sql2, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    cboManufac.Items.Add(dr[1].ToString());

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void cboItems_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cboItems.Text == "Out of Stock")
            {
                getOutStock();
            }else if(cboItems.Text == "Under Stock")
            {
                getUnderStock();
            }else if(cboItems.Text == "-SELECT-")
            {

                listView2.Items.Clear();
            
            }


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
   
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAdminMenu frmAM = new FrmAdminMenu();
            this.Dispose();
            frmAM.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            
        }


        public void InsertToReorder()
        {

            if (txtStock.Text == "" || cboManufac.Text == "" || txtDays.Text == "")
            {
                MessageBox.Show("Fill the textBoxes!");


            }
            else
            {
                try
                {
                    string sql = @"INSERT INTO tblReorder VALUES(@IDOrder,@PID,@Descrip,@Price,@NetPrice,@Type,@Size,@Brand,@Manufacturer,@Stock,@Manufacturer,@OrderDate,@DateDeliver)";
                    cm = new SqlCommand(sql, cn);
                    cm.Parameters.AddWithValue("@IDOrder", txtOrderID.Text);
                    cm.Parameters.AddWithValue("@PID", txtIDCode.Text);
                    cm.Parameters.AddWithValue("@Descrip", txtName.Text);
                    cm.Parameters.AddWithValue("@Price", txtPrice.Text);
                    cm.Parameters.AddWithValue("@NetPrice", txtNetPrice.Text);
                    cm.Parameters.AddWithValue("@Type", txtType.Text);
                    cm.Parameters.AddWithValue("@Size", txtSize.Text);
                    cm.Parameters.AddWithValue("@Brand", txtBrand.Text);
               
                    cm.Parameters.AddWithValue("@Stock", txtStock.Text);
                    cm.Parameters.AddWithValue("@Manufacturer", cboManufac.Text);
                  
             
                    cm.Parameters.AddWithValue("@OrderDate", lblDate.Text);
                    cm.Parameters.AddWithValue("@DateDeliver", lblTempDate.Text);

                    cm.ExecuteNonQuery();
                    MessageBox.Show("Record successfully saved!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   


                    Clear();
                }
                catch (SqlException l)
                {
                    MessageBox.Show("RE INPUT AGAIN!!!!");
                    MessageBox.Show(l.Message);
                }

            }
        }
        
        
        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtQuantity.Select();
         
       //     txtCurrStock.Text = listView1.FocusedItem.SubItems[6].Text;
         //   txtNetPrice.Text = listView1.FocusedItem.SubItems[7].Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
           // string format = "MM-dd-yyy HH:mm:ss";
            
            lblDate.Text = time.ToString();
        }

        private void txtAddStock_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void cboManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void lblTempDate_Click(object sender, EventArgs e)
        {

        }
   
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            txtIDCode.Text = listView2.FocusedItem.Text;
            txtName.Text = listView2.FocusedItem.SubItems[1].Text;
            txtNetPrice.Text = listView2.FocusedItem.SubItems[3].Text;
            txtPrice.Text = listView2.FocusedItem.SubItems[2].Text;
            txtType.Text = listView2.FocusedItem.SubItems[4].Text;
            txtSize.Text = listView2.FocusedItem.SubItems[5].Text;
            txtBrand.Text = listView2.FocusedItem.SubItems[6].Text;
            lblCurrStock.Text = listView2.FocusedItem.SubItems[7].Text;
            cboManufac.Text = listView2.FocusedItem.SubItems[8].Text;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void InsertTrail()
        {

            try
            {
                string sql = @"INSERT INTO tblAuditTrail VALUES(@Dater,@Transactype,@Description,@Authority)";
                cm = new SqlCommand(sql, cn);

                cm.Parameters.AddWithValue("@Dater", lblDate.Text);
                cm.Parameters.AddWithValue("@Transactype", "Insertion");
                cm.Parameters.AddWithValue("@Description", "REOrder: " + txtOrderID.Text + " has been sent to orders form!");
                cm.Parameters.AddWithValue("@Authority", "Admin");


                cm.ExecuteNonQuery();

            }
            catch (SqlException l)
            {
                MessageBox.Show("Re-input again.");
                MessageBox.Show(l.Message);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            Search();
        }

        private void lblCurrStock_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FrmAdminMenu frmAM = new FrmAdminMenu();
            frmAM.Show();
        }

        private void txtDays_TextChanged(object sender, EventArgs e)
        {

            if (txtDays.Text == "")
            {

                lblTempDate.Text = "";

            }
            else
            {

               // string format2 = "MMM-dd-yyy HH:mm:ss";
                int arrive = Convert.ToInt32(txtDays.Text);
                DateTime date = Convert.ToDateTime(lblDate.Text);
                date = date.AddDays(arrive);
                lblTempDate.Text = date.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (txtName.Text == "" || txtPrice.Text == "" || txtNetPrice.Text == "" || txtStock.Text == "" || txtType.Text == "" || cboManufac.Text == "-Select-" || txtSize.Text == "" || txtDays.Text == "")
            {
                MessageBox.Show("Fill textboxes to proceed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int x = 100;
            int y = Convert.ToInt32(txtStock.Text);
            if (y > x)
            {

                MessageBox.Show("Quantity Should not exceed 100!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
              InsertTrail();
           
                try
                {
                    string sql = @"INSERT INTO tblReorder VALUES(@IDOrder,@PID,@Descrip,@Price,@NetPrice,@Type,@Size,@Brand,@Stock,@Manufacturer,@DateOrdered,@DateDelivery)";
                    cm = new SqlCommand(sql, cn);
                    cm.Parameters.AddWithValue("@IDOrder", txtOrderID.Text);
                    cm.Parameters.AddWithValue("@PID", txtIDCode.Text);
                    cm.Parameters.AddWithValue("@Descrip", txtName.Text);
                    cm.Parameters.AddWithValue("@Price", txtPrice.Text);
                    cm.Parameters.AddWithValue("@NetPrice", txtNetPrice.Text);
                    cm.Parameters.AddWithValue("@Type", txtType.Text);
                    cm.Parameters.AddWithValue("@Size", txtSize.Text);
                    cm.Parameters.AddWithValue("@Brand", txtBrand.Text);
                    cm.Parameters.AddWithValue("@Stock", txtStock.Text);
                    cm.Parameters.AddWithValue("@Manufacturer", cboManufac.Text);
                    cm.Parameters.AddWithValue("@DateOrdered", lblDate.Text);
                    cm.Parameters.AddWithValue("@DateDelivery", lblTempDate.Text);


                    cm.ExecuteNonQuery();
                    MessageBox.Show("Record successfully saved!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Clear();
                    cboManufac.SelectedIndex = 0;
                    
                    generateID();            
                }
                catch (SqlException l)
                {
                    MessageBox.Show("Re-input again. OrderID may already be taken!");
                    MessageBox.Show(l.Message);
                }          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            frmUpdateLimit UL = new frmUpdateLimit();
            UL.Show();
        }
    }
}
