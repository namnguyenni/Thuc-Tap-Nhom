using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using KetNoiDB;

namespace BangQLCT
{
    public class TimKiem
    {
        KetNoi cn = new KetNoi();
        // Tìm kiếm nhan vien theo mã
        public DataTable TKMaNV(string MaNV)
        {
            string sql = "SELECT * FROM tblNhanVien WHERE MaNV LIKE N'%' + @MaNV + '%'";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@MaNV", MaNV);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;

        }

        // Tìm kiếm nhan vien theo tên
        public DataTable TKTenNV(string TenNV)
        {
            string sql = "SELECT * FROM tblNhanVien WHERE TenNV LIKE N'%' + @TenNV + '%'";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@TenNV", TenNV);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        //tìm kiếm nhan vien theo mã  trên thanh tìm kiếm.
        public DataTable TKMaNhanVien(string MaNV)
        {
            string sql = "SELECT * FROM tblNhanVien WHERE MaNV LIKE (N'%' + @MaNV + '%')";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@MaNV", MaNV);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        // Tìm kiếm nhân viên theo Tên
        public DataTable TKTenNhanVien(string TenNV)
        {
            //string sql = "SELECT * FROM tblNhanVien WHERE TenNV LIKE (N'%' + @TenNV + '%')";
            string sql = "TKTen";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@TenNV", TenNV);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        // Tìm kiếm nhân viên theo giới tính
        public DataTable TKGTNhanVien(string GT)
        {
            //string sql = "SELECT * FROM tblNhanVien WHERE GT LIKE (N'%' + @GT + '%')";
            string sql = "TKGT";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@GT", GT);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        // Tìm nhân viên theo địa chỉ
        public DataTable TKDiaChiNhanVien(string DC)
        {
            //string sql = "SELECT * FROM tblNhanVien WHERE DiaChi LIKE (N'%' + @DC + '%')";
            string sql = "TKDiaChi";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@DC", DC);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
    }
}
