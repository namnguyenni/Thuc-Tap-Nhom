using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DAL
{
   public class nhanvienDAL
    {
        public DataTable hienthinhanvien()
        {
            SqlConnection cnn = ketnoi.Get();
            // Khai báo và khởi tạo đối tượng Command, truyền vào tên thủ tục tương ứng
            SqlCommand cmd = new SqlCommand("hienthitatcanhanvien", cnn);
            // Khai báo kiểu thực thi là Thực thi thủ tục
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public bool them_nhanvien(string hoTen, bool gioiTinh, DateTime ngaySinh, string soChungMinh, string diaChi, string soDienThoai, DateTime ngayVaoLam)
        {
            SqlConnection cnn = ketnoi.Get();
            SqlCommand cmd = new SqlCommand("them_nhanvien", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("hoTen", hoTen);
            cmd.Parameters.AddWithValue("gioiTinh", gioiTinh);
            cmd.Parameters.AddWithValue("ngaySinh", ngaySinh);
            cmd.Parameters.AddWithValue("soChungMinh", soChungMinh);
            cmd.Parameters.AddWithValue("diaChi", diaChi);
            cmd.Parameters.AddWithValue("soDienThoai", soDienThoai);
            cmd.Parameters.AddWithValue("ngayVaoLam", ngayVaoLam);

            int i = cmd.ExecuteNonQuery();
            cnn.Close();
            if (i != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
            public void xoa_nhanvien(int maNhanVien)
        {

            SqlConnection cnn = ketnoi.Get();
            SqlCommand cmd = new SqlCommand("xoa_nhanvien", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("maNhanVien", maNhanVien);
            int i = cmd.ExecuteNonQuery();
            cnn.Close();

        }

        public void sua_nhanvien(string hoTen, bool gioiTinh, DateTime ngaySinh, string soChungMinh, string diaChi, string soDienThoai, DateTime ngayVaoLam, int maNhanVien)
        {
            SqlConnection cnn = ketnoi.Get();
            SqlCommand cmd = new SqlCommand("sua_nhanvien", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("hoTen", hoTen);
            cmd.Parameters.AddWithValue("gioiTinh", gioiTinh);
            cmd.Parameters.AddWithValue("ngaySinh", ngaySinh);
            cmd.Parameters.AddWithValue("soChungMinh", soChungMinh);
            cmd.Parameters.AddWithValue("diaChi", diaChi);
            cmd.Parameters.AddWithValue("soDienThoai", soDienThoai);
            cmd.Parameters.AddWithValue("ngayVaoLam", ngayVaoLam);
            cmd.Parameters.AddWithValue("maNhanVien", maNhanVien);
            int i = cmd.ExecuteNonQuery();
            cnn.Close();
        }
    
    }
}
