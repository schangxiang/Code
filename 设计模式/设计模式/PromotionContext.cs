/*
 * CLR Version：4.0.30319.42000
 * NameSpace：设计模式
 * FileName：PromotionContext
 * CurrentYear：2019
 * CurrentTime：2019/5/30 6:22:55
 * Author：shaocx
 *
 * <更新记录>
 * ver 1.0.0.0   2019/5/30 6:22:55 新規作成 (by shaocx)
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    //策略的上下文对象，用来为客户端选择合适的策略
    class PromotionContext
    {
        private Promotion p = null;
        public PromotionContext(Promotion p)
        {
            this.p = p;
        }
        //计算商品的价格接口
        public double GetPrice(double originPrice)
        {
            if (p == null)
            {
                p = new Discount();//默认的促销策略
            }
            return p.GetPrice(originPrice);
        }

        public void ChangePromotion(Promotion p)
        {
            this.p = p;
        }
    }
}
