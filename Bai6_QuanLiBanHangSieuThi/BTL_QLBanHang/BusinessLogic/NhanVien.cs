using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BusinessLogic
{
    public class NhanVien
    {
        //KetNoiDB da = new KetNoiDB();

        public DataTable HienThiNhanVien()
        {
            string sql = "SELECT * FROM NHANVIEN";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }

        public void ThemNhanVien(string TenDn, string MatKhau, string TenNV, string GT, string DiaChi, string SDT)
        {
            string sql = "ADDNhanVien";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenDn",TenDn);
            cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
            cmd.Parameters.AddWithValue("@TenNV", TenNV);
            cmd.Parameters.AddWithValue("@GT",GT);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@SDT", SDT);
           
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public void SuaNhanVien(string TenDn, string MatKhau, string TenNV, string GT, string DiaChi, string SDT)
        {
            string sql = "SuaNhanVien";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
            cmd.Parameters.AddWithValue("@TenNV", TenNV);
            cmd.Parameters.AddWithValue("@GT", GT);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@SDT", SDT);
            cmd.Parameters.AddWithValue("@TenDn", TenDn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public void XoaNhanVien(string TenDN)
        {
            string sql = "Xoa_NV";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenDN", TenDN);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public DataTable TKTenDN(string TenDN)
        {
            string sql = "SELECT * FROM NHANVIEN WHERE TenDN LIKE N'%' + @TenDN + '%'";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@TenDN", TenDN);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;

        }

        // Tìm kiếm nhan vien theo tên
        public DataTable TKTenNV(string TenNV)
        {
            string sql = "SELECT * FROM NHANVIEN WHERE TenNV LIKE N'%' + @TenNV + '%'";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@TenNV", TenNV);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        //tìm kiếm nhan vien theo mã  trên thanh tìm kiếm.
        //public DataTable TKMaNhanVien(string MaNV)
        //{
        //    string sql = "SELECT * FROM tblNhanVien WHERE MaNV LIKE (N'%' + @MaNV + '%')";
        //    DataTable dt = new DataTable();
        //    SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand(sql, con);
        //    SqlDataAdapter da = new SqlDataAdapter();
        //    cmd.Parameters.AddWithValue("@MaNV", MaNV);
        //    da.SelectCommand = cmd;
        //    da.Fill(dt);
        //    return dt;
        //}
        // Tìm kiếm nhân viên theo Tên
        //public DataTable TKTenNhanVien(string TenNV)
        //{
        //    //string sql = "SELECT * FROM tblNhanVien WHERE TenNV LIKE (N'%' + @TenNV + '%')";
        //    string sql = "TKTen";
        //    DataTable dt = new DataTable();
        //    SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand(sql, con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    SqlDataAdapter da = new SqlDataAdapter();
        //    cmd.Parameters.AddWithValue("@TenNV", TenNV);
        //    da.SelectCommand = cmd;
        //    da.Fill(dt);
        //    return dt;
        //}
        // Tìm kiếm nhân viên theo giới tính
        public DataTable TKGTNhanVien(string GT)
        {
            string sql = "SELECT * FROM NHANVIEN WHERE GT LIKE (N'%' + @GT + '%')";
            //string sql = "TKGT";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            //cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@GT", GT);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        // Tìm nhân viên theo địa chỉ
        public DataTable TKDiaChiNhanVien(string DC)
        {
            string sql = "SELECT * FROM NHANVIEN WHERE DiaChi LIKE (N'%' + @DC + '%')";
            //string sql = "TKDiaChi";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            //cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@DC", DC);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
    }
}
