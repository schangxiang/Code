using Hangfire;
using Hangfire.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHangFire
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("服务开始...");

            //1、配置HangFire数据库连接：首次连接数据库会自动创建12张相关的表
            string conn = "server=shaocx;uid=sa;pwd=1111;database=MyDB";
            GlobalConfiguration.Configuration.UseStorage(new SqlServerStorage(conn));

            //2、创建任务，自动将任务信息存储到数据系统表
            BackgroundJob.Enqueue<Class1>(x => x.Fuck("我是鬼"));//执行一次其他类的非静态方法
            RecurringJob.AddOrUpdate(() => Console.WriteLine("你好啊"), Cron.Minutely());//每分钟执行一次控制台输出
            RecurringJob.AddOrUpdate(() => Class1.FuckStatic(), Cron.Hourly(2));//每2小时执行一次 其他类的静态方法
            RecurringJob.AddOrUpdate(() => Program.DoSomething2(), Cron.Daily());//每天执行一次 其他类的静态方法

            var client = new BackgroundJobClient();

            //3、开启HangFire作业服务
            using (var _service = new BackgroundJobServer())
            {
                //4、控制台等待用户输入命令结束程序，如果控制台程序结束，HangFire服务跟宿主一起停止
                while (true)
                {
                    string tmpCmd = Console.ReadLine();
                    if (tmpCmd.ToLower().Equals("exit"))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("可输入exit结束程序!");
                    }
                }
            }

        }

        public static void DoSomething2()
        {
            Console.WriteLine("Fire in th hole!");
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(@"D:\log_stop.txt", true))
            {
                sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "Stop.");
            }
        }
    }
}
