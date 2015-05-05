using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoCaoDTDTO
    {
        private int id;
        private string ngay;
        private int soBenhNhan;
        private double doanhThu;
        private double tyLe;

        public int getID()
        {
            return id;
        }
        public void setID(int i)
        {
            id = i;
        }
        public string getNgay()
        {
            return ngay;
        }
        public void setNgay(string n)
        {
            ngay = n;
        }
        public int getSoBenhNhan()
        {
            return soBenhNhan;
        }
        public void setSoBenhNhan(int s)
        {
            soBenhNhan = s;
        }
        public double getDoanhThu()
        {
            return doanhThu;
        }
        public void setDoanhThu(double d)
        {
            doanhThu = d;
        }
        public double getTyLe()
        {
            return tyLe;
        }
        public void setTyLe(double t)
        {
            tyLe = t;
        }
    }
}
