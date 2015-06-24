using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.OleDb;

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

        public DataTable DanhsachKham()
        {
            DataProvider dp = new DataProvider();

            OleDbParameter[] para = new OleDbParameter[1];

            para[0] = new OleDbParameter();
            para[0].ParameterName = "ngay";
            para[0].OleDbType = OleDbType.Date;
            para[0].Value = DateTime.Now.Date;

            DataTable bn = dp.SqlExcuteQuery("LayDanhSachkham", para);

            return bn;
        }

        //Luu tru mot benh nhan xuong csdl
        public bool LuuBenhNhan(BenhNhan bn)
        {
            OleDbParameter[] para = new OleDbParameter[4];

            para[0] = new OleDbParameter();
            para[0].ParameterName = "hoten";
            para[0].OleDbType = OleDbType.VarChar;
            para[0].Value = bn.HoTen;

            para[1] = new OleDbParameter();
            para[1].ParameterName = "gioitinh";
            para[1].OleDbType = OleDbType.VarChar;
            para[1].Value = bn.GioiTinh;

            para[2] = new OleDbParameter();
            para[2].ParameterName = "namsinh";
            para[2].OleDbType = OleDbType.Date;
            para[2].Value = bn.NamSinh;

            para[3] = new OleDbParameter();
            para[3].ParameterName = "diachi";
            para[3].OleDbType = OleDbType.VarChar;
            para[3].Value = bn.DiaChi;

            DataProvider dp = new DataProvider();
            return dp.SqlExcuteNonQuery("ThemBN", para);
        }

        public DataTable TimBenhNhanID(int id)
        {
            DataProvider dp = new DataProvider();

            OleDbParameter[] para = new OleDbParameter[1];

            para[0] = new OleDbParameter();
            para[0].ParameterName = "id";
            para[0].OleDbType = OleDbType.Integer;
            para[0].Value = id;

            DataTable bn = dp.SqlExcuteQuery("TimBenhNhanID", para);

            return bn;
        }

        public DataTable TimBenhNhanName(string name)
        {
            DataProvider dp = new DataProvider();

            OleDbParameter[] para = new OleDbParameter[1];

            para[0] = new OleDbParameter();
            para[0].ParameterName = "hoten";
            para[0].OleDbType = OleDbType.VarChar;
            para[0].Value = name;

            DataTable bn = dp.SqlExcuteQuery("find", para);

            return bn;
        }

        public bool LuuVaKham(BenhNhan bn)
        {
            bool TF = LuuBenhNhan(bn);
            int ma = -1;
            ma = LayID();
            bool TF2 = DKKham(ma);
            if (TF || TF2 || ma != -1)
            {
                return true;
            }
            return false;
        }

        public bool DKKham(int ma)
        {
            OleDbParameter[] para = new OleDbParameter[2];

            para[0] = new OleDbParameter();
            para[0].ParameterName = "mabn";
            para[0].OleDbType = OleDbType.Integer;
            para[0].Value = ma;

            para[1] = new OleDbParameter();
            para[1].ParameterName = "ngay";
            para[1].OleDbType = OleDbType.VarChar;
            para[1].Value = DateTime.Now.Date;
            DataProvider dp = new DataProvider();
            return dp.SqlExcuteNonQuery("luuvaodskham", para);
        }

        public int LayID()
        {
            DataProvider dp = new DataProvider();
            DataTable bn = dp.SqlExcuteQuery("getlastid", null);
            return (int)bn.Rows[0][0];
        }

        public bool Xoa_DK_Kham(int id)
        {
            OleDbParameter[] para = new OleDbParameter[1];

            para[0] = new OleDbParameter();
            para[0].ParameterName = "id";
            para[0].OleDbType = OleDbType.Integer;
            para[0].Value = id;

            DataProvider dp = new DataProvider();
            return dp.SqlExcuteNonQuery("Delete_DK_kham", para);
        }

        public bool TimBNCu(BenhNhan bn)
        {
            OleDbParameter[] para = new OleDbParameter[3];

            para[0] = new OleDbParameter();
            para[0].ParameterName = "hoten";
            para[0].OleDbType = OleDbType.VarChar;
            para[0].Value = bn.HoTen;

            para[1] = new OleDbParameter();
            para[1].ParameterName = "gioitinh";
            para[1].OleDbType = OleDbType.VarChar;
            para[1].Value = bn.GioiTinh;

            para[2] = new OleDbParameter();
            para[2].ParameterName = "namsinh";
            para[2].OleDbType = OleDbType.Date;
            para[2].Value = bn.NamSinh;

            DataProvider dp = new DataProvider();

            DataTable dt = dp.SqlExcuteQuery("Qr_TimBN_Cu", para);
            if (dt.Rows.Count > 0)
            {
                DKKham((int)dt.Rows[0][0]);
                return true;
            }
            return false;
        }
    }
}
