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

namespace QuanLyBanHang
{
    public partial class frmHoaDonBan : Form
    {
        public frmHoaDonBan()
        {
            InitializeComponent();
        }

        int dong = 0;
        HoaDonBan hdb = new HoaDonBan();
        ChiTietHoaDonBan cthdb = new ChiTietHoaDonBan();
        SanPham sp = new SanPham();
        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            HienThi();

        }

        public void HienThi()
        {
            dgvHoaDon.DataSource = hdb.HienThiHDB();
            for (int i = 0; i < dgvHoaDon.RowCount - 1; i++)
                dgvHoaDon.Rows[i].Cells[0].Value = (i + 1).ToString();

            dgvCTHD.DataSource = cthdb.HienThiCTHDB();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvCTHD.DataSource = cthdb.HienThiCTHDB(dgvHoaDon.Rows[e.RowIndex].Cells[1].Value.ToString());
                dong = e.RowIndex;
            }
            catch { }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = hdb.HienThiHDB(DateTime.Parse(dateTimePicker1Ngay.Text));
            for (int i = 0; i < dgvHoaDon.RowCount - 1; i++)
                dgvHoaDon.Rows[i].Cells[0].Value = (i + 1).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = hdb.HienThiHDB(DateTime.Parse(dateTimePicker1.Text), DateTime.Parse(dateTimePicker2.Text));
            for (int i = 0; i < dgvHoaDon.RowCount - 1; i++)
                dgvHoaDon.Rows[i].Cells[0].Value = (i + 1).ToString();
        }

        private void btnMuaMax_Click(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = hdb.HienThiTop10HDB();
            for (int i = 0; i < dgvHoaDon.RowCount - 1; i++)
                dgvHoaDon.Rows[i].Cells[0].Value = (i + 1).ToString();
        }
        private void comboBoxThongKeTien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxThongKeTien.Text == "<= 500.000")
                dgvHoaDon.DataSource = hdb.HienThiHDB(0, 500000);
            else if (comboBoxThongKeTien.Text == "500.000 -> 2.000.000")
                dgvHoaDon.DataSource = hdb.HienThiHDB(500000, 2000000);
            else if (comboBoxThongKeTien.Text == "2.000.000 -> 5.000.000")
                dgvHoaDon.DataSource = hdb.HienThiHDB(2000000, 5000000);
            else if (comboBoxThongKeTien.Text == "5.000.000 -> 10.000.000")
                dgvHoaDon.DataSource = hdb.HienThiHDB(5000000, 10000000);
            else if (comboBoxThongKeTien.Text == "> 10.000.000")
                dgvHoaDon.DataSource = hdb.HienThiHDB(10000000, 10000000000);
            else dgvHoaDon.DataSource = hdb.HienThiTop10HDB();

            for (int i = 0; i < dgvHoaDon.RowCount - 1; i++)
                dgvHoaDon.Rows[i].Cells[0].Value = (i + 1).ToString();
        }

        private void dgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblTenSP.Text = dgvCTHD.Rows[e.RowIndex].Cells[2].Value.ToString();
                picSP.Image = null;
                picSP.Image = Image.FromFile(@"image/LapTop//" + sp.LayAnh(dgvCTHD.Rows[e.RowIndex].Cells[1].Value.ToString()));
                picSP.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch { }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn Muốn In Hóa Đơn Này?", "Question", MessageBoxButtons.OK) == DialogResult.OK)
            {
                frmInHDB frm = new frmInHDB(dgvHoaDon.Rows[dong].Cells[1].Value.ToString(), true);
                frm.Show();
            }
        }
    }
}
