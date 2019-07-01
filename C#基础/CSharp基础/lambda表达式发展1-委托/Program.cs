using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda表达式发展1_委托
{
    class Program
    {
        //委托分3步

        //step01：用delegate定义一个委托
        public delegate int DeleFun(int x,int y);

        //step02：声明一个方法来对应委托
        public static int Add(int x,int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            //step03：用这个方法来实例化这个委托
            DeleFun dFun = new DeleFun(Add);
            Console.WriteLine("委托输出1："+dFun.Invoke(5,6));//输出11
            Console.WriteLine("委托输出2：" + dFun(5,6));//输出11

            Console.ReadKey();
        }
    }
}
