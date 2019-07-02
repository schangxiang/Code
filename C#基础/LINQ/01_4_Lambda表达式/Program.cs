using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_4_Lambda表达式
{
    class Program
    {
        private delegate void myDelegate(string name);
        private delegate void myDelegate2(string name, int age);
        static void Main(string[] args)
        {
            //Lambda表达式是对匿名方法的又一次简化
            myDelegate md = name => Console.WriteLine(name);
            md("shaocx");

            //多参数的Lambda表达式
            myDelegate2 md2 = (name, age) =>
            {
                Console.WriteLine("姓名:{0},年龄:{1}", name, age);
            };
            md2("牛顿", 55);

            Console.ReadKey();
        }
    }
}
