using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TinhTrangDAO
    {
        public DataTable LoadDSTinhTrang()
        {
            string procname = "LoadDanhSachTinhTrang";
            DataProvider dp = new DataProvider();
            List<OleDbParameter> parameters = new List<OleDbParameter>();
            DataTable dt = new DataTable();
            dt = dp.SqlExcuteQuery(procname, parameters.ToArray());
            dp.CloseConnect();
            return dt;
        }
    }
}
