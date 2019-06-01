/*
 * CLR Version：4.0.30319.42000
 * NameSpace：简单的Entity_Framework连接教程.Models
 * FileName：Student
 * CurrentYear：2019
 * CurrentTime：2019/6/2 7:21:42
 * Author：shaocx
 *
 * <更新记录>
 * ver 1.0.0.0   2019/6/2 7:21:42 新規作成 (by shaocx)
 */


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace 简单的Entity_Framework连接教程.Models
{
    public class Student
    {
        /*
         * 添加实体类属性时，手动设置[Key]是个好习惯，
         * 不设置[Key]主键的话，程序默认主键为带有id的属性。每个实体类必须有Key。
         */
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}