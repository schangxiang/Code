/*
 * CLR Version：4.0.30319.42000
 * NameSpace：策略模式.CashFactory.Default
 * FileName：CashReturn
 * CurrentYear：2019
 * CurrentTime：2019/6/22 7:05:59
 * Author：shaocx
 *
 * <更新记录>
 * ver 1.0.0.0   2019/6/22 7:05:59 新規作成 (by shaocx)
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式.CashFactory.Default
{
    /// <summary>
    /// 返利收费子类
    /// </summary>
    class CashReturn : CashSuper
    {
        //返利条件，如满300返100
        private double moneyCondition = 0.0d;
        private double moneyReturn = 0.0d;

        public CashReturn(string moneyConditionStr, string moneyReturnStr)
        {
            this.moneyCondition = double.Parse(moneyConditionStr);
            this.moneyReturn = double.Parse(moneyReturnStr);
        }

        public override double AcceptCash(double money)
        {
            double result = money;
            if (money > moneyCondition)
            {
                result = money - Math.Floor(money / moneyCondition) * moneyReturn;
            }
            return result;
        }
    }
}
