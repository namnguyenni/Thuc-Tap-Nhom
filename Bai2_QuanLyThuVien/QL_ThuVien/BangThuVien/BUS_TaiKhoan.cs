using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using KetNoiDB;

namespace BangThuVien
{
    public class BUS_TaiKhoan
    {
        KetNoi cn = new KetNoi();
        dbConnection dbcon = new dbConnection();

        public DataTable HienThi()
        {
            DataTable dt = new DataTable();
            string str = string.Format("Select* from dbo.TaiKhoan");
            dt = dbcon.executeSelectQueryNonParameter(str);
            return dt;
        }
        public DataTable TimKiemID(string _ID)
        {
            DataTable dt = new DataTable();
            string str = string.Format("Select* from dbo.TaiKhoan where (ID = @ID)");
            SqlParameter[] arrPara = new SqlParameter[1];
            arrPara[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 20);
            arrPara[0].Value = _ID;

            dt = dbcon.executeSelectQuery(str, arrPara);
            return dt;
        }
    }
}
