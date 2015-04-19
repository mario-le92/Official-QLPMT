using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class BenhNhanDAO
    {
        public DataTable DanhsachBN()
        {
            DataProvider dp = new DataProvider();
            DataTable bn = dp.SqlExcuteQuery("TatCaBN", null);

            return bn;
        }
    }
}
