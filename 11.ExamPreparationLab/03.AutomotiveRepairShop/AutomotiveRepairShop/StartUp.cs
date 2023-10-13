namespace AutomotiveRepairShop
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RepairShop repairShop = new(1);

            Vehicle vehicle = new Vehicle("VIN nqkakuv", 10000, "leko chuknata");

            repairShop.AddVehicle(vehicle);

            Console.WriteLine(repairShop.GetLowestMileage());

            repairShop.RemoveVehicle("VIN nqkakuv");

            Console.WriteLine(repairShop.GetLowestMileage());

        }
    }
}