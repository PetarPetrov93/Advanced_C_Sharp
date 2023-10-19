using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        private List<Renovator> renovators = new List<Renovator>();
        public Catalog(string name, int neededRenovators, string project)
        {
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
        }
        public string Name { get; set; }
        public int NeededRenovators { get; set; }
        public string Project { get; set; }

        public int Count { get { return renovators.Count; } } // Getter

        public string AddRenovator(Renovator renovator)
        {
            if (renovators.Count < NeededRenovators)
            {
                if (renovator.Name == null || renovator.Type == null || renovator.Name == "" || renovator.Type == "")
                {
                    return "Invalid renovator's information.";
                }
                if (renovator.Rate > 350)
                {
                    return "Invalid renovator's rate.";
                }
                renovators.Add(renovator);
                return $"Successfully added {renovator.Name} to the catalog.";
            }
            return "Renovators are no more needed.";
        }
        public bool RemoveRenovator(string name)
        {
            if (renovators.Any(x => x.Name == name))
            {
                renovators.RemoveAll(x => x.Name == name);
                return true;
            }
            return false;
        }

        public int RemoveRenovatorBySpecialty(string type)
        {
            int renovatorsToRemove = 0;
            foreach (var renovator in renovators)
            {
                if (renovator.Type == type)
                {
                    renovatorsToRemove++;
                }
            }
            renovators.RemoveAll(x => x.Type == type);
            return renovatorsToRemove;
        }

        public Renovator HireRenovator(string name)
        {
            if (renovators.Any(x => x.Name == name))
            {
                renovators.First(x => x.Name == name).Hired = true;
                return renovators.First(x => x.Name == name);
            }
            return null;
        }

        public List<Renovator> PayRenovators(int days)
        {
            List<Renovator> paidRenovators = new List<Renovator>();
            foreach (var renovator in renovators)
            {
                if (renovator.Days >= days)
                {
                    paidRenovators.Add(renovator);
                }
            }
            return paidRenovators;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Renovators available for Project {Project}:");
            foreach (var renovator in renovators)
            {
                if (renovator.Hired == false)
                {
                    sb.AppendLine(renovator.ToString());
                }
            }
            return sb.ToString().TrimEnd();
        } 
    }
}
