/*
 * CLR Version：4.0.30319.42000
 * NameSpace：设计模式
 * FileName：MoneyBack
 * CurrentYear：2019
 * CurrentTime：2019/5/30 6:20:50
 * Author：shaocx
 *
 * <更新记录>
 * ver 1.0.0.0   2019/5/30 6:20:50 新規作成 (by shaocx)
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    //满100返50策略
    class MoneyBack : Promotion
    {
        //计算商品的价格接口
        public double GetPrice(double originPrice)
        {
            Console.WriteLine("满100返50");
            return originPrice - (int)originPrice / 100 * 50;
        }
    }
}
