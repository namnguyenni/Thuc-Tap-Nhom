using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using KetNoiDB;

namespace BangQLCT
{
    public class BUS_DonVi
    {
        KetNoi con = new KetNoi();

        public DataTable HienThiDonVi()
        {
            string sql = "SELECT * FROM dbo.DonVi";
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(KetNoi.connect());
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }
		
            string sql = "SELECT * FROM dbo.DonVi";
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(KetNoi.connect());
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }

        public void ThemDonVi(string TenDV, string NQL, string DC, string SoDT)
        {
            string sql = "ADDDonVi";
            SqlConnection conn = new SqlConnection(KetNoi.connect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenDV", TenDV);
            cmd.Parameters.AddWithValue("@NQL", NQL);
            cmd.Parameters.AddWithValue("@SoDT", SoDT);
             cmd.Parameters.AddWithValue("@DC", DC);
          
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        public void SuaDonVi(string MaDV, string TenDV, string NQL, string DC, string SoDT)
        {
            string sql = "SuaNhanVien";
            SqlConnection conn = new SqlConnection(KetNoi.connect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.AddWithValue("@SoDT", SoDT);
            cmd.Parameters.AddWithValue("@MaNV", MaDV);
            cmd.Parameters.AddWithValue("@DC", DC);
            cmd.Parameters.AddWithValue("@TenDV", TenDV);
            cmd.Parameters.AddWithValue("@NQL", NQL);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        public void XoaDonVi(string MaDV)
        {
            string sql = "Xoa_DV";
            SqlConnection conn = new SqlConnection(KetNoi.connect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDV", MaDV);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
    }
}
