using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoeStore
{
    public class ShoeStore
    {
        public ShoeStore(string name, int storageCapacity)
        {
            Name = name;
            StorageCapacity = storageCapacity;
            Shoes = new List<Shoe>();
        }
        public string Name { get; set; }
        public int StorageCapacity { get; set; }
        public List<Shoe> Shoes { get; private set; }
        public int Count { get { return Shoes.Count; } } // getter

        public string AddShoe (Shoe shoe)
        {
            if (Shoes.Count < StorageCapacity)
            {
                Shoes.Add(shoe);
                return $"Successfully added {shoe.Type} {shoe.Material} pair of shoes to the store.";
            }
            return "No more space in the storage room.";
        }

        public int RemoveShoes(string material)
        {
            int count = 0;
            foreach (var shoe in Shoes)
            {
                if (shoe.Material == material)
                {
                    count++;
                }
            }
            Shoes.RemoveAll(sh => sh.Material == material);
            return count;
        }

        public List<Shoe> GetShoesByType(string type)
        {
            List<Shoe> shoesByType = new List<Shoe>();
            foreach (var shoe in Shoes)
            {
                if (shoe.Type.ToLower() == type.ToLower())
                {
                    shoesByType.Add(shoe);
                }
            }
            return shoesByType;
        }

        public Shoe GetShoeBySize(double size)
        {
            
            return Shoes.First(x => x.Size == size);
        }

        public string StockList(double size, string type)
        {
            if (Shoes.Any(x => x.Size == size && x.Type == type))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Stock list for size {size} - {type} shoes:");
                foreach (var shoe in Shoes.Where(x => x.Size == size && x.Type == type))
                {
                    sb.AppendLine(shoe.ToString());
                }
                return sb.ToString().TrimEnd();
            }
            return "No matches found!";
        }
    }
}
