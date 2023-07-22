using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SqlInjection.Service
{
    public class Database
    { 
        SqlConnection _connection { set; get; }
        SqlDataAdapter _adapter { set; get; }
        DataSet _dataSet { set; get; }
        public Database()
        {
            var connectionString = "Data Source=localhost;Initial Catalog=SqlInjection;User ID=sa; PwD=Password@1234";
            _connection = new SqlConnection(connectionString);
            _connection.Open();
        }


        public DataTable excute(string query)
        {
            _adapter = new SqlDataAdapter(query, _connection);
            _dataSet = new DataSet();
            _adapter.Fill(_dataSet);
            return _dataSet.Tables[0];
        }
    }
}