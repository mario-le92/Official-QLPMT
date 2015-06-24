using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class TinhTrangBUS
    {
        TinhTrangDAO TinhTrang = new TinhTrangDAO();
        public DataTable LoadDSTinhTrang()
        {
            DataTable dt = new DataTable();
            dt = TinhTrang.LoadDSTinhTrang();
            return dt;
        }
    }
}
