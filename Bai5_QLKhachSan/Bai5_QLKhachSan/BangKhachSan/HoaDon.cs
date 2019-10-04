using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using KetNoiDB;

namespace BangKhachSan
{
    public class HoaDon
    {
        KetNoi cn = new KetNoi();

        public DataTable HienDH()
        {
            string sql = "SELECT MaHD FROM tblHoaDon";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }
        public void SuaHD(string MaHD, long TongTien, DateTime TGTra)
        {
            string sql = "SuaHD";
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TGTra", TGTra);
            cmd.Parameters.AddWithValue("@MaHD", MaHD);
            cmd.Parameters.AddWithValue("@TongTien", TongTien);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}
