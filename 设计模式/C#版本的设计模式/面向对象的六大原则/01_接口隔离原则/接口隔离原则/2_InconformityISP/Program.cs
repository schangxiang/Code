using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_InconformityISP
{
    /*
       *  场景介绍：一对小情侣，一天女生给男生打电话，告诉他车被追尾了，哭的梨花带雨。
       *  小男生情商高，哄小女生说 不要紧，明天给你买辆坦克，就不怕追尾了。（前提是小女生不能开炮，只能开~~~~）
       *  
       */
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new Driver(new HeavyTank());//开坦克
            driver.Drive();

            // 这时候你会发现， 小女生能开坦克上街了，但是你又会发现，小女生现在只会开坦克了，不会开车了
            // 问题出现在哪里呢？
            // 我们把一个胖接口(ITank)传递进来,这个胖接口中有一个我们永远用不到的功能，就是fire。
            // 所以现在这个设计是违反了接口隔离原则
            // 具体改造请看下一个例子

            Console.ReadKey();
        }
    }

    class Driver
    {
        private ITank _tank;
        public Driver(ITank tank)
        {
            _tank = tank;
        }
        public void Drive()
        {
            _tank.Run();
        }
    }


    #region 车辆接口和实现

    interface IVehicle
    {
        void Run();
    }

    class Car : IVehicle
    {
        public void Run()
        {
            Console.WriteLine("Car is Running");
        }
    }
    class Truck : IVehicle
    {
        public void Run()
        {
            Console.WriteLine("Truck is Running");
        }
    }

    #endregion

    interface ITank
    {
        void Run();
        void Fire();
    }
    class LightTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom!");
        }

        public void Run()
        {
            Console.WriteLine("Ka Ka Ka!");
        }
    }

    class HeavyTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom!!!!!!!!");
        }

        public void Run()
        {
            Console.WriteLine("Ka!!! Ka!!!! Ka!!!!!!");
        }
    }
}
