using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using IDAL;
using System.Reflection;

namespace DALFactory
{
    /// <summary>
    /// 密封类
    /// </summary>
    public sealed class DataAccess
    {
        private static readonly string path = ConfigurationManager.AppSettings["SQLDAL"];

        public static IDAL.IGrade CreateGrade()
        {
            string className = path + ".GradeDAL";
            return (IGrade)(Assembly.Load(path).CreateInstance(className));
        }
        public static IDAL.IStudent CreateStudent()
        {
            string className = path + ".StudentDAL";
            return (IStudent)(Assembly.Load(path).CreateInstance(className));
        }


    }
}
