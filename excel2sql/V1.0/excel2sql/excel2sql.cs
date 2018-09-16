using GenerateModel;
using Maticsoft.Model;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1;

namespace Excel2SQL
{
    public static class Excel2SQL
    {
        /// <summary>
        /// 生成SYS11_PrintInfo表的SQL语句
        /// </summary>
        /// <returns></returns>
        public static string GetInsertSQLForCodeItems(List<UdtWip_CodeItems> codeItemList)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                List<udtWip_CodeSets> codeSetList = Common.GetCodeSetList(codeItemList);
                foreach (var item in codeSetList)
                {
                    if (string.IsNullOrEmpty(item.code))
                        continue;
                    sb.Append(" DELETE udtWip_CodeSets WHERE code='" + item.code + "'; \n");
                    sb.Append(" DELETE udtWip_CodeItems WHERE setCode='" + item.code + "'; \n");
                    sb.Append(" GO \n");
                    sb.Append("  INSERT INTO udtWip_CodeSets ([code], [name],[note], [delFlag], [creator], [createTime], [lastModifier], [lastModifyTime]) ");
                    sb.Append("	VALUES(");
                    sb.Append("'" + item.code + "',");
                    sb.Append("'" + item.name + "',");
                    sb.Append("'" + item.note + "',");
                    sb.Append("'0',");
                    sb.Append("'sys',");
                    sb.Append("getdate(),");
                    sb.Append("'sys',");
                    sb.Append("getdate()");
                    sb.Append("	) \n");
                    sb.Append(" GO \n");
                }
                sb.Append(" GO \n");
                foreach (var entity in codeItemList)
                {
                    if (string.IsNullOrEmpty(entity.setCode))
                        continue;
                    sb.Append(@"INSERT INTO udtWip_CodeItems(setCode,code,name,note,delFlag,Creator, CreateTime, LastModifier, LastModifyTime  	)");
                    sb.Append("	VALUES(");
                    sb.Append("'" + entity.setCode + "',");
                    sb.Append("'" + entity.code + "',");
                    sb.Append("'" + entity.name + "',");
                    sb.Append("'" + entity.note + "',");
                    sb.Append("'0',");
                    sb.Append("'sys',");
                    sb.Append("getdate(),");
                    sb.Append("'sys',");
                    sb.Append("getdate()");
                    sb.Append("	) \n");
                    sb.Append(" GO \n");
                }
                var bb = sb.ToString();
                return bb;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
