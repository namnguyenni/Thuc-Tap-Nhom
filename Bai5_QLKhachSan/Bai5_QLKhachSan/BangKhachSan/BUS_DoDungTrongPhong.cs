using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KetNoiDB;
using System.Data;
using System.Data.SqlClient;

namespace BangKhachSan
{
    public class BUS_DoDungTrongPhong
    {
        public DataTable ShowDoDung_Ma(string MaPhong)
        {
            string sql = string.Format(@"SELECT     dbo.DoDung.MaDD, dbo.DoDung.TenDD, dbo.tblDoDungTrongPhong.SoLuong, dbo.tblDoDungTrongPhong.DonViTinh, dbo.tblDoDungTrongPhong.TinhTrang, dbo.DoDung.GiaMua
                                        FROM         dbo.tblDoDungTrongPhong INNER JOIN
                                                     dbo.DoDung ON dbo.tblDoDungTrongPhong.MaDoDung = dbo.DoDung.MaDD INNER JOIN
                                                     dbo.tblPhong ON dbo.tblDoDungTrongPhong.MaPhong = dbo.tblPhong.MaPhong
                                        WHERE     (dbo.tblPhong.MaPhong = @MaPhong)");
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@MaPhong", MaPhong);
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
