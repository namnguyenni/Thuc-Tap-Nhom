using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KetNoiDB;
using BangQLCT;
namespace Bai1_QLNhanSu
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        BUS_NhanVien nhanvien = new BUS_NhanVien();
        int chon = 0;
        TimKiem tk = new TimKiem();
        void KhoaDieuKhien()
        {
            txtMaNV.Enabled = txtHoDem.Enabled = txtTenNV.Enabled =txtGT.Enabled= dtpNgaySinh.Enabled = txtDiaChi.Enabled = txtSDT.Enabled = txtLuong.Enabled = txtChucVu.Enabled = cbMa_NQL.Enabled = cbMaDV.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }
        void MoDieuKhien()
        {
            txtMaNV.Enabled = txtHoDem.Enabled = txtTenNV.Enabled = txtGT.Enabled = dtpNgaySinh.Enabled = txtDiaChi.Enabled = txtSDT.Enabled = txtLuong.Enabled = txtChucVu.Enabled = cbMa_NQL.Enabled = cbMaDV.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }
        void SetNull()
        {
            txtMaNV.Text = txtHoDem.Text = txtTenNV.Text = txtGT.Text = txtSDT.Text = txtDiaChi.Text = txtLuong.Text = "";
            txtChucVu.Text = cbMa_NQL.Text = cbMaDV.Text = "";
            dtpNgaySinh.Text = DateTime.Now.ToShortDateString();
            tscbGT.Text = tstxtDiaChi.Text = tstxtMa.Text = tstxtTen.Text = "";
        }


        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = nhanvien.HienThiNhanVien();
            dgvNhanVien.DataSource = dt;
            KhoaDieuKhien();
            KhoiTao();
        }
        public void KhoiTao()
        {
            txtMaNV.Text = dgvNhanVien.Rows[0].Cells[0].Value.ToString();
            txtHoDem.Text = dgvNhanVien.Rows[0].Cells[1].Value.ToString();
            txtTenNV.Text = dgvNhanVien.Rows[0].Cells[2].Value.ToString();
            txtGT.Text = dgvNhanVien.Rows[0].Cells[4].Value.ToString();
            dtpNgaySinh.Value = DateTime.Parse(dgvNhanVien.Rows[0].Cells[3].Value.ToString());
            txtLuong.Text = dgvNhanVien.Rows[0].Cells[5].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.Rows[0].Cells[6].Value.ToString();
            cbMa_NQL.Text = dgvNhanVien.Rows[0].Cells[7].Value.ToString();
            cbMaDV.Text = dgvNhanVien.Rows[0].Cells[8].Value.ToString();
            txtChucVu.Text = dgvNhanVien.Rows[0].Cells[9].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[0].Cells[10].Value.ToString();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            txtMaNV.Enabled = false;
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
            if (txtMaNV.Text == "")
                MessageBox.Show("mời chọn nhân viên!");
            else
            if (DialogResult.Yes == MessageBox.Show("Bạn muốn xóa nhân viên này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                nhanvien.XoaNhanVien(txtMaNV.Text);
                MessageBox.Show("Xóa thành công!");
                frmNhanVien_Load(sender, e);
                SetNull();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chon == 1)
            {
                if (txtTenNV.Text == "" || txtGT.Text == "" || txtHoDem.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || txtLuong.Text == "" || cbMaDV.Text == "" || cbMa_NQL.Text == "")
                    MessageBox.Show("Mời nhập đầy đủ tất cả thông tin!");
                else
                    if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn thêm nhân viên này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        nhanvien.ThemNhanVien(txtHoDem.Text,txtTenNV.Text,dtpNgaySinh.Text,txtGT.Text,txtLuong.Text,txtDiaChi.Text,cbMa_NQL.Text,cbMaDV.Text,txtChucVu.Text,txtSDT.Text);
                        MessageBox.Show(" đã thêm!");
                        SetNull();
                        frmNhanVien_Load(sender, e);
                    }
            }
            else if (chon == 2)
            {
                if (txtTenNV.Text == "" || txtGT.Text == "" || txtHoDem.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || txtLuong.Text == "" || cbMaDV.Text == "" || cbMa_NQL.Text == "")
                    MessageBox.Show("Mời nhập đầy đủ thông tin!");
                else
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn Sửa nhân viên này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        nhanvien.SuaNhanVien(txtMaNV.Text, txtHoDem.Text, txtTenNV.Text, dtpNgaySinh.Text, txtGT.Text, txtLuong.Text, txtDiaChi.Text, cbMa_NQL.Text, cbMaDV.Text, txtChucVu.Text, txtSDT.Text);
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
                txtMaNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoDem.Text = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTenNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtGT.Text = dgvNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                dtpNgaySinh.Value = DateTime.Parse(dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString());
                txtLuong.Text = dgvNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
                cbMa_NQL.Text = dgvNhanVien.Rows[e.RowIndex].Cells[7].Value.ToString();
                cbMaDV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtChucVu.Text = dgvNhanVien.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtSDT.Text = dgvNhanVien.Rows[e.RowIndex].Cells[10].Value.ToString();
            }
            catch { }
        }

        private void tstxtMa_TextChanged(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = tk.TKMaNhanVien(tstxtMa.Text);
            //KhoiTao();
        }
        private void tstxtTen_TextChanged(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = tk.TKTenNhanVien(tstxtTen.Text);
            //KhoiTao();
        }

        private void tscbGT_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = tk.TKGTNhanVien(tscbGT.Text);
            //KhoiTao();
        }

        private void tstxtDiaChi_TextChanged(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = tk.TKDiaChiNhanVien(tstxtDiaChi.Text);
            //KhoiTao();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
            SetNull();
            chon = 0;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban có chắc muốn thoát ??", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
