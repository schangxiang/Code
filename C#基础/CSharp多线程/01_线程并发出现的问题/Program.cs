using SecureAcount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _01_线程并发出现的问题
{
    /*
     * 我们可以发现，10个人同时进行存款 2000，取款2000，最后的余额应该是不变的，
     * 但是结果却出现了混乱，说明多个线程是交替进行的，就出现了并发问题。
     */
    class Program
    {

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
