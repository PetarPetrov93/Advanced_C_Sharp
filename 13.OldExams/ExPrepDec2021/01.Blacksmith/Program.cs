using System.Collections.Generic;
using System;
using System.Linq;

namespace _01.Blacksmith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> steel = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Stack<int> carbon = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            SortedDictionary<string, int> swords = new SortedDictionary<string, int>();

            while (steel.Count > 0 & carbon.Count > 0)
            {
                if (steel.Peek() + carbon.Peek() == 70)
                {
                    steel.Dequeue();
                    carbon.Pop();
                    if (!swords.ContainsKey("Gladius"))
                    {
                        swords.Add("Gladius", 0);
                    }
                    swords["Gladius"]++;
                }
                else if (steel.Peek() + carbon.Peek() == 80)
                {
                    steel.Dequeue();
                    carbon.Pop();
                    if (!swords.ContainsKey("Shamshir"))
                    {
                        swords.Add("Shamshir", 0);
                    }
                    swords["Shamshir"]++;
                }
                else if (steel.Peek() + carbon.Peek() == 90)
                {
                    steel.Dequeue();
                    carbon.Pop();
                    if (!swords.ContainsKey("Katana"))
                    {
                        swords.Add("Katana", 0);
                    }
                    swords["Katana"]++;
                }
                else if (steel.Peek() + carbon.Peek() == 110)
                {
                    steel.Dequeue();
                    carbon.Pop();
                    if (!swords.ContainsKey("Sabre"))
                    {
                        swords.Add("Sabre", 0);
                    }
                    swords["Sabre"]++;
                }
                else if (steel.Peek() + carbon.Peek() == 150)
                {
                    steel.Dequeue();
                    carbon.Pop();
                    if (!swords.ContainsKey("Broadsword"))
                    {
                        swords.Add("Broadsword", 0);
                    }
                    swords["Broadsword"]++;
                }
                else
                {
                    steel.Dequeue();
                    carbon.Push(carbon.Pop() + 5);
                }
            }
            if (swords.Count() > 0)
            {
                Console.WriteLine($"You have forged {swords.Sum(x => x.Value)} swords.");
            }
            else
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }

            if (steel.Count == 0)
            {
                Console.WriteLine("Steel left: none");
            }
            else
            {
                Console.Write("Steel left: ");
                Console.WriteLine(string.Join(", ", steel));
            }

            if (carbon.Count == 0)
            {
                Console.WriteLine("Carbon left: none");
            }
            else
            {
                Console.Write("Carbon left: ");
                Console.WriteLine(string.Join(", ", carbon));
            }

            if (swords.Count > 0)
            {
                foreach (var sword in swords)
                {
                    Console.WriteLine($"{sword.Key}: {sword.Value}");
                }
            }
        }
    }
}