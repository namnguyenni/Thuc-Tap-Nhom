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

namespace QuanLyBanHang
{
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
        }

        int dong = 0, dongSP = 0, DongCTHD = 0;
        KhachHang kh = new KhachHang();
        SanPham sp = new SanPham();
        HoaDonBan hdb = new HoaDonBan();
        ChiTietHoaDonBan cthd = new ChiTietHoaDonBan();
        public string MaKHNew = "", MaHDB = "";
        private void frmHoaDonBanHang_Load(object sender, EventArgs e)
        {
            KhoiTaotxtsKH();
            KhoiTaotxtsSP();
            HienThi();
        }
        public void HienThi()
        {
            dgvKhachHang.DataSource = kh.HienThiKhachHang();
            for (int i = 0; i < dgvKhachHang.RowCount; i++)
                dgvKhachHang.Rows[i].Cells[0].Value = (i + 1).ToString();

            dgvSanPham.DataSource = sp.HienThiSP_LH();
        }
        public void KhoiTaotxtsKH()
        {
            txttenKH.Text = txtDC.Text = txtGhichu.Text = txtSoDT.Text = txtMaKH.Text = "";
            cmbLoaiKH.Text = "";
            cmbGioiTinh.Text = "";
            MaKHNew = ""; MaHDB = "";
            txtTongTienHDB.Text = txtMaKHHDB.Text = txtNgayBanHDB.Text = "";
            dong = DongCTHD = 0;
        }
        public void KhoiTaotxtsSP()
        {
            txtTenSP.Text = txtTenNSX.Text = cmbGiaBan.Text = cmbTenLH.Text = "";
            txtSoLuongMua.Text = "";
            txtMaSP.Text = txtSoLgHangCon.Text = txtGiaBan.Text = "";
            dongSP = 0;
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                txttenKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbGioiTinh.Text = dgvKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDC.Text = dgvKhachHang.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSoDT.Text = dgvKhachHang.Rows[e.RowIndex].Cells[5].Value.ToString();
                cmbLoaiKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtGhichu.Text = dgvKhachHang.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            catch { }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dongSP = e.RowIndex;
                txtGiaBan.Text = dgvSanPham.Rows[e.RowIndex].Cells[4].Value.ToString();

                txtMaSP.Text = dgvSanPham.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtSoLgHangCon.Text = dgvSanPham.Rows[e.RowIndex].Cells[5].Value.ToString();
                picSanPham.Image = null;
                picSanPham.Image = Image.FromFile(@"image/" + dgvSanPham.Rows[e.RowIndex].Cells[2].Value.ToString() + "//" + dgvSanPham.Rows[e.RowIndex].Cells[6].Value.ToString());
                picSanPham.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch { }
        }

        private void btnOKKH_Click(object sender, EventArgs e)
        {
            if (txttenKH.Text == "")
            {
                MessageBox.Show("Cần Nhập thông tin khách hàng.");
                return;
            }
            float sdt = 0;
            if (float.TryParse(txtSoDT.Text, out sdt) != true)
            {
                MessageBox.Show("Nhập Số Điện Thoại Sai, Vui Lòng Nhập Lại.");
                return;
            }
            if (txtMaKH.Text == "")
            {
                MaKHNew = kh.InsertKhachHang(txttenKH.Text, cmbGioiTinh.Text, txtDC.Text, txtSoDT.Text, cmbLoaiKH.Text, txtGhichu.Text);
            }
            else MaKHNew = txtMaKH.Text;

            txtMaKHHDB.Text = MaKHNew;
            txtTenKHHDB.Text = txttenKH.Text;
            txtTongTienHDB.Text = "";
            txtNgayBanHDB.Text = DateTime.Now.ToString();

            MessageBox.Show("Hãy Chọn Các Sản Phẩm!");
            btnOKKH.Enabled = false; btnCanCelKH.Enabled = false; txttenKH.Enabled = false;
        }
        private void btnChonSP_Click(object sender, EventArgs e)
        {
            if (txttenKH.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn khách hàng.");
                return;
            }
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Cần chọn sản phẩm bán.");
                return;
            }

            float sdt = 0;
            if (float.TryParse(txtSoLuongMua.Text, out sdt) != true || txtSoLuongMua.Text == "")
            {
                MessageBox.Show("Nhập Số Hàng Mua Sai, Vui Lòng Nhập Lại.");
                return;
            }
            if (int.Parse(txtSoLuongMua.Text) > int.Parse(txtSoLgHangCon.Text))
            {
                txtSoLuongMua.Text = "";
                MessageBox.Show("Không đủ số hàng để bán.");
                return;
            }
            else
            {
                dgvSanPham.Rows[dongSP].Cells[5].Value = (int.Parse(txtSoLgHangCon.Text) - int.Parse(txtSoLuongMua.Text)).ToString();

                dgvCTHD.RowCount++;
                dgvCTHD.Rows[dong].Cells[0].Value = dgvSanPham.Rows[dongSP].Cells[0].Value.ToString();
                dgvCTHD.Rows[dong].Cells[1].Value = dgvSanPham.Rows[dongSP].Cells[1].Value.ToString();
                dgvCTHD.Rows[dong].Cells[2].Value = txtSoLuongMua.Text;
                dgvCTHD.Rows[dong].Cells[3].Value = dgvSanPham.Rows[dongSP].Cells[4].Value.ToString();
                dgvCTHD.Rows[dong].Cells[4].Value = int.Parse(dgvCTHD.Rows[dong].Cells[2].Value.ToString()) * long.Parse(dgvSanPham.Rows[dongSP].Cells[4].Value.ToString());

                long Tien = 0;
                for (int i = 0; i < dgvCTHD.RowCount - 1; i++)
                    Tien += long.Parse(dgvCTHD.Rows[i].Cells[4].Value.ToString());
                txtTongTienHDB.Text = Tien.ToString();

                dong++;
                KhoiTaotxtsSP();
                btnCanCelKH.Enabled = true;
            }

        }

        private void txttenKH_TextChanged(object sender, EventArgs e)
        {
            if (txttenKH.Text != null)
            {
                dgvKhachHang.DataSource = kh.SearchKH(txttenKH.Text);
            }
            else { txttenKH.Text = ""; txtMaKH.Text = ""; }
        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {
            if (txtTenSP.Text != null)
            {
                string str = dgvSanPham.Rows[dongSP].Cells[5].Value.ToString();
                dgvSanPham.DataSource = sp.SearchTenSP(txtTenSP.Text);
                dgvSanPham.Rows[dongSP].Cells[5].Value = str;
            }
            else txtTenSP.Text = "";
        }

        private void txtTenNSX_TextChanged(object sender, System.EventArgs e)
        {
            if (txtTenNSX.Text != null)
            {
                string str = dgvSanPham.Rows[dongSP].Cells[5].Value.ToString();
                dgvSanPham.DataSource = sp.SearchNSX(txtTenNSX.Text);
                dgvSanPham.Rows[dongSP].Cells[5].Value = str;
            }
            else txtTenSP.Text = "";
        }

        private void btnrefreshKH_Click(object sender, System.EventArgs e)
        {
            KhoiTaotxtsKH();
            dgvKhachHang.DataSource = kh.HienThiKhachHang();
            for (int i = 0; i < dgvKhachHang.RowCount; i++)
                dgvKhachHang.Rows[i].Cells[0].Value = (i + 1).ToString();

            btnOKKH.Enabled = true; txtMaKH.Enabled = true;
        }

        private void btnRefresh_Click(object sender, System.EventArgs e)
        {
            KhoiTaotxtsSP();
            dgvSanPham.DataSource = sp.HienThiSP_LH();
        }

        private void cmbTenLH_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cmbTenLH.Text != null)
            {
                string str = dgvSanPham.Rows[dongSP].Cells[5].Value.ToString();
                dgvSanPham.DataSource = sp.SearchTenLH(txtTenNSX.Text);
                dgvSanPham.Rows[dongSP].Cells[5].Value = str;
            }
            else cmbTenLH.Text = "";
        }

        private void HuyBo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Khởi Tạo Toàn Bộ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                KhoiTaotxtsKH();
                KhoiTaotxtsSP();
                HienThi();
            }
        }

        private void btnTangSL_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvSanPham.RowCount - 1; i++)
            {
                if (dgvSanPham.Rows[i].Cells[0].Value.ToString() == dgvCTHD.Rows[DongCTHD].Cells[0].Value.ToString())
                {
                    if (int.Parse(dgvSanPham.Rows[i].Cells[5].Value.ToString()) > 0)
                    {
                        dgvCTHD.Rows[DongCTHD].Cells[2].Value = (int.Parse(dgvCTHD.Rows[DongCTHD].Cells[2].Value.ToString()) + 1).ToString();
                        dgvCTHD.Rows[DongCTHD].Cells[4].Value = int.Parse(dgvCTHD.Rows[DongCTHD].Cells[2].Value.ToString()) * long.Parse(dgvCTHD.Rows[DongCTHD].Cells[3].Value.ToString());

                        long Tien = 0;
                        for (int j = 0; j < dgvCTHD.RowCount - 1; j++)
                            Tien += long.Parse(dgvCTHD.Rows[j].Cells[4].Value.ToString());
                        txtTongTienHDB.Text = Tien.ToString();

                        dgvSanPham.Rows[i].Cells[5].Value = (int.Parse(dgvSanPham.Rows[i].Cells[5].Value.ToString()) - 1).ToString();
                        break;
                    }

                }
            }
        }
        private void btnGiamSL_Click(object sender, EventArgs e)
        {
            if (int.Parse(dgvCTHD.Rows[DongCTHD].Cells[2].Value.ToString()) > 0)
            {
                dgvCTHD.Rows[DongCTHD].Cells[2].Value = (int.Parse(dgvCTHD.Rows[DongCTHD].Cells[2].Value.ToString()) - 1).ToString();
                dgvCTHD.Rows[DongCTHD].Cells[4].Value = int.Parse(dgvCTHD.Rows[DongCTHD].Cells[2].Value.ToString()) * long.Parse(dgvCTHD.Rows[DongCTHD].Cells[3].Value.ToString());

                long Tien = 0;
                for (int i = 0; i < dgvCTHD.RowCount - 1; i++)
                    Tien += long.Parse(dgvCTHD.Rows[i].Cells[4].Value.ToString());
                txtTongTienHDB.Text = Tien.ToString();

                for (int i = 0; i < dgvSanPham.RowCount - 1; i++)
                {
                    if (dgvSanPham.Rows[i].Cells[0].Value.ToString() == dgvCTHD.Rows[DongCTHD].Cells[0].Value.ToString())
                    {
                        dgvSanPham.Rows[i].Cells[5].Value = (int.Parse(dgvSanPham.Rows[i].Cells[5].Value.ToString()) + 1).ToString();
                        break;
                    }
                }
            }
        }

        private void grboxHDB_Enter(object sender, EventArgs e)
        {

        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoLuongMua_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try { DongCTHD = e.RowIndex; }
            catch { }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Lưu hóa đơn này ?", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                this.Close();
            }
            else
            {
                MaHDB = hdb.InsertHDB(txtMaKHHDB.Text, DateTime.Parse(txtNgayBanHDB.Text), long.Parse(txtTongTienHDB.Text));
                for (int i = 0; i < dgvCTHD.RowCount - 1; i++)
                {
                    cthd.InsertCTHD(MaHDB, dgvCTHD.Rows[i].Cells[0].Value.ToString(), dgvCTHD.Rows[i].Cells[2].Value.ToString(), dgvCTHD.Rows[i].Cells[3].Value.ToString());
                    sp.UpdateSoLuongSauBan(dgvCTHD.Rows[i].Cells[0].Value.ToString(), int.Parse(dgvCTHD.Rows[i].Cells[2].Value.ToString()));
                }
                frmInHDB frm = new frmInHDB(MaHDB, true);
                frm.Show();
                dgvCTHD.Rows.Clear();
                KhoiTaotxtsKH(); KhoiTaotxtsSP();
                HienThi();
            }
        }

        private void HuyBo_Click_1(object sender, EventArgs e)
        {
            dgvCTHD.Rows.Clear();
            KhoiTaotxtsKH(); KhoiTaotxtsSP();
            HienThi();
            btnOKKH.Enabled = btnCanCelKH.Enabled = btnCancelSP.Enabled = true; txttenKH.Enabled = true;
        }
    }
}
