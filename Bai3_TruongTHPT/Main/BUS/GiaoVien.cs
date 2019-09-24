using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class GiaoVien
    {
        public DataTable Show()
        {
            string sql = "SELECT gv.MaGV, gv.HoTen, gv.GT, gv.NgaySinh, gv.DiaChi, gv.Luong, gv.SDT, mh.TenMon FROM dbo.GiaoVien gv, dbo.MonHoc mh where gv.MaMon = mh.MaMon";
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(ConnectDB.getconnect());
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            conn.Close();
            da.Dispose();
            return dt;
        }
        public DataTable Show(string tenmon)
        {
            string sql = "SELECT gv.MaGV, gv.HoTen FROM dbo.GiaoVien gv, dbo.MonHoc mh where gv.MaMon = mh.MaMon and mh.TenMon=N'" + tenmon + "'";
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(ConnectDB.getconnect());
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            conn.Close();
            da.Dispose();
            return dt;
        }
        public void ADDGiaoVien(string HoTen, string GT, string NgaySinh, string DiaChi, string SDT, string Luong, string MaMon)
        {
            string sql = "ADD_GV";
            SqlConnection conn = new SqlConnection(ConnectDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@HoTen", HoTen);
            cmd.Parameters.AddWithValue("@GT", GT);
            cmd.Parameters.AddWithValue("@NgaySinh", DateTime.Parse(NgaySinh));
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@SDT", int.Parse(SDT));
            cmd.Parameters.AddWithValue("@Luong", int.Parse(Luong));
            cmd.Parameters.AddWithValue("@MaMon", MaMon);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        //Sua 
        public void Sua_GV(string MaGV, string HoTen, string GT, string NgaySinh, string DiaChi, string SDT, string Luong, string Mon)
        {
            string sql = "Sua_GV";
            SqlConnection conn = new SqlConnection(ConnectDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaGV", MaGV);
            cmd.Parameters.AddWithValue("@HoTen", HoTen);
            cmd.Parameters.AddWithValue("@GT", GT);
            cmd.Parameters.AddWithValue("@NgaySinh", DateTime.Parse(NgaySinh));
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@SDT", int.Parse(SDT));
            cmd.Parameters.AddWithValue("@Luong", int.Parse(Luong));
            cmd.Parameters.AddWithValue("@MaMon", Mon);
           
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        //Xoa
        public void Xoa_GV(string MaGV)
        {
            string sql = "Xoa_GV";
            SqlConnection conn = new SqlConnection(ConnectDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaGV", MaGV);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
        //lay thong tin mon hoc
        public DataTable LayThongTinMonHoc()
        {
            string sql = "SELECT * FROM dbo.MonHoc";
            SqlConnection conn = new SqlConnection(ConnectDB.getconnect());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }
    }
}
