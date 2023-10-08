namespace _07.Tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            string[] personAndAddress = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string fullName = personAndAddress[0] + " " + personAndAddress[1];
            string address = personAndAddress[2];
            Tuple<string, string> tuple1 = new Tuple<string, string>(fullName, address);

            Console.WriteLine(tuple1.Item1 + " -> " + tuple1.Item2);


            string[] personAndBeer = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string name = personAndBeer[0];
            int beers = int.Parse(personAndBeer[1]);
            Tuple<string, int> tuple2 = new Tuple<string, int>(name, beers);

            Console.WriteLine(tuple2.Item1 + " -> " + tuple2.Item2);


            string[] intAndDouble = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int num1 = int.Parse(intAndDouble[0]);
            double num2 = double.Parse(intAndDouble[1]);
            Tuple<int, double> tuple3 = new Tuple<int, double>(num1, num2);

            Console.WriteLine(tuple3.Item1 + " -> " + tuple3.Item2);

        }
    }
}