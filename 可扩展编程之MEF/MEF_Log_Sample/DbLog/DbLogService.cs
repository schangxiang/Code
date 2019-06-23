using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ILog;
using System.ComponentModel.Composition;

namespace DbLog
{
    [Export(typeof(ILogService))]
    public class DbLogService : ILogService
    {
        public void Log(string content)
        {
            string log = "DbLog:" + content;
            Console.WriteLine(log);
            //这里写的是存入数据库的方法，此处略
        }
    }
}
