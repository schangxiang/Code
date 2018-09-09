using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenerateCode_GEBrilliantFactory
{
    /// <summary>
    /// 列对象
    /// </summary>
    public class ColumnModel
    {
        /// <summary>
        /// 列名
        /// </summary>
        public string ColumnName { get; set; }

        /// <summary>
        /// 数据类型
        /// </summary>
        public string DataType { get; set; }

        /// <summary>
        /// 注释
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 字段长度
        /// </summary>
        public string DataLength { get; set; }

        /// <summary>
        /// 是否可为null
        /// </summary>
        public bool IsNullable { get; set; }

        /// <summary>
        /// 是否是主键
        /// </summary>
        public bool IsPrimaryKey { get; set; }

        public int Precision { get; set; }

        public int Scale { get; set; }
    }


    /// <summary>
    /// 数据类型枚举
    /// </summary>
    public enum DataTypeEnum
    {
        dt_char = 0,
        dt_varchar = 1,
        dt_datetime = 2,
        dt_int = 3,
        dt_decimal = 4,
        dt_bigint = 5,
        dt_nvarchar = 6,
        dt_Varchar_Desc = 7,
        dt_Varchar_Ext_Link = 8,
        dt_bit = 9,
        /// <summary>
        /// 唯一类型
        /// uniqueidentifier数据类型可存储16字节的二进制值，其作用与全局唯一标记符(GUID)一样。GUID是唯一的二进制数:世界上的任何两台计算机都不会生成重复的GUID值。GUID主要用于在用于多个节点，多台计算机的网络中，分配必须具有唯一性的标识符。
        /// </summary>
        dt_uniqueidentifier = 10
    }
}
