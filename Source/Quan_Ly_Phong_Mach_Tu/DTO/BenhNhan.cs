using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BenhNhan
    {
        private string hoten;
        public string HoTen
        {
            get 
            {
                return hoten;
            }
            set 
            {
                hoten = value;
            }
        }

        private bool giotinh;
        public bool GioiTinh
        {
            get
            {
                return giotinh;
            }
            set
            {
                giotinh = value;
            }
        }

        private DateTime namsinh;
        public DateTime NamSinh
        {
            get 
            {
                return namsinh;
            }
            set
            {
                namsinh = value;
            }
        }

        private string diachi;
        public string DiaChi
        {
            get
            {
                return diachi;
            }
            set
            {
                diachi = value;
            }
        }
    }
}
