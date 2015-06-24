using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;

namespace BUS
{
    public class ThongTinBUS
    {
        ThongTinDAO dao = new ThongTinDAO();
        public DataTable LayThongTin()
        {
            return dao.LayThongTin();
        }

        public int SL_DKKham()
        {
            return dao.SL_DKKham();
        }

        public bool updateTT(int sl, int dgia)
        {
            return dao.updateTT(sl, dgia);
        }
    }
}
