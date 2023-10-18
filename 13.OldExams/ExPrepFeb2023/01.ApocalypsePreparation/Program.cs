using System.Text.Json;

namespace _01.ApocalypsePreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> textile = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Stack<int> medicaments = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            Dictionary<string, int> items = new Dictionary<string, int>();

            while (textile.Count > 0 && medicaments.Count > 0)
            {
                if (textile.Peek() + medicaments.Peek() == 30)
                {
                    if (!items.ContainsKey("Patch"))
                    {
                        items.Add("Patch", 0);
                    }
                    items["Patch"]++;
                    textile.Dequeue();
                    medicaments.Pop();
                }
                else if (textile.Peek() + medicaments.Peek() == 40)
                {
                    if (!items.ContainsKey("Bandage"))
                     {
                        items.Add("Bandage", 0);
                     }
                    items["Bandage"]++;
                    textile.Dequeue();
                    medicaments.Pop();
                }
                else if (textile.Peek() + medicaments.Peek() >= 100)
                {
                    if (!items.ContainsKey("MedKit"))
                     {
                        items.Add("MedKit", 0);
                     }
                    items["MedKit"]++;

                    int valueToAdd = textile.Dequeue() + medicaments.Pop() - 100;

                    if (valueToAdd > 0)
                     {
                        medicaments.Push(medicaments.Pop() + valueToAdd);
                     }
                    
                }
                else
                {
                    textile.Dequeue();
                    medicaments.Push(medicaments.Pop() + 10);
                }
            }
            if (textile.Count == 0 && medicaments.Count == 0)
            {
                Console.WriteLine("Textiles and medicaments are both empty.");
            }
            else if (textile.Count == 0)
            {
                Console.WriteLine("Textiles are empty.");
            }
            else if (medicaments.Count == 0)
            {
                Console.WriteLine("Medicaments are empty.");
            }

            if (items.Count > 0)
            {
                foreach (var item in items.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{item.Key} - {item.Value}");
                }
            }
            if (medicaments.Count > 0)
            {
                Console.Write("Medicaments left: ");
                Console.WriteLine(string.Join(", ", medicaments));
            }
            if (textile.Count > 0)
            {
                Console.Write("Textiles left: ");
                Console.WriteLine(string.Join(", ", textile));
            }
        }
    }
}