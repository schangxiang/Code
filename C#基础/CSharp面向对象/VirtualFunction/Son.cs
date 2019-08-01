using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualFunction
{
    class Son : Father
    {
        public string son_name = "我是儿子";
        public override string GetName()
        {
            this.son_name = "儿子变成猪";
            this.name = "父亲的名字改变了哦";
            return this.son_name;
        }
    }
}
