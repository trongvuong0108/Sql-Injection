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
            var connectionString = "workstation id=SqlInjection.mssql.somee.com;packet size=4096;user id=trong01082001_SQLLogin_1;pwd=aqytzz25vf;data source=SqlInjection.mssql.somee.com;persist security info=False;initial catalog=SqlInjection";
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