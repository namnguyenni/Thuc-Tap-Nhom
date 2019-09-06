using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBJ
{
    public class NhanVien_OBJ
    {
        string _MaNV;

        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
        string _HoDem;

        public string HoDem
        {
            get { return _HoDem; }
            set { _HoDem = value; }
        }
        string _TenNV;

        public string TenNV
        {
            get { return _TenNV; }
            set { _TenNV = value; }
        }
        DateTime _NS;

        public DateTime NS
        {
            get { return _NS; }
            set { _NS = value; }
        }
        string _GT;

        public string GT
        {
            get { return _GT; }
            set { _GT = value; }
        }
        long _Luong;

        public long Luong
        {
            get { return _Luong; }
            set { _Luong = value; }
        }
        string _DiaChi;

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        string _MaNQL;

        public string MaNQL
        {
            get { return _MaNQL; }
            set { _MaNQL = value; }
        }
    }
}
