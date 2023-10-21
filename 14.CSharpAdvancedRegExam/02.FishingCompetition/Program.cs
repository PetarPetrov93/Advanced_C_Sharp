namespace _02.FishingCompetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] area = new char[n,n];

            int collectedFish = 0;

            int shipRow = -1;
            int shipCol = -1;

            for (int row = 0; row < n; row++)
            {
                char[] cols = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    area[row, col] = cols[col];
                    if (cols[col] == 'S')
                    {
                        shipRow = row;
                        shipCol = col;
                    }
                }
            }

            string cmd;
            bool whirlpool = false;
            while ((cmd = Console.ReadLine()) != "collect the nets")
            {
                area[shipRow, shipCol] = '-';

                if (cmd == "left")
                {
                    if (shipCol - 1 < 0)
                    {
                        shipCol = n - 1;
                    }
                    else
                    {
                        shipCol--;
                    }
                    
                }
                else if (cmd == "right")
                {
                    if (shipCol + 1 >= n)
                    {
                        shipCol = 0;
                    }
                    else
                    {
                        shipCol++;
                    }
                }
                else if (cmd == "up")
                {
                    if (shipRow - 1 < 0)
                    {
                        shipRow = n - 1;
                    }
                    else
                    {
                        shipRow--;
                    }
                }
                else if (cmd == "down")
                {
                    if (shipRow + 1 >= n)
                    {
                        shipRow = 0;
                    }
                    else
                    {
                        shipRow++;
                    }
                }
                if (area[shipRow, shipCol] == 'W')
                {
                    whirlpool = true;
                    collectedFish = 0;
                    Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{shipRow},{shipCol}]");
                    break;
                }
                else if (char.IsDigit(area[shipRow, shipCol]))
                {
                    collectedFish += int.Parse(area[shipRow, shipCol].ToString());
                }
            }
            if (!whirlpool)
            {
                area[shipRow, shipCol] = 'S';
                if (collectedFish >= 20)
                {
                    Console.WriteLine("Success! You managed to reach the quota!");
                }
                else
                {
                    Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {20 - collectedFish} tons of fish more.");
                }
                if (collectedFish > 0)
                {
                    Console.WriteLine($"Amount of fish caught: {collectedFish} tons.");
                }
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        Console.Write(area[row,col]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}