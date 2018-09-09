﻿

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenerateCode_GEBrilliantFactory
{
    /// <summary>
    /// 生成查询实体类
    /// </summary>
    public class QueryModel_Generate
    {
        public static string CreateQueryModelLText(string Modulelogo, string TableName, string entityName, string Author,
            string ChinaComment, string PimaryKey,string PimaryKeyName,  List<ColumnModel> columnNameList)
        {
            var str_dal = TextHelper.ReadText(@"Templete\QueryModel模板.txt");

           
            str_dal = str_dal.Replace("$ChinaComment$", ChinaComment);//中文注释
           

            str_dal = str_dal.Replace("$Modulelogo$", Modulelogo);//模块简写

            string attrString = "";
            for (int i = 0; i < columnNameList.Count; ++i)
            {
                attrString += StructStrHelper.GenerateAttribute(columnNameList[i]);
            }
            str_dal = str_dal.Replace("$Attributes$", attrString);
           
            return str_dal;
        }
    }
}
