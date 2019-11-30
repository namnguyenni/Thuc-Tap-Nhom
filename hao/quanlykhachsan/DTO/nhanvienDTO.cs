using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class nhanvienDTO
    {
        private int _maNhanVien;
        private string _hoTen;
        private bool _gioiTinh;
        private DateTime _ngaySinh;
        private string _soChungMinh;
        private string _diaChi;
        private string _soDienThoai;
        private DateTime _ngayVaoLam;

        public int maNhanVien
        {
            get { return _maNhanVien; }
            set { _maNhanVien = value; }
        }
        public string hoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }
        public bool gioiTinh
        {
            get { return _gioiTinh; }
            set { _gioiTinh = value; }
        }
        public DateTime ngaySinh
        {
            get { return _ngaySinh; }
            set { _ngaySinh = value; }
        }
        public string soChungMinh
        {
            get { return _soChungMinh; }
            set { _soChungMinh = value; }
        }
        public string diaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
        public string soDienThoai
        {
            get { return _soDienThoai; }
            set { _soDienThoai = value; }
        }
        public DateTime ngayVaoLam
        {
            get { return ngayVaoLam; }
            set { _ngayVaoLam = value; }
        }
    }
}
