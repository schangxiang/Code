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

namespace Server
{
    /*
     *  需要引用System.Runtime.Remoting
     */
    class Program
    {
        static void Main(string[] args)
        {
            #region 代码实现
            /*
            //1、注册管道
            TcpChannel tcpChannel = new TcpChannel(10000);//端口指定
            HttpChannel httpChannel = new HttpChannel(10001);

            ChannelServices.RegisterChannel(tcpChannel, true);
            ChannelServices.RegisterChannel(httpChannel, false);

            //2、注册服务器激活方式
            //WellKnownObjectMode.Singleton表示生成的远程对象实例是单例模式
            //WellKnownObjectMode.SingleCall表示每个传入消息是由新的对象实例
            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(RemoteClass),
                "HelloTest",
                WellKnownObjectMode.SingleCall);

            //*/

            #endregion

            #region 配置文件实现

            RemotingConfiguration.Configure(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile, true);

            #endregion

            Console.WriteLine("这里是服务器端宿主程序");
            Console.Read();
        }
    }
}
