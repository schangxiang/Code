using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace _01_实现构造注入
{
    /*
     * 构造器注入
        构造器注入（Constructor Injection）：IoC容器会智能地选择选择和调用适合的构造函数以创建依赖的对象。
        如果被选择的构造函数具有相应的参数，IoC容器在调用构造函数之前解析注册的依赖关系并自行获得相应参数对象。
        RegisterType：可以看做是自来水厂决定用什么作为水源，可以是水库或是地下水，我只要“注册”开关一下就行了。
        Resolve：可以看做是自来水厂要输送水的对象，可以是农村或是城市，我只要“控制”输出就行了。 
     */
    class Program
    {
        static void Main(string[] args)
        {
            //创建容器
            UnityContainer container = new UnityContainer();

            //注册依赖对象
            container.RegisterType<IUserService, UserService>();
            container.RegisterType<IUserDao, UserDao>();

            //返回调用者对象
            IUserService _IUserService = container.Resolve<UserService>();

            //执行
            _IUserService.MyDisplay("邵长祥");

            Console.ReadKey();
        }
    }
}
