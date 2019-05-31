/*
 * CLR Version：4.0.30319.42000
 * NameSpace：观察者模式
 * FileName：Mouse
 * CurrentYear：2019
 * CurrentTime：2019/5/31 15:15:22
 * Author：shaocx
 *
 * <更新记录>
 * ver 1.0.0.0   2019/5/31 15:15:22 新規作成 (by shaocx)
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    class Mouse
    {
        private string name;
        private string color;

        public Mouse(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
        /// <summary>
        /// 逃跑功能
        /// </summary>

        public void RunAway()
        {
            Console.WriteLine(color + "的老鼠" + name + "跑了");
        }
    }
}
