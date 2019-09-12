using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BUS
{
    public class CTGD
    {
        public DataTable Show(string tenlop)
        {
            string sql = @"select mh.TenMon, gv.HoTen, NgayDay, Tiet 
                                from tblCTGD ct, tblMonHoc mh, tblLop l, tblGiaoVien gv
                                where ct.MaLop=l.MaLop and ct.MaMon=mh.MaMon and ct.MaGV=gv.MaGV and l.tenlop='" + tenlop + "'";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            da.Dispose();
            return dt;
        }
        public void ThemCTGD(string malop, string mamon, string magv, DateTime ngayday, int tiet)
        {
            string sql = "ThemCTGD";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@malop", malop);
            cmd.Parameters.AddWithValue("@mamon", mamon);
            cmd.Parameters.AddWithValue("@magv", magv);
            cmd.Parameters.AddWithValue("@ngayday", ngayday);
            cmd.Parameters.AddWithValue("@tiet", tiet);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void SuaCTGD(string malop, string mamon, string magv, DateTime ngayday, int tiet)
        {
            string sql = "SuaCTGD";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@malop", malop);
            cmd.Parameters.AddWithValue("@mamon", mamon);
            cmd.Parameters.AddWithValue("@magv", magv);
            cmd.Parameters.AddWithValue("@ngayday", ngayday);
            cmd.Parameters.AddWithValue("@tiet", tiet);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        //Xoa
        public void XoaCTGD(string malop, string mamon)
        {
            string sql = "XoaCTGD";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@malop", malop);
            cmd.Parameters.AddWithValue("@mamon", mamon);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}
