namespace _04.EvenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> nums = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (!nums.ContainsKey(num))
                {
                    nums.Add(num, 0);
                }
                nums[num] += 1;
            }
            foreach (var number in nums.Where(x => x.Value % 2 == 0))
            {
                Console.WriteLine(number.Key);
            }
        }
    }
}