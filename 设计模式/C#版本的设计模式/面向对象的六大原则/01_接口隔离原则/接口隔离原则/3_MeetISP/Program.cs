using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_MeetISP
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
            //接口隔离的原则是 服务的调用方不会都要
            //本例子中服务的调用方的需求很简单，这是要求会run,不要求fire
            //因此原先的ITank接口中自己包含的fire和run就符合胖接口的规则，他提供了多余的接口给调用方
            //因此把ITank接口隔离开是对的
            var driver = new Driver(new HeavyTank());//开坦克
            driver.Drive();
            driver = new Driver(new Car());//开汽车
            driver.Drive();


            Console.ReadKey();
        }
    }

    class Driver
    {
        private IVehicle _vehicle;
        public Driver(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }
        public void Drive()
        {
            _vehicle.Run();
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

    interface IWeapon
    {
        void Fire();
    }

    interface ITank:IVehicle,IWeapon
    {
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
