using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.MealPlan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> meals = new Queue<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));
            Stack<int> calories = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            int numberOfMeals = meals.Count();

            while (meals.Count > 0 && calories.Count > 0)
            {
                int mealCalories = 0;
                if (meals.Peek() == "salad")
                {
                    mealCalories = 350;
                }
                else if (meals.Peek() == "soup")
                {
                    mealCalories = 490;
                }
                else if (meals.Peek() == "pasta")
                {
                    mealCalories = 680;
                }
                else if (meals.Peek() == "steak")
                {
                    mealCalories = 790;
                }
                meals.Dequeue();

                if (calories.Peek() - mealCalories == 0)
                {
                    calories.Pop();
                }
                else if (calories.Peek() - mealCalories > 0)
                {
                    calories.Push(calories.Pop() - mealCalories);
                }
                else if (calories.Peek() - mealCalories < 0)
                {
                    if (calories.Count == 1)
                    {
                        calories.Pop();
                        break;
                    }
                    else
                    {
                        mealCalories -= calories.Pop();
                        calories.Push(calories.Pop() - mealCalories);
                    }
                    
                }
            }

            if (meals.Count == 0)
            {
                Console.WriteLine($"John had {numberOfMeals} meals.");
                Console.Write("For the next few days, he can eat ");
                Console.Write(string.Join(", ", calories));
                Console.WriteLine(" calories.");
            }
            if (calories.Count == 0)
            {
                Console.WriteLine($"John ate enough, he had {numberOfMeals - meals.Count} meals.");
                Console.Write("Meals left: ");
                Console.Write(string.Join(", ", meals) + ".");
            }
        }
    }
}
