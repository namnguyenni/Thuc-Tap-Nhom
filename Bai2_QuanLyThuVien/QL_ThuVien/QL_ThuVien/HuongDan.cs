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
namespace QL_ThuVien
{
    public partial class HuongDan : Form
    {
        public HuongDan()
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
                Image img = Image.FromFile(@"thu vien.jpg");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtDangNhap")
            {
                GetFileAll("PhanDangNhap.txt");
                Image img = Image.FromFile(@"b3 dang nhap.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtManHinhChinh")
            {
                GetFileAll("PhanMain.txt");
                Image img = Image.FromFile(@"b3 main.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtDocGia")
            {
                GetFileAll("PhanDocGia.txt");
                Image img = Image.FromFile(@"b3 DocGia.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtMuonSach")
            {
                GetFileAll("PhanMuonSach.txt");
                Image img = Image.FromFile(@"b3 MuonSach.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtTaiLieu")
            {
                GetFileAll("PhanTaiLieu.txt");
                Image img = Image.FromFile(@"b3 TaiLieu.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtTraSach")
            {
                GetFileAll("PhanTraSach.txt");
                Image img = Image.FromFile(@"b3 TraSach.png");
                pictureBox1.BackgroundImage = img;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
