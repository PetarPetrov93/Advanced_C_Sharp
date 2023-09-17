namespace _04.FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> orders = new Queue<int>(input);

            Console.WriteLine(orders.Max());

            while (orders.Any()) //|| foodQuantity < 0)
            {
                if (foodQuantity - orders.Peek() < 0)
                {
                    Console.Write("Orders left: ");
                    Console.WriteLine(string.Join(" ", orders));
                    break;
                }
                foodQuantity -= orders.Dequeue();
            }
            if (!orders.Any())
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}