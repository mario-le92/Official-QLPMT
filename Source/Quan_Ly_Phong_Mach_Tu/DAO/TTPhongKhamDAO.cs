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
    public class TTPhongKhamDAO : ODBConnector
    {
        public TTPhongKhamDTO getTTPK()
        {
            TTPhongKhamDTO ttpk = new TTPhongKhamDTO();
            OleDbConnection connection = openConnection();

            string sql = "SELECT So_Luong_Kham, Phi_Kham_Benh from Thong_tin_phong_kham where ID=1";
            OleDbCommand command = new OleDbCommand(sql, connection);
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ttpk.setSoLuong(int.Parse(reader.GetInt32(0).ToString()));
                ttpk.setTienKham(float.Parse(reader.GetDouble(1).ToString()));
            }
            reader.Close();

            return ttpk;
        }

        public bool doiTTPK(TTPhongKhamDTO ttpk)
        {
            OleDbConnection connection = openConnection();

            string sql = "UPDATE Thong_tin_phong_kham set So_Luong_Kham = @SL, Phi_Kham_Benh = @TK where ID=1";
            OleDbCommand command = new OleDbCommand(sql, connection);
            OleDbParameter para = command.Parameters.Add("@SL", OleDbType.Numeric);
            para.Value = ttpk.getSoLuong();
            para = command.Parameters.Add("@TK", OleDbType.Double);
            para.Value = ttpk.getTienKham();

            int count = command.ExecuteNonQuery();
            connection.Close();

            return count > 1;
        }
    }
}
