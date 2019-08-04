using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace 线程池的应用
{
    class CLRThread
    {
        /*
         * 您猜对了吗？我没有猜对，因为有两点：

原来最小线程数量为5时，只有4个线程可以立即执行。经过进一步尝试，最小线程数量为10时，也只有9个线程可以立即执行。
原来线程池创建线程的速度并非永远是“每秒2个”，而一些资料上写着“每秒不超过2个”的确是确切的说法。
但是，我们还是验证了以下几个结论：

在线程池最小线程数量的范围之内，尽可能多的任务立即执行。
线程池使用使用每秒不超过2个的频率创建线程（1秒一个或0.5秒一个）。
当达到线程池最大线程数时（第6秒），停止创建新线程。
在旧任务执行完毕后，新任务立即执行。
         */
        public static void ThreadUseAndConstruction()
        {
            ThreadPool.SetMinThreads(5, 5); // set min thread to 5
            ThreadPool.SetMaxThreads(12, 12); // set max thread to 12

            Stopwatch watch = new Stopwatch();
            watch.Start();

            WaitCallback callback = index =>
            {
                Console.WriteLine(String.Format("{0}: Task {1} started", watch.Elapsed, index));
                Thread.Sleep(10000);
                Console.WriteLine(String.Format("{0}: Task {1} finished", watch.Elapsed, index));
            };

            for (int i = 0; i < 20; i++)
            {
                ThreadPool.QueueUserWorkItem(callback, i);
            }

        }
    }
}
