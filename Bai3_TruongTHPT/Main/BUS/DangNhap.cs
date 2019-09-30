using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BUS
{
    public class DangNhap
    {

        public bool DangNhapHT(string UserName, string Pass)
        {
            string sql = "SELECT * FROM dbo.DangNhap WHERE UserName='" + UserName + "' AND Pass='" + Pass + "'";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
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
