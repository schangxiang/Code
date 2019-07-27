﻿/*
 * CLR Version：4.0.30319.42000
 * NameSpace：KAOPSample
 * FileName：MyLogAttribute
 * CurrentYear：2019
 * CurrentTime：2019/7/27 8:51:32
 * Author：shaocx
 *
 * <更新记录>
 * ver 1.0.0.0   2019/7/27 8:51:32 新規作成 (by shaocx)
 */


using KAOP;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAOPSample
{
    [AttributeUsage(AttributeTargets.All)]
    public class MyLogAttribute : KAopClassAttribute
    {
        public override void PreExcute(string MethodName, object[] InParams)
        {
            Logger.Info("==================== " + MethodName + ":" + " Start====================");
            Logger.Info(string.Format("参数数量：{0}", InParams.Count()));

            for (int i = 0; i < InParams.Count(); i++)
            {
                Logger.Info(string.Format("参数序号[{0}] ============    参数类型：{1}    执行类：{1}", i + 1, InParams[i]));
                Logger.Info("传入参数：");
                string paramXMLstr = JsonConvert.SerializeObject((InParams[i]));
                Logger.Info(paramXMLstr);
            }
        }

        /// <summary>
        /// 后处理
        /// </summary> 
        public override void EndExcute(string MethodName, object[] OutParams, object ReturnValue, Exception ex)
        {
            Type myType = ReturnValue.GetType();
            Logger.Info(string.Format("返回值类型：{0}", myType.Name));
            Logger.Info("返回值：");
            if (myType.Name != "Void")
            {
                string resXMLstr = JsonConvert.SerializeObject(ReturnValue);
                Logger.Info(resXMLstr);
            }

            if (OutParams.Count() > 0)//out 返回参数
            {
                Logger.Info(string.Format("out返回参数数量：{0}", OutParams.Count()));
                for (int i = 0; i < OutParams.Count(); i++)
                {
                    Logger.Info(string.Format("参数序号[{0}] == 参数值：{1}", i + 1, OutParams[i]));
                }
            }

            if (ex != null)
            {
                Logger.Error(ex);
            }
            Logger.Info("==================== " + MethodName + ":" + " End====================");
        }
    }
}
