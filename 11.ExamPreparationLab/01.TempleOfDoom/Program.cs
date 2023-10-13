namespace _01.TempleOfDoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputTools = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] inputSubstances = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> tools = new Queue<int>(inputTools);
            Stack<int> substances = new Stack<int>(inputSubstances);

            List<int> challenges = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            while(tools.Any() && substances.Any() && challenges.Any())
            {
                if (challenges.Any(x => x == (tools.Peek() * substances.Peek())))
                {
                    int challengeToRemove = tools.Dequeue() * substances.Pop();
                    
                    challenges.Remove(challengeToRemove);
                }
                else
                {
                    tools.Enqueue(tools.Dequeue() + 1);
                    if (substances.Peek() - 1 > 0)
                    {
                        substances.Push(substances.Pop() - 1);
                    }
                    else
                    {
                        substances.Pop();
                    }

                }
            }
            if (!challenges.Any())
            {
                Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
            }
            else if (challenges.Any())
            {
                Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
            }
            if (tools.Any())
            {
                Console.WriteLine($"Tools: {string.Join(", ", tools)}");
            }
            if (substances.Any())
            {
                Console.WriteLine($"Substances: {string.Join(", ", substances)}");
            }
            if (challenges.Any())
            {
                Console.WriteLine($"Challenges: {string.Join(", ", challenges)}");
            }
        }
    }
}