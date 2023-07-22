using SqlInjection.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SqlInjection.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var authService = new AuthenticationService();
            authService.login(" ' or ' '='", " ' or ' '='");
            return View();
        }
    }
}