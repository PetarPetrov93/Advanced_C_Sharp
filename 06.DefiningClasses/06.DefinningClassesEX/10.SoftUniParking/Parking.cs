using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> cars;
        private int capacity;

        public Parking(int capacity)
        {
            Cars = new List<Car>();
            Capacity = capacity;
        }

        public List<Car> Cars
        {
            get { return cars; }
            set { cars = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        public int Count
        {
            get { return cars.Count;}
        }

        public string AddCar(Car carToAdd)
        {           
            if (Cars.Any(car => car.RegistrationNumber == carToAdd.RegistrationNumber))
            {            
                return "Car with that registration number, already exists!";
            }
            
            
            if (Capacity == Cars.Count)
            {
                return "Parking is full!";
            }
            else
            {
                Cars.Add(carToAdd);
                return $"Successfully added new car {carToAdd.Make} {carToAdd.RegistrationNumber}";                  
            }
            
            
        }
        public string RemoveCar(string registrationNumber)
        {
            if (cars.Any(car => car.RegistrationNumber == registrationNumber))
            {
                cars.RemoveAll(car => car.RegistrationNumber == registrationNumber);
                return $"Successfully removed {registrationNumber}";
            }
            else
            {
                return "Car with that registration number, doesn't exist!";
            }
        }

        public Car GetCar (string registrationNumber)
        {
            return cars.FirstOrDefault(car => car.RegistrationNumber == registrationNumber);
        }

        public void RemoveSetOfRegistrationNumber (List<string> registrationNumbers)
        {
            foreach (string registrationNumber in registrationNumbers)
            {
                if (cars.Any(car => car.RegistrationNumber == registrationNumber))
                {
                    cars.RemoveAll(car => car.RegistrationNumber == registrationNumber);
                }
            }
        }
    }
}
