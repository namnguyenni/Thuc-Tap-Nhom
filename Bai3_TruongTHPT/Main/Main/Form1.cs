using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giao_Vien gv = new Giao_Vien();
            gv.Show();
        }

        private void họcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hoc_Sinh hs = new Hoc_Sinh();
            hs.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn Muốn Thoát Ứng dụng này?", "Question", MessageBoxButtons.YesNo)==DialogResult.Yes)
                Application.Exit();
        }

        private void thôngTinGiảngDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLGD frm = new QLGD();
            frm.Show();
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHuongDan hd = new frmHuongDan();
            hd.Show();
            Hide();
        }

    }
}
