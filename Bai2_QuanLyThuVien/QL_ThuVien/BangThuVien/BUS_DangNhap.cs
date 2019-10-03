using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KetNoiDB;
using System.Data;
using System.Data.SqlClient;
namespace BangThuVien
{
    public class BUS_DangNhap
    {
        public bool DangNhap(string Username, string Pass)
        {
            string sql = "SELECT * FROM dbo.TaiKhoan WHERE ID='" + Username + "' AND MatKhau='" + Pass + "'";
            SqlConnection con = new SqlConnection(KetNoi.connect());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }



        // rieng
        public bool TCTPM(string MaPM, string MaSach, DateTime NgayMuon, DateTime HanTra, string Ghichu)
        {
            bool b = false;
            string sql = string.Format("Insert into dbo.CHITIETPHIEUMUON (MaPM, MaSach, NgayMuon, HanTra, GhiChu) values ( @MaPM, @MaSach, @NgayMuon, @HanTra, @GhiChu )");
            SqlParameter[] arr = new SqlParameter[5];
            arr[0] = new SqlParameter("@MaPM", SqlDbType.NVarChar, 10);
            arr[0].Value = MaPM;
            arr[1] = new SqlParameter("@MaSach", SqlDbType.NVarChar, 10);
            arr[1].Value = MaSach;
            arr[2] = new SqlParameter("@NgayMuon", SqlDbType.Date);
            arr[2].Value = NgayMuon;
            arr[3] = new SqlParameter("@HanTra", SqlDbType.Date);
            arr[3].Value = HanTra;
            arr[4] = new SqlParameter("@GhiChu", SqlDbType.NVarChar, 500);
            arr[4].Value = Ghichu;

            b = dbcon.executeInsertQuery(sql, arr);
            return b;
        }
    }
}
