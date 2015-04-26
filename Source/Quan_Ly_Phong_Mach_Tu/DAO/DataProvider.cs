using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace DAO
{
    public class DataProvider
    {
        //Khai báo biến 
        private string _strConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"DB PMT.mdb\"";
        private OleDbConnection _connection; 
        private string _error = ""; 
 
        //Khai báo property 
        public string Error  
        { 
            get { return _error; } 
            private set { _error = value; } 
        } 
 
        //Mở kết nối đến CSDL 
        public bool OpenConnect() 
        { 
            try 
            { 
                if (_connection == null) 
                    _connection = new OleDbConnection(_strConnectionString); 
 
                if(_connection.State == ConnectionState.Open) 
                    _connection.Close(); 
 
                _connection.Open(); 
 
                return true; 
            } 
            catch (OleDbException ex) 
            { 
                Error = ex.Message; 
            } 
 
            return false; 
        } 
 
        //Đóng kết nối 
        public bool CloseConnect() 
        { 
            try 
            { 
                if (_connection != null) 
                    if (_connection.State == ConnectionState.Open) 
                        _connection.Close(); 
                return true; 
            } 
            catch (Exception ex) 
            { 
                Error = ex.Message; 
                return false; 
            } 
        } 
          
        /// <summary>
        /// Thực thi truy vấn với các lệnh insert, update, delete 
        /// </summary>
        /// <param name="procName">Tên của Procedure</param>
        /// <param name="oledbParameters">Danh sách các tham số, không có là null</param>
        /// <returns>Thành công trả về True, xảy ra lỗi trả vè false</returns>
        public bool SqlExcuteNonQuery(string procName, params OleDbParameter[] oledbParameters) 
        { 
            try 
            { 
                if(OpenConnect()) 
                { 
                    OleDbCommand OleCommand = _connection.CreateCommand(); 
                    OleCommand.CommandType = CommandType.StoredProcedure; 
                    OleCommand.CommandText = procName; 
 
                    if(oledbParameters!=null) 
                        OleCommand.Parameters.AddRange(oledbParameters); 
 
                    OleCommand.ExecuteNonQuery(); 
 
                    Error = ""; 
 
                    return true;    
                } 
 
                return false; 
            }
            catch (OleDbException ex) 
            { 
                _error = ex.Message; 
 
                return false; 
            } 
            finally 
            { 
                CloseConnect(); 
            } 
             
        } 
 
        /// <summary>
        /// Thực thi truy vấn với lệnh Select, trả về 1 bảng dữ liệu
        /// </summary>
        /// <param name="procName">Tên của Procedure</param>
        /// <param name="oledbParameters">Danh sách các tham số, không có là null</param>
        /// <returns>Thành công trả về True, xảy ra lỗi trả vè false</returns>
        public DataTable SqlExcuteQuery(string procName, params OleDbParameter[] oledbParameters) 
        { 
            DataTable dt = null; 
            try 
            { 
                if (OpenConnect()) 
                { 
                    OleDbCommand OleCommand = _connection.CreateCommand(); 
                    OleCommand.CommandType = CommandType.StoredProcedure; 
                    OleCommand.CommandText = procName; 
                    if(oledbParameters!=null) 
                        OleCommand.Parameters.AddRange(oledbParameters); 
         
                    var dbadapter = new OleDbDataAdapter(OleCommand); 
                    dt = new DataTable(); 
                    dbadapter.Fill(dt); 
 
                    Error = ""; 
                } 
            }
            catch (OleDbException ex) 
            { 
                Error = ex.Message; 
            } 
            finally 
            { 
                CloseConnect(); 
            } 
 
            return dt; 
        } 
 
         /// <summary>
        /// Trả về 1 giá trị đầu tiên 
        /// </summary>
        /// <param name="procName">Tên của Procedure</param>
        /// <param name="oledbParameters">Danh sách các tham số, không có là null</param>
        /// <returns>Kiểu trả về object</returns>
        public object SqlExcuteScalar(string procName, params OleDbParameter[] oledbParameters)  
        { 
            object value = null; 
            try 
            { 
                if (OpenConnect()) 
                { 
                    var OleCommand = _connection.CreateCommand(); 
                    OleCommand.CommandType = CommandType.StoredProcedure; 
                    OleCommand.CommandText = procName; 
   
                    if (oledbParameters != null) 
                        OleCommand.Parameters.AddRange(oledbParameters); 
 
                    value = OleCommand.ExecuteScalar(); 
 
                    Error = ""; 
                } 
            }
            catch (OleDbException ex) 
            { 
                Error = ex.Message; 
            } 
            finally 
            { 
                CloseConnect(); 
            } 
 
            return value; 
        } 
    }
}
