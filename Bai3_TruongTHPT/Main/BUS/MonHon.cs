﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BUS
{
    public class MonHon
    {
        public DataTable Show()
        {
            string sql = @"SELECT * FROM dbo.MonHoc";
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(ConnectDB.getconnect());
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            conn.Close();
            da.Dispose();
            return dt;
        }

        public void ThemMonHoc( string tenMonHoc)
        {
            string sqlCommand = "AddMonHoc";
            SqlConnection conn = new SqlConnection(ConnectDB.getconnect());

            conn.Open();

            SqlCommand cmd = new SqlCommand(sqlCommand, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@TenMon", tenMonHoc);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }



        // Sua MH
        public void Sua_MH(string MaMH, string TenMH, string GT, string Mon)
        {
            string sql = "Sua_MH";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaMH", MaMH);
          
            cmd.Parameters.AddWithValue("@GT", GT);
            cmd.Parameters.AddWithValue("@MaMon", Mon);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        //Xoa
        public void Xoa_MH(string MaMH)
        {
            string sql = "Xoa_MH";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaMH", MaMH);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}
