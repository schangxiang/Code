/*
 * CLR Version：4.0.30319.42000
 * NameSpace：FirstMVCDemo.Attribute
 * FileName：LoginAttribute
 * CurrentYear：2019
 * CurrentTime：2019/6/7 9:45:25
 * Author：shaocx
 *
 * <更新记录>
 * ver 1.0.0.0   2019/6/7 9:45:25 新規作成 (by shaocx)
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCDemo.Attribute
{
    /// <summary>
    /// 登录过滤器
    /// </summary>
    public class LoginFilterAttribute : System.Web.Mvc.ActionFilterAttribute
    {
        /// <summary>
        /// 表示是否检查登录
        /// </summary>
        public bool IsCheck { get; set; }


        //Action方法执行之前执行此方法
        public override void OnActionExecuting(System.Web.Mvc.ActionExecutingContext filterContext)
        {
            if (IsCheck)
            {
                if (this.HasLogin(filterContext))
                {
                    base.OnActionExecuting(filterContext);
                }
                else
                {
                    //仅有这句话跳转时登陆界面会显示在iframe框架中
                    filterContext.HttpContext.Response.Redirect("/Login/Index");
                }
            }
            else
            {
                base.OnActionExecuting(filterContext);
            }
        }

        /// <summary>
        /// 验证是否登录
        /// </summary>
        /// <param name="filterContext"></param>
        /// <returns></returns>
        private bool HasLogin(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Session["UserId"] != null)
            {
                return true;
            }
            return false;
        }


    }
}