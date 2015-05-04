using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class TimKiemBUS
    {
        public List<ModelTimKiemDTO> lay_thong_tin_benh_nhan()
        {
            List<ModelTimKiemDTO> kq = new List<ModelTimKiemDTO>();

            DataTable ds = new DanhSachBenhNhan().ds_benh_nhan();

            int i = 0;
            foreach (DataRow dr in ds.Rows)
            {
                kq.Add(new ModelTimKiemDTO()
                {
                    so_thu_tu = i.ToString(),
                    ma_benh_nhan = dr["id"].ToString(),
                    ho_ten = dr["ho_ten"].ToString(),
                    ngay_kham = dr["ngay_kham"].ToString(),
                    loai_benh = dr["ten"].ToString(),
                    trieu_chung = dr["trieu_chung"].ToString()
                });
                i++;
            }


            //for (int i = 0; i < 100; i++)
            //{
            //    kq.Add(new ModelTimKiemDTO()
            //    {
            //        so_thu_tu = i.ToString(),
            //        ma_benh_nhan = i.ToString(),
            //        ho_ten = "nguyen van a" + i.ToString(),
            //        ngay_kham = "25/5/2015",
            //        loai_benh = "HIV" + i.ToString(),
            //        trieu_chung = "Ia chay loai " + i.ToString()
            //    });
            //}

            return kq;
        }
    }
}
