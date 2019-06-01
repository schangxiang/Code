/*
 * CLR Version：4.0.30319.42000
 * NameSpace：简单的Entity_Framework连接教程.DAL
 * FileName：StudentDbContext
 * CurrentYear：2019
 * CurrentTime：2019/6/2 7:25:03
 * Author：shaocx
 *
 * <更新记录>
 * ver 1.0.0.0   2019/6/2 7:25:03 新規作成 (by shaocx)
 */


using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using 简单的Entity_Framework连接教程.Models;

namespace 简单的Entity_Framework连接教程.DAL
{
    /*
     * 为实体类创建一个数据库上下文类DbContext
     */
    public class StudentDbContext : System.Data.Entity.DbContext
    {
        public StudentDbContext()
            : base("Conn")//构造函数的作用是定义一个连接数据库的字符串"Conn"。
        {

        }

        //一个用来操作的数据库的上下文，被DbSet定义的students。
        //被DbSet定义的students就是我们用来操作数据库的上下文，里面存在了常用的Add,Delete,Save等增删改查方法。
        public DbSet<Student> students { get; set; }
    }
}