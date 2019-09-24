using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entity;

namespace BusinessLogic
{
    public class HoaDonNhap
    {
        KetNoiDB da = new KetNoiDB();

        public DataTable ShowHDN(string DieuKien)
        {
            string sql = @"SELECT * FROM dbo.HOADONNHAP " + DieuKien;
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(dt);
            return dt;
        }
        public DataTable ShowHDN(DateTime _NgayDau, DateTime _NgayCuoi)
        {
            string sql = "ThongKeHDN";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ngaydau", _NgayDau);
            cmd.Parameters.AddWithValue("@ngaycuoi", _NgayCuoi);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dt);
            return dt;
        }
        public DataTable PhieuNhap(string _MaNCC)
        {
            string sql = "PhieuNhap";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mancc", _MaNCC);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dt);
            return dt;
        }
        public string InsertHDN(EC_HOADONNHAP et)
        {
            string sql = "ThemHDN";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mancc", et.MaNCC);
            cmd.Parameters.AddWithValue("@ngaynhap", et.NgayNhap);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            ad.Fill(dt);
            string ma = dt.Rows[0].ItemArray[0].ToString();
            
            cmd.Dispose();
            con.Close();
            if (ma != null) return ma;
            return "error";
        }
        public void UpdateHDN(EC_HOADONNHAP et)
        {
            string sql = "SuaHDN";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mahdn", et.MaHDN);
            cmd.Parameters.AddWithValue("@mancc", et.MaNCC);
            cmd.Parameters.AddWithValue("@ngaynhap", et.NgayNhap);


            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
        public void DeleteHDN(string _MaHDN)
        {
            string sql = "XoaHDN";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mahdn", _MaHDN);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public string TongTien(string _MaHD)
        {
            string sql = "TongTien";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mahd", _MaHD);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            cmd.Dispose();
            con.Close();
            string tien = dt.Rows[0].ItemArray[0].ToString();
            return tien;
        }
    }
}
