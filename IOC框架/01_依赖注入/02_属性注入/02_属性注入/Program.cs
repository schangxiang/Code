using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_属性注入
{
    class Program
    {
        static void Main(string[] args)
        {
            UnityContainer container = new UnityContainer();

            container.RegisterType<IUserService, UserService>();
            container.RegisterType<IUserDao, UserDao>();

            IUserService userService= container.Resolve<UserService>();

            userService.MyDisplay("邵长祥");

            Console.ReadKey();
        }
    }
}
