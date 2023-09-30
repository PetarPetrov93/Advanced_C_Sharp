using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    class Car
    {
        // fields:
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        //properties:
        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }
        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        //methods:
        public void Drive(double distance)
        {
            if (fuelQuantity - (distance * fuelConsumption) >= 0)
            {
                fuelQuantity -= (distance * fuelConsumption);
            }
            else 
            {
                Console.WriteLine("Not enlugh fuel to perform this trip");
            }
        }

        public string WhoAmI()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine($"Make: {this.Make}");
            info.AppendLine($"Model: {this.Model}");
            info.AppendLine($"Year: {this.Year}");
            info.AppendLine($"Fuel: {this.fuelQuantity:f2}");

            return info.ToString();
        }

    }   
}
