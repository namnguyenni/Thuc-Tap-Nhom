using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class ketnoi
    {
        public static SqlConnection Get()
        {
            SqlConnection cnn = new SqlConnection();
             //@"Data Source=THANH-HOANG-THU;Initial Catalog=quanlykhachsan;Integrated Security=True";
            cnn.ConnectionString = @"Data Source=MINHHIEU2010199;Initial Catalog=quanlykhachsan;Integrated Security=True";
            cnn.Open();
            return cnn;
        }
   }
}
