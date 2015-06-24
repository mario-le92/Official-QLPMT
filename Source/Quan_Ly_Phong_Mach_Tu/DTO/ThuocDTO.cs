using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
    public class ThuocDTO
    {
        private int _Mathuoc;
        public int MaThuoc
        {
            get { return _Mathuoc; }
            set { _Mathuoc = value; }
        }
        
        private string  _Tenthuoc;
        public string  Tenthuoc
        {
            get { return _Tenthuoc; }
            set { _Tenthuoc = value; }
        }
       
        private int _Soluong;
        public int Soluong
        {
            get { return _Soluong; }
            set { _Soluong = value; }
        }
        private int _Donvitinh;
        public int Donvitinh
        {
            get { return _Donvitinh; }
            set { _Donvitinh = value; }
        }
        private int _Dongia;

        public int Dongia
        {
            get { return _Dongia; }
            set { _Dongia = value; }
        }
        private int _Xoa;

        public int Xoa
        {
            get { return _Xoa; }
            set { _Xoa = value; }
        }        
    }
}
