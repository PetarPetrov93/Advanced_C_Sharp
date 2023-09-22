namespace _05.CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currSymbol = input[i];
                if (!symbols.ContainsKey(currSymbol))
                {
                    symbols.Add(currSymbol, 0);
                }
                symbols[currSymbol] += 1;
            }
            foreach (var symbol in symbols)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}