using Microsoft.Practices.Unity;
using System;

namespace _04_Unity在MVC中引用
{
    class UserService : IUserService
    {
        //只需要在对象成员前面加上[Dependency]，
        //就是把构造函数去掉，成员对象上面加[Dependency]注入
        //注意：这里使用的Unity版本是4.0.1，最新版本[Dependency]会报错 
        [Dependency]
        public IUserDao IUserDao { get; set; }

        /*
        //对象成员增加了[Dependency]，就不需要这个构造函数了
        public UserService(IUserDao UserDao)
        {
            this.IUserDao = UserDao;
        }
        //*/

        public string MyDisplay(string msg)
        {
            return ("Service输出Dao的内容:" + IUserDao.Display(msg));
        }
    }
}
