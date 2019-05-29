/*
 * CLR Version：4.0.30319.42000
 * NameSpace：设计模式
 * FileName：Discount
 * CurrentYear：2019
 * CurrentTime：2019/5/30 6:19:01
 * Author：shaocx
 *
 * <更新记录>
 * ver 1.0.0.0   2019/5/30 6:19:01 新規作成 (by shaocx)
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    //打折策略
    class Discount : Promotion
    {
        //计算商品的价格接口
        public double GetPrice(double originPrice)
        {
            Console.WriteLine("打8折");
            return originPrice * 0.8;
        }
    }
}
