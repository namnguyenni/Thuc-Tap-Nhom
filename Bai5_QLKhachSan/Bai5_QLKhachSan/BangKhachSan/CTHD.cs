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
    public class CTHD
    {
        KetNoi cn = new KetNoi();

        public DataTable HienCTDH(string dieukien)
        {
            string sql = "SELECT ct.MaDV, TenDV, Gia FROM tblCTHD ct, tblDichVu dv where ct.MaDV=dv.MaDV " + dieukien;
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }

        //public void ThemPhong(string TenPhong, string LoaiPhong)
        //{
        //    string sql = "ADDPhong";
        //    SqlConnection con = new SqlConnection(KetNoi.connect());
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand(sql, con);
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    cmd.Parameters.AddWithValue("@TenPhong", TenPhong);
        //    cmd.Parameters.AddWithValue("@LoaiPhong", LoaiPhong);

        //    cmd.ExecuteNonQuery();
        //    cmd.Dispose();
        //    con.Close();
        //}

        //public void SuaCTHD(string MaHD, string MaPhong, string MaDV, long TongTien, DateTime TGMuon, DateTime TGTra)
        //{
        //    string sql = "SuaCTHD";
        //    SqlConnection con = new SqlConnection(KetNoi.connect());
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand(sql, con);
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    cmd.Parameters.AddWithValue("@MaPhong", MaPhong);
        //    cmd.Parameters.AddWithValue("@TenPhong", TenPhong);
        //    cmd.Parameters.AddWithValue("@LoaiPhong", LoaiPhong);
        //    cmd.ExecuteNonQuery();

        //    cmd.Dispose();
        //    con.Close();
        //}
    }
}
