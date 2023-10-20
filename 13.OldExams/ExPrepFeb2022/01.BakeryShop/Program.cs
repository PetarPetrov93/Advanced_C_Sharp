using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BakeryShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<double> water = new Queue<double>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray());
            Stack<double> flour = new Stack<double>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray());

            Dictionary<string, int> products = new Dictionary<string, int>();

            while (water.Count > 0 && flour.Count > 0)
            {
                double currWater = water.Dequeue();
                double currFlour = flour.Pop();

                double percWater = currWater * 100 / (currWater + currFlour);
                double percFlour = currFlour * 100 / (currWater + currFlour);

                if (percWater == 50 && percFlour == 50)
                {
                    if (!products.ContainsKey("Croissant"))
                    {
                        products.Add("Croissant", 0);
                    }
                    products["Croissant"]++;
                }
                else if (percWater == 40 && percFlour == 60)
                {
                    if (!products.ContainsKey("Muffin"))
                    {
                        products.Add("Muffin", 0);
                    }
                    products["Muffin"]++;
                }
                else if (percWater == 30 && percFlour == 70)
                {
                    if (!products.ContainsKey("Baguette"))
                    {
                        products.Add("Baguette", 0);
                    }
                    products["Baguette"]++;
                }
                else if (percWater == 20 && percFlour == 80)
                {
                    if (!products.ContainsKey("Bagel"))
                    {
                        products.Add("Bagel", 0);
                    }
                    products["Bagel"]++;
                }
                else
                {
                    flour.Push(currFlour - currWater);
                    if (!products.ContainsKey("Croissant"))
                    {
                        products.Add("Croissant", 0);
                    }
                    products["Croissant"]++;
                }
            }
            foreach (var product in products.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{product.Key}: {product.Value}");
            }

            if (water.Count <= 0)
            {
                Console.WriteLine("Water left: None");
            }
            else
            {
                Console.WriteLine("Water left: " + string.Join(", ", water));
            }
            if (flour.Count <= 0)
            {
                Console.WriteLine("Flour left: None");
            }
            else
            {
                Console.WriteLine("Flour left: " + string.Join(", ", flour));
            }
        }
    }
}
