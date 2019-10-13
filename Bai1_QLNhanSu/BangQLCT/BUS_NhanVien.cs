using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KetNoiDB;
using System.Data.SqlClient;
using System.Data;
namespace BangQLCT
{
    public class BUS_NhanVien
    {
        KetNoi cn = new KetNoi();

        public DataTable HienThiNhanVien()
        {
            string sql = "SELECT * FROM dbo.NhanVien";
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(KetNoi.connect());
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }

        public void ThemNhanVien(string HoDem, string TenNV, string NS, string GT, string LUONG, string DC, string Ma_NQL, string MaDV, string ChucVu, string DT)
        {
            string sql = "ADDNhanVien";
            SqlConnection conn = new SqlConnection(KetNoi.connect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@HoDem", HoDem);
            cmd.Parameters.AddWithValue("@TenNV", TenNV);
            cmd.Parameters.AddWithValue("@NS", DateTime.Parse(NS));
            cmd.Parameters.AddWithValue("@GT", GT);
            cmd.Parameters.AddWithValue("@LUONG", int.Parse(LUONG));
            cmd.Parameters.AddWithValue("@DiaChi", DC);
            cmd.Parameters.AddWithValue("@Ma_NQL", Ma_NQL);
            cmd.Parameters.AddWithValue("@MaDV", MaDV);
            cmd.Parameters.AddWithValue("@ChucVu", ChucVu);
            cmd.Parameters.AddWithValue("@DT", DT);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        public void SuaNhanVien(string MaNV, string HoDem, string TenNV, string NS, string GT, string LUONG, string DC, string Ma_NQL, string MaDV, string ChucVu, string DT)
        {
            string sql = "SuaNhanVien";
            SqlConnection conn = new SqlConnection(KetNoi.connect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@HoDem", HoDem);
            cmd.Parameters.AddWithValue("@TenNV", TenNV);
            cmd.Parameters.AddWithValue("@NS", DateTime.Parse(NS));
            cmd.Parameters.AddWithValue("@GT", GT);
            cmd.Parameters.AddWithValue("@LUONG", int.Parse(LUONG));
            cmd.Parameters.AddWithValue("@DiaChi", DC);
            cmd.Parameters.AddWithValue("@Ma_NQL", Ma_NQL);
            cmd.Parameters.AddWithValue("@MaDV", MaDV);
            cmd.Parameters.AddWithValue("@ChucVu", ChucVu);
            cmd.Parameters.AddWithValue("@DT", DT);
            cmd.Parameters.AddWithValue("@MaNV", MaNV);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        public void XoaNhanVien(string MaNV)
        {
            string sql = "Xoa_NV";
            SqlConnection conn = new SqlConnection(KetNoi.connect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNV", MaNV);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
    }
}
