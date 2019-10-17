using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLogic
{
    public class NhaCungCap
    {
        KetNoiDB da = new KetNoiDB();
        public DataTable ShowNCC(string DieuKien)
        {
            string sql = @"SELECT * FROM dbo.NHACUNGCAP " + DieuKien;
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(KetNoiDB.getconnect());
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }
        public void InsertNCC(string _TenNCC, string _DiaChi, string _SDT)
        {
            string sql = "ThemNCC";
            SqlConnection conn = new SqlConnection(KetNoiDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@tenlh", _TenNCC);
            cmd.Parameters.AddWithValue("@diachi", _DiaChi);
            cmd.Parameters.AddWithValue("@sdt", _SDT);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();

        }
        public void UpdateNCC(string _MaNCC, string _TenNCC, string _DiaChi, string _SDT)
        {
            string sql = "SuaNCC";
            SqlConnection conn = new SqlConnection(KetNoiDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@mancc", _MaNCC);
            cmd.Parameters.AddWithValue("@tenncc", _TenNCC);
            cmd.Parameters.AddWithValue("@diachi", _DiaChi);
            cmd.Parameters.AddWithValue("@sdt", _SDT);


            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();

        }
        public void DeleteNCC(string _MaNCC)
        {
            string sql = "XoaNCC";
            SqlConnection conn = new SqlConnection(KetNoiDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@mancc", _MaNCC);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        // commit

        public void InsertNCC_1(string _TenNCC, string _DiaChi, string _SDT)
        {
            string sql = "ADD_NCC";
            SqlConnection conn = new SqlConnection(KetNoiDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@tenlh", _TenNCC);
            cmd.Parameters.AddWithValue("@diachi", _DiaChi);
            cmd.Parameters.AddWithValue("@sdt", _SDT);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();

        }
        public void UpdateNCC_1(string _MaNCC, string _TenNCC, string _DiaChi, string _SDT)
        {
            string sql = "EDIT_NCC";
            SqlConnection conn = new SqlConnection(KetNoiDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@mancc", _MaNCC);
            cmd.Parameters.AddWithValue("@tenncc", _TenNCC);
            cmd.Parameters.AddWithValue("@diachi", _DiaChi);
            cmd.Parameters.AddWithValue("@sdt", _SDT);


            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();

        }
    }
}
