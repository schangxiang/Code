using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ILog;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace MEFConsoleHost
{
    class Program
    {
        //导入声明,用接口来定义实例，然后增加导入声明，和导出的相互对应
        [Import(typeof(ILogService))]
        public ILogService CurrentLogService { get; set; }


        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }

        void Run()
        {
            //注意：需要把DbLog.dll或TextLog.dll放到指定文件夹
            //var catalog = new DirectoryCatalog(AppDomain.CurrentDomain.BaseDirectory,"DbLog.dll");
            var catalog = new DirectoryCatalog(AppDomain.CurrentDomain.BaseDirectory, "TextLog.dll");

            var container = new CompositionContainer(catalog);

            container.ComposeParts(this);

            CurrentLogService.Log("MEF Log Test Pass");

            Console.Read();
        }
    }
}
