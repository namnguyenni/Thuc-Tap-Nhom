﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Main
{
    public class HocSinh
    {
        string strcon = @"Data Source=HOA_LONG\SQLEXPRESS; Initial Catalog=TruongTHPT; Integrated Security=true;";
        public DataTable Show()
        {
            string sql = "select hs.MaHS, hs.HovaTen, hs.GT,  hs.NgaySinh, hs.DiaChi,  hs.PhuHuynh, lop.TenLop from tblHocSinh hs, tblLop lop where hs.MaLop = lop.MaLop";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            da.Dispose();
            return dt;
        }

        //Sủa 
        public void Sua_HS(string MaHS, string HoTen, string GT, string NgaySinh, string DiaChi, string PhuHuynh, string MaLop)
        {
            string sql = "Sua_HS";
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@HovaTen", HoTen);
            cmd.Parameters.AddWithValue("@GT", GT);
            cmd.Parameters.AddWithValue("@NgaySinh",DateTime.Parse(NgaySinh));
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@PhuHuynh", PhuHuynh);
            cmd.Parameters.AddWithValue("@MaLop", MaLop);
            cmd.Parameters.AddWithValue("@MaHS", MaHS);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void ThemHocSinh(string HovaTen, string GT, DateTime NgaySinh, string DiaChi, string PhuHuynh, string MaLop)
        {
            string sql = "ADD_HocSinh";
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@HovaTen", HovaTen);
            cmd.Parameters.AddWithValue("@GT", GT);
            cmd.Parameters.AddWithValue("@NgaySinh", (NgaySinh));
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@PhuHuynh", PhuHuynh);
            cmd.Parameters.AddWithValue("@MaLop", MaLop);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        // Xóa
        public void Xoa_HS(string MaHS)
        {
            string sql = "Xoa_HS";
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHS", MaHS);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public DataTable LayThongTinLop()
        {
            string sql = "SELECT * FROM tblLop";
            SqlConnection con = new SqlConnection(strcon);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }
    }
}
