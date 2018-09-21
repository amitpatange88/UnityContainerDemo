using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace UnityContainerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //RegisterDependency.Register();

            IUnityContainer container = new UnityContainer();
            container.RegisterType<ICar, BMW>();
            container.RegisterType<ICar, Audi>("LuxuryCar");

            //Resolves dependencies and returns Driver object 
            Driver dr = container.Resolve<Driver>();
            dr.RunCar();

            ICar bmw = container.Resolve<ICar>();  // return BMW object
            ICar audi = container.Resolve<ICar>("LuxuryCar"); // return Audi object

            Console.WriteLine("Running {0} - {1} mile ", bmw.GetType().Name, bmw.Run());
            Console.WriteLine("Running {0} - {1} mile ", audi.GetType().Name, audi.Run());


            Console.ReadLine();
        }
    }
}
