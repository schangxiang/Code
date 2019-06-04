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
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;

namespace CodeFirstDemo
{
    /*
     * NuGet安装 EnityFrameWork包
     */
    class CodeFirstDbContext : DbContext
    {
        public CodeFirstDbContext()
            : base("name=shaocxdb")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //解决EF动态建库数据库表名变为复数问题,如果不加这段代码，则EF生成的表名都默认变为复数名称
            //如 原本表名叫UserInfo,复数表名是 UserInfoes
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<UserInfo> UserInfo { get; set; }

        public DbSet<OrderInfo> OrderInfo { get; set; }
    }
}
