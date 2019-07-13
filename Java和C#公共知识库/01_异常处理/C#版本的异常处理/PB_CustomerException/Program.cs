using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB_CustomerException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // 无参构造对象
                //throw new MyException();
                //throw new MyException("我的错误哦");
                throw new MyException("我的错误",new Exception("这是Exception的错误"));
            }
           
            catch (MyException e) 
            {
                //Console.WriteLine(e.GetError());
                Console.WriteLine(e.InnerException.Message);
            }
            //*/
            /*
           //因为Exception是MyException父类，所以如果这里是Exception也能捕获到MyException的错误
           //前提是MyException必须初始化父类Exception构造函数，即 public MyException(string msg) :base(msg)
           catch (Exception e)
           {
               Console.WriteLine(e.Message);
           }
           //*/

            Console.ReadKey();
        }
    }
}
