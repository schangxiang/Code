using System;
using System.Runtime.Serialization; 
                   
namespace PostSharpExample
{
    /// <summary>
    /// agv台车映射实体类
    /// </summary>
 
    public class AgvMap 
    {

        /// <summary>
        /// RFID
        /// </summary>

        public string rfid { get; set; }

        /// <summary>
        /// agv编码
        /// </summary>

        public string agvCode { get; set; }

        /// <summary>
        /// AGV台车
        /// </summary>

        public string agvNumber { get; set; }

    }
}