using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostSharpExample
{
    /// <summary>
    /// 异常级别
    /// </summary>
    public enum MyExceptionLevel
    {
        /// <summary>
        /// 可识别捕获的异常
        /// </summary>
        Warning = 0,
        /// <summary>
        ///  未知的异常
        /// </summary>
        Error = 1
    }
}
