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
    public partial class frmAddManufac : Form
    {
        SqlConnection cn;
        SqlCommand cm;
       // SqlDataReader dr;
      //  string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Data.accdb";
        frmLogin login = new frmLogin();


        public frmAddManufac()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtName.Text == "")
            {
                MessageBox.Show("Fill textboxes to proceed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {

                try
                {
                    string sql = @"INSERT INTO tblManufacturer VALUES(@ID,@MName)";
                    cm = new SqlCommand(sql, cn);
                    cm.Parameters.AddWithValue("@ID", txtID.Text);
                    cm.Parameters.AddWithValue("@MName", txtName.Text);



                    cm.ExecuteNonQuery();
                    MessageBox.Show("Record successfully saved!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Clear();

                    generateID();

                }
                catch (SqlException l)
                {
                    MessageBox.Show("Re-input again. your Company may already be added to database!");
                    MessageBox.Show(l.Message);
                }




            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            frmAddProduct frmAD = new frmAddProduct();
           // frmAD.getManufacturer();
            frmAD.Show();

           this.Dispose();
          
        }

        private void frmAddManufac_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(login.connection);
            cn.Open(); 
            generateID();
        }
        public void generateID()
        {

            var chars = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 5)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            txtID.Text ="MID:" + result;

        }
        public void Clear() 
        {
            txtID.Text = "";
            txtName.Text = "";

        
        }
    }
}
