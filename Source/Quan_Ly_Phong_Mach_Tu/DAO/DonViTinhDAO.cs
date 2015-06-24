using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class DonViTinhDAO
    {
        public DataTable LoadDSDonViTinh()
        {
            string procname = "LoadDanhSachDonViTinh";
            DataProvider dp = new DataProvider();
            List<OleDbParameter> parameters = new List<OleDbParameter>();
            DataTable dt = new DataTable();
            dt = dp.SqlExcuteQuery(procname, parameters.ToArray());
            dp.CloseConnect();
            return dt;
        }
        public void ThemDonViTinh(DonViTinhDTO dvt)
        {
            string procname = "ThemDonViTinh";
            DataProvider dp = new DataProvider();
            List<OleDbParameter> parameters = new List<OleDbParameter>();
            parameters.Add(new OleDbParameter("Ten", dvt.Ten_don_vi));
            dp.SqlExcuteNonQuery(procname, parameters.ToArray());
        }
        public void CapNhatDonViTinh(DonViTinhDTO dvt)
        {
            string procname = "CapNhatDonViTinh";
            DataProvider dp = new DataProvider();
            List<OleDbParameter> parameters = new List<OleDbParameter>();
            parameters.Add(new OleDbParameter("ID", dvt.Ma_don_vi));
            parameters.Add(new OleDbParameter("Ten", dvt.Ten_don_vi));
            dp.SqlExcuteNonQuery(procname, parameters.ToArray());
        }
        public DataTable TimDonViTinh(DonViTinhDTO dvt)
        {
            string procname = "TimDonViTinh";
            DataProvider dp = new DataProvider();
            List<OleDbParameter> parameters = new List<OleDbParameter>();
            parameters.Add(new OleDbParameter("Ten", dvt.Ten_don_vi));
            DataTable dt = new DataTable();
            dt = dp.SqlExcuteQuery(procname, parameters.ToArray());
            dp.CloseConnect(); 
            return dt;
        }
        //KiemTraTonTai
        public DataTable KiemTraTonTai(string TenDonVi)
        {
            string procname = "KiemTraDonViTonTai";
            DataProvider dp = new DataProvider();
            List<OleDbParameter> parameters = new List<OleDbParameter>();
            parameters.Add(new OleDbParameter("Ten", TenDonVi));
            DataTable dt = new DataTable();
            dt = dp.SqlExcuteQuery(procname, parameters.ToArray());
            dp.CloseConnect();
            return dt;
        }
    }
}
