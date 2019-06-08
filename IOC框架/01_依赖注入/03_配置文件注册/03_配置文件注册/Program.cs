using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Configuration;

namespace _03_配置文件注册
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 配置文件注册：
　　其实使用上面 RegisterType 方法进行注册，
  每次添加和删除一个注册都需要去修改代码和重新编译，这样不符合“高内聚、低耦合”的编程思想，
  所以我们可以采用配置文件的方式去注册，这样每次添加和修改注册就不需要去修改代码和重新发布了。
  配置文件注册用 UnityConfigurationSection 的 Configure加载配置文件注册。
             */
            //创建容器
            UnityContainer container = new UnityContainer();
            UnityConfigurationSection config = (UnityConfigurationSection)ConfigurationManager.GetSection(
                UnityConfigurationSection.SectionName
                );

            //加载到容器
            config.Configure(container, "XiangziContainer");

            //返回调用者
            IUserService userService = container.Resolve<UserService>();//这里Resolve成UserService或者IUserService都行

            //执行
            userService.MyDisplay("邵长祥");

            Console.ReadLine();

        }
    }
}
