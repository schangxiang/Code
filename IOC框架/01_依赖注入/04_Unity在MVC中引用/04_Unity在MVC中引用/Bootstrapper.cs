using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc4;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;

namespace _04_Unity在MVC中引用
{
    public static class Bootstrapper
    {
        /// <summary>
        ///  获取容器-注册依赖关系
        /// </summary>
        /// <returns></returns>
        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            return container;
        }

        /// <summary>
        /// 加载容器
        /// </summary>
        /// <returns></returns>
        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();    
            RegisterTypes(container);

            return container;
        }

        /// <summary>
        /// 实施依赖注入
        /// </summary>
        /// <param name="container"></param>
        public static void RegisterTypes(IUnityContainer container)
        {
            UnityConfigurationSection config = (UnityConfigurationSection)ConfigurationManager.GetSection(UnityConfigurationSection.SectionName);
            //加载到容器
            config.Configure(container, "XiangziContainer");

        }
    }
}