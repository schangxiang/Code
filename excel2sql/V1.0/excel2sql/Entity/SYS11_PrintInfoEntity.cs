/*
 * CLR Version：4.0.30319.34014
 * NameSpace：Teld.OpenInterConnectionBM.Models
 * FileName：XiangziEntity
 * FileDesc：祥子实体类
 * CurrentTime：2018-8-2 9:55:52
 * Author：shaocx
 *
 * <更新记录>
 * ver 1.0.0.0   2018-8-2 9:55:52 新規作成 (by shaocx)
 */ 
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
                   
namespace UnitTestProject1
{
    /// <summary>
    /// 祥子实体类
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Serializable]
    public class SYS11_PrintInfoEntity
    {

        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string printDevKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string temName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string printJson { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? printTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string printFlag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string pageOrientationType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string printArea { get; set; }

    }
}