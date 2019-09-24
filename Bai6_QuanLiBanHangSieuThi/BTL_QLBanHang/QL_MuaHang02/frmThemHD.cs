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
using Entity;
using System.IO;

namespace QuanLyBanHang
{
    public partial class frmThemHD : Form
    {
        public frmThemHD()
        {
            InitializeComponent();
        }
        SanPham sp = new SanPham();
        LoaiHang lh = new LoaiHang();
        NhaCungCap ncc = new NhaCungCap();
        HoaDonNhap hd = new HoaDonNhap();
        CTHD cthd = new CTHD();
        EC_CTHD et_cthd = new EC_CTHD();
        EC_HOADONNHAP et_hdn = new EC_HOADONNHAP();
        EC_SANPHAM et_sp = new EC_SANPHAM();
        public string tenAnh;
        
        private void frmThemHD_Load(object sender, EventArgs e)
        {
            HienThi();
            cboTenNCC.DataSource = ncc.ShowNCC("");
            cboTenNCC.DisplayMember = "TenNCC";
            cboTenNCC.ValueMember = "MaNCC";
            cboTenNCC.SelectedValue = "MaNCC";
            cboTenNCC.SelectedIndex = 0;
            cboTK.SelectedIndex = 0;
            if (dgvSP.Rows.Count > 1)
            {
                et_sp.MaSP = dgvSP.Rows[0].Cells[1].Value.ToString();
                et_sp.SoLuong = int.Parse(numericUpDownSL.Value.ToString());
                et_sp.GiaNhap = long.Parse(numericUpDownGN.Value.ToString());
            }
            //pictureBox1.Image = Image.FromFile(@"image//laptop//" + sp.LayAnh(dgvSP.Rows[0].Cells[1].Value.ToString()));
        }

        public void HienThi()
        {

            dgvSP.DataSource = sp.ShowSanPham("");

            for (int i = 0; i < dgvSP.RowCount - 1; i++) dgvSP.Rows[i].Cells[0].Value = (i + 1).ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dgvSPN.Rows.Count > 1)
            {
                et_hdn.MaNCC = cboTenNCC.SelectedValue.ToString();
                et_hdn.NgayNhap = dateTimePicker1.Value;
                string ma = hd.InsertHDN(et_hdn);
                
                for (int i = 0; i < dgvSPN.Rows.Count - 1; i++)
                {
                    et_cthd.MaHD = ma;
                    et_cthd.MaSP = et_sp.MaSP = dgvSPN.Rows[i].Cells[1].Value.ToString();
                    et_sp.SoLuong = et_cthd.SoLuong = int.Parse(dgvSPN.Rows[i].Cells[2].Value.ToString());
                    et_cthd.GiaNhap = long.Parse(dgvSPN.Rows[i].Cells[3].Value.ToString());
                    et_cthd.ThanhTien = long.Parse(dgvSPN.Rows[i].Cells[4].Value.ToString());
                    cthd.InsertCTHD(et_cthd);
                    sp.UpdateSoLuong(et_sp);
                }
                MessageBox.Show("Thêm dữ liệu thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnTao_Click(sender, e);

                frmInHDB frm = new frmInHDB(ma, false);
                frm.Show();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvSPN.Rows.Count; i++)
            {
                if (dgvSPN.Rows[i].Cells[1].Value == dgvSP.Rows[dgvSP.SelectedRows[0].Index].Cells[1].Value) 
                {
                    MessageBox.Show("Sản phẩm đã được chọn !!!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }                    
            }
            if (dgvSP.SelectedRows.Count > 0)
            {
                dgvSPN.Rows.AddRange(new DataGridViewRow());
                dgvSPN.Rows[dgvSPN.RowCount - 2].Cells[1].Value = et_sp.MaSP;
                dgvSPN.Rows[dgvSPN.RowCount - 2].Cells[2].Value = numericUpDownSL.Value;
                dgvSPN.Rows[dgvSPN.RowCount - 2].Cells[3].Value = numericUpDownGN.Value;
                dgvSPN.Rows[dgvSPN.RowCount - 2].Cells[4].Value = int.Parse(numericUpDownSL.Value.ToString()) * long.Parse(numericUpDownGN.Value.ToString());
            }
            for (int i = 0; i < dgvSPN.Rows.Count - 1; i++) dgvSPN.Rows[i].Cells[0].Value = (i + 1).ToString();
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

        private void btnTao_Click(object sender, EventArgs e)
        {
            frmThemHD_Load(sender, e);
            dgvSPN.Rows.Clear();
            numericUpDownSL.Value = 1;
        }

        private void cboTenNCC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboTK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int indexSP = 0;
        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexSP = e.RowIndex;
            et_sp.MaSP = dgvSP.Rows[e.RowIndex].Cells[1].Value.ToString();
            et_sp.SoLuong = int.Parse(numericUpDownSL.Value.ToString());
            et_sp.GiaNhap = long.Parse(numericUpDownGN.Value.ToString());
            //pictureBox1.Image = Image.FromFile(@"image//laptop//" + sp.LayAnh(dgvSP.Rows[e.RowIndex].Cells[1].Value.ToString()));
        }
        int indexSPN = 0;
        private void dgvSPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexSPN = e.RowIndex;
        }

        private void tangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(dgvSPN.Rows[indexSPN].Cells[2].Value.ToString());
                x++;
                dgvSPN.Rows[indexSPN].Cells[2].Value = x.ToString();
                dgvSPN.Rows[indexSPN].Cells[4].Value = (x * float.Parse(dgvSPN.Rows[indexSPN].Cells[3].Value.ToString())).ToString();
            }
            catch { }
        }

