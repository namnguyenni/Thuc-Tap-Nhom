using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace BusinessLogic
{
    public class ChiTietPhieuNhap
    {
        KetNoiDB da = new KetNoiDB();
        public DataTable ShowCTPN(string DieuKien)
        {
            string sql = @"SELECT MaHH, SoLuong, DonGia, ThanhTien FROM dbo.CHITIETPHIEUNHAP " + DieuKien;
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(dt);
            return dt;
        }
        public void InsertCTHD(string mapn, string mahh, int soluong, long dongia, long thanhtien)
        {
            string sql = "ThemCTPN";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@mapn", mapn);
            cmd.Parameters.AddWithValue("@mahh", mahh);
            cmd.Parameters.AddWithValue("@soluong", soluong);
            cmd.Parameters.AddWithValue("@dongia", dongia);
            cmd.Parameters.AddWithValue("@thanhtien", thanhtien);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }


        public DataTable HienThi(string DieuKien)
        {
            string sql = @"SELECT * FROM dbo.CHITIETPHIEUNHAP WHERE MaPN = '" + DieuKien + "'";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(dt);
            return dt;
        }

        public DataTable HienThiTien(string DieuKien)
        {
            string sql = @"SELECT TongTien FROM dbo.PHIEUNHAP WHERE MaPN = '" + DieuKien + "'";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(dt);
            return dt;
        }
    }
}
