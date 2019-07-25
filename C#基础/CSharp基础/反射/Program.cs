using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 反射
{
    class Program
    {
        static void Main(string[] args)
        {
            //得到类的属性
            PropertyInfo[] propertys = typeof(Student).GetProperties();//注意：这里读取的是公共属性，像本例中age是私有的，所以读不出去
            foreach (var item in propertys)
            {
                Console.WriteLine("属性名：" + item.Name + ",类型是：" + item.PropertyType.ToString());

                if (item.PropertyType.IsGenericType)
                {//判断是否是泛型类型
                    Console.WriteLine("泛型 属性名：" + item.Name + ",类型是：" + item.PropertyType.ToString());
                }
            }

            List<TestScore> testScoreList = new List<TestScore>() {
                 new TestScore(){ Subject="语文", TestDate=DateTime.Now },
                 new TestScore(){Subject="数学", TestDate=DateTime.Now },
                 new TestScore(){Subject="政治", TestDate=DateTime.Now }
            };
            Student stu = new Student()
            {
                Name = "祥子",
                BirthDay = DateTime.Now,
                LittleRedFlowers = 5,
                Sex = "爷们",
                TestScoreList = testScoreList
            };

            foreach (var item in propertys)
            {
                Console.WriteLine("属性名：" + item.Name + ",类型是：" + item.PropertyType.ToString() + ",属性值：" + item.GetValue(stu, null).ToString());

            }



            Console.ReadKey();

        }
    }
}
