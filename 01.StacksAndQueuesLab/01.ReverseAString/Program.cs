namespace _01.ReverseAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<string> stack = new Stack<string>();

            foreach (char letter in input)
            {
                stack.Push(letter.ToString());
            }
            while (stack.Any())
            {
                Console.Write(stack.Pop());
            }
        }
    }
}