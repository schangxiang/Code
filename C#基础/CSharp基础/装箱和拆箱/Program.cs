using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装箱和拆箱
{
    class Program
    {
        /*
         *  装箱： 【值类型】 转成 【引用类型】
         *  拆箱：  【引用类型】 转成 【值类型】
         *  
         *  学习装箱，是为了尽量避免装箱，装箱往往是被迫的。
在C#没有支持泛型之前，为了使某些程序具有通用性，使用到了Object（Object是所有类型的跟父类），
所以必须装箱。
对于已装箱的对象，因为无法直接调用其指定方法，所以必须先拆箱，再调用方法，
但再次拆箱，会生成新的栈实例，而无法修改装箱对象。这样消耗资源很大！
         */
        static void Main(string[] args)
        {
            int a = 7;
            object o = a; //装箱
            int b = (int)o; //拆箱


        }
    }
}
