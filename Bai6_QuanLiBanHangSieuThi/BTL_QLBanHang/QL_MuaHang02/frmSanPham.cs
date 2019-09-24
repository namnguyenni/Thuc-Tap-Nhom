using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BusinessLogic;
using Entity;

namespace QuanLyBanHang
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }

        SanPham sp = new SanPham();
        EC_SANPHAM et_sp = new EC_SANPHAM();
        LoaiHang lh = new LoaiHang();
        string tenAnh;
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            HienThi();
            cboLH.DataSource = lh.ShowLoaiHang();
            cboLH.DisplayMember = "TenLH";
            cboLH.ValueMember = "MaLH";
            cboLH.SelectedValue = "MaLH";
            cboLH.SelectedIndex = 0;
            cboTK.SelectedIndex = 0;
        }
        public void HienThi()
        {
            dataGridView1.DataSource = sp.ShowSanPham("");
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
                    txtMaSP.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                    txtTenSP.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                    txtLoiNhuan.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
                    txtGN.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
                    txtGB.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
                    txtMoTa.Text = dataGridView1.Rows[0].Cells[7].Value.ToString();
                    txtNSX.Text = dataGridView1.Rows[0].Cells[8].Value.ToString();
                    cboLH.Text = dataGridView1.Rows[0].Cells[9].Value.ToString();
                    
                    tenAnh = sp.LayAnh(txtMaSP.Text);
                    pictureBox1.Image = Image.FromFile(@"image//laptop//" + tenAnh);  
                    //pictureBox1.Image = Image.FromFile(@"image//laptop//Khuyenmai.gif");
                }
                catch { }
            }
            
        }
        public void SetNull()
        {
            txtTK.Text = "";
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtNSX.Text = "";
            txtMoTa.Text = "";
            pictureBox1.Image = null;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            SetNull();
            tenAnh = "";
            txtLoiNhuan.Text = "";
            cboTK.Enabled = false;
            txtTK.Enabled = false;
            //btnLuu.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            GetData();
            sp.UpdateSanPham(et_sp);
            MessageBox.Show("Sửa dữ liệu thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HienThi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu không ???", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dataGridView1.SelectedRows.Count == 1) sp.DeleteSanPham(et_sp);
                    else if (dataGridView1.SelectedRows.Count > 1)
                    {
                        for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                        {
                            et_sp.MaSP = dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[1].Value.ToString();
                            sp.DeleteSanPham(et_sp);
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
        public void GetData()
        {
            try
            {
                et_sp.MaSP = txtMaSP.Text;
                et_sp.TenSP = txtTenSP.Text;
                et_sp.MaLH = cboLH.SelectedValue.ToString();
                et_sp.SoLuong = int.Parse(txtSL.Text);
                et_sp.LoiNhuan = float.Parse(txtLoiNhuan.Text);
                et_sp.GiaNhap = long.Parse(txtGN.Text);
                et_sp.MoTa = txtMoTa.Text;
                et_sp.NSX = txtNSX.Text;
                et_sp.TenLH = cboLH.Text;
                et_sp.HinhAnh = tenAnh;
            }
            catch { }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            HienThi();
            cboTK.Enabled = true;
            txtTK.Enabled = true;
            //btnLuu.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaSP.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTenSP.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSL.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtLoiNhuan.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtGN.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtGB.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();             
                txtMoTa.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtNSX.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                cboLH.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                tenAnh = sp.LayAnh(txtMaSP.Text);
                pictureBox1.Image = Image.FromFile(@"image//laptop//" + tenAnh);
                GetData();
            }
            catch { }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Chọn Ảnh";
            openFileDialog1.Multiselect = false; // khong cho phep chon nhieu file dong thoi
            openFileDialog1.InitialDirectory = "F:\\";
            openFileDialog1.Filter = "|*.jpg; *.png; *.gif; *.bmp; *.jpeg";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            tenAnh = Path.GetFileName(openFileDialog1.FileName);
            pictureBox1.Image = Image.FromFile(@"image//laptop//" + tenAnh);
        }

        private void cboTK_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public void TimKiem(string DieuKien)
        {
            if (cboTK.SelectedIndex != 2) dataGridView1.DataSource = sp.ShowSanPham("AND " + DieuKien + " LIKE N'%" + txtTK.Text + "%'");
            else dataGridView1.DataSource = sp.ShowSanPham("AND " + DieuKien + " = " + txtTK.Text);
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
                if (cboTK.SelectedIndex == 0) TimKiem("MaSP");
                else if (cboTK.SelectedIndex == 1) TimKiem("TenSP");
                else if (cboTK.SelectedIndex == 2) TimKiem("GiaBan");
                else if (cboTK.SelectedIndex == 3) TimKiem("TenLH");
                else if (cboTK.SelectedIndex == 4) TimKiem("NSX");
                Init();
            }
        }

        private void btnSPMax_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sp.LaySPMax();
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
            Init();
        }
    }
}
