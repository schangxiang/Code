using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda表达式发展3_lambda表达式
{
    class Program
    {
        //lambda表达式简化了匿名方法的第2步

        //step01：用delegate定义一个委托
        public delegate int deleFun(int x, int y);

        static void Main(string[] args)
        {
            //step02：把一个方法赋值给委托  
            deleFun dFun = (x, y) => { return x + y; };

            Console.WriteLine("lambda表达式输出1：" + dFun.Invoke(5, 6));//输出11
            Console.WriteLine("lambda表达式输出2：" + dFun(5, 6));//输出11

            Console.ReadKey();
        }
    }
}
