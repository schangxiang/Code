/*
 * CLR Version：4.0.30319.42000
 * NameSpace：观察者模式
 * FileName：Cat
 * CurrentYear：2019
 * CurrentTime：2019/5/31 15:12:18
 * Author：shaocx
 *
 * <更新记录>
 * ver 1.0.0.0   2019/5/31 15:12:18 新規作成 (by shaocx)
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    class Cat
    {
        private string name;
        private string color;

        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        /// <summary>
        /// 猫进屋（猫的状态发生改变）
        /// </summary>
        public void CatComing()
        {
            Console.WriteLine("猫来了");
            if (catCome != null)
            {
                catCome();
            }
        }

        public Action catCome;//委托
    }
}
