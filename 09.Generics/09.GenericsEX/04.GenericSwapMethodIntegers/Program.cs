namespace _04.GenericSwapMethodIntegers
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                box.Items.Add(input);
                               
            }

            int[] positions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            box.SwapElements(positions[0], positions[1]);

            Console.WriteLine(box);
        }
    }
}
