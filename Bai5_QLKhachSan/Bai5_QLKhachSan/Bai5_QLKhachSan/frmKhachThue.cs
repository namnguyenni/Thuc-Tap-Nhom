using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BangKhachSan;
using KetNoiDB;

namespace Bai5_QLKhachSan
{
    public partial class frmKhachThue : Form
    {
        public frmKhachThue()
        {
            InitializeComponent();
        }

        BUS_KhachThuePhong khach = new BUS_KhachThuePhong();
        int chon = 0;
        TimKiem tk = new TimKiem();

        public void Khoa()
        {
            txtHoTen.Enabled = txtCMND.Enabled = cbGT.Enabled = dtpNgay.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }

        public void Mo()
        {
            txtHoTen.Enabled = txtCMND.Enabled = cbGT.Enabled = dtpNgay.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        public void SetNull()
        {
            txtMa.Text = txtHoTen.Text = txtCMND.Text = cbGT.Text = txtTK.Text = cbTK.Text = "";
            dtpNgay.Text = DateTime.Now.ToString();
        }

        private void dgvKhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMa.Text = dgvKhach.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTen.Text = dgvKhach.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbGT.Text = dgvKhach.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpNgay.Text = dgvKhach.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtCMND.Text = dgvKhach.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch { }
        }

        private void frmKhachThue_Load(object sender, EventArgs e)
        {
            dgvKhach.DataSource = khach.HienThiKhach();
            Khoa();
            SetNull();
            chon = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Mo();
            SetNull();
            chon = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Mo();
            SetNull();
            chon = 2;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmKhachThue_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn muốn xóa Khách này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                khach.XoaKhach(txtMa.Text);
                MessageBox.Show("Xóa thành công!");
                frmKhachThue_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chon == 1)
            {
                if (txtHoTen.Text == "" || cbGT.Text == "" || txtCMND.Text == "")
                    MessageBox.Show("Mời nhập đầy đủ thông tin!");
                else
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm Khách này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        khach.ThemKhach(txtHoTen.Text, cbGT.Text, dtpNgay.Text, txtCMND.Text);
                        MessageBox.Show("Thêm thành công!");
                        frmKhachThue_Load(sender, e);
                    }
            }
            else if (chon == 2)
            {
                if (txtHoTen.Text == "" || cbGT.Text == "" || txtCMND.Text == "")
                    MessageBox.Show("Mời nhập đầy đủ thông tin!");
                else
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn Sửa Khách này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        khach.SuaKhach(txtMa.Text, txtHoTen.Text, cbGT.Text, dtpNgay.Text, txtCMND.Text);
                        MessageBox.Show("Sửa thành công!");
                        frmKhachThue_Load(sender, e);
                    }
            }
        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {
            if (cbTK.Text == "Mã Khách")
                dgvKhach.DataSource = tk.TKKhach_MaKhach(txtTK.Text);
            else if (cbTK.Text == "Tên Khách")
                dgvKhach.DataSource = tk.TKKhach_TenKhach(txtTK.Text);
            else if (cbTK.Text == "CMND")
                dgvKhach.DataSource = tk.TKKhach_CMND(txtTK.Text);
        }
    }
}
