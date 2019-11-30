using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    public class ketnoi
    {
        public static SqlConnection Get()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=2BQIVLU755WPSM0;Initial Catalog=quanlykhachsan;Integrated Security=True";
            cnn.Open();
            return cnn;
        }
    }
}
