/*
 * CLR Version：4.0.30319.42000
 * NameSpace：设计模式
 * FileName：Promotion
 * CurrentYear：2019
 * CurrentTime：2019/5/30 6:16:56
 * Author：shaocx
 *
 * <更新记录>
 * ver 1.0.0.0   2019/5/30 6:16:56 新規作成 (by shaocx)
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    /// <summary>
    /// 促销策略的接口
    /// </summary>
    interface Promotion
    {
        //计算商品的价格接口
        double GetPrice(double originPrice);
    }
}
