namespace _06.Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> colors = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                string[] inputClothes = input[1].Split(",");
                if (!colors.ContainsKey(color))
                {
                    colors.Add(color, new Dictionary<string, int>());

                }
                foreach (string piece in inputClothes)
                {
                    if (!colors[color].ContainsKey(piece))
                    {
                        colors[color].Add(piece, 0);
                    }
                    colors[color][piece] += 1;
                }
                
            }
            string[] clothesToSearch = Console.ReadLine().Split();
            string specificColor = clothesToSearch[0];
            string specificItem = clothesToSearch[1];

            foreach (var col in colors)
            {
                Console.WriteLine($"{col.Key} clothes:");
                foreach (var item in col.Value)
                {
                    if (item.Key == specificItem && col.Key == specificColor)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}