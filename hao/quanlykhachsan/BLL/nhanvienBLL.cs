using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class nhanvienBLL
    {
        nhanvienDAL nvDLL = new nhanvienDAL();
        public DataTable hienthinhanvien()
        {
            return nvDLL.hienthinhanvien();
        }
        public bool them_nhanvien(string hoTen, bool gioiTinh, DateTime ngaySinh, string soChungMinh, string diaChi, string soDienThoai, DateTime ngayVaoLam)
        {
            return nvDLL.them_nhanvien( hoTen,  gioiTinh,  ngaySinh,  soChungMinh,  diaChi,  soDienThoai, ngayVaoLam);
        }
        public void xoa_nhanvien(int maNhanVien)
        {
            nvDLL.xoa_nhanvien(maNhanVien);

        }

        public void sua_nhanvien(string hoTen, bool gioiTinh, DateTime ngaySinh, string soChungMinh, string diaChi, string soDienThoai, DateTime ngayVaoLam, int maNhanVien)
        {

            nvDLL.sua_nhanvien(hoTen, gioiTinh, ngaySinh, soChungMinh, diaChi, soDienThoai, ngayVaoLam, maNhanVien);
        }
    }
}

