using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Configuration;
using Newtonsoft.Json;

namespace Dapper学习
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["shaocxdb"].ConnectionString;
            IDbConnection conn = new SqlConnection(connectionString);

            #region Insert操作
            /*
            string insertSql = " INSERT INTO dbo.BAS_NAME(ID,NAME,OTHER,DATE) VALUES(@ID,@NAME,@OTHER,@DATE) ";
            BAS_NAME nameInfo = new BAS_NAME()
            {
                ID = 0,
                DATE = DateTime.Now,
                NAME = "小王",
                OTHER = string.Empty
            };
            var result = conn.Execute(insertSql, nameInfo);

            Console.WriteLine("Insert操作结果:"+result.ToString());
            Console.ReadKey();

            //*/
            #endregion

            #region Update操作
            /*
            BAS_NAME nameInfo = new BAS_NAME()
            {
                ID = 0,
                NAME = "小王222",
                OTHER = "333",
                DATE = DateTime.Now
            };
            string upDateSql = " UPDATE dbo.BAS_NAME SET NAME = @NAME,OTHER= @OTHER,[DATE] = @DATE WHERE ID = @ID";
            var result = conn.Execute(upDateSql, nameInfo);

            Console.WriteLine("Update操作结果:" + result.ToString());
            Console.ReadKey();
            //*/
            #endregion

            #region Select操作
            /*
            string selectSql = "SELECT * FROM BAS_NAME";
            List<BAS_NAME> basNameList = conn.Query<BAS_NAME>(selectSql).ToList();

            Console.WriteLine("Select操作结果1:" +JsonConvert.SerializeObject(basNameList));

            selectSql = "SELECT * FROM BAS_NAME WHERE ID = @ID";
            basNameList = conn.Query<BAS_NAME>(selectSql, new { ID = 1 }).ToList();
            Console.WriteLine("Select操作结果2:" + JsonConvert.SerializeObject(basNameList));
            Console.ReadKey();
            //*/

            #endregion

            #region Delete操作

            var result = conn.Execute("DELETE FROM dbo.BAS_NAME WHERE ID = @ID", new { ID = 0 });
            Console.WriteLine("Delete操作结果:" + result.ToString());
            Console.ReadKey();
            #endregion

        }
    }
}
