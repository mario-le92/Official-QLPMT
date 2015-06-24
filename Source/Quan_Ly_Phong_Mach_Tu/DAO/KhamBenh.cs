using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace DAO
{
    public class KhamBenhDAO
    {
        public DataTable DSBenh()
        {
            DataProvider dt = new DataProvider();

            DataTable ds = new DataTable();

            ds = dt.SqlExcuteQuery("Qr_DS_Benh", null);

            return ds;
        }

        public DataTable DSCachDung(int id)
        {
            DataProvider dt = new DataProvider();

            DataTable ds = new DataTable();

            OleDbParameter[] para = new OleDbParameter[1];

            para[0] = new OleDbParameter();
            para[0].ParameterName = "id";
            para[0].OleDbType = OleDbType.Integer;
            para[0].Value = id;


            ds = dt.SqlExcuteQuery("Qr_Cach_dung", para);

            return ds;
        }

        public DataTable DSThuoc()
        {
            DataProvider dt = new DataProvider();

            DataTable ds = new DataTable();

            ds = dt.SqlExcuteQuery("Qr_DS_thuoc", null);

            return ds;
        }

        public int TienKham()
        {
            DataProvider dp = new DataProvider();
            DataTable bn = dp.SqlExcuteQuery("Qr_PhiKham", null);
            return (int)bn.Rows[0][0];
        }

        public int IDLayToa()
        {
            DataProvider dp = new DataProvider();
            DataTable bn = dp.SqlExcuteQuery("Qr_LayIDToa", null);
            return (int)bn.Rows[0][0];
        }

        public bool TaoToa()
        {
            int idtoa = 1 + IDLayToa();

            DataProvider dt = new DataProvider();

            OleDbParameter[] para = new OleDbParameter[1];

            para[0] = new OleDbParameter();
            para[0].ParameterName = "matoa";
            para[0].OleDbType = OleDbType.Integer;
            para[0].Value = idtoa;

            bool TF = dt.SqlExcuteNonQuery("Qr_ThemToa", para);

            return TF;
        }

        public bool LuuChiTietToa(DataTable toa)
        {
            DataProvider dt = new DataProvider();
            OleDbParameter[] para = new OleDbParameter[4];

            int idtoa = IDLayToa();
            if (toa.Rows.Count == 0) 
                return false;
            try
            {
                for (int i = 0; i < toa.Rows.Count; i++)
                {
                    para[0] = new OleDbParameter();
                    para[0].ParameterName = "toa";
                    para[0].OleDbType = OleDbType.Integer;
                    para[0].Value = idtoa;

                    para[1] = new OleDbParameter();
                    para[1].ParameterName = "thuoc";
                    para[1].OleDbType = OleDbType.Integer;
                    para[1].Value = int.Parse(toa.Rows[i][6].ToString());

                    para[2] = new OleDbParameter();
                    para[2].ParameterName = "sl";
                    para[2].OleDbType = OleDbType.Integer;
                    para[2].Value = int.Parse(toa.Rows[i][3].ToString());

                    para[3] = new OleDbParameter();
                    para[3].ParameterName = "dgia";
                    para[3].OleDbType = OleDbType.Integer;
                    para[3].Value = int.Parse(toa.Rows[i][5].ToString());

                    dt.SqlExcuteNonQuery("Qr_ChietTietToa", para);
                }
            }
            catch (System.Exception ex)
            {
                ex.GetBaseException();
                return false;
            }

            return true;
        }

        public bool HoaDon(int idbn, int idbenh, string trchung)
        {
            int idtoa = IDLayToa();
            int tienkham = TienKham();
            DataProvider dt = new DataProvider();

            OleDbParameter[] para = new OleDbParameter[6];

            para[0] = new OleDbParameter();
            para[0].ParameterName = "idbn";
            para[0].OleDbType = OleDbType.Integer;
            para[0].Value = idbn;

            para[1] = new OleDbParameter();
            para[1].ParameterName = "idtoa";
            para[1].OleDbType = OleDbType.Integer;
            para[1].Value = idtoa;

            para[2] = new OleDbParameter();
            para[2].ParameterName = "idbenh";
            para[2].OleDbType = OleDbType.Integer;
            para[2].Value = idbenh;

            para[3] = new OleDbParameter();
            para[3].ParameterName = "ngaykh";
            para[3].OleDbType = OleDbType.Date;
            para[3].Value = DateTime.Now.Date;

            para[4] = new OleDbParameter();
            para[4].ParameterName = "trchung";
            para[4].OleDbType = OleDbType.VarWChar;
            para[4].Value = trchung;

            para[5] = new OleDbParameter();
            para[5].ParameterName = "tienkh";
            para[5].OleDbType = OleDbType.Integer;
            para[5].Value = tienkham;

            try
            {
                dt.SqlExcuteNonQuery("Qr_HoaDon", para);
            }
            catch (System.Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
            return true;
        }

        public bool DaKham(int idkh)
        {
            DataProvider dt = new DataProvider();

            OleDbParameter[] para = new OleDbParameter[1];

            para[0] = new OleDbParameter();
            para[0].ParameterName = "id";
            para[0].OleDbType = OleDbType.Integer;
            para[0].Value = idkh;

            bool TF = dt.SqlExcuteNonQuery("Qr_DaKham", para);

            return TF;
        }
    }
}
