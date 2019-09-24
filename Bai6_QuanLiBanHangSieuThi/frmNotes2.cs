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
    public partial class frmNotes2 : Form
    {
        SqlCommand cm;
        SqlConnection cn;
        SqlDataReader dr;
       // string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Data.accdb";
        ListViewItem lst;
        frmLogin login = new frmLogin();

        public frmNotes2()
        {
            InitializeComponent();
            cn = new SqlConnection(login.connection);
            cn.Open();
        }

        private void frmNotes2_Load(object sender, EventArgs e)
        {
            getData();
            timer1.Start();
        }

        public void getData()
        {

            //displaying data from Database to lstview
            try
            {
                listView1.Items.Clear();
                listView1.Columns.Clear();
                listView1.Columns.Add("Order ID", 110);//0
                listView1.Columns.Add("PID", 90);//1
                listView1.Columns.Add("Product Name", 190);//2

                listView1.Columns.Add("Price", 90);//3
                listView1.Columns.Add("Offered Price", 100);//4
                listView1.Columns.Add("Type", 80);//5
                listView1.Columns.Add("Size", 80);//6
                listView1.Columns.Add("Brand", 90);//7
                listView1.Columns.Add("Items to Receive", 190);//8
                listView1.Columns.Add("Manufacturer", 190);//9
                listView1.Columns.Add("Date Orderded", 190);//10
                listView1.Columns.Add("Supposed Arrival Date", 190);//11

                string sql2 = @"Select * from tblOrderNote2";
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
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOrderID.Text = listView1.FocusedItem.Text;
            txtPID.Text = listView1.FocusedItem.SubItems[1].Text;
            txtDesc.Text = listView1.FocusedItem.SubItems[2].Text;
            txtPrice.Text = listView1.FocusedItem.SubItems[3].Text;
            txtNetPrice.Text = listView1.FocusedItem.SubItems[4].Text;



            txtType.Text = listView1.FocusedItem.SubItems[5].Text;
            txtSize.Text = listView1.FocusedItem.SubItems[6].Text;
            txtBrand.Text = listView1.FocusedItem.SubItems[7].Text;
            txtStock.Text = listView1.FocusedItem.SubItems[8].Text;
            txtManufac.Text = listView1.FocusedItem.SubItems[9].Text;
            txtDateOrdered.Text = listView1.FocusedItem.SubItems[10].Text;

            txtExtendDays.Select();

        }
        public void Insert()
        {

            try
            {
                string sql = @"INSERT INTO tblReorder VALUES(@OrderID,@PID,@Descrip,@Price,@NetPrice,@Type,@Size,@Brand,@Stock,@Manufacturer,@DateOrder,@DateDeliver)";
                cm = new SqlCommand(sql, cn);
                cm.Parameters.AddWithValue("@OrderID", txtOrderID.Text);
                cm.Parameters.AddWithValue("@PID", txtPID.Text);
                cm.Parameters.AddWithValue("@Descrip", txtDesc.Text);
                cm.Parameters.AddWithValue("@Price", txtPrice.Text);
                cm.Parameters.AddWithValue("@NetPrice", txtNetPrice.Text);
                cm.Parameters.AddWithValue("@Type", txtType.Text);
                cm.Parameters.AddWithValue("@Size", txtSize.Text);
                cm.Parameters.AddWithValue("@Brand", txtBrand.Text);
                cm.Parameters.AddWithValue("@Stock", txtStock.Text);
                cm.Parameters.AddWithValue("@Manufacturer", txtManufac.Text);
                cm.Parameters.AddWithValue("@DateOrder", txtDateOrdered.Text);
                cm.Parameters.AddWithValue("@DateDeliver", lblTempDate.Text);


                cm.ExecuteNonQuery();


                DeleteNote();
                getData();


            }
            catch (SqlException l)
            {
                MessageBox.Show("Re-input again. your username may already be taken!");
                MessageBox.Show(l.Message);
            }

        }
        public void UpdateDate()
        {

            try
            {
                string up = @"UPDATE tblReorder SET [DateDeliver] = '" + lblTempDate.Text + "' where [IDOrder]='" + txtOrderID.Text + "'";
                cm = new SqlCommand(up, cn);



                cm.Parameters.AddWithValue("@DateDeliver", lblTempDate.Text);
                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No Items to Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteNote()
        {

            try
            {
                listView1.FocusedItem.Remove();
                string del = "DELETE from tblOrderNote2 where OrderID='" + txtOrderID.Text + "'";
                cm = new SqlCommand(del, cn); cm.ExecuteNonQuery();

                // MessageBox.Show("Successfully Deleted!");
                Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("No Item to Remove", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void Clear()
        {
            txtOrderID.Text = "";
            txtExtendDays.Text = "";

        }
        public void DeleteAll()
        {

            try
            {
                //  listView1.FocusedItem.Remove();
                string del = "DELETE from tblOrderNote2";
                cm = new SqlCommand(del, cn); cm.ExecuteNonQuery();

                MessageBox.Show("Successfully Deleted!");

                Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("No Item to Remove", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void txtExtendDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
           // string format = "MM-dd-yyy HH:mm:ss";
            lblTimer.Text = time.ToString();
        }

        private void txtExtendDays_TextChanged(object sender, EventArgs e)
        {
            if (txtExtendDays.Text == "")
            {

                lblTempDate.Text = "";

            }
            else
            {

                //   string format2 = "MMM-dd-yyy HH:mm:ss";
                int arrive = Convert.ToInt32(txtExtendDays.Text);
                DateTime date = Convert.ToDateTime(listView1.FocusedItem.SubItems[11].Text);
                date = date.AddDays(arrive);
                lblTempDate.Text = date.ToString();
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (txtExtendDays.Text == "" || txtOrderID.Text == "")
            {

                MessageBox.Show("Fill the Fields provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                UpdateDate();
                Insert();
                txtExtendDays.Text = "";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtOrderID.Text == "")
            {

                MessageBox.Show("Nothing to Delete!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Doyou really want to DELETE this Order??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                //   AllDelTrail();
                DeleteNote();
                getData();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {

                return;
            }

            if (MessageBox.Show("Do you really want to delete ALL Order??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                //   AllDelTrail();
                DeleteAll();
                getData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmReceiveCrit RI = new frmReceiveCrit();
            RI.Show();
        }

    }
}
