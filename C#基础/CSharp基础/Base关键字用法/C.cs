using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base关键字用法
{
    class C:A
    {
        public int age = 99;
        public C() {
        }
        public C(string name) : base(name)
        {
            Console.WriteLine(name + "Build C(有参构造)");
        }

        public override void Hello()
        {
            Console.WriteLine("Hello,我是C方法里的Hello方法");
        }
    }
}
