namespace _01.UniqueUsernames
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();

            for (int i = 1; i <= n; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }
            foreach (string currName in names)
            {
                Console.WriteLine(currName);
            }
        }
    }
}