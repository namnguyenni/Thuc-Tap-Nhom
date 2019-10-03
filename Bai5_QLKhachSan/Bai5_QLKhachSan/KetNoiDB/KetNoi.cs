using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using KetNoiDB;
namespace KetNoiDB
{
    public class KetNoi
    {
        SqlConnection cn = new SqlConnection();

        public static String connect()
        {
            return (@"Data Source=DESKTOP-2QBJM9N;Initial Catalog=QL_KhachSan;Integrated Security=True");
        }
    }
}
