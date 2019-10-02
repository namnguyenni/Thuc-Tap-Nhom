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
            string sql = "SELECT MaLop, TenLop FROM dbo.Lop";
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(ConnectDB.getconnect());
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            conn.Close();
            da.Dispose();
            return dt;
        }
        //sua lop
        public void Sua_Lop(string MaLop, string TenLop, string Gvcn)
        {
            string sql = "Sua_Lop";
            SqlConnection conn = new SqlConnection(ConnectDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaLop",MaLop);
            cmd.Parameters.AddWithValue("@TenLop", TenLop);
            cmd.Parameters.AddWithValue("@GVCN", Gvcn);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
        public void ThemLop(string TenLop, string Gvcn)
        {
            string sql = "ADD_Lop";
            SqlConnection conn = new SqlConnection(ConnectDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@TenLop", TenLop);
            cmd.Parameters.AddWithValue("@GVCN", Gvcn);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        // Xóa
        public void Xoa_Lop(string MaLop)
        {
            string sql = "Xoa_Lop";
            SqlConnection conn = new SqlConnection(ConnectDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLop",MaLop);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
    }
}