        private void giamSôLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(dgvSPN.Rows[indexSPN].Cells[2].Value.ToString());
                if (x == 1) return;
                x--;
                dgvSPN.Rows[indexSPN].Cells[2].Value = x.ToString();
                dgvSPN.Rows[indexSPN].Cells[4].Value = (x * float.Parse(dgvSPN.Rows[indexSPN].Cells[3].Value.ToString())).ToString();
            }
            catch { }
        }
        public void TimKiem(string DieuKien)
        {
            if (cboTK.SelectedIndex != 2) dgvSP.DataSource = sp.ShowSanPham("AND " + DieuKien + " LIKE N'%" + txtTK.Text + "%'");
            else dgvSP.DataSource = sp.ShowSanPham("AND " + DieuKien + " = " + txtTK.Text);
            for (int i = 0; i < dgvSP.RowCount - 1; i++)
            {
                dgvSP.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
            pictureBox1.Image = Image.FromFile(@"image//laptop//" + sp.LayAnh(dgvSP.Rows[0].Cells[1].Value.ToString()));
        }
        private void txtTK_TextChanged(object sender, EventArgs e)
        {
            if (txtTK.Text == "") HienThi();
            else
            {
                if (cboTK.SelectedIndex == 0) TimKiem("MaSP");
                else if (cboTK.SelectedIndex == 1) TimKiem("TenSP");
                else if (cboTK.SelectedIndex == 2) TimKiem("GiaMua");
                else if (cboTK.SelectedIndex == 3) TimKiem("TenLH");
                else if (cboTK.SelectedIndex == 4) TimKiem("NSX");
            }
        }
        public void SetNull()
        {
            txtTenSP.Text = "";
            txtNSX.Text = "";
            txtMoTa.Text = "";
            txtLoiNhuan.Text = "";
            cboLH.DataSource = lh.ShowLoaiHang();
            cboLH.DisplayMember = "TenLH";
            cboLH.ValueMember = "MaLH";
            cboLH.SelectedValue = "MaLH";
            cboLH.SelectedIndex = 0;
            numericUpDown1.Value = numericUpDown2.Value = 1;
            pictureBox1.Image = null;
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            SetNull();
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnOpen.Enabled = true;
        }

        public void GetData()
        {
            et_sp.TenSP = txtTenSP.Text;
            et_sp.MaLH = cboLH.SelectedValue.ToString();
            et_sp.LoiNhuan = float.Parse(txtLoiNhuan.Text);
            et_sp.SoLuong = 0;
            et_sp.GiaNhap = long.Parse(numericUpDown1.Value.ToString());
            et_sp.MoTa = txtMoTa.Text;
            et_sp.NSX = txtNSX.Text;
            et_sp.TenLH = cboLH.Text;
            et_sp.HinhAnh = tenAnh;
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
            if (tenAnh == "")
            {
                MessageBox.Show("Bạn chưa nhập hình ảnh cho sản phẩm !!!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                float.Parse(txtLoiNhuan.Text);
            }
            catch
            {
                MessageBox.Show("Lợi nhuận không hợp lệ !!!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                GetData();
                string ma = sp.InsertSanPham(et_sp);
                dgvSPN.Rows.AddRange(new DataGridViewRow());
                dgvSPN.Rows[dgvSPN.RowCount - 2].Cells[1].Value = ma;
                dgvSPN.Rows[dgvSPN.RowCount - 2].Cells[2].Value = int.Parse(numericUpDown2.Value.ToString());
                dgvSPN.Rows[dgvSPN.RowCount - 2].Cells[3].Value = et_sp.GiaNhap;
                dgvSPN.Rows[dgvSPN.RowCount - 2].Cells[4].Value = int.Parse(numericUpDown2.Value.ToString()) * et_sp.GiaNhap;
                for (int i = 0; i < dgvSPN.Rows.Count - 1; i++) dgvSPN.Rows[i].Cells[0].Value = (i + 1).ToString();
                MessageBox.Show("Thêm dữ liệu thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThi();
                cboTK.Enabled = true;
                txtTK.Enabled = true;
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
            }
            catch { }
            SetNull();
            btnOpen.Enabled = false;
            cboLH.DataSource = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {          
            SetNull();
            btnOpen.Enabled = false;
            cboLH.DataSource = null;
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Chọn Ảnh";
            openFileDialog1.Multiselect = false; // khong cho phep chon nhieu file dong thoi
            openFileDialog1.InitialDirectory = "F:\\";
            openFileDialog1.Filter = "|*.jpg; *.png; *.gif; *.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            tenAnh = Path.GetFileName(openFileDialog1.FileName);
            pictureBox1.Image = Image.FromFile(@"image//laptop//" + tenAnh);
        }
    }
}
