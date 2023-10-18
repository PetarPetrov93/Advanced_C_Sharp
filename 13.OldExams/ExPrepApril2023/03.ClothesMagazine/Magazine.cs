using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClothesMagazine
{
    public class Magazine
    {
        public Magazine(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            Clothes = new List<Cloth>();
        }
        public string Type { get; set; }
        public int Capacity { get; set; }
        public List<Cloth> Clothes { get; private set; } // if something is wrong should try with set;

        public void AddCloth(Cloth cloth)
        {
            if (Clothes.Count < Capacity)
            {
                Clothes.Add(cloth);
            }
        }
        public bool RemoveCloth(string color)
        {
            if (Clothes.Any(x => x.Color == color))
            {
                Clothes.Remove(Clothes.First(x => x.Color == color));
                return true;
            }
            return false;
        }
        public Cloth GetSmallestCloth()
        {
            return Clothes.OrderBy(x => x.Size).First();
        }
        public Cloth GetCloth(string color)
        {
            return Clothes.First(x => x.Color == color);
        }
        public int GetClothCount()
        {
            return Clothes.Count;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Type} magazine contains:");
            foreach (var cloth in Clothes.OrderBy(x => x.Size))
            {
                sb.AppendLine(cloth.ToString());
            }
            return sb.ToString().TrimEnd();
        }
        
    }
}
