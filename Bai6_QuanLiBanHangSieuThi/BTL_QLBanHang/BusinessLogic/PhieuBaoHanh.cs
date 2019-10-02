using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace BusinessLogic
{
    public class PhieuBaoHanh
    {
        KetNoiDB da = new KetNoiDB();
        public DataTable ShowPBH()
        {
            string sql = @"SELECT * FROM PHIEUBAOHANH " ;
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(dt);
            return dt;
        }
        public void InsertPBH(string MaSP, string MaKH, string NgayBatDau,string NgayKetThuc,string SoLan)
        {
            string sql = "ThemPBH";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaSP", MaSP);
            cmd.Parameters.AddWithValue("@MaKH", MaKH);
            cmd.Parameters.AddWithValue("@NgayBatDau",NgayBatDau);
            cmd.Parameters.AddWithValue("@NgayKetThuc", NgayKetThuc);
            cmd.Parameters.AddWithValue("@SoLan", SoLan);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
        public void UpdatePBH(string SoPhieu,string MaSP, string MaKH, string NgayBatDau, string NgayKetThuc, string SoLan)
        {
            string sql = "SuaPBH";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SoPhieu", SoPhieu);
            cmd.Parameters.AddWithValue("@MaSP", MaSP);
            cmd.Parameters.AddWithValue("@MaKH", MaKH);
            cmd.Parameters.AddWithValue("@NgayBatDau", NgayBatDau);
            cmd.Parameters.AddWithValue("@NgayKetThuc", NgayKetThuc);
            cmd.Parameters.AddWithValue("@SoLan", SoLan);


            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
        public void DeletePBH(string SoPhieu)
        {
            string sql = "XoaPBH";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SoPhieu", SoPhieu);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }


        public DataTable SPBH()
        {
            string sql = @"SELECT * FROM PHIEUBAOHANH ";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(dt);
            return dt;
        }
        public void InsertPBH(string MaSP, string MaKH, string NgayBatDau, string NgayKetThuc, string SoLan)
        {
            string sql = "TPBH";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaSP", MaSP);
            cmd.Parameters.AddWithValue("@MaKH", MaKH);
            cmd.Parameters.AddWithValue("@NgayBatDau", NgayBatDau);
            cmd.Parameters.AddWithValue("@NgayKetThuc", NgayKetThuc);
            cmd.Parameters.AddWithValue("@SoLan", SoLan);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
    }
}
