using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01_没有线程协作的打印机工作
{
 
    class MonitorTest
    {
        int MAX = 10;//最多允许10个打印作业

        Queue<int> queue; //表示对象的先进先出的集合
        public MonitorTest()
        {
            queue = new Queue<int>();
        }

        //生产者线程调用的方法：模拟添加打印作业
        public void ProducerThread()
        {
            Random r = new Random();

            lock (queue)
            {
                for (int counter = 0; counter < MAX; counter++)
                {
                    int value = r.Next(100);
                    queue.Enqueue(value);    //随机数入队列
                    Console.WriteLine("生产：" + value);
                }
            }
        }

        //消费者线程
        public void ConsumerThread()
        {
            lock (queue)
            {
                for (int counter = 0; counter < MAX; counter++)
                {
                    int value = (int)queue.Dequeue(); //第一个元素出队列
                    Console.WriteLine("消费：" + value);
                }
            }
        }

        static void Main(string[] args)
        {
            MonitorTest monitor = new MonitorTest();
            Thread producer = new Thread(new ThreadStart(monitor.ProducerThread));
            Thread consumer = new Thread(new ThreadStart(monitor.ConsumerThread));

            producer.Start();
            consumer.Start();

            Console.WriteLine("打印机工作完毕");
            Console.ReadLine();
        }
    }
}
