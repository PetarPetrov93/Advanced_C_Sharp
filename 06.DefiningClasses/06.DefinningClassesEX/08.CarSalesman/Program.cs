using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int inputEngines = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < inputEngines; i++)
            {
                string[] inputEng = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = inputEng[0];
                int power = int.Parse(inputEng[1]);

                Engine engine = new Engine
                {
                    Model = model,
                    Power = power,
                };

                if (inputEng.Length == 4)
                {
                    int displacement = int.Parse(inputEng[2]);
                    string efficiency = inputEng[3];
                    engine.Displacement = displacement;
                    engine.Efficiency = efficiency;
                }
                else if (inputEng.Length == 3)
                {
                    bool isDisplacement = int.TryParse(inputEng[2], out int result);

                    if (isDisplacement)
                    {
                        engine.Displacement = result;
                    }
                    else
                    {
                        engine.Efficiency = inputEng[2];
                    }
                }
                engines.Add(engine);
            }

            int inputCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < inputCars; i++)
            {
                string[] inputCurrCar = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = inputCurrCar[0];
                Engine engine = engines.First(engine => engine.Model == inputCurrCar[1]);

                Car car = new Car
                {
                    Model = model,
                    Engine = engine
                };

                if (inputCurrCar.Length == 4)
                {
                    int weight = int.Parse(inputCurrCar[2]);
                    string color = inputCurrCar[3];
                    car.Weight = weight;
                    car.Color = color;
                }
                else if (inputCurrCar.Length == 3)
                {
                    bool isWeight = int.TryParse(inputCurrCar[2], out int result);
                    if (isWeight)
                    {
                        car.Weight = result;
                    }
                    else
                    {
                        car.Color = inputCurrCar[2];
                    }
                }
                cars.Add(car);
   
            }
            foreach (Car currCar in cars)
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"{currCar.Model}:");
                sb.AppendLine($"  {currCar.Engine.Model}:");
                sb.AppendLine($"    Power: {currCar.Engine.Power}");
                if (currCar.Engine.Displacement == null)
                {
                    sb.AppendLine("    Displacement: n/a");
                }
                else
                {
                    sb.AppendLine($"    Displacement: {currCar.Engine.Displacement}");
                }
                if (currCar.Engine.Efficiency == null)
                {
                    sb.AppendLine("    Efficiency: n/a");
                }
                else
                {
                    sb.AppendLine($"    Efficiency: {currCar.Engine.Efficiency}");
                }
                if (currCar.Weight == null)
                {
                    sb.AppendLine("  Weight: n/a");
                }
                else
                {
                    sb.AppendLine($"  Weight: {currCar.Weight}");
                }
                if (currCar.Color == null)
                {
                    sb.Append("  Color: n/a");
                }
                else
                {
                    sb.Append($"  Color: {currCar.Color}");
                }
                Console.WriteLine(sb.ToString());
            }
        }
    }
}