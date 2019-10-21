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
        KetNoiDB db = new KetNoiDB();
        public DataTable ShowCTPN(string DieuKien)
        {
            string sql = @"SELECT MaHH, SoLuong, DonGia, ThanhTien FROM dbo.CHITIETPHIEUNHAP " + DieuKien;
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(KetNoiDB.getconnect());
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }
        public void InsertCTHD(string mapn, string mahh, int soluong, long dongia, long thanhtien)
        {
            string sql = "ThemCTPN";
            SqlConnection conn = new SqlConnection(KetNoiDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@mapn", mapn);
            cmd.Parameters.AddWithValue("@mahh", mahh);
            cmd.Parameters.AddWithValue("@soluong", soluong);
            cmd.Parameters.AddWithValue("@dongia", dongia);
            cmd.Parameters.AddWithValue("@thanhtien", thanhtien);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();

        }



        public DataTable HienThi(string DieuKien)
        {
            string sql = @"SELECT * FROM dbo.CHITIETPHIEUNHAP WHERE MaPN = '" + DieuKien + "'";
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(KetNoiDB.getconnect());
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }


        public void Insert(string mapn, string mahh, int soluong, long dongia, long thanhtien)
        {
            string sql = "ThemCTPN";
            SqlConnection conn = new SqlConnection(KetNoiDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@mapn", mapn);
            cmd.Parameters.AddWithValue("@mahh", mahh);
            cmd.Parameters.AddWithValue("@soluong", soluong);
            cmd.Parameters.AddWithValue("@dongia", dongia);
            cmd.Parameters.AddWithValue("@thanhtien", thanhtien);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();

        }


        public DataTable HienThiTT(string DieuKien)
        {
            string sql = @"SELECT * FROM dbo.CHITIETPHIEUNHAP WHERE MaPN = '" + DieuKien + "'";
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(KetNoiDB.getconnect());
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }

    }
}
