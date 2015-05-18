using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BaoCaoBUS
    {
        public List<BaoCaoDTDTO> getBaoCaoDT(string thang, string nam)
        {
            BaoCaoDAO dao = new BaoCaoDAO();
            return dao.getBaoCaoDT(thang, nam);
        }

        public CRDoanhThu getCRDoanhThu(int thang, string nam)
        {
            int inam = int.Parse(nam);
            string sngay = "01";
            thang++;
            switch(thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    sngay = "31";
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    sngay = "30";
                    break;
                case 2:
                    sngay = (inam % 400 == 0 || (inam % 4 == 0 && inam % 100 != 0)) ? "29" : "28";
                    break;
            }
            CRDoanhThu cr = new CRDoanhThu();
            cr.RecordSelectionFormula = "{Hoa_Don.Ngay_kham} in DateTime (" + nam + ", " + thang.ToString() + ", 01, 0, 0, 0) to DateTime (" + nam + ", " + thang.ToString() + ", " + sngay + ", 0, 0, 0)";
            return cr;
        }
        public CRSuDungThuoc getCRSuDungThuoc(int thang, string nam)
        {
            int inam = int.Parse(nam);
            string sngay = "01";
            thang++;
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    sngay = "31";
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    sngay = "30";
                    break;
                case 2:
                    sngay = (inam % 400 == 0 || (inam % 4 == 0 && inam % 100 != 0)) ? "29" : "28";
                    break;
            }
            CRSuDungThuoc cr = new CRSuDungThuoc();
            cr.RecordSelectionFormula = "{Hoa_Don.Ngay_kham} in DateTime (" + nam + ", " + thang.ToString() + ", 01, 0, 0, 0) to DateTime (" + nam + ", " + thang.ToString() + ", " + sngay + ", 0, 0, 0)";
            return cr;
        }
    }
}
