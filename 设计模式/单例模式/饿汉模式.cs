/*
 * CLR Version：4.0.30319.42000
 * NameSpace：单例模式
 * FileName：饿汉模式
 * CurrentYear：2019
 * CurrentTime：2019/5/31 9:52:41
 * Author：shaocx
 *
 * <更新记录>
 * ver 1.0.0.0   2019/5/31 9:52:41 新規作成 (by shaocx)
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式
{

    /*
     * 静态初始化
     * 这种方法不需要开发人员显式的编写线程安全代码，即可解决多线程环境下他是不安全的问题
     * 饿汉式是类一加载就实例化对象，所以要提前占用系统资源。
     * 
     */
    sealed class Singleton
    {//sealed是为了防止发生派生，派生可能会增加实例
        #region 饿汉模式

        private static readonly Singleton instance = new Singleton();//readonly意味着只能在静态初始化期间或者在类构造函数中分配变量
        private Singleton() { }
        public static Singleton GetInstance()
        {
            return instance;
        }

        #endregion
    }
}
