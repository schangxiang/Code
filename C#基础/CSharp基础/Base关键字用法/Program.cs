using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base关键字用法
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 子类实例化无参

            //子类无参实例化，首先会默认调用父类的无参构造，再调用子类的无参构造
            //B b1 = new B();//输出：【Build A(无参构造)   Build B(无参构造)】

            #endregion

            #region 子类实例化有参，子类有参构造显式调用父类的无参构造(如果不显式，默认还是调父类的无参构造)

            //子类有参实例化，首先会默认调用父类的无参构造，再调用子类的无参构造
            //B b2 = new B("猪");//输出：【Build A(无参构造)  猪Build B(无参构造)】

            #endregion

            #region 子类实例化有参，子类有参构造显式调用父类的有参构造

            //子类有参实例化，首先会默认调用父类的无参构造，再调用子类的无参构造
            //C c1 = new C("驴");//输出：【驴Build A(有参构造)  驴Build C(有参构造)】

            #endregion

            #region 子类和父类同时有同名的属性
            /*
            A a1= new C();
            Console.WriteLine("a1的age是:" + a1.age);//输出 11
            C c2 = new C();
            Console.WriteLine("c2的age是:" + c2.age);//输出 99 
            //*/
            #endregion

            #region 实例化子类，转为父类对象，输出的成员变量是父类的值,调用的方法是字类重写的方法

            A a2 = new C();
            Console.WriteLine("年龄： " + a2.age);//输出 11
            a2.Hello();

            #endregion

            //B b = new B("祥子");

            Console.ReadLine();
        }
    }
}
