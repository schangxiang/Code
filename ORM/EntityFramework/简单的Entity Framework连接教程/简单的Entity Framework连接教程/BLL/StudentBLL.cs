/*
 * CLR Version：4.0.30319.42000
 * NameSpace：简单的Entity_Framework连接教程.BLL
 * FileName：StudentBLL
 * CurrentYear：2019
 * CurrentTime：2019/6/2 7:29:41
 * Author：shaocx
 *
 * <更新记录>
 * ver 1.0.0.0   2019/6/2 7:29:41 新規作成 (by shaocx)
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using 简单的Entity_Framework连接教程.DAL;
using 简单的Entity_Framework连接教程.Models;

namespace 简单的Entity_Framework连接教程.BLL
{
    public class StudentBLL
    {
        //创建了一个DbContext对象命名为db.
        StudentDbContext db = new StudentDbContext();

        public void AddStudent()
        {
            Student s = new Student();
            s.ID = 1;
            s.Name = "王小二";

            //利用Add方法把student添加进入上下文
            db.students.Add(s);
            //利用SaveChanges方法把更改的上下文存入数据库
            db.SaveChanges();
        }
    }
}