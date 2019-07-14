using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base关键字用法
{
    class B:A
    {
        public B():base()
        {
            Console.WriteLine("Build B");
        }
        public B(string name) : base()
        {
            Console.WriteLine(name + "Build B(有参构造)");
        }
        /*
        public B(string name) : base(name)
        {
            Console.WriteLine(name + "Build B(有参构造)");
        }
       //*/

        public override void Hello()
        {
            base.Hello();//调用基类的方法
            Console.WriteLine("Hello,我是 B");
        }
    }
}
