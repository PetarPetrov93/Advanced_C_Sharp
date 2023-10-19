namespace _01.BaristaContest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> coffee = new Queue<int>(Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Stack<int> milk = new Stack<int>(Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            Dictionary<string, int> bevies = new Dictionary<string, int>();

            while (coffee.Count > 0 && milk.Count > 0)
            {
                if (coffee.Peek() + milk.Peek() == 50)
                {
                    if (!bevies.ContainsKey("Cortado"))
                    {
                        bevies.Add("Cortado", 0);
                    }
                    bevies["Cortado"]++;
                    coffee.Dequeue();
                    milk.Pop();
                }
                else if (coffee.Peek() + milk.Peek() == 75)
                {
                    if (!bevies.ContainsKey("Espresso"))
                    {
                        bevies.Add("Espresso", 0);
                    }
                    bevies["Espresso"]++;
                    coffee.Dequeue();
                    milk.Pop();
                }
                else if (coffee.Peek() + milk.Peek() == 100)
                {
                    if (!bevies.ContainsKey("Capuccino"))
                    {
                        bevies.Add("Capuccino", 0);
                    }
                    bevies["Capuccino"]++;
                    coffee.Dequeue();
                    milk.Pop();
                }
                else if (coffee.Peek() + milk.Peek() == 150)
                {
                    if (!bevies.ContainsKey("Americano"))
                    {
                        bevies.Add("Americano", 0);
                    }
                    bevies["Americano"]++;
                    coffee.Dequeue();
                    milk.Pop();
                }
                else if (coffee.Peek() + milk.Peek() == 200)
                {
                    if (!bevies.ContainsKey("Latte"))
                    {
                        bevies.Add("Latte", 0);
                    }
                    bevies["Latte"]++;
                    coffee.Dequeue();
                    milk.Pop();
                }
                else
                {
                    coffee.Dequeue();
                    milk.Push(milk.Pop() - 5);
                }
            }
            if (coffee.Count == 0 && milk.Count == 0)
            {
                Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
            }
            else
            {
                Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");
            }
            if (coffee.Count > 0)
            {
                Console.Write("Coffee left: ");
                Console.WriteLine(string.Join(", ", coffee));
            }
            else
            {
                Console.WriteLine("Coffee left: none");
            }
            if (milk.Count > 0)
            {
                Console.Write("Milk left: ");
                Console.WriteLine(string.Join(", ", milk));
            }
            else
            {
                Console.WriteLine("Milk left: none");
            }
            foreach (var item in bevies.OrderBy(x => x.Value).ThenByDescending(x => x.Key))
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}