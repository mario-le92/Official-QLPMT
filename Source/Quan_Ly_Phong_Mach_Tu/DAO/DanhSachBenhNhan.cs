using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
using System.Data;

namespace DAO
{
    public class DanhSachBenhNhan
    {
        public DataTable ds_benh_nhan()
        {
            DataTable d = new DataTable();
            DataProvider dp = new DataProvider();

            d = dp.SqlExcuteQuery("ds_benh_nhan");
            return d;
        }

    }
}
