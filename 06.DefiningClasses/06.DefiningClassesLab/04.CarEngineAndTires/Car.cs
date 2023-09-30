﻿using System;
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

        //constructors:
        public Car()
        {
            // using the properties here, not the fields, that's why we need to use the capital letter:
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }
        public Car(string make, string model, int year) : this()  //<-- the variables here can be named however we like, normally they are named as the priperties, but with lower case letter, I've intentionally named them differently for visibility that the properties below wil accept the values from outside the Class
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            FuelConsumption = fuelConsumption;
            FuelQuantity = fuelQuantity;
        }
        

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
                Console.WriteLine("Not enlugh fuel to perform this trip!");
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

        // adding more fields, placing them here, not above, for my on convenience and visibility:
        private Engine engine;
        private Tire[] tires;

        //adding properties to these fields:
        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }
        public Tire[] Tires
        {
            get { return tires; }
            set { tires = value; }
        }
        
        //adding another constructor, placing it here for my on convenience and visibility:  The last values are actually the 2 newly crated classes Engine and Tire[]

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires) : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            Tires = tires;
        }
    }   
}
