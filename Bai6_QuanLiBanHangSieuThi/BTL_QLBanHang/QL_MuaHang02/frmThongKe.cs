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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        SanPham sp = new SanPham();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 6) dateTimePicker1.Enabled = dateTimePicker2.Enabled = true;
            else dateTimePicker1.Enabled = dateTimePicker2.Enabled = false;
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                switch (comboBox1.SelectedIndex)
                {
                    case -1: return;
                    case 0: dataGridView1.DataSource = sp.ThongKeSPN(DateTime.Now.AddDays(-1), DateTime.Now); break;
                    case 1: dataGridView1.DataSource = sp.ThongKeSPN(DateTime.Now.AddDays(-7), DateTime.Now); break;
                    case 2: dataGridView1.DataSource = sp.ThongKeSPN(DateTime.Now.AddMonths(-1), DateTime.Now); break;
                    case 3: dataGridView1.DataSource = sp.ThongKeSPN(DateTime.Now.AddMonths(-3), DateTime.Now); break;
                    case 4: dataGridView1.DataSource = sp.ThongKeSPN(DateTime.Now.AddMonths(-6), DateTime.Now); break;
                    case 5: dataGridView1.DataSource = sp.ThongKeSPN(DateTime.Now.AddYears(-1), DateTime.Now); break;
                    case 6: dateTimePicker1.Enabled = dateTimePicker2.Enabled = true; dataGridView1.DataSource = sp.ThongKeSPN(dateTimePicker1.Value, dateTimePicker2.Value); break;
                }
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                switch (comboBox1.SelectedIndex)
                {
                    case -1: return;
                    case 0: dataGridView1.DataSource = sp.ThongKeTop10(DateTime.Now.AddDays(-1), DateTime.Now); break;
                    case 1: dataGridView1.DataSource = sp.ThongKeTop10(DateTime.Now.AddDays(-7), DateTime.Now); break;
                    case 2: dataGridView1.DataSource = sp.ThongKeTop10(DateTime.Now.AddMonths(-1), DateTime.Now); break;
                    case 3: dataGridView1.DataSource = sp.ThongKeTop10(DateTime.Now.AddMonths(-3), DateTime.Now); break;
                    case 4: dataGridView1.DataSource = sp.ThongKeTop10(DateTime.Now.AddMonths(-6), DateTime.Now); break;
                    case 5: dataGridView1.DataSource = sp.ThongKeTop10(DateTime.Now.AddYears(-1), DateTime.Now); break;
                    case 6: dateTimePicker1.Enabled = dateTimePicker2.Enabled = true; dataGridView1.DataSource = sp.ThongKeSPN(dateTimePicker1.Value, dateTimePicker2.Value); break;
                }
            }
            for (int i = 0; i < dataGridView1.RowCount - 1; i++) dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
        }
    }
}
