using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ILog;
using System.ComponentModel.Composition;//使用MEF必须引用的

namespace TextLog
{
    [Export(typeof(ILogService))] //注意：这里就是使用MEF的地方
    public class TextLogService: ILogService
    {
        public void Log(string content)
        {
            string log = "TextLog:" + content;
            Console.WriteLine(log);
            System.Diagnostics.Debug.WriteLine(log);
        }
    }
}
