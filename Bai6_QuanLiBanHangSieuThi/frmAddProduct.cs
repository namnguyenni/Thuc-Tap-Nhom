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
    public partial class frmAddProduct : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
       // string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Data.accdb";

        ListViewItem lst;
        frmLogin login = new frmLogin();

        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
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

        private void Form11_Load(object sender, EventArgs e)
        {
            cboGender.SelectedIndex = 0;
            cboSize.SelectedIndex = 0;
            cboManufac.SelectedIndex = 0;
            cn = new SqlConnection(login.connection);
            cn.Open();
            getData();
            generateID();
            generateOrderID();
            getManufacturer();
            timer1.Start();
          
        }
      
        private void btnUpdateI_Click(object sender, EventArgs e)
        {

        }
        public void CLear() 
        {
          //  txtIDCode.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            cboGender.Text = "-SELECT-";
            cboSize.Text = "-SELECT-";
            txtBrand.Text = "";
            txtStock.Text = "";
            
        
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
           

            if (txtPrice.Text == "")
            {


            }
            else 
            {

                try
                {


                }
                catch (FormatException)
                {
                    MessageBox.Show("Enter Numbers Only.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPrice.Text = "0.00";


                }
            
            }

          

        }

        private void txtIDCode_TextChanged(object sender, EventArgs e)
        {
           
        }
        public void generateID()
    {

        var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        var random = new Random();
        var result = new string(
            Enumerable.Repeat(chars, 5)
                      .Select(s => s[random.Next(s.Length)])
                      .ToArray());
        txtIDCode.Text = "ID:" + result;
        
        
        
        }

        public void generateOrderID()
        {

            var chars = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 5)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            txtOrderID.Text ="OrID:"+ result;



        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FrmAdminMenu frmAM = new FrmAdminMenu();
            frmAM.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTempID.Text = listView1.FocusedItem.Text;
            lblTempName.Text = listView1.FocusedItem.SubItems[2].Text;            
        }


        private void txtDeliveryDate_TextChanged(object sender, EventArgs e)
        {


           
            if (txtDeliveryDate.Text == "")
            {

                lblTempDate.Text = "";

            }
            else 
            {
                
            //    string format2 = "MMM-dd-yyy HH:mm:ss";
                int arrive = Convert.ToInt32(txtDeliveryDate.Text);
                DateTime date = Convert.ToDateTime(lblDate.Text);
                date = date.AddDays(arrive);
             
                lblTempDate.Text = date.ToString();
            
            
            
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
         //   string format = "MMM-dd-yyy HH:mm:ss";
            //lblTimer.Text = time.ToString(format);
            lblDate.Text = time.ToString();

        }


        public void getData()
        {
            //displaying data from Database to lstview
            try
            {
                listView1.Items.Clear();
                listView1.Columns.Clear();
                listView1.Columns.Add("Order ID", 90);
                listView1.Columns.Add("PID", 90);
                listView1.Columns.Add("Product Name", 190);

                listView1.Columns.Add("Price", 90);
                listView1.Columns.Add("Offered Price", 100);
                listView1.Columns.Add("Type", 80);
                listView1.Columns.Add("Size", 80);
                listView1.Columns.Add("Brand", 90);
                listView1.Columns.Add("Items to Receive", 190);
                listView1.Columns.Add("Manufacturer", 190);
                listView1.Columns.Add("Date Orderded", 190);
                listView1.Columns.Add("Date of Delivery", 190);
                listView1.Columns.Add("CritLimit", 90);

                string sql2 = @"Select * from tblNewOrder";
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

        private void btnAddOrder(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPrice.Text == "" || txtNetPrice.Text == "" || txtStock.Text == "" || cboGender.Text == "-Gender-" || cboManufac.Text == "-Select-" || cboSize.Text == "-Size-" || txtDeliveryDate.Text == "" || txtCritLimit.Text == "")
            {
                MessageBox.Show("Fill textboxes to proceed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(Convert.ToDouble(txtPrice.Text) < Convert.ToDouble(txtNetPrice.Text))
            {
                MessageBox.Show("The Price Should not be more than that to It's NetPrice","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            int x = 100;
            int y = Convert.ToInt32(txtStock.Text);
                if(y > x)
                {

                    MessageBox.Show("Quantity Should not exceed 100!","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

          


            else 
            {
                try
                {
                    string sql = @"INSERT INTO tblNewOrder VALUES(@IDOrder,@PID,@Descrip,@Price,@NetPrice,@Type,@Size,@Brand,@Stock,@Manufacturer,@DateOrdered,@DateDelivery,@CritLimit)";
                    cm = new SqlCommand(sql, cn);
                    cm.Parameters.AddWithValue("@IDOrder", txtOrderID.Text);
                    cm.Parameters.AddWithValue("@PID", txtIDCode.Text);
                    cm.Parameters.AddWithValue("@Descrip", txtName.Text);
                    cm.Parameters.AddWithValue("@Price", txtPrice.Text);
                    cm.Parameters.AddWithValue("@NetPrice", txtNetPrice.Text);
                    cm.Parameters.AddWithValue("@Type", cboGender.Text);
                    cm.Parameters.AddWithValue("@Size", cboSize.Text);
                    cm.Parameters.AddWithValue("@Brand", txtBrand.Text);
                    cm.Parameters.AddWithValue("@Stock", txtStock.Text);
                    cm.Parameters.AddWithValue("@Manufacturer", cboManufac.Text);
                    cm.Parameters.AddWithValue("@DateOrdered", lblDate.Text);
                    cm.Parameters.AddWithValue("@DateDelivery", lblTempDate.Text);
                    cm.Parameters.AddWithValue("@CritLimit" , txtCritLimit.Text);

                    cm.ExecuteNonQuery();
                    MessageBox.Show("Record successfully saved!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InsertTrail();
                    this.Clear();
                    cboGender.SelectedIndex = 0;
                    cboSize.SelectedIndex = 0;
                    cboManufac.SelectedIndex = 0;
                    txtCritLimit.Text = "";
                    getData();
                    generateID();
                    generateOrderID();
                }
                catch (SqlException l)
                {
                    MessageBox.Show("Re-input again. ID may already be taken!");
                    MessageBox.Show(l.Message);
                }
            
            }
    
        }
        public void InsertTrail()
        {
            try
            {
                string sql = @"INSERT INTO tblAuditTrail VALUES(@Dater,@Transactype,@Description,@Authority)";
                cm = new SqlCommand(sql, cn);
                cm.Parameters.AddWithValue("@Dater", lblDate.Text);
                cm.Parameters.AddWithValue("@Transactype", "Insertion");
                cm.Parameters.AddWithValue("@Description", "Order:" + txtOrderID.Text + " has been sent to orders!");
                cm.Parameters.AddWithValue("@Authority", "Admin");


                cm.ExecuteNonQuery();
                //   MessageBox.Show("Record successfully saved!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (SqlException l)
            {
                MessageBox.Show("Re-input again. your username may already be taken!");
                MessageBox.Show(l.Message);
            }
        }
        public void DeleteTrail() 
        {
            try
            {
                string sql = @"INSERT INTO tblAuditTrail VALUES(@Dater,@Transactype,@Description,@Authority)";
                cm = new SqlCommand(sql, cn);
                cm.Parameters.AddWithValue("@Dater", lblDate.Text);
                cm.Parameters.AddWithValue("@Transactype", "Deletion");
                cm.Parameters.AddWithValue("@Description", "Item: " + lblTempName.Text + " has been removed from orders!");
                cm.Parameters.AddWithValue("@Authority", "Admin");


                cm.ExecuteNonQuery();
                //   MessageBox.Show("Record successfully saved!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (SqlException l)
            {
                MessageBox.Show("Re-input again. your username may already be taken!");
                MessageBox.Show(l.Message);
            }


        }
        public void AllDelTrail()
        {

            try
            {
                string sql = @"INSERT INTO tblAuditTrail VALUES(@Dater,@Transactype,@Description,@Authority)";
                cm = new SqlCommand(sql, cn);
                cm.Parameters.AddWithValue("@Dater", lblDate.Text);
                cm.Parameters.AddWithValue("@Transactype", "Deletion");
                cm.Parameters.AddWithValue("@Description", "All Items from orders were REMOVED!");
                cm.Parameters.AddWithValue("@Authority", "Admin");

                cm.ExecuteNonQuery();
               
            }
            catch (SqlException l)
            {
                MessageBox.Show("Re-input again. your username may already be taken!");
                MessageBox.Show(l.Message);
            }

        }
        public void Clear() 
        {

           // txtOrderID.Text = "";
           // txtIDCode.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtNetPrice.Text = "";
            txtStock.Text = "";
            txtDeliveryDate.Text = "";
            txtBrand.Text = "";
         
            lblTempID.Text = "";
        
        }

        private void txtDeliveryDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtNetPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void button2_Click(object sender, EventArgs e)
        {
           this.Dispose();
            frmAddManufac frmManufac = new frmAddManufac();
            frmManufac.ShowDialog();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            getManufacturer();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0 || lblTempID.Text == "")
            {
                MessageBox.Show("Nothing to Delete!. Please Select an item.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else 
            {
                if (MessageBox.Show("Do you really want to delete this Order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    DeleteTrail();
                    deleteRecords();                  
                }
            }       
        }
        public void deleteRecords()
        {
            try
            {
             
             //   listView1.FocusedItem.Remove();
                string del = "DELETE from tblNewOrder where IDOrder='" + lblTempID.Text + "'";
                cm = new SqlCommand(del, cn); cm.ExecuteNonQuery();

                MessageBox.Show("Successfully Deleted!");
                Clear();
                getData();
                generateID();
                generateOrderID();

            }
            catch (Exception)
            {
                MessageBox.Show("No Item to Remove", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count == 0)
            {

                return;
            }

            if (MessageBox.Show("Do you really want to delete ALL Order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                AllDelTrail();
                DeleteAll();
                generateID();
                generateOrderID();
               
            }
        }
        public void DeleteAll()
        {

            try
            {

                // listView1.FocusedItem.Remove();
                string del = "DELETE * from tblNewOrder ";
                cm = new SqlCommand(del, cn); cm.ExecuteNonQuery();

                MessageBox.Show("Successfully Deleted!");
                getData();
                Clear();
                
            }
            catch (Exception)
            {
                MessageBox.Show("No Item to Remove", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void cboManufac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCritLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
