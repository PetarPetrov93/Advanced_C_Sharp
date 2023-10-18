using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        public Kindergarten(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Registry = new List<Child>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Child> Registry { get; private set; }

        public int ChildrenCount { get { return Registry.Count; } } //Getter

        public bool AddChild(Child child)
        {
            if (Registry.Count < Capacity)
            {
                Registry.Add(child);
                return true;
            }
            return false;
        }
        public bool RemoveChild(string childFullName)
        {
            string[] childName = childFullName.Split(" ", System.StringSplitOptions.RemoveEmptyEntries);

            if (Registry.Any(x => x.FirstName == childName[0] && x.LastName == childName[1]))
            {
                Child childToRemove = Registry.First(x => x.FirstName == childName[0] && x.LastName == childName[1]);
                Registry.Remove(childToRemove);
                return true;
            }
            return false;
        }
        public Child GetChild(string childFullName)
        {
            string[] childName = childFullName.Split(" ", System.StringSplitOptions.RemoveEmptyEntries);
            if (Registry.Any(x => x.FirstName == childName[0] && x.LastName == childName[1]))
            {
                return Registry.FirstOrDefault(x => x.FirstName == childName[0] && x.LastName == childName[1]);
            }
            return null;
        }
        public string RegistryReport()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Registered children in {Name}:");
            foreach (var child in Registry.OrderByDescending(x => x.Age).ThenBy(x => x.LastName).ThenBy(x => x.FirstName))
            {
                sb.AppendLine(child.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
