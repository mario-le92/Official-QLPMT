using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ThongTinDAO
    {
        public DataTable LayThongTin()
        {
            DataProvider dp = new DataProvider();
            DataTable thongtin = dp.SqlExcuteQuery("Thongtin", null);

            return thongtin;
        }

        public int SL_DKKham()
        {
            DataProvider dp = new DataProvider();

            OleDbParameter[] para = new OleDbParameter[1];

            para[0] = new OleDbParameter();
            para[0].ParameterName = "ngay";
            para[0].OleDbType = OleDbType.Date;
            para[0].Value = DateTime.Now.Date; ;

            DataTable bn = dp.SqlExcuteQuery("soluongdk", para);
            if (bn.Rows.Count > 0)
            {
                return (int)bn.Rows[0][0];
            } 
            else
            {
                return 0;
            } 
        }

        public bool updateTT(int sl, int dgia)
        {
            DataProvider dp = new DataProvider();

            OleDbParameter[] para = new OleDbParameter[2];

            para[0] = new OleDbParameter();
            para[0].ParameterName = "sl";
            para[0].OleDbType = OleDbType.Integer;
            para[0].Value = sl;

            para[1] = new OleDbParameter();
            para[1].ParameterName = "dgia";
            para[1].OleDbType = OleDbType.Integer;
            para[1].Value = dgia;

            return dp.SqlExcuteNonQuery("Qr_SuaThongTin", para);
            
        }
    }
}
