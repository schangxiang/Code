/*
 * CLR Version：4.0.30319.42000
 * NameSpace：策略模式
 * FileName：CashContext
 * CurrentYear：2019
 * CurrentTime：2019/6/22 7:10:31
 * Author：shaocx
 *
 * <更新记录>
 * ver 1.0.0.0   2019/6/22 7:10:31 新規作成 (by shaocx)
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 策略模式.CashFactory;
using 策略模式.CashFactory.Default;

namespace 策略模式
{
    /// <summary>
    /// 策略上下文
    /// </summary>
    class CashContext
    {
        CashSuper cashSuper = null;

        public CashContext(string type)
        {
            switch (type)
            {
                case "正常收费":
                    cashSuper = new CashNormal();
                    break;
                case "打8折":
                    cashSuper = new CashRebate("0.8");
                    break;
                case "满300返100":
                    cashSuper = new CashReturn("300", "100");
                    break;
            }
        }

        public double GetResult(double money)
        {
            return cashSuper.AcceptCash(money);
        }
    }
}
