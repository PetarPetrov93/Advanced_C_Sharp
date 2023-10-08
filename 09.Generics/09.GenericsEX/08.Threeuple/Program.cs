namespace _08.Threeuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] personAndAddress = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string fullName = personAndAddress[0] + " " + personAndAddress[1];
            string address = personAndAddress[2];
            string[] town = personAndAddress.Skip(3).ToArray();
            string townName = string.Join(" ", town);
             

            Threeuple<string, string, string> threeuple1 = new Threeuple<string, string, string>(fullName, address, townName);

            Console.WriteLine(threeuple1.Item1 + " -> " + threeuple1.Item2 + " -> " + threeuple1.Item3);


            string[] personAndBeer = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string name = personAndBeer[0];
            int beers = int.Parse(personAndBeer[1]);
            string drunkOrNot = personAndBeer[2];
            bool isDrunk = false;
            if (drunkOrNot == "drunk")
            {
                isDrunk = true;
            }

            Threeuple<string, int, bool> threeuple2 = new Threeuple<string, int, bool>(name, beers, isDrunk);

            Console.WriteLine(threeuple2.Item1 + " -> " + threeuple2.Item2 + " -> " + threeuple2.Item3);


            string[] nameBalanceBank = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string accHolder = nameBalanceBank[0];
            double balance = double.Parse(nameBalanceBank[1]);
            string bank = nameBalanceBank[2];

            Threeuple<string, double, string> threeuple3 = new Threeuple<string, double, string>(accHolder, balance, bank);

            Console.WriteLine(threeuple3.Item1 + " -> " + threeuple3.Item2 + " -> " + threeuple3.Item3);
        }
    }
}