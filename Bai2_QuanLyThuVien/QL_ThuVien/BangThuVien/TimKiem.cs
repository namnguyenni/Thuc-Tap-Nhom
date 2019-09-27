using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using KetNoiDB;
namespace BangThuVien
{
    public class TimKiem
    {
        KetNoi cn = new KetNoi();


        // Tìm kiếm Tài liệu theo mã
        public DataTable TKTL_MaTL(string MaTL)
        {
            string sql = "SELECT * FROM dbo.DauSach WHERE MaDauSach LIKE N'%' + @MaDauSach + '%'";
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(KetNoi.connect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@MaDauSach", MaTL);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;

        }

        // Tìm kiếm tài liệu theo nhan đề
        public DataTable TKTL_NhanDe(string NhanDe)
        {
            string sql = "SELECT * FROM dbo.DauSach WHERE NhanDe LIKE N'%' + @NhanDe + '%'";
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(KetNoi.connect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@NhanDe", NhanDe);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        // Tìm kiếm tài liệu theo tác giả
        public DataTable TKTL_TacGia(string TacGia)
        {
            string sql = "SELECT * FROM dbo.DauSach WHERE TacGia LIKE N'%' + @TacGia + '%'";
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(KetNoi.connect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@TacGia", TacGia);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        // Tìm kiếm độc giả theo mã đọc giả
        public DataTable TKDG_MaDG(string MaBD)
        {
            string sql = "SELECT * FROM dbo.BanDoc WHERE MaBD LIKE N'%' + @MaBD + '%'";
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(KetNoi.connect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@MaBD", MaBD);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        // TK độc giả theo họ tên
        public DataTable TKDG_TenDG(string HoTen)
        {
            string sql = "SELECT * FROM dbo.BanDoc WHERE HoTen LIKE N'%' + @HoTen + '%'";
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(KetNoi.connect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@HoTen", HoTen);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        //TK độc giả theo CMND
        public DataTable TKDG_CMND(string CMND)
        {
            string sql = "SELECT * FROM dbo.BanDoc WHERE CMND LIKE N'%' + @CMND + '%'";
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(KetNoi.connect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@CMND", CMND);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        // TK độc giả theo mã lớp
        public DataTable TKDG_MaLop(string MaLop)
        {
            string sql = "SELECT * FROM dbo.BanDoc WHERE MaLop LIKE N'%' + @MaLop + '%'";
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(KetNoi.connect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@MaLop", MaLop);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        // Tìm kiếm Ban doc theo ten
        public DataTable TKBD_HoTen(string HoTen)
        {
            string sql = "SELECT * FROM dbo.BanDoc WHERE HoTen LIKE N'%' + @HoTen + '%'";
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(KetNoi.connect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@HoTen", HoTen);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;

        }
    }
}
