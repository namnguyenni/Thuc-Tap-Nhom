using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLogic
{
    public class PhieuNhap
    {
        KetNoiDB da = new KetNoiDB();

        public DataTable ShowPN(string DieuKien)
        {
            string sql = @"SELECT MaPN, MaNCC, NgayNhap FROM PHIEUNHAP " + DieuKien;
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(dt);
            return dt;
        }
        public DataTable ShowPN(DateTime _NgayDau, DateTime _NgayCuoi)
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

        public void addTien(string MaPN)
        {
            string sql = "TienNhap";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPN", MaPN);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public DataTable HT_PN(string ngay1, string ngay2)
        {
            string str = "TK_PN";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ngay1", DateTime.Parse(ngay1));
            cmd.Parameters.AddWithValue("@Ngay2", DateTime.Parse(ngay2));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public DataTable HT_CTPN(string ngay1, string ngay2)
        {
            string str = "HT_TK_CTPN";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ngay1", DateTime.Parse(ngay1));
            cmd.Parameters.AddWithValue("@Ngay2", DateTime.Parse(ngay2));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        //public DataTable PhieuNhap(string _MaNCC)
        //{
        //    string sql = "PhieuNhap";
        //    DataTable dt = new DataTable();
        //    SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand(sql, con);
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    cmd.Parameters.AddWithValue("@mancc", _MaNCC);
        //    SqlDataAdapter ad = new SqlDataAdapter(cmd);
        //    ad.Fill(dt);
        //    return dt;
        //}
        public string InsertPN(string mancc, DateTime ngaynhap)
        {
            string sql = "ThemPN";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@mancc", mancc);
            cmd.Parameters.AddWithValue("@ngaynhap", ngaynhap);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            ad.Fill(dt);
            string ma = dt.Rows[0].ItemArray[0].ToString();

            cmd.Dispose();
            con.Close();
            if (ma != null) return ma;
            return "error";
        }
        //public void UpdateHDN(EC_HOADONNHAP et)
        //{
        //    string sql = "SuaHDN";
        //    SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand(sql, con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@mahdn", et.MaHDN);
        //    cmd.Parameters.AddWithValue("@mancc", et.MaNCC);
        //    cmd.Parameters.AddWithValue("@ngaynhap", et.NgayNhap);


        //    cmd.ExecuteNonQuery();
        //    cmd.Dispose();
        //    con.Close();

        //}
        //public void DeleteHDN(string _MaHDN)
        //{
        //    string sql = "XoaHDN";
        //    SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand(sql, con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@mahdn", _MaHDN);

        //    cmd.ExecuteNonQuery();
        //    cmd.Dispose();
        //    con.Close();
        //}

        public string TongTien(string mapn)
        {
            string sql = "TongTien";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mapn", mapn);
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
