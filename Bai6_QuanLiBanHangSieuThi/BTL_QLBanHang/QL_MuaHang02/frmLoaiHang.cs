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
    public partial class frmLoaiHang : Form
    {
        public frmLoaiHang()
        {
            InitializeComponent();
        }

        LoaiHang lh = new LoaiHang();
        private void frmLoaiHang_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        public void HienThi()
        {
            dataGridView1.DataSource = lh.ShowLoaiHang();
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
            Init();
        }
        public void Init()
        {
            if (dataGridView1.RowCount > 1)
            {
                try
                {
                    txtMaLH.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                    txtTenLH.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                }
                catch { }
            }
        }
        public void SetNull()
        {
            txtMaLH.Text = "";
            txtTenLH.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            SetNull();
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            lh.UpdateLoaiHang(txtMaLH.Text, txtTenLH.Text);
            MessageBox.Show("Sửa dữ liệu thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HienThi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu không ???", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dataGridView1.SelectedRows.Count == 1) lh.DeleteLoaiHang(txtMaLH.Text);
                    else if (dataGridView1.SelectedRows.Count > 1)
                    {
                        for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                        {
                            lh.DeleteLoaiHang(dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[1].Value.ToString());
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            HienThi();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            if (txtTenLH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên sản phẩm !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                lh.InsertLoaiHang(txtTenLH.Text);
                MessageBox.Show("Thêm dữ liệu thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThi();               
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                btnThem.Enabled = true;
            }
            catch { }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaLH.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTenLH.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();               
            }
            catch { }
        }
    }
}
