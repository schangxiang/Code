/*
 * CLR Version：4.0.30319.42000
 * NameSpace：策略模式.CashFactory.Default
 * FileName：CashNormal
 * CurrentYear：2019
 * CurrentTime：2019/6/22 7:01:25
 * Author：shaocx
 *
 * <更新记录>
 * ver 1.0.0.0   2019/6/22 7:01:25 新規作成 (by shaocx)
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式.CashFactory.Default
{
    /// <summary>
    /// 正常收费子类
    /// </summary>
    class CashNormal : CashSuper
    {
        public override double AcceptCash(double money)
        {
            return money;//正常收费，原价
        }
    }
}
