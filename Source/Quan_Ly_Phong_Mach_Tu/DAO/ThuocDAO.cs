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
    public class ThuocDAO
    {
        public DataTable LoadDSThuoc()
        {
            string procname = "LoadDanhSachThuoc";
            DataProvider dp = new DataProvider();
            List<OleDbParameter> parameters = new List<OleDbParameter>();
            DataTable dt = new DataTable();
            dt = dp.SqlExcuteQuery(procname, parameters.ToArray());
            dp.CloseConnect();
            return dt;
        }
        public DataTable LoadDSDonViTinh()
        {
            string procname = "LayDSTenDonViTinh";
            DataProvider dp = new DataProvider();
            List<OleDbParameter> parameters = new List<OleDbParameter>();
            DataTable dt = new DataTable();
            dt = dp.SqlExcuteQuery(procname, parameters.ToArray());
            dp.CloseConnect();
            return dt;
        }
        public DataTable LoadDSLoaiThuoc()
        {
            string procname = "LayDSTenLoaiThuoc";
            DataProvider dp = new DataProvider();
            List<OleDbParameter> parameters = new List<OleDbParameter>();
            DataTable dt = new DataTable();
            dt = dp.SqlExcuteQuery(procname, parameters.ToArray());
            dp.CloseConnect();
            return dt;
        }
        public void ThemThuoc(ThuocDTO t)
        {
            string procname = "ThemThuoc";
            DataProvider dp = new DataProvider();
            List<OleDbParameter> parameters = new List<OleDbParameter>();
            parameters.Add(new OleDbParameter("Ten_thuoc", t.Tenthuoc));
            parameters.Add(new OleDbParameter("So_luong", t.Soluong));
            parameters.Add(new OleDbParameter("Don_gia", t.Dongia));
            parameters.Add(new OleDbParameter("Id_Don_vi_tinh", t.Donvitinh));
            parameters.Add(new OleDbParameter("Xoa", t.Xoa));
            dp.SqlExcuteNonQuery(procname, parameters.ToArray());
        }
        public void CapNhatThuoc(ThuocDTO t)
        {
            string procname = "CapNhatThuoc";
            DataProvider dp = new DataProvider();
            List<OleDbParameter> parameters = new List<OleDbParameter>();
            parameters.Add(new OleDbParameter("ID", t.MaThuoc));
            parameters.Add(new OleDbParameter("Ten_thuoc", t.Tenthuoc));
            parameters.Add(new OleDbParameter("So_luong", t.Soluong));
            parameters.Add(new OleDbParameter("Don_gia", t.Dongia));
            parameters.Add(new OleDbParameter("Id_Don_vi_tinh", t.Donvitinh));
            parameters.Add(new OleDbParameter("Xoa", t.Xoa));
            dp.SqlExcuteNonQuery(procname, parameters.ToArray());
        }

        public void PhucHoiThuoc(ThuocDTO t)
        {
            string procname = "PhucHoiThuoc";
            DataProvider dp = new DataProvider();
            List<OleDbParameter> parameters = new List<OleDbParameter>();
            parameters.Add(new OleDbParameter("Ten_thuoc", t.Tenthuoc));
            dp.SqlExcuteNonQuery(procname, parameters.ToArray());
        }
        public void XoaThuoc(ThuocDTO t)
        {
            string procname = "XoaThuoc";
            DataProvider dp = new DataProvider();
            List<OleDbParameter> parameters = new List<OleDbParameter>();
            parameters.Add(new OleDbParameter("ID", t.MaThuoc));
            dp.SqlExcuteNonQuery(procname, parameters.ToArray());
        }
        public DataTable TimThuoc1(ThuocDTO t)
        {
            DataTable dt = new DataTable();
            string procname = "TimThuoc";
            DataProvider dp = new DataProvider();
            List<OleDbParameter> parameters = new List<OleDbParameter>();
            parameters.Add(new OleDbParameter("Ten_thuoc", t.Tenthuoc));
            dt = dp.SqlExcuteQuery(procname, parameters.ToArray());
            return dt;
        }
        public DataTable TimThuoc(ThuocDTO t)
        {
            DataTable dt = new DataTable();
            DataProvider dp = new DataProvider();
            OleDbConnection cn = new OleDbConnection(dp._strConnectionString);
            cn.Open();

            OleDbCommand cmd = new OleDbCommand("TimThuoc", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Ten_thuoc", System.Data.OleDb.OleDbType.VarChar).Value = t.Tenthuoc;
            //string sql = "SELECT t.ID, t.Ten_thuoc, t.So_luong, t.Don_gia, dvt.Ten, tt.Ten_tinh_trang FROM Thuoc AS t, Don_vi_tinh AS dvt, Tinh_trang AS tt WHERE t.Ten_thuoc LIKE '%"+t.Tenthuoc+"%' AND ((t.ID_don_vi_tinh)=[dvt].[ID]) AND ((tt.ID) = (t.Xoa))";
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable KiemTraThuocTonTai(string TenThuoc)
        {
            string procname = "KiemTraThuocTonTai";
            DataProvider dp = new DataProvider();
            List<OleDbParameter> parameters = new List<OleDbParameter>();
            parameters.Add(new OleDbParameter("Ten_thuoc", TenThuoc));
            DataTable dt = new DataTable();
            dt = dp.SqlExcuteQuery(procname, parameters.ToArray());
            dp.CloseConnect();
            return dt;
        }
        public DataTable KiemTraThuocTonTai_Xoa(string TenThuoc)
        {
            string procname = "KiemTraThuocTonTai_Xoa";
            DataProvider dp = new DataProvider();
            List<OleDbParameter> parameters = new List<OleDbParameter>();
            parameters.Add(new OleDbParameter("Ten_thuoc", TenThuoc));
            DataTable dt = new DataTable();
            dt = dp.SqlExcuteQuery(procname, parameters.ToArray());
            dp.CloseConnect();
            return dt;
        }
    }
}
