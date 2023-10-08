namespace _05.GenericCountMethodStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                box.Items.Add(input);
                               
            }
            string elementToCompare = Console.ReadLine();

            Console.WriteLine(box.Counter(elementToCompare));

           
        }
    }
}