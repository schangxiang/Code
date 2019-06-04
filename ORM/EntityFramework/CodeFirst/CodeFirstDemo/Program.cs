using CodeFirstDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeFirstDbContext dbContext = new CodeFirstDbContext();

            dbContext.Database.CreateIfNotExists();

            #region 增加

            /*
            UserInfo user = new UserInfo();
            user.SName = "shaocx";

            dbContext.UserInfo.Add(user);//告诉EF咱们对上面的实体做一个插入操作
            dbContext.SaveChanges();//告诉上下文把实体的变化保存到数据库中
            //*/

            #endregion

            #region 修改

            /*
            UserInfo modified = new UserInfo();
            modified.SName = "我是猪";
            modified.ID = 1;

            dbContext.Entry<UserInfo>(modified).State = System.Data.Entity.EntityState.Modified;
            //单独指定要修改的列
            //dbContext.Entry<UserInfo>(modified).Property<string>(u => u.SName).IsModified = true;

            dbContext.SaveChanges();

            //*/


            #endregion

            #region 删除

            /*

            UserInfo del = new UserInfo();
            del.ID = 1;

            dbContext.Entry<UserInfo>(del).State = System.Data.Entity.EntityState.Deleted;

            dbContext.SaveChanges();

            //*/

            #endregion


            #region 查询

            var temp = from u in dbContext.UserInfo
                       where u.ID > 0
                       //where u.ID>0 && u.SName.Contains("shaocx") && u.SName.StartsWith("S")
                       select u;
            foreach (var userInfo in temp)
            {
                Console.WriteLine(userInfo.ID + "  " + userInfo.SName);
            }


            //两种延迟加载

            #region 1、第一种延迟加载 用到的时候才去加载
            var temp2 = from u in temp
                        where u.ID > 0
                        select u;

            foreach (var userInfo in temp2)
            {
                Console.WriteLine(userInfo.ID + "  " + userInfo.SName);
            }

            #endregion

            #region 2、第二种延迟加载，

            foreach (var userInfo in temp)
            {
                //如果userInfo.OrderInfo为Null的情况，则EF会每次循环前加载OrderInfo数据
                foreach (var order in userInfo.OrderInfo)
                {
                    Console.WriteLine(order.id + "  " + order.name);
                }
            }

            #endregion

            #endregion



            Console.WriteLine("ok....");

            Console.ReadKey();

        }
    }
}
