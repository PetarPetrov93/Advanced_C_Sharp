namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[]args)
        {
            Car car = new Car();
            car.Make = "VW";
            car.Model = "Golf";
            car.Year = 2020;

            Console.WriteLine(car.Year + car.Make + car.Model);
        }
    }
}