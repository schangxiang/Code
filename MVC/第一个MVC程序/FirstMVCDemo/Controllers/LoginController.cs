using FirstMVCDemo.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCDemo.Controllers
{
    /*
     * 因为在请求登陆界面及进行登陆时Session还为空，所以不能对其应用LoginAttribute，否则会造成循环调用，这时我们定义的IsCheck变量就派上用场了。
     */
    [LoginFilterAttribute(IsCheck = false)]
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string username, string password)
        {
            /*
            using (LastChanceContext lastChance = new LastChanceContext())
            {
                IList<Sys_User> userList = lastChance.Sys_User.Where(a => a.LoginName == username).ToList();
                if (userList.Count < 1)
                {
                    return Json(new { state = "error", message = "用户名或密码错误！" });
                }
                else if (userList[0].IsDelete == 1)
                {
                    return Json(new { state = "error", message = "该用户已被禁用！" });
                }
                else if (userList[0].Password != password)
                {
                    return Json(new { state = "error", message = "用户名或密码错误！" });
                }
                Session["UserId"] = userList[0].UserId;
                Session["LoginName"] = userList[0].LoginName;
                Session["RealName"] = userList[0].RealName;
                return Json(new { state = "success", message = "" });
            }
            //*/
            return null;
        }
    }
}