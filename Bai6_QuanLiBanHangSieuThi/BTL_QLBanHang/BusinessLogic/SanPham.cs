using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entity;

namespace BusinessLogic
{
    public class SanPham
    {
        KetNoiDB db = new KetNoiDB();
        public DataTable ShowSanPham(string DieuKien)
        {
            string sql = @"SELECT MaSP, TenSP, SoLuong, LoiNhuan, GiaNhap, GiaBan, MoTa, NSX, TenLH
                                                    FROM SANPHAM sp, LOAIHANG lh
                                                    WHERE sp.MaLH = lh.MaLH " + DieuKien;
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }
        public string LayAnh(string _MaSP)
        {
            string sql = @"SELECT HinhAnh FROM SANPHAM WHERE MaSP = '" + _MaSP + "'";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            string anh = dt.Rows[0].ItemArray[0].ToString();
            if (anh != null) return anh;
            return "loi";
        }
        public string InsertSanPham(EC_SANPHAM sp)
        {
            string sql = "ThemSP";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tensp", sp.TenSP);
            cmd.Parameters.AddWithValue("@malh", sp.MaLH);
            cmd.Parameters.AddWithValue("@soluong", sp.SoLuong);
            cmd.Parameters.AddWithValue("@loinhuan", sp.LoiNhuan);
            cmd.Parameters.AddWithValue("@gianhap", sp.GiaNhap);
            cmd.Parameters.AddWithValue("@mota", sp.MoTa);
            cmd.Parameters.AddWithValue("@nsx",sp.NSX);
            cmd.Parameters.AddWithValue("@hinhanh", sp.HinhAnh);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            string i = dt.Rows[0].ItemArray[0].ToString();
            cmd.Dispose();
            con.Close();
            return i;
        }
        public void UpdateSanPham(EC_SANPHAM sp)
        {
            string sql = "SuaSP";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", sp.MaSP);
            cmd.Parameters.AddWithValue("@tensp", sp.TenSP);
            cmd.Parameters.AddWithValue("@malh", sp.MaLH);
            cmd.Parameters.AddWithValue("@soluong", sp.SoLuong);
            cmd.Parameters.AddWithValue("@loinhuan", sp.LoiNhuan);
            cmd.Parameters.AddWithValue("@gianhap", sp.GiaNhap);
            cmd.Parameters.AddWithValue("@mota", sp.MoTa);
            cmd.Parameters.AddWithValue("@nsx", sp.NSX);
            cmd.Parameters.AddWithValue("@hinhanh", sp.HinhAnh);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
        public void UpdateSoLuong(EC_SANPHAM  sp)
        {
            string sql = "SuaSL";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", sp.MaSP);
            cmd.Parameters.AddWithValue("@sl", sp.SoLuong);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public void UpdateSoLuong(string MaSP, int SoLuong)
        {
            string sql = "SuaSL";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", MaSP);
            cmd.Parameters.AddWithValue("@sl", SoLuong);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public void UpdateSoLuongSauBan(string MaSP, int SoLuong)
        {
            string sql = "UpdateSLBan";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", MaSP);
            cmd.Parameters.AddWithValue("@sl", SoLuong);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void DeleteSanPham(EC_SANPHAM sp)
        {
            string sql = "XoaSP";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", sp.MaSP);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public DataTable HienThiSP_LH()
        {
            DataTable dt = new DataTable();
            string str = @"SELECT     dbo.SANPHAM.MaSP, dbo.SANPHAM.TenSP, dbo.LOAIHANG.TenLH, dbo.SANPHAM.NSX, 
                                      dbo.SANPHAM.GiaBan AS GiaBan, dbo.SANPHAM.SoLuong, dbo.SANPHAM.HinhAnh
                            FROM  dbo.SANPHAM INNER JOIN dbo.LOAIHANG ON dbo.SANPHAM.MaLH = dbo.LOAIHANG.MaLH";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            da.Fill(dt);
            con.Close();

            return dt;
        }
        public DataTable LaySP(string _MaSP)
        {
            DataTable dt = new DataTable();
            string str = @"SELECT * FROM SANPHAM WHERE MaSP = " + _MaSP;
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(str, con);
            ad.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable LaySPMax()
        {
            DataTable dt = new DataTable();
            string str = @"ShowSPBanChayNhat";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public void SuaSP(string _MaSP, int _SoLg)
        {
            string str = @"UPDATE SANPHAM SET SoLuong = " + _SoLg + " WHERE MaSP = N'" + _MaSP + "'";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public DataTable SearchTenSP(string _str)
        {
            DataTable dt = new DataTable();
            string sql = "SearchTenSP";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@str", _str);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            con.Close();
            cmd.Dispose();
            return dt;

        }
        public DataTable SearchNSX(string _str)
        {
            DataTable dt = new DataTable();
            string sql = "SearchTenNSX";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@str", _str);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            con.Close();
            cmd.Dispose();
            return dt;

        }

        public DataTable SearchTenLH(string _str)
        {
            DataTable dt = new DataTable();
            string sql = "SearchTenLH";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@str", _str);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            con.Close();
            cmd.Dispose();
            return dt;
        }
        public DataTable ThongKeSPN(DateTime _NgayDau, DateTime _NgayCuoi)
        {
            string sql = "ThongKeSPB";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ngaydau", _NgayDau);
            cmd.Parameters.AddWithValue("@ngaycuoi", _NgayCuoi);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ThongKeTop10(DateTime _NgayDau, DateTime _NgayCuoi)
        {
            string sql = "ThongKeTop10";
            SqlConnection con = new SqlConnection(KetNoiDB.getconnect());
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ngaydau", _NgayDau);
            cmd.Parameters.AddWithValue("@ngaycuoi", _NgayCuoi);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
