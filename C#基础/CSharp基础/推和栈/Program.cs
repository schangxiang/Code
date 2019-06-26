using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 堆和栈
{
    class Program
    {
        static void Main(string[] args)
        {
            // s : 对象的引用【存储在栈中】
            //new Student() 【对象存储在堆中】
            Student s = new Student();//引用类型
            s.Age = 88;
            Console.WriteLine("初始对象s的Age是:" + s.Age.ToString()); // 输出：88

            Student s2 = s;//给引用类型赋值的时候，其实只是赋值了对象的引用【即是在栈中赋值了对象的引用，s和s2的引用地址都指向同一个堆上的地址】
            s2.Age = 44;
            Console.WriteLine("引用类型赋值后对象s2的Age是:" + s2.Age.ToString());// 输出：44
            Console.WriteLine("引用类型赋值后对象s的Age是:" + s.Age.ToString());// 输出：88

            //局部变量 【存储在栈中】
            int aaa = 0;//值类型
            Console.WriteLine("初始aaa变量的值是：" + aaa.ToString()); // 输出：0
            int aaa2 = aaa;//给值类型变量赋值的时候，是创建了一个副本（即克隆，aaa2 和aaa没一毛钱关系）
            aaa2 = 99;

            Console.WriteLine("值类型赋值后aaa变量的值是：" + aaa.ToString()); // 输出：0
            Console.WriteLine("值类型赋值后aaa2变量的值是：" + aaa2.ToString()); // 输出：99
            Console.ReadKey();


        }
    }
}
