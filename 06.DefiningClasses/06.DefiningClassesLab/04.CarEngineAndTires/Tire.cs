using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Tire
    {
        //Fields:
        private int year;
        private double pressure;

        //Properties:
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public double Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }

        //Constructor:
        public Tire(int inputYear, double inputPressure)
        {
            Year = inputYear;
            Pressure = inputPressure;
        }


    }
}
