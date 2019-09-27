using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLogic
{
    public class DangNhap
    {
        public bool Login(string _Name, string _Pass)
        {
            string sql = @"select * from NHANVIEN WHERE TenDN = '" + _Name + "' AND MatKhau = '" + _Pass + "'";

            SqlConnection conn = new SqlConnection(KetNoiDB.getconnect());
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            if (dt.Rows.Count > 0) return true;
            return false;
        }
    }
}
