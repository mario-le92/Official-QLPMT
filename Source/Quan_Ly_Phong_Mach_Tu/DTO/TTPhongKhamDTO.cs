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
        public int SoLuong 
        {
            get 
            {
                return soLuong;
            }
            set
            {
                soLuong = value;
            }
        }

        private float tienKham;
        public float TienKham 
        { 
            get
            {
                return tienKham;
            } 
            set
            {
                tienKham = value;
            } 
        }

        public TTPhongKhamDTO()
        {
            soLuong = 30;
            tienKham = 30000;
        }
    }
}
