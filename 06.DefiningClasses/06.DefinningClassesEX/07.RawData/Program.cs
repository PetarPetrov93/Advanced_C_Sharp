using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];

                double tire1Pressure = double.Parse(carInfo[5]);
                int tire1Age = int.Parse(carInfo[6]);
                double tire2Pressure = double.Parse(carInfo[7]);
                int tire2Age = int.Parse(carInfo[8]);
                double tire3Pressure = double.Parse(carInfo[9]);
                int tire3Age = int.Parse(carInfo[10]);
                double tire4Pressure = double.Parse(carInfo[11]);
                int tire4Age = int.Parse(carInfo[12]);

                Engine engine = new Engine(engineSpeed, enginePower);

                Cargo cargo = new Cargo(cargoType, cargoWeight);

                Tire[] tires = new Tire[]
                {
                    new Tire(tire1Age, tire1Pressure),
                    new Tire(tire2Age, tire2Pressure),
                    new Tire(tire3Age, tire3Pressure),
                    new Tire(tire4Age, tire4Pressure)
                };

                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }

            string cmd = Console.ReadLine();

            List<Car> carsToPrint = new List<Car>();

            if (cmd == "fragile")
            {
                carsToPrint = cars.Where(car => car.Cargo.Type == "fragile" && car.Tires.Any(tire => tire.Pressure < 1)).ToList();
            }
            else if (cmd == "flammable")
            {
                carsToPrint = cars.Where(car => car.Cargo.Type == "flammable" && car.Engine.Power > 250).ToList();
            }

            foreach (Car car in carsToPrint) 
            {
                Console.WriteLine(car.Model);
            }
                      
        }
    }
}