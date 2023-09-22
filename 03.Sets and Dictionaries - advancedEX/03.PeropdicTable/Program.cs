namespace _03.PeropdicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> elements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string sequence = Console.ReadLine();
                List<string> sequenceAsList = sequence.Split().ToList();
                foreach (string element in sequenceAsList)
                {
                    elements.Add(element);
                }
            }

            Console.WriteLine(string.Join(" ", elements));
        }
    }
}