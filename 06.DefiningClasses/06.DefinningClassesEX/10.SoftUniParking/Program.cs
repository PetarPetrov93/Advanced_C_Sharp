using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var car = new Car("Skoda", "Fabia", 65, "CC1856BG");

            var car2 = new Car("Audi", "A3", 110, "EB8787MN");

            Console.WriteLine(car.ToString());
          

            Parking parking = new Parking(5);

            Console.WriteLine(parking.AddCar(car));


            Console.WriteLine(parking.AddCar(car));


            Console.WriteLine(parking.AddCar(car2));


            Console.WriteLine(parking.GetCar("EB8787MN").ToString());   

            Console.WriteLine(parking.RemoveCar("EB8787MN"));


            Console.WriteLine(parking.Count);

        }
    }
}