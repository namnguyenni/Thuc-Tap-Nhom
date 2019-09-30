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
    public class CTHD
    {
        KetNoiDB da = new KetNoiDB();
        public DataTable ShowCTHD(string DieuKien)
        {
            string sql = @"SELECT MaSP, SoLuong, DonGia, ThanhTien FROM dbo.CHITIETHOADONNHAP " + DieuKien;
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(dt);
            return dt;
        }
        public void InsertCTHD(EC_CTHD et)
        {
            string sql = "ThemCTHD";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mahd", et.MaHD);
            cmd.Parameters.AddWithValue("@masp", et.MaSP);
            cmd.Parameters.AddWithValue("@soluong", et.SoLuong);
            cmd.Parameters.AddWithValue("@dongia", et.GiaNhap);
            cmd.Parameters.AddWithValue("@thanhtien", et.ThanhTien);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
        public void UpdateHDN(EC_CTHD et)
        {
            string sql = "SuaHDN";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mahd", et.MaHD);
            cmd.Parameters.AddWithValue("@masp", et.MaSP);
            cmd.Parameters.AddWithValue("@soluong", et.SoLuong);
            cmd.Parameters.AddWithValue("@dongia", et.GiaNhap);
            cmd.Parameters.AddWithValue("@thanhtien", et.ThanhTien);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
        public void DeleteCTHD(string _MaHD, string _MaSP)
        {
            string sql = "XoaCTHD";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mahd", _MaHD);
            cmd.Parameters.AddWithValue("@masp", _MaSP);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}
