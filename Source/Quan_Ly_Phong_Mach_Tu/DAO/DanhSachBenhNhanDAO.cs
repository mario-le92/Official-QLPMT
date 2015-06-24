using DTO;
using System.Data;
using System.Data.OleDb;

namespace DAO
{
    public class DanhSachBenhNhanDAO
    {
        //get
        public DataTable danh_sach_benh_nhan()
        {
            return new DataProvider().SqlExcuteQuery("t_danh_sach_benh_nhan");
        }

        public object utility1(string s)
        {
            return new DataProvider().SqlExcuteScalar("t_utility1", new OleDbParameter()
            {
                ParameterName = "@p1",
                OleDbType = OleDbType.Numeric,
                Value = s
            });
        }

        public DataTable danh_sach_loai_benh()
        {
            return new DataProvider().SqlExcuteQuery("t_danh_sach_loai_benh");
        }

        public DataTable ma_so_hint(string s)
        {
            return new DataProvider().SqlExcuteQuery("t_ma_so_hint", new OleDbParameter()
            {
                ParameterName = "@p1",
                OleDbType = OleDbType.Numeric,
                Value = s
            });
        }

        public DataTable ho_ten_hint(string s)
        {
            return new DataProvider().SqlExcuteQuery("t_ho_ten_hint", new OleDbParameter()
            {
                ParameterName = "@p1",
                OleDbType = OleDbType.VarChar,
                Value = s
            });
        }

        public DataTable tim_kiem_benh_nhan(DanhSachBenhNhanDTO d)
        {
            return new DataProvider().SqlExcuteQuery("t_tim_kiem_benh_nhan_classical", new OleDbParameter[]
            {
                new OleDbParameter()
                {
                    ParameterName = "@p1", //ma so
                    OleDbType = OleDbType.Numeric,
                    Value = d.ma_so
                },
                new OleDbParameter()
                {
                    ParameterName = "@p2", //ho ten
                    OleDbType = OleDbType.VarChar,
                    Value = d.ho_ten
                },
                new OleDbParameter()
                {
                    ParameterName = "@p3", //ngay kham
                    OleDbType = OleDbType.Date,
                    Value =  d.ngay_kham
                },
                new OleDbParameter()
                {
                    ParameterName = "@p4", //loai benh
                    OleDbType = OleDbType.Numeric,
                    Value = d.loai_benh
                }
            });
        }

        public DataTable tim_kiem_benh_nhan_ngay_kham(string s)
        {
            return new DataProvider().SqlExcuteQuery(
                "t_tim_kiem_benh_nhan_classical_ngay_kham", new OleDbParameter()
            {
                ParameterName = "@p1",
                OleDbType = OleDbType.Date,
                Value = s
            });
        }

        public DataTable tim_kiem_benh_nhan_loai_benh(string s)
        {
            return new DataProvider().SqlExcuteQuery(
                "t_tim_kiem_benh_nhan_classical_loai_benh", new OleDbParameter()
                {
                    ParameterName = "@p1",
                    OleDbType = OleDbType.Numeric,
                    Value = s
                });
        }

        public DataTable tim_kiem_benh_nhan_ho_ten(string s)
        {
            var aaa = new DataProvider().SqlExcuteQuery(
                "t_tim_kiem_benh_nhan_classical_ho_ten", new OleDbParameter()
                {
                    ParameterName = "@p1",
                    OleDbType = OleDbType.VarChar,
                    Value = s
                });

            return aaa;
        }

        public DataTable tim_kiem_benh_nhan_ho_ten_ngay_kham(string s1, string s2)
        {
            //2 params.
            return new DataProvider().SqlExcuteQuery(
                "t_tim_kiem_benh_nhan_classical_ho_ten_ngay_kham", new OleDbParameter[]
                {
                    new OleDbParameter()
                    {
                        ParameterName = "@p1",
                        OleDbType = OleDbType.VarChar,
                        Value = s1
                    },
                    new OleDbParameter()
                    {
                        ParameterName = "@p2",
                        OleDbType = OleDbType.Date,
                        Value = s2
                    }
                });
        }

        public DataTable tim_kiem_benh_nhan_ho_ten_loai_benh(string s1, string s2)
        {
            //2 params.
            return new DataProvider().SqlExcuteQuery(
                "t_tim_kiem_benh_nhan_classical_ho_ten_loai_benh", new OleDbParameter[]
                {
                    new OleDbParameter()
                    {
                        ParameterName = "@p1",
                        OleDbType = OleDbType.VarChar,
                        Value = s1
                    },
                    new OleDbParameter()
                    {
                        ParameterName = "@p2",
                        OleDbType = OleDbType.Numeric,
                        Value = s2
                    }
                });
        }

        public DataTable tim_kiem_benh_nhan_loai_benh_ngay_kham(string s1, string s2)
        {
            //2 params.
            return new DataProvider().SqlExcuteQuery(
                "t_tim_kiem_benh_nhan_classical_loai_benh_ngay_kham", new OleDbParameter[]
                {
                    new OleDbParameter()
                    {
                        ParameterName = "@p1",
                        OleDbType = OleDbType.Numeric,
                        Value = s1
                    },
                    new OleDbParameter()
                    {
                        ParameterName = "@p2",
                        OleDbType = OleDbType.Date,
                        Value = s2
                    }
                });
        }

        //t_tim_kiem_benh_nhan_classical_ho_ten_ngay_kham_loai_benh
        public DataTable tim_kiem_benh_nhan_ho_ten_ngay_kham_loai_benh(string s1, string s2, string s3)
        {
            //2 params.
            return new DataProvider().SqlExcuteQuery(
                "t_tim_kiem_benh_nhan_classical_ho_ten_ngay_kham_loai_benh", new OleDbParameter[]
                {
                    new OleDbParameter()
                    {
                        ParameterName = "@p1",
                        OleDbType = OleDbType.VarChar,
                        Value = s1
                    },
                    new OleDbParameter()
                    {
                        ParameterName = "@p2",
                        OleDbType = OleDbType.Date,
                        Value = s2
                    },
                    new OleDbParameter()
                    {
                        ParameterName = "@p3",
                        OleDbType = OleDbType.Numeric,
                        Value = s3
                    }
                });
        }
    }
}