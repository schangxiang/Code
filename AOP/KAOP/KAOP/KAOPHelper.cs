/*
 * CLR Version：4.0.30319.42000
 * NameSpace：KAOP
 * FileName：ReHelper
 * CurrentYear：2019
 * CurrentTime：2019/7/27 12:45:35
 * Author：shaocx
 *
 * <更新记录>
 * ver 1.0.0.0   2019/7/27 12:45:35 新規作成 (by shaocx)
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace KAOP
{
    internal  class KAOPHelper
    {
        /// <summary>
        /// 验证是否KAopMethodAttribute特性
        /// </summary>
        /// <param name="call"></param>
        /// <returns></returns>
        public static bool IsHaveKAopMethod(IMethodCallMessage call)
        {
            Type _type = KAOPHelper.FindTypeInCurrentDomain(call.TypeName);
            var _arr = _type.GetMethod(call.MethodName).GetCustomAttributes(typeof(KAopMethodAttribute), false);
            if (_arr != null && _arr.Length > 0)
                return true;
            return false;
        }
        private static Type FindTypeInCurrentDomain(string typeName)
        {
            Type type = null;

            //如果该类型已经装载
            type = Type.GetType(typeName);
            if (type != null)
            {
                return type;
            }

            //在EntryAssembly中查找
            if (Assembly.GetEntryAssembly() != null)
            {
                type = Assembly.GetEntryAssembly().GetType(typeName);
                if (type != null)
                {
                    return type;
                }
            }

            //在CurrentDomain的所有Assembly中查找
            Assembly[] assemblyArray = AppDomain.CurrentDomain.GetAssemblies();
            int assemblyArrayLength = assemblyArray.Length;
            for (int i = 0; i < assemblyArrayLength; ++i)
            {
                type = assemblyArray[i].GetType(typeName);
                if (type != null)
                {
                    return type;
                }
            }

            for (int i = 0; (i < assemblyArrayLength); ++i)
            {
                Type[] typeArray = assemblyArray[i].GetTypes();
                int typeArrayLength = typeArray.Length;
                for (int j = 0; j < typeArrayLength; ++j)
                {
                    if (typeArray[j].Name.Equals(typeName))
                    {
                        return typeArray[j];
                    }
                }
            }

            return type;
        }

    }
}
