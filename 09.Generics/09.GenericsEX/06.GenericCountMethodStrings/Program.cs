namespace _06.GenericCountMethodDouble
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();

            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());

                box.Items.Add(input);
                               
            }
            double elementToCompare = double.Parse(Console.ReadLine());

            Console.WriteLine(box.Counter(elementToCompare));

           
        }
    }
}