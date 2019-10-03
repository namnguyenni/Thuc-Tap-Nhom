using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogic
{
    public class ChiTietHoaDonBan
    {
        KetNoiDB  kn =new KetNoiDB();

        public DataTable HienThiCTHDB()
        {
            DataTable dt = new DataTable();
            string sql = "ShowCTHDB";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            cmd.Dispose();
            con.Close();
            return dt;
        }

        public DataTable HienThiCTHDB(string MaHDB)
        {
            DataTable dt = new DataTable();
            string sql = "ShowCTHDB2";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHDB", MaHDB);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            cmd.Dispose();
            con.Close();
            return dt;
        }

        public void InsertCTHD(string _MaHDB, string _MaSP, string _SoLg, string _DonGia)
        {
            string sql = "InsertCTHDB";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHDB", _MaHDB);
            cmd.Parameters.AddWithValue("@MaSP", _MaSP);
            cmd.Parameters.AddWithValue("@SoLuong", int.Parse(_SoLg));
            cmd.Parameters.AddWithValue("@dongia", float.Parse(_DonGia));
            cmd.Parameters.AddWithValue("@ThanhTien", float.Parse(_DonGia) * int.Parse(_SoLg));
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void UpdateCTHD(string _MaHDB, string _MaSP, string _SoLg, string _DonGia)
        {
            string sql = "UpdateCTHDB";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHDB", _MaHDB);
            cmd.Parameters.AddWithValue("@MaSP", _MaSP);
            cmd.Parameters.AddWithValue("@SoLuong", int.Parse(_SoLg));
            cmd.Parameters.AddWithValue("@dongia", float.Parse(_DonGia));
            cmd.Parameters.AddWithValue("@ThanhTien", float.Parse(_DonGia) * int.Parse(_SoLg));
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void DeleteCTHDB(string _MaHDB, string _MaSP)
        {
            string str = "DeleteCTHDB";
            SqlConnection con = new SqlConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHDB", _MaHDB);
            cmd.Parameters.AddWithValue("@MaSP", _MaSP);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }






        public DataTable HTCTHDB()
        {
            DataTable dt = new DataTable();
            string sql = "STHDB";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            cmd.Dispose();
            con.Close();
            return dt;
        }

        public DataTable HT2(string MaHDB)
        {
            DataTable dt = new DataTable();
            string sql = "SCTHDB2";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHDB", MaHDB);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            cmd.Dispose();
            con.Close();
            return dt;
        }

        public void ICTHD(string _MaHDB, string _MaSP, string _SoLg, string _DonGia)
        {
            string sql = "ICTHDB";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHDB", _MaHDB);
            cmd.Parameters.AddWithValue("@MaSP", _MaSP);
            cmd.Parameters.AddWithValue("@SoLuong", int.Parse(_SoLg));
            cmd.Parameters.AddWithValue("@dongia", float.Parse(_DonGia));
            cmd.Parameters.AddWithValue("@ThanhTien", float.Parse(_DonGia) * int.Parse(_SoLg));
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}
