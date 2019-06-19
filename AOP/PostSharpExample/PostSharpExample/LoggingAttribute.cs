using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostSharpExample
{
    /*
     * 我们约定每个Aspect类的命名必须为“XXXAttribute”的形式。
     * 其中“XXX”就是这个Aspect的名字。
     * PostSharp中提供了丰富的内置“Base Aspect”以便我们继承，
     * 其中这里我们继承“OnMethodBoundaryAspect ”，
     * 这个Aspect提供了进入、退出函数等连接点方法。
     * 另外，Aspect上必须设置“[Serializable] ”，
     * 这与PostSharp内部对Aspect的生命周期管理有关
     */
    [Serializable]
    [AttributeUsage(AttributeTargets.Method,AllowMultiple =true,Inherited =true)]
    public sealed class LoggingAttribute:OnMethodBoundaryAspect
    {
        public string BusinessName { get; set; }

        public override void OnEntry(MethodExecutionArgs args)
        {
            LoggingHelper.Writelog(BusinessName+"开始执行");
        }
        public override void OnExit(MethodExecutionArgs args)
        {
            LoggingHelper.Writelog(BusinessName + "成功完成");
        }
    }
}
