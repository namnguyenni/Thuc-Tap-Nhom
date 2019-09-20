using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BangKhachSan;
using KetNoiDB;
namespace Bai5_QLKhachSan
{
    public partial class frmDoDungTheoPhong : Form
    {
        string ma;
        public frmDoDungTheoPhong()
        {
            InitializeComponent();
        }
        public frmDoDungTheoPhong(string _ma)
        {
            ma = _ma;
            InitializeComponent(); 
        }

        BUS_DoDung dodung = new BUS_DoDung();
        private void frmDoDungTheoPhong_Load(object sender, EventArgs e)
        {
            if (ma != null) HienThi("where MaPhong = '" + ma + "'");
            else HienThi("");
        }
        public void HienThi(string DieuKien) 
        {
            txtMaPhong.Text = ma;
            dgvDodung.DataSource = dodung.HienThiDoDung(DieuKien);
        }

        private void dgvDodung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDoDung.Text = dgvDodung.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTen.Text = dgvDodung.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSoLuong.Text = dgvDodung.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDonVi.Text = dgvDodung.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtTinhTrang.Text = dgvDodung.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
