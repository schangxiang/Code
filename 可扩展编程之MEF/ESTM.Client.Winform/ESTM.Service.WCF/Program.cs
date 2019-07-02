using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace ESTM.Service.WCF
{
    class Program
    {
        static void Main(string[] args)
        {
            var strUri = "http://127.0.0.1:1234/MyWCF.Server";

            Uri httpAddress = new Uri(strUri);
            using (ServiceHost host = new ServiceHost(typeof(CSOAService)))//需要添加System.SystemModel这个dll。。。。CSOAService这个为实现ICSOAService的实现类，WCF真正的实现方法再这个类里面
            {
                ///////////////////////////////////////添加服务节点///////////////////////////////////////////////////
                host.AddServiceEndpoint(typeof(ICSOAService), new WSHttpBinding(), httpAddress);//ICSOAService这个为向外暴露的接口
                if (host.Description.Behaviors.Find<ServiceMetadataBehavior>() == null)
                {
                    ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
                    behavior.HttpGetEnabled = true;
                    behavior.HttpGetUrl = httpAddress;
                    host.Description.Behaviors.Add(behavior);
                }
                host.Opened += delegate
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("MyWCF.Server服务已经启动成功。" + strUri);
                };

                host.Open();
                while (true)
                {
                    Console.ReadLine();
                }
            }

            
        }
    }
}
