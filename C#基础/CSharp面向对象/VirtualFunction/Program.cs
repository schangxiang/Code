using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualFunction
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * 这里主要是测试 在父类中单独的一个方法，调用父类的一个虚方法（该方法是被子类重写的），那么执行的这个虚方法是掉
             * 父类的还是子类的呢？
             * 实验证明：调的是子类的被重写的方法。
             */
            Console.WriteLine("实例化son对象");
            Father f = new Son();
            f.SetFather();

            Console.WriteLine("========================我是华丽的分割线========================");

            Console.WriteLine("实例化father对象");
            Father f2 = new Father();
            f2.SetFather();

            Console.Read();
        }
    }
}
