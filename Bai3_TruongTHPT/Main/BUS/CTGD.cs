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
                                from dbo.CTGD ct, dbo.MonHoc mh, dbo.Lop l, dbo.GiaoVien gv
                                where ct.MaLop=l.MaLop and ct.MaMon=mh.MaMon and ct.MaGV=gv.MaGV and l.tenlop='" + tenlop + "'";
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(ConnectDB.getconnect());
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            conn.Close();
            da.Dispose();
            return dt;
        }
        public void ThemCTGD(string malop, string mamon, string magv, DateTime ngayday, int tiet)
        {
            string sql = "ThemCTGD";
            SqlConnection conn = new SqlConnection(ConnectDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@malop", malop);
            cmd.Parameters.AddWithValue("@mamon", mamon);
            cmd.Parameters.AddWithValue("@magv", magv);
            cmd.Parameters.AddWithValue("@ngayday", ngayday);
            cmd.Parameters.AddWithValue("@tiet", tiet);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
        public void SuaCTGD(string malop, string mamon, string magv, DateTime ngayday, int tiet)
        {
            string sql = "SuaCTGD";
            SqlConnection conn = new SqlConnection(ConnectDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@malop", malop);
            cmd.Parameters.AddWithValue("@mamon", mamon);
            cmd.Parameters.AddWithValue("@magv", magv);
            cmd.Parameters.AddWithValue("@ngayday", ngayday);
            cmd.Parameters.AddWithValue("@tiet", tiet);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        //Xoa
        public void XoaCTGD(string malop, string mamon)
        {
            string sql = "XoaCTGD";
            SqlConnection conn = new SqlConnection(ConnectDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@malop", malop);
            cmd.Parameters.AddWithValue("@mamon", mamon);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
    }
}
