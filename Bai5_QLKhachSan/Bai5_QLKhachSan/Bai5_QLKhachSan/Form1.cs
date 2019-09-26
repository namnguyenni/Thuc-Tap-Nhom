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
using KetNoiDB;
using BangKhachSan;
namespace Bai5_QLKhachSan
{
    public partial class frmPHONG : Form
    {
        public frmPHONG()
        {
            InitializeComponent();
        }
        BUS_Phong _phong = new BUS_Phong();
        TimKiem tk = new TimKiem();
        int chon = 0;
        void KhoaDieuKhien()
        {
            txtTenphong.Enabled=txtLoaiphong.Enabled= false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnDodung.Enabled = false;
        }

        void MoDieuKhien()
        {
            txtTenphong.Enabled=txtLoaiphong.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnDodung.Enabled = true;
        }

        void SetNull()
        {
            txtMaphong.Text = txtTenphong.Text = txtLoaiphong.Text = "";
            txttk_Maphong.Text = txttk_tenphong.Text = txttk_loaiphong.Text = "";
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
        private void frmPHONG_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = _phong.HienThiPhong();
            dgvPhong.DataSource = dt;
            KhoaDieuKhien();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn muốn xóa nhân viên này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                _phong.XoaPhong(txtMaphong.Text);
                MessageBox.Show("Xóa thành công!");
                frmPHONG_Load(sender, e);
                SetNull();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chon == 1)
            {
                if (txtTenphong.Text == "" || txtLoaiphong.Text == "")
                    MessageBox.Show("Mời nhập đầy đủ thông tin!");
                else
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm nhân viên này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        _phong.ThemPhong(txtTenphong.Text,txtLoaiphong.Text);
                        MessageBox.Show("Thêm thành công!");
                        SetNull();
                        frmPHONG_Load(sender, e);
                    }
            }
            else if (chon == 2)
            {
                if (txtTenphong.Text == "" || txtLoaiphong.Text == "")
                    MessageBox.Show("Mời nhập đầy đủ thông tin!");
                else
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn Sửa nhân viên này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        _phong.SuaPhong(txtMaphong.Text,txtTenphong.Text,txtLoaiphong.Text);
                        MessageBox.Show("Sửa thành công!");
                        SetNull();
                        frmPHONG_Load(sender, e);
                    }
            }
        }

        private void dgvPHONG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDodung.Enabled = true;
            try
            {
                txtMaphong.Text = dgvPhong.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenphong.Text = dgvPhong.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLoaiphong.Text = dgvPhong.Rows[e.RowIndex].Cells[2].Value.ToString();
              
            }
            catch { }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            chon = 0;
            SetNull();
            frmPHONG_Load(sender, e);
        }
        private void txttk_Maphong_TextChanged(object sender, EventArgs e)
        {
            dgvPhong.DataSource = tk.TKPhong_MaPhong(txttk_Maphong.Text);
        }
        private void txttk_Tenphong_TextChanged(object sender, EventArgs e)
        {
            dgvPhong.DataSource = tk.TKPhong_TenPhong(txttk_tenphong.Text);
        }

        private void txttk_Loaiphong_TextChanged(object sender, EventArgs e)
        {
            dgvPhong.DataSource = tk.TKPhong_LoaiPhong(txttk_loaiphong.Text);
        }

        private void btnDodung_Click(object sender, EventArgs e)
        {
            frmDoDungTheoPhong dodung = new frmDoDungTheoPhong(txtMaphong.Text);
            dodung.Show();
        }

     
    }
}
