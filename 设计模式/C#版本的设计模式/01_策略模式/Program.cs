using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 策略模式;

namespace _01_策略模式
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = 350;//商品原价
            CashContext cashContext = new CashContext("正常收费");
            Console.WriteLine("正常收费的价格:" + cashContext.GetResult(money));

            cashContext = new CashContext("打8折");
            Console.WriteLine("打8折收费的价格:" + cashContext.GetResult(money));

            cashContext = new CashContext("满300返100");
            Console.WriteLine("满300返100收费的价格:" + cashContext.GetResult(money));

            Console.ReadKey();
        }
    }
}
