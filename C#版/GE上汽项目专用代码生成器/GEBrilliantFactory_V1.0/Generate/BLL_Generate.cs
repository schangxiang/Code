﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenerateCode_GEBrilliantFactory
{
    /// <summary>
    /// 生成BLL
    /// </summary>
    public class BLL_Generate
    {
        public static string CreateBLLText(string filePrefixName, string TableName, string entityName, string Author,
            string ChinaComment, string primaryKey,string primaryKeyDesc,string Modulelogo,
            List<ColumnModel> columnNameList)
        {
            var str_dal = TextHelper.ReadText(@"Templete\BLL模板.txt");

            str_dal = str_dal.Replace("$TableName$", TableName);//表名
            str_dal = str_dal.Replace("$Author$", Author);//作者
            str_dal = str_dal.Replace("$ChinaComment$", ChinaComment);//中文注释
            str_dal = str_dal.Replace("$CurDate$", CommonHelper.GetCurDate());//当前时间
            str_dal = str_dal.Replace("$EntityName$", entityName);//实体类名

            str_dal = str_dal.Replace("$FilePrefixName$", filePrefixName);//模块名
            str_dal = str_dal.Replace("$Modulelogo$", Modulelogo);//模块简写
            str_dal = str_dal.Replace("$PrimaryKey$", primaryKey);//主键
            str_dal = str_dal.Replace("$PrimaryKeyDesc$", primaryKeyDesc);//描述

            str_dal = str_dal.Replace("$ToSingleModel$", StructStrHelper.GetToModelStr(columnNameList));//动态给实体类赋值 
            return str_dal;
        }
    }
}
