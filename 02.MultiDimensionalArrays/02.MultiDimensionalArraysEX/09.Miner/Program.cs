namespace _09.Miner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);           
            int totalCoalsOnTheField = 0;
            int minerPositionRow = -1;
            int minerPositionCol = -1;
            bool coalsLeft = true;

            char[,] field = new char[n, n];

            for (int row = 0; row < field.GetLength(0); row++) // GetLength is the same as n in this case, matter of prefference which one to use
            {
                char[] currRowToImplement = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < field.GetLength(1); col++)
                {                 
                    field[row,col] = currRowToImplement[col];
                    if (currRowToImplement[col] == 's')
                    {
                        minerPositionRow = row;
                        minerPositionCol = col;
                    }
                    else if (currRowToImplement[col] == 'c')
                    {
                        totalCoalsOnTheField++;
                    }
                }
            }

            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == "left" && minerPositionCol - 1 >= 0)
                {
                    minerPositionCol--;
                    if (field[minerPositionRow, minerPositionCol] == 'c')
                    {
                        totalCoalsOnTheField--;
                        if (totalCoalsOnTheField == 0)
                        {
                            Console.WriteLine($"You collected all coals! ({minerPositionRow}, {minerPositionCol})");
                            coalsLeft = false;
                            break;
                        }

                       field[minerPositionRow, minerPositionCol] = '*';
                    }
                    else if (field[minerPositionRow, minerPositionCol] == 'e')
                    {
                        Console.WriteLine($"Game over! ({minerPositionRow}, {minerPositionCol})");
                        coalsLeft = false;
                        break;
                    }

                }
                else if (commands[i] == "right" && minerPositionCol + 1 < field.GetLength(0))
                {
                    minerPositionCol++;
                    if (field[minerPositionRow, minerPositionCol] == 'c')
                    {
                        totalCoalsOnTheField--;
                        if (totalCoalsOnTheField == 0)
                        {
                            Console.WriteLine($"You collected all coals! ({minerPositionRow}, {minerPositionCol})");
                            coalsLeft = false;
                            break;
                        }
                        field[minerPositionRow, minerPositionCol] = '*';
                    }
                    else if (field[minerPositionRow, minerPositionCol] == 'e')
                    {
                        Console.WriteLine($"Game over! ({minerPositionRow}, {minerPositionCol})");
                        coalsLeft = false;
                        break;
                    }

                }
                else if (commands[i] == "up" && minerPositionRow-1 >= 0)
                {
                    minerPositionRow--;
                    if (field[minerPositionRow, minerPositionCol] == 'c')
                    {
                        totalCoalsOnTheField--;
                        if (totalCoalsOnTheField == 0)
                        {
                            Console.WriteLine($"You collected all coals! ({minerPositionRow}, {minerPositionCol})");
                            coalsLeft = false;
                            break;
                        }
                        field[minerPositionRow, minerPositionCol] = '*';
                    }
                    else if (field[minerPositionRow, minerPositionCol] == 'e')
                    {
                        Console.WriteLine($"Game over! ({minerPositionRow}, {minerPositionCol})");
                        coalsLeft = false;
                        break;
                    }
                }
                else if (commands[i] == "down" && minerPositionRow + 1 < field.GetLength(1))
                {
                    minerPositionRow++;
                    if (field[minerPositionRow, minerPositionCol] == 'c')
                    {
                        totalCoalsOnTheField--;
                        if (totalCoalsOnTheField == 0)
                        {
                            Console.WriteLine($"You collected all coals! ({minerPositionRow}, {minerPositionCol})");
                            coalsLeft = false;
                            break;
                        }
                        field[minerPositionRow, minerPositionCol] = '*';
                    }
                    else if (field[minerPositionRow, minerPositionCol] == 'e')
                    {
                        Console.WriteLine($"Game over! ({minerPositionRow}, {minerPositionCol})");
                        coalsLeft = false;
                        break;
                    }
                }
                
            }
            if (coalsLeft)
            {
                Console.WriteLine($"{totalCoalsOnTheField} coals left. ({minerPositionRow}, {minerPositionCol})");
            }
        }
    }
}