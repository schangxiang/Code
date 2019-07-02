using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_1_隐式类型局部变量
{
    class Program
    {
        static void Main(string[] args)
        {
            //隐式类型局部变量
            var age = 25;
            var username = "shaocx";
            var userList = new string[] { "tom", "tilee", "gates" };
            foreach (var item in userList)
            {
                Console.WriteLine(item);
            }

            //需要注意的问题
            //1、不能赋值为NULL
            //var product;//报错，无法将<NULL>赋予隐式类型化的变量
            //var customer = null; //报错，无法将<NULL>赋予隐式类型化的变量
            //2、隐式变量是强类型，不能改变数据类型
            //var i = 15;
            //i = "666";//报错，无法将string隐式转换为int

            Console.ReadKey();
        }
    }
}
