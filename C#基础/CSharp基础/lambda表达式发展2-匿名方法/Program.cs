using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda表达式发展2_匿名方法
{
    class Program
    {
        //匿名方法分2步

        //step01：用delegate定义一个委托
        public delegate int deleFun(int x, int y);

        static void Main(string[] args)
        {
            //step02：把一个方法赋值给委托
            deleFun dFun = delegate (int x, int y) { return x + y; };

            Console.WriteLine("匿名方法输出1：" + dFun.Invoke(5, 6));//输出11
            Console.WriteLine("匿名方法输出2：" + dFun(5, 6));//输出11

            Console.ReadKey();
        }
    }
}
