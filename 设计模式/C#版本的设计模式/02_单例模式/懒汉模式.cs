/*
 * CLR Version：4.0.30319.42000
 * NameSpace：单例模式
 * FileName：懒汉模式
 * CurrentYear：2019
 * CurrentTime：2019/5/31 9:29:01
 * Author：shaocx
 *
 * <更新记录>
 * ver 1.0.0.0   2019/5/31 9:29:01 新規作成 (by shaocx)
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式
{
    class Sington
    {
        #region 懒汉模式

        private static Sington instance;
        private static readonly object syncRoot = new object();
        private Sington() { }
        public static Sington GetInstance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new Sington();
                    }
                }
            }
            return instance;
        }

        #endregion
    }
}
