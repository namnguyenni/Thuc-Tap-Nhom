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
namespace Main
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
                Image img = Image.FromFile(@"truong.jpg");
                pictureBox1.BackgroundImage = img;
            }
            else
                if (e.Node.Name == "gtDangNhap")
                {
                    GetFileAll("PhanDangNhap.txt");
                    Image img = Image.FromFile(@"b2 dang nhap.png");
                    pictureBox1.BackgroundImage = img;
                }
                else
                    if (e.Node.Name == "gtManHinhChinh")
                    {
                        GetFileAll("PhanMain.txt");
                        Image img = Image.FromFile(@"b2 main.png");
                        pictureBox1.BackgroundImage = img;
                    }
                    else
                        if (e.Node.Name == "gtGiaoVien")
                        {
                            GetFileAll("PhanQuanLyGiaoVien.txt");
                            Image img = Image.FromFile(@"b2 giao vien.png");
                            pictureBox1.BackgroundImage = img;
                        }
                        else
                            if (e.Node.Name == "gtHocSinh")
                            {
                                GetFileAll("PhanQuanLyHocSinh.txt");
                                Image img = Image.FromFile(@"b2 hoc sinh.png");
                                pictureBox1.BackgroundImage = img;
                            }
                            else
                                if (e.Node.Name == "gtQLGD")
                                {
                                    GetFileAll("PhanQuanLyQLGD.txt");
                                    Image img = Image.FromFile(@"b2 ttgd.png");
                                    pictureBox1.BackgroundImage = img;
                                }
        }

        private void frmHuongDan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }
}
