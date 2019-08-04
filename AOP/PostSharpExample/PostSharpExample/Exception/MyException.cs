using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PostSharpExample
{
    /// <summary>
    /// 自定义异常
    /// </summary>
    public class MyException : System.Exception
    {
        /// <summary>
        /// 异常编号
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 异常级别
        /// </summary>
        public MyExceptionLevel Level { get; set; }

        public MyException() { }

        /// <summary>
        ///  构造函数
        /// </summary>
        /// <param name="exceptionCode">异常编号</param>
        /// <param name="message">异常信息</param>
        /// <param name="innerException">内部异常</param>
        /// <param name="context">上下文</param>
        /// <param name="level">异常级别</param>
        public MyException(string exceptionCode, string message, System.Exception innerException, IDictionary<string, string> context, MyExceptionLevel level = MyExceptionLevel.Error)
            : base(message, innerException)
        {
            this.Code = Code;
            this.Level = level;
            this.InitData(context);
        }

        /// <summary>
        /// 获取对象数据
        /// </summary>
        /// <param name="info">序列化信息</param>
        /// <param name="context">上下文</param>
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ExceptionCode", this.Code);
            info.AddValue("Level", this.Level);
            base.GetObjectData(info, context);
        }

        /// <summary>
        /// 初始化上下文数据
        /// </summary>
        /// <param name="context">上下文</param>
        private void InitData(IDictionary<string, string> context)
        {
            if (context != null)
            {
                foreach (string item in context.Keys)
                {
                    if (!this.Data.Contains(item))
                    {
                        this.Data.Add(item, context[item]);
                    }
                }
            }
        }
    }
}
