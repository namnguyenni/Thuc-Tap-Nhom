using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_QLNhanSu
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.ResizeRedraw, true);
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien nhanvien = new frmNhanVien();
            //nhanvien.MdiParent = this;
            nhanvien.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label1.Text = label1.Text.Substring(2, label1.Text.Length - 2) + label1.Text.Substring(0, 2);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           // label1.ForeColor = Color.Yellow;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
           // label1.ForeColor = Color.Red;
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHuongDan hd = new frmHuongDan();
            hd.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
