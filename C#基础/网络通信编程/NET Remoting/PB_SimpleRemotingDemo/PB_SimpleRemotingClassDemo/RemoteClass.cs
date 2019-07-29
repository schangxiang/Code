using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB_SimpleRemotingClassDemo
{
    /*
     * 远程对象类必须派生自MarshalByRefObject
     */
    public class RemoteClass : MarshalByRefObject
    {
        int num = 0;
        public RemoteClass()
        {
            Console.WriteLine("激活了RemoteClass远程对象");
        }
        public string Method(string name)
        {
            Console.WriteLine("第{0}次调用，参数为{1}", num++, name);
            return "hello " + name;
        }
    }
}
