using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class ConnectDB
    {
        SqlConnection cn = new SqlConnection();
        static public String getconnect()
        {
            return (@"Data Source=NHOXHOANGANH\SQLEXPRESS; Initial Catalog=TruongTHPT; Integrated Security=true");
        }
    }
}
