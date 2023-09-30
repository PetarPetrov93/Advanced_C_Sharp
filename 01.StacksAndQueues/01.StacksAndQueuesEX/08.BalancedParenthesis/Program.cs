namespace _08.BalancedParenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string parenthesis = Console.ReadLine();

            Stack<char> openingParenthesis = new Stack<char>();

            foreach (char symbol in parenthesis)
            {
                if (symbol == '(' || symbol == '{' || symbol == '[')
                {
                    openingParenthesis.Push(symbol);
                    continue;
                    
                }
                if (!openingParenthesis.Any())
                {
                    openingParenthesis.Push(symbol);
                    break;
                }
                if ((symbol == ')' && openingParenthesis.Peek() == '(') || (symbol == '}' && openingParenthesis.Peek() == '{') || (symbol == ']' && openingParenthesis.Peek() == '['))
                {
                    openingParenthesis.Pop();
                }
            }
            if (!openingParenthesis.Any())
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            
        }
    }
}