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
                string carModel = carInfo[0];
                double carFuelAmount = double.Parse(carInfo[1]);
                double carFuelConsumptionPerKM = double.Parse(carInfo[2]);

                Car car = new Car(carModel, carFuelAmount, carFuelConsumptionPerKM);
                cars.Add(car);
            }

            string cmd;

            while ((cmd = Console.ReadLine()) != "End")
            {
                string carModelToDrive = cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries)[1];
                double kilometersToDrive = double.Parse(cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries)[2]);

                Car carToDrive = cars.First(car => car.Model == carModelToDrive);
                carToDrive.Drive(kilometersToDrive);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
                      
        }
    }
}