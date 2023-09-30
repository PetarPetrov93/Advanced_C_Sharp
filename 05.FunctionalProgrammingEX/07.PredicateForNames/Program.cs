namespace _07.PredicateForNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action<string[], int> lengthCheck = (names, length) =>
            {
                foreach (string name in names)
                {
                    if (name.Length <= length)
                    {
                        Console.WriteLine(name);
                    }
                }
            };
            lengthCheck(names, length);
        }
    }
}