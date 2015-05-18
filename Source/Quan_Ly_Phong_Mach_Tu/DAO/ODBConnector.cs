using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace DAO
{
    public class ODBConnector
    {
        public static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"DB PMT.mdb\"";
        OleDbConnection mOleDbConnection;
        public OleDbConnection openConnection()
        {
            mOleDbConnection = new OleDbConnection(connectionString);
            mOleDbConnection.Open();
            return mOleDbConnection;
        }
    }
}
