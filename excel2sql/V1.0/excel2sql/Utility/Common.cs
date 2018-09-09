﻿using Excel2SQL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace GenerateModel
{
    /// <summary>
    /// 公共类
    /// </summary>
    public class Common
    {


        /// <summary>
        /// 当前时间字符串
        /// </summary>
        /// <returns></returns>
        public static string GetCurDate()
        {
            return DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day
                            + " "
                            + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
        }

        /// <summary>
        /// 生成属性字符串
        /// </summary>
        /// <param name="columnModel"></param>
        /// <returns></returns>
        public static string GetStrForColumnListStr(List<ColumnEntity> columnList, string primaryKey)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                string str_isNull = "";
                foreach (var item in columnList)
                {
                    if (item.ColumnName == null)
                        continue;
                    if (item.ColumnName.ToUpper() == primaryKey.ToUpper())
                        continue;
                    str_isNull = " NULL ";
                    if (item.IsNullAuble == "Y")
                    {
                        str_isNull = " NOT NULL ";
                    }
                    //获取数据类型
                    DataTypeEnum enumDT = (DataTypeEnum)Enum.Parse(typeof(DataTypeEnum), "dt_" + item.DataType);
                    switch (enumDT)
                    {
                        case DataTypeEnum.dt_char:
                            sb.Append("   " + item.ColumnName + "    CHAR(" + item.DataLength + ")  " + str_isNull + ", -- " + item.ChinaName + "\n");
                            break;
                        case DataTypeEnum.dt_varchar:
                        case DataTypeEnum.dt_nvarchar:
                            sb.Append("   " + item.ColumnName + "    NVARCHAR(" + item.DataLength + ")  " + str_isNull + ", -- " + item.ChinaName + "\n");
                            break;
                        case DataTypeEnum.dt_int:
                            sb.Append("   " + item.ColumnName + "    INT  " + str_isNull + ", -- " + item.ChinaName + "\n");
                            break;
                        case DataTypeEnum.dt_datetime:
                            sb.Append("   " + item.ColumnName + "    DATETIME  " + str_isNull + ", -- " + item.ChinaName + "\n");
                            break;
                        case DataTypeEnum.dt_bit:
                            sb.Append("   " + item.ColumnName + "    BIT  " + str_isNull + ", -- " + item.ChinaName + "\n");
                            break;
                        case DataTypeEnum.dt_decimal:
                            sb.Append("   " + item.ColumnName + "    DECIMAL" + item.DataLength + " " + str_isNull + ", -- " + item.ChinaName + "\n");
                            break;
                    }
                }
                string resStr = sb.ToString();
                if (resStr != "")
                {
                    resStr = resStr.Substring(0, resStr.Length - 1);
                }
                return resStr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取列注释
        /// </summary>
        /// <param name="columnList"></param>
        /// <returns></returns>
        public static string GetColumnsAnnotation(string tableName, string primaryKey, List<ColumnEntity> columnList)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                foreach (var item in columnList)
                {
                    if (item.ColumnName == null)
                        continue;
                    if (item.ColumnName.ToUpper() == primaryKey.ToUpper())
                        continue;
                    sb.Append("EXEC sys.sp_addextendedproperty @value=N'" + item.ChinaName + "' ,@level2name=N'" + item.ColumnName + "',@level1name=N'" + tableName + "',@name=N'MS_Description',  @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE' ,@level2type=N'COLUMN' \n");
                    sb.Append("GO \n");
                }

                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 生成唯一索引
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="unqiueIndex"></param>
        /// <returns></returns>
        public static string GetUniqueIndex(string tableName, string unqiueIndex)
        {
            if (unqiueIndex == "")
            {
                return "";
            }
            StringBuilder sb = new StringBuilder();
            sb.Append("IF NOT EXISTS(select 1 from sysindexes where id=object_id('" + tableName + "') and name='" + tableName + "_idx')  \n");
            sb.Append("CREATE UNIQUE INDEX \n");
            sb.Append("    " + tableName + "_idx ON " + tableName + "(" + unqiueIndex + ")  \n");
            sb.Append("GO \n");
            return sb.ToString();
        }


    }

}