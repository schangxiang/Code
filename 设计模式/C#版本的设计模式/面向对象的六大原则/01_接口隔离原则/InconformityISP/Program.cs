using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InconformityISP
{
    /*
     *  场景介绍：一对小情侣，一天女生给男生打电话，告诉他车被追尾了，哭的梨花带雨。
     *  小男生情商高，哄小女生说 不要紧，明天给你买辆坦克，就不怕追尾了。。（前提是小女生不能开炮，只能开~~~~）
     *  
     */
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new Driver(new Car());//开汽车
            driver = new Driver(new Truck());//开卡车
            driver.Drive();

            //这时候你会发现，如果小女生想要开坦克的话，目前是满足不了的
            //因为Driver构造参数传递的是IVehicle接口，不是ITank接口
            //如果想要满足小女生开坦克上街的愿望，就必须改造Driver，传递ITank接口，请看下一个例子

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

