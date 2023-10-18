namespace _02.TheSquirrel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[,] field = new string[n, n];

            int hazelnutsCount = 0;

            int rowSquirrelIndex = 0;
            int colSquirrelIndex = 0;
            List<string> cmd = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int row = 0; row < n; row++)
            {
                char[] cols = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    field[row, col] = cols[col].ToString();

                    if (cols[col].ToString() == "s")
                    {
                        rowSquirrelIndex = row;
                        colSquirrelIndex = col;
                    }
                }
            }

            bool notCollectedAllHazelnuts = true;

            while (cmd.Count > 0)
            {
                if (cmd[0] == "left")
                {
                    if (colSquirrelIndex - 1 < 0)
                    {
                        field[rowSquirrelIndex, colSquirrelIndex] = "*";
                        Console.WriteLine("The squirrel is out of the field.");
                        Console.WriteLine($"Hazelnuts collected: {hazelnutsCount}");
                        notCollectedAllHazelnuts = false;
                        break;
                    }
                    field[rowSquirrelIndex, colSquirrelIndex] = "*";
                    colSquirrelIndex--;
                }
                else if (cmd[0] == "right")
                {
                    if (colSquirrelIndex + 1 >= n)
                    {
                        field[rowSquirrelIndex, colSquirrelIndex] = "*";
                        Console.WriteLine("The squirrel is out of the field.");
                        Console.WriteLine($"Hazelnuts collected: {hazelnutsCount}");
                        notCollectedAllHazelnuts = false;
                        break;
                    }
                    field[rowSquirrelIndex, colSquirrelIndex] = "*";
                    colSquirrelIndex++;
                }
                else if (cmd[0] == "up")
                {
                    if (rowSquirrelIndex - 1 < 0)
                    {
                        field[rowSquirrelIndex, colSquirrelIndex] = "*";
                        Console.WriteLine("The squirrel is out of the field.");
                        Console.WriteLine($"Hazelnuts collected: {hazelnutsCount}");
                        notCollectedAllHazelnuts = false;
                        break;
                    }
                    field[rowSquirrelIndex, colSquirrelIndex] = "*";
                    rowSquirrelIndex--;
                }
                else if (cmd[0] == "down")
                {
                    if (rowSquirrelIndex + 1 >= n)
                    {
                        field[rowSquirrelIndex, colSquirrelIndex] = "*";
                        Console.WriteLine("The squirrel is out of the field.");
                        Console.WriteLine($"Hazelnuts collected: {hazelnutsCount}");
                        notCollectedAllHazelnuts = false;
                        break;
                    }
                    field[rowSquirrelIndex, colSquirrelIndex] = "*";
                    rowSquirrelIndex++;
                }

                if (field[rowSquirrelIndex, colSquirrelIndex] == "t")
                {
                    Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
                    Console.WriteLine($"Hazelnuts collected: {hazelnutsCount}");
                    notCollectedAllHazelnuts = false;
                    break;
                }
                if (field[rowSquirrelIndex, colSquirrelIndex] == "h")
                {
                    hazelnutsCount++;
                    field[rowSquirrelIndex, colSquirrelIndex] = "*";
                    if (hazelnutsCount == 3)
                    {
                        Console.WriteLine("Good job! You have collected all hazelnuts!");
                        Console.WriteLine($"Hazelnuts collected: {hazelnutsCount}");
                        notCollectedAllHazelnuts = false;
                        break;
                    }
                    
                }
                cmd.RemoveAt(0);
                
            }
            if (notCollectedAllHazelnuts)
            {
                Console.WriteLine("There are more hazelnuts to collect.");
                Console.WriteLine($"Hazelnuts collected: {hazelnutsCount}");
            }
        }
    }
}