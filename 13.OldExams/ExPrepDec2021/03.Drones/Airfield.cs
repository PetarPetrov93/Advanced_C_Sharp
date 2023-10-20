using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drones
{
    public class Airfield
    {
        public Airfield(string name, int capacity, double landingStrip)
        {
            Name = name;
            Capacity = capacity;
            LandingStrip = landingStrip;
            Drones = new List<Drone>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public double LandingStrip { get; set; }
        public List<Drone> Drones { get; private set; }

        public int Count { get { return Drones.Count; } } // Getter

        public string AddDrone(Drone drone)
        {
            if (Count < Capacity)
            {
                if (drone.Name == null || drone.Name == string.Empty || drone.Range < 5 || drone.Range > 15)
                {
                    return "Invalid drone.";
                }
                Drones.Add(drone);
                return $"Successfully added {drone.Name} to the airfield.";
            }
            return "Airfield is full.";
        }
        public bool RemoveDrone(string name)
        {
            if (Drones.Any(x => x.Name == name))
            {
                Drones.RemoveAll(x => x.Name == name);
                return true;
            }
            return false;
        }
        public int RemoveDroneByBrand(string brand)
        {
            int count = 0;
            foreach (var drone in Drones)
            {
                if (drone.Brand == brand)
                {
                    count++;
                }
            }
            Drones.RemoveAll(x => x.Brand == brand);
            return count;
        }
        public Drone FlyDrone(string name)
        {
            if (Drones.Any(x => x.Name == name))
            {
                Drones.First(x => x.Name == name).Available = false;
                return Drones.First(x => x.Name == name);
            }
            return null;
        }
        public List<Drone> FlyDronesByRange(int range)
        {
            List<Drone> flyDrones = new List<Drone>();
            foreach (var drone in Drones)
            {
                if (drone.Range == range)
                {
                    drone.Available = false;
                    flyDrones.Add(drone);
                }
            }
            return flyDrones;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Drones available at {Name}:");
            foreach (var drone in Drones.Where(x => x.Available == true))
            {
                sb.AppendLine(drone.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
