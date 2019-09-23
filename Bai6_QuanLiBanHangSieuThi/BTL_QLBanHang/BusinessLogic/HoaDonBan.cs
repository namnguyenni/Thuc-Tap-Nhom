using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogic
{
    public class HoaDonBan
    {
        KetNoiDB kn = new KetNoiDB();

        public DataTable HienThiHDB()
        {
            DataTable dt = new DataTable();
            string sql = "ShowHDB";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            cmd.Dispose();
            con.Close();
            return dt;
        }

        public DataTable HienThiHDB(long tien1, long tien2)
        {
            DataTable dt = new DataTable();
            string sql = "ShowHDBTongTien";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tien1", tien1);
            cmd.Parameters.AddWithValue("@tien2", tien2);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            cmd.Dispose();
            con.Close();
            return dt;
        }

        public DataTable HienThiHDB(DateTime date)
        {
            DataTable dt = new DataTable();
            string sql = "ShowHDB1Ngay";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@date", date);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            cmd.Dispose();
            con.Close();
            return dt;
        }

        public DataTable HienThiHDB(DateTime date1, DateTime date2)
        {
            DataTable dt = new DataTable();
            string sql = "ShowHDBNhieuNgay";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@date1", date1);
            cmd.Parameters.AddWithValue("@date2", date2);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            cmd.Dispose();
            con.Close();
            return dt;
        }

        public DataTable HienThiTop10HDB()
        {
            DataTable dt = new DataTable();
            string sql = "MuaNhieuNhat";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            cmd.Dispose();
            con.Close();
            return dt;
        }
        public string InsertHDB(string _MaKH, DateTime _ngayban, long _tongtien)
        {
            string str = "";
            string sql = "InsertHDB";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKH", _MaKH);
            cmd.Parameters.AddWithValue("@NgayBan", _ngayban);
            cmd.Parameters.AddWithValue("@TongTien", _tongtien);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            str = dt.Rows[0].ItemArray[0].ToString();

            cmd.Dispose();
            con.Close();

            return str;
        }
        public void DeleteHDB(string _MaHDB)
        {
            string str = "DeleteHDB";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHDB", _MaHDB);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void UpdateHDB(string _MaHDB)
        {
            string str = "UpdateHDB";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHDB", _MaHDB);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}
