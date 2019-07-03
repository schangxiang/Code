using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ查询
{
    class Program
    {
        static void Main(string[] args)
        {

            #region LINQ TO  ARRAY

            string[] array = new string[] { "Juan", "Tom", "Jonh", "Anndy" };

            //查询以J开头的名称

            var result = from n in array
                         where n.StartsWith("J")
                         orderby n ascending
                         select n;
            var i = 0;
            foreach (var item in result)
            {
                i++;
                Console.WriteLine("第一种方式->查询以J开头的名称:第" + i.ToString() + "个" + item);
            }
            Console.WriteLine("===================分割线========================");
            var result2 = array.Where(name => name.StartsWith("J")).OrderBy(name => name).Select(name => name);//写法1
            result2 = array.Where(name => name.StartsWith("J")).OrderBy(name => name).ToList();//写法2
            var j = 0;
            foreach (var item in result2)
            {
                j++;
                Console.WriteLine("第二种方式->查询以J开头的名称:第" + j.ToString() + "个" + item);
            }

            #endregion
            Console.WriteLine("===================分割线========================");

            #region LINQ TO STRING
            string str = "HelloWord";
            var str_result = from n in str
                             where char.IsUpper(n)
                             select n;
            foreach (var item in str_result)
            {
                Console.WriteLine("查询字符串中大写字母的值：" + item);
            }
            #endregion

            #region LINQ TO LIST

            List<Student> stuList = new List<Student>();
            stuList.Add(new Student() { name = "Jom", age = 10 });
            stuList.Add(new Student() { name = "Jamck", age = 18 });
            stuList.Add(new Student() { name = "Jerry", age = 66 });
            stuList.Add(new Student() { name = "Mark", age = 55 });
            //查询姓名包含M并且年龄小于25的
            var list_result = from Student n in stuList
                              where n.name.Contains("m") && n.age <= 25
                              orderby n.name descending
                              select n;
            foreach (var item in list_result)
            {
                Console.WriteLine("查询姓名包含M并且年龄小于25的->" +"姓名："+item.name+",年龄"+item.age.ToString() );
            }

            #endregion

            Console.ReadKey();
        }
    }
}
