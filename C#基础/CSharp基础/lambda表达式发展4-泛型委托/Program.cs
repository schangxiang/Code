using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda表达式
{
    class Program
    {
        //泛型委托只需要1步
        static void Main(string[] args)
        {

            #region 泛型委托

            //step01：定义泛型委托 并把一个方法赋值给委托  
            Func<int, int, int, string> dFun = (x, y, z) => { return (x + y + z).ToString(); };
            Console.WriteLine("泛型委托之1："+dFun(1, 2, 3));//输出6
            Console.WriteLine("泛型委托之2：" + dFun.Invoke(1, 2, 3));//输出6

            Func<int, string> gwl = p => "泛型委托之单个参数：" + p + 10 + "--返回类型为string";
            Console.WriteLine(gwl(10) + "");   //打印‘20--返回类型为string’，z对应参数b，p对应参数a

            #endregion


            Console.ReadKey();
        }
    }
}
