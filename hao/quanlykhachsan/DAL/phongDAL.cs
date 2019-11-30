using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
   public class phongDAL
    {
        public DataTable hienthithongtinphong()
        {
            SqlConnection cnn = ketnoi.Get();         
            // Khai báo và khởi tạo đối tượng Command, truyền vào tên thủ tục tương ứng
            SqlCommand cmd = new SqlCommand("hienthiphong", cnn);
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
    }
}
