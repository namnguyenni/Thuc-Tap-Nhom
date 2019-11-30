using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using BTL_QLNS.BUS;
namespace BTL_QLNS
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void frmdangky_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void frmmhc_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        User_BUS ub = new User_BUS();
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            String condition;
            condition = " username ='" + txtUsername.Text + "' AND password ='" + txtPassword.Text + "'";
            DataTable dt = new DataTable();
            try
            {
                dt = ub.getUser(condition);
                if (dt.Rows.Count>0)
                {
                    MessageBox.Show("Đăng nhập thành công !");
                    ManHinhChinh frmmhc = new ManHinhChinh();
                    frmmhc.FormClosed += new FormClosedEventHandler(frmmhc_Closed);
                    frmmhc.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công , mời bạn đăng ký !");
                    DangKy frmdk = new DangKy();
                    frmdk.FormClosed += new FormClosedEventHandler(frmdangky_Closed);
                    frmdk.Show();
                    this.Hide();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn đã nhập sai cú pháp");
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi kết nối CSDL !");
            }
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            DangKy frmdk = new DangKy();
            frmdk.FormClosed += new FormClosedEventHandler(frmdangky_Closed);
            frmdk.Show();
            this.Hide();
        }
    }
}
