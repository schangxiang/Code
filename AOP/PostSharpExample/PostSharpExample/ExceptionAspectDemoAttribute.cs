using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostSharpExample
{
    [Serializable]
    public class ExceptionAspectDemoAttribute : OnExceptionAspect
    {
        /// <summary>
        /// 发生异常时
        /// </summary>
        /// <param name="args"></param>
        public override void OnException(MethodExecutionArgs args)
        {
            var msg = string.Format("时间[{0:yyyy年MM月dd日 HH时mm分}]方法{1}发生异常: {2}\n{3}", DateTime.Now, args.Method.Name, args.Exception.Message, args.Exception.StackTrace);
            LoggingHelper.Writelog("发生异常:" + msg);
            args.FlowBehavior = FlowBehavior.Continue;//方法指定继续执行
        }
    }
}
