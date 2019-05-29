using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    class Program
    {
        static void Main(string[] args)
        {

            //1 
            PromotionContext context = new PromotionContext(null);
            Console.WriteLine(context.GetPrice(200));

            context.ChangePromotion(new MoneyBack());
            Console.WriteLine(context.GetPrice(155.9));
        }
    }
}
