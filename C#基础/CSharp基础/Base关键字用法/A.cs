using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base关键字用法
{
    class A
    {
        public int age = 11;
        public A()
        {
            Console.WriteLine("Build A(无参构造)");
        }
        public A(string name)
        {
            Console.WriteLine(name + "Build A(有参构造)");
        }
        public virtual void Hello()
        {
            Console.WriteLine("Hello,我是A方法里的Hello方法");
        }
    }
}
