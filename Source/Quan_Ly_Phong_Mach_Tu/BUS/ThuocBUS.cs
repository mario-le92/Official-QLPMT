using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
   public class ThuocBUS
    {
       ThuocDAO Thuoc = new ThuocDAO();
       public DataTable LoadDSThuoc()
       {
           DataTable dt = new DataTable();
           dt = Thuoc.LoadDSThuoc();
           return dt;
       }
       public DataTable LoadDSDonViTinh()
       {
           DataTable dt = new DataTable();
           dt = Thuoc.LoadDSDonViTinh();
           return dt;
       }
       public DataTable LoadDSLoaiThuoc()
       {
           DataTable dt = new DataTable();
           dt = Thuoc.LoadDSLoaiThuoc();
           return dt;
       }
       public bool XoaThuoc(ThuocDTO t)
       {
           Thuoc.XoaThuoc(t);
           return true;
       }
       public bool ThemThuoc(ThuocDTO t)
       {
           Thuoc.ThemThuoc(t);
           return true;
       }
       public bool CapNhatThuoc(ThuocDTO t)
       {
           Thuoc.CapNhatThuoc(t);
           return true;
       }
       public bool PhucHoiThuoc(ThuocDTO t)
       {
           Thuoc.PhucHoiThuoc(t);
           return true;
       }
       public DataTable TimThuoc(ThuocDTO t)
       {
           DataTable dt = new DataTable();
           dt = Thuoc.TimThuoc(t);
           return dt;

       }
       public DataTable KiemTraThuocTonTai(string TenThuoc)
       {
           DataTable dt = new DataTable();
           dt = Thuoc.KiemTraThuocTonTai(TenThuoc);
           return dt;
       }
       public DataTable KiemTraThuocTonTai_Xoa(string TenThuoc)
       {
           DataTable dt = new DataTable();
           dt = Thuoc.KiemTraThuocTonTai_Xoa(TenThuoc);
           return dt;
       }
    }
}
