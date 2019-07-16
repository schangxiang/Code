using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base关键字用法
{
    class B:A
    {
        public B():base() //注意：这里:base()不写也是默认调用父类的无参构造,除非显式写base(name)，调用父类的有参构造
        {
            Console.WriteLine("Build B(无参构造)");
        }
        public B(string name)  // : base()  //注意：这里:base()不写也是默认调用父类的无参构造,除非显式写base(name)，调用父类的有参构造
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
            Console.WriteLine("Hello,我是 B方法里的Hello方法");
        }
    }
}
