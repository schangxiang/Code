using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 反射
{
    public class XiangziAttribute : Attribute
    {
        public int age { get; set; }

        public XiangziAttribute(int age)
        {
            this.age = age;
        }
    }
}
