using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class Benh_NhanBUS
    {
        BenhNhanDAO ds = new BenhNhanDAO(); 
        public DataTable DanhsachBN()
        {    
            return ds.DanhsachBN();
        }

        public DataTable DanhsachKham()
        {
            return ds.DanhsachKham();
        }

        public bool LuuBenhNhan(BenhNhan bn)
        {
            return ds.LuuBenhNhan(bn);
        }

        public DataTable TimBenhNhanID(int id)
        {
            return ds.TimBenhNhanID(id);
        }

        public DataTable TimBenhNhanName(string name)
        {
            return ds.TimBenhNhanName(name);
        }

        public bool LuuVaKham(BenhNhan bn)
        {
            return ds.LuuVaKham(bn);
        }

        public bool Xoa_DK_Kham(int id)
        {
            return ds.Xoa_DK_Kham(id);
        }

        public bool TimBNCu(BenhNhan bn)
        {
            return ds.TimBNCu(bn);
        }
    }
}
