using SecureAcount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03_使用Monitor解决并发问题
{
    /*
     * Monitor类提供同步访问对象的机制

Monitor 类通过向单个线程授予对象锁来控制对对象的访问。
 对象锁提供限制访问代码块（通常称为临界区）的能力。当一个线程拥有对象的锁时，其他任何线程都不能获取该锁。
 还可以使用 Monitor 来确保不会允许其他任何线程访问正在由锁的所有者执行的应用程序代码节，除非另一个线程正在使用其他的锁定对象执行该代码。 
     */
    class Program
    {
        public static readonly object _lockObject = new object();

        Account acc = new Account("张兰", "0000", 5000);

        static void Main(string[] args)
        {
            Thread[] threads = new Thread[10];
            Program p = new Program();

            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(new ThreadStart(p.Run));
                threads[i].Name = "线程" + (i + 1);
            }

            foreach (Thread t in threads)
            {
                t.Start();
            }
        }

        public void Run()
        {
            ATM atm = new ATM();
            atm.account = acc;
            //对额度相关的操作代码加锁
            try
            {
                if (Monitor.TryEnter(_lockObject, -1))
                {

                    Console.WriteLine(Thread.CurrentThread.Name +
                         "：查询当前" + atm.GetBalance());

                    Console.WriteLine(Thread.CurrentThread.Name +
                         "：取款2000");
                    //取款
                    atm.WithDraw(2000);

                    Thread.Sleep(100);

                    Console.WriteLine(Thread.CurrentThread.Name +
                         "：查询当前" + atm.GetBalance());

                    Console.WriteLine(Thread.CurrentThread.Name +
                         "：存款2000");
                    //存款
                    atm.Deposit(2000);
                    Console.WriteLine(Thread.CurrentThread.Name +
                         "：查询当前" + atm.GetBalance());

                }
            }
            finally
            {
                Monitor.Exit(_lockObject);
            }
        }
    }
}
