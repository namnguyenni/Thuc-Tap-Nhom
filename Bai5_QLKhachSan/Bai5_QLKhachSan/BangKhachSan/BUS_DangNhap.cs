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
    public class BUS_DangNhap
    {
        public bool DangNhap(string UserName, string Pass)
        {
            string sql = "SELECT * FROM dbo.DangNhap WHERE UserName='" + UserName + "' AND Pass='" + Pass + "'";
            SqlConnection con = new SqlConnection(KetNoi.connect());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);

            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
