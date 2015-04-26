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
        public DataTable DanhsachBN()
        {
            BenhNhanDAO ds = new BenhNhanDAO(); 
            return ds.DanhsachBN();
        }

        public DataTable DanhsachKham()
        {
            BenhNhanDAO ds = new BenhNhanDAO();
            return ds.DanhsachKham();
        }

        public bool LuuBenhNhan(BenhNhan bn)
        {
            BenhNhanDAO ds = new BenhNhanDAO();
            return ds.LuuBenhNhan(bn);
        }

        public DataTable TimBenhNhanID(int id)
        {
            BenhNhanDAO ds = new BenhNhanDAO();
            return ds.TimBenhNhanID(id);
        }

        public DataTable TimBenhNhanName(string name)
        {
            BenhNhanDAO ds = new BenhNhanDAO();
            return ds.TimBenhNhanName(name);
        }

        public bool LuuVaKham(BenhNhan bn)
        {
            BenhNhanDAO ds = new BenhNhanDAO();
            return ds.LuuVaKham(bn);
        }

    }
}
