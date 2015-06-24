using System.Data;
using System.Collections.Generic;
using System.Linq;

using DAO;
using DTO;

namespace BUS
{
    public class DanhSachBenhNhanBUS
    {
        //get
        public DataTable danh_sach_benh_nhan()
        {
            return (new DanhSachBenhNhanDAO()).danh_sach_benh_nhan();
        }

        public DataTable danh_sach_loai_benh()
        {
            var data = (new DanhSachBenhNhanDAO()).danh_sach_loai_benh();

            var row = data.NewRow();

            row["id"] = "-1";
            row["ten"] = "<tất cả>";

            data.Rows.InsertAt(row, 0);

            return data;
        }

        public DataTable tim_kiem_benh_nhan(DanhSachBenhNhanDTO d)
        {
            string count = "";

            //////////////////////////////////////////////////////////////////
            if (d.ma_so != -1)
            {
                count += "1";
            }

            if (!string.IsNullOrEmpty(d.ho_ten))
            {
                count += "2";
            }

            if (!(d.ngay_kham == ""))
            {
                count += "3";
            }

            if (d.loai_benh != -1)
            {
                count += "4";
            }
            //////////////////////////////////////////////////////////////////
            //1,2,3,4. 1 -> 2 -> 12
            //12,13,14,23,24,34
            //123,124,134,234
            //1234


            switch (count.Length)
            {
                //1234. 1 -> 2 -> 12 -> case '2'
                case 1:
                    switch (count[0])
                    {
                        case '2':
                            return tim_kiem_benh_nhan_ho_ten(d.ho_ten);
                        case '3':
                            return tim_kiem_benh_nhan_ngay_kham(d.ngay_kham);
                        case '4':                            
                            return tim_kiem_benh_nhan_loai_benh(d.loai_benh.ToString());                          
                    }
                    break;

                //12,13,14,23,24,34
                //12 -> 2, 13 -> 123, 14 -> 124 are exceptions.
                case 2:
                    switch (count)
                    {
                        case "12":
                            return tim_kiem_benh_nhan_ho_ten(d.ho_ten); //result in case '2'.

                        case "23":
                            return tim_kiem_benh_nhan_ho_ten_ngay_kham(d.ho_ten, d.ngay_kham);

                        case "24":
                            return tim_kiem_benh_nhan_ho_ten_loai_benh(
                                d.ho_ten, d.loai_benh.ToString());

                        case "34":
                            return tim_kiem_benh_nhan_loai_benh_ngay_kham(
                                d.loai_benh.ToString(), d.ngay_kham);
                    }
                    break;

                //123,124,134,234
                //123 -> 23, 124 -> 24, 134 -> 1234 are exceptions
                case 3:
                    switch (count)
                    {
                        case "123":
                            return tim_kiem_benh_nhan_ho_ten_ngay_kham(d.ho_ten, d.ngay_kham);

                        case "124":
                            return tim_kiem_benh_nhan_ho_ten_loai_benh(
                                d.ho_ten, d.loai_benh.ToString());

                        case "234": //xxxx
                            return tim_kiem_benh_nhan_ho_ten_ngay_kham_loai_benh(
                                d.ho_ten, d.ngay_kham, d.loai_benh.ToString());
                    }
                    break;

                case 0:
                    return danh_sach_benh_nhan();

                default:
                    return tim_kiem_benh_nhan(d);
            }

            return (new DanhSachBenhNhanDAO()).tim_kiem_benh_nhan(d);
        }

        public DataTable tim_kiem_benh_nhan_ho_ten_ngay_kham_loai_benh(string s1, string s2, string s3)
        {
            return (new DanhSachBenhNhanDAO()).tim_kiem_benh_nhan_ho_ten_ngay_kham_loai_benh
                (s1, s2, s3);
        }

        public DataTable tim_kiem_benh_nhan_ngay_kham(string s)
        {
            return (new DanhSachBenhNhanDAO()).tim_kiem_benh_nhan_ngay_kham(s);
        }

        public DataTable tim_kiem_benh_nhan_loai_benh(string s)
        {
            return (new DanhSachBenhNhanDAO()).tim_kiem_benh_nhan_loai_benh(s);
        }

        public DataTable tim_kiem_benh_nhan_ho_ten(string s)
        {
            return (new DanhSachBenhNhanDAO()).tim_kiem_benh_nhan_ho_ten(s);
        }

        public DataTable tim_kiem_benh_nhan_ho_ten_loai_benh(string s1, string s2)
        {
            return (new DanhSachBenhNhanDAO())
                .tim_kiem_benh_nhan_ho_ten_loai_benh(s1, s2);
        }

        public DataTable tim_kiem_benh_nhan_ho_ten_ngay_kham(string s1, string s2)
        {
            return (new DanhSachBenhNhanDAO())
                .tim_kiem_benh_nhan_ho_ten_ngay_kham(s1, s2);
        }

        public DataTable tim_kiem_benh_nhan_loai_benh_ngay_kham(string s1, string s2)
        {
            return (new DanhSachBenhNhanDAO())
                .tim_kiem_benh_nhan_loai_benh_ngay_kham(s1, s2);
        }

        public List<string> ho_ten_hint(string s)
        {
            var aaa = (new DanhSachBenhNhanDAO()).ho_ten_hint(s).AsEnumerable()
                .Select(o => o.Field<string>("ho_ten"))
                .ToList();

            return aaa;
        }

        public List<string> ma_so_hint(string s)
        {
            return (new DanhSachBenhNhanDAO()).ma_so_hint(s).AsEnumerable()
                .Select(o => o.Field<int>(0))
                .ToList<int>().ConvertAll(o => o.ToString());
        }

        public string t_utility1(string s)
        {
            return (new DanhSachBenhNhanDAO()).utility1(s).ToString();
        }

    }
}
