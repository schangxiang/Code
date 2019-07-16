/*
 * CLR Version：4.0.30319.42000
 * NameSpace：策略模式.CashFactory.Default
 * FileName：CashRebate
 * CurrentYear：2019
 * CurrentTime：2019/6/22 7:02:40
 * Author：shaocx
 *
 * <更新记录>
 * ver 1.0.0.0   2019/6/22 7:02:40 新規作成 (by shaocx)
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式.CashFactory.Default
{
    /// <summary>
    /// 打折收费子类
    /// </summary>
    class CashRebate : CashSuper
    {
        private double moneyRebate = 1d;//折扣率
        public CashRebate(string moneyRebateStr)
        {
            this.moneyRebate = double.Parse(moneyRebateStr);//初始化时输入折扣率，如打八折的话，输入0.8
        }
        public override double AcceptCash(double money)
        {
            return money * moneyRebate;
        }
    }
}
