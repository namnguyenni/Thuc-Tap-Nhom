using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KhoHang
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHangHoa frm = new frmHangHoa();
            frm.Show();
        }

        private void họcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frm = new frmNhaCungCap();
            frm.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void nhậpXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhapXuat frm = new frmNhapXuat();
            frm.Show();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHuongDan frm = new frmHuongDan();
            frm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
