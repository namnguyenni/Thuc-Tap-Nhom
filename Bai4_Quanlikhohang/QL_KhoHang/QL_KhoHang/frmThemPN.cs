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
    public partial class frmThemPN : Form
    {
        public frmThemPN()
        {
            InitializeComponent();
        }

        HangHoa hh = new HangHoa();
        NhaCungCap ncc = new NhaCungCap();
        PhieuNhap pn = new PhieuNhap();
        ChiTietPhieuNhap ctpn = new ChiTietPhieuNhap();
        string mahh;
        string tenhh;
        int soluong;
        long gianhap;
        long giaxuat;
        string nsx;
        string thongtin;
        private void frmThemPN_Load(object sender, EventArgs e)
        {
            HienThi();
            cboTenNCC.DataSource = ncc.ShowNCC("");
            cboTenNCC.DisplayMember = "TenNCC";
            cboTenNCC.ValueMember = "MaNCC";
            cboTenNCC.SelectedValue = "MaNCC";
            cboTenNCC.SelectedIndex = 0;
        }

        public void HienThi()
        {
            dgvSP.DataSource = hh.ShowHangHoa("");
        }
        public void SetNull()
        {
            txtTenSP.Text = "";
            txtNSX.Text = "";
            txtMoTa.Text = "";
            numericUpDownGX.Value = numericUpDown2.Value = numericUpDown3.Value = 1;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenhh = txtTenSP.Text;
            soluong = Convert.ToInt32(numericUpDown2.Value.ToString());
            gianhap = long.Parse(numericUpDown3.Value.ToString());
            giaxuat = long.Parse(numericUpDownGX.Value.ToString());
            nsx = txtNSX.Text;
            thongtin = txtMoTa.Text;
            string ma = hh.InsertHangHoa(tenhh, soluong, gianhap, giaxuat, nsx, thongtin);
            MessageBox.Show("Thêm dữ liệu thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HienThi();
            if (dgvSP.SelectedRows.Count > 0)
            {
                dgvSPN.Rows.AddRange(new DataGridViewRow());
                dgvSPN.Rows[dgvSPN.RowCount - 2].Cells[1].Value = ma;
                dgvSPN.Rows[dgvSPN.RowCount - 2].Cells[2].Value = soluong;
                dgvSPN.Rows[dgvSPN.RowCount - 2].Cells[3].Value = gianhap;
                dgvSPN.Rows[dgvSPN.RowCount - 2].Cells[4].Value = soluong * gianhap;
            }
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên sản phẩm !!!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtNSX.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên NSX !!!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMoTa.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin sản phẩm !!!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            try
            {
                string ma = hh.InsertHangHoa(tenhh, soluong, gianhap, giaxuat, nsx, thongtin);
                dgvSPN.Rows.AddRange(new DataGridViewRow());
                dgvSPN.Rows[dgvSPN.RowCount - 2].Cells[1].Value = ma;
                dgvSPN.Rows[dgvSPN.RowCount - 2].Cells[2].Value = soluong;
                dgvSPN.Rows[dgvSPN.RowCount - 2].Cells[3].Value = gianhap;
                dgvSPN.Rows[dgvSPN.RowCount - 2].Cells[4].Value = soluong * gianhap;
                
                MessageBox.Show("Thêm dữ liệu thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThi();
                cboTK.Enabled = true;
                txtTK.Enabled = true;
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
            }
            catch { }
            SetNull();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetNull();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvSPN.Rows.Count; i++)
            {
                if (dgvSPN.Rows[i].Cells[0].Value == dgvSP.Rows[dgvSP.SelectedRows[0].Index].Cells[0].Value)
                {
                    MessageBox.Show("Sản phẩm đã được chọn !!!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (dgvSP.SelectedRows.Count > 0)
            {
                dgvSPN.Rows.AddRange(new DataGridViewRow());
                dgvSPN.Rows[dgvSPN.RowCount - 2].Cells[0].Value = mahh;
                dgvSPN.Rows[dgvSPN.RowCount - 2].Cells[1].Value = numericUpDownSL.Value;
                dgvSPN.Rows[dgvSPN.RowCount - 2].Cells[2].Value = numericUpDownGN.Value;
                dgvSPN.Rows[dgvSPN.RowCount - 2].Cells[3].Value = int.Parse(numericUpDownSL.Value.ToString()) * long.Parse(numericUpDownGN.Value.ToString());
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            try
            {
                dgvSPN.Rows.RemoveAt(indexSPN);
                indexSPN--;
            }
            catch
            {

            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            frmThemPN_Load(sender, e);
            dgvSPN.Rows.Clear();
            numericUpDownSL.Value = 1;
        }
        int indexSP = 0;
        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexSP = e.RowIndex;
            mahh = dgvSP.Rows[e.RowIndex].Cells[0].Value.ToString();
            soluong = int.Parse(numericUpDownSL.Value.ToString());
            gianhap = long.Parse(numericUpDownGN.Value.ToString());
            //pictureBox1.Image = Image.FromFile(@"image//laptop//" + sp.LayAnh(dgvSP.Rows[e.RowIndex].Cells[1].Value.ToString()));
        }
        int indexSPN = 0;
        private void dgvSPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexSPN = e.RowIndex;
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (dgvSPN.Rows.Count > 1)
            {
                string mancc = cboTenNCC.SelectedValue.ToString();
                DateTime ngaynhap = dateTimePicker1.Value;
                string mapn = pn.InsertPN(mancc, ngaynhap);

                for (int i = 0; i < dgvSPN.Rows.Count - 1; i++)
                {
                    mahh = dgvSPN.Rows[i].Cells[0].Value.ToString();
                    soluong = int.Parse(dgvSPN.Rows[i].Cells[1].Value.ToString());
                    gianhap = long.Parse(dgvSPN.Rows[i].Cells[2].Value.ToString());
                    long thanhtien = long.Parse(dgvSPN.Rows[i].Cells[3].Value.ToString());
                    ctpn.InsertCTHD(mapn, mahh, soluong, gianhap, thanhtien);
                    pn.addTien(mapn);
                    //sp.UpdateSoLuong(et_sp);
                }
                MessageBox.Show("Thêm dữ liệu thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               // btnTao_Click(sender, e);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
