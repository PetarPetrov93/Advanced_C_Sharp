namespace _03.CustomMinFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Func<int[], int> minNum = x =>
            {
                int min = int.MaxValue;
                foreach (var num in x)
                {
                    if (min > num)
                    {
                        min = num;
                    }
                }
                return min;
            };

            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Console.WriteLine(minNum(numbers));
        }
    }
}