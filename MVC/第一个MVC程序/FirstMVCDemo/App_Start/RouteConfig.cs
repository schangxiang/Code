using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FirstMVCDemo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}"); // 可以忽略的路由配置
            // 设置默认路由
            routes.MapRoute(
                name: "Default",// 路由名称
                url: "{controller}/{action}/{id}",// 带有参数的 URL
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional } //参数默认值
            );
        }
    }
}
