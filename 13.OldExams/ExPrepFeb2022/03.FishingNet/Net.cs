using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FishingNet
{
    public class Net
    {
        public Net(string material, int capacity)
        {
            Material = material;
            Capacity = capacity;
            Fish = new List<Fish>();
        }
        public string Material { get; set; }
        public int Capacity { get; set; }
        public List<Fish> Fish { get; private set; }

        public int Count { get { return Fish.Count; } } // Getter

        public string AddFish(Fish fish)
        {
            if (Count < Capacity)
            {
                if (fish.FishType == null || fish.FishType == " " || fish.Length <= 0 || fish.Weight <= 0)
                {
                    return "Invalid fish.";
                }
                this.Fish.Add(fish);
                return $"Successfully added {fish.FishType} to the fishing net.";
            }
            return "Fishing net is full.";
        }
        public bool ReleaseFish(double weight)
        {
            if (this.Fish.Any(x => x.Weight == weight))
            {
                this.Fish.RemoveAll(x => x.Weight == weight);
                return true;
            }
            return false;
        }
        public Fish GetFish(string fishType) => this.Fish.First(x => x.FishType == fishType);

        public Fish GetBiggestFish() => this.Fish.OrderByDescending(x => x.Weight).FirstOrDefault();

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Into the {Material}:");
            foreach (var fish in this.Fish.OrderByDescending(x => x.Length))
            {
                sb.AppendLine(fish.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
