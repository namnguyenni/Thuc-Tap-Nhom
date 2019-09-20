using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using KetNoiDB;
namespace BangKhachSan
{
    public class BUS_DichVu
    {
        public DataTable HienThiDV()
        {
            string sql = "SELECT * FROM tblDichVu ";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }
    }
}