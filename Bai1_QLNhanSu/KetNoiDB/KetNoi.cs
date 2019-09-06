using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace KetNoiDB
{
    public class KetNoi
    {
        SqlConnection cn = new SqlConnection();

        public static String connect()
        {
            return (@"Data Source=NHOXHOANGANH\SQLEXPRESS;Initial Catalog=QLCT_2;Integrated Security=true");
        }
    }
}
