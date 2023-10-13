using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingSystem
{
    public class VendingMachine
    {
        public VendingMachine(int buttonCapacity)
        {
            ButtonCapacity = buttonCapacity;
            Drinks = new List<Drink>();
        }
        public int ButtonCapacity { get; set; }
        public List<Drink> Drinks { get; set; }
        public int GetCount { get { return Drinks.Count; } } // not sure if I need a setter for this one
            
        public void AddDrink(Drink drink)
        {
            if (Drinks.Count < ButtonCapacity)
            {
                Drinks.Add(drink);
            }
        }

        public bool RemoveDrink(string drink)
        {
            if (Drinks.Any(item => item.Name == drink))
            {
                Drinks.RemoveAll(item => item.Name == drink); // can do it with a new item Drink = item.Name and then remove Drink
                return true;
            }
            return false;
        }

        public Drink GetLongest()
        {
            Drink drink;// = new Drink("", 0, -1);

            drink = Drinks.OrderByDescending(item => item.Volume).FirstOrDefault();

            return drink;
        }

        public Drink GetCheapest()
        {
            Drink drink;

            drink = Drinks.OrderBy(item => item.Price).FirstOrDefault();

            return drink;
        }

        public string BuyDrink(string drink)
        {
            return Drinks.FirstOrDefault(item => item.Name == drink).ToString();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Drinks available:");
            foreach (Drink drink in Drinks)
            {
                sb.AppendLine(drink.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
