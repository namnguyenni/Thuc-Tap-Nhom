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
    
    public partial class FrmAdminLogin : Form
    {

        SqlCommand cm;
        SqlConnection cn;
        SqlDataReader dr;
        frmLogin login = new frmLogin();
       // public string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Data.accdb";

        public FrmAdminLogin()
        {
            InitializeComponent();
            timer1.Start();
            cn = new SqlConnection(login.connection);
            cn.Open();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmStart frm1 = new frmStart();
            frm1.Show();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string sql = @"Select * from tblAdmin where Username like '" + txtUsername.Text + "' and Password like '" + txtPassword.Text + "'";
            cm = new SqlCommand(sql, cn);
            dr = cm.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
               
                FrmAdminMenu frm7 = new FrmAdminMenu();
                frm7.pass(txtUsername.Text);
                frm7.Show();
                this.Hide();
                dr.Close();
                InsertTrail();
                dr.Close();
                MessageBox.Show("Welcome Admin :)");            
            }
               
            else
            {
                MessageBox.Show("Access Denied! ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
           
        }
        public void InsertTrail()
        {

            try
            {
                string sql = @"INSERT INTO tblLogTrail VALUES(@Dater,@Descrip,@Authority)";
                cm = new SqlCommand(sql, cn);
                cm.Parameters.AddWithValue("@Dater", lblTime.Text);
                cm.Parameters.AddWithValue("@Descrip", "User: " + txtUsername.Text + " has successfully Logged In!");
                cm.Parameters.AddWithValue("@Authority", "Admin");


                cm.ExecuteNonQuery();
                //   MessageBox.Show("Record successfully saved!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (SqlException l)
            {
                MessageBox.Show("Re-input again.");
                MessageBox.Show(l.Message);
            }
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '●';
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
           
            lblTime.Text = time.ToString();
        }
    }
}
