using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using KetNoiDB;
namespace BangQLCT
{
    public class BUS_DangNhap
    {
        public bool DangNhap(string Username, string Pass)
        {


            // cau lenh trong sql
            string sql = "SELECT * FROM dbo.DangNhap WHERE UserName='" + Username + "' AND Pass='" + Pass + "'";
            //tao ket noi sqlconnecttion
            SqlConnection con = new SqlConnection(KetNoi.connect());
            // tao bang ao luu data
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
