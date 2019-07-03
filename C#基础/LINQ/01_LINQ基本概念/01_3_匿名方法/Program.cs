using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_3_匿名方法
{
    class Program
    {
        private delegate void myDelegate(string type,string name);//定义委托
        public static void myMethod(string type,string name)
        {
            Console.WriteLine(type+"输出：" + name);
        }
        static void Main(string[] args)
        {
            #region 使用委托方式

            myDelegate md = new myDelegate(myMethod);
            myDelegate md1 = myMethod;
            md("委托方法","shaocx");
            md1("委托方法","我是鬼");

            #endregion

            #region 使用匿名方法方式（其实就是简化了使用委托的操作）

            myDelegate md2 = delegate (string type,string name) { Console.WriteLine(type + "输出：" + name); };
            md2("匿名方法","张三");

            #endregion

            Console.ReadKey();
        }
    }
}
