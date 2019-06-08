using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _04_Unity在MVC中引用.Controllers
{
    public class HomeController : Controller
    {

        [Dependency]
        public IUserService UserService { get; set; }


        public ActionResult Index()
        {
            ViewBag.message = UserService.MyDisplay("邵长祥");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}