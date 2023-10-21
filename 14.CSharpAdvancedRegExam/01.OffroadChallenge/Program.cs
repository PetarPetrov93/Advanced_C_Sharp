namespace _01.OffroadChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> fuel = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Queue<int> additionalConsumption = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            Queue<int> altitudes = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            int totalAltitudes = altitudes.Count();
            int concqueredAltitudes = 0;

            while (fuel.Count > 0 && additionalConsumption.Count > 0)
            {
                if (fuel.Pop() - additionalConsumption.Dequeue() >= altitudes.Dequeue())
                {
                    concqueredAltitudes++;
                    Console.WriteLine($"John has reached: Altitude {concqueredAltitudes}");
                }
                else
                {
                    Console.WriteLine($"John did not reach: Altitude {concqueredAltitudes + 1}");
                    break;
                }
            }
            if (concqueredAltitudes > 0 && concqueredAltitudes < totalAltitudes)
            {
                Console.WriteLine("John failed to reach the top.");
                List<string> concAlt = new List<string>();
                for (int i = 1; i <= concqueredAltitudes; i++)
                {
                    concAlt.Add($"Altitude {i}");
                }
                Console.WriteLine($"Reached altitudes: {string.Join(", ", concAlt)}");
            }
            else if (concqueredAltitudes <= 0)
            {
                Console.WriteLine("John failed to reach the top.");
                Console.WriteLine("John didn't reach any altitude.");
            }
            else
            {
                Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
            }
        }
    }
}