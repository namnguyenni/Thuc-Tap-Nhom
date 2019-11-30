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
    public partial class frmthongtinphong : Form
    {
        public frmthongtinphong()
        {
            InitializeComponent();
        }
        private void hienthi()
        {
            phongBLL pbll = new phongBLL();
            GridView.DataSource = pbll.hienthithongtinphong();
        }
        private void trangthai(bool t)
        {
            txtphong.Enabled = t;
            txtdongiaphong.Enabled = t;
            cbloaiphong.Enabled = t;
            cbtinhtrang.Enabled = t;
        }
        private void frm_load(object sender, EventArgs e)
        {
            hienthi();
            trangthai(false);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = GridView.Rows[e.RowIndex];
            txtphong.Text = row.Cells["maPhong"].Value.ToString();
            txtdongiaphong.Text = row.Cells["donGia"].Value.ToString();
            cbloaiphong.Text= row.Cells["loaiPhong"].Value.ToString();          
            cbtinhtrang.Text =row.Cells["tinhTrang"].Value.ToString();           
        }

        private void btnthemphong_Click(object sender, EventArgs e)
        {
            trangthai(true);
            
        }
    }
}
