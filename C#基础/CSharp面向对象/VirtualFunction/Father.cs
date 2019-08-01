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
            var _name = this.GetName();
            Console.WriteLine(_name);
            Console.WriteLine("Father的name是:" + name);
        }
    }
}
