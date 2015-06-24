using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;
using System.Collections;

namespace BUS
{
    public class DonViTinhBUS
    {
        DonViTinhDAO DonViTinh = new DonViTinhDAO();
        public DataTable LoadDSDonViTinh()
        {
            DataTable dt = new DataTable();
            dt = DonViTinh.LoadDSDonViTinh();
            return dt;
        }
        public DataTable LoadDSTenDonViTinh()
        {
            DataTable ds = new DataTable();
            ds = DonViTinh.LoadDSDonViTinh();
            return ds;
        }
        public bool ThemDonViTinh(DonViTinhDTO dvt)
        {
            DonViTinh.ThemDonViTinh(dvt);
            return true;
        }
        public bool CapNhatDonViTinh(DonViTinhDTO dvt)
        {
            DonViTinh.CapNhatDonViTinh(dvt);
            return true;
        }
        public DataTable TimDonViTinh(DonViTinhDTO dvt)
        {
            DataTable dt = new DataTable();
            dt = DonViTinh.TimDonViTinh(dvt);
            return dt;
        }
        public DataTable KiemTraTonTai(string TenDonVi)
        {
            DataTable dt = new DataTable();
            dt = DonViTinh.KiemTraTonTai(TenDonVi);
            return dt;
        }
    }
}
