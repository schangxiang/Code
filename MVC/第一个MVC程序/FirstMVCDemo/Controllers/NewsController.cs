using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCDemo.Controllers
{
    /*
     * 页面对象传值，有这三种对象可以传。
     * ViewBag ViewData 和TempData
     * （1）ViewBag和ViewData只在当前Action中有效，等同于View
     * （2）ViewData和ViewBag 中的值可以互相访问，因为ViewBag的实现中包含了ViewData
     * （3）TempData  保存在Session中，Controller每次执行请求的时候，会从Session中先获取 TempData，而后清除Session，
     * 获取完TempData数据，虽然保存在内部字典对象中，但是其集合中的每个条目访问一次后就从字典表中删 除。具体代码层面，TempData获取过程是通过SessionStateTempDataProvider.LoadTempData方法从 ControllerContext的Session中读取数据，而后清除Session，故TempData只能跨Controller传递一次。
     */
    public class NewsController : Controller
    {
        //
        // GET: /News/
        //控制器中的方法必须是public,如果是内部方法，将被设置为[NonActionAttribute]
        public ActionResult Index()
        {
            ViewData["message"] = "你好啊，长祥";//字典类型
            ViewBag.message = "你是鬼吗";// 动态类型

            return View(TempData["Message"]);//从Session中读取，只读取一次就删除
        }

        public ActionResult ShowMsg()
        {
            TempData["Message"] = "我是猪";
            return RedirectToAction("Index");
        }

        public ActionResult Home()
        {
            return View();//返回类型是ActionResult，其实这是个抽象类，实际返回的都是ActionResult的子类！！！！
        }
    }
}