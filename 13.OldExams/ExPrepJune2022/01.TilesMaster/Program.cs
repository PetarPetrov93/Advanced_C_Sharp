using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.TilesMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> whiteTiles = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray()); 
            Queue<int> greyTiles = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            Dictionary<string, int> areas = new Dictionary<string, int>();

            while (whiteTiles.Count > 0 && greyTiles.Count > 0)
            {
                if (whiteTiles.Peek() != greyTiles.Peek())
                {
                    whiteTiles.Push(whiteTiles.Pop() / 2);
                    greyTiles.Enqueue(greyTiles.Dequeue());
                }
                else if (whiteTiles.Peek() == greyTiles.Peek())
                {
                    if (whiteTiles.Peek() + greyTiles.Peek() == 40)
                    {
                        if (!areas.ContainsKey("Sink"))
                        {
                            areas.Add("Sink", 0);
                        }
                        areas["Sink"]++;
                        whiteTiles.Pop();
                        greyTiles.Dequeue();
                    }
                    else if (whiteTiles.Peek() + greyTiles.Peek() == 50)
                    {
                        if (!areas.ContainsKey("Oven"))
                        {
                            areas.Add("Oven", 0);
                        }
                        areas["Oven"]++;
                        whiteTiles.Pop();
                        greyTiles.Dequeue();
                    }
                    else if (whiteTiles.Peek() + greyTiles.Peek() == 60)
                    {
                        if (!areas.ContainsKey("Countertop"))
                        {
                            areas.Add("Countertop", 0);
                        }
                        areas["Countertop"]++;
                        whiteTiles.Pop();
                        greyTiles.Dequeue();
                    }
                    else if (whiteTiles.Peek() + greyTiles.Peek() == 70)
                    {
                        if (!areas.ContainsKey("Wall"))
                        {
                            areas.Add("Wall", 0);
                        }
                        areas["Wall"]++;
                        whiteTiles.Pop();
                        greyTiles.Dequeue();
                    }
                    else
                    {
                        if (!areas.ContainsKey("Floor"))
                        {
                            areas.Add("Floor", 0);
                        }
                        areas["Floor"]++;
                        whiteTiles.Pop();
                        greyTiles.Dequeue();
                    }
                }
            }
            if (whiteTiles.Count == 0)
            {
                Console.WriteLine("White tiles left: none");
            }
            else
            {
                Console.Write("White tiles left: ");
                Console.WriteLine(string.Join(", ", whiteTiles));
            }

            if (greyTiles.Count == 0)
            {
                Console.WriteLine("Grey tiles left: none");
            }
            else
            {
                Console.Write("Grey tiles left: ");
                Console.WriteLine(string.Join(", ", greyTiles));
            }

            foreach (var area in areas.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{area.Key}: {area.Value}");
            }
        }
    }
}
