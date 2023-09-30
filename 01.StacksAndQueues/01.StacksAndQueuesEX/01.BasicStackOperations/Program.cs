namespace _01.BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int elementsToPush = commands[0];
            int elementsToPop = commands[1];
            int elementToPeek = commands[2];

            int[] numbers = new int[elementsToPush];

            numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(numbers);

            while (stack.Any() && elementsToPop > 0)
            {
                stack.Pop();
                elementsToPop--;
            }
            if (!stack.Any())
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(elementToPeek))
            {
                Console.WriteLine("true");
            }
            else if (!stack.Contains(elementToPeek))
            {
                Console.WriteLine(stack.Min());
            }

            
        }
    }
}