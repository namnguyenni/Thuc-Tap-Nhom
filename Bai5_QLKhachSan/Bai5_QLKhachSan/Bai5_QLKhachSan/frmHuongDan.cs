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
namespace Bai5_QLKhachSan
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
                Image img = Image.FromFile(@"khachsan.jpg");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtDangNhap")
            {
                GetFileAll("PhanDangNhap.txt");
                Image img = Image.FromFile(@"b5 dang nhap.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtManHinhChinh")
            {
                GetFileAll("PhanMain.txt");
                Image img = Image.FromFile(@"b5 main.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtPhong")
            {
                GetFileAll("PhanPhong.txt");
                Image img = Image.FromFile(@"b5 Phong.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtChoThuePhong")
            {
                GetFileAll("PhanChoThuePhong.txt");
                Image img = Image.FromFile(@"b5 ChoThuePhong.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtDoDungCuaKhachSan")
            {
                GetFileAll("PhanDoDungCuaKhachSan.txt");
                Image img = Image.FromFile(@"b5 DoDungCuaKhachSan.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtDoDungTheoPhong")
            {
                GetFileAll("PhanDoDungTheoPhong.txt");
                Image img = Image.FromFile(@"b5 DoDungTheoPhong.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtKhachThue")
            {
                GetFileAll("PhanKhachThue.txt");
                Image img = Image.FromFile(@"b5 KhachThue.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtTraPhong")
            {
                GetFileAll("PhanTraPhong.txt");
                Image img = Image.FromFile(@"b5 TraPhong.png");
                pictureBox1.BackgroundImage = img;
            }
        }
    }
}
