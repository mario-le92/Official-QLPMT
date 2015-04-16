using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TTPhongKhamDTO
    {
        private int soLuong;
        private float tienKham;

        public TTPhongKhamDTO()
        {
            soLuong = 30;
            tienKham = 30000;
        }
        public int getSoLuong()
        {
            return soLuong;
        }

        public void setSoLuong(int soluong)
        {
            soLuong = soluong;
        }

        public float getTienKham()
        {
            return tienKham;
        }

        public void setTienKham(float tienkham)
        {
            tienKham = tienkham;
        }
    }
}
