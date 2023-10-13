using System.Diagnostics;

namespace AutomotiveRepairShop
{
    public class Vehicle
    {
     
        public Vehicle(string vin, int milage, string damage) 
        {
            VIN = vin;
            Mileage = milage;
            Damage = damage;
        }

        public string VIN { get; set; }
        public int Mileage { get; set; }
        public string Damage { get; set; }


        public override string ToString()
        {
            return $"Damage: {Damage}, Vehicle: {VIN} ({Mileage} km)";
        }
    }
}
