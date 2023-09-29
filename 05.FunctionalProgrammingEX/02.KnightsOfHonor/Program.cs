namespace _02.KnightsOfHonor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> addTitle = xNames =>
            {
                foreach (var name in xNames)
                {
                    Console.WriteLine($"Sir {name}");
                }
            };
            
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            addTitle(names);
        }
    }
}