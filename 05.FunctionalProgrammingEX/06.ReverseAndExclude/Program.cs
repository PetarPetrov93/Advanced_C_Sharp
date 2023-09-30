namespace _06.ReverseAndExclude
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Func<List<int>, int, List<int>> tryToDevide = (numList, devider) =>
            {
                List<int> nonDevisible = new List<int>();

                foreach (int num in numList)
                {
                    if (num % devider != 0)
                    {
                        nonDevisible.Add(num);
                    }
                }

                List<int> reversed = new List<int>();
                for (int i = nonDevisible.Count - 1; i >= 0; i--)
                {
                    reversed.Add(nonDevisible[i]);
                }

                return reversed;
            };

            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int devider = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(" ", tryToDevide(numbers, devider)));
        }
    }
}