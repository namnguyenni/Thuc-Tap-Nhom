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
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }
        NhaCungCap ncc = new NhaCungCap();
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            HienThi();
            cboTK.SelectedIndex = 0;
        }

        public void HienThi()
        {
            dataGridView1.DataSource = ncc.ShowNCC("");
            
            Init();
        }
        public void Init()
        {
            if (dataGridView1.RowCount > 1)
            {
                try
                {
                    txtMaNCC.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                    txtTenNCC.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                    txtDiaChi.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                    txtSDT.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                }
                catch { }
            }

        }
        public void SetNull()
        {
            txtTK.Text = "";
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            SetNull();
            cboTK.Enabled = false;
            txtTK.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ncc.UpdateNCC(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtSDT.Text);
            MessageBox.Show("Sửa dữ liệu thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HienThi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu không ???", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dataGridView1.SelectedRows.Count == 1) ncc.DeleteNCC(txtMaNCC.Text);
                    else if (dataGridView1.SelectedRows.Count > 1)
                    {
                        for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                        {
                            ncc.DeleteNCC(dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[0].Value.ToString());
                        }
                    }
                    HienThi();
                    MessageBox.Show("Xóa dữ liệu thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được dữ liệu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenNCC.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên sản phẩm !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên NSX !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin sản phẩm !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            long serult;
            if (long.TryParse(txtSDT.Text, out serult) == false) 
            {
                MessageBox.Show("Số điện thoại không hợp lệ !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                ncc.InsertNCC(txtTenNCC.Text, txtDiaChi.Text, txtSDT.Text);
                MessageBox.Show("Thêm dữ liệu thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThi();
                cboTK.Enabled = true;
                txtTK.Enabled = true;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                btnThem.Enabled = true;
            }
            catch { }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            HienThi();
            cboTK.Enabled = true;
            txtTK.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaNCC.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenNCC.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDiaChi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSDT.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch { }
        }
        public void TimKiem(string DieuKien)
        {
            dataGridView1.DataSource = ncc.ShowNCC("WHERE " + DieuKien + " LIKE N'%" + txtTK.Text + "%'");
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {
            if (txtTK.Text == "") HienThi();
            else
            {
                if (cboTK.SelectedIndex == 0) TimKiem("MaNCC");
                else if (cboTK.SelectedIndex == 1) TimKiem("TenNCC");
                else if (s.SelectedIndex == 2) TimKiem("DiaChi");
                else if (cboTK.SelectedIndex == 3) TimKiem("SDT");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
