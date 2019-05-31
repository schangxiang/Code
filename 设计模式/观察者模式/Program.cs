using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    class Program
    {
        /*
         * 
         * 一、定义
         * 观察者模式(Observer Pattern)是设计模式中行为模式的一种，它解决了上述具有一对多依赖关系的对象的重用问题。此模式的参与者分为两大类，
         * 一类是被观察的目标，另一类是观察该目标的观察者们。
         * 正因为该模式是基于“一对多”的关系，所以该模式一般是应用于由一个目标对象和N个观察者对象组成（当然也可以扩展为有多个目标对象，但我们现在只讨论前者）的场合。
         * 当目标对象的状态发生改变或做出某种行为时，正在观察该目标对象的观察者们将自动地、连锁地作出相应的响应行为。
         * 
         * 二、测试事例
         * 猫来了，老鼠走了。
           其中猫为被观察的目标，老鼠为观察者，当猫来了行为发生时，老鼠们会做出逃跑的响应行为。
         * 
         * 
         * 三、适用场景
         * (1)当对一个对象的改变需要同时改变其他对象，而又不知道具体有多少对象有待改变的情况下。
           (2)当一个对象必须通知其他对象，而又不能假定其他对象是谁的情况下。
         */
        static void Main(string[] args)
        {
            Cat cat = new Cat("加菲猫", "黄色");
            Mouse m1 = new Mouse("米奇", "黑色");
            Mouse m2 = new Mouse("唐老鸭", "红色");
            Mouse m3 = new Mouse("来宝", "绿色");

            cat.catCome += m1.RunAway;//多播委托
            cat.catCome += m2.RunAway;
            cat.catCome += m3.RunAway;

            cat.CatComing();//猫的状态发生改变

            Console.ReadKey();
        }
    }
}
