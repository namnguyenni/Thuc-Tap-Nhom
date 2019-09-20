using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using KetNoiDB;
namespace BangKhachSan
{
    public class BUS_Phong
    {
        KetNoi cn = new KetNoi();

        public DataTable HienThiPhong()
        {
            string sql = "SELECT * FROM tblPhong";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }
        public DataTable HienThiPhongTrong()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM tblPhong where TinhTrang = N'Empty'";
            SqlConnection con = new SqlConnection(KetNoi.connect());
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }

        public string GiaPhong(string maphong)
        {
            string sql = "SELECT GiaPhong FROM tblPhong";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            
            string gia = dt.Rows[0].ItemArray[0].ToString();
            return gia;
        }
        public void ThemPhong(string TenPhong,string LoaiPhong)
        {
            string sql = "ADDPhong";
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@TenPhong", TenPhong);
            cmd.Parameters.AddWithValue("@LoaiPhong", LoaiPhong);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public void SuaPhong(string MaPhong,string TenPhong, string LoaiPhong)
        {
            string sql = "SuaPhong";
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaPhong", MaPhong);
            cmd.Parameters.AddWithValue("@TenPhong", TenPhong);
            cmd.Parameters.AddWithValue("@LoaiPhong", LoaiPhong);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
        }

        public void XoaPhong(string MaPhong)
        {
            string sql = "Xoa_Phong";
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPhong", MaPhong);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}
