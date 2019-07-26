using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 反射
{
    /// <summary>
    /// 我的自定义特性
    /// </summary>
    public class MyAttribute : Attribute
    {
        public string Name { get; set; }

        public MyAttribute(string name)
        {
            this.Name = name;
        }
    }
}
