using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 反射
{
    /// <summary>
    /// 考试成绩
    /// </summary>
    public class TestScore
    {
        /// <summary>
        /// 科目
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// 分数(保密)
        /// </summary>
        private int Score { get; set; }

        /// <summary>
        /// 考试时间
        /// </summary>
        public DateTime TestDate { get; set; }
    }
}
