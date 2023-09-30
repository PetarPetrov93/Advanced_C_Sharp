namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[]args)
        {
            Car car1 = new Car();
            car1.Model = "VW";
            car1.Make = "Golf";
            car1.Year = 2020;
            car1.FuelConsumption = 5;
            car1.FuelQuantity = 40;

            car1.Drive(50);

            Console.WriteLine(car1.WhoAmI());
        }
    }
}