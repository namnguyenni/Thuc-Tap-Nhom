using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BangThuVien;
using KetNoiDB;

namespace QL_ThuVien
{
    public partial class DocGia : Form
    {
        public DocGia()
        {
            InitializeComponent();
        }

        BUS_BanDoc bd = new BUS_BanDoc();
        int chon;
        TimKiem tk=new TimKiem();

        public void KhoaDK()
        {
            txtCMND.Enabled = txtDiaChi.Enabled = txtDienThoai.Enabled = txtEmail.Enabled = txtHoTen.Enabled = txtMaLop.Enabled = cbGT.Enabled = dtpNgaySinh.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }

        public void MoDK()
        {
            txtCMND.Enabled = txtDiaChi.Enabled = txtDienThoai.Enabled = txtEmail.Enabled = txtHoTen.Enabled = txtMaLop.Enabled = cbGT.Enabled = dtpNgaySinh.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        public void SetNull()
        {
            txtCMND.Text = txtDiaChi.Text = txtDienThoai.Text = txtEmail.Text = txtHoTen.Text = txtMa.Text = txtMaLop.Text = txtTimKiem.Text = "";
            cbGT.Text = cbTK.Text = "";
            dtpNgaySinh.Text = DateTime.Now.ToString();
        }

        private void DocGia_Load(object sender, EventArgs e)
        {
            dgvBanDoc.DataSource = bd.HienThiBanDoc();
            KhoaDK();
            SetNull();
            chon = 0;
        }

        private void dgvBanDoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                txtMa.Text = dgvBanDoc.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTen.Text = dgvBanDoc.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbGT.Text = dgvBanDoc.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpNgaySinh.Text = dgvBanDoc.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtCMND.Text = dgvBanDoc.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtMaLop.Text = dgvBanDoc.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtDiaChi.Text = dgvBanDoc.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtEmail.Text = dgvBanDoc.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtDienThoai.Text = dgvBanDoc.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            catch { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MoDK();
            txtMa.Enabled = false;
            SetNull();
            chon = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MoDK();
            chon = 2;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "")
                MessageBox.Show("Mời bạn chọn người xóa!");
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn muốn xóa Bạn đọc này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    bd.XoaBanDoc(txtMa.Text);
                    MessageBox.Show("Xóa thành công!");
                    DocGia_Load(sender, e);
                    SetNull();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DocGia_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chon == 1)
            {
                if (txtHoTen.Text == "" || cbGT.Text == "" || dtpNgaySinh.Text == "" || txtCMND.Text == "" || txtMaLop.Text == "" || txtDiaChi.Text == "" || txtDienThoai.Text == "" || txtEmail.Text=="")
                    MessageBox.Show("Mời nhập đầy đủ thông tin!");
                else
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm Độc giả này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        bd.ThemBanDoc(txtHoTen.Text, cbGT.Text, DateTime.Parse(dtpNgaySinh.Text), txtCMND.Text, txtMaLop.Text, txtDiaChi.Text, txtEmail.Text, txtDienThoai.Text);
                        MessageBox.Show("Thêm thành công!");
                        SetNull();
                        DocGia_Load(sender, e);
                    }
            }
            else if (chon == 2)
            {
                if (txtHoTen.Text == "" || cbGT.Text == "" || dtpNgaySinh.Text == "" || txtCMND.Text == "" || txtMaLop.Text == "" || txtDiaChi.Text == "" || txtDienThoai.Text == "" || txtEmail.Text == "")
                    MessageBox.Show("Mời nhập đầy đủ thông tin!");
                else
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn Sửa Độc giả này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        bd.SuaBanDoc(txtMa.Text, txtHoTen.Text, cbGT.Text, DateTime.Parse(dtpNgaySinh.Text), txtCMND.Text, txtMaLop.Text, txtDiaChi.Text, txtEmail.Text, txtDienThoai.Text);
                        MessageBox.Show("Sửa thành công!");
                        SetNull();
                        DocGia_Load(sender, e);
                    }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(cbTK.Text=="Mã Bạn đọc")
                dgvBanDoc.DataSource=tk.TKDG_MaDG(txtTimKiem.Text);
            else
            {
                if (cbTK.Text == "Họ tên")
                    dgvBanDoc.DataSource = tk.TKDG_TenDG(txtTimKiem.Text);
                else
                {
                    if (cbTK.Text == "CMND")
                        dgvBanDoc.DataSource = tk.TKDG_CMND(txtTimKiem.Text);
                    else if (cbTK.Text == "Mã lớp")
                        dgvBanDoc.DataSource = tk.TKDG_MaLop(txtTimKiem.Text);
                }
            }
        }
    }
}
