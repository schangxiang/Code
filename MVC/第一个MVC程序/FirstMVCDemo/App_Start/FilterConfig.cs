using FirstMVCDemo.Attribute;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCDemo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //注册全局过滤器
            filters.Add(new LoginFilterAttribute() { IsCheck = true });
        }
    }
}
