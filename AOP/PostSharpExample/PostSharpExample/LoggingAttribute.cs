using Newtonsoft.Json;
using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public sealed class LoggingAttribute : OnMethodBoundaryAspect
    {
        public string BusinessName { get; set; }

        public override void OnEntry(MethodExecutionArgs args)
        {
            LoggingHelper.Writelog(BusinessName + "开始执行");
            string aa = args.Method.Name;//方法名
            Arguments arguments = args.Arguments;//参数值列表
            ParameterInfo[] parameters = args.Method.GetParameters();//参数名列表
            StringBuilder sb = new StringBuilder();
            for (int i = 0; arguments != null && i < arguments.Count; i++)
            {
                //进入的参数的值
                sb.Append(parameters[i].Name + "=" + JsonConvert.SerializeObject(arguments[i]) + "");
            }
            string message = string.Format("{0}.{1} Method. The Entry Arg Is：{2}",
               args.Method.DeclaringType.FullName, args.Method.Name, sb.ToString());
            LoggingHelper.Writelog(BusinessName + "的参数：" + message);

        }
        public override void OnExit(MethodExecutionArgs args)
        {
            LoggingHelper.Writelog(BusinessName + "成功完成");
        }
    }
}
