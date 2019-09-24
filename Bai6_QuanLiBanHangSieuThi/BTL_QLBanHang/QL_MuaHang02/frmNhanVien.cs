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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        NhanVien nv = new NhanVien();
        int chon = 0;
        void KhoaDieuKhien()
        {
            txtTenDn.Enabled = txtMatKhau.Enabled = txtTenNV.Enabled = txtDiaChi.Enabled = txtSDT.Enabled = cbGT.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }
        void MoDieuKhien()
        {
            txtTenDn.Enabled = txtMatKhau.Enabled = txtTenNV.Enabled = txtDiaChi.Enabled = txtSDT.Enabled = cbGT.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }
        void SetNull()
        {
            txtTenDn.Text = txtMatKhau.Text = txtTenNV.Text = txtSDT.Text = txtDiaChi.Text = cbGT.Text = "";
            tscbGT.Text = tstxtDiaChi.Text = tstxtMa.Text = tstxtTen.Text = "";
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = nv.HienThiNhanVien();
            dgvNhanVien.DataSource = dt;
            KhoaDieuKhien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            SetNull();
            chon = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            chon = 2;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtTenDn.Text == "")
                MessageBox.Show("Chọn nhân viên!");
            else
                if (DialogResult.Yes == MessageBox.Show("Bạn muốn xóa nhân viên này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    nv.XoaNhanVien(txtTenDn.Text);
                    MessageBox.Show("Xóa thành công!");
                    frmNhanVien_Load(sender, e);
                    SetNull();
                }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chon == 1)
            {
                if (txtMatKhau.Text == "" || txtTenNV.Text == "" || txtTenDn.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || cbGT.Text == "")
                    MessageBox.Show("Mời nhập đầy đủ thông tin!");
                else
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm nhân viên này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        nv.ThemNhanVien(txtTenDn.Text,txtMatKhau.Text,txtTenNV.Text,cbGT.Text,txtDiaChi.Text,txtSDT.Text);
                        MessageBox.Show("Thêm thành công!");
                        SetNull();
                        frmNhanVien_Load(sender, e);
                    }
            }
            else if (chon == 2)
            {
                if (txtMatKhau.Text == "" || txtTenNV.Text == "" || txtTenDn.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || cbGT.Text == "")
                    MessageBox.Show("Mời nhập đầy đủ thông tin!");
                else
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn Sửa nhân viên này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        nv.SuaNhanVien(txtTenDn.Text, txtMatKhau.Text, txtTenNV.Text, cbGT.Text, txtDiaChi.Text, txtSDT.Text);
                        MessageBox.Show("Sửa thành công!");
                        SetNull();
                        frmNhanVien_Load(sender, e);
                    }
            }
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                txtTenDn.Text = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMatKhau.Text = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTenNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbGT.Text = dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSDT.Text = dgvNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch { }
        }

        private void tstxtMa_TextChanged(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nv.TKTenDN(tstxtMa.Text);
            //KhoiTao();
        }
        private void tstxtTen_TextChanged(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nv.TKTenNV(tstxtTen.Text);
            //KhoiTao();
        }

        private void tscbGT_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nv.TKGTNhanVien(tscbGT.Text);
            //KhoiTao();
        }

        private void tstxtDiaChi_TextChanged(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nv.TKDiaChiNhanVien(tstxtDiaChi.Text);
            //KhoiTao();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
            SetNull();
            chon = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
