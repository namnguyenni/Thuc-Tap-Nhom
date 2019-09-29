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
        SqlConnection con = new SqlConnection();

        public static String connect()
        {
            return (@"Data Source=DESKTOP-42NHODK;Initial Catalog=QLCT_2;Integrated Security=True");
        }
    }
}
