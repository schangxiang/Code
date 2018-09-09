

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenerateCode_GEBrilliantFactory
{
    /// <summary>
    /// VUE文件
    /// </summary>
    public class VUE_Generate
    {
        public static string CreateText(string TableAlias,string modulelogo,List<ColumnModel> columnNameList)
        {
            var str = TextHelper.ReadText(@"Templete\VUE文件模板.txt");


            str = str.Replace("$el-table-column$", StructStrHelper.GetElTableColumnStr(columnNameList));
            str = str.Replace("$el-col$", StructStrHelper.GetElFormItemStr(columnNameList));
            str = str.Replace("$el-form-itemForSearch$", StructStrHelper.GetElFormItemForSearchStr(columnNameList));

            str = str.Replace("$Modulelogo$", modulelogo);//表别名(他一定要在最后替换)
            str = str.Replace("$TableAlias$", TableAlias);//表别名(他一定要在最后替换)

            return str;
        }
    }
}
