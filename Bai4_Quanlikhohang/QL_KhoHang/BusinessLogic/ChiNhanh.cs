using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLogic
{
    public class Branch
    {

        public DataTable DisplayCustomers()
        {
            string sql = @"SELECT * FROM dbo.CHINHANH ";
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(KetNoiDB.getconnect());
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }

        public string InsertCustomer(string TenKH, string Gioitinh, string Diachi, string SDT, string LoaiKH, string Ghichu)
        {
            string str = "";
            string sql = "InsertKH";
            //   string sql = "insert NhomSP values (@Manhom, @Tennhom, @NgayCN)";
            SqlConnection conn = new SqlConnection(KetNoiDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@TenKH", TenKH);
            cmd.Parameters.AddWithValue("@gt", Gioitinh);
            cmd.Parameters.AddWithValue("@DC", Diachi);
            cmd.Parameters.AddWithValue("@SDT", SDT);
            cmd.Parameters.AddWithValue("@LoaiKH", LoaiKH);
            cmd.Parameters.AddWithValue("@ghichu", Ghichu);

            //cmd.ExecuteNonQuery();

            DataTable dt = new DataTable(); // khoi tao mot bang moi
            SqlDataAdapter da = new SqlDataAdapter(cmd); // du lieu dang Adapter
            da.Fill(dt); // ghi du lieu vao bang
            str = dt.Rows[0].ItemArray[0].ToString();

            cmd.Dispose();
            conn.Close();

            return str;
        }

        public void UpdateCustomer(string MaKh, string TenKH, string Gioitinh, string Diachi, string SDT, string LoaiKH, string Ghichu)
        {
            string sql = "UpdateKH";
            SqlConnection conn = new SqlConnection(KetNoiDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaKH", MaKh);
            cmd.Parameters.AddWithValue("@TenKH", TenKH);
            cmd.Parameters.AddWithValue("@gt", Gioitinh);
            cmd.Parameters.AddWithValue("@DC", Diachi);
            cmd.Parameters.AddWithValue("@SDT", SDT);
            cmd.Parameters.AddWithValue("@LoaiKH", LoaiKH);
            cmd.Parameters.AddWithValue("@ghichu", Ghichu);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
        public void DeleteCustomer(string MaKh)
        {
            string sql = "DeleteKH";
            SqlConnection conn = new SqlConnection(KetNoiDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKH", MaKh);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        public DataTable SearchCustomer(string _TenKH)
        {
            DataTable dt = new DataTable();
            string sql = "SearchTenKH";
            SqlConnection conn = new SqlConnection(KetNoiDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@str", _TenKH);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            conn.Close();
            cmd.Dispose();
            return dt;

        }
        public DataTable SearchCustomerType(string _LoaiKH)
        {
            DataTable dt = new DataTable();
            string sql = "SearchLoaiKH";
            SqlConnection conn = new SqlConnection(KetNoiDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@str", _LoaiKH);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            conn.Close();
            cmd.Dispose();
            return dt;
        }
        public DataTable SearchCustomerAddress(string _DiaChi)
        {
            DataTable dt = new DataTable();
            string sql = "SearchDCKH";
            SqlConnection conn = new SqlConnection(KetNoiDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@str", _DiaChi);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            conn.Close();
            cmd.Dispose();
            return dt;
        }
        public DataTable Show10KH()
        {
            DataTable dt = new DataTable();
            string sql = "Show10KH";
            SqlConnection conn = new SqlConnection(KetNoiDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            conn.Close();
            cmd.Dispose();
            return dt;
        }
        public DataTable DisplayCustomerByDate(DateTime date1, DateTime date2)
        {
            DataTable dt = new DataTable();
            string sql = "ShowKHNhieuNgay";
            SqlConnection conn = new SqlConnection(KetNoiDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@date1", date1);
            cmd.Parameters.AddWithValue("@date2", date2);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            conn.Close();
            cmd.Dispose();
            return dt;
        }


        // commit
        public DataTable SearchC(string _TenKH)
        {
            DataTable dt = new DataTable();
            string sql = "SearchTenKH";
            SqlConnection conn = new SqlConnection(KetNoiDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@str", _TenKH);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            conn.Close();
            cmd.Dispose();
            return dt;

        }
        public DataTable SearchCustomerT(string _LoaiKH)
        {
            DataTable dt = new DataTable();
            string sql = "SearchLoaiKH";
            SqlConnection conn = new SqlConnection(KetNoiDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@str", _LoaiKH);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            conn.Close();
            cmd.Dispose();
            return dt;
        }
        public DataTable SearchCustomerAdd(string _DiaChi)
        {
            DataTable dt = new DataTable();
            string sql = "SearchDCKH";
            SqlConnection conn = new SqlConnection(KetNoiDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@str", _DiaChi);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            conn.Close();
            cmd.Dispose();
            return dt;
        }
    }
}
