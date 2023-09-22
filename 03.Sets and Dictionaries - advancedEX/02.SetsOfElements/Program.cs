namespace _02.SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];
            HashSet<int> firstSet = new HashSet<int>(n);
            HashSet<int> secondSet = new HashSet<int>(m);

            for (int i = 1; i <= n; i++)
            {
                int numForFirst = int.Parse(Console.ReadLine());
                firstSet.Add(numForFirst);
            }
            for (int i = 1; i <= m; i++)
            {
                int numForSecond = int.Parse(Console.ReadLine());
                secondSet.Add(numForSecond);
            }
            List<int> commonNums = new List<int>();
            foreach (int currNum in firstSet)
            {
                if (secondSet.Contains(currNum))
                {
                    commonNums.Add(currNum);
                }
            }

            Console.WriteLine(string.Join(" ", commonNums));
        }
    }
}