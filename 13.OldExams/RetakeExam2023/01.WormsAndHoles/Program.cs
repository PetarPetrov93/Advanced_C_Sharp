namespace _01.WormsAndHoles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> worms = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Queue<int> holes = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            int matches = 0;
            int totalWorms = worms.Count;

            while (worms.Count > 0 && holes.Count > 0)
            {
                if (worms.Peek() == holes.Peek())
                {
                    matches++;
                    worms.Pop();
                    holes.Dequeue();
                }
                else
                {
                    holes.Dequeue();
                    worms.Push(worms.Pop() - 3);

                    if (worms.Peek() <= 0)
                    {
                        worms.Pop();
                    }
                }
            }

            if (matches > 0)
            {
                Console.WriteLine($"Matches: {matches}");
            }
            else
            {
                Console.WriteLine("There are no matches.");
            }

            if (worms.Count == 0 && matches == totalWorms)
            {
                Console.WriteLine("Every worm found a suitable hole!");
            }
            else if (worms.Count == 0 && matches != totalWorms)
            {
                Console.WriteLine("Worms left: none");
            }
            else
            {
                Console.WriteLine($"Worms left: {string.Join(", ", worms)}");
            }

            if (holes.Count == 0)
            {
                Console.WriteLine("Holes left: none");
            }
            else
            {
                Console.WriteLine($"Holes left: {string.Join(", ", holes)}");
            }
        }
    }
}
