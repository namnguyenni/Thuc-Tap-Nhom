using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class TimKiem
    {
        // Tìm kiếm Giao vien theo tên
        public DataTable TKTenGiaoVien(string HoTen)
        {
            string sql = "TK_GV_HoTen";
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(ConnectDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@HoTen", HoTen);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        // Tìm kiếm Hoc Sinh theo tên
        public DataTable TKTenHocSinh(string HoTen)
        {
            string sql = "TK_HS_HoTen";
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(ConnectDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@HoTen", HoTen);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        // Tìm kiếm Hoc Sinh theo Ma
        public DataTable TK_Ma_HocSinh(string Ma)
        {
            string sql = "SELECT * FROM dbo.HocSinh WHERE MaHS LIKE N'%' + @MaHS + '%'";
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(ConnectDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            //cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@MaHS", Ma);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        // Tìm kiếm Giao Vien theo Ma
        public DataTable TK_Ma_GiaoVien(string Ma)
        {
            string sql = "SELECT * FROM dbo.GiaoVien WHERE MaGV LIKE N'%' + @MaGV + '%'";
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(ConnectDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            //cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@MaGV", Ma);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        //tim kiem lop theo ma
        public DataTable TK_Ma_Lop(string MaLop)
        {
            string sql = "SELECT * FROM dbo.Lop WHERE MaLop LIKE N'%' + @MaLop + '%'";
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(ConnectDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            //cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@MaLop", MaLop);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        //tim kiem lop theo ten
        public DataTable TK_Ten_Lop(string TenLop)
        {
            string sql = "SELECT * FROM dbo.Lop WHERE TenLop LIKE N'%' + @TenLop + '%'";
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(ConnectDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            //cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@TenLop", TenLop);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
    }
}
