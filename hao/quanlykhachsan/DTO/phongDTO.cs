using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class phongDTO
    {
        private float _donGia;
        private string _maPhong;
        private bool _tinhTrang;
        private string _loaiPhong;


        public string maPhong
        {
            get { return _maPhong; }
            set { _maPhong = value; }
        }
        public bool tinhTrang
        {
            get { return _tinhTrang; }
            set { _tinhTrang = value; }
        }
        public string loaiPhong
        {
            get { return _loaiPhong; }
            set { _loaiPhong = value; }
        }
        public float donGia
        {
            get { return _donGia; }
            set { _donGia = value; }
        }
    }
}
