﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace GenerateCode_GEBrilliantFactory
{
    /// <summary>
    /// 构造字符串帮助类
    /// </summary>
    public class StructStrHelper
    {
        /// <summary>
        /// 根据表名获取列集合
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public static List<ColumnModel> GetColumnList(string tableName)
        {
            /*
                string strSql = @"
   SELECT 
Syscolumns.name AS ColumnName,
Systypes.name AS DataType,
isnull(g.[value],'') AS N'Description',
Syscolumns.length AS DataLength
FROM sys.extended_properties as Sysproperties
RIGHT OUTER JOIN
Sysobjects
INNER JOIN
Syscolumns ON Sysobjects.id = Syscolumns.id INNER JOIN
Systypes ON Syscolumns.xtype = Systypes.xtype ON
Sysproperties.major_id = Syscolumns.id AND
Sysproperties.minor_id = Syscolumns.colid
left join sys.extended_properties g 
on Syscolumns.id=g.major_id AND Syscolumns.colid = g.minor_id 
WHERE (Sysobjects.xtype = 'u' OR
Sysobjects.xtype = 'v') AND (Systypes.name <> 'Sysname') AND
(Sysobjects.name = '" + tableName + @"')
ORDER BY Syscolumns.id  
";
               //*/
            string strSql = @" select
col.name as ColumnName,
t.name as DataType,
ep.value as Description,
col.max_length as DataLength,
col.is_nullable as IsNullable,

(
    select top 1 ind.is_primary_key from sys.index_columns ic
    left join sys.indexes ind
    on ic.object_id=ind.object_id
    and ic.index_id=ind.index_id
    and ind.name like 'PK_%'
    where ic.object_id=obj.object_id
    and ic.column_id=col.column_id
) as IsPrimaryKey,
col.Precision,
col.Scale 
from sys.objects obj
inner join sys.columns col
on obj.object_id=col.object_id
left join sys.types t
on t.user_type_id=col.user_type_id
left join sys.extended_properties ep
on ep.major_id=obj.object_id
and ep.minor_id=col.column_id
and ep.name='MS_Description'
where obj.name='" + tableName + "'  ";


            List<ColumnModel> columnList = new List<ColumnModel>();
            try
            {
                string strConn = ConfigurationManager.ConnectionStrings["ConnString"].ToString();
                DataSet ds = SqlHelper.Query(strConn, strSql);
                columnList = DataTableToList(ds.Tables[0]);
            }
            catch
            {
                throw;
            }
            finally
            {
            }
            return columnList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        private static List<ColumnModel> DataTableToList(DataTable dt)
        {
            try
            {
                List<ColumnModel> modelList = new List<ColumnModel>();
                int rowsCount = dt.Rows.Count;
                if (rowsCount > 0)
                {
                    ColumnModel model;
                    for (int n = 0; n < rowsCount; n++)
                    {
                        model = new ColumnModel();
                        if (dt.Rows[n]["Precision"].ToString() != "")
                        {
                            model.Precision = int.Parse(dt.Rows[n]["Precision"].ToString());
                        }
                        if (dt.Rows[n]["Scale"].ToString() != "")
                        {
                            model.Scale = int.Parse(dt.Rows[n]["Scale"].ToString());
                        }
                        model.ColumnName = dt.Rows[n]["ColumnName"].ToString();
                        model.DataLength = dt.Rows[n]["DataLength"].ToString();
                        model.DataType = dt.Rows[n]["DataType"].ToString();
                        model.Description = dt.Rows[n]["Description"].ToString();
                        if (dt.Rows[n]["IsNullable"].ToString() != "")
                        {
                            if ((dt.Rows[n]["IsNullable"].ToString() == "1") || (dt.Rows[n]["IsNullable"].ToString().ToLower() == "true"))
                            {
                                model.IsNullable = true;
                            }
                            else
                            {
                                model.IsNullable = false;
                            }
                        }
                        if (dt.Rows[n]["IsPrimaryKey"].ToString() != "")
                        {
                            if ((dt.Rows[n]["IsPrimaryKey"].ToString() == "1") || (dt.Rows[n]["IsPrimaryKey"].ToString().ToLower() == "true"))
                            {
                                model.IsPrimaryKey = true;
                            }
                            else
                            {
                                model.IsPrimaryKey = false;
                            }
                        }

                        modelList.Add(model);
                    }
                }
                return modelList;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 生成属性字符串
        /// </summary>
        /// <param name="columnModel"></param>
        /// <returns></returns>
        public static string GenerateAttribute(ColumnModel columnModel)
        {
            try
            {
                string attr = columnModel.ColumnName;
                string str_NullFlag = " ";

                //获取数据类型
                DataTypeEnum enumDT = (DataTypeEnum)Enum.Parse(typeof(DataTypeEnum), "dt_" + columnModel.DataType.ToString());
                string attrStr = "";

                attrStr += "        /// <summary>\n";
                attrStr += "        /// " + columnModel.Description + "\n";
                attrStr += "        /// </summary>\n";
                attrStr += "        [DataMember]\n";
                switch (enumDT)
                {
                    case DataTypeEnum.dt_Varchar_Desc:
                    case DataTypeEnum.dt_uniqueidentifier:
                    case DataTypeEnum.dt_Varchar_Ext_Link:
                    case DataTypeEnum.dt_char:
                    case DataTypeEnum.dt_varchar:
                    case DataTypeEnum.dt_nvarchar:
                        attrStr += "        public string" + str_NullFlag + attr + " { get; set; }\n";
                        break;
                    case DataTypeEnum.dt_datetime:
                        if (columnModel.IsNullable) { str_NullFlag = "? "; }
                        attrStr += "        public DateTime" + str_NullFlag + attr + " { get; set; }\n";
                        break;
                    case DataTypeEnum.dt_int:
                        if (columnModel.IsNullable) { str_NullFlag = "? "; }
                        attrStr += "        public int" + str_NullFlag + attr + " { get; set; }\n";
                        break;
                    case DataTypeEnum.dt_bigint:
                        if (columnModel.IsNullable) { str_NullFlag = "? "; }
                        attrStr += "        public long" + str_NullFlag + attr + " { get; set; }\n";
                        break;
                    case DataTypeEnum.dt_decimal:
                        if (columnModel.IsNullable) { str_NullFlag = "? "; }
                        attrStr += "        public decimal" + str_NullFlag + attr + " { get; set; }\n";
                        break;
                    case DataTypeEnum.dt_bit:
                        if (columnModel.IsNullable) { str_NullFlag = "? "; }
                        attrStr += "        public bool" + str_NullFlag + attr + " { get; set; }\n";
                        break;
                }
                attrStr += "\n";//最后是加一个空格
                return attrStr;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// 获取查询列字符串
        /// </summary>
        /// <param name="columnNameList">列集合</param>
        /// <param name="tableAlias">表别名</param>
        /// <returns>字符串，格式如 列1，列2，列3</returns>
        public static string GetQueryColumnsStr(List<ColumnModel> columnNameList, string tableAlias = null)
        {
            StringBuilder selectSql = new StringBuilder();
            tableAlias = tableAlias == null ? "" : (tableAlias + ".");
            ColumnModel columnModel = null;
            string attrColumnName = null;
            for (int i = 0; i < columnNameList.Count; i++)
            {
                columnModel = columnNameList[i];
                attrColumnName = columnModel.ColumnName;
                if (i == (columnNameList.Count - 1))
                    selectSql.Append("         " + tableAlias + attrColumnName + "\n");
                else
                    selectSql.Append("         " + tableAlias + attrColumnName + ",\n");
            }
            return selectSql.ToString();
        }

        /// <summary>
        /// 获取列字符串(不包括ID) 【插入用】
        /// </summary>
        /// <param name="columnNameList">列集合</param>
        /// <param name="prefix">@前缀</param>
        /// <returns>字符串，格式如 列1，列2，列3</returns>
        public static string GetColumnsStrNoIDForAdd(List<ColumnModel> columnNameList, string prefix)
        {
            StringBuilder selectSql = new StringBuilder();
            ColumnModel columnModel = null;
            string description = "";
            for (int i = 0; i < columnNameList.Count; i++)
            {
                columnModel = columnNameList[i];
                description = "   --    " + columnModel.Description;
                string attrColumnName = columnModel.ColumnName;
                if (attrColumnName.ToUpper() == "ID")
                    continue;
                if (i == (columnNameList.Count - 1))
                    selectSql.Append("         " + prefix + attrColumnName + description + "\n");
                else
                    selectSql.Append("         " + prefix + attrColumnName + "," + description + "\n");
            }
            return selectSql.ToString();
        }

        /// <summary>
        /// 获取列字符串(不包括ID) 【生成InsertSQL文本使用】
        /// </summary>
        /// <param name="columnNameList">列集合</param>
        /// <returns>字符串，格式如 列1，列2，列3</returns>
        public static string GetColumnsStrNoIDForInsertSQL(List<ColumnModel> columnNameList)
        {
            StringBuilder selectSql = new StringBuilder();
            ColumnModel columnModel = null;
            string description = "";
            string defaultValue = "";
            for (int i = 0; i < columnNameList.Count; i++)
            {
                columnModel = columnNameList[i];
                description = "   --    " + columnModel.Description;
                string attrColumnName = columnModel.ColumnName;
                if (attrColumnName.ToUpper() == "ID")
                    continue;
                DataTypeEnum myDataType = (DataTypeEnum)Enum.Parse(typeof(DataTypeEnum), "dt_" + columnModel.DataType);
                switch (myDataType)
                {
                    case DataTypeEnum.dt_bigint:
                    case DataTypeEnum.dt_int:
                        defaultValue = "0";
                        break;
                    case DataTypeEnum.dt_decimal:
                        defaultValue = "0.00";
                        break;
                    case DataTypeEnum.dt_datetime:
                        defaultValue = "getdate()";
                        break;
                    case DataTypeEnum.dt_bit:
                        defaultValue = "0";
                        break;
                    default:
                        defaultValue = "''";
                        break;
                }
                if (i == (columnNameList.Count - 1))
                    selectSql.Append("         " + defaultValue + description + "\n");
                else
                    selectSql.Append("         " + defaultValue + "," + description + "\n");
            }
            return selectSql.ToString();
        }

        /// <summary>
        /// 获取增加使用的存储过程参数列字符串（要排除id）
        /// </summary>
        /// <param name="columnNameList">列集合</param>
        /// <returns>字符串，@processCardNumber nvarchar(50),@partNumber nvarchar(50),
        ///</returns>
        public static string GetInputParamColumnsStrForAdd(List<ColumnModel> columnNameList)
        {
            StringBuilder sql = new StringBuilder();
            ColumnModel columnModel = null;
            for (int i = 0; i < columnNameList.Count; i++)
            {
                columnModel = columnNameList[i];
                string attrColumnName = columnModel.ColumnName;
                if (attrColumnName.ToUpper() == "ID")
                    continue;

                var fuhao = ",";
                if (i == columnNameList.Count - 1)
                {
                    fuhao = "";
                }
                DataTypeEnum enumDT = (DataTypeEnum)Enum.Parse(typeof(DataTypeEnum), "dt_" + columnModel.DataType.ToString());
                switch (enumDT)
                {
                    case DataTypeEnum.dt_char:
                    case DataTypeEnum.dt_varchar:
                    case DataTypeEnum.dt_Varchar_Desc:
                    case DataTypeEnum.dt_uniqueidentifier:
                    case DataTypeEnum.dt_Varchar_Ext_Link:
                    case DataTypeEnum.dt_nvarchar:
                        var dataLength = columnModel.DataLength;
                        if (dataLength == "-1")
                        {
                            dataLength = "max";
                        }
                        sql.Append("@" + attrColumnName + "  " + columnModel.DataType + "(" + dataLength + ") " + fuhao + "\n");
                        break;
                    case DataTypeEnum.dt_bigint:
                    case DataTypeEnum.dt_int:
                    case DataTypeEnum.dt_datetime:
                    case DataTypeEnum.dt_bit:
                        sql.Append("@" + attrColumnName + "  " + columnModel.DataType + " " + fuhao + "\n");
                        break;
                    case DataTypeEnum.dt_decimal:
                        sql.Append("@" + attrColumnName + "  " + columnModel.DataType
                            + "(" + columnModel.Precision.ToString() + "," + columnModel.Scale.ToString() + ")  " + fuhao + "\n");
                        break;
                    default:
                        break;
                }
            }
            return sql.ToString();
        }


        /// <summary>
        /// 获取更新使用的存储过程参数列字符串（要排除id）
        /// </summary>
        /// <param name="columnNameList">列集合</param>
        /// <returns>字符串，@processCardNumber nvarchar(50),@partNumber nvarchar(50),
        ///</returns>
        public static string GetInputParamColumnsStrForUpdate(List<ColumnModel> columnNameList)
        {
            //构造新的List
            columnNameList = GetNewColumnModelListForUpdateParameter(columnNameList);

            StringBuilder sql = new StringBuilder();
            ColumnModel columnModel = null;
            string attrColumnName = null;
            for (int i = 0; i < columnNameList.Count; i++)
            {
                columnModel = columnNameList[i];
                attrColumnName = columnModel.ColumnName;

                var fuhao = ",";
                if (i == columnNameList.Count - 1)
                {
                    fuhao = "";
                }
                DataTypeEnum enumDT = (DataTypeEnum)Enum.Parse(typeof(DataTypeEnum), "dt_" + columnModel.DataType.ToString());
                switch (enumDT)
                {
                    case DataTypeEnum.dt_char:
                    case DataTypeEnum.dt_varchar:
                    case DataTypeEnum.dt_Varchar_Desc:
                    case DataTypeEnum.dt_uniqueidentifier:
                    case DataTypeEnum.dt_Varchar_Ext_Link:
                    case DataTypeEnum.dt_nvarchar:
                        var dataLength = columnModel.DataLength;
                        if (dataLength == "-1")
                        {
                            dataLength = "max";
                        }
                        sql.Append("@" + attrColumnName + "  " + columnModel.DataType + "(" + dataLength + ") " + fuhao + "\n");
                        break;
                    case DataTypeEnum.dt_bigint:
                    case DataTypeEnum.dt_int:
                    case DataTypeEnum.dt_datetime:
                    case DataTypeEnum.dt_bit:
                        sql.Append("@" + attrColumnName + "  " + columnModel.DataType + " " + fuhao + "\n");
                        break;
                    case DataTypeEnum.dt_decimal:
                        sql.Append("@" + attrColumnName + "  " + columnModel.DataType
                            + "(" + columnModel.Precision.ToString() + "," + columnModel.Scale.ToString() + ")  " + fuhao + "\n");
                        break;
                    default:
                        break;
                }
            }
            return sql.ToString();
        }

        /// <summary>
        /// 生成赋值sql字符串，用于修改
        /// </summary>
        /// <param name="columnNameList"></param>
        /// <param name="primaryKey"></param>
        /// <returns></returns>
        public static string GetCols_AssignmentStrForUpdate(List<ColumnModel> columnNameList)
        {
            //构造新的List
            columnNameList = GetNewColumnModelListForUpdateParameter(columnNameList);

            StringBuilder sql = new StringBuilder();
            ColumnModel columnModel = null;
            string attrColumnName = null;
            for (int i = 0; i < columnNameList.Count; i++)
            {
                columnModel = columnNameList[i];
                attrColumnName = columnModel.ColumnName;
                if (columnModel.IsPrimaryKey)
                    continue;

                if (i == columnNameList.Count - 1)
                {
                    sql.Append(attrColumnName + "=@" + attrColumnName + " \n");
                }
                else
                {
                    sql.Append(attrColumnName + "=@" + attrColumnName + ",\n");
                }

            }
            return sql.ToString();
        }

        /// <summary>
        /// 构造新增SQL的参数ForDAL文件
        /// </summary>
        /// <param name="columnNameList"></param>
        /// <returns></returns>
        public static string GetParameterForAddDAL(List<ColumnModel> columnNameList)
        {
            //构造新的List
            List<ColumnModel> newList = new List<ColumnModel>();
            ColumnModel columnModel = null;
            for (int i = 0; i < columnNameList.Count; i++)
            {
                columnModel = columnNameList[i];
                if (columnModel.IsPrimaryKey)
                {//新增的时候，不用主键
                    continue;
                }
                newList.Add(columnModel);
            }

            StringBuilder paramSql = new StringBuilder();
            paramSql.Append("SqlParameter[] parameters = { " + "\n");
            for (int i = 0; i < newList.Count; i++)
            {
                paramSql.Append(GetSqlParameterStr(newList[i]));
            }
            paramSql.Append("              param_id \n");
            paramSql.Append("            };\n");

            for (int i = 0; i < newList.Count; i++)
            {
                paramSql.Append("            parameters[" + i.ToString() + "].Value = model." + newList[i].ColumnName + ";\n");
            }

            return paramSql.ToString();
        }

        /// <summary>
        /// 构造更新SQL的参数ForDAL文件
        /// </summary>
        /// <param name="columnNameList"></param>
        /// <returns></returns>
        public static string GetParameterForUpdateDAL(List<ColumnModel> columnNameList)
        {
            //构造新的List
            columnNameList = GetNewColumnModelListForUpdateParameter(columnNameList);


            StringBuilder paramSql = new StringBuilder();
            paramSql.Append("SqlParameter[] parameters = { " + "\n");
            string firstParam = "", secondParam = "";
            ColumnModel columnModel = null;
            for (int i = 0; i < columnNameList.Count; i++)
            {
                columnModel = columnNameList[i];
                firstParam += GetSqlParameterStr(columnModel);
                secondParam += "            parameters[" + i.ToString() + "].Value = model." + columnModel.ColumnName + ";\n";
            }
            paramSql.Append(firstParam);
            paramSql.Append("            };\n");
            paramSql.Append(secondParam);

            return paramSql.ToString();
        }

        /// <summary>
        /// 获取最新的列List集合ForUpdate(去掉 creator和createTime)
        /// </summary>
        /// <param name="columnNameList"></param>
        /// <returns></returns>
        private static List<ColumnModel> GetNewColumnModelListForUpdateParameter(List<ColumnModel> columnNameList)
        {
            //构造新的List
            List<ColumnModel> newList = new List<ColumnModel>();
            ColumnModel columnModel = null;
            for (int i = 0; i < columnNameList.Count; i++)
            {//需要去掉 创建人和创建时间
                columnModel = columnNameList[i];
                if (columnModel.ColumnName.ToUpper() == "creator".ToUpper()
                    || columnModel.ColumnName.ToUpper() == "createTime".ToUpper())
                {
                    continue;
                }
                newList.Add(columnModel);
            }
            return newList;
        }


        /// <summary>
        /// 获取最新的列List集合ForUpdate(去掉 id delFlag,creator和createTime)
        /// </summary>
        /// <param name="columnNameList"></param>
        /// <returns></returns>
        private static List<ColumnModel> GetNewColumnModelListForVUESerachOrEdit(List<ColumnModel> columnNameList)
        {
            //构造新的List
            List<ColumnModel> newList = new List<ColumnModel>();
            ColumnModel columnModel = null;
            for (int i = 0; i < columnNameList.Count; i++)
            {//需要去掉 创建人和创建时间
                columnModel = columnNameList[i];
                if (columnModel.ColumnName.ToUpper() == "creator".ToUpper()
                    || columnModel.ColumnName.ToUpper() == "createTime".ToUpper()
                    || columnModel.ColumnName.ToUpper() == "lastModifier".ToUpper()
                    || columnModel.ColumnName.ToUpper() == "lastModifyTime".ToUpper()
                    || columnModel.ColumnName.ToUpper() == "delFlag".ToUpper()
                    || columnModel.ColumnName.ToUpper() == "id".ToUpper()
                    )
                {
                    continue;
                }
                newList.Add(columnModel);
            }
            return newList;
        }


        private static string GetSqlParameterStr(ColumnModel columnModel)
        {
            string str = "              new SqlParameter(\"@" + columnModel.ColumnName + "\",";
            try
            {
                string attr = columnModel.ColumnName;
                //获取数据类型
                DataTypeEnum enumDT = (DataTypeEnum)Enum.Parse(typeof(DataTypeEnum), "dt_" + columnModel.DataType.ToString());
                switch (enumDT)
                {
                    case DataTypeEnum.dt_char:
                        str += "SqlDbType.NChar," + columnModel.DataLength.ToString();
                        break;
                    case DataTypeEnum.dt_varchar:
                        str += "SqlDbType.VarChar," + columnModel.DataLength.ToString();
                        break;
                    case DataTypeEnum.dt_Varchar_Desc:
                    case DataTypeEnum.dt_uniqueidentifier:
                    case DataTypeEnum.dt_Varchar_Ext_Link:
                    case DataTypeEnum.dt_nvarchar:
                        str += "SqlDbType.NVarChar," + columnModel.DataLength.ToString();
                        break;
                    case DataTypeEnum.dt_datetime:
                        str += "SqlDbType.DateTime";
                        break;
                    case DataTypeEnum.dt_int:
                        str += "SqlDbType.Int," + columnModel.DataLength.ToString();
                        break;
                    case DataTypeEnum.dt_bigint:
                        str += "SqlDbType.BigInt," + columnModel.DataLength.ToString();
                        break;
                    case DataTypeEnum.dt_decimal:
                        str += "SqlDbType.Decimal," + columnModel.DataLength.ToString();
                        break;
                    case DataTypeEnum.dt_bit:
                        str += "SqlDbType.Bit," + columnModel.DataLength.ToString();
                        break;
                }
                str += "),\n";//最后是加一个回车
                return str;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 生成赋值实体类的字符串
        /// </summary>
        /// <param name="columnModelList"></param>
        /// <returns></returns>
        public static string GetToModelStr(List<ColumnModel> columnModelList)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                foreach (var columnModel in columnModelList)
                {
                    string attr = columnModel.ColumnName;
                    //获取数据类型
                    DataTypeEnum enumDT = (DataTypeEnum)Enum.Parse(typeof(DataTypeEnum), "dt_" + columnModel.DataType.ToString());
                    switch (enumDT)
                    {
                        case DataTypeEnum.dt_char:
                        case DataTypeEnum.dt_varchar:
                        case DataTypeEnum.dt_Varchar_Desc:
                        case DataTypeEnum.dt_uniqueidentifier:
                        case DataTypeEnum.dt_Varchar_Ext_Link:
                        case DataTypeEnum.dt_nvarchar:
                            sb.Append("model." + columnModel.ColumnName.ToString() + "=dataRow[\"" + columnModel.ColumnName.ToString() + "\"].ToString();\n");
                            break;
                        case DataTypeEnum.dt_datetime:
                            sb.Append("if (dataRow[\"" + columnModel.ColumnName.ToString() + "\"].ToString() != \"\") \n");
                            sb.Append("{ \n");
                            sb.Append("   model." + columnModel.ColumnName.ToString() + " = DateTime.Parse(dataRow[\"" + columnModel.ColumnName.ToString() + "\"].ToString()); \n");
                            sb.Append("} \n");
                            break;
                        case DataTypeEnum.dt_int:
                        case DataTypeEnum.dt_bigint:
                            sb.Append("if (dataRow[\"" + columnModel.ColumnName.ToString() + "\"].ToString() != \"\") \n");
                            sb.Append("{ \n");
                            sb.Append("   model." + columnModel.ColumnName.ToString() + " = int.Parse(dataRow[\"" + columnModel.ColumnName.ToString() + "\"].ToString()); \n");
                            sb.Append("} \n");
                            break;
                        case DataTypeEnum.dt_decimal:
                            sb.Append("if (dataRow[\"" + columnModel.ColumnName.ToString() + "\"].ToString() != \"\") \n");
                            sb.Append("{ \n");
                            sb.Append("   model." + columnModel.ColumnName.ToString() + " = decimal.Parse(dataRow[\"" + columnModel.ColumnName.ToString() + "\"].ToString()); \n");
                            sb.Append("} \n");
                            break;
                        case DataTypeEnum.dt_bit:
                            sb.Append("if (dataRow[\"" + columnModel.ColumnName.ToString() + "\"].ToString() != \"\") \n");
                            sb.Append("{ \n");

                            sb.Append(" if ((dataRow[\"" + columnModel.ColumnName.ToString() + "\"].ToString() == \"1\") || (dataRow[\"" + columnModel.ColumnName.ToString() + "\"].ToString().ToLower() == \"true\")) \n");
                            sb.Append("{ \n");
                            sb.Append("   model." + columnModel.ColumnName.ToString() + " = true; \n");
                            sb.Append("} \n");
                            sb.Append("else \n");
                            sb.Append("{ \n");
                            sb.Append("   model." + columnModel.ColumnName.ToString() + " = false; \n");
                            sb.Append("} \n");

                            sb.Append("} \n");
                            break;
                    }
                }

                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #region WCF层验证文本

        /// <summary>
        /// 生成需要验证不为空的字符串
        /// </summary>
        /// <param name="columnModelList"></param>
        /// <returns></returns>
        public static string GetValidateEmptyStr(List<ColumnModel> columnModelList)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                sb.Append("                List<ColumnsModel> columnsList = new List<ColumnsModel>() { \n");
                foreach (var columnModel in columnModelList)
                {

                    string attr = columnModel.ColumnName;
                    //获取数据类型
                    DataTypeEnum enumDT = (DataTypeEnum)Enum.Parse(typeof(DataTypeEnum), "dt_" + columnModel.DataType.ToString());
                    switch (enumDT)
                    {
                        case DataTypeEnum.dt_char:
                        case DataTypeEnum.dt_varchar:
                        case DataTypeEnum.dt_Varchar_Desc:
                        case DataTypeEnum.dt_uniqueidentifier:
                        case DataTypeEnum.dt_Varchar_Ext_Link:
                        case DataTypeEnum.dt_nvarchar:
                            if (!columnModel.IsNullable)
                            {
                                sb.Append("                     new ColumnsModel(){ ChinaName=\"" + columnModel.Description + "\",PropertyName=\"" + columnModel.ColumnName + "\" },\n");
                            }
                            break;
                        case DataTypeEnum.dt_datetime:
                            if (!columnModel.IsNullable)
                            {//日期必输
                                sb.Append("                     new ColumnsModel(){ ChinaName=\"" + columnModel.Description + "\",PropertyName=\"" + columnModel.ColumnName + "\",DataType=typeof(DateTime) },\n");
                            }
                            else
                            {//日期不必输 
                                sb.Append("                     new ColumnsModel(){ ChinaName=\"" + columnModel.Description + "\",PropertyName=\"" + columnModel.ColumnName + "\",DataType=typeof(DateTime),IsNullable=true },\n");
                            }
                            break;
                        default:
                            break;
                    }

                }
                sb.Append("                };\n");
                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region VUE文件

        /// <summary>
        /// 获取VUE el-table-column
        /// </summary>
        /// <param name="columnModelList"></param>
        /// <returns></returns>
        public static string GetElTableColumnStr(List<ColumnModel> columnModelList)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                List<ColumnModel> newList=GetNewColumnModelListForVUESerachOrEdit(columnModelList);
                foreach (var columnModel in newList)
                {
                    sb.Append("          <el-table-column prop=\"" + columnModel.ColumnName + "\" label=\"" + columnModel.Description + "\" > \n");
                    sb.Append("          </el-table-column> \n");
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// 获取VUE el-form-item
        /// </summary>
        /// <param name="columnModelList"></param>
        /// <returns></returns>
        public static string GetElFormItemStr(List<ColumnModel> columnModelList)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                List<ColumnModel> newList = GetNewColumnModelListForVUESerachOrEdit(columnModelList);
                foreach (var columnModel in newList)
                {
                    sb.Append("              <el-col :span=\"12\"> \n");

                    sb.Append("                <el-form-item label=\"" + columnModel.Description + "\" prop=\"" + columnModel.ColumnName + "\" :rules=\"[{ required: true, message: '" + columnModel.Description + "不能为空'}]\"> \n");
                    sb.Append("                  <el-input v-model=\"$TableAlias$." + columnModel.ColumnName + "\"></el-input> \n");
                    sb.Append("                </el-form-item> \n");

                    sb.Append("              </el-col> \n");
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// 获取VUE el-form-item 查询用
        /// </summary>
        /// <param name="columnModelList"></param>
        /// <returns></returns>
        public static string GetElFormItemForSearchStr(List<ColumnModel> columnModelList)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                List<ColumnModel> newList = GetNewColumnModelListForVUESerachOrEdit(columnModelList);
                foreach (var columnModel in newList)
                {
                    sb.Append("          <el-form-item label=\"" + columnModel.Description + "\"> \n");

                    sb.Append("<el-input v-model=\"serachObj." + columnModel.ColumnName + "\" placeholder=\"请输入" + columnModel.Description + "\"></el-input>\n");

                    sb.Append("          </el-form-item> \n");
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion



        /// <summary>
        /// 生成Where查询条件的字符串
        /// </summary>
        /// <param name="columnModelList"></param>
        /// <returns></returns>
        public static string GetStrForWhereQuery(List<ColumnModel> columnModelList)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                foreach (var columnModel in columnModelList)
                {
                    string attr = columnModel.ColumnName;
                    //获取数据类型
                    DataTypeEnum enumDT = (DataTypeEnum)Enum.Parse(typeof(DataTypeEnum), "dt_" + columnModel.DataType.ToString());
                    switch (enumDT)
                    {
                        case DataTypeEnum.dt_char:
                        case DataTypeEnum.dt_varchar:
                        case DataTypeEnum.dt_Varchar_Desc:
                        case DataTypeEnum.dt_uniqueidentifier:
                        case DataTypeEnum.dt_Varchar_Ext_Link:
                        case DataTypeEnum.dt_nvarchar:
                            sb.Append("                if (!string.IsNullOrEmpty(queryModel." + columnModel.ColumnName + ")) \n");
                            sb.Append("                { \n");
                            sb.Append("                    strWhere += \" $TableAlias$." + columnModel.ColumnName + " LIKE '%\" + queryModel." + columnModel.ColumnName + " + \"%',\"; \n");
                            sb.Append("                } \n");
                            break;
                        default:
                            break;
                    }
                }
                sb.Append("if (!string.IsNullOrEmpty(strWhere)) \n");
                sb.Append("                    strWhere = strWhere.Substring(0, strWhere.Length - 1); \n");
                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 通过列名查找列对象
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="columnModelList"></param>
        /// <returns></returns>
        public static ColumnModel GetColumnModelByName(string columnName, List<ColumnModel> columnModelList)
        {
            foreach (var item in columnModelList)
            {
                if (item.ColumnName.ToUpper() == columnName.ToUpper())
                {
                    return item;
                }
            }
            return null;
        }
    }
}
