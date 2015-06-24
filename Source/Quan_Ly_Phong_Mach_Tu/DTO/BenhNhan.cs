using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BenhNhan
    {
        private int id;
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

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

        private string giotinh;
        public string GioiTinh
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
                return namsinh.Date;
            }
            set
            {
                namsinh = value.Date;
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
