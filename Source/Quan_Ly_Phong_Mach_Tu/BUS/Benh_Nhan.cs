using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
    public class Benh_Nhan
    {
        public DataTable DanhsachBN()
        {
            DAO.BenhNhanDAO ds = new DAO.BenhNhanDAO(); 
            return ds.DanhsachBN();
        }
    }
}
