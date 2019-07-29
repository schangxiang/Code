using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels.Http;
using PB_SimpleRemotingClassDemo;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TCP方式
            /*
            //1、注册通道
            TcpChannel tcpChannel = new TcpChannel();//客户端不需要指定端口号
            ChannelServices.RegisterChannel(tcpChannel, true);

            //2、创建代理
            RemoteClass rc = (RemoteClass)Activator.GetObject(typeof(RemoteClass), "tcp://localhost:10000/HelloTest");//1000端口号是服务器端指定的
            if (rc == null)
            {
                Console.WriteLine("Could not locate TCP Server");
            }
            Console.WriteLine("TCP方式{0}", rc.Method("张飞"));
            //*/

            #endregion

            #region Http方式

            HttpChannel httpChannel = new HttpChannel();
            ChannelServices.RegisterChannel(httpChannel, false);
            RemoteClass object2 = (RemoteClass)Activator.GetObject(typeof(RemoteClass), "http://localhost:10001/HelloTest");
            if (object2 == null)
            {
                Console.WriteLine("Could not locate HTTP Server");
            }

            Console.WriteLine("HTTP方式{0}", object2.Method("关羽"));
            #endregion

            #region 配置文件实现

            RemotingConfiguration.Configure(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile, true);
            RemoteClass obj = new RemoteClass();

            Console.WriteLine("HTTP方式{0}", obj.Method("祥子"));
            #endregion

            Console.Read();
        }
    }
}
