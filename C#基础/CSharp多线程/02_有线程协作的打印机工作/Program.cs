using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_有线程协作的打印机工作
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

                    //producer线程通知consumer线程从阻塞队列进入准备队列
                    Monitor.Pulse(queue); //释放等待线程
                    //producer线程进入阻塞队列，并放弃了锁定，使consumer线程得以执行
                    Monitor.Wait(queue);  //等待CosumerThread()完成

                }
            }
        }

        //消费者线程
        public void ConsumerThread()
        {
            lock (queue)
            {
                do
                {
                    if (queue.Count>0)
                    {
                        int value = (int)queue.Dequeue(); //第一个元素出队列
                        Console.WriteLine("消费：" + value);

                        Monitor.Pulse(queue);//释放 
                    }
                } while (Monitor.Wait(queue)); // 等待ProducerThread()放入数据
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
