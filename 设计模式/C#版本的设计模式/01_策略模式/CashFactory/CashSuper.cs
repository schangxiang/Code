/*
 * CLR Version：4.0.30319.42000
 * NameSpace：策略模式.CashFactory
 * FileName：CashSuper
 * CurrentYear：2019
 * CurrentTime：2019/6/22 6:58:58
 * Author：shaocx
 *
 * <更新记录>
 * ver 1.0.0.0   2019/6/22 6:58:58 新規作成 (by shaocx)
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式.CashFactory
{
    /// <summary>
    /// 现金收费抽象类
    /// </summary>
    abstract class CashSuper
    {
        /// <summary>
        /// 计算价格
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public abstract double AcceptCash(double money);
    }
}
