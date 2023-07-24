using SqlInjection.DTO;
using SqlInjection.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Razor.Generator;
using static System.Collections.Specialized.BitVector32;

namespace SqlInjection.Controllers
{
    public class HomeController : Controller
    {
        AuthenticationService authService = new AuthenticationService();
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            bool login = authService.login(username, password);
            if(login)
            {
                Session["user"] = username;
                return Redirect("home/GetUserList");
            }
            else return Redirect("home/loginfail");
        }

        [HttpGet]
        public ActionResult GetUserList()
        {
            if(Session["user"] != null)
            {
                List<User> users = authService.getAllUser();
                return View(users);
            }
            else
            {
                return Redirect("login");
            }
        }

        [HttpGet]
        public ActionResult LoginFail()
        {
            return View();
        }
    }
}