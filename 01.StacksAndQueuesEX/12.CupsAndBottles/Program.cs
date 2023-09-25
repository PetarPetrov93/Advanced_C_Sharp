namespace _12.CupsAndBottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputCups = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] inputBottles = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> cups = new Queue<int>(inputCups);
            Stack<int> bottles = new Stack<int>(inputBottles);

            int wastedLittres = 0;

            while (cups.Any() && bottles.Any())
            {
                if (cups.Peek() <= bottles.Peek())
                {
                    int currWaterSpilled = bottles.Pop() - cups.Dequeue();
                    wastedLittres += currWaterSpilled;
                }
                else
                {
                    
                    cups.Enqueue(cups.Dequeue() - bottles.Pop());
                    for (int i = 0; i < cups.Count-1; i++)
                    {
                        cups.Enqueue(cups.Dequeue());
                    }
                    
                }
            }
            if (cups.Any())
            {
                Console.Write("Cups: ");
                Console.WriteLine(string.Join(" ", cups));
            }
            else if (bottles.Any())
            {
                Console.Write("Bottles: ");
                Console.WriteLine(string.Join(" ", bottles));
            }
            Console.WriteLine($"Wasted litters of water: {wastedLittres}");
        }
    }
}