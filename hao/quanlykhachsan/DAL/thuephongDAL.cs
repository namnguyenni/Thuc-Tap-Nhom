using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
   public class thuephongDAL
    {
        public bool them_thuephong(int maKhachHang, DateTime ngayDen, int maPhong)
        {
            SqlConnection cnn = ketnoi.Get();
            SqlCommand cmd = new SqlCommand("them_thuephong", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("maKhachHang", maKhachHang);
            cmd.Parameters.AddWithValue("ngayDen", ngayDen);

            cmd.Parameters.AddWithValue("maPhong", maPhong);

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
        public DataTable hienthi_thuetheophong()
        {
            SqlConnection cnn = ketnoi.Get();
            // Khai báo và khởi tạo đối tượng Command, truyền vào tên thủ tục tương ứng
            SqlCommand cmd = new SqlCommand("hienthi_thuetheophong", cnn);
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
        public void tinhtien( DateTime ngayDi, float thanhTien, int maThuePhong, int maPhong)
        {
            SqlConnection cnn = ketnoi.Get();
            SqlCommand cmd = new SqlCommand("tinhtien ", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("ngayDi", ngayDi);
            cmd.Parameters.AddWithValue("thanhTien", thanhTien);
            cmd.Parameters.AddWithValue("maThuePhong", maThuePhong);
            cmd.Parameters.AddWithValue("maPhong", maPhong);
            int i = cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}

