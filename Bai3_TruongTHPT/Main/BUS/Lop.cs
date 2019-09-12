using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BUS
{
    public class Lop
    {
        public DataTable Show()
        {
            string sql = "SELECT MaLop, TenLop from tblLop";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            da.Dispose();
            return dt;
        }
        //sua lop
        public void Sua_Lop(string MaLop, string TenLop, string GVCN)
        {
            string sql = "Sua_Lop";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaLop",MaLop);
            cmd.Parameters.AddWithValue("@TenLop", TenLop);
            cmd.Parameters.AddWithValue("@GVCN", GVCN);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void ThemLop(string TenLop, string GVCN)
        {
            string sql = "ADD_Lop";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@TenLop", TenLop);
            cmd.Parameters.AddWithValue("@GVCN", GVCN);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        // Xóa
        public void Xoa_Lop(string MaLop)
        {
            string sql = "Xoa_Lop";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLop",MaLop);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}
