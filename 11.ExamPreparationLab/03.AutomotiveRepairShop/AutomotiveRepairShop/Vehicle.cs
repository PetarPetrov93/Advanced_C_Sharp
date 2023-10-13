using System.Diagnostics;

namespace AutomotiveRepairShop
{
    public class Vehicle
    {
     
        public Vehicle(string vin, int milage, string damage) 
        {
            Vin = vin;
            Milage = milage;
            Damage = damage;
        }

        public string Vin { get; set; }
        public int Milage { get; set; }
        public string Damage { get; set; }


        public override string ToString()
        {
            return $"Damage: {Damage}, Vehicle: {Vin} ({Milage} km)";
        }
    }
}
