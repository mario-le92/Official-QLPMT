using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using DAO;
using DTO;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace BUS
{
    public class BaoCaoBUS
    {
        public ReportDocument getCRDoanhThu(string path, int tuThang, string tuNam, int toiThang, string toiNam)
        {
            int inam = int.Parse(toiNam);
            string sngay = "01";
            tuThang++;
            toiThang++;
            switch (toiThang)
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


            //****************************************************//
            ConnectionInfo crconnectioninfo = new ConnectionInfo();
            ReportDocument cryrpt = new ReportDocument();
            TableLogOnInfos crtablelogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtablelogoninfo = new TableLogOnInfo();

            Tables CrTables;

            crconnectioninfo.ServerName = path + "\\_DB PMT.mdb";
            crconnectioninfo.DatabaseName = path + "\\_DB PMT.mdb";
            crconnectioninfo.UserID = "";
            crconnectioninfo.Password = "";


            /*cryrpt.Load(path + "\\" + (new CRDoanhThu()).ResourceName);

            CrTables = cryrpt.Database.Tables;

            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtablelogoninfo = CrTable.LogOnInfo;
                crtablelogoninfo.ConnectionInfo = crconnectioninfo;
                CrTable.ApplyLogOnInfo(crtablelogoninfo);
            }


            cryrpt.RecordSelectionFormula = "{Hoa_Don.Ngay_kham} in DateTime (" + tuNam + ", " + tuThang.ToString() + ", 01, 0, 0, 0) to DateTime (" + toiNam + ", " + toiThang.ToString() + ", " + sngay + ", 0, 0, 0)";
            cryrpt.Refresh();*/

            //return cryrpt;
            //****************************************************//

            CRDoanhThu cr = new CRDoanhThu();

            CrTables = cr.Database.Tables;

            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtablelogoninfo = CrTable.LogOnInfo;
                crtablelogoninfo.ConnectionInfo = crconnectioninfo;
                CrTable.ApplyLogOnInfo(crtablelogoninfo);
            }

            cr.RecordSelectionFormula = "{Hoa_Don.Ngay_kham} in DateTime (" + tuNam + ", " + tuThang.ToString() + ", 01, 0, 0, 0) to DateTime (" + toiNam + ", " + toiThang.ToString() + ", " + sngay + ", 0, 0, 0)";
            return cr;
        }
        public CRSuDungThuoc getCRSuDungThuoc(string path, int tuThang, string tuNam, int toiThang, string toiNam)
        {
            int inam = int.Parse(toiNam);
            string sngay = "01";
            tuThang++;
            toiThang++;
            switch (toiThang)
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

            ConnectionInfo crconnectioninfo = new ConnectionInfo();
            ReportDocument cryrpt = new ReportDocument();
            TableLogOnInfos crtablelogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtablelogoninfo = new TableLogOnInfo();

            Tables CrTables;

            crconnectioninfo.ServerName = path + "\\_DB PMT.mdb";
            crconnectioninfo.DatabaseName = path + "\\_DB PMT.mdb";
            crconnectioninfo.UserID = "";
            crconnectioninfo.Password = "";

            CRSuDungThuoc cr = new CRSuDungThuoc();

            CrTables = cr.Database.Tables;

            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtablelogoninfo = CrTable.LogOnInfo;
                crtablelogoninfo.ConnectionInfo = crconnectioninfo;
                CrTable.ApplyLogOnInfo(crtablelogoninfo);
            }

            cr.RecordSelectionFormula = "{Hoa_Don.Ngay_kham} in DateTime (" + tuNam + ", " + tuThang.ToString() + ", 01, 0, 0, 0) to DateTime (" + toiNam + ", " + toiThang.ToString() + ", " + sngay + ", 0, 0, 0)";
            return cr;
        }

        public DataTable xx()
        {
            return (new BaoCaoDAO()).xx();
        }
    }
}
