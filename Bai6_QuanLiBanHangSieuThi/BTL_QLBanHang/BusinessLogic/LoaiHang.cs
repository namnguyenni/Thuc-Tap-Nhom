using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLogic
{
    public class LoaiHang
    {
        KetNoiDB db = new KetNoiDB();
        public DataTable ShowLoaiHang()
        {
            string sql = @"SELECT * FROM LOAIHANG";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }
        public void InsertLoaiHang(string _TenLH)
        {
            string sql = "ThemLH";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenlh", _TenLH);
            
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
        public void UpdateLoaiHang(string _MaLH, string _TenLH)
        {
            string sql = "SuaLH";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@malh", _MaLH);
            cmd.Parameters.AddWithValue("@tenlh", _TenLH);


            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
        public void DeleteLoaiHang(string _MaLH)
        {
            string sql = "XoaLH";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@malh", _MaLH);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public DataTable SearchLoaiKH(string _LoaiKH)
        {
            DataTable dt = new DataTable();
            string sql = "SearchLoaiKH";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@str", _LoaiKH);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            con.Close();
            cmd.Dispose();
            return dt;
        }

    }
}
