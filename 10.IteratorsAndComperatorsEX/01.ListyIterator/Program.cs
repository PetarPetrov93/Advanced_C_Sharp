namespace _01._ListyIterator
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Skip(1).ToList();

            ListyIterator<string> data = new();
            data.Create(items);

            string cmd;

            while ((cmd = Console.ReadLine())!= "END")
            {
                if (cmd == "Move")
                {
                    Console.WriteLine(data.Move());
                }
                else if (cmd == "Print")
                {
                    data.Print();
                }
                else if (cmd == "HasNext")
                {
                    Console.WriteLine(data.HasNext());
                }
            }

        }
    }
}