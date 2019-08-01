using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualFunction
{
    class Father
    {
        public string name = "我是父亲";

        public virtual string GetName()
        {
            return this.name;
        }

        public void SetFather()
        {
            var _name = this.GetName();//如果实例对象是子类的话，这里调的是子类的重写方法;如果实例对象是父类的话，调的当然是父类的方法
            Console.WriteLine("通过GetName方法获取的值：" + _name);
            Console.WriteLine("Father的name是:" + name);
        }
    }
}
