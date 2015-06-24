using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhamBenhBUS
    {
        KhamBenhDAO dao = new KhamBenhDAO();
        public DataTable DSBenh()
        {
            return dao.DSBenh();
        }

        public DataTable DSCachDung(int id)
        {
            return dao.DSCachDung(id);
        }

        public DataTable DSThuoc()
        {
            return dao.DSThuoc();
        }

        public int TienKham()
        {
            return dao.TienKham();
        }

        public bool TaoToa()
        {
            return dao.TaoToa();
        }

        public bool LuuChiTietToa(DataTable toa)
        {
            return dao.LuuChiTietToa(toa);
        }

        public bool HoaDon(int idbn, int idbenh, string trchung)
        {
            return dao.HoaDon(idbn, idbenh, trchung);
        }

        public bool DaKham(int idkh)
        {
            return dao.DaKham(idkh);
        }
    }
}
