namespace _02.BlindMansBuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = dimensions[0];
            int m = dimensions[1];

            string[,] field = new string[n, m];

            int blindRowIndex = -1;
            int blindColIndex = -1;

            int moves = 0;
            int touchedOpponents = 0;

            for (int row = 0; row < n; row++)
            {
                string[] cols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < m; col++)
                {
                    field[row,col] = cols[col];
                    if (cols[col] == "B")
                    {
                        blindRowIndex = row;
                        blindColIndex = col;
                    }
                    
                }
            }

            string cmd;

            while ((cmd = Console.ReadLine()) != "Finish")
            {
                if (cmd == "left")
                {
                    if (blindColIndex - 1 >=0 && field[blindRowIndex, blindColIndex - 1] != "O")
                    {
                        blindColIndex--;
                        moves++;

                    }
                }
                else if (cmd == "right")
                {
                    if (blindColIndex + 1 < m && field[blindRowIndex, blindColIndex + 1] != "O")
                    {
                        blindColIndex++;
                        moves++;
                    }
                }
                else if (cmd == "up")
                {
                    if (blindRowIndex - 1 >= 0 && field[blindRowIndex - 1, blindColIndex] != "O")
                    {
                        blindRowIndex--;
                        moves++;
                    }
                }
                else if (cmd == "down")
                {
                    if (blindRowIndex + 1 < n && field[blindRowIndex + 1, blindColIndex] != "O")
                    {
                        blindRowIndex++;
                        moves++;
                    }
                }
                if (field[blindRowIndex,blindColIndex] == "P")
                {
                    field[blindRowIndex, blindColIndex] = "-";
                    touchedOpponents++;
                    if (touchedOpponents == 3)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("Game over!");
            Console.WriteLine($"Touched opponents: {touchedOpponents} Moves made: {moves}");
        }
    }
}