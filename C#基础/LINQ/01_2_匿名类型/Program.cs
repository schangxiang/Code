using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_2_匿名类型
{
    class Program
    {
        static void Main(string[] args)
        {
            var stu = new { username="shaocx",age=16};
            Console.WriteLine("姓名:{0},年龄:{1}",stu.username,stu.age);
            Console.ReadKey();
        }
    }
}
