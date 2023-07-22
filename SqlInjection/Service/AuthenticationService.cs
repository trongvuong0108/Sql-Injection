using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SqlInjection.Service
{
    public class AuthenticationService
    {
        public Database database { get; set; }

        public Boolean login (string username, string password)
        {
            database = new Database ();
            var query = @"select * from [SqlInjection].[dbo].[user] where username = '" + username + "' and password = '" + password + "'";
            var data = database.excute(query);
            Console.WriteLine(data);
            return true;
        }
    }
}