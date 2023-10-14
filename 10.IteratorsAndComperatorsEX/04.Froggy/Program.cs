namespace _04.Froggy
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            Lake lake = new Lake(nums);


            Console.WriteLine(string.Join(", ", lake));
        }
    }
}