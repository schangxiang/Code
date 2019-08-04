using SecureAcount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_使用lock解决并发问题
{
    /*
    * lock 关键字将语句块标记为临界区，方法是获取给定对象的互斥锁，执行语句，然后释放该锁。 此语句的形式如下：
        Object thisLock = new Object();
        lock (thisLock)
        {
            // Critical code section.
        }
        lock 关键字可确保当一个线程位于代码的临界区时，另一个线程不会进入该临界区。 
        如果其他线程尝试进入锁定的代码，则它将一直等待（即被阻止），直到该对象被释放。
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

            Console.ReadKey();
        }

        public void Run()
        {

            ATM atm = new ATM();
            atm.account = acc;

            //对额度相关的操作代码加锁
            lock (_lockObject)
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
    }
}
