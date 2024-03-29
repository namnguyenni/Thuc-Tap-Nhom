﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BangKhachSan;
namespace Bai5_QLKhachSan
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        BUS_DangNhap dn = new BUS_DangNhap();

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (dn.DangNhap(txtUserName.Text, txtPass.Text) == true)
            {
               
                MessageBox.Show("Bạn đăng nhập thành công ^^", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmQuanLyKhachSan frm = new frmQuanLyKhachSan();
                frm.Show();
                Hide();
            }
            else MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai. Mời bạn nhập lại !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban có chắc muốn thoát ??", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.ResizeRedraw, true);
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
