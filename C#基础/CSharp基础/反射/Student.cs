using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 反射
{
    public class Student
    {
        /// <summary>
        /// 年龄（对外不暴露）
        /// </summary>
        private int Age { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        ///  得到的小红花数
        /// </summary>
        public int LittleRedFlowers { get; set; }

        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime BirthDay { get; set; }

        /// <summary>
        /// 考试成绩列表
        /// </summary>
        public List<TestScore> TestScoreList { get; set; }
    }
}
