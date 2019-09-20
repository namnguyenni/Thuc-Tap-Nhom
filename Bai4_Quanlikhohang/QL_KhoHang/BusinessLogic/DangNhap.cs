using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogic
{
    public class DangNhap
    {
        KetNoiDB da = new KetNoiDB();
        public bool DangNhapHT(string Username, string Pass)
        {
            string sql = "SELECT * FROM DANGNHAP WHERE UserName='" + Username + "' AND Pass='" + Pass + "'";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);

            ad.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
