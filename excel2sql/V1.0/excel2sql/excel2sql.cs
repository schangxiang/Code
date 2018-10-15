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
                    sb.Append("------------------------------------  \n");
                    sb.Append("--用途：初始化码表["+item.name+"]  \n");
                    sb.Append("--说明：预制码表[" + item.name + "]数据   \n");
                    sb.Append("--作者: shaocx   \n");
                    sb.Append("--时间："+Common.GetCurDate()+"   \n");
                    sb.Append("------------------------------------   \n");
                    sb.Append("DELETE udtWip_CodeSets WHERE code='" + item.code + "'; \n");
                    sb.Append("DELETE udtWip_CodeItems WHERE setCode='" + item.code + "'; \n");
                    sb.Append("GO \n");
                    sb.Append("INSERT INTO udtWip_CodeSets ([code], [name],[note], [delFlag], [creator], [createTime], [lastModifier], [lastModifyTime])");
                    sb.Append(" VALUES(");
                    sb.Append(" N'" + item.code + "',");
                    sb.Append(" N'" + item.name + "',");
                    sb.Append(" N'" + item.note + "',");
                    sb.Append(" '0',");
                    sb.Append(" N'sys',");
                    sb.Append(" getdate(),");
                    sb.Append(" N'sys',");
                    sb.Append(" getdate() ); \n");

                    sb.Append("GO \n");
                    //生成项
                    foreach (var entity in codeItemList)
                    {
                        if (string.IsNullOrEmpty(entity.setCode) || entity.setCode != item.code)
                            continue;
                        sb.Append(@"INSERT INTO udtWip_CodeItems ([code], [name], [setCode],[note], [delFlag], [creator], [createTime], [lastModifier], [lastModifyTime])");
                        sb.Append(" VALUES(");
                        sb.Append(" N'" + entity.code + "',");
                        sb.Append(" N'" + entity.name + "',");
                        sb.Append(" N'" + entity.setCode + "',");
                        sb.Append(" N'" + entity.note + "',");
                        sb.Append(" '0',");
                        sb.Append(" N'sys',");
                        sb.Append(" getdate(),");
                        sb.Append(" N'sys',");
                        sb.Append(" getdate() ); \n");
                    }
                    sb.Append("GO \n\n\n\n");
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
