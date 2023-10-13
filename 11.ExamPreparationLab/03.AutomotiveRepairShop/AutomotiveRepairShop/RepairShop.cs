using System.Text;

namespace AutomotiveRepairShop
{
    public class RepairShop
    {
        
        public RepairShop(int capacity)
        {
            Capacity = capacity;
            Vehicles = new List<Vehicle>();
        }

        public int Capacity { get; set; }
        public List<Vehicle> Vehicles { get; set; }

        public void AddVehicle(Vehicle vehicle)
        {
            if (Capacity > Vehicles.Count)
            {
                Vehicles.Add(vehicle);
            }
        }

        public bool RemoveVehicle(string vin)
        {
            if (Vehicles.Any(automobile => automobile.VIN == vin))
            {
                Vehicles.RemoveAll(automobile => automobile.VIN == vin);
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetCount()
        {
            return Vehicles.Count;
        }

        public Vehicle GetLowestMileage()
        {

            Vehicle lowestMilage;

            lowestMilage = Vehicles.OrderBy(car => car.Mileage).FirstOrDefault();
            return lowestMilage;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Vehicles in the preparatory:");
            foreach (Vehicle vehicle in Vehicles)
            {
                sb.AppendLine(vehicle.ToString());
            }
            return sb.ToString().Trim();
        }


    }
}
