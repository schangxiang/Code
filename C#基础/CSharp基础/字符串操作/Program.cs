using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串操作
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Compare

            /*
             *  Compare 方法特点：
             *  1、方法不会创建新的字符串，所以是避免ToUpper和ToLower的调优方式（他们两者都会导致创建一个新的字符串，违背了“避免频繁创建对象”原则）
             *  2、参数可以设置不区分大小写
             */
            string strA = "Abc";
            string strB = "ABC";
            Console.WriteLine("strA和strB的比较结果(Compare默认)：" + string.Compare(strA,strB));//返回-1，默认区分大小写
            Console.WriteLine("strA和strB的比较结果（Compare设置不区分大小写）：" + string.Compare(strA, strB,true));//返回0，设置不区分大小写

            //Compare的另一种用法CompareTo
            Console.WriteLine("strA和strB的比较结果(CompareTo默认)：" + strA.CompareTo(strB));

            #endregion
            Console.ReadKey();
        }
    }
}
