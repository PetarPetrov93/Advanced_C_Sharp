namespace _02.BasicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int elementsToEnqueue = input[0];
            int elementsToDequeue = input[1];
            int elementToCheck = input[2];

            int[] numbers = new int[elementsToEnqueue];
            numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(numbers);

            while (queue.Any() && elementsToDequeue > 0)
            {
                queue.Dequeue();
                elementsToDequeue--;
            }
            if (!queue.Any())
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(elementToCheck))
            {
                Console.WriteLine("true");
            }
            else if (!queue.Contains(elementToCheck))
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}