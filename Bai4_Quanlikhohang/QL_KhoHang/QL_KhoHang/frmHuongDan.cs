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
namespace QL_KhoHang
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
                Image img = Image.FromFile(@"kho.jpg");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtDangNhap")
                {
                    GetFileAll("PhanDangNhap.txt");
                    Image img = Image.FromFile(@"b4 anh dang nhap.png");
                    pictureBox1.BackgroundImage = img;
                }
            else if (e.Node.Name == "gtManHinhChinh")
                    {
                        GetFileAll("PhanMain.txt");
                        Image img = Image.FromFile(@"b4 anh main.png");
                        pictureBox1.BackgroundImage = img;
                    }
             else if (e.Node.Name == "gtHangHoa")
                        {
                            GetFileAll("PhanHangHoa.txt");
                            Image img = Image.FromFile(@"b4 hanghoa.png");
                            pictureBox1.BackgroundImage = img;
                        }
            else if (e.Node.Name == "gtKhachHang")
            {
                GetFileAll("PhanKhachHang.txt");
                Image img = Image.FromFile(@"b4 khachhang.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtNhaCungCap")
            {
                GetFileAll("PhanNhaCungCap.txt");
                Image img = Image.FromFile(@"b4 nhacungcap.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtNhapXuat")
            {
                GetFileAll("PhanNhapXuat.txt");
                Image img = Image.FromFile(@"b4 nhapxuat.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtThemPN")
            {
                GetFileAll("PhanThemPN.txt");
                Image img = Image.FromFile(@"b4 thempn.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtThemPX")
            {
                GetFileAll("PhanThemPX.txt");
                Image img = Image.FromFile(@"b4 thempx.png");
                pictureBox1.BackgroundImage = img;
            }
        }
    }
}
