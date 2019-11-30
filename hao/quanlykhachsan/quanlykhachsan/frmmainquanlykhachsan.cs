using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace quanlykhachsan
{
    public partial class frmmainquanlykhachsan : Form
    {
        public frmmainquanlykhachsan()
        {
            InitializeComponent();
        }
       
        private void frm_load(object sender, EventArgs e)
        {
            frmmain frm = new frmmain();
            frm.MdiParent = this;
            frm.Show();
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmthongtinphong frm = new frmthongtinphong();
             frm.MdiParent = this;
            frm.Show();
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmdangnhap frm = new frmdangnhap();
            frm.Show();
        }

        private void quảnLýThôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmkhachhang frm = new frmkhachhang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnhanvien frm = new frmnhanvien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void báoCáoThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbaocao frm = new frmbaocao();
            frm.MdiParent = this;
            frm.Show();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmain frm = new frmmain();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
