namespace _06.EqualityLogic
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<Person> customHashSet = new HashSet<Person>();
            SortedSet<Person> customSortedSet = new SortedSet<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Person person = new(input[0], int.Parse(input[1]));
                customHashSet.Add(person);
                customSortedSet.Add(person);
            }
            Console.WriteLine(customHashSet.Count());
            Console.WriteLine(customSortedSet.Count());
        }
    }
}