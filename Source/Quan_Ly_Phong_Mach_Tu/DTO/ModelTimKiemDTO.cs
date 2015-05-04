using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ModelTimKiemDTO
    {
        public string so_thu_tu { get; set; }
        public string ma_benh_nhan { get; set; }
        public string ho_ten { get; set; }
        public string loai_benh { get; set; }
        public string ngay_kham { get; set; }
        public string trieu_chung { get; set; }

        public ModelTimKiemDTO() { }
        public ModelTimKiemDTO(string a, string b, string c, string d, string e)
        {
            so_thu_tu = a;
            ho_ten = b;
            loai_benh = c;
            ngay_kham = d;
            trieu_chung = e;
        }

        public ModelTimKiemDTO(ModelTimKiemDTO a)
        {
            so_thu_tu = a.so_thu_tu;
            ho_ten = a.ho_ten;
            loai_benh = a.loai_benh;
            ngay_kham = a.ngay_kham;
            trieu_chung = a.trieu_chung;
        }
    }
}
