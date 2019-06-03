/*
 * CLR Version：4.0.30319.42000
 * NameSpace：CodeFirstDemo
 * FileName：CodeFirstDbContext
 * CurrentYear：2019
 * CurrentTime：2019/6/3 16:34:37
 * Author：shaocx
 *
 * <更新记录>
 * ver 1.0.0.0   2019/6/3 16:34:37 新規作成 (by shaocx)
 */


using CodeFirstDemo.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    class CodeFirstDbContext : DbContext
    {
        public CodeFirstDbContext()
            : base("name=数据库连接字符串")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<UserInfo> UserInfo { get; set; }

        public DbSet<OrderInfo> OrderInfo { get; set; }
    }
}
