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
        SqlConnection conn = new SqlConnection();
        static public String getconnect()
        {
            return (@"Data Source=DESKTOP-42NHODK;Initial Catalog=QL_KhoHang;Integrated Security=True");
        }
    }
}
