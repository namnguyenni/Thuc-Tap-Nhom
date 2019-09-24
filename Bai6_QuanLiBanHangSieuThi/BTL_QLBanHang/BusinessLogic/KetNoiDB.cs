using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLogic
{
    public class KetNoiDB
    {
        SqlConnection cn = new SqlConnection();
        static public String getconnect()
        {
            return (@"Data Source=NHOXHOANGANH\SQLEXPRESS;Initial Catalog=Bai6_BanHangSieuThi;Integrated Security=True");

        }
    }
}
