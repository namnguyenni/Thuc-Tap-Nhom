using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
   public class phongBLL
    {
        phongDAL Stclr = new phongDAL();
        public DataTable hienthithongtinphong()
        {
            return Stclr.hienthithongtinphong();
        }
    }
}
