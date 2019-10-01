using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class HocSinh
    {
        public DataTable Show()
        {
            string sql = "SELECT hs.MaHS, hs.HoTen, hs.GT, hs.NgaySinh, hs.DiaChi, hs.PhuHuynh, lop.TenLop FROM dbo.HocSinh hs, dbo.Lop lop WHERE hs.MaLop = lop.MaLop";
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(ConnectDB.getconnect());
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            conn.Close();
            da.Dispose();
            return dt;
        }

        //Sủa 
        public void Sua_HS(string MaHS, string HoTen, string GT, string NgaySinh, string DiaChi, string PhuHuynh, string MaLop)
        {
            string sql = "Sua_HS";
            SqlConnection conn = new SqlConnection(ConnectDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@HovaTen", HoTen);
            cmd.Parameters.AddWithValue("@GT", GT);
            cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@PhuHuynh", PhuHuynh);
            cmd.Parameters.AddWithValue("@MaLop", MaLop);
            cmd.Parameters.AddWithValue("@MaHS", MaHS);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
        public void ThemHocSinh(string HovaTen, string GT, DateTime NgaySinh, string DiaChi, string PhuHuynh, string MaLop)
        {
            string sql = "ADD_HocSinh";
            SqlConnection conn = new SqlConnection(ConnectDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@HovaTen", HovaTen);
            cmd.Parameters.AddWithValue("@GT", GT);
            cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@PhuHuynh", PhuHuynh);
            cmd.Parameters.AddWithValue("@MaLop", MaLop);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        // Xóa
        public void Xoa_HS(string MaHS)
        {
            string sql = "Xoa_HS";
            SqlConnection conn = new SqlConnection(ConnectDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHS", MaHS);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
        //lay thong tin lop
        public DataTable LayThongTinLop()
        {
            string sql = "SELECT * FROM dbo.Lop";
            SqlConnection conn = new SqlConnection(ConnectDB.getconnect());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }
    }
}
