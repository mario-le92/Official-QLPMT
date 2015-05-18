using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class BaoCaoDAO : ODBConnector
    {
        public List<BaoCaoDTDTO> getBaoCaoDT(string thang, string nam)
        {
            List<BaoCaoDTDTO> bcs = new List<BaoCaoDTDTO>();
            OleDbConnection connection = openConnection();

            string sql = "SELECT COUNT (Hoa_Don.ID), SUM (Thuoc.Don_gia * Thuoc_Cua_Toa.so_luong), Hoa_Don.Ngay_kham FROM Hoa_Don, Thuoc_Cua_Toa, Thuoc WHERE MONTH (Hoa_Don.Ngay_kham) = "+ thang +" AND YEAR (Hoa_Don.Ngay_kham) = "+ nam +" AND Hoa_Don.id_Toa_Thuoc = Thuoc_Cua_Toa.Id_toa AND Thuoc.ID = Thuoc_Cua_Toa.Id_thuoc GROUP BY Hoa_Don.Ngay_kham";
            //string sql = "SELECT SUM (Don_gia) FROM Thuoc GROUP BY ID";
            OleDbCommand command = new OleDbCommand(sql, connection);
            OleDbDataReader reader = command.ExecuteReader();
            int i = 1;
            while (reader.Read())
            {
                BaoCaoDTDTO bc = new BaoCaoDTDTO();
                bc.setID(i++);
                //bc.setSoBenhNhan(reader.GetInt32(0));
                bc.setDoanhThu(reader.GetDouble(1));
                bc.setNgay(reader.GetDateTime(2).ToShortDateString());
                bcs.Add(bc);
            }

            string sql2 = "SELECT COUNT (Hoa_Don.ID) FROM Hoa_Don WHERE MONTH (Hoa_Don.Ngay_kham) = "+ thang +" AND YEAR (Hoa_Don.Ngay_kham) = "+ nam +" Group by Hoa_Don.Ngay_kham";
            command = new OleDbCommand(sql2, connection);
            reader = command.ExecuteReader();
           
            for (int j = 0; j < bcs.Count(); j++)
            {
                if(reader.Read())
                    bcs[j].setSoBenhNhan(reader.GetInt32(0));
            }

            reader.Close();

            return bcs;
        }
    }
}
