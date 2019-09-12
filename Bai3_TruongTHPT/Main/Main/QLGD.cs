using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace Main
{
    public partial class QLGD : Form
    {
        public QLGD()
        {
            InitializeComponent();
        }

        Lop l = new Lop();
        MonHon mh = new MonHon();
        GiaoVien gv = new GiaoVien();
        CTGD ct = new CTGD();
        int selection = 0;

        public void SetNull()
        {
            txtTiet.Text = "";
            cboTenMon.Enabled = cboTenGV.Enabled = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            SetNull();
            selection = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cboTenMon.Enabled = cboTenGV.Enabled = true;
            selection = 2;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cboTenMon.SelectedValue.ToString());
            ct.XoaCTGD(cboTenLop.ValueMember, cboTenMon.ValueMember);
            dataGridView1.DataSource = ct.Show(cboTenMon.Text);
            MessageBox.Show("Xóa dữ liệu thành công");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (selection == 1)
            {
                ct.ThemCTGD(cboTenLop.SelectedValue.ToString(), cboTenMon.SelectedValue.ToString(),
                                cboTenGV.SelectedValue.ToString(), dateTimePicker1.Value, Convert.ToInt32(txtTiet.Text));
                MessageBox.Show("Thêm dữ liệu thành công");
            }
            else if (selection == 2)
            {
                ct.SuaCTGD(cboTenLop.SelectedValue.ToString(), cboTenMon.SelectedValue.ToString(),
                                cboTenGV.SelectedValue.ToString(), Convert.ToDateTime(dateTimePicker1.Text), Convert.ToInt32(txtTiet.Text));
                MessageBox.Show("Sửa dữ liệu thành công");
            }

            //MessageBox.Show(dateTimePicker1.Value.);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QLGD_Load(object sender, EventArgs e)
        {
            cboTenLop.DataSource = l.Show();
            cboTenLop.DisplayMember = "TenLop";
            cboTenLop.ValueMember = "MaLop";
            cboTenLop.SelectedValue = "MaLop";
            cboTenLop.SelectedIndex = 0;
            cboTenMon.DataSource = mh.Show();
            cboTenMon.DisplayMember = "TenMon";
            cboTenMon.ValueMember = "MaMon";
            cboTenMon.SelectedValue = "MaMon";
            cboTenMon.SelectedIndex = 0;
            cboTenMon.Enabled = cboTenGV.Enabled = false;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cboTenLop.Text != "")
            {
                dataGridView1.DataSource = ct.Show(cboTenLop.Text);
            }
        }

        private void cboTenMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboTenGV.DataSource = gv.Show(cboTenMon.Text);
            cboTenGV.DisplayMember = "HoTen";
            cboTenGV.ValueMember = "MaGV";
            cboTenGV.SelectedValue = "MaGV";
            if (cboTenGV.Items.Count > 0)
            {
                cboTenGV.SelectedIndex = 0;
            }
        }

        private void cboTenMon_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            for (int i = 0; i < cboTenMon.Items.Count; i++)
            {
                cboTenMon.SelectedIndex = i;
                if (cboTenMon.Text == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()) break;
            }           
            for (int i = 0; i < cboTenGV.Items.Count; i++)
            {
                cboTenGV.SelectedIndex = i;
                if (cboTenGV.Text == dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()) break;
            }
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTiet.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
                
    }
}
