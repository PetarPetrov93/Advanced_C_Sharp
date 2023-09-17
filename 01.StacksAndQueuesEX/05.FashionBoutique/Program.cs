namespace _05.FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> clothes = new Stack<int>(input);
            int rackCapacity = int.Parse(Console.ReadLine());
            int currRack = rackCapacity;
            int racksCount = 1;

            while (clothes.Any())
            {
                int currItem = clothes.Pop();
                
                if (currRack - currItem >= 0)
                {
                    currRack -= currItem;
                }
                else
                {
                    currRack = rackCapacity - currItem;
                    racksCount++;
                }
            }
            Console.WriteLine(racksCount);
        }
    }
}