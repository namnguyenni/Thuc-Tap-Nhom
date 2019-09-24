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
namespace QuanLyBanHang
{
    public partial class frmHuongDan : Form
    {
        public frmHuongDan()
        {
            InitializeComponent();
        }
        private void GetFileAll(string tenfile)
        {
            StreamReader doc = File.OpenText(tenfile);
            string s = doc.ReadToEnd();
            txtGioiThieu.Text = s;
        }

        private void trViewGioiThieu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "gtPhanMem")
            {
                GetFileAll("GioiThieuChung.txt");
                Image img = Image.FromFile(@"ban hang.jpg");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtDangNhap")
            {
                GetFileAll("PhanDangNhap.txt");
                Image img = Image.FromFile(@"b6 dang nhap.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtManHinhChinh")
            {
                GetFileAll("PhanMain.txt");
                Image img = Image.FromFile(@"b6 main.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtBanHang")
            {
                GetFileAll("PhanBanHang.txt");
                Image img = Image.FromFile(@"b6 BanHang.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtHoaDonBan")
            {
                GetFileAll("PhanHoaDonBan.txt");
                Image img = Image.FromFile(@"b6 HoaDonBan.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtInHDB")
            {
                GetFileAll("PhanKhachHang.txt");
                Image img = Image.FromFile(@"b6 InHDB.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtKhachHang")
            {
                GetFileAll("PhanKhachHang.txt");
                Image img = Image.FromFile(@"b6 KhachHang.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtLoaiHang")
            {
                GetFileAll("PhanLoaiHang.txt");
                Image img = Image.FromFile(@"b6 LoaiHang.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtNhanVien")
            {
                GetFileAll("PhanNhanVien.txt");
                Image img = Image.FromFile(@"b6 NhanVien.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtSanPham")
            {
                GetFileAll("PhanSanPham.txt");
                Image img = Image.FromFile(@"b6 SanPham.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtThemHD")
            {
                GetFileAll("PhanThemHD.txt");
                Image img = Image.FromFile(@"b6 ThemHD.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtThongKe")
            {
                GetFileAll("PhanThongKe.txt");
                Image img = Image.FromFile(@"b6 ThongKe.png");
                pictureBox1.BackgroundImage = img;
            }
        }
    }
}
