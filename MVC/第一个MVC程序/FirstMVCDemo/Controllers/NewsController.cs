using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCDemo.Controllers
{
    public class NewsController : Controller
    {
        //
        // GET: /News/
        public ActionResult Index()
        {
            ViewData["message"] = "你好啊，长祥";
            ViewBag.message = "你是鬼吗";
            return View();
        }
    }
}