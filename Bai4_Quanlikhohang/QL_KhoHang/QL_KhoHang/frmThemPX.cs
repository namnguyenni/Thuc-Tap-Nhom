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
    public partial class frmThemPX : Form
    {
        public frmThemPX()
        {
            InitializeComponent();
        }

        HangHoa hh = new HangHoa();
        ChiTietPhieuXuat ctpx = new ChiTietPhieuXuat();
        PhieuXuat px = new PhieuXuat();
        ChiNhanh cn = new ChiNhanh();
        int indexSPX = 0;
        string mahh;
        int soluong;
        long giaxuat;

        private void frmThemPX_Load(object sender, EventArgs e)
        {
            dgvSP.DataSource = hh.ShowHangHoa("");
            cbChiNhanh.DataSource = cn.HienThiKhachHang();
            cbChiNhanh.DisplayMember = "TenCN";
            cbChiNhanh.ValueMember = "MaCN";
            cbChiNhanh.SelectedValue = "MaCN";
            cbChiNhanh.SelectedIndex = 0;
        }

        private void dgvSPX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexSPX = e.RowIndex;
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            try
            {
                dgvSPX.Rows.RemoveAt(indexSPX);
                indexSPX--;
            }
            catch { }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvSPX.Rows.Count; i++)
            {
                if (dgvSPX.Rows[i].Cells[0].Value == dgvSP.Rows[dgvSP.SelectedRows[0].Index].Cells[0].Value)
                {
                    MessageBox.Show("Sản phẩm đã được chọn !!!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (dgvSP.SelectedRows.Count > 0)
            {
                dgvSPX.Rows.AddRange(new DataGridViewRow());
                dgvSPX.Rows[dgvSPX.RowCount - 2].Cells[0].Value = dgvSP.Rows[dgvSP.SelectedRows[0].Index].Cells[0].Value;
                dgvSPX.Rows[dgvSPX.RowCount - 2].Cells[1].Value = numericUpDownSL.Value;
                dgvSPX.Rows[dgvSPX.RowCount - 2].Cells[2].Value = numericUpDownGN.Value;
                dgvSPX.Rows[dgvSPX.RowCount - 2].Cells[3].Value = int.Parse(numericUpDownSL.Value.ToString()) * long.Parse(numericUpDownGN.Value.ToString());
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            frmThemPX_Load(sender, e);
            dgvSPX.Rows.Clear();
            numericUpDownSL.Value = numericUpDownGN.Value = 1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dgvSPX.Rows.Count > 1)
            {
                string macn = cbChiNhanh.SelectedValue.ToString();
                DateTime ngayxuat = dateTimePicker1.Value;
                string mapx = px.InsertPX(macn, ngayxuat);

                for (int i = 0; i < dgvSPX.Rows.Count - 1; i++)
                {
                    mahh = dgvSPX.Rows[i].Cells[0].Value.ToString();
                    soluong = int.Parse(dgvSPX.Rows[i].Cells[1].Value.ToString());
                    giaxuat = long.Parse(dgvSPX.Rows[i].Cells[2].Value.ToString());
                    long thanhtien = long.Parse(dgvSPX.Rows[i].Cells[3].Value.ToString());
                    ctpx.InsertCTPX(mapx, mahh, soluong, giaxuat, thanhtien);
                    px.addTien(mapx);
                }
                MessageBox.Show("Thêm dữ liệu thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
