using SqlInjection.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SqlInjection.Service
{
    public class AuthenticationService
    {
        public Database database = new Database();

        public Boolean login (string username, string password)
        {
            var query = @"select * from [SqlInjection].[dbo].[user] where"+
                            " username = '" + username + 
                            "' and password = '" + password + "'";
            var data = database.excute(query);
            if(data.Rows.Count > 0) // nếu kết quả query trả về nhiều hơn 1 dòng thì login thành công
                return true;
            else return false;
        }

        public List<User> getAllUser()
        {
            var query = @"select * from [SqlInjection].[dbo].[user]";
            var data = database.excute(query);
            List<User> users = new List<User>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                User user = new User();
                user.Id = Convert.ToInt32(data.Rows[i]["id"]);
                user.username = data.Rows[i]["username"].ToString();
                user.password = data.Rows[i]["password"].ToString();
                users.Add(user);
            }
            return users;
        }
    }
}