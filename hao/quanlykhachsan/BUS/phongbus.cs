using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace BUS
{
    public class phongBUS
    {

            phongDAO Stclr = new phongBUS();

            //Student get by all
            public DataTable hienthithongtinphong()
            {
                return Stclr.hienthithongtinphong();
            }
        }
    
}
