using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
   public class khachhangBLL
    {
        khachhangDAL khDAL = new khachhangDAL();
        public DataTable hienthikhachhang()
        {
            return khDAL.hienthikhachhang();
        }
        public bool them_khachhang(string tenKhachHang, DateTime ngaySinh, bool gioiTinh, string chungMinhNhanDan, string diaChi, string soDienThoai, string quocTich)
        {
            return khDAL.them_khachhang(tenKhachHang, ngaySinh, gioiTinh, chungMinhNhanDan, diaChi, soDienThoai, quocTich);
        }
         public void xoa_khachhang(int maKhachHang)
        {
            khDAL.xoa_nhanvien(maKhachHang);

        }

        public void sua_khachhang(string tenKhachHang, DateTime ngaySinh, bool gioiTinh, string chungMinhNhanDan, string diaChi, string soDienThoai, string quocTich,int maKhachHang)
        {

            khDAL.sua_khachhang(tenKhachHang, ngaySinh, gioiTinh, chungMinhNhanDan, diaChi, soDienThoai, quocTich, maKhachHang);
        }
    }
}
