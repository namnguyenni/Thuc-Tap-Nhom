using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace skelot
{
    public partial class FrmRegister : Form
    {

        SqlConnection cn;
        SqlCommand cm;
       // SqlDataReader dr;
      //  string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Data.accdb";

        frmLogin login = new frmLogin();
       
        public FrmRegister()
        {
            InitializeComponent();
 
            cn = new SqlConnection(login.connection);
            cn.Open();
            txtCreatePass.PasswordChar = '●';
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FrmAdminMenu frmAD = new FrmAdminMenu();
            frmAD.Show();

    
        }

        public void generateID()
        {

            var chars = "0923213USERASDASDQ";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 5)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            txtUserID.Text ="USR:" + result;

        }

        public void InsertTrail()
        {
            try
            {
                string sql = @"INSERT INTO tblAuditTrail VALUES(@Dater,@Transactype,@Description,@Authority)";
                cm = new SqlCommand(sql, cn);
                cm.Parameters.AddWithValue("@Dater", lblTimer.Text);
                cm.Parameters.AddWithValue("@Transactype", "Insertion");
                cm.Parameters.AddWithValue("@Description", "User:" + txtCreateUser.Text + " has been sent registered!");
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

        private void btnDone_Click(object sender, EventArgs e)
        {

            if (txtCreatePass.Text == "" || txtCreateUser.Text == "" || txtAddress.Text == "" || txtAge.Text == "" || txtContact.Text == "" || txtFullName.Text == "")
            {

                MessageBox.Show("Please Fill all the provided blanks!");

            }
            else {
                //Insertion to DataBase
                try
                {
                    string sql = @"INSERT INTO tblLogin VALUES(@ID,@FullName,@Age,@Address,@Contact,@Username,@Password)";
                    cm = new SqlCommand(sql, cn);
                    cm.Parameters.AddWithValue("@ID", txtUserID.Text);
                    cm.Parameters.AddWithValue("@FullName", txtFullName.Text);
                    cm.Parameters.AddWithValue("@Age", txtAge.Text);
                    cm.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cm.Parameters.AddWithValue("@Contact", txtContact.Text);
                    cm.Parameters.AddWithValue("@Username", txtCreateUser.Text);
                    cm.Parameters.AddWithValue("@Password", txtCreatePass.Text);

                    cm.ExecuteNonQuery();
                    MessageBox.Show("Record successfully saved!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    InsertTrail();
                    this.Clear();
                    generateID();
                }
                catch (SqlException l)
                {
                    MessageBox.Show("Re-input again. your username may already be taken!");
                    MessageBox.Show(l.Message);
                }
            
            }

        }
        public void Clear()
        {
            txtContact.Text = "";
            txtAddress.Text = "";
            txtAge.Text = "";
            txtFullName.Text = "";
            txtCreateUser.Text = "";
            txtCreatePass.Text = "";
           
        
            }

        private void txtCreatePass_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            timer1.Start();
            generateID();
        }

        private void txtCreateUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            //   string format = "MMM-dd-yyy HH:mm:ss";
            lblTimer.Text = time.ToString();
         
        }
    }
}
