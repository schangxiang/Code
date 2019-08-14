using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            RedisHelper redis = new RedisHelper();
            

            string key = "csharp:user:1";

            redis.Set(key, "祥哥哥");
            var value = redis.Get<string>(key);
            Console.WriteLine("读取的"+key+"值："+value);

            Console.ReadLine();
        }
    }
}
