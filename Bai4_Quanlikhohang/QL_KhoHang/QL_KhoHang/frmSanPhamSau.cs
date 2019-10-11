using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace QL_KhoHang
{
    public partial class frmHangHoa : Form
    {
        public frmHangHoa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        HangHoa hh = new HangHoa();
        public void HienThi()
        {
            dataGridView1.DataSource = hh.ShowHangHoa("");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaSP.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenSP.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSL.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtGN.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtGB.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();               
                txtNSX.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtMoTa.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch { }
        }
        private void txttk_TenHH_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = hh.TKHH_TenHH(txttk_TenHH.Text);

        }
        private void txttk_NSX_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = hh.TKHH_NSX(txttk_NSX.Text);
        }

        private void txtGB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
