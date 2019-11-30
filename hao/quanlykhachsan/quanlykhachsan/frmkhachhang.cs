using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace quanlykhachsan
{
    public partial class frmkhachhang : Form
    {
        public frmkhachhang()
        {
            InitializeComponent();
        }
        int temp;
        private void hienthi()
        {
            khachhangBLL pbll = new khachhangBLL();
            dataGridView1.DataSource = pbll.hienthikhachhang();
        }
        private void trangthai(bool t)
        {
           // txtmakhachhang.Enabled = t;
            txttenkh.Enabled = t;
            txtcmt.Enabled = t;
            txtsdt.Enabled = t;
            txtdiachi.Enabled = t;
            dtngaysinh.Enabled = t;
            cbquoctich.Enabled = t;
            cbgiotinhkh.Enabled = t;
        }

        private void frm_load(object sender, EventArgs e)
        {
            hienthi();
            trangthai(false);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            txtmakhachhang.Text = row.Cells["maKhachHang"].Value.ToString();
            txttenkh.Text = row.Cells["tenKhachHang"].Value.ToString();
            txtcmt.Text = row.Cells["chungMinhNhanDan"].Value.ToString();
            txtsdt.Text = row.Cells["soDienThoai"].Value.ToString();
            txtdiachi.Text = row.Cells["diaChi"].Value.ToString();
            cbquoctich.Text = row.Cells["quocTich"].Value.ToString();
            cbgiotinhkh.Text = row.Cells["gioiTinh"].Value.ToString();
            dtngaysinh.Value = Convert.ToDateTime(row.Cells["ngaySinh"].Value.ToString());
        }
        private bool travegioitinh()
        {
            if (cbgiotinhkh.Text == "Nam")
                return true;
            else
                return false;
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            temp = 2;
            trangthai(true);

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            khachhangBLL khBLL = new khachhangBLL();
           DialogResult luu= MessageBox.Show("Bạn chắc chắn xóa??", "Thông báo thêm mới", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(luu==DialogResult.Yes)
            {
                
               khBLL.xoa_khachhang(int.Parse(txtmakhachhang.Text));
              hienthi();
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
                khachhangBLL khBLL = new khachhangBLL(); 
            if (temp == 2)
            {
                khBLL.sua_khachhang(txttenkh.Text, dtngaysinh.Value, travegioitinh(), txtcmt.Text, txtdiachi.Text, txtsdt.Text, cbquoctich.Text, int.Parse(txtmakhachhang.Text));
                hienthi();
                MessageBox.Show("Bạn đã lưu thành công", "Thông báo cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                khBLL.them_khachhang(txttenkh.Text, dtngaysinh.Value, travegioitinh(), txtcmt.Text, txtdiachi.Text, txtsdt.Text, cbquoctich.Text);
                hienthi();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temp = 1;
            trangthai(true);
        }
    }
}
